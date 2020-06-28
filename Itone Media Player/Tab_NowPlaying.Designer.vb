<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tab_NowPlaying
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tab_NowPlaying))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.label_artist = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.label_song = New Guna.UI.WinForms.GunaLabel()
        Me.Timer_Slidername = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Itone_Music_Player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Itone_Music_Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 39)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Controls.Add(Me.label_artist)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 240)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(721, 40)
        Me.Panel2.TabIndex = 1
        '
        'label_artist
        '
        Me.label_artist.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label_artist.AutoSize = True
        Me.label_artist.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_artist.ForeColor = System.Drawing.Color.White
        Me.label_artist.Location = New System.Drawing.Point(10, 12)
        Me.label_artist.Name = "label_artist"
        Me.label_artist.Size = New System.Drawing.Size(0, 17)
        Me.label_artist.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.Controls.Add(Me.label_song)
        Me.Panel3.Location = New System.Drawing.Point(3, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(715, 34)
        Me.Panel3.TabIndex = 2
        '
        'label_song
        '
        Me.label_song.AutoSize = True
        Me.label_song.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_song.ForeColor = System.Drawing.Color.White
        Me.label_song.Location = New System.Drawing.Point(7, 6)
        Me.label_song.Name = "label_song"
        Me.label_song.Size = New System.Drawing.Size(0, 17)
        Me.label_song.TabIndex = 3
        '
        'Timer_Slidername
        '
        Me.Timer_Slidername.Interval = 135
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 214)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(721, 26)
        Me.Panel4.TabIndex = 3
        Me.Panel4.Visible = False
        '
        'Itone_Music_Player
        '
        Me.Itone_Music_Player.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Itone_Music_Player.Enabled = True
        Me.Itone_Music_Player.Location = New System.Drawing.Point(0, 39)
        Me.Itone_Music_Player.Name = "Itone_Music_Player"
        Me.Itone_Music_Player.OcxState = CType(resources.GetObject("Itone_Music_Player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Itone_Music_Player.Size = New System.Drawing.Size(721, 201)
        Me.Itone_Music_Player.TabIndex = 3
        '
        'Tab_NowPlaying
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Itone_Music_Player)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Tab_NowPlaying"
        Me.Size = New System.Drawing.Size(721, 280)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Itone_Music_Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents label_artist As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents label_song As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Itone_Music_Player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer_Slidername As Timer
    Friend WithEvents Panel4 As Panel
End Class
