<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBonos
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
        Me.lTitle = New System.Windows.Forms.Label()
        Me.gbSeason = New System.Windows.Forms.GroupBox()
        Me.rbVerano = New System.Windows.Forms.RadioButton()
        Me.rbInvierno = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbSkype = New System.Windows.Forms.RadioButton()
        Me.rbPresencial = New System.Windows.Forms.RadioButton()
        Me.gbLugar = New System.Windows.Forms.GroupBox()
        Me.rbDomi = New System.Windows.Forms.RadioButton()
        Me.rbEscuela = New System.Windows.Forms.RadioButton()
        Me.nudHoras = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudPersonas = New System.Windows.Forms.NumericUpDown()
        Me.bDone = New System.Windows.Forms.Button()
        Me.lPrice = New System.Windows.Forms.Label()
        Me.toolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsbInformacion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAYdua = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.gbSeason.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbLugar.SuspendLayout()
        CType(Me.nudHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lTitle
        '
        Me.lTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitle.Location = New System.Drawing.Point(42, 23)
        Me.lTitle.Name = "lTitle"
        Me.lTitle.Size = New System.Drawing.Size(543, 63)
        Me.lTitle.TabIndex = 0
        Me.lTitle.Text = "Asignar bono al alumno"
        '
        'gbSeason
        '
        Me.gbSeason.Controls.Add(Me.rbVerano)
        Me.gbSeason.Controls.Add(Me.rbInvierno)
        Me.gbSeason.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSeason.Location = New System.Drawing.Point(97, 96)
        Me.gbSeason.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbSeason.Name = "gbSeason"
        Me.gbSeason.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbSeason.Size = New System.Drawing.Size(165, 106)
        Me.gbSeason.TabIndex = 2
        Me.gbSeason.TabStop = False
        Me.gbSeason.Text = "Época"
        '
        'rbVerano
        '
        Me.rbVerano.AutoSize = True
        Me.rbVerano.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVerano.Location = New System.Drawing.Point(17, 68)
        Me.rbVerano.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbVerano.Name = "rbVerano"
        Me.rbVerano.Size = New System.Drawing.Size(111, 33)
        Me.rbVerano.TabIndex = 1
        Me.rbVerano.Text = "Verano"
        Me.rbVerano.UseVisualStyleBackColor = True
        '
        'rbInvierno
        '
        Me.rbInvierno.AutoSize = True
        Me.rbInvierno.Checked = True
        Me.rbInvierno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbInvierno.Location = New System.Drawing.Point(17, 34)
        Me.rbInvierno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbInvierno.Name = "rbInvierno"
        Me.rbInvierno.Size = New System.Drawing.Size(119, 33)
        Me.rbInvierno.TabIndex = 0
        Me.rbInvierno.TabStop = True
        Me.rbInvierno.Text = "Invierno"
        Me.rbInvierno.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbSkype)
        Me.Panel1.Controls.Add(Me.rbPresencial)
        Me.Panel1.Location = New System.Drawing.Point(336, 108)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 94)
        Me.Panel1.TabIndex = 3
        '
        'rbSkype
        '
        Me.rbSkype.AutoSize = True
        Me.rbSkype.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSkype.Location = New System.Drawing.Point(3, 56)
        Me.rbSkype.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbSkype.Name = "rbSkype"
        Me.rbSkype.Size = New System.Drawing.Size(150, 33)
        Me.rbSkype.TabIndex = 2
        Me.rbSkype.Text = "A distancia"
        Me.rbSkype.UseVisualStyleBackColor = True
        '
        'rbPresencial
        '
        Me.rbPresencial.AutoSize = True
        Me.rbPresencial.Checked = True
        Me.rbPresencial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPresencial.Location = New System.Drawing.Point(3, 22)
        Me.rbPresencial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbPresencial.Name = "rbPresencial"
        Me.rbPresencial.Size = New System.Drawing.Size(148, 33)
        Me.rbPresencial.TabIndex = 0
        Me.rbPresencial.TabStop = True
        Me.rbPresencial.Text = "Presencial"
        Me.rbPresencial.UseVisualStyleBackColor = True
        '
        'gbLugar
        '
        Me.gbLugar.Controls.Add(Me.rbDomi)
        Me.gbLugar.Controls.Add(Me.rbEscuela)
        Me.gbLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLugar.Location = New System.Drawing.Point(106, 249)
        Me.gbLugar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbLugar.Name = "gbLugar"
        Me.gbLugar.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbLugar.Size = New System.Drawing.Size(165, 106)
        Me.gbLugar.TabIndex = 4
        Me.gbLugar.TabStop = False
        Me.gbLugar.Text = "Lugar"
        '
        'rbDomi
        '
        Me.rbDomi.AutoSize = True
        Me.rbDomi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDomi.Location = New System.Drawing.Point(17, 68)
        Me.rbDomi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbDomi.Name = "rbDomi"
        Me.rbDomi.Size = New System.Drawing.Size(135, 33)
        Me.rbDomi.TabIndex = 1
        Me.rbDomi.Text = "Domicilio"
        Me.rbDomi.UseVisualStyleBackColor = True
        '
        'rbEscuela
        '
        Me.rbEscuela.AutoSize = True
        Me.rbEscuela.Checked = True
        Me.rbEscuela.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEscuela.Location = New System.Drawing.Point(17, 34)
        Me.rbEscuela.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbEscuela.Name = "rbEscuela"
        Me.rbEscuela.Size = New System.Drawing.Size(120, 33)
        Me.rbEscuela.TabIndex = 0
        Me.rbEscuela.TabStop = True
        Me.rbEscuela.Text = "Escuela"
        Me.rbEscuela.UseVisualStyleBackColor = True
        '
        'nudHoras
        '
        Me.nudHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHoras.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudHoras.Location = New System.Drawing.Point(515, 262)
        Me.nudHoras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudHoras.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudHoras.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudHoras.Name = "nudHoras"
        Me.nudHoras.Size = New System.Drawing.Size(70, 30)
        Me.nudHoras.TabIndex = 5
        Me.nudHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudHoras.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Número de horas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(372, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Personas:"
        '
        'nudPersonas
        '
        Me.nudPersonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPersonas.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudPersonas.Location = New System.Drawing.Point(515, 319)
        Me.nudPersonas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudPersonas.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudPersonas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPersonas.Name = "nudPersonas"
        Me.nudPersonas.Size = New System.Drawing.Size(70, 30)
        Me.nudPersonas.TabIndex = 7
        Me.nudPersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudPersonas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'bDone
        '
        Me.bDone.AutoSize = True
        Me.bDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDone.Location = New System.Drawing.Point(106, 442)
        Me.bDone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bDone.Name = "bDone"
        Me.bDone.Size = New System.Drawing.Size(122, 41)
        Me.bDone.TabIndex = 9
        Me.bDone.Text = "Asignar"
        Me.bDone.UseVisualStyleBackColor = True
        '
        'lPrice
        '
        Me.lPrice.AutoSize = True
        Me.lPrice.Font = New System.Drawing.Font("Forte", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPrice.Location = New System.Drawing.Point(490, 442)
        Me.lPrice.Name = "lPrice"
        Me.lPrice.Size = New System.Drawing.Size(67, 37)
        Me.lPrice.TabIndex = 10
        Me.lPrice.Text = "0 €"
        '
        'toolStrip
        '
        Me.toolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbInformacion, Me.ToolStripSeparator1, Me.tsbAYdua, Me.ToolStripSeparator2, Me.tsbSalir})
        Me.toolStrip.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(629, 27)
        Me.toolStrip.TabIndex = 17
        Me.toolStrip.Text = "ToolStrip1"
        '
        'tsbInformacion
        '
        Me.tsbInformacion.Image = Global.Academy.My.Resources.Resources.book
        Me.tsbInformacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbInformacion.Name = "tsbInformacion"
        Me.tsbInformacion.Size = New System.Drawing.Size(113, 24)
        Me.tsbInformacion.Text = "Información"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tsbAYdua
        '
        Me.tsbAYdua.Image = Global.Academy.My.Resources.Resources.help
        Me.tsbAYdua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAYdua.Name = "tsbAYdua"
        Me.tsbAYdua.Size = New System.Drawing.Size(75, 24)
        Me.tsbAYdua.Text = "Ayuda"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = Global.Academy.My.Resources.Resources.door_out
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(62, 24)
        Me.tsbSalir.Text = "Salir"
        '
        'FormBonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(629, 527)
        Me.Controls.Add(Me.toolStrip)
        Me.Controls.Add(Me.lPrice)
        Me.Controls.Add(Me.bDone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudPersonas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudHoras)
        Me.Controls.Add(Me.gbLugar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbSeason)
        Me.Controls.Add(Me.lTitle)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FormBonos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar bono"
        Me.gbSeason.ResumeLayout(False)
        Me.gbSeason.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbLugar.ResumeLayout(False)
        Me.gbLugar.PerformLayout()
        CType(Me.nudHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lTitle As Label
    Friend WithEvents gbSeason As GroupBox
    Friend WithEvents rbVerano As RadioButton
    Friend WithEvents rbInvierno As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbSkype As RadioButton
    Friend WithEvents rbPresencial As RadioButton
    Friend WithEvents gbLugar As GroupBox
    Friend WithEvents rbDomi As RadioButton
    Friend WithEvents rbEscuela As RadioButton
    Friend WithEvents nudHoras As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudPersonas As NumericUpDown
    Friend WithEvents bDone As Button
    Friend WithEvents lPrice As Label
    Friend WithEvents toolStrip As ToolStrip
    Friend WithEvents tsbInformacion As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbAYdua As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
End Class
