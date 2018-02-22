Imports idiomasDLL

Public Class formModify

    Public Property Modo As Byte

    Public Property alu As Alumno

    Public Property alum_OR_Emple As Byte


    Private Sub FormModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.IsBalloon = True
        mtbTel.Mask = "000000000"
        'TODO: esta línea de código carga datos en la tabla 'Academy_bdDataSet1.idiomas' Puede moverla o quitarla según sea necesario.
        Me.IdiomasTableAdapter.Fill(Me.Academy_bdDataSet1.idiomas)


        mtbTel.Mask = "000 000 000"

        mtbDni.Mask = "00000000>L"
        If Modo = INSERTAR Then
            bDone.Text = "Añadir"
            mtbDni.Enabled = True
        Else
            bDone.Text = "Modificar"
            mtbDni.Text = alu.DNI
            mtbNombre.Text = alu.Nombre
            mtbApellido.Text = alu.Apellido
            mtbTel.Text = alu.Telefono
            mtbEmail.Text = alu.Email
            mtbDireccion.Text = alu.Direccion
            mtbDni.Enabled = False
        End If
        'cargar comboBox: cbPuesto
        modulo.crudEmployes.loadComboBoxPuestos(cbPuesto)
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
    '
    'Button Done
    '
    Private Sub bDone_Click(sender As Object, e As EventArgs) Handles bDone.Click
<<<<<<< HEAD
        If mtbNombre.Text.Length > 0 And mtbApellido.Text.Length > 0 And mtbEmail.Text.Length > 0 AndAlso mtbDireccion.Text.Length > 0 Then
            If idiomasDLL.Validaciones.isValidEmail(mtbEmail.Text) Then
                If Modo = 0 Then
=======

        If Modo = INSERTAR And alum_OR_Emple = ALUMNOS Then
            If mtbNombre.Text.Length > 0 And mtbApellido.Text.Length > 0 And mtbEmail.Text.Length > 0 AndAlso mtbDireccion.Text.Length > 0 Then
                If idiomasDLL.Validaciones.isValidEmail(mtbEmail.Text) Then
>>>>>>> Bryan
                    Try
                        idiomasDLL.Alumnos.InsertAlumno(FormManagement.user.dni, New idiomasDLL.Alumno(mtbDni.Text, mtbNombre.Text, mtbApellido.Text, mtbTel.Text, mtbEmail.Text, mtbDireccion.Text))
                        FormManagement.LoadDataGrids()
                        Me.Close()
                    Catch ex As System.Data.OleDb.OleDbException
                        MsgBox("Este alumno ya existe en la base de datos.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
                        idiomasDLL.Alumnos.CloseConnection()
                        idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
                    End Try
                Else
                    Try
                        idiomasDLL.Alumnos.UpdateAlumno(New idiomasDLL.Alumno(mtbDni.Text, mtbNombre.Text, mtbApellido.Text, mtbTel.Text, mtbEmail.Text, mtbDireccion.Text))
                        FormManagement.LoadDataGrids()
                        Me.Close()
                    Catch ex As Exception
                        MsgBox("Error al actualizar el registro.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
                        idiomasDLL.Alumnos.CloseConnection()
                        idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
                    End Try
                End If
            Else
                MsgBox("La dirección de email no es válida. Revísala.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Email incorrecto")
            End If
        Else
            MsgBox("Todos los campos son necesarios.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Campos requeridos")
        End If
        'CODIGO JAVIER MODIFICAR
    End Sub
    '
    'masked DNI
    '
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
            Dim dni, nombre, apellido, direccion, email, telefono, password As String
            Dim cuenta As Integer
            Try
                cuenta = CInt(mtbCuenta.Text)
            Catch ex As InvalidCastException
                idiomasDLL.INSERT_IN_ERROR_LOG(ex)
            End Try
            dni = mtbDni.Text
            nombre = mtbNombre.Text
            apellido = mtbApellido.Text
            direccion = mtbDireccion.Text
            email = mtbEmail.Text
            telefono = mtbTel.Text
            password = tbPass.Text

        End If
    End Sub

End Class