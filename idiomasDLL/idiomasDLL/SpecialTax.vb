Imports System.Data.OleDb

Public Class SpecialTax
    Private Shared ReadOnly Property connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=academy_bd.accdb")

    Public Shared Function SelectPrecio(nombre As String, prepa As Boolean) As String()
        Dim adapter As New OleDbDataAdapter("SELECT id, precio FROM tax_especial WHERE titulacion = '" & nombre &
                                            "' AND examen_preparacion = " & prepa, connection)
        Dim midataset As New DataSet
        adapter.Fill(midataset, "precio")
        Dim ret(2) As String
        If midataset.Tables(0).Rows.Count > 0 Then
            ret(0) = midataset.Tables(0).Rows(0)("id").ToString
            ret(1) = midataset.Tables(0).Rows(0)("precio").ToString
        End If
        Return ret
    End Function

    Public Shared Sub UpdateAlumnoTax(idTax As Integer, dniAlumno As String)
        connection.Open()
        Dim terminal As New OleDbCommand("UPDATE empleados_alumnos SET tarifa_especial = " & idTax & " WHERE dni_alumno = '" & dniAlumno & "'", connection)
        terminal.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Shared Sub CloseConnection()
        connection.Close()
    End Sub
End Class
