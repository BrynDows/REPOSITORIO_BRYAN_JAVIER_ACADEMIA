Imports idiomasDLL

Public Class FormBonos

    Public Property alu As Alumno
    Private actual As String()
    Private isDisabled As Boolean

    Private Sub FormBonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actual = idiomasDLL.Bonos.SelectPrecio(rbInvierno.Checked, rbPresencial.Checked, rbDomi.Checked, nudHoras.Value, nudPersonas.Value)
        lPrice.Text = actual(1) & " €"
        lTitle.Text = "Asignar bono al alumno " & alu.Nombre & " " & alu.Apellido
    End Sub

<<<<<<< HEAD
    Private Sub rbSkype_CheckedChanged(sender As Object, e As EventArgs) Handles rbSkype.CheckedChanged
        If rbSkype.Checked Then
            If nudPersonas.Value > 5 Then
                nudPersonas.Value = 5
            End If
            nudPersonas.Maximum = 5
            gbSeason.Enabled = False
            gbLugar.Enabled = False
            isDisabled = True
        Else
            nudPersonas.Maximum = 6
            gbSeason.Enabled = True
            gbLugar.Enabled = True
            isDisabled = False
        End If
        UpdatePrice(sender, e)
    End Sub

    Private Sub UpdatePrice(sender As Object, e As EventArgs) Handles rbInvierno.CheckedChanged, rbEscuela.CheckedChanged, nudPersonas.ValueChanged, nudHoras.ValueChanged
        If isDisabled Then
            actual = idiomasDLL.Bonos.SelectPrecio(False, rbPresencial.Checked, False, nudHoras.Value, nudPersonas.Value)
        Else
            actual = idiomasDLL.Bonos.SelectPrecio(rbInvierno.Checked, rbPresencial.Checked, rbDomi.Checked, nudHoras.Value, nudPersonas.Value)
        End If
        lPrice.Text = actual(1) & " €"
=======
    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        modulo.ExitToAPP(Me)
    End Sub

    Private Sub tsbInformacion_Click(sender As Object, e As EventArgs) Handles tsbInformacion.Click
        FormInformation.Show()
        Me.Close()
>>>>>>> bryan
    End Sub
End Class