<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormManagement
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
        Me.tcModos = New System.Windows.Forms.TabControl()
        Me.tabProfesores = New System.Windows.Forms.TabPage()
        Me.dgvProfesores = New System.Windows.Forms.DataGridView()
        Me.tabAlumnos = New System.Windows.Forms.TabPage()
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bSpecialTax = New System.Windows.Forms.Button()
        Me.bBono = New System.Windows.Forms.Button()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.bDel = New System.Windows.Forms.Button()
        Me.bMod = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.InformeAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.toolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbInformacion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAYdua = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tcModos.SuspendLayout()
        Me.tabProfesores.SuspendLayout()
        CType(Me.dgvProfesores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAlumnos.SuspendLayout()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.toolStrip.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcModos
        '
        Me.tcModos.Controls.Add(Me.tabProfesores)
        Me.tcModos.Controls.Add(Me.tabAlumnos)
        Me.tcModos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcModos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcModos.Location = New System.Drawing.Point(3, 2)
        Me.tcModos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tcModos.Name = "tcModos"
        Me.tcModos.SelectedIndex = 0
        Me.tcModos.Size = New System.Drawing.Size(784, 555)
        Me.tcModos.TabIndex = 6
        Me.tcModos.Tag = ""
        '
        'tabProfesores
        '
        Me.tabProfesores.Controls.Add(Me.dgvProfesores)
        Me.tabProfesores.Location = New System.Drawing.Point(4, 38)
        Me.tabProfesores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabProfesores.Name = "tabProfesores"
        Me.tabProfesores.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabProfesores.Size = New System.Drawing.Size(776, 513)
        Me.tabProfesores.TabIndex = 0
        Me.tabProfesores.Text = "Empleados"
        Me.tabProfesores.UseVisualStyleBackColor = True
        '
        'dgvProfesores
        '
        Me.dgvProfesores.AllowUserToAddRows = False
        Me.dgvProfesores.AllowUserToDeleteRows = False
        Me.dgvProfesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvProfesores.BackgroundColor = System.Drawing.Color.White
        Me.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProfesores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProfesores.GridColor = System.Drawing.Color.SteelBlue
        Me.dgvProfesores.Location = New System.Drawing.Point(3, 2)
        Me.dgvProfesores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvProfesores.MultiSelect = False
        Me.dgvProfesores.Name = "dgvProfesores"
        Me.dgvProfesores.ReadOnly = True
        Me.dgvProfesores.RowHeadersWidth = 50
        Me.dgvProfesores.RowTemplate.Height = 28
        Me.dgvProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProfesores.ShowEditingIcon = False
        Me.dgvProfesores.Size = New System.Drawing.Size(770, 509)
        Me.dgvProfesores.TabIndex = 0
        '
        'tabAlumnos
        '
        Me.tabAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabAlumnos.Controls.Add(Me.dgvAlumnos)
        Me.tabAlumnos.Location = New System.Drawing.Point(4, 38)
        Me.tabAlumnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabAlumnos.Name = "tabAlumnos"
        Me.tabAlumnos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabAlumnos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabAlumnos.Size = New System.Drawing.Size(776, 513)
        Me.tabAlumnos.TabIndex = 1
        Me.tabAlumnos.Text = "Alumnos"
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.AllowUserToAddRows = False
        Me.dgvAlumnos.AllowUserToDeleteRows = False
        Me.dgvAlumnos.BackgroundColor = System.Drawing.Color.White
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAlumnos.Location = New System.Drawing.Point(3, 2)
        Me.dgvAlumnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvAlumnos.MultiSelect = False
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.ReadOnly = True
        Me.dgvAlumnos.RowHeadersWidth = 50
        Me.dgvAlumnos.RowTemplate.Height = 28
        Me.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlumnos.ShowEditingIcon = False
        Me.dgvAlumnos.Size = New System.Drawing.Size(766, 505)
        Me.dgvAlumnos.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.27941!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72059!))
        Me.TableLayoutPanel1.Controls.Add(Me.tcModos, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 63)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 559.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 559.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1023, 559)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bSpecialTax)
        Me.Panel1.Controls.Add(Me.bBono)
        Me.Panel1.Controls.Add(Me.bAdd)
        Me.Panel1.Controls.Add(Me.bDel)
        Me.Panel1.Controls.Add(Me.bMod)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(793, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 555)
        Me.Panel1.TabIndex = 7
        '
        'bSpecialTax
        '
        Me.bSpecialTax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSpecialTax.BackColor = System.Drawing.Color.White
        Me.bSpecialTax.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bSpecialTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSpecialTax.Location = New System.Drawing.Point(15, 402)
        Me.bSpecialTax.Name = "bSpecialTax"
        Me.bSpecialTax.Size = New System.Drawing.Size(195, 72)
        Me.bSpecialTax.TabIndex = 7
        Me.bSpecialTax.Text = "Asignar tarifa especial"
        Me.bSpecialTax.UseVisualStyleBackColor = False
        '
        'bBono
        '
        Me.bBono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bBono.BackColor = System.Drawing.Color.White
        Me.bBono.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bBono.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBono.Location = New System.Drawing.Point(15, 324)
        Me.bBono.Name = "bBono"
        Me.bBono.Size = New System.Drawing.Size(195, 72)
        Me.bBono.TabIndex = 6
        Me.bBono.Text = "Asignar bono"
        Me.bBono.UseVisualStyleBackColor = False
        '
        'bAdd
        '
        Me.bAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAdd.BackColor = System.Drawing.Color.White
        Me.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAdd.Location = New System.Drawing.Point(15, 90)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Size = New System.Drawing.Size(195, 72)
        Me.bAdd.TabIndex = 3
        Me.bAdd.Text = "Añadir"
        Me.bAdd.UseVisualStyleBackColor = False
        '
        'bDel
        '
        Me.bDel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bDel.BackColor = System.Drawing.Color.White
        Me.bDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDel.Location = New System.Drawing.Point(15, 246)
        Me.bDel.Name = "bDel"
        Me.bDel.Size = New System.Drawing.Size(195, 72)
        Me.bDel.TabIndex = 5
        Me.bDel.Text = "Eliminar"
        Me.bDel.UseVisualStyleBackColor = False
        '
        'bMod
        '
        Me.bMod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMod.BackColor = System.Drawing.Color.White
        Me.bMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMod.Location = New System.Drawing.Point(15, 168)
        Me.bMod.Name = "bMod"
        Me.bMod.Size = New System.Drawing.Size(195, 72)
        Me.bMod.TabIndex = 4
        Me.bMod.Text = "Modificar"
        Me.bMod.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 698)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1039, 31)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformeAlumnosToolStripMenuItem, Me.InformeEmpleadosToolStripMenuItem})
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton1.Image = Global.Academy.My.Resources.Resources.application_view_detail
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(185, 29)
        Me.ToolStripDropDownButton1.Text = "Generar informe"
        '
        'InformeAlumnosToolStripMenuItem
        '
        Me.InformeAlumnosToolStripMenuItem.Image = Global.Academy.My.Resources.Resources.medal_gold_2
        Me.InformeAlumnosToolStripMenuItem.Name = "InformeAlumnosToolStripMenuItem"
        Me.InformeAlumnosToolStripMenuItem.Size = New System.Drawing.Size(253, 30)
        Me.InformeAlumnosToolStripMenuItem.Text = "Informe Alumnos"
        '
        'InformeEmpleadosToolStripMenuItem
        '
        Me.InformeEmpleadosToolStripMenuItem.Image = Global.Academy.My.Resources.Resources.award_star_gold_2
        Me.InformeEmpleadosToolStripMenuItem.Name = "InformeEmpleadosToolStripMenuItem"
        Me.InformeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(253, 30)
        Me.InformeEmpleadosToolStripMenuItem.Text = "Informe empleados"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "ayuda.chm"
        '
        'toolStrip
        '
        Me.toolStrip.BackColor = System.Drawing.Color.Transparent
        Me.toolStrip.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator3, Me.tsbInformacion, Me.ToolStripSeparator1, Me.tsbAYdua})
        Me.toolStrip.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(1039, 32)
        Me.toolStrip.TabIndex = 23
        Me.toolStrip.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'tsbInformacion
        '
        Me.tsbInformacion.ForeColor = System.Drawing.Color.White
        Me.tsbInformacion.Image = Global.Academy.My.Resources.Resources.book
        Me.tsbInformacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbInformacion.Name = "tsbInformacion"
        Me.tsbInformacion.Size = New System.Drawing.Size(138, 29)
        Me.tsbInformacion.Text = "Información"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'tsbAYdua
        '
        Me.tsbAYdua.ForeColor = System.Drawing.Color.White
        Me.tsbAYdua.Image = Global.Academy.My.Resources.Resources.help
        Me.tsbAYdua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAYdua.Name = "tsbAYdua"
        Me.tsbAYdua.Size = New System.Drawing.Size(89, 29)
        Me.tsbAYdua.Text = "Ayuda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Bienvenido "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = ", Que tenga un buen día."
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblUser)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(461, 653)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(553, 29)
        Me.FlowLayoutPanel1.TabIndex = 26
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(91, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(36, 17)
        Me.lblUser.TabIndex = 26
        Me.lblUser.Text = "user"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.Academy.My.Resources.Resources.arrow_undo
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(217, 29)
        Me.ToolStripButton1.Text = "Cerrar sesión y volver"
        '
        'FormManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.Academy.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(1039, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.toolStrip)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.HelpButton = True
        Me.Name = "FormManagement"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel de gestión"
        Me.tcModos.ResumeLayout(False)
        Me.tabProfesores.ResumeLayout(False)
        CType(Me.dgvProfesores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAlumnos.ResumeLayout(False)
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcModos As TabControl
    Friend WithEvents tabProfesores As TabPage
    Friend WithEvents tabAlumnos As TabPage
    Friend WithEvents dgvProfesores As DataGridView
    Friend WithEvents dgvAlumnos As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents InformeAlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bSpecialTax As Button
    Friend WithEvents bBono As Button
    Friend WithEvents bAdd As Button
    Friend WithEvents bDel As Button
    Friend WithEvents bMod As Button
    Friend WithEvents toolStrip As ToolStrip
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbInformacion As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbAYdua As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblUser As Label
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
