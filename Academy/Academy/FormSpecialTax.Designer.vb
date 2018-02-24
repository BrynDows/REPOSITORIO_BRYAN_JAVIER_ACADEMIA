<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSpecialTax
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTitu = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbExamen = New System.Windows.Forms.RadioButton()
        Me.rbPrepa = New System.Windows.Forms.RadioButton()
        Me.lPrice = New System.Windows.Forms.Label()
        Me.bDone = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lTitle
        '
        Me.lTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lTitle.AutoSize = True
        Me.lTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitle.Location = New System.Drawing.Point(89, 38)
        Me.lTitle.Name = "lTitle"
        Me.lTitle.Size = New System.Drawing.Size(356, 37)
        Me.lTitle.TabIndex = 1
        Me.lTitle.Text = "Asignar tarifa especial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Titulación:"
        '
        'cbTitu
        '
        Me.cbTitu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTitu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTitu.FormattingEnabled = True
        Me.cbTitu.Items.AddRange(New Object() {"TOEIC", "DIPLOMAS ALWAYS (idiomas comunes)", "DIPLOMAS ALWAYS (otros idiomas)", "APTIS/FIRST/CAE/PROFICENCY"})
        Me.cbTitu.Location = New System.Drawing.Point(208, 125)
        Me.cbTitu.Name = "cbTitu"
        Me.cbTitu.Size = New System.Drawing.Size(273, 28)
        Me.cbTitu.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbExamen)
        Me.Panel1.Controls.Add(Me.rbPrepa)
        Me.Panel1.Location = New System.Drawing.Point(61, 208)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 60)
        Me.Panel1.TabIndex = 4
        '
        'rbExamen
        '
        Me.rbExamen.AutoSize = True
        Me.rbExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExamen.Location = New System.Drawing.Point(252, 15)
        Me.rbExamen.Name = "rbExamen"
        Me.rbExamen.Size = New System.Drawing.Size(125, 33)
        Me.rbExamen.TabIndex = 1
        Me.rbExamen.Text = "Examen"
        Me.rbExamen.UseVisualStyleBackColor = True
        '
        'rbPrepa
        '
        Me.rbPrepa.AutoSize = True
        Me.rbPrepa.Checked = True
        Me.rbPrepa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrepa.Location = New System.Drawing.Point(3, 15)
        Me.rbPrepa.Name = "rbPrepa"
        Me.rbPrepa.Size = New System.Drawing.Size(169, 33)
        Me.rbPrepa.TabIndex = 0
        Me.rbPrepa.TabStop = True
        Me.rbPrepa.Text = "Preparación"
        Me.rbPrepa.UseVisualStyleBackColor = True
        '
        'lPrice
        '
        Me.lPrice.AutoSize = True
        Me.lPrice.Font = New System.Drawing.Font("Forte", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPrice.Location = New System.Drawing.Point(393, 335)
        Me.lPrice.Name = "lPrice"
        Me.lPrice.Size = New System.Drawing.Size(79, 44)
        Me.lPrice.TabIndex = 12
        Me.lPrice.Text = "0 €"
        '
        'bDone
        '
        Me.bDone.AutoSize = True
        Me.bDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDone.Location = New System.Drawing.Point(65, 334)
        Me.bDone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bDone.Name = "bDone"
        Me.bDone.Size = New System.Drawing.Size(137, 51)
        Me.bDone.TabIndex = 11
        Me.bDone.Text = "Asignar"
        Me.bDone.UseVisualStyleBackColor = True
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "X:\academiaingles\Academy\Academy\bin\Debug\Always idiomas.chm"
        '
        'FormSpecialTax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(548, 414)
        Me.Controls.Add(Me.lPrice)
        Me.Controls.Add(Me.bDone)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbTitu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lTitle)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "FormSpecialTax"
        Me.Text = "Asignar tarifa especial"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbTitu As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbExamen As RadioButton
    Friend WithEvents rbPrepa As RadioButton
    Friend WithEvents lPrice As Label
    Friend WithEvents bDone As Button
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
