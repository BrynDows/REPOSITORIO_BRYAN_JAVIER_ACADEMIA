Public Class Alumno
    Public Property DN As String
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Telefono As String
    Public Property Email As String
    Public Property Direccion As String

    Public Sub New(dN As String, nombre As String, apellido As String, telefono As String, email As String, direccion As String)
        Me.DN = dN
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Telefono = telefono
        Me.Email = email
        Me.Direccion = direccion
    End Sub
End Class
