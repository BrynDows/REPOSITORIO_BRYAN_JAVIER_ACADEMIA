Imports System.Data.OleDb
Public Class Login
    Private connection As OleDbConnection
    Private terminal As OleDbCommand
    Private NAME_BD As String = "academy_bd.accdb"

    Public Sub New()
        connection = New OleDbConnection("PROVIDER = Microsoft.Ace.OleDB.12.0 ; Data Source=" & NAME_BD)
        terminal = New OleDbCommand
    End Sub

    Public Function getUsers() As ArrayList
        Dim users As New ArrayList

        Dim adapter As New OleDbDataAdapter("SELECT cuentasUsuario.nombre_usuario, empleados.dni, puestos.nombre
                                            FROM cuentasUsuario ,empleados, puestos WHERE cuentasUsuario.id = empleados.cuenta AND puestos.id = empleados.puesto
                                            ", connection)
        Dim dataset As New DataSet
        adapter.Fill(dataset)

        For Each row As DataRow In dataset.Tables(0).Rows
            Dim values() As Object = row.ItemArray
            Dim user As New User(values(0).ToString,
                                 values(1).ToString,
                                 values(2).ToString)
            users.Add(user)
        Next


        Return users
    End Function

    Public Function checkPassword(nameUser As String, password As String) As Boolean
        Dim ok = False
        Dim resu As String
        Dim query As String = "SELECT contrasenya FROM cuentasUsuario WHERE nombre_usuario = '" & nameUser & "'"
        Dim adapter As New OleDbDataAdapter(query, connection)
        Dim dataset As New DataSet
        adapter.Fill(dataset)
        resu = dataset.Tables(0).Rows(0).Item(0)
        If password.Equals(resu) Then
            ok = True
        End If
        Return ok
    End Function



End Class
