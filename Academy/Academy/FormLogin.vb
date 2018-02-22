Imports idiomasDLL.Errores

Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        addUser(New User("bryan", "22222222B", "jefe"))
        addUser(New User("javier", "22222222B", "profesor"))

    End Sub

    'Adición de usuario a modo de windows, la imagen es siempre la misma.
    Public Sub addUser(user As User)
        Dim panel As New FlowLayoutPanel
        panel.AutoSize = False
        panel.FlowDirection = FlowDirection.TopDown
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.Size = New Size(80, 100)

        Dim ima As New PictureBox
        ima.Size = New Size(70, 70)
        ima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Dim label As New Label
        label.Text = user.Name
        label.AutoSize = True
        label.Padding = New Padding(15, 0, 0, 0)
        Try
            ima.Image = My.Resources.user
            flowPanel.Controls.Add(ima)
        Catch ex As Exception
            'INSERT_IN_ERROR_LOG(ex)
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
        FormManagement.Show()
        Me.Close()
    End Sub


End Class