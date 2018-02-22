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

    Public Shared Sub InsertAlumno(ByVal dniprof As String, ByVal alu As Alumno)
        connection.Open()
        Dim terminal As New OleDbCommand("INSERT INTO alumnos VALUES ('" & alu.DNI & "', '" & alu.Nombre & "', '" & alu.Apellido &
                                         "', '" & alu.Telefono & "', '" & alu.Email & "', '" & alu.Direccion & "')", connection)
        terminal.ExecuteNonQuery()
        terminal = New OleDbCommand("INSERT INTO empleados_alumnos(dni_profesor, dni_alumno) VALUES ('" & dniprof & "', '" & alu.DNI & "')", connection)
        terminal.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Shared Sub CloseConnection()
        connection.Close()
    End Sub
End Class
