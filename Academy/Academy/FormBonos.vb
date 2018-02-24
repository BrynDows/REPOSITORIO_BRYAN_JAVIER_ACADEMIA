Imports idiomasDLL

Public Class FormBonos

    Public Property alu As Alumno

    Private Sub FormBonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lTitle.Text = "Asignar bono al alumno " & alu.Nombre & " " & alu.Apellido
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        modulo.ExitToAPP(Me)
    End Sub

    Private Sub tsbInformacion_Click(sender As Object, e As EventArgs) Handles tsbInformacion.Click
        FormInformation.Show()
        Me.Close()
    End Sub
End Class