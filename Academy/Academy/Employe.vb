Imports Academy

Public Class Employe
    Public ReadOnly Property dni As String
    Public ReadOnly Property name As String
    Public ReadOnly Property job As Integer
    Public ReadOnly Property account As Integer
    Public ReadOnly Property surname As String
    Public ReadOnly Property tel As String
    Public ReadOnly Property address As String
    Public ReadOnly Property email As String

    ''' <summary>
    ''' Instanciar empleado normal
    ''' </summary>
    ''' <param name="dni"></param>
    ''' <param name="name"></param>
    ''' <param name="job"></param>
    ''' <param name="surname"></param>
    ''' <param name="tel"></param>
    ''' <param name="address"></param>
    ''' <param name="email"></param>
    Public Sub New(dni As String, name As String, job As Integer, surname As String, tel As String, address As String, email As String)
        Me.dni = dni
        Me.name = name
        Me.job = job
        Me.surname = surname
        Me.tel = tel
        Me.address = address
        Me.email = email
    End Sub
    ''' <summary>
    ''' Instanciar Profesor
    ''' </summary>
    ''' <param name="dni"></param>
    ''' <param name="name"></param>
    ''' <param name="job"></param>
    ''' <param name="account"></param>
    ''' <param name="surname"></param>
    ''' <param name="tel"></param>
    ''' <param name="address"></param>
    ''' <param name="email"></param>
    Public Sub New(dni As String, name As String, job As Integer, account As Integer, surname As String, tel As String, address As String, email As String)
        Me.dni = dni
        Me.name = name
        Me.job = job
        Me.account = account
        Me.surname = surname
        Me.tel = tel
        Me.address = address
        Me.email = email
    End Sub
End Class
