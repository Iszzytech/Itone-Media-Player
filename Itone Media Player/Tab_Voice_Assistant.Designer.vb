<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tab_Voice_Assistant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tab_Voice_Assistant))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.label_voice_assitant = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_VA = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_search = New System.Windows.Forms.Panel()
        Me.music_search = New System.Windows.Forms.TextBox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_VA_OFF = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_SP_active = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_SP_Deactive = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_help = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_help2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.btn_VA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_search.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_VA_OFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_SP_active, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_SP_Deactive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_help2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.label_voice_assitant)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 57)
        Me.Panel1.TabIndex = 3
        '
        'label_voice_assitant
        '
        Me.label_voice_assitant.AutoSize = True
        Me.label_voice_assitant.BackColor = System.Drawing.Color.Transparent
        Me.label_voice_assitant.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.label_voice_assitant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.label_voice_assitant.Location = New System.Drawing.Point(290, 14)
        Me.label_voice_assitant.Name = "label_voice_assitant"
        Me.label_voice_assitant.Size = New System.Drawing.Size(140, 25)
        Me.label_voice_assitant.TabIndex = 15
        Me.label_voice_assitant.Text = "Voice Assistant"
        Me.label_voice_assitant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.GunaVSeparator1)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_help2)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_help)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_SP_Deactive)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_SP_active)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton2)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel_search)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_VA)
        Me.BunifuGradientPanel1.Controls.Add(Me.btn_VA_OFF)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 57)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(721, 146)
        Me.BunifuGradientPanel1.TabIndex = 4
        '
        'btn_VA
        '
        Me.btn_VA.BackColor = System.Drawing.Color.Transparent
        Me.btn_VA.Image = CType(resources.GetObject("btn_VA.Image"), System.Drawing.Image)
        Me.btn_VA.ImageActive = Nothing
        Me.btn_VA.Location = New System.Drawing.Point(414, 34)
        Me.btn_VA.Name = "btn_VA"
        Me.btn_VA.Size = New System.Drawing.Size(61, 70)
        Me.btn_VA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_VA.TabIndex = 21
        Me.btn_VA.TabStop = False
        Me.btn_VA.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(351, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Panel_search
        '
        Me.Panel_search.BackColor = System.Drawing.Color.Transparent
        Me.Panel_search.BackgroundImage = Global.Itone_Media_Player.My.Resources.Resources.spot2
        Me.Panel_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel_search.Controls.Add(Me.music_search)
        Me.Panel_search.Controls.Add(Me.BunifuImageButton1)
        Me.Panel_search.Location = New System.Drawing.Point(414, 149)
        Me.Panel_search.Name = "Panel_search"
        Me.Panel_search.Size = New System.Drawing.Size(195, 52)
        Me.Panel_search.TabIndex = 23
        '
        'music_search
        '
        Me.music_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.music_search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.music_search.ForeColor = System.Drawing.Color.White
        Me.music_search.Location = New System.Drawing.Point(37, 20)
        Me.music_search.Name = "music_search"
        Me.music_search.Size = New System.Drawing.Size(119, 13)
        Me.music_search.TabIndex = 9
        Me.music_search.Text = "Search Voice Command"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.Itone_Media_Player.My.Resources.Resources.Searchbtn
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(161, 15)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(26, 23)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 0
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'btn_VA_OFF
        '
        Me.btn_VA_OFF.BackColor = System.Drawing.Color.Transparent
        Me.btn_VA_OFF.Image = CType(resources.GetObject("btn_VA_OFF.Image"), System.Drawing.Image)
        Me.btn_VA_OFF.ImageActive = Nothing
        Me.btn_VA_OFF.Location = New System.Drawing.Point(414, 34)
        Me.btn_VA_OFF.Name = "btn_VA_OFF"
        Me.btn_VA_OFF.Size = New System.Drawing.Size(61, 70)
        Me.btn_VA_OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_VA_OFF.TabIndex = 24
        Me.btn_VA_OFF.TabStop = False
        Me.btn_VA_OFF.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(11, 9)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(61, 53)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 25
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'btn_SP_active
        '
        Me.btn_SP_active.BackColor = System.Drawing.Color.Transparent
        Me.btn_SP_active.Image = CType(resources.GetObject("btn_SP_active.Image"), System.Drawing.Image)
        Me.btn_SP_active.ImageActive = Nothing
        Me.btn_SP_active.Location = New System.Drawing.Point(652, 257)
        Me.btn_SP_active.Name = "btn_SP_active"
        Me.btn_SP_active.Size = New System.Drawing.Size(44, 36)
        Me.btn_SP_active.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_SP_active.TabIndex = 26
        Me.btn_SP_active.TabStop = False
        Me.btn_SP_active.Zoom = 10
        '
        'btn_SP_Deactive
        '
        Me.btn_SP_Deactive.BackColor = System.Drawing.Color.Transparent
        Me.btn_SP_Deactive.Image = CType(resources.GetObject("btn_SP_Deactive.Image"), System.Drawing.Image)
        Me.btn_SP_Deactive.ImageActive = Nothing
        Me.btn_SP_Deactive.Location = New System.Drawing.Point(652, 257)
        Me.btn_SP_Deactive.Name = "btn_SP_Deactive"
        Me.btn_SP_Deactive.Size = New System.Drawing.Size(44, 36)
        Me.btn_SP_Deactive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_SP_Deactive.TabIndex = 27
        Me.btn_SP_Deactive.TabStop = False
        Me.btn_SP_Deactive.Zoom = 10
        '
        'btn_help
        '
        Me.btn_help.BackColor = System.Drawing.Color.Transparent
        Me.btn_help.Image = CType(resources.GetObject("btn_help.Image"), System.Drawing.Image)
        Me.btn_help.ImageActive = Nothing
        Me.btn_help.Location = New System.Drawing.Point(652, 6)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(54, 43)
        Me.btn_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_help.TabIndex = 28
        Me.btn_help.TabStop = False
        Me.btn_help.Zoom = 10
        '
        'btn_help2
        '
        Me.btn_help2.BackColor = System.Drawing.Color.Transparent
        Me.btn_help2.Image = CType(resources.GetObject("btn_help2.Image"), System.Drawing.Image)
        Me.btn_help2.ImageActive = Nothing
        Me.btn_help2.Location = New System.Drawing.Point(652, 6)
        Me.btn_help2.Name = "btn_help2"
        Me.btn_help2.Size = New System.Drawing.Size(54, 43)
        Me.btn_help2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_help2.TabIndex = 29
        Me.btn_help2.TabStop = False
        Me.btn_help2.Zoom = 10
        '
        'GunaVSeparator1
        '
        Me.GunaVSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.GunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaVSeparator1.Location = New System.Drawing.Point(373, 9)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(10, 284)
        Me.GunaVSeparator1.TabIndex = 30
        Me.GunaVSeparator1.Thickness = 2
        '
        'Tab_Voice_Assistant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Tab_Voice_Assistant"
        Me.Size = New System.Drawing.Size(721, 203)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.btn_VA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_search.ResumeLayout(False)
        Me.Panel_search.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_VA_OFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_SP_active, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_SP_Deactive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_help2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents label_voice_assitant As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_VA As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_VA_OFF As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel_search As Panel
    Friend WithEvents music_search As TextBox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_SP_Deactive As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_SP_active As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_help2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_help As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
End Class
