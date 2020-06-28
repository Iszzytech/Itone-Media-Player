Imports System.IO

Public Class Tab_Audio_Playlist
    Public Sub Addbutton()
        OpenFileDialog_Audio.Filter = "Video and Music Files (*.asf, *.wma, *.wmv, *.wm, *.asx, *.wax, *.wvx, *.wmx, *.wpl, *.dvr-ms, *.wmd, *.avi, *.mpg, *.mpeg, *.m1v, *.mp2, *.mp3, *.mpa, *.mpe, *.m3u, *.mid, *.midi, *.rmi. *.aif, *.aifc, *.aiff, *.au, *.snd, *.wav, *.cda, *.ivf, *.wmz, *.wms, *.mov, *.m4a, *.mp4, *.m4v, *.mp4v, *.3g2, *.3gp2, *.3gp, *.3gpp, *.aac, *.adt, *.adts, *.m2ts)|*.asf; *.wma; *.wmv; *.wm; *.asx; *.wax; *.wvx; *.wmx; *.wpl; *.dvr-ms; *.wmd; *.avi; *.mpg; *.mpeg; *.m1v; *.mp2; *.mp3; *.mpa; *.mpe; *.m3u; *.mid; *.midi; *.rmi. *.aif; *.aifc; *.aiff; *.au; *.snd; *.wav; *.cda; *.ivf; *.wmz; *.wms; *.mov; *.m4a; *.mp4; *.m4v; *.mp4v; *.3g2; *.3gp2; *.3gp; *.3gpp; *.aac; *.adt; *.adts; *.m2ts|All Files (*.*)|*.*"
        OpenFileDialog_Audio.ShowDialog()
        OpenFileDialog_Audio.Title = "Choose Your Audio Songs..."
        btn_remove.Enabled = True

        For Each FileName As String In OpenFileDialog_Audio.FileNames
            ListBox_Song_Path.Items.Add(FileName)
        Next
        ListBox_Song_Path.SelectedIndex = ListBox_Song_Path.SelectedIndex + 1
        For Each FileName2 As String In OpenFileDialog_Audio.SafeFileNames
            ListBox_Song_Name.Items.Add(FileName2)
        Next
        Dim i As Int16 = 0
        Dim T As String

        Try
            Do While 1 = 1
                T = ListBox_Song_Name.Items(i).ToString
                i = i + 1

            Loop
        Catch ex As Exception

        End Try

        Try


            If i.ToString = 0 Then
            ElseIf i.ToString = 1 Then
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_1.Text = ListBox_Song_Name.Items(0)

            ElseIf i.ToString = 2 Then
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_1.Text = ListBox_Song_Name.Items(0)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_2.Text = ListBox_Song_Name.Items(1)
            ElseIf i.ToString = 3 Then
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_1.Text = ListBox_Song_Name.Items(0)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_2.Text = ListBox_Song_Name.Items(1)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_3.Text = ListBox_Song_Name.Items(2)
            ElseIf i.ToString = 4 Then
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_1.Text = ListBox_Song_Name.Items(0)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_2.Text = ListBox_Song_Name.Items(1)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_3.Text = ListBox_Song_Name.Items(2)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_4.Text = ListBox_Song_Name.Items(3)
            ElseIf i.ToString = 5 Then
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_1.Text = ListBox_Song_Name.Items(0)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_2.Text = ListBox_Song_Name.Items(1)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_3.Text = ListBox_Song_Name.Items(2)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_4.Text = ListBox_Song_Name.Items(3)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_5.Text = ListBox_Song_Name.Items(4)
            ElseIf i.ToString = 6 Then
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_1.Text = ListBox_Song_Name.Items(0)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_2.Text = ListBox_Song_Name.Items(1)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_3.Text = ListBox_Song_Name.Items(2)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_4.Text = ListBox_Song_Name.Items(3)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_5.Text = ListBox_Song_Name.Items(4)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_6.Text = ListBox_Song_Name.Items(5)
            ElseIf i.ToString = 7 Then
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_1.Text = ListBox_Song_Name.Items(0)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_2.Text = ListBox_Song_Name.Items(1)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_3.Text = ListBox_Song_Name.Items(2)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_4.Text = ListBox_Song_Name.Items(3)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_5.Text = ListBox_Song_Name.Items(4)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_6.Text = ListBox_Song_Name.Items(5)
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_7.Text = ListBox_Song_Name.Items(6)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Addbutton()
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim A As Integer = ListBox_Song_Path.Items.Count

        If A = 0 Then
            btn_remove.Enabled = False
        ElseIf A = 2 Then
            btn_remove.Enabled = False
        Else
            btn_remove.Enabled = True
        End If
        Try
            ListBox_Song_Path.Items.Remove(ListBox_Song_Path.SelectedItem)
            ListBox_Song_Path.SelectedIndex = "0"

            ListBox_Song_Name.Items.Remove(ListBox_Song_Name.SelectedItem)
            ListBox_Song_Name.SelectedIndex = "1"

            ListBox_Song_Path.Items.Remove(ListBox_Song_Path.SelectedItem)
            ListBox_Song_Path.SelectedIndex = "2"

            ListBox_Song_Name.Items.Remove(ListBox_Song_Name.SelectedItem)
            ListBox_Song_Name.SelectedIndex = "3"

        Catch ex As Exception

        End Try
    End Sub

    Public Sub Playall_button()
        Try
            Dim A As Integer
            A = ListBox_Song_Path.Items.Count

            If A = 0 Then
                Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
                Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
                Itone_Media_Player.My.Forms.form_message.Show()
                Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Playlist is empty!"
                Itone_Media_Player.My.Forms.form_message.Label_Message.Text = "Please choose a media"
            End If
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ListBox_Song_Path.SelectedItem
            Itone_Media_Player.My.Forms.Form1.Slider_seek_bar.Value = Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.currentPosition
            Timer1.Start()
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btn_play_all_Click(sender As Object, e As EventArgs) Handles btn_play_all.Click
        Playall_button()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a As Integer
        a = ListBox_Song_Path.Items.Count
        label_available_song.Text = a & " " & "Available Songs"
        label_available_song.Visible = True
        Try

            If Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.playState = WMPLib.WMPPlayState.wmppsStopped Then

                If (ListBox_Song_Path.SelectedIndex < ListBox_Song_Path.Items.Count - 1) Then

                    ListBox_Song_Path.SelectedIndex = ListBox_Song_Path.SelectedIndex + 1

                    Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ListBox_Song_Path.SelectedItem

                    Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()

                End If

            End If
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Previous_Audio()
        Dim a As Integer
        a = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items.Count
        If a = 0 Then
            Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Playlist is currently empty"
            Itone_Media_Player.My.Forms.form_message.Label_Message.Text = "Please choose a media"
        End If
        ListBox_Song_Path.SelectedIndex = ListBox_Song_Name.SelectedIndex

        Try
            Timer1.Stop()
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ""
            ListBox_Song_Name.SelectedIndex = ListBox_Song_Name.SelectedIndex - 1
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ListBox_Song_Path.SelectedItem
            Timer1.Start()
        Catch ex As Exception
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "There you are in the first Audio track"
            Itone_Media_Player.My.Forms.form_message.Label_Message.Text = "You have selected the first audio track"
        End Try
    End Sub
    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Previous.Click
        Previous_Audio()
    End Sub
    Public Sub Next_audio()
        Dim b As Integer
        b = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items.Count

        If b = 0 Then
            Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Playlist is currently empty"
            Itone_Media_Player.My.Forms.form_message.Label_Message.Text = "Please choose a media"
        End If
        ListBox_Song_Path.SelectedIndex = ListBox_Song_Name.SelectedIndex

        Try
            Timer1.Stop()
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ""
            ListBox_Song_Name.SelectedIndex = ListBox_Song_Name.SelectedIndex + 1
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ListBox_Song_Path.SelectedItem
            Timer1.Start()
        Catch ex As Exception
            Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.Text = "Playlist is over"
            Itone_Media_Player.My.Forms.form_message.Text = "Play again"
        End Try
    End Sub
    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        Next_audio()
    End Sub

    Private Sub ListBox_Song_Name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Song_Name.SelectedIndexChanged
        Try
            ListBox_Song_Path.SelectedIndex = ListBox_Song_Name.SelectedIndex
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListBox_Song_Name_DoubleClick(sender As Object, e As EventArgs) Handles ListBox_Song_Name.DoubleClick
        Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ListBox_Song_Path.SelectedItem

    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        Form1.OpenMic()
    End Sub

    Private Sub ListBox_Song_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListBox_Song_Name.KeyPress

        Try
            If e.KeyChar = Chr(13) Then
                '//////////////////////// Playing the file ///////////////

                's Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = CType(Me.ListBox_Song_Path.SelectedItem)
                Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Timer_Slidername.Start()
                Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.Timer_textRunner.Start()
                Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()
                Itone_Media_Player.My.Forms.Form1.btn_pause.Hide()
                Itone_Media_Player.My.Forms.Form1.btn_play.Show()
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class
