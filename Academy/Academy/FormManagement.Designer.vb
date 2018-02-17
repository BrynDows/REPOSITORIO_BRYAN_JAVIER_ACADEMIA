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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.bMod = New System.Windows.Forms.Button()
        Me.bDel = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "profesores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "alumnos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(130, 190)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(776, 484)
        Me.DataGridView1.TabIndex = 2
        '
        'bAdd
        '
        Me.bAdd.Location = New System.Drawing.Point(996, 216)
        Me.bAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Size = New System.Drawing.Size(84, 29)
        Me.bAdd.TabIndex = 3
        Me.bAdd.Text = "Añadir"
        Me.bAdd.UseVisualStyleBackColor = True
        '
        'bMod
        '
        Me.bMod.Location = New System.Drawing.Point(996, 279)
        Me.bMod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bMod.Name = "bMod"
        Me.bMod.Size = New System.Drawing.Size(84, 29)
        Me.bMod.TabIndex = 4
        Me.bMod.Text = "Modificar"
        Me.bMod.UseVisualStyleBackColor = True
        '
        'bDel
        '
        Me.bDel.Location = New System.Drawing.Point(996, 350)
        Me.bDel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bDel.Name = "bDel"
        Me.bDel.Size = New System.Drawing.Size(84, 29)
        Me.bDel.TabIndex = 5
        Me.bDel.Text = "Eliminar"
        Me.bDel.UseVisualStyleBackColor = True
        '
        'FormManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1169, 911)
        Me.Controls.Add(Me.bDel)
        Me.Controls.Add(Me.bMod)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormManagement"
        Me.Text = "FormManagement"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bAdd As Button
    Friend WithEvents bMod As Button
    Friend WithEvents bDel As Button
End Class
