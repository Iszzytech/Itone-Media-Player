Public Class Tab_Video_Playlist

    Public Sub play_all_video()
        Dim A As Integer
        A = ListBox2_songpath.Items.Count

        If A = 0 Then
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Playlist is empty!"
            Itone_Media_Player.My.Forms.form_message.Label_Message.Text = "Please choose a media"
        End If
        Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ListBox2_songpath.SelectedItem
        Timer1.Start()
    End Sub
    Private Sub btn_play_all_Click(sender As Object, e As EventArgs) Handles btn_play_all.Click
        play_all_video()
    End Sub
    Public Sub Previous_Video()

        Dim a As Integer
        a = Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.ListBox2_songpath.Items.Count
        If a = 0 Then
            Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Playlist is currently empty"
            Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Please choose a media"
        End If
        ListBox2_songpath.SelectedIndex = ListBox1_songname.SelectedIndex
        Try
            Timer1.Stop()
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ""
            ListBox1_songname.SelectedIndex = ListBox1_songname.SelectedIndex - 1
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ListBox2_songpath.SelectedItem
            Timer1.Start()
        Catch ex As Exception
            Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.Text = "There you are in first Video track"


        End Try
    End Sub
    Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click
        Previous_Video()
    End Sub
    Public Sub Next_Video()


        Dim b As Integer
        b = Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.ListBox2_songpath.Items.Count

        If b = 0 Then
            Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Video Playlist is currently empty"
            Itone_Media_Player.My.Forms.form_message.Label_Message.Text = "Please choose a media"
        End If
        ListBox2_songpath.SelectedIndex = ListBox1_songname.SelectedIndex

        Try
            Timer1.Stop()

            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ""
            ListBox1_songname.SelectedIndex = ListBox1_songname.SelectedIndex + 1
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ListBox2_songpath.SelectedItem
            Timer1.Start()
        Catch ex As Exception
            Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Playlist is over"
            Itone_Media_Player.My.Forms.form_message.Label_Message.Text = "Play again"

        End Try
    End Sub
    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        Next_Video()
    End Sub
    Public Sub Add_Video()
        OpenFileDialog_video.Filter = "Video Files(*.mp4;*.wma;*.wmv;*.wm;*.asf;*.m2ts;*.avi;*.ivf;*.mov;*.m4v;*.3gp;*.3gp2;*.3g2;*.3gpp)|*.mp4;*.wma;*.wmv;*.wm;*.asf;*.m2ts;*.avi;*.ivf;*.mov;*.m4v;*.3gp;*.3gp2;*.3g2;*.3gpp"
        OpenFileDialog_video.ShowDialog()
        OpenFileDialog_video.Title = "Choose Your Video Files..."
        btn_remove.Enabled = True

        For Each FileName As String In OpenFileDialog_video.FileNames
            ListBox2_songpath.Items.Add(FileName)

        Next
        ListBox2_songpath.SelectedIndex = ListBox2_songpath.SelectedIndex + 1
        For Each FileName2 As String In OpenFileDialog_video.SafeFileNames
            ListBox1_songname.Items.Add(FileName2)
        Next
        Dim i As Int16 = 0
        Dim T As String

        Try
            Do While 1 = 1
                T = ListBox1_songname.Items(i).ToString()
                i = i + 1

            Loop
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Add_Video()
    End Sub

    Private Sub ListBox1_songname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1_songname.SelectedIndexChanged
        Try
            ListBox2_songpath.SelectedIndex = ListBox1_songname.SelectedIndex
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListBox1_songname_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1_songname.DoubleClick
        Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ListBox2_songpath.SelectedItem
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim A As Integer = ListBox2_songpath.Items.Count

        If A = 0 Then
            btn_remove.Enabled = False
        ElseIf A = 2 Then
            btn_remove.Enabled = False
        Else
            btn_remove.Enabled = True
        End If
        Try
            ListBox2_songpath.Items.Remove(ListBox2_songpath.SelectedItem)
            ListBox2_songpath.SelectedIndex = 0

            ListBox1_songname.Items.Remove(ListBox1_songname.SelectedItem)
            ListBox1_songname.SelectedIndex = 0

            ListBox2_songpath.Items.Remove(ListBox2_songpath.SelectedItem)
            ListBox2_songpath.SelectedIndex = 1

            ListBox1_songname.Items.Remove(ListBox1_songname.SelectedItem)
            ListBox1_songname.SelectedIndex = 1

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a As Integer
        a = ListBox2_songpath.Items.Count
        label_available_song.Text = a & " " & "Available Videos"

        Try
            Dim itemNo As Integer
            itemNo = ListBox2_songpath.SelectedIndex
            If Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.playState = WMPLib.WMPPlayState.wmppsStopped Then
                ListBox2_songpath.SelectedIndex = itemNo + 1
                Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ListBox2_songpath.SelectedItem
                Timer1.Start()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        Form1.OpenMic()
    End Sub
End Class
