'
'
'=============Drive Listener ======================
Class DriveChangeListener : Inherits NativeWindow

    Public Event DriveAdded(ByVal e As String)
    Public Event DriveRemoved(ByVal e As String)

    Private parent As Form

    Public Sub New(ByVal parent As Form)
        AddHandler parent.HandleCreated, AddressOf Me.OnHandleCreated
        AddHandler parent.HandleDestroyed, AddressOf Me.OnHandleDestroyed

    End Sub

    Private Sub OnHandleCreated(ByVal sender As Object, ByVal e As EventArgs)
        AssignHandle(CType(sender, Form).Handle)
    End Sub

    Private Sub OnHandleDestroyed(ByVal sender As Object, ByVal e As EventArgs)
        ReleaseHandle()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = &H219 Then
            Select Case CInt(m.WParam)
                Case &H8000 ' Drive added
                    HandleDriveChanged(m, True)
                Case &H8004 ' Drive removed
                    HandleDriveChanged(m, False)
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub HandleDriveChanged(ByVal m As Message, ByVal DriveAdded As Boolean)
        Dim DEV_BROADCAST_HDR_header(2) As Integer
        Runtime.InteropServices.Marshal.Copy(m.LParam, DEV_BROADCAST_HDR_header, 0, 2)
        Dim StructLength = DEV_BROADCAST_HDR_header(0) \ 4
        Dim DEV_BROADCAST_HDR(StructLength) As Integer
        Runtime.InteropServices.Marshal.Copy(m.LParam, DEV_BROADCAST_HDR, 0, StructLength)
        Dim Drive As Integer = 1
        For x As Integer = 1 To 26
            If (DEV_BROADCAST_HDR(3) And Drive) <> 0 Then
                Dim DrvName As String = Chr(64 + x) & ":\"
                If DriveAdded Then
                    RaiseEvent DriveAdded(DrvName)
                Else
                    RaiseEvent DriveRemoved(DrvName)
                End If
                Exit For
            Else
                Drive <<= 1
            End If
        Next
    End Sub

End Class