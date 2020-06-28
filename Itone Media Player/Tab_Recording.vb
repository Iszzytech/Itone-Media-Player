Public Class Tab_Recording
    Private Sub BunifuVTrackbar1_ValueChanged(sender As Object, e As EventArgs) Handles VTrackbarA.ValueChanged
        lblA.Text = VTrackbarA.Value
        If VTrackbarA.Value = 0 Then
            micA.Visible = False
            micAA.Visible = True
        End If
    End Sub

    Private Sub VTrackbarB_ValueChanged(sender As Object, e As EventArgs) Handles VTrackbarB.ValueChanged
        lblB.Text = VTrackbarB.Value
        If VTrackbarB.Value = 0 Then
            micB.Visible = False
            micBB.Visible = True
        End If
    End Sub

    Private Sub VTrackbarC_ValueChanged(sender As Object, e As EventArgs) Handles VTrackbarC.ValueChanged
        lblC.Text = VTrackbarC.Value
        If VTrackbarC.Value = 0 Then
            micC.Visible = False
            micCC.Visible = True
        End If
    End Sub

    Private Sub VTrackbarD_ValueChanged(sender As Object, e As EventArgs) Handles VTrackbarD.ValueChanged
        lblD.Text = VTrackbarD.Value
        If VTrackbarD.Value = 0 Then
            micD.Visible = False
            micDD.Visible = True
        End If
    End Sub

    Private Sub VTrackbarE_ValueChanged(sender As Object, e As EventArgs) Handles VTrackbarE.ValueChanged
        lblE.Text = VTrackbarE.Value
        If VTrackbarE.Value = 0 Then
            micE.Visible = False
            micEE.Visible = True
        End If
    End Sub

    Private Sub VTrackbarF_ValueChanged(sender As Object, e As EventArgs) Handles VTrackbarF.ValueChanged
        lblF.Text = VTrackbarF.Value
        If VTrackbarF.Value = 0 Then
            micF.Visible = False
            micFF.Visible = True
        End If
    End Sub

    Private Sub VTrackbarG_ValueChanged(sender As Object, e As EventArgs) Handles VTrackbarG.ValueChanged
        lblG.Text = VTrackbarG.Value
        If VTrackbarG.Value = 0 Then
            micG.Visible = False
            micGG.Visible = True
        End If
    End Sub

    Private Sub VTrackbarH_ValueChanged(sender As Object, e As EventArgs) Handles VTrackbarH.ValueChanged
        lblH.Text = VTrackbarH.Value
        If VTrackbarH.Value = 0 Then
            micH.Visible = False
            micHH.Visible = True
        End If
    End Sub

    Private Sub VTrackbarI_ValueChanged(sender As Object, e As EventArgs) Handles VTrackbarI.ValueChanged
        lblI.Text = VTrackbarI.Value
        If VTrackbarI.Value = 0 Then
            micI.Visible = False
            micII.Visible = True
        End If
    End Sub

    Private Sub micA_Click(sender As Object, e As EventArgs) Handles micA.Click

    End Sub

    Private Sub micB_Click(sender As Object, e As EventArgs) Handles micB.Click

    End Sub

    Private Sub micD_Click(sender As Object, e As EventArgs) Handles micD.Click

    End Sub

    Private Sub micE_Click(sender As Object, e As EventArgs) Handles micE.Click

    End Sub
End Class
