<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Rbtn_Codigo = New System.Windows.Forms.RadioButton()
        Me.Rbtn_Nombre = New System.Windows.Forms.RadioButton()
        Me.Rbtn_Cedula = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SISTEMADECLIENTESDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SISTEMA_DE_CLIENTESDataSet = New WindowsApp1.SISTEMA_DE_CLIENTESDataSet()
        Me.CheckBox_Vertodos = New System.Windows.Forms.CheckBox()
        Me.Lb_seleccione = New System.Windows.Forms.Label()
        Me.Lb_buscar = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SISTEMADECLIENTESDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SISTEMA_DE_CLIENTESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(308, 81)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.MaxLength = 30
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(367, 22)
        Me.TextBox1.TabIndex = 48
        '
        'Rbtn_Codigo
        '
        Me.Rbtn_Codigo.AutoSize = True
        Me.Rbtn_Codigo.Location = New System.Drawing.Point(26, 55)
        Me.Rbtn_Codigo.Name = "Rbtn_Codigo"
        Me.Rbtn_Codigo.Size = New System.Drawing.Size(73, 21)
        Me.Rbtn_Codigo.TabIndex = 50
        Me.Rbtn_Codigo.TabStop = True
        Me.Rbtn_Codigo.Text = "Codigo"
        Me.Rbtn_Codigo.UseVisualStyleBackColor = True
        '
        'Rbtn_Nombre
        '
        Me.Rbtn_Nombre.AutoSize = True
        Me.Rbtn_Nombre.Location = New System.Drawing.Point(26, 85)
        Me.Rbtn_Nombre.Name = "Rbtn_Nombre"
        Me.Rbtn_Nombre.Size = New System.Drawing.Size(79, 21)
        Me.Rbtn_Nombre.TabIndex = 51
        Me.Rbtn_Nombre.TabStop = True
        Me.Rbtn_Nombre.Text = "Nombre"
        Me.Rbtn_Nombre.UseVisualStyleBackColor = True
        '
        'Rbtn_Cedula
        '
        Me.Rbtn_Cedula.AutoSize = True
        Me.Rbtn_Cedula.Location = New System.Drawing.Point(26, 115)
        Me.Rbtn_Cedula.Name = "Rbtn_Cedula"
        Me.Rbtn_Cedula.Size = New System.Drawing.Size(73, 21)
        Me.Rbtn_Cedula.TabIndex = 52
        Me.Rbtn_Cedula.TabStop = True
        Me.Rbtn_Cedula.Text = "Cedula"
        Me.Rbtn_Cedula.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.SISTEMADECLIENTESDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 172)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(829, 381)
        Me.DataGridView1.TabIndex = 53
        '
        'SISTEMADECLIENTESDataSetBindingSource
        '
        Me.SISTEMADECLIENTESDataSetBindingSource.DataSource = Me.SISTEMA_DE_CLIENTESDataSet
        Me.SISTEMADECLIENTESDataSetBindingSource.Position = 0
        '
        'SISTEMA_DE_CLIENTESDataSet
        '
        Me.SISTEMA_DE_CLIENTESDataSet.DataSetName = "SISTEMA_DE_CLIENTESDataSet"
        Me.SISTEMA_DE_CLIENTESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox_Vertodos
        '
        Me.CheckBox_Vertodos.AutoSize = True
        Me.CheckBox_Vertodos.Checked = True
        Me.CheckBox_Vertodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Vertodos.Location = New System.Drawing.Point(764, 115)
        Me.CheckBox_Vertodos.Name = "CheckBox_Vertodos"
        Me.CheckBox_Vertodos.Size = New System.Drawing.Size(91, 21)
        Me.CheckBox_Vertodos.TabIndex = 54
        Me.CheckBox_Vertodos.Text = "Ver todos"
        Me.CheckBox_Vertodos.UseVisualStyleBackColor = True
        '
        'Lb_seleccione
        '
        Me.Lb_seleccione.AutoSize = True
        Me.Lb_seleccione.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_seleccione.Location = New System.Drawing.Point(23, 23)
        Me.Lb_seleccione.Name = "Lb_seleccione"
        Me.Lb_seleccione.Size = New System.Drawing.Size(254, 18)
        Me.Lb_seleccione.TabIndex = 55
        Me.Lb_seleccione.Text = "Seleccione criterio de busqueda:"
        '
        'Lb_buscar
        '
        Me.Lb_buscar.AutoSize = True
        Me.Lb_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_buscar.Location = New System.Drawing.Point(609, 55)
        Me.Lb_buscar.Name = "Lb_buscar"
        Me.Lb_buscar.Size = New System.Drawing.Size(66, 18)
        Me.Lb_buscar.TabIndex = 56
        Me.Lb_buscar.Text = "Buscar:"
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 586)
        Me.Controls.Add(Me.Lb_buscar)
        Me.Controls.Add(Me.Lb_seleccione)
        Me.Controls.Add(Me.CheckBox_Vertodos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Rbtn_Cedula)
        Me.Controls.Add(Me.Rbtn_Nombre)
        Me.Controls.Add(Me.Rbtn_Codigo)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Consulta"
        Me.Text = "Consulta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SISTEMADECLIENTESDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SISTEMA_DE_CLIENTESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Rbtn_Codigo As RadioButton
    Friend WithEvents Rbtn_Nombre As RadioButton
    Friend WithEvents Rbtn_Cedula As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SISTEMADECLIENTESDataSetBindingSource As BindingSource
    Friend WithEvents SISTEMA_DE_CLIENTESDataSet As SISTEMA_DE_CLIENTESDataSet
    Friend WithEvents CheckBox_Vertodos As CheckBox
    Friend WithEvents Lb_seleccione As Label
    Friend WithEvents Lb_buscar As Label
End Class
