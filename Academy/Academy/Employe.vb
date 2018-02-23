Imports Academy

Public Class Employe
    Public ReadOnly Property dni As String
    Public ReadOnly Property nombre As String
    Public ReadOnly Property puesto As Puesto
    Public ReadOnly Property apellido As String
    Public ReadOnly Property telefono As String
    Public ReadOnly Property direccion As String
    Public ReadOnly Property email As String
    Public ReadOnly Property user As User
    Public Sub New(dni As String, nombre As String, puesto As Puesto, apellido As String, telefono As String, direccion As String, email As String, user As User)
        Me.dni = dni
        Me.nombre = nombre
        Me.puesto = puesto
        Me.apellido = apellido
        Me.telefono = telefono
        Me.direccion = direccion
        Me.email = email
        Me.user = user
    End Sub

End Class
