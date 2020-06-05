<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_ARTICULO
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
        Me.B_MENU = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXTID_ART = New System.Windows.Forms.TextBox()
        Me.LBID_ARTICULO = New System.Windows.Forms.Label()
        Me.TextBox_TIPO = New System.Windows.Forms.TextBox()
        Me.TextBox_PRECIO = New System.Windows.Forms.TextBox()
        Me.TextBox_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.TextBox_ARTICULO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SISTEMA_DE_CLIENTES_ARTICULOS = New WindowsApp1.SISTEMA_DE_CLIENTES_ARTICULOS()
        Me.L = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ARTICULOSTableAdapter = New WindowsApp1.SISTEMA_DE_CLIENTES_ARTICULOSTableAdapters.ARTICULOSTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SISTEMA_DE_CLIENTES_ARTICULOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'B_MENU
        '
        Me.B_MENU.BackColor = System.Drawing.Color.LimeGreen
        Me.B_MENU.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_MENU.ForeColor = System.Drawing.SystemColors.Info
        Me.B_MENU.Location = New System.Drawing.Point(532, 557)
        Me.B_MENU.Margin = New System.Windows.Forms.Padding(4)
        Me.B_MENU.Name = "B_MENU"
        Me.B_MENU.Size = New System.Drawing.Size(119, 57)
        Me.B_MENU.TabIndex = 34
        Me.B_MENU.Text = "REGRESAR"
        Me.B_MENU.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TXTID_ART)
        Me.Panel1.Controls.Add(Me.LBID_ARTICULO)
        Me.Panel1.Controls.Add(Me.TextBox_TIPO)
        Me.Panel1.Controls.Add(Me.TextBox_PRECIO)
        Me.Panel1.Controls.Add(Me.TextBox_DESCRIPCION)
        Me.Panel1.Controls.Add(Me.TextBox_ARTICULO)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(30, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 372)
        Me.Panel1.TabIndex = 35
        '
        'TXTID_ART
        '
        Me.TXTID_ART.Location = New System.Drawing.Point(20, 14)
        Me.TXTID_ART.Name = "TXTID_ART"
        Me.TXTID_ART.ReadOnly = True
        Me.TXTID_ART.Size = New System.Drawing.Size(254, 22)
        Me.TXTID_ART.TabIndex = 52
        '
        'LBID_ARTICULO
        '
        Me.LBID_ARTICULO.AutoSize = True
        Me.LBID_ARTICULO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBID_ARTICULO.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBID_ARTICULO.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LBID_ARTICULO.Location = New System.Drawing.Point(326, 19)
        Me.LBID_ARTICULO.Name = "LBID_ARTICULO"
        Me.LBID_ARTICULO.Size = New System.Drawing.Size(113, 25)
        Me.LBID_ARTICULO.TabIndex = 51
        Me.LBID_ARTICULO.Text = "CODIGO_ART"
        '
        'TextBox_TIPO
        '
        Me.TextBox_TIPO.Location = New System.Drawing.Point(20, 238)
        Me.TextBox_TIPO.Name = "TextBox_TIPO"
        Me.TextBox_TIPO.Size = New System.Drawing.Size(254, 22)
        Me.TextBox_TIPO.TabIndex = 9
        '
        'TextBox_PRECIO
        '
        Me.TextBox_PRECIO.Location = New System.Drawing.Point(20, 177)
        Me.TextBox_PRECIO.Name = "TextBox_PRECIO"
        Me.TextBox_PRECIO.Size = New System.Drawing.Size(254, 22)
        Me.TextBox_PRECIO.TabIndex = 8
        '
        'TextBox_DESCRIPCION
        '
        Me.TextBox_DESCRIPCION.Location = New System.Drawing.Point(20, 116)
        Me.TextBox_DESCRIPCION.Name = "TextBox_DESCRIPCION"
        Me.TextBox_DESCRIPCION.Size = New System.Drawing.Size(254, 22)
        Me.TextBox_DESCRIPCION.TabIndex = 7
        '
        'TextBox_ARTICULO
        '
        Me.TextBox_ARTICULO.Location = New System.Drawing.Point(20, 61)
        Me.TextBox_ARTICULO.Name = "TextBox_ARTICULO"
        Me.TextBox_ARTICULO.Size = New System.Drawing.Size(254, 22)
        Me.TextBox_ARTICULO.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(326, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TIPO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(326, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PRECIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(326, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DESCRIPCION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(326, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ARTICULO"
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(634, 194)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(550, 308)
        Me.DataGridView1.TabIndex = 36
        '
        'ARTICULOSBindingSource
        '
        Me.ARTICULOSBindingSource.DataMember = "ARTICULOS"
        Me.ARTICULOSBindingSource.DataSource = Me.SISTEMA_DE_CLIENTES_ARTICULOS
        '
        'SISTEMA_DE_CLIENTES_ARTICULOS
        '
        Me.SISTEMA_DE_CLIENTES_ARTICULOS.DataSetName = "SISTEMA_DE_CLIENTES_ARTICULOS"
        Me.SISTEMA_DE_CLIENTES_ARTICULOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.BackColor = System.Drawing.Color.Transparent
        Me.L.Font = New System.Drawing.Font("Trebuchet MS", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.ForeColor = System.Drawing.Color.PowderBlue
        Me.L.Location = New System.Drawing.Point(172, 9)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(243, 54)
        Me.L.TabIndex = 42
        Me.L.Text = "ARTICULOS"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Info
        Me.Button2.Location = New System.Drawing.Point(194, 557)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 57)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "VER ARTICULO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Info
        Me.Button3.Location = New System.Drawing.Point(352, 557)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 57)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "INVENTARIO"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.CadetBlue
        Me.Button4.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.Info
        Me.Button4.Location = New System.Drawing.Point(1067, 525)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 37)
        Me.Button4.TabIndex = 46
        Me.Button4.Text = "ACTUALIZAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(179, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 15)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Autor : Samuel Ramirez S."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(179, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 15)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Version 1.0.0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(178, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 17)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "SISTEMA DE VENTAS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.L)
        Me.Panel2.Location = New System.Drawing.Point(3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1237, 122)
        Me.Panel2.TabIndex = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources._313511
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'ARTICULOSTableAdapter
        '
        Me.ARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._1495574037_floppy_disk_84506
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Info
        Me.Button1.Location = New System.Drawing.Point(30, 557)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 57)
        Me.Button1.TabIndex = 43
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.BackColor = System.Drawing.Color.CadetBlue
        Me.BTNMODIFICAR.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMODIFICAR.ForeColor = System.Drawing.SystemColors.Info
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(932, 525)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(117, 37)
        Me.BTNMODIFICAR.TabIndex = 51
        Me.BTNMODIFICAR.Text = "MODIFICAR"
        Me.BTNMODIFICAR.UseVisualStyleBackColor = False
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.BackColor = System.Drawing.Color.CadetBlue
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.ForeColor = System.Drawing.SystemColors.Info
        Me.BTNELIMINAR.Location = New System.Drawing.Point(786, 525)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(117, 37)
        Me.BTNELIMINAR.TabIndex = 52
        Me.BTNELIMINAR.Text = "ELIMINAR"
        Me.BTNELIMINAR.UseVisualStyleBackColor = False
        '
        'F_ARTICULO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 643)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.BTNMODIFICAR)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.B_MENU)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "F_ARTICULO"
        Me.Text = "ARTICULO"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SISTEMA_DE_CLIENTES_ARTICULOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents B_MENU As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox_TIPO As TextBox
    Friend WithEvents TextBox_PRECIO As TextBox
    Friend WithEvents TextBox_DESCRIPCION As TextBox
    Friend WithEvents TextBox_ARTICULO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents L As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SISTEMA_DE_CLIENTES_ARTICULOS As SISTEMA_DE_CLIENTES_ARTICULOS
    Friend WithEvents ARTICULOSBindingSource As BindingSource
    Friend WithEvents ARTICULOSTableAdapter As SISTEMA_DE_CLIENTES_ARTICULOSTableAdapters.ARTICULOSTableAdapter
    Friend WithEvents TXTID_ART As TextBox
    Friend WithEvents LBID_ARTICULO As Label
    Friend WithEvents BTNMODIFICAR As Button
    Friend WithEvents BTNELIMINAR As Button
End Class
