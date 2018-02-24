Imports System.Data.OleDb
'Esta clase contedrá métodos encargados de realizar altas bajas y modificación de profesores
'así como tambíen sus correspondientes validaciones
Public Class CRUD_employes
    Private connection As OleDbConnection
    Private terminal As OleDbCommand
    Private NAME_BD As String = "academy_bd.accdb"

    '
    'CONSTRUCTOR
    '
    Public Sub New()
        connection = New OleDbConnection("PROVIDER = Microsoft.Ace.OleDB.12.0 ; Data Source=" & NAME_BD)
        terminal = New OleDbCommand
    End Sub
    '
    'MUESTRA JOIN EN DATAGRIDVIEW
    '
    Public Sub ShowTeachers(DataGrid As DataGridView)
        Dim table As String = "empleados"
        Dim adapter As New OleDbDataAdapter("SELECT empleados.dni, empleados.nombre, empleados.apellido, empleados.telefono, empleados.direccion, empleados.email, cuentasUsuario.nombre_usuario, puestos.nombre
                                            FROM (empleados LEFT JOIN cuentasUsuario ON empleados.cuenta = cuentasUsuario.id) LEFT JOIN puestos ON empleados.puesto = puestos.id", connection)
        Dim dataset As New DataSet

        adapter.Fill(dataset, table)
        DataGrid.DataSource = dataset
        DataGrid.DataMember = table
    End Sub

    '
    'EJECUTA QUERY
    '
    Private Function ExecuteQuery(query As String) As Integer
        Dim value As Integer = 0
        Try
            connection.Open()
            terminal = New OleDbCommand(query, connection)
            ' value = terminal.ExecuteNonQuery
            terminal.ExecuteNonQuery()
        Catch ex As Exception
            If ex.HResult = -2147467259 Then
                MsgBox("Este profesor no Puede ser alterado porque aún tiene alumnos", 48 + vbOK, "Operación denegada")
            End If
            MsgBox(ex.Message)
            idiomasDLL.INSERT_IN_ERROR_LOG(ex)
        Finally
            connection.Close()
        End Try
        Return value
    End Function
    '
    'INSERT PROFESOR
    '
    Public Sub InsertTeacher(dni As String, nombre As String, apellido As String, email As String, password As String, puesto As Puesto, telefono As String, direccion As String)
        Dim insertAccount As String = "INSERT INTO cuentasUsuario (nombre_usuario, contrasenya, rol) VALUES ('" & email & "', '" & password & "'," & puesto.id & ")"
        ExecuteQuery(insertAccount)
        Dim insertTeacher As String = "INSERT INTO empleados VALUES('" & dni & "', '" & nombre & "', " & getIDAccount(email) & "," & puesto.id & ", '" & apellido & "', '" & telefono & "', '" & direccion & "', '" & email & "')"
        ExecuteQuery(insertTeacher)
    End Sub
    '
    'OBTENER ID DE EMAIL
    '
    Public Function getIDAccount(email As String) As Integer
        Dim resu As Integer = 0
        Try
            Dim query As String = "SELECT id FROM cuentasUsuario WHERE nombre_usuario = '" & email & "'"
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dataset As New DataSet
            adapter.Fill(dataset)
            resu = CInt(dataset.Tables(0).Rows(0).Item(0))
        Catch ex As Exception
            resu = 0
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
        Return resu
    End Function
    '
    'INSERTAR EMPLEADO
    '
    Public Sub InsertEmploye(dni As String, nombre As String, puesto As Puesto, apellido As String, telefono As String, direccion As String, email As String)
        Dim query As String = "INSERT INTO empleados (dni, nombre, puesto, apellido, telefono, direccion, email) VALUES ('" & dni & "','" & nombre & "'," & puesto.id & ",'" & apellido & "','" & telefono & "','" & direccion & "','" & email & "')"
        ExecuteQuery(query)
    End Sub
    '
    'UPDATE
    '
    Public Sub UpdateEmployee(newEmploye As Employe, oldAccount As String)
        If getIDAccount(newEmploye.email) = 0 And newEmploye.puesto.id = 1 Then
            'Actualiza empleado normal a profesor
            Dim insertNewAccount As String = "INSERT INTO cuentasUsuario (nombre_usuario, contrasenya, rol) VALUES ( '" & newEmploye.user.userName & "'," &
                    "'" & newEmploye.user.password & "'," & newEmploye.puesto.id & ")"
            ExecuteQuery(insertNewAccount)

            Dim query As String = "UPDATE empleados SET nombre = '" & newEmploye.nombre & "'" &
                ", puesto = " & newEmploye.puesto.id &
                ", cuenta = " & getIDAccount(newEmploye.user.userName) &
                ", apellido = '" & newEmploye.apellido & "'" &
                ", telefono = '" & newEmploye.telefono & "'" &
                ", direccion = '" & newEmploye.direccion & "'" &
                ", email = '" & newEmploye.email & "' " &
                "  WHERE dni = '" & newEmploye.dni & "'"
            ExecuteQuery(query)
        ElseIf getIDAccount(newEmploye.email) = 0 Then
            'Actualiza empleado normal
            Dim query As String = "UPDATE empleados SET nombre = '" & newEmploye.nombre & "'" &
            ", puesto = " & newEmploye.puesto.id &
            ", apellido = '" & newEmploye.apellido & "'" &
            ", telefono = '" & newEmploye.telefono & "'" &
            ", direccion = '" & newEmploye.direccion & "'" &
            ", email = '" & newEmploye.email & "' " &
            "  WHERE dni = '" & newEmploye.dni & "'"
            ExecuteQuery(query)
        Else
            'Actualiza Profesor
            Dim update_account = "UPDATE cuentasUsuario SET nombre_usuario = '" & newEmploye.email & "', contrasenya ='" & newEmploye.user.password & "' WHERE id = " & getIDAccount(oldAccount)
            ExecuteQuery(update_account)
            Dim query As String = "UPDATE empleados SET nombre = '" & newEmploye.nombre & "' " &
            ", cuenta = '" & getIDAccount(newEmploye.email) & "'" &
            ", puesto = " & newEmploye.puesto.id &
            ", apellido = '" & newEmploye.apellido & "'" &
            ", telefono = '" & newEmploye.telefono & "'" &
            ", direccion = '" & newEmploye.direccion & "'" &
            ", email = '" & newEmploye.email & "' " &
            "  WHERE dni = '" & newEmploye.dni & "'"
            ExecuteQuery(query)
        End If

    End Sub
    '
    'DELETE
    '
    Public Sub deleteEmployee(dni As String, userName As String)
        If userName.Length > 2 Then
            Dim DELETE_cuentas As String = "DELETE FROM cuentasUsuario WHERE nombre_usuario = '" & userName & "'"
            ExecuteQuery(DELETE_cuentas)
            Dim DELETE_empleados_idiomas As String = "DELETE FROM empleados_idiomas WHERE dni_empleado = '" & dni & "'"
            ExecuteQuery(DELETE_empleados_idiomas)
            Dim DELETE_empleados_alumnos As String = "DELETE FROM empleados_alumnos WHERE dni_profesor = '" & dni & "'"
            ExecuteQuery(DELETE_empleados_alumnos)
            Dim DELETE_Empleados As String = "DELETE FROM empleados WHERE dni = '" & dni & "'"
            ExecuteQuery(DELETE_Empleados)
        Else
            Dim DELETE_empleados As String = "DELETE FROM empleados WHERE dni = '" & dni & "'"
            ExecuteQuery(DELETE_empleados)
        End If

    End Sub
    '
    'CARGAR COMBOBOX
    '
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
    '
    'CrystalReport de último alumno añadido
    '
    Public Sub generateReport_EMPLEADOS()
        Dim query As String = "SELECT empleados.dni, empleados.nombre, empleados.apellido, empleados.telefono, empleados.direccion, empleados.email, cuentasUsuario.nombre_usuario, puestos.nombre, empleados_alumnos.dni_alumno
                                            FROM ((empleados LEFT JOIN cuentasUsuario ON empleados.cuenta = cuentasUsuario.id) LEFT JOIN puestos ON empleados.puesto = puestos.id) LEFT JOIN empleados_alumnos ON empleados_alumnos.dni_profesor = empleados.dni"
        Dim adapter As New OleDbDataAdapter(query, connection)
        Dim dataset = New DataSet
        adapter.Fill(dataset, "informe_empleados")
        dataset.WriteXml("informe_EMPLEADOS.xml", XmlWriteMode.WriteSchema)
    End Sub

End Class
