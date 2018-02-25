﻿Imports System.Data.OleDb

Public Class Alumnos
    Private Shared ReadOnly Property connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=academy_bd.accdb")

    ' Si se tiene rango jefe se seleccionarán todos los alumnos
    Public Shared Function SelectAllAlumnos() As DataSet
        Dim adapter As New OleDbDataAdapter("SELECT * FROM alumnos", connection)
        Dim midataset As New DataSet
        adapter.Fill(midataset, "alumnos")
        Return midataset
    End Function

    ' Si se es profesor solo se mostrarán los alumnos de ese profesor
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
        terminal = New OleDbCommand("INSERT INTO empleados_alumnos VALUES ('" & dniprof & "', '" & alu.DNI & "', NULL, NULL, NULL)", connection)
        terminal.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Shared Sub UpdateAlumno(ByVal alu As Alumno)
        connection.Open()
        Dim terminal As New OleDbCommand("UPDATE alumnos SET nombre = '" & alu.Nombre & "', apellido = '" & alu.Apellido &
                                         "', telefono = '" & alu.Telefono & "', email = '" & alu.Email & "', direccion = '" & alu.Direccion & "' WHERE dni = '" & alu.DNI & "'", connection)
        terminal.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Shared Sub DeleteAlumno(ByVal dni As String)
        connection.Open()
        Dim terminal As New OleDbCommand("DELETE * FROM empleados_alumnos WHERE dni_alumno = '" & dni & "'", connection)
        terminal.ExecuteNonQuery()
        terminal = New OleDbCommand("DELETE * FROM alumnos WHERE dni = '" & dni & "'", connection)
        terminal.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Shared Sub CloseConnection()
        connection.Close()
    End Sub

    '
    '------------------CRYSTAL REPORT ÚLTIMO ALUMNO AÑADIDO
    '
    Public Shared Sub generateReport_lastRecord(dniLastRecord As String)
        Dim query As String = "SELECT * FROM alumnos where dni = '" & dniLastRecord & "'"
        Dim adapter As New OleDbDataAdapter(query, connection)
        Dim dataset = New DataSet
        adapter.Fill(dataset, "lastRecord")
        dataset.WriteXml("informe.xml", XmlWriteMode.WriteSchema)
    End Sub
    '
    '----------------CRYSTAL REPORT TODOS LOS ALUMNOS
    '

    '
    'CrystalReport de Todos los alumnos
    '
    Public Shared Sub generateReport_ALUMNOS()
        Dim query As String = "SELECT alumnos.*, empleados.nombre, empleados.apellido 
                                FROM alumnos, empleados, empleados_alumnos
                                where alumnos.dni = empleados_alumnos.dni_alumno 
                                AND empleados_alumnos.dni_profesor = empleados.dni"
        Try
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dataset = New DataSet
            adapter.Fill(dataset, "informe_alumnos")
            dataset.WriteXml("informe_ALUMNOS.xml", XmlWriteMode.WriteSchema)
        Catch ex As Exception
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try

    End Sub
End Class
