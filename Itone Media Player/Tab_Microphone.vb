Public Class Tab_Microphone
    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mic_Btn_Check_OnChange(sender As Object, e As EventArgs) Handles Mic_Btn_Check.OnChange
        If Mic_Btn_Check.Checked = False Then
            Noise_btn.Value = False
            Echo_btn.Value = False
            beam_btn.Value = False
            Mic_Btn_Check.Checked = False
        Else
            MessageBox.Show("Opening Microphone.........", "MIC TURNED ON", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Form1.OpenMic()
            Noise_btn.Value = True
            Echo_btn.Value = True
            Mic_Btn_Check.Checked = True
        End If

    End Sub
End Class
