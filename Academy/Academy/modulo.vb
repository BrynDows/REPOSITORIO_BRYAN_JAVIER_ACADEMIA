Imports System.IO
Module modulo
    'Método que guarda las excepciones que se dan en el LOG
    Public Sub INSERT_IN_ERROR_LOG(ex As Exception)
        Try
            Dim file As New FileStream("LOG.txt", FileMode.Append, FileAccess.Write)
            Dim sr As New StreamWriter(file)
            sr.WriteLine("[" & Now & "] " & ex.GetBaseException().ToString)
            sr.Close()
        Catch exce As Exception

        End Try

    End Sub
End Module
