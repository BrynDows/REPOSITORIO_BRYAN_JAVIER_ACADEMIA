<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formModify
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.flpPricipal = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpDni = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.mtbDni = New System.Windows.Forms.MaskedTextBox()
        Me.flpCuenta = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.flpNombre = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtbNombre = New System.Windows.Forms.MaskedTextBox()
        Me.flpPuesto = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.flpDireccion = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mtbDireccion = New System.Windows.Forms.MaskedTextBox()
        Me.flpApellido = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtbApellido = New System.Windows.Forms.MaskedTextBox()
        Me.flpEmail = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtbEmail = New System.Windows.Forms.MaskedTextBox()
        Me.flpIdioma = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbIdioma = New System.Windows.Forms.ComboBox()
        Me.flpTel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtbTel = New System.Windows.Forms.MaskedTextBox()
        Me.bDone = New System.Windows.Forms.Button()
        Me.mtbPuesto = New System.Windows.Forms.MaskedTextBox()
        Me.mtbCuenta = New System.Windows.Forms.MaskedTextBox()
        Me.flpPricipal.SuspendLayout()
        Me.flpDni.SuspendLayout()
        Me.flpCuenta.SuspendLayout()
        Me.flpNombre.SuspendLayout()
        Me.flpPuesto.SuspendLayout()
        Me.flpDireccion.SuspendLayout()
        Me.flpApellido.SuspendLayout()
        Me.flpEmail.SuspendLayout()
        Me.flpIdioma.SuspendLayout()
        Me.flpTel.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpPricipal
        '
        Me.flpPricipal.Controls.Add(Me.flpDni)
        Me.flpPricipal.Controls.Add(Me.flpCuenta)
        Me.flpPricipal.Controls.Add(Me.flpNombre)
        Me.flpPricipal.Controls.Add(Me.flpPuesto)
        Me.flpPricipal.Controls.Add(Me.flpDireccion)
        Me.flpPricipal.Controls.Add(Me.flpApellido)
        Me.flpPricipal.Controls.Add(Me.flpEmail)
        Me.flpPricipal.Controls.Add(Me.flpIdioma)
        Me.flpPricipal.Controls.Add(Me.flpTel)
        Me.flpPricipal.Location = New System.Drawing.Point(25, 56)
        Me.flpPricipal.Name = "flpPricipal"
        Me.flpPricipal.Size = New System.Drawing.Size(942, 534)
        Me.flpPricipal.TabIndex = 20
        '
        'flpDni
        '
        Me.flpDni.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpDni.Controls.Add(Me.lblDni)
        Me.flpDni.Controls.Add(Me.mtbDni)
        Me.flpDni.Location = New System.Drawing.Point(3, 3)
        Me.flpDni.Name = "flpDni"
        Me.flpDni.Size = New System.Drawing.Size(1024, 52)
        Me.flpDni.TabIndex = 0
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.BackColor = System.Drawing.Color.SteelBlue
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.Location = New System.Drawing.Point(3, 0)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Padding = New System.Windows.Forms.Padding(200, 0, 0, 0)
        Me.lblDni.Size = New System.Drawing.Size(258, 32)
        Me.lblDni.TabIndex = 16
        Me.lblDni.Text = "Dni"
        '
        'mtbDni
        '
        Me.mtbDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbDni.Location = New System.Drawing.Point(464, 0)
        Me.mtbDni.Margin = New System.Windows.Forms.Padding(200, 0, 0, 0)
        Me.mtbDni.Name = "mtbDni"
        Me.mtbDni.Size = New System.Drawing.Size(356, 38)
        Me.mtbDni.TabIndex = 17
        '
        'flpCuenta
        '
        Me.flpCuenta.Controls.Add(Me.Label7)
        Me.flpCuenta.Controls.Add(Me.mtbCuenta)
        Me.flpCuenta.Location = New System.Drawing.Point(3, 61)
        Me.flpCuenta.Name = "flpCuenta"
        Me.flpCuenta.Size = New System.Drawing.Size(1024, 52)
        Me.flpCuenta.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(200, 0, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(307, 32)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Cuenta"
        '
        'flpNombre
        '
        Me.flpNombre.Controls.Add(Me.Label1)
        Me.flpNombre.Controls.Add(Me.mtbNombre)
        Me.flpNombre.Location = New System.Drawing.Point(3, 119)
        Me.flpNombre.Name = "flpNombre"
        Me.flpNombre.Size = New System.Drawing.Size(1024, 52)
        Me.flpNombre.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(200, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(315, 32)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nombre"
        '
        'mtbNombre
        '
        Me.mtbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbNombre.Location = New System.Drawing.Point(466, 0)
        Me.mtbNombre.Margin = New System.Windows.Forms.Padding(145, 0, 0, 0)
        Me.mtbNombre.Name = "mtbNombre"
        Me.mtbNombre.Size = New System.Drawing.Size(356, 38)
        Me.mtbNombre.TabIndex = 26
        '
        'flpPuesto
        '
        Me.flpPuesto.Controls.Add(Me.Label8)
        Me.flpPuesto.Controls.Add(Me.mtbPuesto)
        Me.flpPuesto.Location = New System.Drawing.Point(3, 177)
        Me.flpPuesto.Name = "flpPuesto"
        Me.flpPuesto.Size = New System.Drawing.Size(1024, 52)
        Me.flpPuesto.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(200, 0, 0, 0)
        Me.Label8.Size = New System.Drawing.Size(304, 32)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Puesto"
        '
        'flpDireccion
        '
        Me.flpDireccion.Controls.Add(Me.Label5)
        Me.flpDireccion.Controls.Add(Me.mtbDireccion)
        Me.flpDireccion.Location = New System.Drawing.Point(3, 235)
        Me.flpDireccion.Name = "flpDireccion"
        Me.flpDireccion.Size = New System.Drawing.Size(1024, 52)
        Me.flpDireccion.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(200, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(334, 32)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Dirección"
        '
        'mtbDireccion
        '
        Me.mtbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbDireccion.Location = New System.Drawing.Point(470, 0)
        Me.mtbDireccion.Margin = New System.Windows.Forms.Padding(130, 0, 0, 0)
        Me.mtbDireccion.Name = "mtbDireccion"
        Me.mtbDireccion.Size = New System.Drawing.Size(356, 38)
        Me.mtbDireccion.TabIndex = 30
        '
        'flpApellido
        '
        Me.flpApellido.Controls.Add(Me.Label2)
        Me.flpApellido.Controls.Add(Me.mtbApellido)
        Me.flpApellido.Location = New System.Drawing.Point(3, 293)
        Me.flpApellido.Name = "flpApellido"
        Me.flpApellido.Size = New System.Drawing.Size(1024, 52)
        Me.flpApellido.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(200, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(319, 32)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Apellido"
        '
        'mtbApellido
        '
        Me.mtbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbApellido.Location = New System.Drawing.Point(471, 0)
        Me.mtbApellido.Margin = New System.Windows.Forms.Padding(146, 0, 0, 0)
        Me.mtbApellido.Name = "mtbApellido"
        Me.mtbApellido.Size = New System.Drawing.Size(356, 38)
        Me.mtbApellido.TabIndex = 27
        '
        'flpEmail
        '
        Me.flpEmail.Controls.Add(Me.Label4)
        Me.flpEmail.Controls.Add(Me.mtbEmail)
        Me.flpEmail.Location = New System.Drawing.Point(3, 351)
        Me.flpEmail.Name = "flpEmail"
        Me.flpEmail.Size = New System.Drawing.Size(1024, 52)
        Me.flpEmail.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(200, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(447, 32)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Correo electrónico"
        '
        'mtbEmail
        '
        Me.mtbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbEmail.Location = New System.Drawing.Point(473, 0)
        Me.mtbEmail.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.mtbEmail.Name = "mtbEmail"
        Me.mtbEmail.Size = New System.Drawing.Size(356, 38)
        Me.mtbEmail.TabIndex = 29
        '
        'flpIdioma
        '
        Me.flpIdioma.Controls.Add(Me.Label6)
        Me.flpIdioma.Controls.Add(Me.cbIdioma)
        Me.flpIdioma.Location = New System.Drawing.Point(3, 409)
        Me.flpIdioma.Name = "flpIdioma"
        Me.flpIdioma.Size = New System.Drawing.Size(1024, 52)
        Me.flpIdioma.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(200, 0, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(300, 32)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Idioma"
        '
        'cbIdioma
        '
        Me.cbIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIdioma.FormattingEnabled = True
        Me.cbIdioma.Location = New System.Drawing.Point(471, 0)
        Me.cbIdioma.Margin = New System.Windows.Forms.Padding(165, 0, 0, 0)
        Me.cbIdioma.Name = "cbIdioma"
        Me.cbIdioma.Size = New System.Drawing.Size(356, 39)
        Me.cbIdioma.TabIndex = 32
        '
        'flpTel
        '
        Me.flpTel.Controls.Add(Me.Label3)
        Me.flpTel.Controls.Add(Me.mtbTel)
        Me.flpTel.Location = New System.Drawing.Point(3, 467)
        Me.flpTel.Name = "flpTel"
        Me.flpTel.Size = New System.Drawing.Size(1024, 52)
        Me.flpTel.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(200, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(327, 32)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Teléfono"
        '
        'mtbTel
        '
        Me.mtbTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbTel.Location = New System.Drawing.Point(472, 0)
        Me.mtbTel.Margin = New System.Windows.Forms.Padding(139, 0, 0, 0)
        Me.mtbTel.Name = "mtbTel"
        Me.mtbTel.Size = New System.Drawing.Size(356, 38)
        Me.mtbTel.TabIndex = 28
        '
        'bDone
        '
        Me.bDone.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDone.Location = New System.Drawing.Point(430, 619)
        Me.bDone.Name = "bDone"
        Me.bDone.Size = New System.Drawing.Size(161, 61)
        Me.bDone.TabIndex = 31
        Me.bDone.Text = "Modificar"
        Me.bDone.UseVisualStyleBackColor = True
        '
        'mtbPuesto
        '
        Me.mtbPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbPuesto.Location = New System.Drawing.Point(468, 0)
        Me.mtbPuesto.Margin = New System.Windows.Forms.Padding(158, 0, 0, 0)
        Me.mtbPuesto.Name = "mtbPuesto"
        Me.mtbPuesto.Size = New System.Drawing.Size(356, 38)
        Me.mtbPuesto.TabIndex = 36
        '
        'mtbCuenta
        '
        Me.mtbCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCuenta.Location = New System.Drawing.Point(463, 0)
        Me.mtbCuenta.Margin = New System.Windows.Forms.Padding(150, 0, 0, 0)
        Me.mtbCuenta.Name = "mtbCuenta"
        Me.mtbCuenta.Size = New System.Drawing.Size(356, 38)
        Me.mtbCuenta.TabIndex = 34
        '
        'formModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1039, 729)
        Me.Controls.Add(Me.flpPricipal)
        Me.Controls.Add(Me.bDone)
        Me.Name = "formModify"
        Me.Text = "FormModify"
        Me.flpPricipal.ResumeLayout(False)
        Me.flpDni.ResumeLayout(False)
        Me.flpDni.PerformLayout()
        Me.flpCuenta.ResumeLayout(False)
        Me.flpCuenta.PerformLayout()
        Me.flpNombre.ResumeLayout(False)
        Me.flpNombre.PerformLayout()
        Me.flpPuesto.ResumeLayout(False)
        Me.flpPuesto.PerformLayout()
        Me.flpDireccion.ResumeLayout(False)
        Me.flpDireccion.PerformLayout()
        Me.flpApellido.ResumeLayout(False)
        Me.flpApellido.PerformLayout()
        Me.flpEmail.ResumeLayout(False)
        Me.flpEmail.PerformLayout()
        Me.flpIdioma.ResumeLayout(False)
        Me.flpIdioma.PerformLayout()
        Me.flpTel.ResumeLayout(False)
        Me.flpTel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents flpPricipal As FlowLayoutPanel
    Friend WithEvents flpDni As FlowLayoutPanel
    Friend WithEvents lblDni As Label
    Friend WithEvents mtbDni As MaskedTextBox
    Friend WithEvents flpCuenta As FlowLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbIdioma As ComboBox
    Friend WithEvents bDone As Button
    Friend WithEvents mtbDireccion As MaskedTextBox
    Friend WithEvents mtbEmail As MaskedTextBox
    Friend WithEvents mtbTel As MaskedTextBox
    Friend WithEvents mtbApellido As MaskedTextBox
    Friend WithEvents mtbNombre As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents flpIdioma As FlowLayoutPanel
    Friend WithEvents flpNombre As FlowLayoutPanel
    Friend WithEvents flpPuesto As FlowLayoutPanel
    Friend WithEvents flpDireccion As FlowLayoutPanel
    Friend WithEvents flpApellido As FlowLayoutPanel
    Friend WithEvents flpEmail As FlowLayoutPanel
    Friend WithEvents flpTel As FlowLayoutPanel
    Friend WithEvents mtbCuenta As MaskedTextBox
    Friend WithEvents mtbPuesto As MaskedTextBox
End Class
