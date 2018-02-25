Imports idiomasDLL

Public Class FormSpecialTax

    Public Property alu As Alumno ' Alumno al que se le asigna la tarifa
    Private actual As String() ' id y precio actual de la tarifa seleccionada

    Private Sub FormSpecialTax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbTitu.SelectedIndex = 0
        actual = SpecialTax.SelectPrecio(cbTitu.SelectedItem.ToString, rbExamen.Checked)
        lPrice.Text = actual(1) & " €"
    End Sub

    Private Sub UpdatePrice(sender As Object, e As EventArgs) Handles cbTitu.SelectedIndexChanged, rbExamen.CheckedChanged
        actual = SpecialTax.SelectPrecio(cbTitu.SelectedItem.ToString, rbExamen.Checked)
        lPrice.Text = actual(1) & " €"
    End Sub

    Private Sub bDone_Click(sender As Object, e As EventArgs) Handles bDone.Click
        Try
            idiomasDLL.SpecialTax.UpdateAlumnoTax(Convert.ToInt32(actual(0)), alu.DNI)
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al asignar la tarifa al alumno " & alu.Nombre & " " & alu.Apellido & ".", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
            idiomasDLL.SpecialTax.CloseConnection()
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
    End Sub

    Private Sub lTitle_Click(sender As Object, e As EventArgs) Handles lTitle.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FormManagement.Show()
        Me.Close()

    End Sub
End Class