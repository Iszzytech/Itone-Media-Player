Public Class Tab_Artist
    Private Sub btn_album_playlist_Click(sender As Object, e As EventArgs) Handles btn_nigeria.Click
        Tab_Nigerian_artist1.BringToFront()
        hide_slide()
        BunifuSeparator4.Visible = True
    End Sub

    Private Sub btn_camera_playlist_Click(sender As Object, e As EventArgs) Handles btn_blues.Click
        Tab_blues_artist1.BringToFront()
        hide_slide()
        BunifuSeparator3.Visible = True
    End Sub
    'hide the slider function
    Public Sub hide_slide()
        BunifuSeparator1.Visible = False
        BunifuSeparator2.Visible = False
        BunifuSeparator3.Visible = False
        BunifuSeparator4.Visible = False
        BunifuSeparator5.Visible = False
    End Sub
    Private Sub btn_hiphop_Click(sender As Object, e As EventArgs) Handles btn_hiphop.Click
        Tab_hiphop_artist1.BringToFront()
        hide_slide()
        BunifuSeparator1.Visible = True

    End Sub

    Private Sub btn_gospel_Click(sender As Object, e As EventArgs) Handles btn_gospel.Click
        Tab_Gospel_artist1.BringToFront()
        hide_slide()
        BunifuSeparator2.Visible = True
    End Sub

    Private Sub btn_favour_Click(sender As Object, e As EventArgs) Handles btn_favour.Click
        Tab_Favourite_Artist1.BringToFront()
        hide_slide()
        BunifuSeparator5.Visible = True
    End Sub






End Class
