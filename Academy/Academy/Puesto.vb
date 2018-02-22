Public Class Puesto
    Public ReadOnly Property id As Integer
    Public ReadOnly Property name As String

    Public Sub New(id As Integer, name As String)
        Me.id = id
        Me.name = name
    End Sub
    Public Overrides Function ToString() As String
        Return String.Format(name)
    End Function

End Class
