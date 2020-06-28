<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tab_Audio_Command
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_microphone = New Guna.UI.WinForms.GunaButton()
        Me.btn_recording = New Guna.UI.WinForms.GunaButton()
        Me.btn_listening = New Guna.UI.WinForms.GunaButton()
        Me.btn_volume = New Guna.UI.WinForms.GunaButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Tab_Volume1 = New Itone_Media_Player.Tab_Volume()
        Me.Tab_Listening1 = New Itone_Media_Player.Tab_Listening()
        Me.Tab_Recording1 = New Itone_Media_Player.Tab_Recording()
        Me.Tab_Microphone1 = New Itone_Media_Player.Tab_Microphone()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_microphone)
        Me.Panel1.Controls.Add(Me.btn_recording)
        Me.Panel1.Controls.Add(Me.btn_listening)
        Me.Panel1.Controls.Add(Me.btn_volume)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 58)
        Me.Panel1.TabIndex = 1
        '
        'btn_microphone
        '
        Me.btn_microphone.AnimationHoverSpeed = 0.07!
        Me.btn_microphone.AnimationSpeed = 0.03!
        Me.btn_microphone.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_microphone.BorderColor = System.Drawing.Color.Black
        Me.btn_microphone.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_microphone.FocusedColor = System.Drawing.Color.Empty
        Me.btn_microphone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_microphone.ForeColor = System.Drawing.Color.White
        Me.btn_microphone.Image = Nothing
        Me.btn_microphone.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_microphone.Location = New System.Drawing.Point(485, 9)
        Me.btn_microphone.Name = "btn_microphone"
        Me.btn_microphone.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_microphone.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_microphone.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_microphone.OnHoverImage = Nothing
        Me.btn_microphone.OnPressedColor = System.Drawing.Color.Black
        Me.btn_microphone.Size = New System.Drawing.Size(110, 39)
        Me.btn_microphone.TabIndex = 3
        Me.btn_microphone.Text = "Microphone"
        Me.btn_microphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_recording
        '
        Me.btn_recording.AnimationHoverSpeed = 0.07!
        Me.btn_recording.AnimationSpeed = 0.03!
        Me.btn_recording.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_recording.BorderColor = System.Drawing.Color.Black
        Me.btn_recording.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_recording.FocusedColor = System.Drawing.Color.Empty
        Me.btn_recording.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_recording.ForeColor = System.Drawing.Color.White
        Me.btn_recording.Image = Nothing
        Me.btn_recording.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_recording.Location = New System.Drawing.Point(365, 9)
        Me.btn_recording.Name = "btn_recording"
        Me.btn_recording.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_recording.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_recording.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_recording.OnHoverImage = Nothing
        Me.btn_recording.OnPressedColor = System.Drawing.Color.Black
        Me.btn_recording.Size = New System.Drawing.Size(110, 39)
        Me.btn_recording.TabIndex = 2
        Me.btn_recording.Text = "Recording"
        Me.btn_recording.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_listening
        '
        Me.btn_listening.AnimationHoverSpeed = 0.07!
        Me.btn_listening.AnimationSpeed = 0.03!
        Me.btn_listening.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_listening.BorderColor = System.Drawing.Color.Black
        Me.btn_listening.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_listening.FocusedColor = System.Drawing.Color.Empty
        Me.btn_listening.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_listening.ForeColor = System.Drawing.Color.White
        Me.btn_listening.Image = Nothing
        Me.btn_listening.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_listening.Location = New System.Drawing.Point(245, 9)
        Me.btn_listening.Name = "btn_listening"
        Me.btn_listening.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_listening.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_listening.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_listening.OnHoverImage = Nothing
        Me.btn_listening.OnPressedColor = System.Drawing.Color.Black
        Me.btn_listening.Size = New System.Drawing.Size(110, 39)
        Me.btn_listening.TabIndex = 1
        Me.btn_listening.Text = "Listening"
        Me.btn_listening.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_volume
        '
        Me.btn_volume.AnimationHoverSpeed = 0.07!
        Me.btn_volume.AnimationSpeed = 0.03!
        Me.btn_volume.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_volume.BorderColor = System.Drawing.Color.Black
        Me.btn_volume.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_volume.FocusedColor = System.Drawing.Color.Empty
        Me.btn_volume.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_volume.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_volume.Image = Nothing
        Me.btn_volume.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_volume.Location = New System.Drawing.Point(125, 9)
        Me.btn_volume.Name = "btn_volume"
        Me.btn_volume.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_volume.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_volume.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_volume.OnHoverImage = Nothing
        Me.btn_volume.OnPressedColor = System.Drawing.Color.Black
        Me.btn_volume.Size = New System.Drawing.Size(110, 39)
        Me.btn_volume.TabIndex = 0
        Me.btn_volume.Text = "Volume"
        Me.btn_volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Tab_Volume1)
        Me.Panel2.Controls.Add(Me.Tab_Listening1)
        Me.Panel2.Controls.Add(Me.Tab_Recording1)
        Me.Panel2.Controls.Add(Me.Tab_Microphone1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(721, 315)
        Me.Panel2.TabIndex = 2
        '
        'Tab_Volume1
        '
        Me.Tab_Volume1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Volume1.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Volume1.Name = "Tab_Volume1"
        Me.Tab_Volume1.Size = New System.Drawing.Size(721, 315)
        Me.Tab_Volume1.TabIndex = 0
        '
        'Tab_Listening1
        '
        Me.Tab_Listening1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Listening1.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Listening1.Name = "Tab_Listening1"
        Me.Tab_Listening1.Size = New System.Drawing.Size(721, 315)
        Me.Tab_Listening1.TabIndex = 1
        '
        'Tab_Recording1
        '
        Me.Tab_Recording1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Recording1.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Recording1.Name = "Tab_Recording1"
        Me.Tab_Recording1.Size = New System.Drawing.Size(721, 315)
        Me.Tab_Recording1.TabIndex = 2
        '
        'Tab_Microphone1
        '
        Me.Tab_Microphone1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Microphone1.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Microphone1.Name = "Tab_Microphone1"
        Me.Tab_Microphone1.Size = New System.Drawing.Size(721, 315)
        Me.Tab_Microphone1.TabIndex = 3
        '
        'Tab_Audio_Command
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Tab_Audio_Command"
        Me.Size = New System.Drawing.Size(721, 373)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_microphone As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_recording As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_listening As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_volume As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tab_Volume1 As Tab_Volume
    Friend WithEvents Tab_Listening1 As Tab_Listening
    Friend WithEvents Tab_Recording1 As Tab_Recording
    Friend WithEvents Tab_Microphone1 As Tab_Microphone
    'Friend WithEvents Tab_Volume1 As Tab_Volume
    'Friend WithEvents Tab_Listening1 As Tab_Listening
    'Friend WithEvents Tab_Recording1 As Tab_Recording
    'Friend WithEvents Tab_Microphone1 As Tab_Microphone
End Class
