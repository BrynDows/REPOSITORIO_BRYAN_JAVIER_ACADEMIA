Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(1)
        lblProgess.Text = ProgressBar1.Value & " %"
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            FormLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = 100
        Timer1.Start()
    End Sub
End Class
