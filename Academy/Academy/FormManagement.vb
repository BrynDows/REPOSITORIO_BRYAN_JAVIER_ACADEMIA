Public Class FormManagement


    Public Property user As User

    ' Mode representa el ROl con el cual se ha accedido a este formulario,.
    ' mode = 0: se ha accedido como jefe
    ' mode = 1: se ha accedido como profesor
    Public Property Mode As Byte

    ' tabMode representa mediante un entero cual es la "pestañita" que está seleccionada.
    ' tcModos_SelectedIndexChanged() es el método que altera esta variable.
    ' esta variable es usada en el método bAdd_Click()
    Private modeTab As String


    Private Sub FormManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tcModos.TabPages.Remove(tabProfesores)
        If user.Rol.Equals("jefe") Then
            'soy jefe y muesro las dos pestañas, profesor y alumnos
            tcModos.TabPages.Insert(0, tabProfesores)
        End If
        LoadDataGrids()
    End Sub

    ''' <summary>
    ''' Cargar datos en los datagrid
    ''' </summary>
    Public Sub LoadDataGrids()
        If user.Rol.Equals("jefe") Then
            dgvAlumnos.DataSource = idiomasDLL.Alumnos.SelectAllAlumnos
            dgvAlumnos.DataMember = "alumnos"
            'mostrar profesores
            modulo.crudEmployes.ShowTeachers(dgvProfesores)
        Else
            dgvAlumnos.DataSource = idiomasDLL.Alumnos.SelectAlumnosByProf(user.dni)
            dgvAlumnos.DataMember = "alumnos"
        End If
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        formModify.Modo = INSERTAR

        If modeTab.Equals("Alumnos") Then ' alumnos
            formModify.flpCuenta.Visible = False
            formModify.flpPuesto.Visible = False
        Else
            formModify.flpCuenta.Visible = True
            formModify.flpPuesto.Visible = True
        End If
        SetTextEmpty()
        formModify.ShowDialog()
    End Sub

    Private Sub bMod_Click(sender As Object, e As EventArgs) Handles bMod.Click
        formModify.Modo = MODIFICAR
        If modeTab.Equals("Profesores") Then
            formModify.alum_OR_Emple = EMPLEADOS
            Dim row = dgvProfesores.SelectedRows(0)
            'formModify.mtbDni.Text = row.Cells(0).Value.ToString
            'formModify.mtbNombre.Text = row.Cells(1).Value.ToString
            'formModify.mtbApellido.Text = row.Cells(1).Value.ToString
            'formModify.mtb
        End If
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


    Private Sub dgvProfesores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProfesores.CellContentClick
        bMod.Enabled = True
    End Sub

    Private Sub tcModos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcModos.SelectedIndexChanged
        modeTab = tcModos.GetControl(sender.selectedIndex).Text
    End Sub
End Class