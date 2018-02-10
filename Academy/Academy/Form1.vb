Public Class Form1
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Me.Hide() 'oculto este formulario
        Dim pantallapas As New FormLogin
        pantallapas.Show() 'muestro el formulario de login

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
