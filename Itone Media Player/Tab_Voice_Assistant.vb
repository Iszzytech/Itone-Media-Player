Public Class Tab_Voice_Assistant
    Private Sub btn_SP_Active_Click(sender As Object, e As EventArgs) Handles btn_SP_Deactive.Click
        btn_VA.Visible = False
        btn_VA_OFF.Visible = True
        btn_SP_Deactive.Visible = False
        btn_SP_active.Visible = True

    End Sub

    Private Sub btn_SP_active_Click_1(sender As Object, e As EventArgs) Handles btn_SP_active.Click
        btn_VA.Visible = True
        btn_VA_OFF.Visible = False
        btn_SP_Deactive.Visible = True
        btn_SP_active.Visible = False
    End Sub

    Private Sub btn_help_Click(sender As Object, e As EventArgs) Handles btn_help.Click
        btn_help2.Visible = True
        btn_help.Visible = False
    End Sub
    Private Sub btn_help2_Click(sender As Object, e As EventArgs) Handles btn_help2.Click
        btn_help2.Visible = False
        btn_help.Visible = True
    End Sub
End Class
