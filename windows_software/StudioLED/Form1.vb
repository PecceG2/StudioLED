Imports System.IO

Public Class StudioLED
    Dim connectionStatus As Boolean
    Dim shuttingDownStatus As Boolean
    Private Sub StudioLED_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tempColorPredefined.Colors = New Cyotek.Windows.Forms.PaintNetPaletteSerializer().Deserialize(Path.Combine("C:\Users\pecce\Desktop\Laburo\Hardware\Foco-led-estudio\DesktopApp\StudioLED\StudioLED\palettes\temperatureColorPalette.txt"))
        connectionStatus = False
    End Sub


    Dim WithEvents DrChange As New DriveChangeListener(Me)

    Private Sub AddedDrive(ByVal e As String) Handles DrChange.DriveAdded
        GetSerialPortNames()
    End Sub

    Private Sub RemovedDrive(ByVal e As String) Handles DrChange.DriveRemoved
        GetSerialPortNames()
    End Sub




    Sub GetSerialPortNames()
        ' Show all available COM ports.
        ListBox1.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ListBox1.Items.Add(sp)
        Next
    End Sub

    Sub connectSerialPort(ComName As String)
        COM.PortName = ComName
        If COM.IsOpen = False Then
            Try
                COM.Open()
            Catch ex As Exception
                'Port does not exists (or bussy)
                GetSerialPortNames()
            End Try
        End If

        If COM.IsOpen = True Then
            serialConnected()
        Else
            disconnectSerialPort()
            b_updateCOM.Text = "Error al conectar"

        End If
    End Sub

    Sub disconnectSerialPort()
        If COM.IsOpen = True Then
            COM.Close()
        End If
        connectionStatus = False
        b_updateCOM.Text = "Actualizar Dispositivos"
        ListBox1.Enabled = True
        b_updateCOM.Enabled = True
        colorGroupConfiguration.Enabled = False
        colorUpdaterToCOM.Enabled = False
    End Sub
    Sub serialConnected()
        colorGroupConfiguration.Enabled = True
        ListBox1.Enabled = False
        b_updateCOM.Enabled = True
        connectionStatus = True
        colorUpdaterToCOM.Enabled = True
        b_updateCOM.Text = "Desconectar"
    End Sub
    Sub sendColorDataCOM(r As Int16, g As Int16, b As Int16)
        'R = Red color 0-255
        'G = Green color 0-255
        'B = Blue color 0-255
        Dim comstring As String

        ' Zero fix
        If (r < 100) Then
            If (r < 10) Then
                comstring = "00" + r.ToString
            Else
                comstring = "0" + r.ToString
            End If
        Else
            comstring = r.ToString
        End If

        comstring = comstring + ":"

        If (g < 100) Then
            If (g < 10) Then
                comstring = comstring + "00" + g.ToString
            Else
                comstring = comstring + "0" + g.ToString
            End If
        Else
            comstring = comstring + g.ToString
        End If

        comstring = comstring + ":"

        If (b < 100) Then
            If (b < 10) Then
                comstring = comstring + "00" + b.ToString
            Else
                comstring = comstring + "0" + b.ToString
            End If
        Else
            comstring = comstring + b.ToString
        End If
        ' End zero fix

        COM.WriteLine(comstring)
    End Sub

    Private Sub b_updateCOM_Click(sender As Object, e As EventArgs) Handles b_updateCOM.Click
        If connectionStatus = True Then
            'DISCONNECT PRESSED
            disconnectSerialPort()
        Else
            'UPDATE DEVICES PRESSED
            GetSerialPortNames()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox1.Enabled = False
        b_updateCOM.Enabled = False
        b_updateCOM.Text = "Conectando..."
        connectSerialPort(ListBox1.SelectedItem.ToString)
    End Sub

    Private Sub CEM_ColorChanged(sender As Object, e As EventArgs) Handles CEM.ColorChanged
        showPreview.BackColor = CEM.Color
    End Sub

    Private Sub shutdownButton_Click(sender As Object, e As EventArgs) Handles shutdownButton.Click
        If (shuttingDownStatus = False) Then
            colorUpdaterToCOM.Enabled = False
            sendColorDataCOM(0, 0, 0)
            shutdownButton.Text = "Encender"
            shuttingDownStatus = True
        Else
            colorUpdaterToCOM.Enabled = True
            shutdownButton.Text = "Apagar"
            shuttingDownStatus = False
        End If
    End Sub

    Private Sub colorUpdaterToCOM_Tick(sender As Object, e As EventArgs) Handles colorUpdaterToCOM.Tick
        sendColorDataCOM(CEM.Color.R, CEM.Color.G, CEM.Color.B)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim syncForm = New syncForm
        syncForm.Show()

    End Sub

End Class
