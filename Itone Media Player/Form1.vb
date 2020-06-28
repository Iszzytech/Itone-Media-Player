Imports System.IO
Imports System.Speech
Imports Itone_Media_Player.Form2

Public Class Form1

    'Create repeat btn.
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


    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel_search.Paint

    End Sub

    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_playlistOFF_Click(sender As Object, e As EventArgs) Handles btn_playlistOFF.Click
        Form2.Show()
        btn_playlistON.Visible = True
        btn_playlistOFF.Visible = False
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        sidepanel.Height = btn_browse.Height
        sidepanel.Top = btn_browse.Top
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub btn_now_playing_Click(sender As Object, e As EventArgs) Handles btn_now_playing.Click
        sidepanel.Height = btn_now_playing.Height
        sidepanel.Top = btn_now_playing.Top
        Tab_NowPlaying1.BringToFront()
        Panel_top.Show()

    End Sub

    Private Sub btn_playlist_Click(sender As Object, e As EventArgs) Handles btn_playlist.Click
        sidepanel.Height = btn_playlist.Height
        sidepanel.Top = btn_playlist.Top
        Tab_Quick_Playlist1.BringToFront()
        Panel_top.Hide()

    End Sub

    Private Sub btn_favourites_Click(sender As Object, e As EventArgs) Handles btn_favourites.Click
        sidepanel.Height = btn_favourites.Height
        sidepanel.Top = btn_favourites.Top
        MessageBox.Show("Favourite Page Will Be Available In The Next Version", "Favourite Page", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_album_Click(sender As Object, e As EventArgs) Handles btn_album.Click
        sidepanel.Height = btn_album.Height
        sidepanel.Top = btn_album.Top
        MessageBox.Show("Album Page Will Be Available In The Next Version", "Album Page", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub BtnArtist()
        Tab_Artist1.BringToFront()
        Panel_top.Hide()
        sidepanel.Height = btn_artist.Height
        sidepanel.Top = btn_artist.Top
    End Sub
    Private Sub btn_artist_Click(sender As Object, e As EventArgs) Handles btn_artist.Click
        BtnArtist()

    End Sub
    Public Sub Btn_Settings()
        sidepanel.Height = btn_setting.Height
        sidepanel.Top = btn_setting.Top
        Tab_Settings1.BringToFront()
        Panel_top.Hide()
        '///////////  Refresh SLider Values /////////////
        Tab_Settings1.Tab_Transparent1.label_TR_value.Text = Tab_Settings1.Tab_Transparent1.slider_transparent.Value
        Tab_Settings1.Tab_Transparent1.Progressbar_slider.Value = Tab_Settings1.Tab_Transparent1.slider_transparent.Value
        '//////////                        /////////////
    End Sub
    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        Btn_Settings()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()

    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles shrink.Click
        mucat.Location = New Point(42, 449)
        mecat.Location = New Point(42, 130)
        Separator1.Width = 60
        btn_close.Visible = False
        btn_maximize.Visible = False
        btn_minimize.Visible = False
        Panel_search.Visible = False
        label_media.Visible = False
        label_music.Visible = False
        Separator2.Width = 60
        Expand.Location = New Point(42, 12)
        Panel_left.Width = 90

    End Sub

    Public Sub IMP_Write_File()
        Using WRiter As StreamWriter = New StreamWriter("ItoneMusicPlayer_Transparent-Settings")
            WRiter.WriteLine(Tab_Settings1.Tab_Transparent1.TextBox_write.Text)
            Tab_Settings1.Tab_Transparent1.TextBox_write.Text = Tab_Settings1.Tab_Transparent1.label_TR_value.Text

        End Using


    End Sub

    '///////////////////////////// STARTING UP THE VOICE ENGINE //////////////////////////////////
    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine
    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted
        reco.RecognizeAsync()

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized
        'Creating test Cases
        'Play,Stop,Next Audio,Previous Audio, Open File
        'Go to settings,Go to artist,  open quickplaylist, Go back, Exit ItoneMediaPlayer, Maximize, Minimize, Fullscreen , Halfscreen , Normalscreen, open playlist, Exit Playlist, play all
        ' Next Video,Previous Video,Previous song, Next song, Add Video, Add Audio
        Dim synth As New Synthesis.SpeechSynthesizer
        Select Case e.Result.Text
            Case "Play"
                Try
                    'Noting down when playlist is empty
                    Dim count As Integer = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items.Count
                    If Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.currentItem.name = "" AndAlso count <> 0 Then
                        Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.Playall_button()
                    End If

                    Tab_NowPlaying1.Timer_Slidername.Start()
                    Tab_Quick_Playlist1.Timer_textRunner.Start()
                    Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()
                    btn_pause.Hide()
                    btn_play.Show()

                Catch ex As Exception
                    Tab_NowPlaying1.Timer_Slidername.Start()
                    Tab_Quick_Playlist1.Timer_textRunner.Start()
                    Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()
                    btn_pause.Hide()
                    btn_play.Show()
                End Try
            '////////////////////////////
            Case "Stop"
                Try
                    Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.stop()
                    Tab_NowPlaying1.Timer_Slidername.Stop()
                    Tab_Quick_Playlist1.Timer_textRunner.Stop()
                    btn_pause.Show()
                    btn_play.Hide()
                Catch ex As Exception
                    Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.stop()
                    Tab_NowPlaying1.Timer_Slidername.Stop()
                    Tab_Quick_Playlist1.Timer_textRunner.Stop()
                    btn_pause.Show()
                    btn_play.Hide()
                End Try
            '///////////////////
            Case "Pause"
                Try
                    Tab_NowPlaying1.Timer_Slidername.Stop()
                    Tab_Quick_Playlist1.Timer_textRunner.Stop()
                    btn_pause.Show()
                    btn_play.Hide()
                    Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.pause()
                Catch ex As Exception
                    Tab_NowPlaying1.Timer_Slidername.Stop()
                    Tab_Quick_Playlist1.Timer_textRunner.Stop()
                    btn_pause.Show()
                    btn_play.Hide()
                    Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.pause()
                End Try
            '///////////////////
            Case "Next Audio"
                Try
                    NextSong()
                Catch ex As Exception
                    NextSong()
                End Try
            '/////////////
            Case "Previous Audio"
                Try
                    Previous_song()
                Catch ex As Exception
                    Previous_song()
                End Try
            '//////////////////
            Case "Open File"
                Try
                    sidepanel.Height = btn_browse.Height
                    sidepanel.Top = btn_browse.Top
                    OpenFileDialog1.ShowDialog()
                Catch ex As Exception
                    sidepanel.Height = btn_browse.Height
                    sidepanel.Top = btn_browse.Top
                    OpenFileDialog1.ShowDialog()
                End Try
            '///////////////////
            Case "Go to settings"
                Try

                    Btn_Settings()
                Catch ex As Exception
                    Btn_Settings()
                End Try
            '///////////////////
            Case "Go to artist"
                Try
                    BtnArtist()

                Catch ex As Exception
                    BtnArtist()
                End Try
            '///////////////////
            Case "open quickplaylist"
                Try
                    sidepanel.Height = btn_playlist.Height
                    sidepanel.Top = btn_playlist.Top
                    Tab_Quick_Playlist1.BringToFront()
                    Panel_top.Hide()

                Catch ex As Exception
                    sidepanel.Height = btn_playlist.Height
                    sidepanel.Top = btn_playlist.Top
                    Tab_Quick_Playlist1.BringToFront()
                    Panel_top.Hide()
                End Try
            '///////////////////
            Case "Go back"
                Try
                    sidepanel.Height = btn_now_playing.Height
                    sidepanel.Top = btn_now_playing.Top
                    Tab_NowPlaying1.BringToFront()
                    Panel_top.Show()
                Catch ex As Exception
                    sidepanel.Height = btn_now_playing.Height
                    sidepanel.Top = btn_now_playing.Top
                    Tab_NowPlaying1.BringToFront()
                    Panel_top.Show()
                End Try
            '///////////////////
            Case "Exit ItoneMediaPlayer"
                Try
                    Application.Exit()
                Catch ex As Exception
                    Application.Exit()
                End Try
            '///////////////////
            Case "Maximize"
                Try
                    MaximizeBtn()
                Catch ex As Exception
                    MaximizeBtn()
                End Try
            '///////////////////
            Case "Minimize"
                Try
                    WindowState = System.Windows.Forms.FormWindowState.Minimized
                Catch ex As Exception
                    WindowState = System.Windows.Forms.FormWindowState.Minimized
                End Try
            '///////////////////
            Case "Fullscreen"
                Try
                    FullScreen()
                Catch ex As Exception
                    FullScreen()
                End Try
            '//////////////////////
            Case "Halfscreen"
                Try
                    HalfScreen()
                Catch ex As Exception
                    HalfScreen()
                End Try
            '//////////////////////
            Case "Normalscreen"
                Try
                    If btn_fullscreenOFF.Visible = False Then
                        ExitFullScreen()
                    ElseIf btn_halfscreenOFF.Visible = False Then
                        ExitHalfScreen()
                    End If
                Catch ex As Exception
                    If btn_fullscreenOFF.Visible = False Then
                        ExitFullScreen()
                    ElseIf btn_halfscreenOFF.Visible = False Then
                        ExitHalfScreen()
                    End If
                End Try
            '//////////////////////
            Case "open playlist"
                Try
                    Form2.Show()
                    btn_playlistON.Visible = True
                    btn_playlistOFF.Visible = False
                Catch ex As Exception
                    Form2.Show()
                    btn_playlistON.Visible = True
                    btn_playlistOFF.Visible = False
                End Try
            '//////////////////////
            Case "Exit Playlist"
                Try
                    Me.Hide()
                    btn_playlistON.Visible = False
                    btn_playlistOFF.Visible = True
                Catch ex As Exception
                    Me.Hide()
                    btn_playlistON.Visible = False
                    btn_playlistOFF.Visible = True
                End Try
            '//////////////////////
            Case "play all"
                Try
                    Timer_SeekBar.Start()
                    Timer_SeekBar.Enabled = True
                    Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.SelectedIndex = 0
                    Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedIndex = 0
                    Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedItem
                Catch ex As Exception
                    Timer_SeekBar.Start()
                    Timer_SeekBar.Enabled = True
                    Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.SelectedIndex = 0
                    Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedIndex = 0
                    Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedItem
                End Try
            '//////////////////////
            Case "Next Video"
                Try
                    Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.Next_Video()
                Catch ex As Exception
                    Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.Next_Video()
                End Try
            '//////////////////////
            Case "Previous Video"
                Try
                    Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.Previous_Video()
                Catch ex As Exception
                    Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.Previous_Video()
                End Try
            '//////////////////////////
            Case "Previous Song"
                Try
                    Previous_song()
                Catch ex As Exception
                    Previous_song()
                End Try
            '////////////////////
            Case "Next Song"
                Try
                    NextSong()
                Catch ex As Exception
                    NextSong()
                End Try
            Case "Add Video"
                Try
                    Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.Add_Video()
                Catch ex As Exception
                    Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.Add_Video()
                End Try
            '//////////////////////////////
            Case "Add Audio"
                Try
                    Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.Addbutton()
                Catch ex As Exception
                    Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.Addbutton()
                End Try
        End Select
    End Sub

    Public Sub OpenMic()

        '//////////////////TESTING THE VOICE RECOGNITION///////////////////////

        reco.SetInputToDefaultAudioDevice()
        Dim gram As New Recognition.SrgsGrammar.SrgsDocument

        Dim ItoneMediaPlayerCMD As New Recognition.SrgsGrammar.SrgsRule("Command")
        Dim ItoneMediaPlayerCMDList As New Recognition.SrgsGrammar.SrgsOneOf("Play", "Stop", "Pause", "Next Audio", "Previous Audio", "Open File", "Go to settings", "Go to artist", "open quickplaylist", "Go back", "Exit ItoneMediaPlayer", "Maximize", "Minimize", "Fullscreen", "Halfscreen", "Normalscreen", "open playlist", "Exit Playlist", "play all", "Next Video", "Previous Video", "Previous Song", "Next Song", "Add Video", "Add Audio")
        ' play,stop,Next Audio, Previous Audio, Open File
        'Go to settings,Go to artist,  open quickplaylist, Go back, Exit ItoneMediaPlayer,
        'Maximize, Minimize, FullScreen, HalfScreen, Normalscreen, open playlist, Exit Playlist, play all
        ' Next Video,Previous Video,

        ItoneMediaPlayerCMD.Add(ItoneMediaPlayerCMDList)
        gram.Rules.Add(ItoneMediaPlayerCMD)
        gram.Root = ItoneMediaPlayerCMD

        reco.LoadGrammar(New Recognition.Grammar(gram))
        reco.RecognizeAsync()

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '/////////////////////// HOW UP MP3 FILES //////////////

        OpenFilesFromCommandLine() 'Calling the function to open it up

        'Set to defauistt audio device
        ' Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Hide()
        'Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Hide()

        'Itone_Media_Player.My.Forms.form_message.Label_Message.Text = "Your Mic Audio Device Not Found"
        'Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Insert Mic Device"




        Try
            Dim arraycount As Integer = 0
            Dim MusicDirectory As String = My.Computer.FileSystem.SpecialDirectories.MyMusic
            Dim MusicDirectoryInDesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

            If (MusicDirectory = "") Then
                MessageBox.Show("There are no music in your music directory")
            Else
                For Each File As String In My.Computer.FileSystem.GetFiles(MusicDirectory, FileIO.SearchOption.SearchAllSubDirectories, "*.mp3")
                    Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.Items.Add(My.Computer.FileSystem.GetFileInfo(File).Name)
                    Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items.Add(My.Computer.FileSystem.GetFileInfo(File).FullName)

                Next
                If (MusicDirectoryInDesktop = "") Then
                    MessageBox.Show("There are no music in your Desktop directory")
                Else
                    'Fetching Desktop Music Files
                    For Each File As String In My.Computer.FileSystem.GetFiles(MusicDirectoryInDesktop, FileIO.SearchOption.SearchAllSubDirectories, "*.mp3")
                        Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.Items.Add(My.Computer.FileSystem.GetFileInfo(File).Name)
                        Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items.Add(My.Computer.FileSystem.GetFileInfo(File).FullName)
                    Next

                End If
            End If


            'Fetching Document Music Files


            Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_1.Text = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.Items(0)
            Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_2.Text = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.Items(1)
            Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_3.Text = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.Items(2)
            Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_4.Text = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.Items(3)
            Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_5.Text = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.Items(4)
            Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_6.Text = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.Items(5)
            Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.label_track_name_7.Text = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.Items(6)

        Catch ex As Exception
            MessageBox.Show("Loading up music files...", "UPLOADING MUSIC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Music file Not found")

        End Try


        Timer_SeekBar.Enabled = True
        Me.ActiveControl = Panel_top




        Try
            Using REader2 As StreamReader = New StreamReader("ItoneMusicPlayer-volume.txt")
                TextBox_read.Text = REader2.ReadLine()
                Dim VoL As Integer = TextBox_read.Text
                Label_Volume.Text = VoL
                Slider_volume.Value = VoL


                Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.settings.volume = VoL
            End Using

            '////////////////////////////////////////////
            Using REader As StreamReader = New StreamReader("ItoneMusicPlayer_Transparent-Settings")

                Tab_Settings1.Tab_Transparent1.TextBox_read.Text = REader.ReadLine()

            End Using

            Dim VAL As String = Tab_Settings1.Tab_Transparent1.TextBox_read.Text
            Tab_Settings1.Tab_Transparent1.slider_transparent.Value = VAL
            Dim O As String = Tab_Settings1.Tab_Transparent1.TextBox_read.Text
            Opacity = O / 100


        Catch ex As Exception

        End Try


    End Sub

    Private Sub OpenFilesFromCommandLine()
        Dim strExt As String
        Dim fileContents As String
        Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
        For i As Integer = 0 To CommandLineArgs.Count - 1
            strExt = System.IO.Path.GetExtension(CommandLineArgs(i)) 'get the filename extension

            Select Case strExt


                Case ".mp3" 'This is to open a file with associated extension *.kay
                    ' If you need to associate your App to open any other extensions,
                    ' you can create a case for it just like this.
                    fileContents = My.Computer.FileSystem.ReadAllText(CommandLineArgs(i))
                    RichTextBox1.Text = fileContents


                    Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.label_song.Text = GetFileName(CommandLineArgs(i))

                    Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.label_song.Text
                Case ".mp4"
                    fileContents = My.Computer.FileSystem.ReadAllText(CommandLineArgs(i))
                    RichTextBox1.Text = fileContents
                    HalfScreen()
                    Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.label_song.Text = GetFileName(CommandLineArgs(i))
                    Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.label_song.Text
                Case ".mkv"
                    fileContents = My.Computer.FileSystem.ReadAllText(CommandLineArgs(i))
                    RichTextBox1.Text = fileContents
                    HalfScreen()
                    Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.label_song.Text = GetFileName(CommandLineArgs(i))
                    Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.label_song.Text
                Case Else
                    fileContents = My.Computer.FileSystem.ReadAllText(CommandLineArgs(i))
                    RichTextBox1.Text = fileContents

                    Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.label_song.Text = GetFileName(CommandLineArgs(i))
                    Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.label_song.Text
            End Select
        Next
        Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()
    End Sub
    '///////GETTING FILE NAME
    Private Function GetFileName(ByVal vStrFullPath As String) As String
        Dim intPos As Integer
        intPos = InStrRev(vStrFullPath, "\")
        GetFileName = Mid$(vStrFullPath, intPos + 1)
    End Function
    Private Sub Expand_Click(sender As Object, e As EventArgs) Handles Expand.Click
        mucat.Location = New Point(19, 446)
        mecat.Location = New Point(19, 127)
        btn_close.Visible = True
        Separator1.Width = 160
        Separator2.Width = 160
        btn_maximize.Visible = True
        btn_minimize.Visible = True
        Panel_search.Visible = True
        label_media.Visible = True
        label_music.Visible = True
        Expand.Location = New Point(203, 12)
        Panel_left.Width = 243

    End Sub

    Private Sub Panel_left_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_left.MouseDown
        isMouseDown = True
        mouseLocation = e.Location
    End Sub

    Private Sub Panel_left_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_left.MouseMove
        If (isMouseDown = True) Then
            Me.Location += e.Location - mouseLocation
        End If
    End Sub

    Private Sub Panel_left_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_left.MouseUp
        isMouseDown = False
    End Sub

    Private Sub Panel_bottom_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_bottom.MouseDown
        isMouseDown = True
        mouseLocation = e.Location
    End Sub

    Private Sub Panel_bottom_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_bottom.MouseMove
        If (isMouseDown = True) Then
            Me.Location += e.Location - mouseLocation
        End If
    End Sub

    Private Sub Panel_bottom_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_bottom.MouseUp
        isMouseDown = False
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click

        WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
    Public Sub MaximizeBtn()
        Dim myToolTipText1 = "Restore Down"
        Dim myToolTipText2 = "Maximize"
        If delt = False Then
            delt = True
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            ToolTip1.SetToolTip(Me.btn_maximize, myToolTipText1)
            Panel_top.BackgroundImage = My.Resources.ITONEZ_FINALE
            PictureBox2.Visible = False
        Else

            delt = False   'To reset boolean value
            WindowState = Dock = DockStyle.Fill
            ToolTip1.SetToolTip(Me.btn_maximize, myToolTipText2)
            Panel_top.BackgroundImage = My.Resources.ITONEZf
            PictureBox2.Visible = True
        End If
    End Sub
    Private Sub btn_maximize_Click(sender As Object, e As EventArgs) Handles btn_maximize.Click
        MaximizeBtn()
    End Sub

    Private Sub btn_playlistON_Click(sender As Object, e As EventArgs) Handles btn_playlistON.Click
        Form2.Hide()
        btn_playlistON.Visible = False
        btn_playlistOFF.Visible = True
    End Sub

    Private Sub btn_pause_Click(sender As Object, e As EventArgs) Handles btn_pause.Click
        Tab_NowPlaying1.Timer_Slidername.Start()
        Tab_Quick_Playlist1.Timer_textRunner.Start()
        Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()
        btn_pause.Hide()
        btn_play.Show()

    End Sub

    Private Sub btn_play_Click(sender As Object, e As EventArgs) Handles btn_play.Click
        Tab_NowPlaying1.Timer_Slidername.Stop()
        Tab_Quick_Playlist1.Timer_textRunner.Stop()
        Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.pause()
        btn_pause.Show()
        btn_play.Hide()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Tab_NowPlaying1.Itone_Music_Player.URL = OpenFileDialog1.FileName

    End Sub
    Public Sub FullScreen()



        Panel_left.Hide()
        Panel_top.Hide()
        Tab_NowPlaying1.label_artist.Hide()
        Tab_NowPlaying1.label_song.Hide()
        btn_fullscreenOFF.Visible = False
        btn_fullscreen.Visible = True
        btn_halfscreen.Visible = False
        btn_halfscreenOFF.Visible = True


        If delt = False Then
            delt = True
            WindowState = System.Windows.Forms.FormWindowState.Maximized
        Else
            delt = False
            WindowState = Dock = DockStyle.Fill

        End If
        Tab_NowPlaying1.Itone_Music_Player.SetBounds(0, 0, Me.Width, Me.Height)
        Try
            Tab_NowPlaying1.Itone_Music_Player.fullScreen = True

        Catch ex As Exception

        End Try

        Tab_NowPlaying1.Panel1.Hide()
        Tab_NowPlaying1.Panel2.Hide()
        Tab_NowPlaying1.Panel3.Hide()
        Tab_NowPlaying1.Panel4.Show()
    End Sub
    Private Sub btn_fullscreenOFF_Click(sender As Object, e As EventArgs) Handles btn_fullscreenOFF.Click
        FullScreen()
    End Sub
    Public Sub ExitFullScreen()

        Panel_left.Show()
        Panel_top.Show()
        Tab_NowPlaying1.label_artist.Show()

        Tab_NowPlaying1.label_song.Show()

        btn_fullscreenOFF.Visible = True
        btn_fullscreen.Visible = False

        If delt = False Then
            delt = True
            WindowState = System.Windows.Forms.FormWindowState.Maximized
        Else
            delt = False
            WindowState = Dock = DockStyle.Fill

        End If
        Tab_NowPlaying1.Panel1.Show()
        Tab_NowPlaying1.Panel2.Show()
        Tab_NowPlaying1.Panel3.Show()
        Tab_NowPlaying1.Panel4.Hide()
    End Sub
    Private Sub btn_fullscreen_Click(sender As Object, e As EventArgs) Handles btn_fullscreen.Click
        ExitFullScreen()

    End Sub
    Public Sub HalfScreen()
        Tab_NowPlaying1.label_song.Visible = False
        Tab_NowPlaying1.label_artist.Visible = False
        Tab_NowPlaying1.Itone_Music_Player.SetBounds(0, 0, Width, Height)
        Tab_NowPlaying1.Panel1.Hide()
        Tab_NowPlaying1.Panel2.Hide()
        Tab_NowPlaying1.Panel3.Hide()
        Panel_left.Hide()
        Panel_top.Hide()
        btn_halfscreen.Show()
        btn_halfscreenOFF.Hide()
        btn_fullscreenOFF.Visible = True
        btn_fullscreen.Visible = False
    End Sub
    Private Sub btn_halfscreenOFF_Click(sender As Object, e As EventArgs) Handles btn_halfscreenOFF.Click
        HalfScreen()
    End Sub
    Public Sub ExitHalfScreen()
        Tab_NowPlaying1.label_artist.Show()
        Tab_NowPlaying1.label_song.Show()
        Tab_NowPlaying1.Itone_Music_Player.SetBounds(0, 0, Width, Height)
        Tab_NowPlaying1.Panel1.Show()
        Tab_NowPlaying1.Panel2.Show()
        Tab_NowPlaying1.Panel3.Show()
        Panel_left.Show()
        Panel_top.Show()
        btn_halfscreen.Hide()
        btn_halfscreenOFF.Show()
    End Sub
    Private Sub btn_halfscreen_Click(sender As Object, e As EventArgs) Handles btn_halfscreen.Click
        ExitHalfScreen()
    End Sub

    Private Sub Timer_SeekBar_Tick(sender As Object, e As EventArgs) Handles Timer_SeekBar.Tick
        Try
            If Tab_NowPlaying1.Itone_Music_Player.URL = "" Then


            Else
                Tab_NowPlaying1.label_artist.Text = Tab_NowPlaying1.Itone_Music_Player.currentMedia.getItemInfo("Artist")

                Tab_NowPlaying1.label_song.Text = Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.currentItem.name()

                MediaName.Text = Tab_NowPlaying1.label_song.Text
                Timer_SeekBar.Start()
                Timer_SeekBar.Enabled = True
                Dim a As Integer
                a = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items.Count
                Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.label_available_song.Text = a & " " & "Available Songs"
                Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.label_available_song.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



        '////////////////////////////
        If (Tab_NowPlaying1.Itone_Music_Player.playState = WMPLib.WMPPlayState.wmppsPlaying) Then

            Tab_NowPlaying1.Timer_Slidername.Enabled = True

            Timer_SeekBar.Start()
            Timer_SeekBar.Enabled = True
            Tab_Quick_Playlist1.Timer_textRunner.Start()
            btn_play.Show()
            btn_pause.Hide()
            Label_Play_State.Text = "Playing"



        Else
            Label_Play_State.Text = "Ready to play"
            btn_play.Visible = False
            btn_pause.Visible = True
        End If
        '/////////////////////////////////
        If Slider_seek_bar.Value = Slider_seek_bar.Maximum Then
            Timer_SeekBar.Enabled = True


        End If
        '//////////////////////////////
        If (Tab_NowPlaying1.Itone_Music_Player.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
            Dim CurrentLength As String = Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.currentPositionString
            Dim MaxLength As String = Tab_NowPlaying1.Itone_Music_Player.currentMedia.durationString

            Slider_seek_bar.Maximum = Tab_NowPlaying1.Itone_Music_Player.currentMedia.duration
            Slider_seek_bar.Value = Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.currentPosition
            Label_MaxLength.Text = MaxLength
            Label_CurrentLength.Text = CurrentLength
        End If
        '////////////////////////////////
        Try
            If Labelmode.Text = "F" Then

                If (Tab_NowPlaying1.Itone_Music_Player.playState = WMPLib.WMPPlayState.wmppsStopped) Then


                    If (Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedIndex < Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items.Count - 1) Then

                        Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedIndex = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedIndex + 1

                        Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedItem
                        'Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.currentMedia.sourceURL
                        Timer_SeekBar.Start()
                        Timer_SeekBar.Enabled = True

                        Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()

                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        '////////////////////////////////////////////////
        Try
            If Labelmode.Text = "R" Then

                If (Tab_NowPlaying1.Itone_Music_Player.playState = WMPLib.WMPPlayState.wmppsStopped) Then


                    If (Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedIndex < Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items.Count - 1) Then

                        Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedIndex = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedIndex + 1

                        Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.currentMedia.sourceURL

                        Timer_SeekBar.Start()
                        Timer_SeekBar.Enabled = True

                        Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()

                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub Slider_seek_bar_MouseDown(sender As Object, e As MouseEventArgs) Handles Slider_seek_bar.MouseDown
        Timer_SeekBar.Enabled = False
    End Sub

    Private Sub Slider_seek_bar_MouseLeave(sender As Object, e As EventArgs) Handles Slider_seek_bar.MouseLeave
        Timer_SeekBar.Enabled = True
    End Sub

    Private Sub Slider_seek_bar_MouseUp(sender As Object, e As MouseEventArgs) Handles Slider_seek_bar.MouseUp
        Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.currentPosition = Slider_seek_bar.Value
        Timer_SeekBar.Enabled = True
    End Sub

    Private Sub Slider_volume_Scroll(sender As Object, e As ScrollEventArgs) Handles Slider_volume.Scroll
        Tab_NowPlaying1.Itone_Music_Player.settings.volume = Slider_volume.Value

        Label_Volume.Text = Slider_volume.Value
        Using Writer As StreamWriter = New StreamWriter("ItoneMusicPlayer-volume.txt")
            TextBox_write.Text = Slider_volume.Value
            Writer.WriteLine(TextBox_write.Text)
            Tab_NowPlaying1.Itone_Music_Player.settings.volume = Slider_volume.Value

        End Using
        If Slider_volume.Value = 0 Then
            Label_Volume.Text = 0
            btn_mute.Hide()
            btn_Volume_on.Show()
        Else
            btn_mute.Show()
            btn_Volume_on.Hide()

        End If
    End Sub

    Private Sub btn_mute_Click(sender As Object, e As EventArgs) Handles btn_mute.Click
        btn_mute.Hide()
        btn_Volume_on.Show()
        Tab_NowPlaying1.Itone_Music_Player.settings.mute = True
        Label_Volume.Text = 0
        Slider_volume.Value = 0


    End Sub

    Private Sub btn_Volume_on_Click(sender As Object, e As EventArgs) Handles btn_Volume_on.Click
        btn_mute.Show()
        btn_Volume_on.Hide()
        Try
            Using REader2 As StreamReader = New StreamReader("ItoneMusicPlayer-volume.txt")
                TextBox_read.Text = REader2.ReadLine()
                Dim VoL2 As Integer = TextBox_read.Text

                Slider_volume.Value = VoL2
                Label_Volume.Text = VoL2
                btn_mute.Show()
                btn_Volume_on.Hide()
                Tab_NowPlaying1.Itone_Music_Player.settings.volume = VoL2
            End Using
        Catch ex As Exception
            Tab_NowPlaying1.Itone_Music_Player.settings.volume = 5
        End Try

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
    Public Sub Previous_song()
        Dim b As Integer
        b = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items.Count

        If b = 0 Then
            Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Playlist Is currently empty"
            Itone_Media_Player.My.Forms.form_message.Label_Message.Text = "Please choose a media"
        End If
        Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedIndex = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.SelectedIndex

        Try
            Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.Timer1.Stop()
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ""
            Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.SelectedIndex = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.SelectedIndex - 1
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedItem
            Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.Timer1.Start()
        Catch ex As Exception
            Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Playlist Is over"
            Itone_Media_Player.My.Forms.form_message.Label_Message.Text = "Play again"
        End Try
    End Sub
    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click
        If Itone_Media_Player.My.Forms.Form2.btn_audio_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A") Then
            Previous_song()
        ElseIf Itone_Media_Player.My.Forms.Form2.btn_video_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A")
            Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.Previous_Video()
        Else
            Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Your Current Playlist Is over"
            Itone_Media_Player.My.Forms.form_message.Label_Message.Text = "Play again"
        End If

    End Sub
    Public Sub NextSong()
        Dim b As Integer
        b = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items.Count

        If b = 0 Then
            Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Playlist Is currently empty"
            Itone_Media_Player.My.Forms.form_message.Label_Message.Text = "Please choose a media"
        End If
        Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedIndex = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.SelectedIndex

        Try
            Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.Timer1.Stop()
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = ""
            Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.SelectedIndex = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.SelectedIndex + 1
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedItem
            Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.Timer1.Start()
        Catch ex As Exception
            Itone_Media_Player.My.Forms.form_message.btn_audio_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.btn_video_playlist.Show()
            Itone_Media_Player.My.Forms.form_message.Show()
            Itone_Media_Player.My.Forms.form_message.Label2_Message.Text = "Playlist Is over"
            Itone_Media_Player.My.Forms.form_message.Label_Message.Text = "Play again"
        End Try
    End Sub

    Private Sub btn_nxt_Click(sender As Object, e As EventArgs) Handles btn_nxt.Click
        If Itone_Media_Player.My.Forms.Form2.btn_audio_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A") Then
            NextSong()
        ElseIf Itone_Media_Player.My.Forms.Form2.btn_video_playlist.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0BAE5A")
            Itone_Media_Player.My.Forms.Form2.Tab_Video_Playlist1.Next_Video()

        End If

    End Sub

    Private Sub Slider_seek_bar_Scroll(sender As Object, e As ScrollEventArgs) Handles Slider_seek_bar.Scroll

    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Try
            Timer_SeekBar.Start()
            Timer_SeekBar.Enabled = True
            Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Name.SelectedIndex = 0
            Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedIndex = 0
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.SelectedItem
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles GunaGradientButton2.Click
        MessageBox.Show("Album Page Will Be Available In The Next Version", "Album Page", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_repeatOFF_Click(sender As Object, e As EventArgs) Handles btn_repeatOFF.Click
        Labelmode.Text = "R"
        'MessageBox.Show("Repeat Will Be Available In The Next Version", "Repeat Activation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Repeat turned on", "REPEAT ON", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btn_repeatOFF.Visible = False
        btn_repeat.Visible = True



    End Sub

    Private Sub Panel_top_MouseHover(sender As Object, e As EventArgs) Handles Panel_top.MouseHover
        'MessageBox.Show("Welcome to Itone Media Player, Start enjoying the flow of music by clicking on the playall button", "GUILDELINE", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_repeat_Click(sender As Object, e As EventArgs) Handles btn_repeat.Click
        Labelmode.Text = "F"
        MessageBox.Show("Repeat turned off", "REPEAT OFF", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btn_repeatOFF.Visible = True
        btn_repeat.Visible = False



    End Sub

    Private Sub Panel_bottom_Paint(sender As Object, e As PaintEventArgs) Handles Panel_bottom.Paint

    End Sub

    Private Sub music_search_MouseClick(sender As Object, e As MouseEventArgs) Handles music_search.MouseClick
        Me.music_search.Text = ""
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) > 1 Then
            MsgBox("You have pressed" & e.KeyChar)
        End If
    End Sub
End Class
