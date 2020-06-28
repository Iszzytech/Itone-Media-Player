Public Class Tab_Audio_Command

    Public Sub default_white()
        btn_volume.ForeColor = Color.White
        btn_listening.ForeColor = Color.White
        btn_recording.ForeColor = Color.White
        btn_microphone.ForeColor = Color.White


    End Sub
    Private Sub btn_themes_Click(sender As Object, e As EventArgs) Handles btn_volume.Click
        Tab_Volume1.BringToFront()
        default_white()
        btn_volume.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub btn_transparent_Click(sender As Object, e As EventArgs) Handles btn_listening.Click
        Tab_Listening1.BringToFront()
        default_white()
        btn_listening.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub btn_voice_assistant_Click(sender As Object, e As EventArgs) Handles btn_recording.Click
        Tab_Recording1.BringToFront()
        default_white()
        btn_recording.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub btn_microphone_Click(sender As Object, e As EventArgs) Handles btn_microphone.Click
        Tab_Microphone1.BringToFront()
        default_white()
        btn_microphone.ForeColor = Color.DarkSeaGreen
    End Sub
End Class
