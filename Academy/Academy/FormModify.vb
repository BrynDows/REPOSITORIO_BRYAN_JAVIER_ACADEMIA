Public Class formModify

    Public Property Modo As Byte

    Private Sub FormModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtbTel.Mask = "000 000 000"
        If Modo = 0 Then
            bDone.Text = "Añadir"
        Else
            bDone.Text = "Modificar"
        End If
    End Sub

    Private Sub mtbTel_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)
        If (mtbTel.MaskFull) Then
            ToolTip1.ToolTipTitle = "Teléfono demasiado largo"
            ToolTip1.Show("El teléfono es demasiado largo.", mtbTel, 5000)
        ElseIf (e.Position = mtbTel.Mask.Length) Then
            ToolTip1.ToolTipTitle = "Fuera de rango"
            ToolTip1.Show("Este teléfono está fuera de rango.", mtbTel, 5000)
        Else
            ToolTip1.ToolTipTitle = "Carácter no válido"
            ToolTip1.Show("Sólo se aceptan números en este caampo.", mtbTel, 5000)
        End If
    End Sub

    Private Sub formModify_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FormManagement.bMod.Enabled = False
    End Sub

End Class