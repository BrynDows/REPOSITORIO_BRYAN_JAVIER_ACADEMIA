Imports System.Text.RegularExpressions

Public Module Validaciones
    Public Function isValidEmail(ByVal email As String) As Boolean
        Return Regex.IsMatch(email, "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" &
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
    End Function

    Public Function isValidName(ByVal name As String) As Boolean
        Return Regex.IsMatch(name, "^[a-zA-Z]{1,20}$")
    End Function

    Public Function isValidApe(ByVal ape As String) As Boolean
        Return Regex.IsMatch(ape, "^[a-zA-Z]{1,50}$")
    End Function
End Module
