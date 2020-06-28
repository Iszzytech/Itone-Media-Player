Public Class Tab_Volume
    Private Sub Slider_Level_ValueChanged(sender As Object, e As EventArgs) Handles Slider_Level.ValueChanged
        Gauge_Level.Value = Slider_Level.Value
    End Sub
End Class
