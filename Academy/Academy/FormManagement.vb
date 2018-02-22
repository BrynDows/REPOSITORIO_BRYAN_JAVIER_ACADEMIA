Public Class FormManagement

    ' Mode representa el ROl con el cual se ha accedido a este formulario,.
    ' mode = 0: se ha accedido como jefe
    ' mode = 1: se ha accedido como profesor
    Public Property Mode As Byte

    ' tabMode representa mediante un entero cual es la "pestañita" que está seleccionada.
    ' tcModos_SelectedIndexChanged() es el método que altera esta variable.
    ' esta variable es usada en el método bAdd_Click()
    Private modeTab As Integer = 1

    Private crudEmployes As CRUD_employes
    Private Sub FormManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crudEmployes = New CRUD_employes
        tcModos.TabPages.Remove(tabProfesores)
        '0 = jefe, 1 = profesor
        If Mode = 0 Then
            'soy jefe y muesro las dos pestañas, profesor y alumnos
            tcModos.TabPages.Insert(0, tabProfesores)
        End If
        LoadDataGrids()
    End Sub

    Public Sub LoadDataGrids()
        If Mode = 0 Then
            dgvAlumnos.DataSource = idiomasDLL.Alumnos.SelectAllAlumnos
            dgvAlumnos.DataMember = "alumnos"
            'mostrar profesores
            crudEmployes.showTeachers(dgvProfesores)
        Else
            dgvAlumnos.DataSource = idiomasDLL.Alumnos.SelectAlumnosByProf("22222222B")
            dgvAlumnos.DataMember = "alumnos"
        End If
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        formModify.Modo = 0 ' 0 = añadir
        MsgBox(modeTab)
        If modeTab = 1 Then ' empleados
            formModify.flpCuenta.Visible = False
            formModify.flpPuesto.Visible = False
        End If
        SetTextEmpty()
        formModify.ShowDialog()
    End Sub

    Private Sub bMod_Click(sender As Object, e As EventArgs) Handles bMod.Click
        formModify.Modo = 1 ' 1 = modificar

        formModify.ShowDialog()
    End Sub

    Private Sub bLogout_Click(sender As Object, e As EventArgs) Handles bLogout.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Este método establece los campos del formulario FormModify a un texto vacío
    ''' </summary>
    Private Sub SetTextEmpty()
        Dim sizeflpPrincipal = formModify.flpPricipal.Controls.Count
        For i As Integer = 0 To sizeflpPrincipal - 1
            Dim sizeFlpChild = formModify.flpPricipal.Controls(i).Controls.Count
            For e As Integer = 0 To sizeFlpChild - 1
                If formModify.flpPricipal.Controls(i).Controls(e).GetType.ToString.Equals("System.Windows.Forms.MaskedTextBox") Then
                    formModify.flpPricipal.Controls(i).Controls(e).Text = ""
                End If
            Next
        Next
    End Sub

    '
    ' Este evento captura los valores de la celda en la cal se ha hecho click y rellena los campos del formulario FormModify,
    ' cada obtención de dato de cada campo está rodeado de un tryCatch
    '
    Private Sub dgvProfesores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProfesores.CellClick
        Try
            formModify.mtbDni.Text = sender.CurrentRow.Cells("dni").Value
        Catch ex As InvalidCastException
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
        Try
            formModify.mtbNombre.Text = sender.CurrentRow.Cells("nombre").Value
        Catch ex As InvalidCastException
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
        Try
            formModify.mtbCuenta.Text = sender.CurrentRow.Cells("cuenta").Value
        Catch ex As InvalidCastException
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
        Try
            formModify.mtbPuesto.Text = sender.CurrentRow.Cells("puesto").Value
        Catch ex As InvalidCastException
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
        Try
            formModify.mtbApellido.Text = sender.CurrentRow.Cells("apellido").Value
        Catch ex As InvalidCastException
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
        Try
            formModify.mtbTel.Text = sender.CurrentRow.Cells("telefono").Value
        Catch ex As InvalidCastException
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
        Try
            formModify.mtbDireccion.Text = sender.CurrentRow.Cells("direccion").Value
        Catch ex As InvalidCastException
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try
        Try
            formModify.mtbEmail.Text = sender.CurrentRow.Cells("email").Value
        Catch ex As InvalidCastException
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try


    End Sub

    Private Sub dgvProfesores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProfesores.CellContentClick
        bMod.Enabled = True
    End Sub

End Class