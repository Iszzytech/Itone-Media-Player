<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startup_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startup_page))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.anime_panel = New System.Windows.Forms.Panel()
        Me.gunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.Time_txt = New System.Windows.Forms.Label()
        Me.stages = New System.Windows.Forms.Label()
        Me.panel_main = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.developer = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GunaProgressBar1 = New Guna.UI.WinForms.GunaProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.anime_panel.SuspendLayout()
        Me.panel_main.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'anime_panel
        '
        Me.anime_panel.BackColor = System.Drawing.Color.Black
        Me.anime_panel.Controls.Add(Me.gunaButton1)
        Me.anime_panel.Controls.Add(Me.Time_txt)
        Me.anime_panel.Controls.Add(Me.stages)
        Me.anime_panel.Controls.Add(Me.panel_main)
        Me.anime_panel.Controls.Add(Me.GunaProgressBar1)
        Me.anime_panel.Controls.Add(Me.PictureBox1)
        Me.anime_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.anime_panel.Location = New System.Drawing.Point(0, 0)
        Me.anime_panel.Name = "anime_panel"
        Me.anime_panel.Size = New System.Drawing.Size(450, 475)
        Me.anime_panel.TabIndex = 0
        '
        'gunaButton1
        '
        Me.gunaButton1.AnimationHoverSpeed = 0.07!
        Me.gunaButton1.AnimationSpeed = 0.03!
        Me.gunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.gunaButton1.BaseColor = System.Drawing.Color.Transparent
        Me.gunaButton1.BorderColor = System.Drawing.Color.Transparent
        Me.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.gunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.gunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gunaButton1.ForeColor = System.Drawing.Color.White
        Me.gunaButton1.Image = CType(resources.GetObject("gunaButton1.Image"), System.Drawing.Image)
        Me.gunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.gunaButton1.Location = New System.Drawing.Point(10, 442)
        Me.gunaButton1.Name = "gunaButton1"
        Me.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.gunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.gunaButton1.OnHoverImage = Nothing
        Me.gunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.gunaButton1.Size = New System.Drawing.Size(418, 21)
        Me.gunaButton1.TabIndex = 8
        Me.gunaButton1.Text = "Copyright 2019 - ODUGBOYE ISRAEL OLUWAGBENGA, 160591126."
        '
        'Time_txt
        '
        Me.Time_txt.AutoSize = True
        Me.Time_txt.BackColor = System.Drawing.Color.Transparent
        Me.Time_txt.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Time_txt.ForeColor = System.Drawing.Color.White
        Me.Time_txt.Location = New System.Drawing.Point(33, 405)
        Me.Time_txt.Name = "Time_txt"
        Me.Time_txt.Size = New System.Drawing.Size(24, 17)
        Me.Time_txt.TabIndex = 4
        Me.Time_txt.Text = "0%"
        '
        'stages
        '
        Me.stages.AutoSize = True
        Me.stages.BackColor = System.Drawing.Color.Transparent
        Me.stages.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stages.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.stages.Location = New System.Drawing.Point(73, 404)
        Me.stages.Name = "stages"
        Me.stages.Size = New System.Drawing.Size(65, 17)
        Me.stages.TabIndex = 3
        Me.stages.Text = "Loading..."
        '
        'panel_main
        '
        Me.panel_main.BackgroundImage = CType(resources.GetObject("panel_main.BackgroundImage"), System.Drawing.Image)
        Me.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_main.Controls.Add(Me.developer)
        Me.panel_main.Controls.Add(Me.PictureBox2)
        Me.panel_main.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.panel_main.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.panel_main.GradientTopLeft = System.Drawing.Color.Empty
        Me.panel_main.GradientTopRight = System.Drawing.Color.Black
        Me.panel_main.Location = New System.Drawing.Point(3, 3)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.Quality = 10
        Me.panel_main.Size = New System.Drawing.Size(444, 396)
        Me.panel_main.TabIndex = 2
        Me.panel_main.Visible = False
        '
        'developer
        '
        Me.developer.AutoSize = True
        Me.developer.BackColor = System.Drawing.Color.Transparent
        Me.developer.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.developer.ForeColor = System.Drawing.Color.White
        Me.developer.Location = New System.Drawing.Point(3, 233)
        Me.developer.Name = "developer"
        Me.developer.Size = New System.Drawing.Size(437, 144)
        Me.developer.TabIndex = 7
        Me.developer.Text = resources.GetString("developer.Text")
        Me.developer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(120, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(210, 188)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'GunaProgressBar1
        '
        Me.GunaProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.GunaProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.GunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.GunaProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaProgressBar1.Location = New System.Drawing.Point(23, 426)
        Me.GunaProgressBar1.Name = "GunaProgressBar1"
        Me.GunaProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GunaProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.GunaProgressBar1.Radius = 2
        Me.GunaProgressBar1.Size = New System.Drawing.Size(402, 10)
        Me.GunaProgressBar1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(444, 472)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 320
        '
        'Startup_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 475)
        Me.Controls.Add(Me.anime_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Startup_page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Startup_page"
        Me.anime_panel.ResumeLayout(False)
        Me.anime_panel.PerformLayout()
        Me.panel_main.ResumeLayout(False)
        Me.panel_main.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents anime_panel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents panel_main As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GunaProgressBar1 As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents Time_txt As Label
    Friend WithEvents stages As Label
    Private WithEvents gunaButton1 As Guna.UI.WinForms.GunaButton
    Private WithEvents developer As Label
End Class
