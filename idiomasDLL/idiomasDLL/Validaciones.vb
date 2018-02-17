Imports System.Text.RegularExpressions

Public Module Validaciones
    Public Function isValidEmail(ByVal email As String) As Boolean
        Return Regex.IsMatch(email, "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" &
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
    End Function
End Module
