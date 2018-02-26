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
        Try
            Dim table As String = "empleados"
            Dim adapter As New OleDbDataAdapter("SELECT empleados.dni, empleados.nombre, empleados.apellido, empleados.telefono, empleados.direccion, empleados.email, cuentasUsuario.nombre_usuario, puestos.nombre
                                            FROM (empleados LEFT JOIN cuentasUsuario ON empleados.cuenta = cuentasUsuario.id) LEFT JOIN puestos ON empleados.puesto = puestos.id", connection)
            Dim dataset As New DataSet

            adapter.Fill(dataset, table)
            DataGrid.DataSource = dataset
            DataGrid.DataMember = table
        Catch ex As Exception
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try

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
            idiomasDLL.INSERT_IN_ERROR_LOG(ex)
        Finally
            Try
                connection.Close()
            Catch ex As Exception
                idiomasDLL.INSERT_IN_ERROR_LOG(ex)
            End Try

        End Try
        Return value
    End Function
    '
    'INSERT PROFESOR
    '
    Public Sub InsertTeacher(dni As String, nombre As String, apellido As String, email As String, password As String, puesto As Puesto, telefono As String, direccion As String)
        Try
            Dim insertAccount As String = "INSERT INTO cuentasUsuario (nombre_usuario, contrasenya, rol) VALUES ('" & email & "', '" & password & "'," & puesto.id & ")"
            ExecuteQuery(insertAccount)
            Dim insertTeacher As String = "INSERT INTO empleados VALUES('" & dni & "', '" & nombre & "', " & getIDAccount(email) & "," & puesto.id & ", '" & apellido & "', '" & telefono & "', '" & direccion & "', '" & email & "')"
            ExecuteQuery(insertTeacher)
        Catch ex As Exception
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
    End Sub
    '
    'OBTENER ID DE EMAIL
    '
    Private Function getIDAccount(email As String) As Integer
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
        Try
            Dim query As String = "INSERT INTO empleados (dni, nombre, puesto, apellido, telefono, direccion, email) VALUES ('" & dni & "','" & nombre & "'," & puesto.id & ",'" & apellido & "','" & telefono & "','" & direccion & "','" & email & "')"
            ExecuteQuery(query)
        Catch ex As Exception
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
    End Sub
    '
    'UPDATE
    '
    Public Sub UpdateEmployee(newEmploye As Employe, oldAccount As String)
        Try
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
        Catch ex As Exception
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try

    End Sub
    '
    'DELETE
    '
    Public Sub deleteEmployee(dni As String, userName As String)
        Try
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
        Catch ex As Exception
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
    End Sub
    '
    'CARGAR COMBOBOX
    '
    Public Sub loadComboBoxPuestos(comboBox As ComboBox)
        Try
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
        Catch ex As Exception
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
    End Sub
    '
    'CrystalReport empleados de la BD v2
    '
    Public Sub generateReport_EMPLEADOS()
        Try
            Dim query As String = "SELECT empleados.dni, empleados.nombre, empleados.apellido, empleados.email, empleados.telefono, empleados.direccion, puestos.nombre, empleados_idiomas.id_idioma, idiomas.idioma
                                    FROM ((empleados LEFT JOIN puestos ON empleados.puesto = puestos.id) LEFT JOIN empleados_idiomas ON empleados.dni = empleados_idiomas.dni_empleado) LEFT JOIN idiomas ON empleados_idiomas.id_idioma = idiomas.id"
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dataset = New DataSet
            adapter.Fill(dataset, "informe_empleados_v2")
            dataset.WriteXml("informe_EMPLEADOS_v2.xml", XmlWriteMode.WriteSchema)
        Catch ex As Exception
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
    End Sub

End Class
