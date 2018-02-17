Imports Academy

Public Class User
    Public ReadOnly Property Name As String
    Public ReadOnly Property Rol As String

    Public Sub New(name As String, password As String, rol As String)
        Me.Name = name
        Me.Rol = rol
    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("[Usuario], usuario: " & Name & ", Rol: " & Rol)
    End Function

End Class
