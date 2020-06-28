Public Class Tab_Quick_Playlist
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        btn_play1.Visible = False
        btn_pause1.Visible = True
    End Sub

    Private Sub BunifuImageButton11_Click(sender As Object, e As EventArgs) Handles btn_pause1.Click
        btn_pause1.Hide()
        btn_play1.Hide()
        btn_pause1_1.Show()
        Form1.btn_pause.Show()
        Form1.btn_play.Hide()
        gif1.Visible = False
        Timer_textRunner.Stop()
        Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.pause()
    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles btn_play1.Click

        btn_play1.Visible = False
        btn_pause1.Visible = True
        btn_pause1_1.Visible = False

        gif1.Visible = True
        Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.Timer_textRunner.Start()
        Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.label_available_song.Visible = True
        Try
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(0)
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles btn_play2.Click

        btn_play2.Visible = False
        btn_pause2.Visible = True
        btn_pause2_2.Visible = False

        gif2.Visible = True
        Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.Timer_textRunner.Start()
        Try
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(1)
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BunifuImageButton22_Click(sender As Object, e As EventArgs) Handles btn_pause2.Click
        btn_pause2.Hide()
        btn_play2.Hide()
        btn_pause2_2.Show()
        Form1.btn_pause.Show()
        Form1.btn_play.Hide()
        gif2.Visible = False
        Timer_textRunner.Stop()
        Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.pause()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles btn_play3.Click
        btn_play3.Visible = False
        btn_pause3.Visible = True
        btn_pause3_3.Visible = False

        gif3.Visible = True
        Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.Timer_textRunner.Start()
        Try
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(2)
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BunifuImageButton33_Click(sender As Object, e As EventArgs) Handles btn_pause3.Click
        btn_pause3.Hide()
        btn_play3.Hide()
        btn_pause3_3.Show()
        Form1.btn_pause.Show()
        Form1.btn_play.Hide()
        gif3.Visible = False
        Timer_textRunner.Stop()
        Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.pause()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles btn_play4.Click
        btn_play4.Visible = False
        btn_pause4.Visible = True
        btn_pause4_4.Visible = False

        gif4.Visible = True
        Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.Timer_textRunner.Start()
        Try
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(3)
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BunifuImageButton444_Click(sender As Object, e As EventArgs) Handles btn_pause4.Click
        btn_pause4.Hide()
        btn_play4.Hide()
        btn_pause4_4.Show()
        Form1.btn_pause.Show()
        Form1.btn_play.Hide()
        gif4.Visible = False
        Timer_textRunner.Stop()
        Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.pause()
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles btn_play5.Click
        btn_play5.Visible = False
        btn_pause5.Visible = True
        btn_pause5_5.Visible = False
        gif5.Visible = True
        Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.Timer_textRunner.Start()
        Try
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(4)
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BunifuImageButton55_Click(sender As Object, e As EventArgs) Handles btn_pause5.Click
        btn_pause5.Hide()
        btn_play5.Hide()
        btn_pause5_5.Show()
        Form1.btn_pause.Show()
        Form1.btn_play.Hide()
        gif5.Visible = False
        Timer_textRunner.Stop()
        Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.pause()
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles btn_play6.Click
        btn_play6.Visible = False
        btn_pause6.Visible = True
        btn_pause6_6.Visible = False
        gif6.Visible = True
        Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.Timer_textRunner.Start()
        Try
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(5)
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BunifuImageButton66_Click(sender As Object, e As EventArgs) Handles btn_pause6.Click
        btn_pause6.Hide()
        btn_play6.Hide()
        btn_pause6_6.Show()
        Form1.btn_pause.Show()
        Form1.btn_play.Hide()
        gif6.Visible = False
        Timer_textRunner.Stop()
        Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.pause()
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles btn_play7.Click
        btn_play7.Visible = False
        btn_pause7.Visible = True
        btn_pause7_7.Visible = False
        gif7.Visible = True
        Itone_Media_Player.My.Forms.Form1.Tab_Quick_Playlist1.Timer_textRunner.Start()
        Try
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(6)
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BunifuImageButton77_Click(sender As Object, e As EventArgs) Handles btn_pause7.Click
        btn_pause7.Hide()
        btn_play7.Hide()
        btn_pause7_7.Show()
        Form1.btn_pause.Show()
        Form1.btn_play.Hide()
        gif7.Visible = False
        Timer_textRunner.Stop()
        Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.pause()
    End Sub

    Private Sub Timer_textRunner_Tick(sender As Object, e As EventArgs) Handles Timer_textRunner.Tick
        Try

            If Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(0) Then
                label_track_name_1.Left = label_track_name_1.Left - 10
                'first playlist activated
                btn_play1.Visible = False
                btn_pause1.Visible = True
                gif1.Visible = True
                track1_length.Text = Form1.Label_CurrentLength.Text
                'Second playlist deactivated
                btn_play2.Visible = True
                btn_pause2.Visible = False
                gif2.Visible = False
                track2_length.Text = ""
                'Third playlist deactivated
                btn_play3.Visible = True
                btn_pause3.Visible = False
                gif3.Visible = False
                track3_length.Text = ""
                'Fourth playlist deactivated
                btn_play4.Visible = True
                btn_pause4.Visible = False
                gif4.Visible = False
                track4_length.Text = ""
                'Fifth playlist deactivated
                btn_play5.Visible = True
                btn_pause5.Visible = False
                gif5.Visible = False
                track5_length.Text = ""
                'Sixth playlist deactivated
                btn_play6.Visible = True
                btn_pause6.Visible = False
                gif6.Visible = False
                track6_length.Text = ""
                'Seventh playlist deactivated
                btn_play7.Visible = True
                btn_pause7.Visible = False
                gif7.Visible = False
                track7_length.Text = ""
                If label_track_name_1.Left + label_track_name_1.Left <= 0 Then
                    label_track_name_1.Left = PanelA.Width
                End If
            End If
            '/////////////////////////////// A DONE
            If Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(1) Then
                label_track_name_2.Left = label_track_name_2.Left - 10
                'first playlist deactivated
                btn_play1.Visible = True
                btn_pause1.Visible = False
                gif1.Visible = False
                track1_length.Text = ""
                'Third playlist deactivated
                btn_play3.Visible = True
                btn_pause3.Visible = False
                gif3.Visible = False
                track3_length.Text = ""
                'Fourth playlist deactivated
                btn_play4.Visible = True
                btn_pause4.Visible = False
                gif4.Visible = False
                track4_length.Text = ""
                'Fifth playlist deactivated
                btn_play5.Visible = True
                btn_pause5.Visible = False
                gif5.Visible = False
                track5_length.Text = ""
                'Applying new changes to the next playlist
                btn_play2.Visible = False
                btn_pause2.Visible = True
                gif2.Visible = True
                track2_length.Text = Form1.Label_CurrentLength.Text
                'Sixth playlist deactivated
                btn_play6.Visible = True
                btn_pause6.Visible = False
                gif6.Visible = False
                track6_length.Text = ""
                'Seventh playlist deactivated
                btn_play7.Visible = True
                btn_pause7.Visible = False
                gif7.Visible = False
                track7_length.Text = ""
                If label_track_name_2.Left + label_track_name_2.Left <= 0 Then
                    label_track_name_2.Left = PanelB.Width
                End If
            End If
            '///////////////////////////// B DONE
            If Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(2) Then
                label_track_name_3.Left = label_track_name_3.Left - 10
                'first playlist deactivated
                btn_play1.Visible = True
                btn_pause1.Visible = False
                gif1.Visible = False
                track1_length.Text = ""
                'Second playlist deactivated
                btn_play2.Visible = True
                btn_pause2.Visible = False
                gif2.Visible = False
                track2_length.Text = ""
                'Applying new changes to the next playlist
                btn_play3.Visible = False
                btn_pause3.Visible = True
                gif3.Visible = True
                track3_length.Text = Form1.Label_CurrentLength.Text
                'Fourth playlist deactivated
                btn_play4.Visible = True
                btn_pause4.Visible = False
                gif4.Visible = False
                track4_length.Text = ""
                'Fifth playlist deactivated
                btn_play5.Visible = True
                btn_pause5.Visible = False
                gif5.Visible = False
                track5_length.Text = ""
                'Sixth playlist deactivated
                btn_play6.Visible = True
                btn_pause6.Visible = False
                gif6.Visible = False
                track6_length.Text = ""
                'Seventh playlist deactivated
                btn_play7.Visible = True
                btn_pause7.Visible = False
                gif7.Visible = False
                track7_length.Text = ""
                If label_track_name_3.Left + label_track_name_3.Left <= 0 Then
                    label_track_name_3.Left = PanelC.Width
                End If
            End If
            '////////////////////////////////// C DONE
            If Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(3) Then
                label_track_name_4.Left = label_track_name_4.Left - 10
                'first playlist deactivated
                btn_play1.Visible = True
                btn_pause1.Visible = False
                gif1.Visible = False
                track1_length.Text = ""
                'Second playlist deactivated
                btn_play2.Visible = True
                btn_pause2.Visible = False
                gif2.Visible = False
                track2_length.Text = ""
                'Third playlist deactivated
                btn_play3.Visible = True
                btn_pause3.Visible = False
                gif3.Visible = False
                track3_length.Text = ""
                'Applying new changes to the next playlist
                btn_play4.Visible = False
                btn_pause4.Visible = True
                gif4.Visible = True
                track4_length.Text = Form1.Label_CurrentLength.Text
                'Fifth playlist deactivated
                btn_play5.Visible = True
                btn_pause5.Visible = False
                gif5.Visible = False
                track5_length.Text = ""
                'Sixth playlist deactivated
                btn_play6.Visible = True
                btn_pause6.Visible = False
                gif6.Visible = False
                track6_length.Text = ""
                'Seventh playlist deactivated
                btn_play7.Visible = True
                btn_pause7.Visible = False
                gif7.Visible = False
                track7_length.Text = ""
                If label_track_name_4.Left + label_track_name_4.Left <= 0 Then
                    label_track_name_4.Left = PanelD.Width
                End If
            End If
            '/////////////////////////////// D DONE
            If Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(4) Then
                label_track_name_5.Left = label_track_name_5.Left - 10
                'first playlist deactivated
                btn_play1.Visible = True
                btn_pause1.Visible = False
                gif1.Visible = False
                track1_length.Text = ""
                'Second playlist deactivated
                btn_play2.Visible = True
                btn_pause2.Visible = False
                gif2.Visible = False
                track2_length.Text = ""
                'Third playlist deactivated
                btn_play3.Visible = True
                btn_pause3.Visible = False
                gif3.Visible = False
                track3_length.Text = ""
                'Fourth playlist deactivated
                btn_play4.Visible = True
                btn_pause4.Visible = False
                gif4.Visible = False
                track4_length.Text = ""
                'Applying new changes to the next playlist
                btn_play5.Visible = False
                btn_pause5.Visible = True
                gif5.Visible = True
                track5_length.Text = Form1.Label_CurrentLength.Text
                'Sixth playlist deactivated
                btn_play6.Visible = True
                btn_pause6.Visible = False
                gif6.Visible = False
                track6_length.Text = ""
                'Seventh playlist deactivated
                btn_play7.Visible = True
                btn_pause7.Visible = False
                gif7.Visible = False
                track7_length.Text = ""
                If label_track_name_5.Left + label_track_name_5.Left <= 0 Then
                    label_track_name_5.Left = PanelE.Width
                End If
            End If
            '////////////////////////////// E DONE
            If Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(5) Then
                label_track_name_6.Left = label_track_name_6.Left - 10
                'first playlist deactivated
                btn_play1.Visible = True
                btn_pause1.Visible = False
                gif1.Visible = False
                track1_length.Text = ""
                'Second playlist deactivated
                btn_play2.Visible = True
                btn_pause2.Visible = False
                gif2.Visible = False
                track2_length.Text = ""
                'Third playlist deactivated
                btn_play3.Visible = True
                btn_pause3.Visible = False
                gif3.Visible = False
                track3_length.Text = ""
                'Fourth playlist deactivated
                btn_play4.Visible = True
                btn_pause4.Visible = False
                gif4.Visible = False
                track4_length.Text = ""
                'Applying new changes to the next playlist
                btn_play6.Visible = False
                btn_pause6.Visible = True
                gif6.Visible = True
                track6_length.Text = Form1.Label_CurrentLength.Text
                'Fifth playlist deactivated
                btn_play5.Visible = True
                btn_pause5.Visible = False
                gif5.Visible = False
                track5_length.Text = ""
                'Seventh playlist deactivated
                btn_play7.Visible = True
                btn_pause7.Visible = False
                gif7.Visible = False
                track7_length.Text = ""
                If label_track_name_6.Left + label_track_name_6.Left <= 0 Then
                    label_track_name_6.Left = PanelF.Width
                End If
            End If
            '/////////////////////////// F DONE 
            If Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.URL = Itone_Media_Player.My.Forms.Form2.Tab_Audio_Playlist1.ListBox_Song_Path.Items(6) Then
                label_track_name_7.Left = label_track_name_7.Left - 10
                'first playlist deactivated
                btn_play1.Visible = True
                btn_pause1.Visible = False
                gif1.Visible = False
                track1_length.Text = ""
                'Second playlist deactivated
                btn_play2.Visible = True
                btn_pause2.Visible = False
                gif2.Visible = False
                track2_length.Text = ""
                'Third playlist deactivated
                btn_play3.Visible = True
                btn_pause3.Visible = False
                gif3.Visible = False
                track3_length.Text = ""
                'Fourth playlist deactivated
                btn_play4.Visible = True
                btn_pause4.Visible = False
                gif4.Visible = False
                track4_length.Text = ""
                'Applying new changes to the next playlist
                btn_play7.Visible = False
                btn_pause7.Visible = True
                gif7.Visible = True
                track7_length.Text = Form1.Label_CurrentLength.Text
                'Fifth playlist deactivated
                btn_play5.Visible = True
                btn_pause5.Visible = False
                gif5.Visible = False
                track5_length.Text = ""
                'Sixth playlist deactivated
                btn_play6.Visible = True
                btn_pause6.Visible = False
                gif6.Visible = False
                track6_length.Text = ""
                If label_track_name_7.Left + label_track_name_7.Left <= 0 Then
                    label_track_name_7.Left = PanelG.Width
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_pause1_1_Click(sender As Object, e As EventArgs) Handles btn_pause1_1.Click
        Try
            btn_pause1.Show()
            btn_play1.Hide()
            btn_pause1_1.Hide()
            gif1.Visible = True
            Form1.btn_pause.Hide()
            Form1.btn_play.Show()
            Timer_textRunner.Start()
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()

        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn_pause2_2_Click(sender As Object, e As EventArgs) Handles btn_pause2_2.Click
        Try
            btn_pause2.Show()
            btn_play2.Hide()
            btn_pause2_2.Hide()
            gif2.Visible = True
            Form1.btn_pause.Hide()
            Form1.btn_play.Show()
            Timer_textRunner.Start()
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn_pause3_3_Click(sender As Object, e As EventArgs) Handles btn_pause3_3.Click
        Try
            btn_pause3.Show()
            btn_play3.Hide()
            btn_pause3_3.Hide()
            gif3.Visible = True
            Form1.btn_pause.Hide()
            Form1.btn_play.Show()
            Timer_textRunner.Start()
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn_pause4_4_Click(sender As Object, e As EventArgs) Handles btn_pause4_4.Click
        Try
            btn_pause4.Show()
            btn_play4.Hide()
            btn_pause4_4.Hide()
            gif4.Visible = True
            Form1.btn_pause.Hide()
            Form1.btn_play.Show()
            Timer_textRunner.Start()
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn_pause5_5_Click(sender As Object, e As EventArgs) Handles btn_pause5_5.Click
        Try
            btn_pause5.Show()
            btn_play5.Hide()
            btn_pause5_5.Hide()
            gif5.Visible = True
            Form1.btn_pause.Hide()
            Form1.btn_play.Show()
            Timer_textRunner.Start()
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn_pause6_6_Click(sender As Object, e As EventArgs) Handles btn_pause6_6.Click
        Try
            btn_pause6.Show()
            btn_play6.Hide()
            btn_pause6_6.Hide()
            gif6.Visible = True
            Form1.btn_pause.Hide()
            Form1.btn_play.Show()
            Timer_textRunner.Start()
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn_pause7_7_Click(sender As Object, e As EventArgs) Handles btn_pause7_7.Click
        Try
            btn_pause7.Show()
            btn_play7.Hide()
            btn_pause7_7.Hide()
            gif7.Visible = True
            Form1.btn_pause.Hide()
            Form1.btn_play.Show()
            Timer_textRunner.Start()
            Itone_Media_Player.My.Forms.Form1.Tab_NowPlaying1.Itone_Music_Player.Ctlcontrols.play()
        Catch ex As Exception
            MessageBox.Show("File format is corrupted", "Cannot play file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
