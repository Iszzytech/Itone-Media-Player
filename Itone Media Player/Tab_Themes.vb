Public Class Tab_Themes
    'Picture box zoom size
    Dim w As Integer = 210
    Dim h As Integer = 165
    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub picturebox_size()
        'Noting down picture box default size
        Dim width As Integer = 178
        Dim height As Integer = 135

        PictureBox1.Width = width
        PictureBox1.Height = height
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_MouseEnter_1(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        If PictureBox1.Width = 178 AndAlso PictureBox1.Height = 135 Then
            PictureBox1.Height = h
            PictureBox1.Width = w
        End If
    End Sub

    Private Sub Panel_back_MouseEnter(sender As Object, e As EventArgs) Handles Panel_back.MouseEnter
        'reset picture box size
        picturebox_size()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub
End Class
