<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManagement
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
        Me.bAdd = New System.Windows.Forms.Button()
        Me.bMod = New System.Windows.Forms.Button()
        Me.bDel = New System.Windows.Forms.Button()
        Me.tcModos = New System.Windows.Forms.TabControl()
        Me.tabProfesores = New System.Windows.Forms.TabPage()
        Me.dgvProfesores = New System.Windows.Forms.DataGridView()
        Me.tabAlumnos = New System.Windows.Forms.TabPage()
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.bLogout = New System.Windows.Forms.Button()
        Me.tcModos.SuspendLayout()
        Me.tabProfesores.SuspendLayout()
        CType(Me.dgvProfesores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAlumnos.SuspendLayout()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bAdd
        '
        Me.bAdd.AutoSize = True
        Me.bAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAdd.Location = New System.Drawing.Point(872, 176)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Size = New System.Drawing.Size(108, 35)
        Me.bAdd.TabIndex = 3
        Me.bAdd.Text = "Añadir"
        Me.bAdd.UseVisualStyleBackColor = True
        '
        'bMod
        '
        Me.bMod.AutoSize = True
        Me.bMod.Enabled = False
        Me.bMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMod.Location = New System.Drawing.Point(872, 228)
        Me.bMod.Name = "bMod"
        Me.bMod.Size = New System.Drawing.Size(108, 35)
        Me.bMod.TabIndex = 4
        Me.bMod.Text = "Modificar"
        Me.bMod.UseVisualStyleBackColor = True
        '
        'bDel
        '
        Me.bDel.AutoSize = True
        Me.bDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDel.Location = New System.Drawing.Point(872, 282)
        Me.bDel.Name = "bDel"
        Me.bDel.Size = New System.Drawing.Size(108, 35)
        Me.bDel.TabIndex = 5
        Me.bDel.Text = "Eliminar"
        Me.bDel.UseVisualStyleBackColor = True
        '
        'tcModos
        '
        Me.tcModos.Controls.Add(Me.tabProfesores)
        Me.tcModos.Controls.Add(Me.tabAlumnos)
        Me.tcModos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcModos.Location = New System.Drawing.Point(116, 90)
        Me.tcModos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tcModos.Name = "tcModos"
        Me.tcModos.SelectedIndex = 0
        Me.tcModos.Size = New System.Drawing.Size(698, 512)
        Me.tcModos.TabIndex = 6
        '
        'tabProfesores
        '
        Me.tabProfesores.Controls.Add(Me.dgvProfesores)
        Me.tabProfesores.Location = New System.Drawing.Point(4, 38)
        Me.tabProfesores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabProfesores.Name = "tabProfesores"
        Me.tabProfesores.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabProfesores.Size = New System.Drawing.Size(690, 470)
        Me.tabProfesores.TabIndex = 0
        Me.tabProfesores.Text = "Profesores"
        Me.tabProfesores.UseVisualStyleBackColor = True
        '
        'dgvProfesores
        '
        Me.dgvProfesores.AllowUserToAddRows = False
        Me.dgvProfesores.AllowUserToDeleteRows = False
        Me.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProfesores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProfesores.Location = New System.Drawing.Point(3, 2)
        Me.dgvProfesores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvProfesores.Name = "dgvProfesores"
        Me.dgvProfesores.ReadOnly = True
        Me.dgvProfesores.RowTemplate.Height = 28
        Me.dgvProfesores.Size = New System.Drawing.Size(684, 466)
        Me.dgvProfesores.TabIndex = 0
        '
        'tabAlumnos
        '
        Me.tabAlumnos.Controls.Add(Me.dgvAlumnos)
        Me.tabAlumnos.Location = New System.Drawing.Point(4, 38)
        Me.tabAlumnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabAlumnos.Name = "tabAlumnos"
        Me.tabAlumnos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabAlumnos.Size = New System.Drawing.Size(690, 470)
        Me.tabAlumnos.TabIndex = 1
        Me.tabAlumnos.Text = "Alumnos"
        Me.tabAlumnos.UseVisualStyleBackColor = True
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.AllowUserToAddRows = False
        Me.dgvAlumnos.AllowUserToDeleteRows = False
        Me.dgvAlumnos.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAlumnos.Location = New System.Drawing.Point(3, 2)
        Me.dgvAlumnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.ReadOnly = True
        Me.dgvAlumnos.RowTemplate.Height = 28
        Me.dgvAlumnos.Size = New System.Drawing.Size(684, 466)
        Me.dgvAlumnos.TabIndex = 0
        '
        'bLogout
        '
        Me.bLogout.AutoSize = True
        Me.bLogout.Location = New System.Drawing.Point(928, 10)
        Me.bLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bLogout.Name = "bLogout"
        Me.bLogout.Size = New System.Drawing.Size(103, 27)
        Me.bLogout.TabIndex = 7
        Me.bLogout.Text = "Cerrar sesión"
        Me.bLogout.UseVisualStyleBackColor = True
        '
        'FormManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1039, 729)
        Me.Controls.Add(Me.bLogout)
        Me.Controls.Add(Me.tcModos)
        Me.Controls.Add(Me.bDel)
        Me.Controls.Add(Me.bMod)
        Me.Controls.Add(Me.bAdd)
        Me.Name = "FormManagement"
        Me.Text = "FormManagement"
        Me.tcModos.ResumeLayout(False)
        Me.tabProfesores.ResumeLayout(False)
        CType(Me.dgvProfesores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAlumnos.ResumeLayout(False)
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bAdd As Button
    Friend WithEvents bMod As Button
    Friend WithEvents bDel As Button
    Friend WithEvents tcModos As TabControl
    Friend WithEvents tabProfesores As TabPage
    Friend WithEvents tabAlumnos As TabPage
    Friend WithEvents dgvProfesores As DataGridView
    Friend WithEvents dgvAlumnos As DataGridView
    Friend WithEvents bLogout As Button
End Class
