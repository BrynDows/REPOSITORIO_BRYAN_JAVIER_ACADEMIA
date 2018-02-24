Imports System.Data.OleDb

Public Class Bonos
    Private Shared ReadOnly Property connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=academy_bd.accdb")

    Public Shared Function SelectPrecio(epoca As Boolean, presencial As Boolean, lugar As Boolean, horas As Int16, personas As Int16) As String()
        Dim adapter As New OleDbDataAdapter("SELECT id, precio FROM bonos WHERE horas = " & horas &
                                            " AND presencial = " & presencial &
                                            " AND n_personas = " & personas &
                                            " AND domiCuela = " & lugar &
                                            " AND invierano = " & epoca, connection)
        Dim midataset As New DataSet
        adapter.Fill(midataset, "precio")
        Dim ret(2) As String
        If midataset.Tables(0).Rows.Count > 0 Then
            ret(0) = midataset.Tables(0).Rows(0)("id").ToString
            ret(1) = midataset.Tables(0).Rows(0)("precio").ToString
        End If
        Return ret
    End Function

    Public Shared Sub UpdateAlumnoBono(idBono As Integer, dniAlumno As String)
        connection.Open()
        Dim terminal As New OleDbCommand("UPDATE empleados_alumnos SET bono = " & idBono & " WHERE dni_alumno = '" & dniAlumno & "'", connection)
        terminal.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Shared Sub CloseConnection()
        connection.Close()
    End Sub
End Class
