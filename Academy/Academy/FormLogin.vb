Imports idiomasDLL.Errores

Public Class FormLogin

    Private actualUser As User
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NotifyIcon.ShowBalloonTip(5)
        btnLogin.Enabled = False
        tbPass.Enabled = False
        For Each user As User In modulo.login.getUsers
            addUser(user)
        Next


    End Sub

    'Adición de usuario a modo de windows, la imagen es siempre la misma.
    Public Sub addUser(user As User)
        Dim panel As New FlowLayoutPanel
        panel.AutoSize = False
        panel.FlowDirection = FlowDirection.LeftToRight
        panel.BorderStyle = BorderStyle.FixedSingle

        panel.BackColor = Color.White
        panel.Size = New Size(200, 100)

        Dim ima As New PictureBox
        ima.Size = New Size(70, 70)
        ima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Dim label As New Label
        label.Text = user.userName
        label.AutoEllipsis = True

        Try
            ima.Image = My.Resources.user
            flowPanel.Controls.Add(ima)
        Catch ex As Exception
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
        End Try

        panel.Tag = user
        ima.Tag = user
        label.Tag = user
        panel.Controls.Add(ima)
        panel.Controls.Add(label)
        flowPanel.Controls.Add(panel)

        AddHandler panel.Click, AddressOf clickUser
        AddHandler ima.Click, AddressOf clickUser
        AddHandler label.Click, AddressOf clickUser

    End Sub

    Private Sub clickUser(sender As Object, e As EventArgs)
        FormManagement.user = sender.Tag
        lNameUser.Text = sender.tag.userName
        actualUser = sender.tag
        tbPass.Enabled = True
        btnLogin.Enabled = True
    End Sub

    Private Sub tbPass_TextChanged(sender As Object, e As EventArgs) Handles tbPass.TextChanged
        If sender.text.length > 0 Then
            lPass.Visible = False

        Else
            lPass.Visible = True
            lPass.Text = "Introduzca contraseña"
            lPass.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If modulo.login.checkPassword(actualUser.userName, tbPass.Text) = True Then
            FormManagement.Show()
            Me.Close()
        Else
            lPass.Text = "Contraseña incorrecta"
            lPass.Visible = True
            lPass.ForeColor = Color.Red
        End If
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        modulo.ExitToAPP(Me)
    End Sub

    Private Sub tsbAYdua_Click(sender As Object, e As EventArgs) Handles tsbAYdua.Click
        'llamar CHM
    End Sub

    Private Sub tsbInformacion_Click(sender As Object, e As EventArgs) Handles tsbInformacion.Click
        FormInformation.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        modulo.ExitToAPP(Me)
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        'CHM
    End Sub
End Class