<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tab_Transparent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tab_Transparent))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.label_music = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Progressbar_slider = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.TextBox_read = New System.Windows.Forms.TextBox()
        Me.TextBox_write = New System.Windows.Forms.TextBox()
        Me.label_TR_value = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuiOSSwitch1 = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_playlistOFF = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_fullscreenOFF = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_halfscreenOFF = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_nice = New Bunifu.Framework.UI.BunifuImageButton()
        Me.slider_transparent = New MB.Controls.ColorSlider()
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_playlistOFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_fullscreenOFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_halfscreenOFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_nice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.label_music)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 57)
        Me.Panel1.TabIndex = 2
        '
        'label_music
        '
        Me.label_music.AutoSize = True
        Me.label_music.BackColor = System.Drawing.Color.Transparent
        Me.label_music.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.label_music.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.label_music.Location = New System.Drawing.Point(252, 14)
        Me.label_music.Name = "label_music"
        Me.label_music.Size = New System.Drawing.Size(217, 25)
        Me.label_music.TabIndex = 15
        Me.label_music.Text = "Transparent Adjustment"
        Me.label_music.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Progressbar_slider)
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox_read)
        Me.BunifuGradientPanel1.Controls.Add(Me.TextBox_write)
        Me.BunifuGradientPanel1.Controls.Add(Me.label_TR_value)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuiOSSwitch1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton2)
        Me.BunifuGradientPanel1.Controls.Add(Me.GunaLabel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_playlistOFF)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_fullscreenOFF)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_halfscreenOFF)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_nice)
        Me.BunifuGradientPanel1.Controls.Add(Me.slider_transparent)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 57)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(721, 146)
        Me.BunifuGradientPanel1.TabIndex = 3
        '
        'Progressbar_slider
        '
        Me.Progressbar_slider.animated = False
        Me.Progressbar_slider.animationIterval = 5
        Me.Progressbar_slider.animationSpeed = 300
        Me.Progressbar_slider.BackColor = System.Drawing.Color.Transparent
        Me.Progressbar_slider.BackgroundImage = CType(resources.GetObject("Progressbar_slider.BackgroundImage"), System.Drawing.Image)
        Me.Progressbar_slider.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Progressbar_slider.ForeColor = System.Drawing.Color.SeaGreen
        Me.Progressbar_slider.LabelVisible = True
        Me.Progressbar_slider.LineProgressThickness = 8
        Me.Progressbar_slider.LineThickness = 5
        Me.Progressbar_slider.Location = New System.Drawing.Point(548, 146)
        Me.Progressbar_slider.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.Progressbar_slider.MaxValue = 100
        Me.Progressbar_slider.Name = "Progressbar_slider"
        Me.Progressbar_slider.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.Progressbar_slider.ProgressColor = System.Drawing.Color.SeaGreen
        Me.Progressbar_slider.Size = New System.Drawing.Size(104, 104)
        Me.Progressbar_slider.TabIndex = 28
        Me.Progressbar_slider.Value = 0
        '
        'TextBox_read
        '
        Me.TextBox_read.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_read.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox_read.Location = New System.Drawing.Point(63, 204)
        Me.TextBox_read.Multiline = True
        Me.TextBox_read.Name = "TextBox_read"
        Me.TextBox_read.Size = New System.Drawing.Size(82, 20)
        Me.TextBox_read.TabIndex = 27
        Me.TextBox_read.Visible = False
        '
        'TextBox_write
        '
        Me.TextBox_write.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_write.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox_write.Location = New System.Drawing.Point(63, 172)
        Me.TextBox_write.Multiline = True
        Me.TextBox_write.Name = "TextBox_write"
        Me.TextBox_write.Size = New System.Drawing.Size(82, 20)
        Me.TextBox_write.TabIndex = 26
        Me.TextBox_write.Visible = False
        '
        'label_TR_value
        '
        Me.label_TR_value.AutoSize = True
        Me.label_TR_value.BackColor = System.Drawing.Color.Transparent
        Me.label_TR_value.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_TR_value.ForeColor = System.Drawing.Color.White
        Me.label_TR_value.Location = New System.Drawing.Point(658, 115)
        Me.label_TR_value.Name = "label_TR_value"
        Me.label_TR_value.Size = New System.Drawing.Size(22, 17)
        Me.label_TR_value.TabIndex = 25
        Me.label_TR_value.Text = "00"
        Me.label_TR_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuiOSSwitch1
        '
        Me.BunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuiOSSwitch1.BackgroundImage = CType(resources.GetObject("BunifuiOSSwitch1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuiOSSwitch1.Location = New System.Drawing.Point(342, 225)
        Me.BunifuiOSSwitch1.Name = "BunifuiOSSwitch1"
        Me.BunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray
        Me.BunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BunifuiOSSwitch1.Size = New System.Drawing.Size(43, 25)
        Me.BunifuiOSSwitch1.TabIndex = 24
        Me.BunifuiOSSwitch1.Value = False
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = Global.Itone_Media_Player.My.Resources.Resources.settingiconwhite
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(643, 7)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(51, 32)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 23
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(60, 13)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(165, 17)
        Me.GunaLabel1.TabIndex = 16
        Me.GunaLabel1.Text = "Adjust screen transparency"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.Itone_Media_Player.My.Resources.Resources.system_info
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(3, 7)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(51, 32)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 22
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'btn_playlistOFF
        '
        Me.btn_playlistOFF.BackColor = System.Drawing.Color.Transparent
        Me.btn_playlistOFF.Image = Global.Itone_Media_Player.My.Resources.Resources.flashauto
        Me.btn_playlistOFF.ImageActive = Nothing
        Me.btn_playlistOFF.Location = New System.Drawing.Point(238, 171)
        Me.btn_playlistOFF.Name = "btn_playlistOFF"
        Me.btn_playlistOFF.Size = New System.Drawing.Size(51, 32)
        Me.btn_playlistOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_playlistOFF.TabIndex = 18
        Me.btn_playlistOFF.TabStop = False
        Me.btn_playlistOFF.Zoom = 10
        '
        'btn_fullscreenOFF
        '
        Me.btn_fullscreenOFF.BackColor = System.Drawing.Color.Transparent
        Me.btn_fullscreenOFF.Image = Global.Itone_Media_Player.My.Resources.Resources.add
        Me.btn_fullscreenOFF.ImageActive = Nothing
        Me.btn_fullscreenOFF.Location = New System.Drawing.Point(305, 171)
        Me.btn_fullscreenOFF.Name = "btn_fullscreenOFF"
        Me.btn_fullscreenOFF.Size = New System.Drawing.Size(51, 32)
        Me.btn_fullscreenOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_fullscreenOFF.TabIndex = 19
        Me.btn_fullscreenOFF.TabStop = False
        Me.btn_fullscreenOFF.Zoom = 10
        '
        'btn_halfscreenOFF
        '
        Me.btn_halfscreenOFF.BackColor = System.Drawing.Color.Transparent
        Me.btn_halfscreenOFF.Image = Global.Itone_Media_Player.My.Resources.Resources.good2
        Me.btn_halfscreenOFF.ImageActive = Nothing
        Me.btn_halfscreenOFF.Location = New System.Drawing.Point(376, 171)
        Me.btn_halfscreenOFF.Name = "btn_halfscreenOFF"
        Me.btn_halfscreenOFF.Size = New System.Drawing.Size(51, 32)
        Me.btn_halfscreenOFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_halfscreenOFF.TabIndex = 20
        Me.btn_halfscreenOFF.TabStop = False
        Me.btn_halfscreenOFF.Zoom = 10
        '
        'btn_nice
        '
        Me.btn_nice.BackColor = System.Drawing.Color.Transparent
        Me.btn_nice.Image = Global.Itone_Media_Player.My.Resources.Resources.ok_hand
        Me.btn_nice.ImageActive = Nothing
        Me.btn_nice.Location = New System.Drawing.Point(448, 171)
        Me.btn_nice.Name = "btn_nice"
        Me.btn_nice.Size = New System.Drawing.Size(51, 32)
        Me.btn_nice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_nice.TabIndex = 21
        Me.btn_nice.TabStop = False
        Me.btn_nice.Zoom = 10
        '
        'slider_transparent
        '
        Me.slider_transparent.BackColor = System.Drawing.Color.Transparent
        Me.slider_transparent.BarInnerColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.slider_transparent.BarOuterColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.slider_transparent.BarPenColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.slider_transparent.BorderRoundRectSize = New System.Drawing.Size(8, 8)
        Me.slider_transparent.ElapsedInnerColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.slider_transparent.ElapsedOuterColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.slider_transparent.LargeChange = CType(5UI, UInteger)
        Me.slider_transparent.Location = New System.Drawing.Point(45, 106)
        Me.slider_transparent.Name = "slider_transparent"
        Me.slider_transparent.Size = New System.Drawing.Size(607, 36)
        Me.slider_transparent.SmallChange = CType(1UI, UInteger)
        Me.slider_transparent.TabIndex = 17
        Me.slider_transparent.Text = "ColorSlider1"
        Me.slider_transparent.ThumbInnerColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.slider_transparent.ThumbOuterColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.slider_transparent.ThumbPenColor = System.Drawing.Color.LightGreen
        Me.slider_transparent.ThumbRoundRectSize = New System.Drawing.Size(6, 6)
        Me.slider_transparent.ThumbSize = 10
        Me.slider_transparent.Value = 10
        '
        'Tab_Transparent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Tab_Transparent"
        Me.Size = New System.Drawing.Size(721, 203)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_playlistOFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_fullscreenOFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_halfscreenOFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_nice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents label_music As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents slider_transparent As MB.Controls.ColorSlider
    Friend WithEvents btn_playlistOFF As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_fullscreenOFF As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_halfscreenOFF As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_nice As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TextBox_read As TextBox
    Friend WithEvents TextBox_write As TextBox
    Friend WithEvents label_TR_value As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuiOSSwitch1 As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents Progressbar_slider As Bunifu.Framework.UI.BunifuCircleProgressbar
End Class
