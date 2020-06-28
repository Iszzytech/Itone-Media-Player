Public Class Form2
    Inherits System.Windows.Forms.Form



    Dim mouseLocation As Point
    Dim isMouseDown As Boolean = False

    Dim delt As Boolean = False

    Dim x As Integer
    Dim strPost As String

    Private m_MoveStartPos As Point
    Private m_MouseDown As Boolean

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            m_MouseDown = True
            m_MoveStartPos = e.Location

        End If

        'The following line is commented out so usercontrol doesnt take the focus away from other controls on the form
        MyBase.OnMouseDown(e)

    End Sub 'OnMouseDown

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            m_MouseDown = False

        End If

        MyBase.OnMouseUp(e)

    End Sub 'OnMouseUp

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If m_MouseDown Then
            Me.Location = New Point(Me.Location.X + e.X - m_MoveStartPos.X, Me.Location.Y + e.Y - m_MoveStartPos.Y)

        End If

        MyBase.OnMouseMove(e)

    End Sub 'OnMouseMove

    Public Sub default_white()
        btn_album_playlist.ForeColor = Color.White
        btn_audio_playlist.ForeColor = Color.White
        btn_video_playlist.ForeColor = Color.White
        btn_camera_playlist.ForeColor = Color.White
        btn_favourites_playlist.ForeColor = Color.White
        btn_playlist_adjustment.ForeColor = Color.White

    End Sub
    Private Sub Panel_top_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_top.MouseDown
        isMouseDown = True
        mouseLocation = e.Location
    End Sub

    Private Sub Panel_top_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_top.MouseMove
        If (isMouseDown = True) Then
            Me.Location += e.Location - mouseLocation
        End If
    End Sub

    Private Sub Panel_top_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_top.MouseUp
        isMouseDown = False
    End Sub
    Private Sub btn_audio_playlist_Click(sender As Object, e As EventArgs) Handles btn_audio_playlist.Click
        Tab_Audio_Playlist1.BringToFront()
        default_white()
        btn_audio_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A")

    End Sub

    Private Sub btn_video_playlist_Click(sender As Object, e As EventArgs) Handles btn_video_playlist.Click
        Tab_Video_Playlist1.BringToFront()
        default_white()
        btn_video_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_maximize_Click(sender As Object, e As EventArgs) Handles btn_maximize.Click
        Dim myToolTipText1 = "Restore Down"
        Dim myToolTipText2 = "Maximize"
        If delt = False Then
            delt = True
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            ToolTip1.SetToolTip(Me.btn_maximize, myToolTipText1)

        Else

            delt = False   'To reset boolean value
            WindowState = Dock = DockStyle.Fill
            ToolTip1.SetToolTip(Me.btn_maximize, myToolTipText2)

        End If
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Hide()
        Form1.btn_playlistON.Visible = False
        Form1.btn_playlistOFF.Visible = True
    End Sub

    Private Sub btn_favourites_playlist_Click(sender As Object, e As EventArgs) Handles btn_favourites_playlist.Click
        default_white()
        btn_favourites_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A")
    End Sub

    Private Sub btn_album_playlist_Click(sender As Object, e As EventArgs) Handles btn_album_playlist.Click
        default_white()
        btn_album_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A")
    End Sub

    Private Sub btn_camera_playlist_Click(sender As Object, e As EventArgs) Handles btn_camera_playlist.Click
        default_white()
        btn_camera_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A")
    End Sub

    Private Sub btn_playlist_adjustment_Click(sender As Object, e As EventArgs) Handles btn_playlist_adjustment.Click
        default_white()
        btn_playlist_adjustment.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A")
    End Sub

    Private Sub Tab_Audio_Playlist1_Load(sender As Object, e As EventArgs) Handles Tab_Audio_Playlist1.Load

    End Sub
End Class