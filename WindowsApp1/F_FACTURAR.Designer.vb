<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_FACTURAR
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
        Me.BTNREGRESAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTCANTIDAD = New System.Windows.Forms.TextBox()
        Me.TXTPRECIO = New System.Windows.Forms.TextBox()
        Me.TXTITBIS = New System.Windows.Forms.TextBox()
        Me.TXTSUBTOT = New System.Windows.Forms.TextBox()
        Me.TXTTOT = New System.Windows.Forms.TextBox()
        Me.BTNGENERAR = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNREPORTE = New System.Windows.Forms.Button()
        Me.TXTCOD_ART = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTCOD_CLI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTCLIENTE = New System.Windows.Forms.TextBox()
        Me.TXTDESCRIP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button_BORRAR = New System.Windows.Forms.Button()
        Me.Button_AÑADIR = New System.Windows.Forms.Button()
        Me.TXTFACTURA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TXTFECHA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNREGRESAR
        '
        Me.BTNREGRESAR.BackColor = System.Drawing.Color.LimeGreen
        Me.BTNREGRESAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREGRESAR.ForeColor = System.Drawing.SystemColors.Info
        Me.BTNREGRESAR.Location = New System.Drawing.Point(370, 605)
        Me.BTNREGRESAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNREGRESAR.Name = "BTNREGRESAR"
        Me.BTNREGRESAR.Size = New System.Drawing.Size(124, 48)
        Me.BTNREGRESAR.TabIndex = 34
        Me.BTNREGRESAR.Text = "REGRESAR"
        Me.BTNREGRESAR.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 18)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "CANTIDAD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "PRECIO RD$:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(996, 655)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 17)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "ITBIS:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(946, 620)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 17)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "SUB-TOTAL:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(984, 689)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "TOTAL:"
        '
        'TXTCANTIDAD
        '
        Me.TXTCANTIDAD.Location = New System.Drawing.Point(164, 92)
        Me.TXTCANTIDAD.Name = "TXTCANTIDAD"
        Me.TXTCANTIDAD.Size = New System.Drawing.Size(192, 22)
        Me.TXTCANTIDAD.TabIndex = 47
        '
        'TXTPRECIO
        '
        Me.TXTPRECIO.Location = New System.Drawing.Point(163, 197)
        Me.TXTPRECIO.Name = "TXTPRECIO"
        Me.TXTPRECIO.Size = New System.Drawing.Size(193, 22)
        Me.TXTPRECIO.TabIndex = 50
        '
        'TXTITBIS
        '
        Me.TXTITBIS.Location = New System.Drawing.Point(1044, 652)
        Me.TXTITBIS.Name = "TXTITBIS"
        Me.TXTITBIS.Size = New System.Drawing.Size(76, 22)
        Me.TXTITBIS.TabIndex = 55
        '
        'TXTSUBTOT
        '
        Me.TXTSUBTOT.Location = New System.Drawing.Point(1044, 617)
        Me.TXTSUBTOT.Name = "TXTSUBTOT"
        Me.TXTSUBTOT.Size = New System.Drawing.Size(100, 22)
        Me.TXTSUBTOT.TabIndex = 56
        '
        'TXTTOT
        '
        Me.TXTTOT.Location = New System.Drawing.Point(1044, 687)
        Me.TXTTOT.Name = "TXTTOT"
        Me.TXTTOT.Size = New System.Drawing.Size(100, 22)
        Me.TXTTOT.TabIndex = 57
        '
        'BTNGENERAR
        '
        Me.BTNGENERAR.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BTNGENERAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGENERAR.ForeColor = System.Drawing.SystemColors.Info
        Me.BTNGENERAR.Location = New System.Drawing.Point(24, 605)
        Me.BTNGENERAR.Name = "BTNGENERAR"
        Me.BTNGENERAR.Size = New System.Drawing.Size(136, 47)
        Me.BTNGENERAR.TabIndex = 58
        Me.BTNGENERAR.Text = "GENERAR"
        Me.BTNGENERAR.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(401, 166)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(552, 408)
        Me.DataGridView1.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.PowderBlue
        Me.Label11.Location = New System.Drawing.Point(148, -3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(282, 49)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "FACTURACION"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(154, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 15)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Autor : Samuel Ramirez S."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.Location = New System.Drawing.Point(154, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 15)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Version 1.0.0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label14.Location = New System.Drawing.Point(154, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 18)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "SISTEMA DE VENTAS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1180, 94)
        Me.Panel1.TabIndex = 64
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.cashier_icon_icons1
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BTNREPORTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREPORTE.ForeColor = System.Drawing.SystemColors.Info
        Me.BTNREPORTE.Location = New System.Drawing.Point(194, 605)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(132, 48)
        Me.BTNREPORTE.TabIndex = 65
        Me.BTNREPORTE.Text = "REPORTES"
        Me.BTNREPORTE.UseVisualStyleBackColor = False
        '
        'TXTCOD_ART
        '
        Me.TXTCOD_ART.Location = New System.Drawing.Point(164, 124)
        Me.TXTCOD_ART.Name = "TXTCOD_ART"
        Me.TXTCOD_ART.ReadOnly = True
        Me.TXTCOD_ART.Size = New System.Drawing.Size(192, 22)
        Me.TXTCOD_ART.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 18)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "COD_ARTICULO:"
        '
        'TXTCOD_CLI
        '
        Me.TXTCOD_CLI.Location = New System.Drawing.Point(127, 61)
        Me.TXTCOD_CLI.Name = "TXTCOD_CLI"
        Me.TXTCOD_CLI.ReadOnly = True
        Me.TXTCOD_CLI.Size = New System.Drawing.Size(229, 22)
        Me.TXTCOD_CLI.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 18)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "CLIENTE:"
        '
        'TXTCLIENTE
        '
        Me.TXTCLIENTE.Location = New System.Drawing.Point(127, 89)
        Me.TXTCLIENTE.Name = "TXTCLIENTE"
        Me.TXTCLIENTE.Size = New System.Drawing.Size(229, 22)
        Me.TXTCLIENTE.TabIndex = 70
        '
        'TXTDESCRIP
        '
        Me.TXTDESCRIP.Location = New System.Drawing.Point(164, 164)
        Me.TXTDESCRIP.Name = "TXTDESCRIP"
        Me.TXTDESCRIP.Size = New System.Drawing.Size(192, 22)
        Me.TXTDESCRIP.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 18)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "DESCRIPCION:"
        '
        'Button_BORRAR
        '
        Me.Button_BORRAR.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.plus_add_minus
        Me.Button_BORRAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_BORRAR.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_BORRAR.Location = New System.Drawing.Point(959, 523)
        Me.Button_BORRAR.Name = "Button_BORRAR"
        Me.Button_BORRAR.Size = New System.Drawing.Size(49, 51)
        Me.Button_BORRAR.TabIndex = 46
        Me.Button_BORRAR.UseVisualStyleBackColor = True
        '
        'Button_AÑADIR
        '
        Me.Button_AÑADIR.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.plus_add_blue
        Me.Button_AÑADIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_AÑADIR.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_AÑADIR.Location = New System.Drawing.Point(959, 466)
        Me.Button_AÑADIR.Name = "Button_AÑADIR"
        Me.Button_AÑADIR.Size = New System.Drawing.Size(49, 51)
        Me.Button_AÑADIR.TabIndex = 45
        Me.Button_AÑADIR.UseVisualStyleBackColor = True
        '
        'TXTFACTURA
        '
        Me.TXTFACTURA.Location = New System.Drawing.Point(518, 138)
        Me.TXTFACTURA.Name = "TXTFACTURA"
        Me.TXTFACTURA.Size = New System.Drawing.Size(83, 22)
        Me.TXTFACTURA.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(398, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 18)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "FACTURA NO."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(5, 101)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(83, 22)
        Me.TextBox1.TabIndex = 75
        '
        'TXTFECHA
        '
        Me.TXTFECHA.Location = New System.Drawing.Point(1074, 100)
        Me.TXTFECHA.Name = "TXTFECHA"
        Me.TXTFECHA.Size = New System.Drawing.Size(107, 22)
        Me.TXTFECHA.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1005, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 18)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "FECHA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 18)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "CODIGO:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.TXTCOD_CLI)
        Me.Panel2.Controls.Add(Me.TXTCLIENTE)
        Me.Panel2.Location = New System.Drawing.Point(1, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(383, 134)
        Me.Panel2.TabIndex = 79
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.MintCream
        Me.Label16.Location = New System.Drawing.Point(104, 2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 38)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "CLIENTE:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.TXTCANTIDAD)
        Me.Panel3.Controls.Add(Me.TXTPRECIO)
        Me.Panel3.Controls.Add(Me.TXTCOD_ART)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TXTDESCRIP)
        Me.Panel3.Location = New System.Drawing.Point(1, 302)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(383, 272)
        Me.Panel3.TabIndex = 80
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.MintCream
        Me.Label17.Location = New System.Drawing.Point(91, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(167, 38)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "ARTICULO:"
        '
        'F_FACTURAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 746)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TXTFECHA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TXTFACTURA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTNREPORTE)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTNGENERAR)
        Me.Controls.Add(Me.TXTTOT)
        Me.Controls.Add(Me.TXTSUBTOT)
        Me.Controls.Add(Me.TXTITBIS)
        Me.Controls.Add(Me.Button_BORRAR)
        Me.Controls.Add(Me.Button_AÑADIR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BTNREGRESAR)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "F_FACTURAR"
        Me.Text = "FACTURAR"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNREGRESAR As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button_AÑADIR As Button
    Friend WithEvents Button_BORRAR As Button
    Friend WithEvents TXTCANTIDAD As TextBox
    Friend WithEvents TXTPRECIO As TextBox
    Friend WithEvents TXTITBIS As TextBox
    Friend WithEvents TXTSUBTOT As TextBox
    Friend WithEvents TXTTOT As TextBox
    Friend WithEvents BTNGENERAR As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNREPORTE As Button
    Friend WithEvents TXTCOD_ART As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTCOD_CLI As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTCLIENTE As TextBox
    Friend WithEvents TXTDESCRIP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTFACTURA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TXTFECHA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label17 As Label
End Class
