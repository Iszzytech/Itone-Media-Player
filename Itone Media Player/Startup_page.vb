Public Class Startup_page

    Dim Progress As Integer = 0
    Private Sub Startup_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        'Onload initialize the value of a assigned variable progress to the progress bar
        GunaProgressBar1.Value = Progress
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GunaProgressBar1.Increment(1)
        Time_txt.Text = GunaProgressBar1.ProgressPercentText
        Progress += 1

        If Progress >= 100 Then
            Form1.Show()
            Timer1.Enabled = False
            Me.Hide()
            Timer1.Stop()
        ElseIf Progress = 50 Then
            stages.Text = "Initiating Itone Media Player"
            Timer1.Interval = 100
        ElseIf Progress = 70 Then
            panel_main.Visible = True
            stages.Text = "Wrapping up Itone Media Player Component"
            Timer1.Interval = 50
        ElseIf Progress = 95 Then
            stages.Text = "Almost Done!!!"

        End If
    End Sub
End Class