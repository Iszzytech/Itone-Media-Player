<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tab_Video_Playlist
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.label_available_song = New Guna.UI.WinForms.GunaLabel()
        Me.btn_remove_all = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_play_all = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_next = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_previous = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_remove = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_add = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton7 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton6 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ListBox1_songname = New System.Windows.Forms.ListBox()
        Me.ListBox2_songpath = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog_video = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_remove_all, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_play_all, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_next, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_previous, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_remove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Panel1.Controls.Add(Me.label_available_song)
        Me.Panel1.Controls.Add(Me.btn_remove_all)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btn_play_all)
        Me.Panel1.Controls.Add(Me.btn_next)
        Me.Panel1.Controls.Add(Me.btn_previous)
        Me.Panel1.Controls.Add(Me.btn_remove)
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Controls.Add(Me.BunifuImageButton7)
        Me.Panel1.Controls.Add(Me.BunifuImageButton6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 223)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 73)
        Me.Panel1.TabIndex = 1
        '
        'label_available_song
        '
        Me.label_available_song.AutoSize = True
        Me.label_available_song.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.label_available_song.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.label_available_song.Location = New System.Drawing.Point(60, 44)
        Me.label_available_song.Name = "label_available_song"
        Me.label_available_song.Size = New System.Drawing.Size(92, 13)
        Me.label_available_song.TabIndex = 17
        Me.label_available_song.Text = "Available Videos"
        '
        'btn_remove_all
        '
        Me.btn_remove_all.BackColor = System.Drawing.Color.Transparent
        Me.btn_remove_all.Image = Global.Itone_Media_Player.My.Resources.Resources.filedel
        Me.btn_remove_all.ImageActive = Nothing
        Me.btn_remove_all.Location = New System.Drawing.Point(452, 24)
        Me.btn_remove_all.Name = "btn_remove_all"
        Me.btn_remove_all.Size = New System.Drawing.Size(29, 35)
        Me.btn_remove_all.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_remove_all.TabIndex = 15
        Me.btn_remove_all.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btn_remove_all, "Clear Playlist")
        Me.btn_remove_all.Zoom = 10
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.Itone_Media_Player.My.Resources.Resources.spot2
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Panel5.Controls.Add(Me.BunifuImageButton5)
        Me.Panel5.Location = New System.Drawing.Point(3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(195, 43)
        Me.Panel5.TabIndex = 12
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderThickness = 3
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(37, 8)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(127, 23)
        Me.BunifuMetroTextbox1.TabIndex = 11
        Me.BunifuMetroTextbox1.Text = "Search media in a playlist"
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton5.Image = Global.Itone_Media_Player.My.Resources.Resources.Searchbtn
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(162, 8)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(26, 23)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton5.TabIndex = 0
        Me.BunifuImageButton5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton5, "Search")
        Me.BunifuImageButton5.Zoom = 10
        '
        'btn_play_all
        '
        Me.btn_play_all.BackColor = System.Drawing.Color.Transparent
        Me.btn_play_all.Image = Global.Itone_Media_Player.My.Resources.Resources.playicon
        Me.btn_play_all.ImageActive = Nothing
        Me.btn_play_all.Location = New System.Drawing.Point(280, 24)
        Me.btn_play_all.Name = "btn_play_all"
        Me.btn_play_all.Size = New System.Drawing.Size(29, 35)
        Me.btn_play_all.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_play_all.TabIndex = 9
        Me.btn_play_all.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btn_play_all, "Play")
        Me.btn_play_all.Zoom = 10
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.Color.Transparent
        Me.btn_next.Image = Global.Itone_Media_Player.My.Resources.Resources.forwardgreen
        Me.btn_next.ImageActive = Nothing
        Me.btn_next.Location = New System.Drawing.Point(317, 24)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(29, 35)
        Me.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_next.TabIndex = 8
        Me.btn_next.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btn_next, "Next Song")
        Me.btn_next.Zoom = 10
        '
        'btn_previous
        '
        Me.btn_previous.BackColor = System.Drawing.Color.Transparent
        Me.btn_previous.Image = Global.Itone_Media_Player.My.Resources.Resources.backgreen
        Me.btn_previous.ImageActive = Nothing
        Me.btn_previous.Location = New System.Drawing.Point(244, 24)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.Size = New System.Drawing.Size(29, 35)
        Me.btn_previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_previous.TabIndex = 7
        Me.btn_previous.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btn_previous, "Previous Button")
        Me.btn_previous.Zoom = 10
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.Color.Transparent
        Me.btn_remove.Image = Global.Itone_Media_Player.My.Resources.Resources.deletefile
        Me.btn_remove.ImageActive = Nothing
        Me.btn_remove.Location = New System.Drawing.Point(419, 24)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(29, 35)
        Me.btn_remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_remove.TabIndex = 6
        Me.btn_remove.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btn_remove, "Delete song from playlist")
        Me.btn_remove.Zoom = 10
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Transparent
        Me.btn_add.Image = Global.Itone_Media_Player.My.Resources.Resources.addfile
        Me.btn_add.ImageActive = Nothing
        Me.btn_add.Location = New System.Drawing.Point(386, 24)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(29, 35)
        Me.btn_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_add.TabIndex = 5
        Me.btn_add.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btn_add, "Add to playlist")
        Me.btn_add.Zoom = 10
        '
        'BunifuImageButton7
        '
        Me.BunifuImageButton7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton7.Image = Global.Itone_Media_Player.My.Resources.Resources.mic
        Me.BunifuImageButton7.ImageActive = Nothing
        Me.BunifuImageButton7.Location = New System.Drawing.Point(496, 24)
        Me.BunifuImageButton7.Name = "BunifuImageButton7"
        Me.BunifuImageButton7.Size = New System.Drawing.Size(29, 35)
        Me.BunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton7.TabIndex = 13
        Me.BunifuImageButton7.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton7, "Enable voice command")
        Me.BunifuImageButton7.Zoom = 10
        '
        'BunifuImageButton6
        '
        Me.BunifuImageButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton6.Image = Global.Itone_Media_Player.My.Resources.Resources.micblocked
        Me.BunifuImageButton6.ImageActive = Global.Itone_Media_Player.My.Resources.Resources.pausegreen
        Me.BunifuImageButton6.Location = New System.Drawing.Point(496, 24)
        Me.BunifuImageButton6.Name = "BunifuImageButton6"
        Me.BunifuImageButton6.Size = New System.Drawing.Size(29, 35)
        Me.BunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton6.TabIndex = 14
        Me.BunifuImageButton6.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BunifuImageButton6, "Disable voice command")
        Me.BunifuImageButton6.Zoom = 10
        '
        'ListBox1_songname
        '
        Me.ListBox1_songname.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ListBox1_songname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1_songname.ForeColor = System.Drawing.Color.White
        Me.ListBox1_songname.FormattingEnabled = True
        Me.ListBox1_songname.ItemHeight = 16
        Me.ListBox1_songname.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1_songname.Name = "ListBox1_songname"
        Me.ListBox1_songname.Size = New System.Drawing.Size(603, 223)
        Me.ListBox1_songname.TabIndex = 2
        '
        'ListBox2_songpath
        '
        Me.ListBox2_songpath.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ListBox2_songpath.FormattingEnabled = True
        Me.ListBox2_songpath.ItemHeight = 16
        Me.ListBox2_songpath.Location = New System.Drawing.Point(452, 7)
        Me.ListBox2_songpath.Name = "ListBox2_songpath"
        Me.ListBox2_songpath.Size = New System.Drawing.Size(120, 84)
        Me.ListBox2_songpath.TabIndex = 3
        Me.ListBox2_songpath.Visible = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Controls.Add(Me.ListBox2_songpath)
        Me.Panel2.Controls.Add(Me.ListBox1_songname)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(603, 223)
        Me.Panel2.TabIndex = 4
        '
        'Timer1
        '
        '
        'OpenFileDialog_video
        '
        Me.OpenFileDialog_video.FileName = "Choose Video Files"
        Me.OpenFileDialog_video.Multiselect = True
        '
        'Tab_Video_Playlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Tab_Video_Playlist"
        Me.Size = New System.Drawing.Size(603, 296)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_remove_all, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_play_all, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_next, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_previous, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_remove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_remove_all As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton7 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_play_all As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_next As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_previous As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_remove As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_add As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton6 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ListBox1_songname As ListBox
    Friend WithEvents ListBox2_songpath As ListBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents label_available_song As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog_video As OpenFileDialog
End Class
