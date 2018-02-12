Imports Academy

Public Class User
    Private name As String
    Private rol As String

    Public Sub New(name As String, password As String, rol As String)
        Me.name = name
        Me.rol = rol
    End Sub

    Public Function getName() As String
        Return Me.name
    End Function


    Public Function getRol() As String
        Return Me.rol
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("[Usuario], usuario: " & name & ", Rol: " & rol)
    End Function

End Class
