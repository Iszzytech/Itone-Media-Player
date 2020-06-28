<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel_top = New System.Windows.Forms.Panel()
        Me.label_mediaPlayer = New Guna.UI.WinForms.GunaLabel()
        Me.btn_maximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel_left = New System.Windows.Forms.Panel()
        Me.btn_playlist_adjustment = New Guna.UI.WinForms.GunaButton()
        Me.btn_camera_playlist = New Guna.UI.WinForms.GunaButton()
        Me.btn_album_playlist = New Guna.UI.WinForms.GunaButton()
        Me.btn_favourites_playlist = New Guna.UI.WinForms.GunaButton()
        Me.btn_video_playlist = New Guna.UI.WinForms.GunaButton()
        Me.btn_audio_playlist = New Guna.UI.WinForms.GunaButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tab_Audio_Playlist1 = New Itone_Media_Player.Tab_Audio_Playlist()
        Me.Tab_Video_Playlist1 = New Itone_Media_Player.Tab_Video_Playlist()
        Me.Panel_top.SuspendLayout()
        CType(Me.btn_maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_left.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel_top
        '
        Me.Panel_top.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel_top.Controls.Add(Me.label_mediaPlayer)
        Me.Panel_top.Controls.Add(Me.btn_maximize)
        Me.Panel_top.Controls.Add(Me.btn_minimize)
        Me.Panel_top.Controls.Add(Me.btn_close)
        Me.Panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(799, 43)
        Me.Panel_top.TabIndex = 0
        '
        'label_mediaPlayer
        '
        Me.label_mediaPlayer.AutoSize = True
        Me.label_mediaPlayer.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.label_mediaPlayer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.label_mediaPlayer.Location = New System.Drawing.Point(350, 12)
        Me.label_mediaPlayer.Name = "label_mediaPlayer"
        Me.label_mediaPlayer.Size = New System.Drawing.Size(99, 20)
        Me.label_mediaPlayer.TabIndex = 15
        Me.label_mediaPlayer.Text = "Media Player"
        '
        'btn_maximize
        '
        Me.btn_maximize.BackColor = System.Drawing.Color.Transparent
        Me.btn_maximize.Image = Global.Itone_Media_Player.My.Resources.Resources.maximizecol
        Me.btn_maximize.ImageActive = Nothing
        Me.btn_maximize.Location = New System.Drawing.Point(756, 12)
        Me.btn_maximize.Name = "btn_maximize"
        Me.btn_maximize.Size = New System.Drawing.Size(17, 23)
        Me.btn_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_maximize.TabIndex = 6
        Me.btn_maximize.TabStop = False
        Me.btn_maximize.Zoom = 10
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.Image = Global.Itone_Media_Player.My.Resources.Resources.minimizecol
        Me.btn_minimize.ImageActive = Nothing
        Me.btn_minimize.Location = New System.Drawing.Point(733, 12)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(17, 23)
        Me.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_minimize.TabIndex = 5
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.Zoom = 10
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Image = Global.Itone_Media_Player.My.Resources.Resources.closecol
        Me.btn_close.ImageActive = Nothing
        Me.btn_close.Location = New System.Drawing.Point(710, 12)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(17, 23)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_close.TabIndex = 4
        Me.btn_close.TabStop = False
        Me.btn_close.Zoom = 10
        '
        'Panel_left
        '
        Me.Panel_left.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Panel_left.Controls.Add(Me.btn_playlist_adjustment)
        Me.Panel_left.Controls.Add(Me.btn_camera_playlist)
        Me.Panel_left.Controls.Add(Me.btn_album_playlist)
        Me.Panel_left.Controls.Add(Me.btn_favourites_playlist)
        Me.Panel_left.Controls.Add(Me.btn_video_playlist)
        Me.Panel_left.Controls.Add(Me.btn_audio_playlist)
        Me.Panel_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_left.Location = New System.Drawing.Point(0, 43)
        Me.Panel_left.Name = "Panel_left"
        Me.Panel_left.Size = New System.Drawing.Size(196, 390)
        Me.Panel_left.TabIndex = 1
        '
        'btn_playlist_adjustment
        '
        Me.btn_playlist_adjustment.AnimationHoverSpeed = 0.07!
        Me.btn_playlist_adjustment.AnimationSpeed = 0.03!
        Me.btn_playlist_adjustment.BaseColor = System.Drawing.Color.Transparent
        Me.btn_playlist_adjustment.BorderColor = System.Drawing.Color.Black
        Me.btn_playlist_adjustment.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_playlist_adjustment.FocusedColor = System.Drawing.Color.Empty
        Me.btn_playlist_adjustment.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btn_playlist_adjustment.ForeColor = System.Drawing.Color.White
        Me.btn_playlist_adjustment.Image = Global.Itone_Media_Player.My.Resources.Resources.settingicon
        Me.btn_playlist_adjustment.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_playlist_adjustment.Location = New System.Drawing.Point(11, 271)
        Me.btn_playlist_adjustment.Name = "btn_playlist_adjustment"
        Me.btn_playlist_adjustment.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btn_playlist_adjustment.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_playlist_adjustment.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_playlist_adjustment.OnHoverImage = Nothing
        Me.btn_playlist_adjustment.OnPressedColor = System.Drawing.Color.Black
        Me.btn_playlist_adjustment.Size = New System.Drawing.Size(168, 30)
        Me.btn_playlist_adjustment.TabIndex = 12
        Me.btn_playlist_adjustment.Text = "  Playlist Adjustment"
        '
        'btn_camera_playlist
        '
        Me.btn_camera_playlist.AnimationHoverSpeed = 0.07!
        Me.btn_camera_playlist.AnimationSpeed = 0.03!
        Me.btn_camera_playlist.BaseColor = System.Drawing.Color.Transparent
        Me.btn_camera_playlist.BorderColor = System.Drawing.Color.Black
        Me.btn_camera_playlist.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_camera_playlist.FocusedColor = System.Drawing.Color.Empty
        Me.btn_camera_playlist.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btn_camera_playlist.ForeColor = System.Drawing.Color.White
        Me.btn_camera_playlist.Image = Global.Itone_Media_Player.My.Resources.Resources.camplaylist
        Me.btn_camera_playlist.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_camera_playlist.Location = New System.Drawing.Point(10, 224)
        Me.btn_camera_playlist.Name = "btn_camera_playlist"
        Me.btn_camera_playlist.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btn_camera_playlist.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_camera_playlist.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_camera_playlist.OnHoverImage = Nothing
        Me.btn_camera_playlist.OnPressedColor = System.Drawing.Color.Black
        Me.btn_camera_playlist.Size = New System.Drawing.Size(168, 30)
        Me.btn_camera_playlist.TabIndex = 11
        Me.btn_camera_playlist.Text = "  My Camera"
        '
        'btn_album_playlist
        '
        Me.btn_album_playlist.AnimationHoverSpeed = 0.07!
        Me.btn_album_playlist.AnimationSpeed = 0.03!
        Me.btn_album_playlist.BaseColor = System.Drawing.Color.Transparent
        Me.btn_album_playlist.BorderColor = System.Drawing.Color.Black
        Me.btn_album_playlist.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_album_playlist.FocusedColor = System.Drawing.Color.Empty
        Me.btn_album_playlist.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btn_album_playlist.ForeColor = System.Drawing.Color.White
        Me.btn_album_playlist.Image = Global.Itone_Media_Player.My.Resources.Resources.musicrec
        Me.btn_album_playlist.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_album_playlist.Location = New System.Drawing.Point(11, 177)
        Me.btn_album_playlist.Name = "btn_album_playlist"
        Me.btn_album_playlist.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btn_album_playlist.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_album_playlist.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_album_playlist.OnHoverImage = Nothing
        Me.btn_album_playlist.OnPressedColor = System.Drawing.Color.Black
        Me.btn_album_playlist.Size = New System.Drawing.Size(168, 30)
        Me.btn_album_playlist.TabIndex = 10
        Me.btn_album_playlist.Text = "  Album"
        '
        'btn_favourites_playlist
        '
        Me.btn_favourites_playlist.AnimationHoverSpeed = 0.07!
        Me.btn_favourites_playlist.AnimationSpeed = 0.03!
        Me.btn_favourites_playlist.BaseColor = System.Drawing.Color.Transparent
        Me.btn_favourites_playlist.BorderColor = System.Drawing.Color.Black
        Me.btn_favourites_playlist.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_favourites_playlist.FocusedColor = System.Drawing.Color.Empty
        Me.btn_favourites_playlist.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btn_favourites_playlist.ForeColor = System.Drawing.Color.White
        Me.btn_favourites_playlist.Image = Global.Itone_Media_Player.My.Resources.Resources.heart
        Me.btn_favourites_playlist.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_favourites_playlist.Location = New System.Drawing.Point(11, 130)
        Me.btn_favourites_playlist.Name = "btn_favourites_playlist"
        Me.btn_favourites_playlist.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btn_favourites_playlist.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_favourites_playlist.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_favourites_playlist.OnHoverImage = Nothing
        Me.btn_favourites_playlist.OnPressedColor = System.Drawing.Color.Black
        Me.btn_favourites_playlist.Size = New System.Drawing.Size(168, 30)
        Me.btn_favourites_playlist.TabIndex = 9
        Me.btn_favourites_playlist.Text = "  Favourites"
        '
        'btn_video_playlist
        '
        Me.btn_video_playlist.AnimationHoverSpeed = 0.07!
        Me.btn_video_playlist.AnimationSpeed = 0.03!
        Me.btn_video_playlist.BaseColor = System.Drawing.Color.Transparent
        Me.btn_video_playlist.BorderColor = System.Drawing.Color.Black
        Me.btn_video_playlist.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_video_playlist.FocusedColor = System.Drawing.Color.Empty
        Me.btn_video_playlist.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btn_video_playlist.ForeColor = System.Drawing.Color.White
        Me.btn_video_playlist.Image = Global.Itone_Media_Player.My.Resources.Resources.vidcam
        Me.btn_video_playlist.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_video_playlist.Location = New System.Drawing.Point(9, 83)
        Me.btn_video_playlist.Name = "btn_video_playlist"
        Me.btn_video_playlist.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btn_video_playlist.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_video_playlist.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_video_playlist.OnHoverImage = Nothing
        Me.btn_video_playlist.OnPressedColor = System.Drawing.Color.Black
        Me.btn_video_playlist.Size = New System.Drawing.Size(168, 30)
        Me.btn_video_playlist.TabIndex = 8
        Me.btn_video_playlist.Text = "  Video Playlist"
        '
        'btn_audio_playlist
        '
        Me.btn_audio_playlist.AnimationHoverSpeed = 0.07!
        Me.btn_audio_playlist.AnimationSpeed = 0.03!
        Me.btn_audio_playlist.BaseColor = System.Drawing.Color.Transparent
        Me.btn_audio_playlist.BorderColor = System.Drawing.Color.Black
        Me.btn_audio_playlist.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_audio_playlist.FocusedColor = System.Drawing.Color.Empty
        Me.btn_audio_playlist.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btn_audio_playlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_audio_playlist.Image = Global.Itone_Media_Player.My.Resources.Resources.audiofile
        Me.btn_audio_playlist.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_audio_playlist.Location = New System.Drawing.Point(9, 36)
        Me.btn_audio_playlist.Name = "btn_audio_playlist"
        Me.btn_audio_playlist.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btn_audio_playlist.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_audio_playlist.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btn_audio_playlist.OnHoverImage = Nothing
        Me.btn_audio_playlist.OnPressedColor = System.Drawing.Color.Black
        Me.btn_audio_playlist.Size = New System.Drawing.Size(168, 30)
        Me.btn_audio_playlist.TabIndex = 7
        Me.btn_audio_playlist.Text = "  Audio Playlist"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(196, 339)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(603, 94)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel4.Controls.Add(Me.Tab_Audio_Playlist1)
        Me.Panel4.Controls.Add(Me.Tab_Video_Playlist1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(196, 43)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(603, 296)
        Me.Panel4.TabIndex = 3
        '
        'Tab_Audio_Playlist1
        '
        Me.Tab_Audio_Playlist1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Audio_Playlist1.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Audio_Playlist1.Name = "Tab_Audio_Playlist1"
        Me.Tab_Audio_Playlist1.Size = New System.Drawing.Size(603, 296)
        Me.Tab_Audio_Playlist1.TabIndex = 0
        '
        'Tab_Video_Playlist1
        '
        Me.Tab_Video_Playlist1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Tab_Video_Playlist1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Video_Playlist1.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Video_Playlist1.Name = "Tab_Video_Playlist1"
        Me.Tab_Video_Playlist1.Size = New System.Drawing.Size(603, 296)
        Me.Tab_Video_Playlist1.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 433)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel_left)
        Me.Controls.Add(Me.Panel_top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Playlist"
        Me.Panel_top.ResumeLayout(False)
        Me.Panel_top.PerformLayout()
        CType(Me.btn_maximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_left.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel_left As Panel
    Friend WithEvents Panel_top As Panel
    Friend WithEvents btn_playlist_adjustment As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_camera_playlist As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_album_playlist As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_favourites_playlist As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_video_playlist As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_audio_playlist As Guna.UI.WinForms.GunaButton
    Friend WithEvents Tab_Audio_Playlist1 As Tab_Audio_Playlist
    Friend WithEvents Tab_Video_Playlist1 As Tab_Video_Playlist
    Friend WithEvents btn_maximize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_minimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents label_mediaPlayer As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ToolTip1 As ToolTip
End Class
