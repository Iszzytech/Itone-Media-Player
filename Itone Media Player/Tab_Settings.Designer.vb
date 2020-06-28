<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tab_Settings
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
        Me.btn_about = New Guna.UI.WinForms.GunaButton()
        Me.btn_audio_panel = New Guna.UI.WinForms.GunaButton()
        Me.btn_voice_assistant = New Guna.UI.WinForms.GunaButton()
        Me.btn_transparent = New Guna.UI.WinForms.GunaButton()
        Me.btn_themes = New Guna.UI.WinForms.GunaButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Tab_Themes1 = New Itone_Media_Player.Tab_Themes()
        Me.Tab_Transparent1 = New Itone_Media_Player.Tab_Transparent()
        Me.Tab_About1 = New Itone_Media_Player.Tab_About()
        Me.Tab_Voice_Assistant1 = New Itone_Media_Player.Tab_Voice_Assistant()
        Me.Tab_Audio_Command1 = New Itone_Media_Player.Tab_Audio_Command()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_about)
        Me.Panel1.Controls.Add(Me.btn_audio_panel)
        Me.Panel1.Controls.Add(Me.btn_voice_assistant)
        Me.Panel1.Controls.Add(Me.btn_transparent)
        Me.Panel1.Controls.Add(Me.btn_themes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 58)
        Me.Panel1.TabIndex = 0
        '
        'btn_about
        '
        Me.btn_about.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_about.AnimationHoverSpeed = 0.07!
        Me.btn_about.AnimationSpeed = 0.03!
        Me.btn_about.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_about.BorderColor = System.Drawing.Color.Black
        Me.btn_about.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_about.FocusedColor = System.Drawing.Color.Empty
        Me.btn_about.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_about.ForeColor = System.Drawing.Color.White
        Me.btn_about.Image = Nothing
        Me.btn_about.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_about.Location = New System.Drawing.Point(545, 9)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_about.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_about.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_about.OnHoverImage = Nothing
        Me.btn_about.OnPressedColor = System.Drawing.Color.Black
        Me.btn_about.Size = New System.Drawing.Size(110, 39)
        Me.btn_about.TabIndex = 4
        Me.btn_about.Text = "About"
        Me.btn_about.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_audio_panel
        '
        Me.btn_audio_panel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_audio_panel.AnimationHoverSpeed = 0.07!
        Me.btn_audio_panel.AnimationSpeed = 0.03!
        Me.btn_audio_panel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_audio_panel.BorderColor = System.Drawing.Color.Black
        Me.btn_audio_panel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_audio_panel.FocusedColor = System.Drawing.Color.Empty
        Me.btn_audio_panel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_audio_panel.ForeColor = System.Drawing.Color.White
        Me.btn_audio_panel.Image = Nothing
        Me.btn_audio_panel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_audio_panel.Location = New System.Drawing.Point(425, 9)
        Me.btn_audio_panel.Name = "btn_audio_panel"
        Me.btn_audio_panel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_audio_panel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_audio_panel.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_audio_panel.OnHoverImage = Nothing
        Me.btn_audio_panel.OnPressedColor = System.Drawing.Color.Black
        Me.btn_audio_panel.Size = New System.Drawing.Size(110, 39)
        Me.btn_audio_panel.TabIndex = 3
        Me.btn_audio_panel.Text = "Audio Panel"
        Me.btn_audio_panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_voice_assistant
        '
        Me.btn_voice_assistant.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_voice_assistant.AnimationHoverSpeed = 0.07!
        Me.btn_voice_assistant.AnimationSpeed = 0.03!
        Me.btn_voice_assistant.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_voice_assistant.BorderColor = System.Drawing.Color.Black
        Me.btn_voice_assistant.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_voice_assistant.FocusedColor = System.Drawing.Color.Empty
        Me.btn_voice_assistant.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_voice_assistant.ForeColor = System.Drawing.Color.White
        Me.btn_voice_assistant.Image = Nothing
        Me.btn_voice_assistant.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_voice_assistant.Location = New System.Drawing.Point(305, 9)
        Me.btn_voice_assistant.Name = "btn_voice_assistant"
        Me.btn_voice_assistant.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_voice_assistant.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_voice_assistant.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_voice_assistant.OnHoverImage = Nothing
        Me.btn_voice_assistant.OnPressedColor = System.Drawing.Color.Black
        Me.btn_voice_assistant.Size = New System.Drawing.Size(110, 39)
        Me.btn_voice_assistant.TabIndex = 2
        Me.btn_voice_assistant.Text = "Voice Assitant"
        Me.btn_voice_assistant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_transparent
        '
        Me.btn_transparent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_transparent.AnimationHoverSpeed = 0.07!
        Me.btn_transparent.AnimationSpeed = 0.03!
        Me.btn_transparent.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_transparent.BorderColor = System.Drawing.Color.Black
        Me.btn_transparent.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_transparent.FocusedColor = System.Drawing.Color.Empty
        Me.btn_transparent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_transparent.ForeColor = System.Drawing.Color.White
        Me.btn_transparent.Image = Nothing
        Me.btn_transparent.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_transparent.Location = New System.Drawing.Point(185, 9)
        Me.btn_transparent.Name = "btn_transparent"
        Me.btn_transparent.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_transparent.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_transparent.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_transparent.OnHoverImage = Nothing
        Me.btn_transparent.OnPressedColor = System.Drawing.Color.Black
        Me.btn_transparent.Size = New System.Drawing.Size(110, 39)
        Me.btn_transparent.TabIndex = 1
        Me.btn_transparent.Text = "Transparent"
        Me.btn_transparent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_themes
        '
        Me.btn_themes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_themes.AnimationHoverSpeed = 0.07!
        Me.btn_themes.AnimationSpeed = 0.03!
        Me.btn_themes.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_themes.BorderColor = System.Drawing.Color.Black
        Me.btn_themes.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_themes.FocusedColor = System.Drawing.Color.Empty
        Me.btn_themes.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_themes.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_themes.Image = Nothing
        Me.btn_themes.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_themes.Location = New System.Drawing.Point(65, 9)
        Me.btn_themes.Name = "btn_themes"
        Me.btn_themes.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_themes.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_themes.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_themes.OnHoverImage = Nothing
        Me.btn_themes.OnPressedColor = System.Drawing.Color.Black
        Me.btn_themes.Size = New System.Drawing.Size(110, 39)
        Me.btn_themes.TabIndex = 0
        Me.btn_themes.Text = "Themes"
        Me.btn_themes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Controls.Add(Me.Tab_Themes1)
        Me.Panel2.Controls.Add(Me.Tab_Transparent1)
        Me.Panel2.Controls.Add(Me.Tab_About1)
        Me.Panel2.Controls.Add(Me.Tab_Voice_Assistant1)
        Me.Panel2.Controls.Add(Me.Tab_Audio_Command1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(721, 203)
        Me.Panel2.TabIndex = 1
        '
        'Tab_Themes1
        '
        Me.Tab_Themes1.AutoScroll = True
        Me.Tab_Themes1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Themes1.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Themes1.Name = "Tab_Themes1"
        Me.Tab_Themes1.Size = New System.Drawing.Size(721, 203)
        Me.Tab_Themes1.TabIndex = 0
        '
        'Tab_Transparent1
        '
        Me.Tab_Transparent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Transparent1.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Transparent1.Name = "Tab_Transparent1"
        Me.Tab_Transparent1.Size = New System.Drawing.Size(721, 203)
        Me.Tab_Transparent1.TabIndex = 1
        '
        'Tab_About1
        '
        Me.Tab_About1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_About1.Location = New System.Drawing.Point(0, 0)
        Me.Tab_About1.Name = "Tab_About1"
        Me.Tab_About1.Size = New System.Drawing.Size(721, 203)
        Me.Tab_About1.TabIndex = 2
        '
        'Tab_Voice_Assistant1
        '
        Me.Tab_Voice_Assistant1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Voice_Assistant1.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Voice_Assistant1.Name = "Tab_Voice_Assistant1"
        Me.Tab_Voice_Assistant1.Size = New System.Drawing.Size(721, 203)
        Me.Tab_Voice_Assistant1.TabIndex = 3
        '
        'Tab_Audio_Command1
        '
        Me.Tab_Audio_Command1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Audio_Command1.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Audio_Command1.Name = "Tab_Audio_Command1"
        Me.Tab_Audio_Command1.Size = New System.Drawing.Size(721, 203)
        Me.Tab_Audio_Command1.TabIndex = 4
        '
        'Tab_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Tab_Settings"
        Me.Size = New System.Drawing.Size(721, 261)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_about As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_audio_panel As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_voice_assistant As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_transparent As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_themes As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tab_Themes1 As Tab_Themes
    Friend WithEvents Tab_Transparent1 As Tab_Transparent
    Friend WithEvents Tab_About1 As Tab_About
    Friend WithEvents Tab_Voice_Assistant1 As Tab_Voice_Assistant
    Friend WithEvents Tab_Audio_Command1 As Tab_Audio_Command
End Class
