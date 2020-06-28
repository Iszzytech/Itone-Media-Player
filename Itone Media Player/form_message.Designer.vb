<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_message
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_message))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.Label2_Message = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_video_playlist = New Guna.UI.WinForms.GunaButton()
        Me.btn_audio_playlist = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.Label_Message = New System.Windows.Forms.Label()
        Me.BunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.GunaImageButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(419, 37)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(107, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Itone Media Player Alert"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(58, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = CType(resources.GetObject("GunaImageButton1.Image"), System.Drawing.Image)
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaImageButton1.Location = New System.Drawing.Point(386, 8)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton1.Size = New System.Drawing.Size(21, 23)
        Me.GunaImageButton1.TabIndex = 0
        '
        'Label2_Message
        '
        Me.Label2_Message.AutoSize = True
        Me.Label2_Message.BackColor = System.Drawing.Color.Transparent
        Me.Label2_Message.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Label2_Message.ForeColor = System.Drawing.Color.White
        Me.Label2_Message.Location = New System.Drawing.Point(190, 19)
        Me.Label2_Message.Name = "Label2_Message"
        Me.Label2_Message.Size = New System.Drawing.Size(34, 13)
        Me.Label2_Message.TabIndex = 1
        Me.Label2_Message.Text = "Alert"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_video_playlist)
        Me.Panel2.Controls.Add(Me.btn_audio_playlist)
        Me.Panel2.Controls.Add(Me.Label2_Message)
        Me.Panel2.Controls.Add(Me.GunaButton2)
        Me.Panel2.Controls.Add(Me.GunaButton1)
        Me.Panel2.Controls.Add(Me.Label_Message)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(419, 164)
        Me.Panel2.TabIndex = 1
        '
        'btn_video_playlist
        '
        Me.btn_video_playlist.AnimationHoverSpeed = 0.07!
        Me.btn_video_playlist.AnimationSpeed = 0.03!
        Me.btn_video_playlist.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_video_playlist.BaseColor = System.Drawing.Color.Transparent
        Me.btn_video_playlist.BorderColor = System.Drawing.Color.Black
        Me.btn_video_playlist.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_video_playlist.FocusedColor = System.Drawing.Color.Empty
        Me.btn_video_playlist.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.btn_video_playlist.ForeColor = System.Drawing.Color.White
        Me.btn_video_playlist.Image = Global.Itone_Media_Player.My.Resources.Resources.vidcam
        Me.btn_video_playlist.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_video_playlist.Location = New System.Drawing.Point(1, 48)
        Me.btn_video_playlist.Name = "btn_video_playlist"
        Me.btn_video_playlist.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btn_video_playlist.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_video_playlist.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_video_playlist.OnHoverImage = Nothing
        Me.btn_video_playlist.OnPressedColor = System.Drawing.Color.Black
        Me.btn_video_playlist.Size = New System.Drawing.Size(179, 30)
        Me.btn_video_playlist.TabIndex = 10
        Me.btn_video_playlist.Text = "  Switch To Video Playlist"
        '
        'btn_audio_playlist
        '
        Me.btn_audio_playlist.AnimationHoverSpeed = 0.07!
        Me.btn_audio_playlist.AnimationSpeed = 0.03!
        Me.btn_audio_playlist.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_audio_playlist.BaseColor = System.Drawing.Color.Transparent
        Me.btn_audio_playlist.BorderColor = System.Drawing.Color.Black
        Me.btn_audio_playlist.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_audio_playlist.FocusedColor = System.Drawing.Color.Empty
        Me.btn_audio_playlist.Font = New System.Drawing.Font("Trebuchet MS", 8.0!)
        Me.btn_audio_playlist.ForeColor = System.Drawing.Color.White
        Me.btn_audio_playlist.Image = Global.Itone_Media_Player.My.Resources.Resources.audiofile
        Me.btn_audio_playlist.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_audio_playlist.Location = New System.Drawing.Point(1, 9)
        Me.btn_audio_playlist.Name = "btn_audio_playlist"
        Me.btn_audio_playlist.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btn_audio_playlist.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_audio_playlist.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_audio_playlist.OnHoverImage = Nothing
        Me.btn_audio_playlist.OnPressedColor = System.Drawing.Color.Black
        Me.btn_audio_playlist.Size = New System.Drawing.Size(181, 30)
        Me.btn_audio_playlist.TabIndex = 9
        Me.btn_audio_playlist.Text = "Switch To Audio Playlist"
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.DarkSeaGreen
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(229, 122)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(108, 30)
        Me.GunaButton2.TabIndex = 5
        Me.GunaButton2.Text = "Play Again"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.DarkSeaGreen
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(44, 122)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(102, 30)
        Me.GunaButton1.TabIndex = 4
        Me.GunaButton1.Text = "Ok"
        '
        'Label_Message
        '
        Me.Label_Message.AutoSize = True
        Me.Label_Message.BackColor = System.Drawing.Color.Transparent
        Me.Label_Message.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Label_Message.ForeColor = System.Drawing.Color.White
        Me.Label_Message.Location = New System.Drawing.Point(190, 58)
        Me.Label_Message.Name = "Label_Message"
        Me.Label_Message.Size = New System.Drawing.Size(34, 13)
        Me.Label_Message.TabIndex = 2
        Me.Label_Message.Text = "Alert"
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 0
        '
        'form_message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 201)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_message"
        Me.Text = "form_message"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label_Message As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2_Message As Label
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_video_playlist As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_audio_playlist As Guna.UI.WinForms.GunaButton
End Class
