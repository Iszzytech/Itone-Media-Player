'NOTING THINGS LEFT TO DO
'Quickplaylist do up to 40
'shuffle btn
'repeat all
'repeat once btn
Public Class form_message
    Inherits System.Windows.Forms.Form
    Private Sub form_message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuFormFadeTransition1.ShowAsyc(Me)

    End Sub

    Private Sub GunaImageButton1_Click(sender As Object, e As EventArgs) Handles GunaImageButton1.Click
        Me.Hide()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Hide()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If Itone_Media_Player.My.Forms.Form2.btn_audio_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A") Then
            Try
                Dim S As Integer = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items.Count
                Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedItem = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(0)
                Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedItem
                Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.Playall_button()
            Catch ex As Exception

            End Try


        ElseIf Itone_Media_Player.My.Forms.Form2.btn_video_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A")

            Try
                Dim S As Integer = Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.ListBox2_songpath.Items.Count
                Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.ListBox2_songpath.SelectedItem = Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.ListBox2_songpath.Items(0)
                Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.ListBox2_songpath.SelectedItem
                Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.play_all_video()
            Catch ex As Exception

            End Try

        End If


    End Sub

    Private Sub Label_Message_Click(sender As Object, e As EventArgs) Handles Label_Message.Click

    End Sub

    Private Sub btn_audio_playlist_Click(sender As Object, e As EventArgs) Handles btn_audio_playlist.Click
        Me.Hide()
        Itone_Media_Player.My.Forms.Form2.btn_audio_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A")
        Itone_Media_Player.My.Forms.Form2.btn_video_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff")
        Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.BringToFront()
    End Sub

    Private Sub btn_video_playlist_Click(sender As Object, e As EventArgs) Handles btn_video_playlist.Click
        Me.Hide()
        Itone_Media_Player.My.Forms.Form2.btn_video_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A")
        Itone_Media_Player.My.Forms.Form2.btn_audio_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff")
        Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.BringToFront()
    End Sub
End Class