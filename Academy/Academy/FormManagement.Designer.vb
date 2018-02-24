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
        Me.bMod = New System.Windows.Forms.Button()
        Me.bDel = New System.Windows.Forms.Button()
        Me.tcModos = New System.Windows.Forms.TabControl()
        Me.tabProfesores = New System.Windows.Forms.TabPage()
        Me.dgvProfesores = New System.Windows.Forms.DataGridView()
        Me.tabAlumnos = New System.Windows.Forms.TabPage()
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.bLogout = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bSpecialTax = New System.Windows.Forms.Button()
        Me.bBono = New System.Windows.Forms.Button()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.toolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.InformeAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbInformacion = New System.Windows.Forms.ToolStripButton()
        Me.tsbAYdua = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.tcModos.SuspendLayout()
        Me.tabProfesores.SuspendLayout()
        CType(Me.dgvProfesores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAlumnos.SuspendLayout()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.toolStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bMod
        '
        Me.bMod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMod.Location = New System.Drawing.Point(15, 139)
        Me.bMod.Name = "bMod"
        Me.bMod.Size = New System.Drawing.Size(237, 35)
        Me.bMod.TabIndex = 4
        Me.bMod.Text = "Modificar"
        Me.bMod.UseVisualStyleBackColor = True
        '
        'bDel
        '
        Me.bDel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDel.Location = New System.Drawing.Point(15, 206)
        Me.bDel.Name = "bDel"
        Me.bDel.Size = New System.Drawing.Size(237, 35)
        Me.bDel.TabIndex = 5
        Me.bDel.Text = "Eliminar"
        Me.bDel.UseVisualStyleBackColor = True
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
        Me.tcModos.Size = New System.Drawing.Size(928, 557)
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
        Me.tabProfesores.Size = New System.Drawing.Size(920, 515)
        Me.tabProfesores.TabIndex = 0
        Me.tabProfesores.Text = "Empleados"
        Me.tabProfesores.UseVisualStyleBackColor = True
        '
        'dgvProfesores
        '
        Me.dgvProfesores.AllowUserToAddRows = False
        Me.dgvProfesores.AllowUserToDeleteRows = False
        Me.dgvProfesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvProfesores.BackgroundColor = System.Drawing.Color.SteelBlue
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
        Me.dgvProfesores.Size = New System.Drawing.Size(914, 511)
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
        Me.tabAlumnos.Size = New System.Drawing.Size(920, 515)
        Me.tabAlumnos.TabIndex = 1
        Me.tabAlumnos.Text = "Alumnos"
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.AllowUserToAddRows = False
        Me.dgvAlumnos.AllowUserToDeleteRows = False
        Me.dgvAlumnos.BackgroundColor = System.Drawing.Color.SteelBlue
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
        Me.dgvAlumnos.Size = New System.Drawing.Size(910, 507)
        Me.dgvAlumnos.TabIndex = 0
        '
        'bLogout
        '
        Me.bLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bLogout.AutoSize = True
        Me.bLogout.Location = New System.Drawing.Point(1097, 29)
        Me.bLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bLogout.Name = "bLogout"
        Me.bLogout.Size = New System.Drawing.Size(103, 27)
        Me.bLogout.TabIndex = 7
        Me.bLogout.Text = "Cerrar sesión"
        Me.bLogout.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 561.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 561.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1209, 561)
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
        Me.Panel1.Location = New System.Drawing.Point(937, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 557)
        Me.Panel1.TabIndex = 7
        '
        'bSpecialTax
        '
        Me.bSpecialTax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSpecialTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSpecialTax.Location = New System.Drawing.Point(15, 338)
        Me.bSpecialTax.Name = "bSpecialTax"
        Me.bSpecialTax.Size = New System.Drawing.Size(237, 35)
        Me.bSpecialTax.TabIndex = 7
        Me.bSpecialTax.Text = "Asignar tarifa especial"
        Me.bSpecialTax.UseVisualStyleBackColor = True
        '
        'bBono
        '
        Me.bBono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bBono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBono.Location = New System.Drawing.Point(15, 270)
        Me.bBono.Name = "bBono"
        Me.bBono.Size = New System.Drawing.Size(237, 35)
        Me.bBono.TabIndex = 6
        Me.bBono.Text = "Asignar bono"
        Me.bBono.UseVisualStyleBackColor = True
        '
        'bAdd
        '
        Me.bAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAdd.Location = New System.Drawing.Point(15, 76)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Size = New System.Drawing.Size(237, 35)
        Me.bAdd.TabIndex = 3
        Me.bAdd.Text = "Añadir"
        Me.bAdd.UseVisualStyleBackColor = True
        '
        'toolStrip
        '
        Me.toolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbInformacion, Me.ToolStripSeparator1, Me.tsbAYdua, Me.ToolStripSeparator2, Me.tsbSalir, Me.ToolStripSeparator3})
        Me.toolStrip.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(1225, 27)
        Me.toolStrip.TabIndex = 17
        Me.toolStrip.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 705)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1225, 26)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformeAlumnosToolStripMenuItem, Me.InformeEmpleadosToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.Academy.My.Resources.Resources.application_view_detail
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(151, 24)
        Me.ToolStripDropDownButton1.Text = "Generar informe"
        '
        'InformeAlumnosToolStripMenuItem
        '
        Me.InformeAlumnosToolStripMenuItem.Image = Global.Academy.My.Resources.Resources.medal_gold_2
        Me.InformeAlumnosToolStripMenuItem.Name = "InformeAlumnosToolStripMenuItem"
        Me.InformeAlumnosToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.InformeAlumnosToolStripMenuItem.Text = "Informe Alumnos"
        '
        'InformeEmpleadosToolStripMenuItem
        '
        Me.InformeEmpleadosToolStripMenuItem.Image = Global.Academy.My.Resources.Resources.award_star_gold_2
        Me.InformeEmpleadosToolStripMenuItem.Name = "InformeEmpleadosToolStripMenuItem"
        Me.InformeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.InformeEmpleadosToolStripMenuItem.Text = "Informe empleados"
        '
        'tsbInformacion
        '
        Me.tsbInformacion.Image = Global.Academy.My.Resources.Resources.book
        Me.tsbInformacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbInformacion.Name = "tsbInformacion"
        Me.tsbInformacion.Size = New System.Drawing.Size(113, 24)
        Me.tsbInformacion.Text = "Información"
        '
        'tsbAYdua
        '
        Me.tsbAYdua.Image = Global.Academy.My.Resources.Resources.help
        Me.tsbAYdua.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAYdua.Name = "tsbAYdua"
        Me.tsbAYdua.Size = New System.Drawing.Size(75, 24)
        Me.tsbAYdua.Text = "Ayuda"
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = Global.Academy.My.Resources.Resources.door_out
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(62, 24)
        Me.tsbSalir.Text = "Salir"
        '
        'FormManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1225, 731)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.toolStrip)
        Me.Controls.Add(Me.bLogout)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel de gestión"
        Me.tcModos.ResumeLayout(False)
        Me.tabProfesores.ResumeLayout(False)
        CType(Me.dgvProfesores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAlumnos.ResumeLayout(False)
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bMod As Button
    Friend WithEvents bDel As Button
    Friend WithEvents tcModos As TabControl
    Friend WithEvents tabProfesores As TabPage
    Friend WithEvents tabAlumnos As TabPage
    Friend WithEvents dgvProfesores As DataGridView
    Friend WithEvents dgvAlumnos As DataGridView
    Friend WithEvents bLogout As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bAdd As Button
    Friend WithEvents bBono As Button
    Friend WithEvents bSpecialTax As Button
    Friend WithEvents toolStrip As ToolStrip
    Friend WithEvents tsbInformacion As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbAYdua As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents InformeAlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeEmpleadosToolStripMenuItem As ToolStripMenuItem
End Class
