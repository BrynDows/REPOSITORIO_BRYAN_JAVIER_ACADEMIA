Imports System.Data.OleDb

Public Class Alumnos
    Private Shared ReadOnly Property connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=academy_bd.accdb")

    Public Shared Function SelectAllAlumnos() As DataSet
        Dim adapter As New OleDbDataAdapter("SELECT * FROM alumnos", connection)
        Dim midataset As New DataSet
        adapter.Fill(midataset, "alumnos")
        Return midataset
    End Function

    Public Shared Function SelectAlumnosByProf(ByVal dniprof As String) As DataSet
        Dim adapter As New OleDbDataAdapter("SELECT alumnos.dni, alumnos.nombre, alumnos.apellido, alumnos.telefono, alumnos.email, alumnos.direccion FROM alumnos INNER JOIN empleados_alumnos ON empleados_alumnos.dni_alumno = alumnos.dni WHERE empleados_alumnos.dni_profesor = '" & dniprof & "'", connection)
        Dim midataset As New DataSet
        adapter.Fill(midataset, "alumnos")
        Return midataset
    End Function
End Class
