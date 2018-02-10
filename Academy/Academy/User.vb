Imports Academy

Public Class User
    Private name As String
    Private password As String
    Private rol As String

    Public Sub New(name As String, password As String, rol As String)
        Me.name = name
        Me.password = password
        Me.rol = rol
    End Sub

    Public Function getName() As String
        Return Me.name
    End Function

    Public Function getPassword() As String
        Return Me.password
    End Function

    Public Function getRol() As String
        Return Me.rol
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("[Usuario], usuario: " & name & ", Contraseña: " & password & ", Rol: " & rol)
    End Function

End Class
