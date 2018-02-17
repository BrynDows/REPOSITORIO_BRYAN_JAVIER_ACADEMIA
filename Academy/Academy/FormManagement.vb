Public Class FormManagement

    Public Property Mode As Byte

    Private Sub FormManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '0 = jefe, 1 = profesor
        If Mode = 0 Then
            'soy jefe y muesro las dos pestañas, profesor y alumnos
        Else
            'soy profesor y muestro solo la pestaña alumno
        End If
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        FormModify.Modo = 0
        FormModify.ShowDialog()
    End Sub

    Private Sub bMod_Click(sender As Object, e As EventArgs) Handles bMod.Click
        FormModify.Modo = 1
        FormModify.ShowDialog()
    End Sub
End Class