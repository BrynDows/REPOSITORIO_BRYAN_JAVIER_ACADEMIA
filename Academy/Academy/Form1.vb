Imports System.Threading

Public Class Form1
    Dim cont As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        ProgressBar1.Maximum = 100
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        lblProgess.Text = cont & " %"
        If cont = 101 Then
            FormLogin.Show()
            Me.Close()
        End If
        cont = cont + 1
    End Sub
End Class
