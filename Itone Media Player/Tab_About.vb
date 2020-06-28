Public Class Tab_About
    Private Sub PictureBox_profile_Click(sender As Object, e As EventArgs) Handles PictureBox_profile.Click
        '134, 136
        PictureBox_profile.Width = 144
        PictureBox_profile.Height = 146
    End Sub

    Private Sub PictureBox_profile_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_profile.MouseEnter
        PictureBox_profile.Width = 144
        PictureBox_profile.Height = 146
    End Sub

    Private Sub Panel_back_abt_MouseEnter(sender As Object, e As EventArgs) Handles Panel_back_abt.MouseEnter
        PictureBox_profile.Width = 134
        PictureBox_profile.Height = 136
    End Sub
End Class
