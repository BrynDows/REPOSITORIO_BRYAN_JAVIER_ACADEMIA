Public Class Alumno
    Public Property DNI As String
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Telefono As String
    Public Property Email As String
    Public Property Direccion As String

    Public Sub New(dni As String, nombre As String, apellido As String, telefono As String, email As String, direccion As String)
        Me.DNI = dni
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Telefono = telefono
        Me.Email = email
        Me.Direccion = direccion
    End Sub
End Class
