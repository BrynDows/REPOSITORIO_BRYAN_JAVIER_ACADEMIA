Public Class formModify

    Public Property Modo As Byte

    Private Sub FormModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtbTel.Mask = "000000000"
        mtbDni.Mask = "00000000>L"
        If Modo = 0 Then
            bDone.Text = "Añadir"
        Else
            bDone.Text = "Modificar"
        End If
    End Sub

    Private Sub mtbTel_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)
        If mtbTel.MaskFull Then
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

    Private Sub bDone_Click(sender As Object, e As EventArgs) Handles bDone.Click

        If Modo = 0 Then
            If mtbNombre.Text.Length > 0 And mtbApellido.Text.Length > 0 And mtbEmail.Text.Length > 0 AndAlso mtbDireccion.Text.Length > 0 Then
                If idiomasDLL.Validaciones.isValidEmail(mtbEmail.Text) Then
                    Try
                        idiomasDLL.Alumnos.InsertAlumno(FormManagement.user.dni, New idiomasDLL.Alumno(mtbDni.Text, mtbNombre.Text, mtbApellido.Text, mtbTel.Text, mtbEmail.Text, mtbDireccion.Text))
                        FormManagement.LoadDataGrids()
                        Me.Close()
                    Catch ex As System.Data.OleDb.OleDbException
                        MsgBox("Este alumno ya existe en la base de datos.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
                        idiomasDLL.Alumnos.CloseConnection()
                    End Try
                Else
                    MsgBox("La dirección de email no es válida. Revísala.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Email incorrecto")
                End If
            Else
                MsgBox("Todos los campos son necesarios.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Campos requeridos")
            End If
        End If
    End Sub

    Private Sub mtbDni_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbDni.MaskInputRejected
        If mtbDni.MaskFull Then
            ToolTip1.ToolTipTitle = "DNI demasiado largo"
            ToolTip1.Show("El DNI es demasiado largo.", mtbDni, 5000)
        ElseIf (e.Position = mtbDni.Mask.Length) Then
            ToolTip1.ToolTipTitle = "Fuera de rango"
            ToolTip1.Show("Este DNI está fuera de rango.", mtbDni, 5000)
        Else
            ToolTip1.ToolTipTitle = "Carácter no válido"
            ToolTip1.Show("Formato de DNI no válido.", mtbDni, 5000)
        End If
        'bryan
        If (sender.text.Equals("Añadir")) Then
            Dim dni, nombre, apellido, direccion, email, telefono As String
            Dim cuenta, puesto As Integer
            Try
                cuenta = CInt(mtbCuenta.Text)
                puesto = CInt(mtbPuesto.Text)
            Catch ex As InvalidCastException

            End Try
            nombre = mtbNombre.Text
            apellido = mtbApellido.Text
            dni = mtbDni.Text
            direccion = mtbDireccion.Text
            email = mtbEmail.Text
            telefono = mtbTel.Text

            modulo.crudEmployes.InsertEmploye(dni, nombre, cuenta, puesto, apellido, telefono, direccion, email)


        End If
    End Sub
End Class