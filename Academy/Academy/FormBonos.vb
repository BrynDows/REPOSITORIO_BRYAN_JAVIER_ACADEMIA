Imports idiomasDLL

Public Class FormBonos

    Public Property alu As Alumno ' Alumno al que se le asigna el bono
    Private actual As String() ' id y precio actual del bono seleccionado
    Private isDisabled As Boolean ' Si es a distancia se deshabilitan las opciones para seleccionar la época de inicio así como el lugar

    Private Sub FormBonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actual = idiomasDLL.Bonos.SelectPrecio(IIf(Month(mcDate.SelectionStart) > 4 And Month(mcDate.SelectionStart) < 10, VERANO, INVIERNO), rbPresencial.Checked, rbDomi.Checked, nudHoras.Value, nudPersonas.Value)
        lPrice.Text = actual(1) & " €"
        lTitle.Text = "Asignar bono al alumno " & alu.Nombre & " " & alu.Apellido
    End Sub


    Private Sub rbSkype_CheckedChanged(sender As Object, e As EventArgs) Handles rbSkype.CheckedChanged
        If rbSkype.Checked Then
            If nudPersonas.Value > 5 Then
                nudPersonas.Value = 5
            End If
            nudPersonas.Maximum = 5
            mcDate.Enabled = False
            gbLugar.Enabled = False
            isDisabled = True
        Else
            nudPersonas.Maximum = 6
            mcDate.Enabled = True
            gbLugar.Enabled = True
            isDisabled = False
        End If
        UpdatePrice(sender, e)
    End Sub

    Private Sub UpdatePrice(sender As Object, e As EventArgs) Handles nudPersonas.ValueChanged, nudHoras.ValueChanged
        If isDisabled Then
            actual = idiomasDLL.Bonos.SelectPrecio(False, rbPresencial.Checked, False, nudHoras.Value, nudPersonas.Value)
        Else
            actual = idiomasDLL.Bonos.SelectPrecio(IIf(Month(mcDate.SelectionStart) > 4 And Month(mcDate.SelectionStart) < 10, VERANO, INVIERNO), rbPresencial.Checked, rbDomi.Checked, nudHoras.Value, nudPersonas.Value)
        End If
        lPrice.Text = actual(1) & " €"
    End Sub

    Private Sub tsbInformacion_Click(sender As Object, e As EventArgs) Handles tsbInformacion.Click
        FormInformation.ShowDialog()
    End Sub

    Private Sub bDone_Click(sender As Object, e As EventArgs) Handles bDone.Click
        Try
            idiomasDLL.Bonos.UpdateAlumnoBono(Convert.ToInt32(actual(0)), alu.DNI)
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al asignar el bono al alumno " & alu.Nombre & " " & alu.Apellido & ".", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
            idiomasDLL.Bonos.CloseConnection()
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
    End Sub

    Private Sub mcDate_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mcDate.DateSelected
        UpdatePrice(sender, e)
    End Sub

    Private Sub tsbAYdua_Click(sender As Object, e As EventArgs) Handles tsbAYdua.Click
        modulo.mostrar_ayuda()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class