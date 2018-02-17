Public Class Form1
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        FormLogin.Show() 'muestro el formulario de login
        Me.Close() ' Cerramos el salvapantallas
    End Sub
End Class
