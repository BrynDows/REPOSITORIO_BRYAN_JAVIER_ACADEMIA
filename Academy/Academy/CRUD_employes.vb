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
        Dim adapter As New OleDbDataAdapter("SELECT empleados.dni, empleados.nombre, empleados.apellido, empleados.telefono, empleados.direccion, empleados.email, cuentasUsuario.nombre_usuario, puestos.nombre
                                            FROM (empleados LEFT JOIN cuentasUsuario ON empleados.cuenta = cuentasUsuario.id) LEFT JOIN puestos ON empleados.puesto = puestos.id", connection)
        Dim dataset As New DataSet

        adapter.Fill(dataset, table)
        DataGrid.DataSource = dataset
        DataGrid.DataMember = table
    End Sub

    ''' <summary>
    ''' Ejecuta una query pasada por parámetro.
    ''' </summary>
    ''' <param name="query"></param>
    Private Function ExecuteQuery(query As String) As Integer
        Dim value As Integer = 0
        connection.Open()
        terminal = New OleDbCommand(query, connection)
        value = terminal.ExecuteNonQuery
        connection.Close()
        Return value
    End Function

    ''' <summary>
    ''' Inserta un nuevo empleado en la tabla empleados de la BD.
    ''' </summary>
    ''' <param name="dni"></param>
    ''' <param name="nombre"></param>
    ''' <param name="puesto"></param>
    ''' <param name="apellido"></param>
    ''' <param name="telefono"></param>
    ''' <param name="direccion"></param>
    ''' <param name="email"></param>
    Public Sub InsertTeacher(dni As String, nombre As String, apellido As String, email As String, password As String, puesto As Puesto, telefono As String, direccion As String)
        Dim insertAccount As String = "INSERT INTO cuentasUsuario (nombre_usuario, contrasenya, rol) VALUES ('" & email & "', '" & password & "'," & puesto.id & ")"
        ExecuteQuery(insertAccount)
        Dim insertTeacher As String = "INSERT INTO empleados VALUES('" & dni & "', '" & nombre & "', " & email & "," & puesto.id & ", '" & apellido & "', '" & telefono & "', '" & direccion & "', '" & email & "')"
        ExecuteQuery(insertTeacher)
    End Sub

    Public Sub InsertEmploye(dni As String, nombre As String, puesto As Puesto, apellido As String, telefono As String, direccion As String, email As String)
        Dim query As String = "INSERT INTO empleados (dni, nombre, puesto, apellido, telefono, direccion, email) VALUES ('" & dni & "','" & nombre & "'," & puesto.id & ",'" & apellido & "','" & telefono & "','" & direccion & "','" & email & "')"
        ExecuteQuery(query)
    End Sub

    Public Sub UpdateEmployee(newEmploye As Employe)
        Dim query As String = "UPDATE FROM empleados SET nombre =" & newEmploye.name &
                                                  ", SET apellido =" & newEmploye.surname &
                                                  ", SET puesto = " & newEmploye.job &
                                                  ", SET telefono = " & newEmploye.tel &
                                                  ", SET direccion = " & newEmploye.address &
                                                  ", SET email = " & newEmploye.email &
                                                  "  WHERE dni = " & newEmploye.dni
        ExecuteQuery(query)
    End Sub


    Public Sub deleteEmployee(dni As String)
        Dim deleteFROM_empleadosAlumnos
        Dim query As String = "Delete from empleados where dni = '" & dni & "'"
        ExecuteQuery(query)
    End Sub

    Public Sub loadComboBoxPuestos(comboBox As ComboBox)
        Dim adapter As New OleDbDataAdapter("SELECT * FROM puestos", connection)
        Dim dataset As New DataSet

        adapter.Fill(dataset)
        Dim i As Integer = 0
        For Each row As DataRow In dataset.Tables(0).Rows
            Dim values() As Object = row.ItemArray
            Dim puesto As New Puesto(CInt(values(0).ToString), values(1).ToString)
            comboBox.Items.Add(puesto)
            i = i + 1
        Next
    End Sub
End Class
