Imports System.Data.OleDb

Public Class Bonos
    Private Shared ReadOnly Property connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=academy_bd.accdb")

    Public Shared Sub CloseConnection()
        connection.Close()
    End Sub
End Class
