<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formModify
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.flpPricipal = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpDni = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.mtbDni = New System.Windows.Forms.MaskedTextBox()
        Me.flpNombre = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtbNombre = New System.Windows.Forms.MaskedTextBox()
        Me.flpApellido = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtbApellido = New System.Windows.Forms.MaskedTextBox()
        Me.flpDireccion = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mtbDireccion = New System.Windows.Forms.MaskedTextBox()
        Me.flpEmail = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtbEmail = New System.Windows.Forms.MaskedTextBox()
        Me.flpPuesto = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbPuesto = New System.Windows.Forms.ComboBox()
        Me.flpTel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtbTel = New System.Windows.Forms.MaskedTextBox()
        Me.flpIdioma = New System.Windows.Forms.FlowLayoutPanel()
        Me.lIdiomas = New System.Windows.Forms.Label()
        Me.cbIdioma = New System.Windows.Forms.ComboBox()
        Me.IdiomasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Academy_bdDataSet1 = New Academy.academy_bdDataSet1()
        Me.flpPassword = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.bDone = New System.Windows.Forms.Button()
        Me.Academy_bdDataSet = New Academy.academy_bdDataSet()
        Me.AcademybdDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcademybdDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdiomasTableAdapter = New Academy.academy_bdDataSet1TableAdapters.idiomasTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.toolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbInformacion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAYdua = New System.Windows.Forms.ToolStripButton()
        Me.flpPricipal.SuspendLayout()
        Me.flpDni.SuspendLayout()
        Me.flpNombre.SuspendLayout()
        Me.flpApellido.SuspendLayout()
        Me.flpDireccion.SuspendLayout()
        Me.flpEmail.SuspendLayout()
        Me.flpPuesto.SuspendLayout()
        Me.flpTel.SuspendLayout()
        Me.flpIdioma.SuspendLayout()
        CType(Me.IdiomasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Academy_bdDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpPassword.SuspendLayout()
        CType(Me.Academy_bdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcademybdDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcademybdDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpPricipal
        '
        Me.flpPricipal.BackColor = System.Drawing.Color.Transparent
        Me.flpPricipal.Controls.Add(Me.flpDni)
        Me.flpPricipal.Controls.Add(Me.flpNombre)
        Me.flpPricipal.Controls.Add(Me.flpApellido)
        Me.flpPricipal.Controls.Add(Me.flpDireccion)
        Me.flpPricipal.Controls.Add(Me.flpEmail)
        Me.flpPricipal.Controls.Add(Me.flpPuesto)
        Me.flpPricipal.Controls.Add(Me.flpTel)
        Me.flpPricipal.Controls.Add(Me.flpIdioma)
        Me.flpPricipal.Controls.Add(Me.flpPassword)
        Me.flpPricipal.Controls.Add(Me.bDone)
        Me.flpPricipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpPricipal.Location = New System.Drawing.Point(0, 0)
        Me.flpPricipal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flpPricipal.Name = "flpPricipal"
        Me.flpPricipal.Padding = New System.Windows.Forms.Padding(0, 125, 0, 0)
        Me.flpPricipal.Size = New System.Drawing.Size(1168, 947)
        Me.flpPricipal.TabIndex = 20
        '
        'flpDni
        '
        Me.flpDni.Controls.Add(Me.lblDni)
        Me.flpDni.Controls.Add(Me.mtbDni)
        Me.flpDni.Location = New System.Drawing.Point(3, 129)
        Me.flpDni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flpDni.Name = "flpDni"
        Me.flpDni.Size = New System.Drawing.Size(1152, 65)
        Me.flpDni.TabIndex = 1
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.BackColor = System.Drawing.Color.Transparent
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.ForeColor = System.Drawing.Color.White
        Me.lblDni.Location = New System.Drawing.Point(3, 0)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Padding = New System.Windows.Forms.Padding(225, 0, 0, 0)
        Me.lblDni.Size = New System.Drawing.Size(298, 38)
        Me.lblDni.TabIndex = 20
        Me.lblDni.Text = "DNI"
        '
        'mtbDni
        '
        Me.mtbDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbDni.Location = New System.Drawing.Point(529, 0)
        Me.mtbDni.Margin = New System.Windows.Forms.Padding(225, 0, 0, 0)
        Me.mtbDni.Name = "mtbDni"
        Me.mtbDni.Size = New System.Drawing.Size(398, 44)
        Me.mtbDni.TabIndex = 1
        '
        'flpNombre
        '
        Me.flpNombre.Controls.Add(Me.Label1)
        Me.flpNombre.Controls.Add(Me.mtbNombre)
        Me.flpNombre.Location = New System.Drawing.Point(3, 202)
        Me.flpNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flpNombre.Name = "flpNombre"
        Me.flpNombre.Size = New System.Drawing.Size(1152, 65)
        Me.flpNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(225, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(358, 38)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nombre"
        '
        'mtbNombre
        '
        Me.mtbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbNombre.Location = New System.Drawing.Point(527, 0)
        Me.mtbNombre.Margin = New System.Windows.Forms.Padding(163, 0, 0, 0)
        Me.mtbNombre.Name = "mtbNombre"
        Me.mtbNombre.Size = New System.Drawing.Size(400, 44)
        Me.mtbNombre.TabIndex = 2
        '
        'flpApellido
        '
        Me.flpApellido.Controls.Add(Me.Label2)
        Me.flpApellido.Controls.Add(Me.mtbApellido)
        Me.flpApellido.Location = New System.Drawing.Point(3, 275)
        Me.flpApellido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flpApellido.Name = "flpApellido"
        Me.flpApellido.Size = New System.Drawing.Size(1024, 52)
        Me.flpApellido.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(225, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(357, 38)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Apellido"
        '
        'mtbApellido
        '
        Me.mtbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbApellido.Location = New System.Drawing.Point(523, 0)
        Me.mtbApellido.Margin = New System.Windows.Forms.Padding(160, 0, 0, 0)
        Me.mtbApellido.Name = "mtbApellido"
        Me.mtbApellido.Size = New System.Drawing.Size(399, 44)
        Me.mtbApellido.TabIndex = 3
        '
        'flpDireccion
        '
        Me.flpDireccion.Controls.Add(Me.Label5)
        Me.flpDireccion.Controls.Add(Me.mtbDireccion)
        Me.flpDireccion.Location = New System.Drawing.Point(3, 348)
        Me.flpDireccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flpDireccion.Name = "flpDireccion"
        Me.flpDireccion.Size = New System.Drawing.Size(1024, 52)
        Me.flpDireccion.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(225, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(379, 38)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Dirección"
        '
        'mtbDireccion
        '
        Me.mtbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbDireccion.Location = New System.Drawing.Point(527, 0)
        Me.mtbDireccion.Margin = New System.Windows.Forms.Padding(142, 0, 0, 0)
        Me.mtbDireccion.Name = "mtbDireccion"
        Me.mtbDireccion.Size = New System.Drawing.Size(400, 44)
        Me.mtbDireccion.TabIndex = 4
        '
        'flpEmail
        '
        Me.flpEmail.Controls.Add(Me.Label4)
        Me.flpEmail.Controls.Add(Me.mtbEmail)
        Me.flpEmail.Location = New System.Drawing.Point(3, 421)
        Me.flpEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flpEmail.Name = "flpEmail"
        Me.flpEmail.Size = New System.Drawing.Size(1152, 65)
        Me.flpEmail.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(225, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(509, 38)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Correo electrónico"
        '
        'mtbEmail
        '
        Me.mtbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbEmail.Location = New System.Drawing.Point(532, 0)
        Me.mtbEmail.Margin = New System.Windows.Forms.Padding(17, 0, 0, 0)
        Me.mtbEmail.Name = "mtbEmail"
        Me.mtbEmail.Size = New System.Drawing.Size(398, 44)
        Me.mtbEmail.TabIndex = 5
        '
        'flpPuesto
        '
        Me.flpPuesto.Controls.Add(Me.Label8)
        Me.flpPuesto.Controls.Add(Me.cbPuesto)
        Me.flpPuesto.Location = New System.Drawing.Point(3, 494)
        Me.flpPuesto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flpPuesto.Name = "flpPuesto"
        Me.flpPuesto.Size = New System.Drawing.Size(1152, 65)
        Me.flpPuesto.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(225, 0, 21, 0)
        Me.Label8.Size = New System.Drawing.Size(518, 38)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Puesto de trabajo"
        '
        'cbPuesto
        '
        Me.cbPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPuesto.FormattingEnabled = True
        Me.cbPuesto.Location = New System.Drawing.Point(527, 4)
        Me.cbPuesto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbPuesto.Name = "cbPuesto"
        Me.cbPuesto.Size = New System.Drawing.Size(400, 45)
        Me.cbPuesto.TabIndex = 6
        '
        'flpTel
        '
        Me.flpTel.Controls.Add(Me.Label3)
        Me.flpTel.Controls.Add(Me.mtbTel)
        Me.flpTel.Location = New System.Drawing.Point(3, 567)
        Me.flpTel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flpTel.Name = "flpTel"
        Me.flpTel.Size = New System.Drawing.Size(1152, 65)
        Me.flpTel.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(225, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(368, 38)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Teléfono"
        '
        'mtbTel
        '
        Me.mtbTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbTel.Location = New System.Drawing.Point(530, 0)
        Me.mtbTel.Margin = New System.Windows.Forms.Padding(156, 0, 0, 0)
        Me.mtbTel.Name = "mtbTel"
        Me.mtbTel.Size = New System.Drawing.Size(393, 44)
        Me.mtbTel.TabIndex = 7
        '
        'flpIdioma
        '
        Me.flpIdioma.Controls.Add(Me.lIdiomas)
        Me.flpIdioma.Controls.Add(Me.cbIdioma)
        Me.flpIdioma.Location = New System.Drawing.Point(3, 640)
        Me.flpIdioma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flpIdioma.Name = "flpIdioma"
        Me.flpIdioma.Size = New System.Drawing.Size(1024, 52)
        Me.flpIdioma.Size = New System.Drawing.Size(1152, 65)
        Me.flpIdioma.TabIndex = 8
        '
        'lIdiomas
        '
        Me.lIdiomas.AutoSize = True
        Me.lIdiomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lIdiomas.ForeColor = System.Drawing.Color.White
        Me.lIdiomas.Location = New System.Drawing.Point(3, 0)
        Me.lIdiomas.Name = "lIdiomas"
        Me.lIdiomas.Padding = New System.Windows.Forms.Padding(225, 0, 0, 0)
        Me.lIdiomas.Size = New System.Drawing.Size(338, 38)
        Me.lIdiomas.TabIndex = 25
        Me.lIdiomas.Text = "Idioma"
        '
        'cbIdioma
        '
        Me.cbIdioma.DataSource = Me.IdiomasBindingSource
        Me.cbIdioma.DisplayMember = "idioma"
        Me.cbIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIdioma.FormattingEnabled = True
        Me.cbIdioma.Location = New System.Drawing.Point(530, 0)
        Me.cbIdioma.Margin = New System.Windows.Forms.Padding(186, 0, 0, 0)
        Me.cbIdioma.Name = "cbIdioma"
        Me.cbIdioma.Size = New System.Drawing.Size(351, 39)
        Me.cbIdioma.Size = New System.Drawing.Size(394, 45)
        Me.cbIdioma.TabIndex = 8
        Me.cbIdioma.ValueMember = "idioma"
        '
        'IdiomasBindingSource
        '
        Me.IdiomasBindingSource.DataMember = "idiomas"
        Me.IdiomasBindingSource.DataSource = Me.Academy_bdDataSet1
        '
        'Academy_bdDataSet1
        '
        Me.Academy_bdDataSet1.DataSetName = "academy_bdDataSet1"
        Me.Academy_bdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'flpPassword
        '
        Me.flpPassword.Controls.Add(Me.Label9)
        Me.flpPassword.Controls.Add(Me.tbPass)
        Me.flpPassword.Location = New System.Drawing.Point(3, 713)
        Me.flpPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flpPassword.Name = "flpPassword"
        Me.flpPassword.Size = New System.Drawing.Size(1024, 52)
        Me.flpPassword.Size = New System.Drawing.Size(1152, 65)
        Me.flpPassword.TabIndex = 9
        Me.flpPassword.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(225, 0, 135, 0)
        Me.Label9.Size = New System.Drawing.Size(522, 38)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Password"
        '
        'tbPass
        '
        Me.tbPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPass.Location = New System.Drawing.Point(531, 4)
        Me.tbPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbPass.MaxLength = 50
        Me.tbPass.Multiline = True
        Me.tbPass.Name = "tbPass"
        Me.tbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPass.TabIndex = 9
        '
        'bDone
        '
        Me.bDone.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDone.Location = New System.Drawing.Point(512, 786)
        Me.bDone.Margin = New System.Windows.Forms.Padding(512, 4, 3, 4)
        Me.bDone.Name = "bDone"
        Me.bDone.Size = New System.Drawing.Size(181, 76)
        Me.bDone.TabIndex = 10
        Me.bDone.Text = "Modificar"
        Me.bDone.UseVisualStyleBackColor = True
        '
        'Academy_bdDataSet
        '
        Me.Academy_bdDataSet.DataSetName = "academy_bdDataSet"
        Me.Academy_bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AcademybdDataSetBindingSource
        '
        Me.AcademybdDataSetBindingSource.DataSource = Me.Academy_bdDataSet
        Me.AcademybdDataSetBindingSource.Position = 0
        '
        'AcademybdDataSetBindingSource1
        '
        Me.AcademybdDataSetBindingSource1.DataSource = Me.Academy_bdDataSet
        Me.AcademybdDataSetBindingSource1.Position = 0
        '
        'IdiomasTableAdapter
        '
        Me.IdiomasTableAdapter.ClearBeforeFill = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "X:\academiaingles\Academy\Academy\bin\Debug\Always idiomas.chm"
        '
        'toolStrip
        '
        Me.toolStrip.BackColor = System.Drawing.Color.Transparent
        Me.toolStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator3, Me.tsbInformacion, Me.ToolStripSeparator1, Me.tsbAYdua})
        Me.toolStrip.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(1168, 39)
        Me.toolStrip.TabIndex = 32
        Me.toolStrip.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.Academy.My.Resources.Resources.arrow_undo
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(105, 36)
        Me.ToolStripButton1.Text = "Volver"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'tsbInformacion
        '
        Me.tsbInformacion.ForeColor = System.Drawing.Color.White
        Me.tsbInformacion.Image = Global.Academy.My.Resources.Resources.book
        Me.tsbInformacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbInformacion.Name = "tsbInformacion"
        Me.tsbInformacion.Size = New System.Drawing.Size(167, 36)
        Me.tsbInformacion.Text = "Información"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbAYdua
        '
        Me.tsbAYdua.ForeColor = System.Drawing.Color.White
        Me.tsbAYdua.Image = Global.Academy.My.Resources.Resources.help
        Me.tsbAYdua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAYdua.Name = "tsbAYdua"
        Me.tsbAYdua.Size = New System.Drawing.Size(106, 36)
        Me.tsbAYdua.Text = "Ayuda"
        '
        'formModify
        '
        Me.AcceptButton = Me.bDone
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.Academy.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(1168, 947)
        Me.ControlBox = False
        Me.Controls.Add(Me.toolStrip)
        Me.Controls.Add(Me.flpPricipal)
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "formModify"
        Me.HelpProvider1.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario"
        Me.flpPricipal.ResumeLayout(False)
        Me.flpDni.ResumeLayout(False)
        Me.flpDni.PerformLayout()
        Me.flpNombre.ResumeLayout(False)
        Me.flpNombre.PerformLayout()
        Me.flpApellido.ResumeLayout(False)
        Me.flpApellido.PerformLayout()
        Me.flpDireccion.ResumeLayout(False)
        Me.flpDireccion.PerformLayout()
        Me.flpEmail.ResumeLayout(False)
        Me.flpEmail.PerformLayout()
        Me.flpPuesto.ResumeLayout(False)
        Me.flpPuesto.PerformLayout()
        Me.flpTel.ResumeLayout(False)
        Me.flpTel.PerformLayout()
        Me.flpIdioma.ResumeLayout(False)
        Me.flpIdioma.PerformLayout()
        CType(Me.IdiomasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Academy_bdDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpPassword.ResumeLayout(False)
        Me.flpPassword.PerformLayout()
        CType(Me.Academy_bdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcademybdDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcademybdDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents flpPricipal As FlowLayoutPanel
    Friend WithEvents flpDni As FlowLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents cbIdioma As ComboBox
    Friend WithEvents bDone As Button
    Friend WithEvents mtbDireccion As MaskedTextBox
    Friend WithEvents mtbEmail As MaskedTextBox
    Friend WithEvents mtbTel As MaskedTextBox
    Friend WithEvents mtbApellido As MaskedTextBox
    Friend WithEvents mtbNombre As MaskedTextBox
    Friend WithEvents lIdiomas As Label
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
    Friend WithEvents Academy_bdDataSet As academy_bdDataSet
    Friend WithEvents AcademybdDataSetBindingSource As BindingSource
    Friend WithEvents AcademybdDataSetBindingSource1 As BindingSource
    Friend WithEvents Academy_bdDataSet1 As academy_bdDataSet1
    Friend WithEvents IdiomasBindingSource As BindingSource
    Friend WithEvents IdiomasTableAdapter As academy_bdDataSet1TableAdapters.idiomasTableAdapter
    Friend WithEvents flpPassword As FlowLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents tbPass As TextBox
    Friend WithEvents cbPuesto As ComboBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents toolStrip As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbInformacion As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbAYdua As ToolStripButton
    Friend WithEvents lblDni As Label
    Friend WithEvents mtbDni As MaskedTextBox
End Class
