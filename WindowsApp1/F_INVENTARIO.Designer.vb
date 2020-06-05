<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_INVENTARIO
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNAGREGAR = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.B_MENU = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_ARTICULO = New System.Windows.Forms.TextBox()
        Me.TextBox_ALMACEN = New System.Windows.Forms.TextBox()
        Me.TextBox_CANTIDAD = New System.Windows.Forms.TextBox()
        Me.BTNFACTURA = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(701, 532)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 48)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "ACTUALIZAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.Location = New System.Drawing.Point(383, 537)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(106, 48)
        Me.BTNAGREGAR.TabIndex = 36
        Me.BTNAGREGAR.Text = "AGREGAR "
        Me.BTNAGREGAR.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(344, 162)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(469, 313)
        Me.DataGridView1.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.PowderBlue
        Me.Label4.Location = New System.Drawing.Point(160, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(261, 54)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "INVENTARIO"
        '
        'B_MENU
        '
        Me.B_MENU.BackColor = System.Drawing.Color.LimeGreen
        Me.B_MENU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B_MENU.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_MENU.ForeColor = System.Drawing.SystemColors.Info
        Me.B_MENU.Location = New System.Drawing.Point(536, 537)
        Me.B_MENU.Margin = New System.Windows.Forms.Padding(4)
        Me.B_MENU.Name = "B_MENU"
        Me.B_MENU.Size = New System.Drawing.Size(124, 48)
        Me.B_MENU.TabIndex = 34
        Me.B_MENU.Text = "REGRESAR"
        Me.B_MENU.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(166, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 15)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Autor : Samuel Ramirez S."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(166, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Version 1.0.0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(166, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 18)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "SISTEMA DE VENTAS"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(1, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1281, 131)
        Me.Panel4.TabIndex = 45
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.inventary_report_icon1
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "CANTIDAD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "ALMACEN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "ARTICULO"
        '
        'TextBox_ARTICULO
        '
        Me.TextBox_ARTICULO.Location = New System.Drawing.Point(121, 240)
        Me.TextBox_ARTICULO.Name = "TextBox_ARTICULO"
        Me.TextBox_ARTICULO.Size = New System.Drawing.Size(208, 22)
        Me.TextBox_ARTICULO.TabIndex = 49
        '
        'TextBox_ALMACEN
        '
        Me.TextBox_ALMACEN.Location = New System.Drawing.Point(121, 302)
        Me.TextBox_ALMACEN.Name = "TextBox_ALMACEN"
        Me.TextBox_ALMACEN.Size = New System.Drawing.Size(208, 22)
        Me.TextBox_ALMACEN.TabIndex = 50
        '
        'TextBox_CANTIDAD
        '
        Me.TextBox_CANTIDAD.Location = New System.Drawing.Point(121, 364)
        Me.TextBox_CANTIDAD.Name = "TextBox_CANTIDAD"
        Me.TextBox_CANTIDAD.Size = New System.Drawing.Size(208, 22)
        Me.TextBox_CANTIDAD.TabIndex = 51
        '
        'BTNFACTURA
        '
        Me.BTNFACTURA.Location = New System.Drawing.Point(194, 537)
        Me.BTNFACTURA.Name = "BTNFACTURA"
        Me.BTNFACTURA.Size = New System.Drawing.Size(135, 48)
        Me.BTNFACTURA.TabIndex = 52
        Me.BTNFACTURA.Text = "FACTURACION"
        Me.BTNFACTURA.UseVisualStyleBackColor = True
        '
        'F_INVENTARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(892, 628)
        Me.Controls.Add(Me.BTNFACTURA)
        Me.Controls.Add(Me.TextBox_CANTIDAD)
        Me.Controls.Add(Me.TextBox_ALMACEN)
        Me.Controls.Add(Me.TextBox_ARTICULO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTNAGREGAR)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.B_MENU)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "F_INVENTARIO"
        Me.Text = "INVENTARIO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_MENU As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BTNAGREGAR As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_ARTICULO As TextBox
    Friend WithEvents TextBox_ALMACEN As TextBox
    Friend WithEvents TextBox_CANTIDAD As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNFACTURA As Button
End Class
