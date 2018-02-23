Imports Academy

Public Class User
    Public ReadOnly Property Name As String
    Public ReadOnly Property dni As String
    Public ReadOnly Property Rol As String
    Public ReadOnly Property password As String

    Public Sub New(name As String, dni As String, rol As String)
        Me.Name = name
        Me.dni = dni
        Me.Rol = rol
    End Sub

    Public Sub New(name As String, dni As String, rol As String, password As String)
        Me.New(name, dni, rol)
        Me.password = password
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("[Usuario], usuario: " & Name & ", Rol: " & Rol)
    End Function

End Class
