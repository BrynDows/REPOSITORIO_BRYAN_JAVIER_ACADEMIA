Public Class FormManagement
    Private mode As Integer
    Private Sub FormManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '0 = jefe, 1 = profesor
        If (mode = 0) Then
            'soy jefe y muesro las dos pestañas, profesor y alumnos
        Else
            'soy profesor y muestro solo la pestaña alumno
        End If


    End Sub

    Public Sub setMode(mode As Integer)
        Me.mode = mode
    End Sub


End Class