<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudioLED
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.b_updateCOM = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.colorGroupConfiguration = New System.Windows.Forms.GroupBox()
        Me.shutdownButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.showPreview = New System.Windows.Forms.Panel()
        Me.tempColorPredefined = New Cyotek.Windows.Forms.ColorGrid()
        Me.ColorEditor1 = New Cyotek.Windows.Forms.ColorEditor()
        Me.ScreenColorPicker1 = New Cyotek.Windows.Forms.ScreenColorPicker()
        Me.ColorWheel1 = New Cyotek.Windows.Forms.ColorWheel()
        Me.colorUpdaterToCOM = New System.Windows.Forms.Timer(Me.components)
        Me.CEM = New Cyotek.Windows.Forms.ColorEditorManager()
        Me.COM = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.colorGroupConfiguration.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.b_updateCOM)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Devices list "
        '
        'b_updateCOM
        '
        Me.b_updateCOM.ForeColor = System.Drawing.Color.Black
        Me.b_updateCOM.Location = New System.Drawing.Point(7, 171)
        Me.b_updateCOM.Name = "b_updateCOM"
        Me.b_updateCOM.Size = New System.Drawing.Size(175, 29)
        Me.b_updateCOM.TabIndex = 1
        Me.b_updateCOM.Text = "Update devices"
        Me.b_updateCOM.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 18)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(175, 147)
        Me.ListBox1.TabIndex = 0
        '
        'colorGroupConfiguration
        '
        Me.colorGroupConfiguration.Controls.Add(Me.shutdownButton)
        Me.colorGroupConfiguration.Controls.Add(Me.Button1)
        Me.colorGroupConfiguration.Controls.Add(Me.TextBox1)
        Me.colorGroupConfiguration.Controls.Add(Me.showPreview)
        Me.colorGroupConfiguration.Controls.Add(Me.tempColorPredefined)
        Me.colorGroupConfiguration.Controls.Add(Me.ColorEditor1)
        Me.colorGroupConfiguration.Controls.Add(Me.ScreenColorPicker1)
        Me.colorGroupConfiguration.Controls.Add(Me.ColorWheel1)
        Me.colorGroupConfiguration.Enabled = False
        Me.colorGroupConfiguration.ForeColor = System.Drawing.Color.White
        Me.colorGroupConfiguration.Location = New System.Drawing.Point(216, 12)
        Me.colorGroupConfiguration.Name = "colorGroupConfiguration"
        Me.colorGroupConfiguration.Size = New System.Drawing.Size(577, 206)
        Me.colorGroupConfiguration.TabIndex = 1
        Me.colorGroupConfiguration.TabStop = False
        Me.colorGroupConfiguration.Text = " Color configuration "
        '
        'shutdownButton
        '
        Me.shutdownButton.ForeColor = System.Drawing.Color.Black
        Me.shutdownButton.Location = New System.Drawing.Point(485, 174)
        Me.shutdownButton.Name = "shutdownButton"
        Me.shutdownButton.Size = New System.Drawing.Size(85, 23)
        Me.shutdownButton.TabIndex = 6
        Me.shutdownButton.Text = "Power Off"
        Me.shutdownButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(388, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "PSync"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(388, 116)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 13)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Color temperature"
        '
        'showPreview
        '
        Me.showPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.showPreview.Location = New System.Drawing.Point(202, 108)
        Me.showPreview.Name = "showPreview"
        Me.showPreview.Size = New System.Drawing.Size(173, 89)
        Me.showPreview.TabIndex = 3
        '
        'tempColorPredefined
        '
        Me.tempColorPredefined.AutoAddColors = False
        Me.tempColorPredefined.Columns = 12
        Me.tempColorPredefined.Location = New System.Drawing.Point(387, 134)
        Me.tempColorPredefined.Name = "tempColorPredefined"
        Me.tempColorPredefined.Palette = Cyotek.Windows.Forms.ColorPalette.None
        Me.tempColorPredefined.SelectedCellStyle = Cyotek.Windows.Forms.ColorGridSelectedCellStyle.None
        Me.tempColorPredefined.ShowCustomColors = False
        Me.tempColorPredefined.Size = New System.Drawing.Size(187, 22)
        Me.tempColorPredefined.TabIndex = 2
        '
        'ColorEditor1
        '
        Me.ColorEditor1.Location = New System.Drawing.Point(388, 19)
        Me.ColorEditor1.Name = "ColorEditor1"
        Me.ColorEditor1.ShowAlphaChannel = False
        Me.ColorEditor1.Size = New System.Drawing.Size(180, 91)
        Me.ColorEditor1.TabIndex = 1
        '
        'ScreenColorPicker1
        '
        Me.ScreenColorPicker1.Color = System.Drawing.Color.Black
        Me.ScreenColorPicker1.Image = Global.StudioLED.My.Resources.Resources.ColorPicker_16x
        Me.ScreenColorPicker1.Location = New System.Drawing.Point(202, 15)
        Me.ScreenColorPicker1.Name = "ScreenColorPicker1"
        Me.ScreenColorPicker1.Size = New System.Drawing.Size(173, 89)
        '
        'ColorWheel1
        '
        Me.ColorWheel1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWheel1.Location = New System.Drawing.Point(6, 16)
        Me.ColorWheel1.Name = "ColorWheel1"
        Me.ColorWheel1.Size = New System.Drawing.Size(183, 182)
        Me.ColorWheel1.TabIndex = 0
        '
        'colorUpdaterToCOM
        '
        Me.colorUpdaterToCOM.Interval = 200
        '
        'CEM
        '
        Me.CEM.ColorEditor = Me.ColorEditor1
        Me.CEM.ColorGrid = Me.tempColorPredefined
        Me.CEM.ColorWheel = Me.ColorWheel1
        Me.CEM.ScreenColorPicker = Me.ScreenColorPicker1
        '
        'COM
        '
        Me.COM.ReadTimeout = 2000
        '
        'StudioLED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(805, 231)
        Me.Controls.Add(Me.colorGroupConfiguration)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StudioLED"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "StudioLED"
        Me.GroupBox1.ResumeLayout(False)
        Me.colorGroupConfiguration.ResumeLayout(False)
        Me.colorGroupConfiguration.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents b_updateCOM As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents colorGroupConfiguration As GroupBox
    Friend WithEvents colorUpdaterToCOM As Timer
    Friend WithEvents ScreenColorPicker1 As Cyotek.Windows.Forms.ScreenColorPicker
    Friend WithEvents ColorWheel1 As Cyotek.Windows.Forms.ColorWheel
    Friend WithEvents ColorEditor1 As Cyotek.Windows.Forms.ColorEditor
    Friend WithEvents CEM As Cyotek.Windows.Forms.ColorEditorManager
    Friend WithEvents tempColorPredefined As Cyotek.Windows.Forms.ColorGrid
    Friend WithEvents showPreview As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents shutdownButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents COM As IO.Ports.SerialPort
End Class
