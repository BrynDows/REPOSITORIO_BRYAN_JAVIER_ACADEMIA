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
        '  connection.ConnectionString = "PROVIDER = Microsoft.Ace.OleDB.12.0 ; Data Source=academy_bd.accdb"
    End Sub

    Private Sub showData(DataGrid As DataGridView, table As String, conn As OleDbConnection)

        Dim adapter As New OleDbDataAdapter("SELECT * FROM " & table, conn)
        Dim dataset As New DataSet

        adapter.Fill(dataset, table)
        DataGrid.DataSource = dataset
        DataGrid.DataMember = table

    End Sub

    'Public Sub readAll(datagrid As DataGridView)

    '    adapter.Fill(DataSet, "empleados")
    '    datagrid.DataSource = DataSet
    '    datagrid.DataMember = "empleados"
    'End Sub

    'Public Function insert(datagrid As DataGridView) As Integer
    '    Dim result As Integer
    '    connection.BeginTransaction()
    '    connection

    '    Return result
    'End Function
End Class
