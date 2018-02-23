Imports Academy

Public Class User
    Public ReadOnly Property id As Byte
    Public ReadOnly Property userName As String
    Public ReadOnly Property dni As String
    Public ReadOnly Property Rol As String
    Public ReadOnly Property password As String

    Public Sub New(userName As String, dni As String, rol As String)
        Me.userName = userName
        Me.dni = dni
        Me.Rol = rol
    End Sub

    Public Sub New(userName As String, dni As String, rol As String, password As String)
        Me.New(userName, dni, rol)
        Me.password = password
    End Sub


    Public Overrides Function ToString() As String
        Return String.Format("[Usuario], usuario: " & userName & ", Rol: " & Rol)
    End Function

End Class
