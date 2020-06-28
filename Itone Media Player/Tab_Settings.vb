Public Class Tab_Settings
    Private Sub btn_themes_Click(sender As Object, e As EventArgs) Handles btn_themes.Click
        Tab_Themes1.BringToFront()
        default_white()
        btn_themes.ForeColor = Color.DarkSeaGreen

    End Sub

    Private Sub Tab_Themes1_Load(sender As Object, e As EventArgs) Handles Tab_Themes1.Load

    End Sub
    Public Sub default_white()
        btn_themes.ForeColor = Color.White
        btn_transparent.ForeColor = Color.White
        btn_voice_assistant.ForeColor = Color.White
        btn_audio_panel.ForeColor = Color.White
        btn_about.ForeColor = Color.White


    End Sub
    Private Sub btn_transparent_Click(sender As Object, e As EventArgs) Handles btn_transparent.Click
        Tab_Transparent1.BringToFront()
        default_white()
        btn_transparent.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub btn_voice_assistant_Click(sender As Object, e As EventArgs) Handles btn_voice_assistant.Click
        Tab_Voice_Assistant1.BringToFront()
        default_white()
        btn_voice_assistant.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub btn_audio_panel_Click(sender As Object, e As EventArgs) Handles btn_audio_panel.Click
        Tab_Audio_Command1.BringToFront()
        default_white()
        btn_audio_panel.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub btn_about_Click(sender As Object, e As EventArgs) Handles btn_about.Click
        Tab_About1.BringToFront()
        default_white()
        btn_about.ForeColor = Color.DarkSeaGreen
    End Sub
End Class
