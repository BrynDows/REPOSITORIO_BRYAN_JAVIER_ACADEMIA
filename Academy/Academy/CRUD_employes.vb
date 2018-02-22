Imports System.Data.OleDb
'Esta clase contedrá métodos encargados de realizar altas bajas y modificación de profesores
'así como tambíen sus correspondientes validaciones
Public Class CRUD_employes
    Private connection As OleDbConnection
    Private terminal As OleDbCommand
    Private NAME_BD As String = "academy_bd.accdb"

    ''' <summary>
    ''' Constructor por defecto, inicia una conexión con la BD e inicia una terminal para poder relizar consultas.
    ''' </summary>
    Public Sub New()
        connection = New OleDbConnection("PROVIDER = Microsoft.Ace.OleDB.12.0 ; Data Source=" & NAME_BD)
        terminal = New OleDbCommand
    End Sub
    '
    ''' <summary>
    ''' Muestra los datos de una tabla en concreto en un datagridview.
    ''' </summary>
    ''' <param name="DataGrid"></param>
    Public Sub ShowTeachers(DataGrid As DataGridView)
        Dim table As String = "empleados"
        Dim adapter As New OleDbDataAdapter("SELECT * FROM " & table & " WHERE puesto = 1", connection)
        Dim dataset As New DataSet

        adapter.Fill(dataset, table)
        DataGrid.DataSource = dataset
        DataGrid.DataMember = table
    End Sub

    ''' <summary>
    ''' Ejecuta una query pasada por parámetro.
    ''' </summary>
    ''' <param name="query"></param>
    Private Sub ExecuteQuery(query As String)
        connection.Open()
        terminal = New OleDbCommand(query, connection)
        terminal.ExecuteNonQuery()
        connection.Close()
    End Sub

    ''' <summary>
    ''' Inserta un nuevo empleado en la tabla empleados de la BD.
    ''' </summary>
    ''' <param name="dni"></param>
    ''' <param name="nombre"></param>
    ''' <param name="cuenta"></param>
    ''' <param name="puesto"></param>
    ''' <param name="apellido"></param>
    ''' <param name="telefono"></param>
    ''' <param name="direccion"></param>
    ''' <param name="email"></param>
    Public Sub InsertEmploye(dni As String, nombre As String, cuenta As Integer, puesto As Integer, apellido As String, telefono As String, direccion As String, email As String)
        Dim query As String = "insert into empleados values('" & dni & "', '" & nombre & "', " & cuenta & "," & puesto & ", '" & apellido & "', '" & telefono & "', '" & direccion & "', '" & email & "');"
        ExecuteQuery(query)
    End Sub

    Public Sub updateEmployee(dniActual As String, nombre As String, cuenta As Integer, puesto As String, apellido As String, telefono As String, direccion As String, email As String)
        Dim name, account, job, surname, number_phone, address, mail As String

    End Sub

    Public Sub deleteEmployee()

    End Sub


End Class
