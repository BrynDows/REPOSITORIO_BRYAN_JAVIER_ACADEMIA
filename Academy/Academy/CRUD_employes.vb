Imports System.Data.OleDb
'Esta clase contedrá métodos encargados de realizar altas bajas y modificación de profesores
'así como tambíen sus correspondientes validaciones
Public Class CRUD_employes
    Private connection As OleDbConnection
    Private terminal As OleDbCommand
    Private NAME_BD As String = "academy_bd.accdb"

    Public Sub New()
        connection = New OleDbConnection("PROVIDER = Microsoft.Ace.OleDB.12.0 ; Data Source=" & NAME_BD)
        terminal = New OleDbCommand
    End Sub

    Private Sub showData(DataGrid As DataGridView, table As String)

        Dim adapter As New OleDbDataAdapter("SELECT * FROM " & table, connection)
        Dim dataset As New DataSet

        adapter.Fill(dataset, table)
        DataGrid.DataSource = dataset
        DataGrid.DataMember = table

    End Sub

    Public Sub insertEmploye(nombre As String, cuenta As Integer, puesto As Integer, apellido As String, telefono As String, direccion As String, email As String)
        Dim terminal As New OleDbCommand
        connection.Open()
        Dim query As String = "INSERT INTO empleados (nombre, cuenta, puesto, apellido, telefono, direccion, email) VALUES (" &
            "'" & nombre & "','" & cuenta & "','" & puesto & "','" & apellido & "','" & telefono & "','" & direccion & "','" & email & "')"
        terminal = New OleDbCommand(query, connection)
        terminal.ExecuteNonQuery()
        connection.Close()
    End Sub

End Class
