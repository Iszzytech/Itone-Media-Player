Public Class Tab_Transparent
    Private Sub BunifuiOSSwitch1_OnValueChange(sender As Object, e As EventArgs) Handles BunifuiOSSwitch1.OnValueChange

    End Sub

    Private Sub slider_transparent_Scroll(sender As Object, e As ScrollEventArgs) Handles slider_transparent.Scroll
        Form1.Opacity = slider_transparent.Value / 100
        Form1.IMP_Write_File()
        label_TR_value.Text = slider_transparent.Value
        Progressbar_slider.Value = slider_transparent.Value
    End Sub

    Private Sub btn_nice_Click(sender As Object, e As EventArgs) Handles btn_nice.Click
        slider_transparent.Value = 85
    End Sub
End Class
