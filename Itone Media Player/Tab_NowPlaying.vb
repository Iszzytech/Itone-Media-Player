Public Class Tab_NowPlaying
    Private Sub Timer_Slidername_Tick(sender As Object, e As EventArgs) Handles Timer_Slidername.Tick
        label_song.Left = label_song.Left - 5
        If label_song.Left + label_song.Left <= 0 Then
            label_song.Left = Panel3.Width
        End If
    End Sub

    Private Sub Panel4_MouseEnter(sender As Object, e As EventArgs) Handles Panel4.MouseEnter
        If Form1.WindowState = System.Windows.Forms.FormWindowState.Maximized Then
            Itone_Media_Player.My.Forms.Form1.Panel_bottom.Show()

        End If
    End Sub

    Private Sub Itone_Music_Player_Enter(sender As Object, e As EventArgs) Handles Itone_Music_Player.Enter
        If Form1.WindowState = System.Windows.Forms.FormWindowState.Maximized Then
            Itone_Media_Player.My.Forms.Form1.Panel_bottom.Hide()

        End If
    End Sub

    Private Sub Itone_Music_Player_MouseMoveEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_MouseMoveEvent) Handles Itone_Music_Player.MouseMoveEvent
        If Form1.WindowState = System.Windows.Forms.FormWindowState.Maximized Then
            Itone_Media_Player.My.Forms.Form1.Panel_bottom.Hide()
            Itone_Music_Player.fullScreen = False
        End If
    End Sub

    Private Sub Itone_Music_Player_ClickEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles Itone_Music_Player.ClickEvent

        If Itone_Media_Player.My.Forms.Form1.Panel_bottom.Visible = True Then
            If Form1.WindowState = System.Windows.Forms.FormWindowState.Maximized Then
                Itone_Media_Player.My.Forms.Form1.Panel_bottom.Visible = False
            End If
        Else
            Itone_Media_Player.My.Forms.Form1.Panel_bottom.Visible = True
            Itone_Music_Player.fullScreen = False
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel4_MouseLeave(sender As Object, e As EventArgs) Handles Panel4.MouseLeave
        If Form1.WindowState = System.Windows.Forms.FormWindowState.Maximized Then
            Itone_Media_Player.My.Forms.Form1.Panel_bottom.Show()
        End If
    End Sub

    Private Sub Itone_Music_Player_DoubleClickEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_DoubleClickEvent) Handles Itone_Music_Player.DoubleClickEvent
        Form1.Panel_bottom.Show()
    End Sub

    Private Sub Tab_NowPlaying_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) > 1 Then
            MsgBox("You have pressed" & e.KeyChar)
        End If
    End Sub
End Class
