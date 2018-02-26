Imports idiomasDLL

Public Class formModify

    Public Property Modo As Byte

    Public Property alu As Alumno

    Public Property alum_OR_Emple As Byte

    Public Property prof_OR_emple As Byte
    Private oldAccountEmploye As String
    Private profes As String()

    Private Sub FormModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtbTel.Mask = "000000000" ' Máscara para el campo teléfono
        mtbDni.Mask = "00000000>L" ' Máscara para el campo DNI

        flpIdioma.Visible = True
        flpIdioma.Enabled = True
        If Modo = INSERTAR Then
            bDone.Text = "Añadir"
            mtbDni.Enabled = True
            If alum_OR_Emple = ALUMNOS Then
                Me.Text = "Añadir nuevo alumno"
                lIdiomas.Text = "Profesores"
            Else
                Me.Text = "Añadir nuevo empleado"
                lIdiomas.Text = "Idioma"
            End If
        Else
            bDone.Text = "Modificar"
            If alum_OR_Emple = ALUMNOS Then
                Me.Text = "Modificar datos del alumno"
                lIdiomas.Text = "Profesores"
            Else
                Me.Text = "Modificar datos del empleado"
                lIdiomas.Text = "Idiomas"
            End If
        End If
        If alum_OR_Emple = ALUMNOS Then
            flpPuesto.Visible = False
            flpPassword.Visible = False
            cbIdioma.DataSource = idiomasDLL.Alumnos.SelectAllProfes.Tables(0)
            cbIdioma.DisplayMember = "nombre"
            profes = (From id In idiomasDLL.Alumnos.SelectAllProfes.Tables(0).AsEnumerable
                      Select id.Field(Of String)("dni")).ToArray
        End If

        If alum_OR_Emple = ALUMNOS And Modo = ACTUALIZAR Then
            flpPuesto.Visible = False
            flpPassword.Visible = False
            mtbDni.Text = alu.DNI
            mtbNombre.Text = alu.Nombre
            mtbApellido.Text = alu.Apellido
            mtbTel.Text = alu.Telefono
            mtbEmail.Text = alu.Email
            mtbDireccion.Text = alu.Direccion
            mtbDni.Enabled = False
        End If

        If alum_OR_Emple = EMPLEADOS Then
            'TODO: esta línea de código carga datos en la tabla 'Academy_bdDataSet1.idiomas' Puede moverla o quitarla según sea necesario.
            Me.IdiomasTableAdapter.Fill(Me.Academy_bdDataSet1.idiomas)
            cbIdioma.DataSource = IdiomasBindingSource
            cbIdioma.DisplayMember = "idioma"
            cbIdioma.Enabled = True
            If Modo = ACTUALIZAR Then
                oldAccountEmploye = mtbEmail.Text
                mtbDni.Enabled = False
                cbIdioma.Enabled = False
            End If
            flpPuesto.Visible = True
            'cargar comboBox: cbPuesto
            Try
                modulo.crudEmployes.loadComboBoxPuestos(cbPuesto)
            Catch ex As Exception
                idiomasDLL.INSERT_IN_ERROR_LOG(ex)
            End Try
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
    '
    'Button Done
    '
    Private Sub bDone_Click(sender As Object, e As EventArgs) Handles bDone.Click
        If mtbDni.MaskFull And mtbTel.MaskFull And mtbEmail.Text.Length > 0 And mtbDireccion.Text.Length > 0 Then
            If idiomasDLL.Validaciones.isValidEmail(mtbEmail.Text) Then
                If idiomasDLL.Validaciones.isValidName(mtbNombre.Text) And idiomasDLL.Validaciones.isValidApe(mtbApellido.Text) Then
                    If mtbDireccion.Text.Length <= 80 Then
                        '
                        'Alumnos
                        '
                        If Modo = INSERTAR And alum_OR_Emple = ALUMNOS Then
                            Try
                                If FormManagement.user.Rol.Equals("administrador") Then
                                    idiomasDLL.Alumnos.InsertAlumno(profes(cbIdioma.SelectedIndex), New idiomasDLL.Alumno(mtbDni.Text, mtbNombre.Text, mtbApellido.Text, mtbTel.Text, mtbEmail.Text, mtbDireccion.Text))
                                Else
                                    idiomasDLL.Alumnos.InsertAlumno(FormManagement.user.dni, New idiomasDLL.Alumno(mtbDni.Text, mtbNombre.Text, mtbApellido.Text, mtbTel.Text, mtbEmail.Text, mtbDireccion.Text))
                                End If
                                FormManagement.LoadDataGrids()
                                idiomasDLL.Alumnos.generateReport_lastRecord(mtbDni.Text)
                                FormCrystal.Show()
                                Me.Close()
                            Catch ex As System.Data.OleDb.OleDbException
                                MsgBox("Error al insertar el alumno.", MsgBoxStyle.Critical, "Error")
                                idiomasDLL.Alumnos.CloseConnection()
                                idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
                            Catch ex As Exception
                                If MsgBox("Parece que no tienes instalado Crystal Report. Este programa es necesario para generar el informe. Pulsa aceptar para descargarlo.", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "ERROR") = MsgBoxResult.Yes Then
                                    Process.Start("http://downloads.businessobjects.com/akdlm/cr4vs2010/CRforVS_13_0_22.exe")
                                End If
                                idiomasDLL.Alumnos.CloseConnection()
                                idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
                            End Try
                        ElseIf Modo = ACTUALIZAR And alum_OR_Emple = ALUMNOS Then
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
                        '
                        'Empleados
                        '
                        If Modo = INSERTAR And alum_OR_Emple = EMPLEADOS And prof_OR_emple = INSERTAR_PROFESOR Then

                            Try
                                crudEmployes.InsertTeacher(mtbDni.Text, mtbNombre.Text, mtbApellido.Text, mtbEmail.Text, tbPass.Text, cbPuesto.SelectedItem, mtbTel.Text, mtbDireccion.Text, cbIdioma.SelectedItem.ToString)
                                FormManagement.LoadDataGrids()
                                Me.Close()
                            Catch ex As Exception
                                MsgBox("Error al insertar el registro.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
                                idiomasDLL.INSERT_IN_ERROR_LOG(ex)
                            End Try
                        ElseIf Modo = INSERTAR And alum_OR_Emple = EMPLEADOS And prof_OR_emple = INSERTAR_EMPLEADO Then
                            Try
                                crudEmployes.InsertEmploye(mtbDni.Text, mtbNombre.Text, cbPuesto.SelectedItem, mtbApellido.Text, mtbTel.Text, mtbDireccion.Text, mtbEmail.Text)
                                FormManagement.LoadDataGrids()
                                Me.Close()
                            Catch ex As Exception

                                MsgBox("Error al insertar el registro.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
                                idiomasDLL.INSERT_IN_ERROR_LOG(ex)
                            End Try
                        ElseIf Modo = ACTUALIZAR And alum_OR_Emple = EMPLEADOS Then
                            Try
                                crudEmployes.UpdateEmployee(New Employe(mtbDni.Text,
                                                                        mtbNombre.Text,
                                                                        cbPuesto.SelectedItem,
                                                                        mtbApellido.Text,
                                                                        mtbTel.Text,
                                                                        mtbDireccion.Text,
                                                                        mtbEmail.Text,
                                                                        New User(mtbEmail.Text, mtbDni.Text, cbPuesto.SelectedItem.id, tbPass.Text)
                                                                        ), oldAccountEmploye)
                                FormManagement.LoadDataGrids()
                                Me.Close()

                            Catch ex As Exception
                                MsgBox("Error al actualizar el registro.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
                                idiomasDLL.INSERT_IN_ERROR_LOG(ex)
                            End Try
                        End If
                    Else
                        MsgBox("La dirección es demasiado larga.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Dirección demasiado larga")
                    End If
                Else
                    MsgBox("El nombre y/o los apellidos no son válidos.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Campo incorrecto")
                End If
            Else
                MsgBox("La dirección de email no es válida. Revísala.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Email incorrecto")
            End If
        Else
            MsgBox("Todos los campos son necesarios.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Campos requeridos")
        End If
    End Sub
    '
    'masked DNI
    '
    Private Sub mtbDni_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)
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
                cuenta = CInt(mtbEmail.Text)
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

    Private Sub cbPuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPuesto.SelectedIndexChanged

        If cbPuesto.SelectedItem.id = 1 Then
            flpPassword.Visible = True
            prof_OR_emple = INSERTAR_PROFESOR
            flpIdioma.Visible = True
        Else
            prof_OR_emple = INSERTAR_EMPLEADO
            flpPassword.Visible = False
            flpIdioma.Visible = False
        End If
        If cbPuesto.SelectedItem.id = 2 Then
            flpPassword.Visible = True
            prof_OR_emple = INSERTAR_PROFESOR
        End If
    End Sub

    Private Sub formModify_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cbPuesto.Items.Clear()
    End Sub

    Private Sub tsbInformacion_Click(sender As Object, e As EventArgs)
        FormInformation.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub tsbInformacion_Click_1(sender As Object, e As EventArgs) Handles tsbInformacion.Click
        FormInformation.ShowDialog()
    End Sub

    Private Sub tsbAYdua_Click(sender As Object, e As EventArgs) Handles tsbAYdua.Click
        modulo.mostrar_ayuda()
    End Sub
    Private Sub mtbApellido_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbApellido.MaskInputRejected

    End Sub

    Private Sub mtbEmail_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbEmail.MaskInputRejected

    End Sub
End Class