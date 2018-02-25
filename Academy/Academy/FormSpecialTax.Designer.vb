<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSpecialTax
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
        Me.lTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTitu = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbExamen = New System.Windows.Forms.RadioButton()
        Me.rbPrepa = New System.Windows.Forms.RadioButton()
        Me.lPrice = New System.Windows.Forms.Label()
        Me.bDone = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.toolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbInformacion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAYdua = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.toolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lTitle
        '
        Me.lTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lTitle.AutoSize = True
        Me.lTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitle.Location = New System.Drawing.Point(3, 0)
        Me.lTitle.Name = "lTitle"
        Me.lTitle.Padding = New System.Windows.Forms.Padding(90, 50, 0, 0)
        Me.lTitle.Size = New System.Drawing.Size(529, 81)
        Me.lTitle.TabIndex = 1
        Me.lTitle.Text = "Asignar tarifa especial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Titulación:"
        '
        'cbTitu
        '
        Me.cbTitu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTitu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbTitu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTitu.FormattingEnabled = True
        Me.cbTitu.Items.AddRange(New Object() {"TOEIC", "DIPLOMAS ALWAYS (idiomas comunes)", "DIPLOMAS ALWAYS (otros idiomas)", "APTIS/FIRST/CAE/PROFICENCY"})
        Me.cbTitu.Location = New System.Drawing.Point(153, 32)
        Me.cbTitu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbTitu.Name = "cbTitu"
        Me.cbTitu.Size = New System.Drawing.Size(243, 37)
        Me.cbTitu.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbExamen)
        Me.Panel1.Controls.Add(Me.rbPrepa)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 220)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(529, 76)
        Me.Panel1.TabIndex = 4
        '
        'rbExamen
        '
        Me.rbExamen.AutoSize = True
        Me.rbExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExamen.Location = New System.Drawing.Point(291, 12)
        Me.rbExamen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbExamen.Name = "rbExamen"
        Me.rbExamen.Size = New System.Drawing.Size(121, 33)
        Me.rbExamen.TabIndex = 1
        Me.rbExamen.Text = "Examen"
        Me.rbExamen.UseVisualStyleBackColor = True
        '
        'rbPrepa
        '
        Me.rbPrepa.AutoSize = True
        Me.rbPrepa.Checked = True
        Me.rbPrepa.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrepa.Location = New System.Drawing.Point(42, 12)
        Me.rbPrepa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbPrepa.Name = "rbPrepa"
        Me.rbPrepa.Size = New System.Drawing.Size(165, 33)
        Me.rbPrepa.TabIndex = 0
        Me.rbPrepa.TabStop = True
        Me.rbPrepa.Text = "Preparación"
        Me.rbPrepa.UseVisualStyleBackColor = True
        '
        'lPrice
        '
        Me.lPrice.AutoSize = True
        Me.lPrice.Font = New System.Drawing.Font("Forte", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPrice.Location = New System.Drawing.Point(391, 26)
        Me.lPrice.Name = "lPrice"
        Me.lPrice.Size = New System.Drawing.Size(67, 37)
        Me.lPrice.TabIndex = 12
        Me.lPrice.Text = "0 €"
        '
        'bDone
        '
        Me.bDone.AutoSize = True
        Me.bDone.BackColor = System.Drawing.Color.White
        Me.bDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDone.Location = New System.Drawing.Point(172, 2)
        Me.bDone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bDone.Name = "bDone"
        Me.bDone.Size = New System.Drawing.Size(122, 59)
        Me.bDone.TabIndex = 11
        Me.bDone.Text = "Asignar"
        Me.bDone.UseVisualStyleBackColor = False
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "X:\academiaingles\Academy\Academy\bin\Debug\Always idiomas.chm"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lTitle, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(535, 393)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.cbTitu)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 112)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(20, 30, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(529, 103)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.bDone)
        Me.Panel2.Controls.Add(Me.lPrice)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 301)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(529, 68)
        Me.Panel2.TabIndex = 5
        '
        'toolStrip
        '
        Me.toolStrip.BackColor = System.Drawing.Color.Transparent
        Me.toolStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator3, Me.tsbInformacion, Me.ToolStripSeparator1, Me.tsbAYdua})
        Me.toolStrip.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(535, 35)
        Me.toolStrip.TabIndex = 33
        Me.toolStrip.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.Academy.My.Resources.Resources.arrow_undo
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(91, 32)
        Me.ToolStripButton1.Text = "Volver"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 35)
        '
        'tsbInformacion
        '
        Me.tsbInformacion.ForeColor = System.Drawing.Color.White
        Me.tsbInformacion.Image = Global.Academy.My.Resources.Resources.book
        Me.tsbInformacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbInformacion.Name = "tsbInformacion"
        Me.tsbInformacion.Size = New System.Drawing.Size(141, 32)
        Me.tsbInformacion.Text = "Información"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 35)
        '
        'tsbAYdua
        '
        Me.tsbAYdua.ForeColor = System.Drawing.Color.White
        Me.tsbAYdua.Image = Global.Academy.My.Resources.Resources.help
        Me.tsbAYdua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAYdua.Name = "tsbAYdua"
        Me.tsbAYdua.Size = New System.Drawing.Size(92, 32)
        Me.tsbAYdua.Text = "Ayuda"
        '
        'FormSpecialTax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.Academy.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(535, 393)
        Me.ControlBox = False
        Me.Controls.Add(Me.toolStrip)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FormSpecialTax"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifa especial"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents toolStrip As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbInformacion As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbAYdua As ToolStripButton
End Class
