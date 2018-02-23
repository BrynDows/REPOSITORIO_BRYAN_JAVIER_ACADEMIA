Imports idiomasDLL

Public Class FormBonos

    Public Property alu As Alumno

    Private Sub FormBonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lTitle.Text = "Asignar bono al alumno " & alu.Nombre & " " & alu.Apellido
    End Sub
End Class