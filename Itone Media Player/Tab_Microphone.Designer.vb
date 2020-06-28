<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tab_Microphone
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tab_Microphone))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Mic_Btn_Check = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Noise_btn = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Echo_btn = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.beam_btn = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Black
        Me.GunaPanel1.Controls.Add(Me.Label7)
        Me.GunaPanel1.Controls.Add(Me.Label8)
        Me.GunaPanel1.Controls.Add(Me.beam_btn)
        Me.GunaPanel1.Controls.Add(Me.Label5)
        Me.GunaPanel1.Controls.Add(Me.Label6)
        Me.GunaPanel1.Controls.Add(Me.Echo_btn)
        Me.GunaPanel1.Controls.Add(Me.Label3)
        Me.GunaPanel1.Controls.Add(Me.Label2)
        Me.GunaPanel1.Controls.Add(Me.Noise_btn)
        Me.GunaPanel1.Controls.Add(Me.PictureBox1)
        Me.GunaPanel1.Controls.Add(Me.Label1)
        Me.GunaPanel1.Controls.Add(Me.BunifuDropdown1)
        Me.GunaPanel1.Controls.Add(Me.Label4)
        Me.GunaPanel1.Controls.Add(Me.Mic_Btn_Check)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(721, 315)
        Me.GunaPanel1.TabIndex = 0
        '
        'Mic_Btn_Check
        '
        Me.Mic_Btn_Check.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Mic_Btn_Check.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Mic_Btn_Check.Checked = False
        Me.Mic_Btn_Check.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Mic_Btn_Check.ForeColor = System.Drawing.Color.White
        Me.Mic_Btn_Check.Location = New System.Drawing.Point(25, 34)
        Me.Mic_Btn_Check.Name = "Mic_Btn_Check"
        Me.Mic_Btn_Check.Size = New System.Drawing.Size(20, 20)
        Me.Mic_Btn_Check.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(52, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 14)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Enable Microphone"
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown1.BorderRadius = 3
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown1.Items = New String(-1) {}
        Me.BunifuDropdown1.Location = New System.Drawing.Point(536, 33)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuDropdown1.selectedIndex = -1
        Me.BunifuDropdown1.Size = New System.Drawing.Size(150, 35)
        Me.BunifuDropdown1.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(475, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 14)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Devices"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'Noise_btn
        '
        Me.Noise_btn.BackColor = System.Drawing.Color.Transparent
        Me.Noise_btn.BackgroundImage = CType(resources.GetObject("Noise_btn.BackgroundImage"), System.Drawing.Image)
        Me.Noise_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Noise_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Noise_btn.Location = New System.Drawing.Point(330, 106)
        Me.Noise_btn.Name = "Noise_btn"
        Me.Noise_btn.OffColor = System.Drawing.Color.Gray
        Me.Noise_btn.OnColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Noise_btn.Size = New System.Drawing.Size(43, 25)
        Me.Noise_btn.TabIndex = 75
        Me.Noise_btn.Value = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(388, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 14)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Noise Suspension"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(389, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 12)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Reduce Static Background Music When Recording"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(389, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(273, 12)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Reduce Echo Background Music When Recording"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(388, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 14)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Echo Cancellation"
        '
        'Echo_btn
        '
        Me.Echo_btn.BackColor = System.Drawing.Color.Transparent
        Me.Echo_btn.BackgroundImage = CType(resources.GetObject("Echo_btn.BackgroundImage"), System.Drawing.Image)
        Me.Echo_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Echo_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Echo_btn.Location = New System.Drawing.Point(330, 170)
        Me.Echo_btn.Name = "Echo_btn"
        Me.Echo_btn.OffColor = System.Drawing.Color.Gray
        Me.Echo_btn.OnColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Echo_btn.Size = New System.Drawing.Size(43, 25)
        Me.Echo_btn.TabIndex = 78
        Me.Echo_btn.Value = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(388, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 12)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Directional Recording"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(387, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 14)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Beam Forming"
        '
        'beam_btn
        '
        Me.beam_btn.BackColor = System.Drawing.Color.Transparent
        Me.beam_btn.BackgroundImage = CType(resources.GetObject("beam_btn.BackgroundImage"), System.Drawing.Image)
        Me.beam_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beam_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.beam_btn.Location = New System.Drawing.Point(329, 233)
        Me.beam_btn.Name = "beam_btn"
        Me.beam_btn.OffColor = System.Drawing.Color.Gray
        Me.beam_btn.OnColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.beam_btn.Size = New System.Drawing.Size(43, 25)
        Me.beam_btn.TabIndex = 81
        Me.beam_btn.Value = False
        '
        'Tab_Microphone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaPanel1)
        Me.Name = "Tab_Microphone"
        Me.Size = New System.Drawing.Size(721, 315)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Mic_Btn_Check As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents beam_btn As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Echo_btn As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Noise_btn As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label4 As Label
End Class
