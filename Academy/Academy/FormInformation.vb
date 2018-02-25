Imports System.IO
Public Class FormInformation
    Private Sub Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("informacion.txt")
            RichTextBox1.Text = fileReader
        Catch ex As Exception
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
            RichTextBox1.Text = "No se ha encontrado el [fichero informacion.txt] "
        End Try

    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class