<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_CLIENTE
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
        Me.B_REGISTRAR_CLIENTE = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SISTEMA_DE_CLIENTESDataSet = New WindowsApp1.SISTEMA_DE_CLIENTESDataSet()
        Me.TXTAPELLIDO = New System.Windows.Forms.TextBox()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBMEMBRESIA = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXTCODCLIENTE = New System.Windows.Forms.TextBox()
        Me.LCOD_CLIENTE = New System.Windows.Forms.Label()
        Me.MTXTTELEFONO = New System.Windows.Forms.MaskedTextBox()
        Me.MTXTCEDULA = New System.Windows.Forms.MaskedTextBox()
        Me.CB_GENERO = New System.Windows.Forms.ComboBox()
        Me.CBESTADO = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_ELIMINAR = New System.Windows.Forms.Button()
        Me.CLIENTESTableAdapter = New WindowsApp1.SISTEMA_DE_CLIENTESDataSetTableAdapters.CLIENTESTableAdapter()
        Me.BTN_ACTUALIZAR = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.Btn_consulta = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SISTEMA_DE_CLIENTESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'B_MENU
        '
        Me.B_MENU.BackColor = System.Drawing.Color.LimeGreen
        Me.B_MENU.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_MENU.ForeColor = System.Drawing.SystemColors.Info
        Me.B_MENU.Location = New System.Drawing.Point(487, 562)
        Me.B_MENU.Margin = New System.Windows.Forms.Padding(4)
        Me.B_MENU.Name = "B_MENU"
        Me.B_MENU.Size = New System.Drawing.Size(113, 32)
        Me.B_MENU.TabIndex = 33
        Me.B_MENU.Text = "REGRESAR"
        Me.B_MENU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.B_MENU.UseVisualStyleBackColor = False
        '
        'B_REGISTRAR_CLIENTE
        '
        Me.B_REGISTRAR_CLIENTE.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.B_REGISTRAR_CLIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B_REGISTRAR_CLIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_REGISTRAR_CLIENTE.ForeColor = System.Drawing.SystemColors.Info
        Me.B_REGISTRAR_CLIENTE.Location = New System.Drawing.Point(32, 556)
        Me.B_REGISTRAR_CLIENTE.Margin = New System.Windows.Forms.Padding(4)
        Me.B_REGISTRAR_CLIENTE.Name = "B_REGISTRAR_CLIENTE"
        Me.B_REGISTRAR_CLIENTE.Size = New System.Drawing.Size(94, 38)
        Me.B_REGISTRAR_CLIENTE.TabIndex = 32
        Me.B_REGISTRAR_CLIENTE.Text = "Guardar"
        Me.B_REGISTRAR_CLIENTE.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label6.Location = New System.Drawing.Point(19, 268)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "ESTADO"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(493, 158)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(758, 390)
        Me.DataGridView1.TabIndex = 27
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.SISTEMA_DE_CLIENTESDataSet
        '
        'SISTEMA_DE_CLIENTESDataSet
        '
        Me.SISTEMA_DE_CLIENTESDataSet.DataSetName = "SISTEMA_DE_CLIENTESDataSet"
        Me.SISTEMA_DE_CLIENTESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TXTAPELLIDO
        '
        Me.TXTAPELLIDO.Location = New System.Drawing.Point(109, 94)
        Me.TXTAPELLIDO.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTAPELLIDO.MaxLength = 30
        Me.TXTAPELLIDO.Name = "TXTAPELLIDO"
        Me.TXTAPELLIDO.Size = New System.Drawing.Size(266, 22)
        Me.TXTAPELLIDO.TabIndex = 23
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(109, 47)
        Me.TXTNOMBRE.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTNOMBRE.MaxLength = 30
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(266, 22)
        Me.TXTNOMBRE.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Location = New System.Drawing.Point(20, 226)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 18)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "MEMBRESIA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(19, 181)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "TELEFONO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Location = New System.Drawing.Point(20, 139)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CEDULA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(20, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "APELLIDO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(20, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "NOMBRE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.CadetBlue
        Me.Label7.Location = New System.Drawing.Point(136, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(430, 49)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "REGISTRO DE CLIENTES"
        '
        'CBMEMBRESIA
        '
        Me.CBMEMBRESIA.FormattingEnabled = True
        Me.CBMEMBRESIA.Items.AddRange(New Object() {"ESTANDAR", "PREMIUM", "GOLD"})
        Me.CBMEMBRESIA.Location = New System.Drawing.Point(109, 220)
        Me.CBMEMBRESIA.Name = "CBMEMBRESIA"
        Me.CBMEMBRESIA.Size = New System.Drawing.Size(266, 24)
        Me.CBMEMBRESIA.TabIndex = 35
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TXTCODCLIENTE)
        Me.Panel1.Controls.Add(Me.LCOD_CLIENTE)
        Me.Panel1.Controls.Add(Me.MTXTTELEFONO)
        Me.Panel1.Controls.Add(Me.MTXTCEDULA)
        Me.Panel1.Controls.Add(Me.CB_GENERO)
        Me.Panel1.Controls.Add(Me.CBESTADO)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CBMEMBRESIA)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TXTAPELLIDO)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TXTNOMBRE)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(32, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 391)
        Me.Panel1.TabIndex = 40
        '
        'TXTCODCLIENTE
        '
        Me.TXTCODCLIENTE.Location = New System.Drawing.Point(127, 4)
        Me.TXTCODCLIENTE.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTCODCLIENTE.MaxLength = 30
        Me.TXTCODCLIENTE.Name = "TXTCODCLIENTE"
        Me.TXTCODCLIENTE.ReadOnly = True
        Me.TXTCODCLIENTE.Size = New System.Drawing.Size(248, 22)
        Me.TXTCODCLIENTE.TabIndex = 45
        '
        'LCOD_CLIENTE
        '
        Me.LCOD_CLIENTE.AutoSize = True
        Me.LCOD_CLIENTE.BackColor = System.Drawing.Color.Transparent
        Me.LCOD_CLIENTE.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCOD_CLIENTE.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LCOD_CLIENTE.Location = New System.Drawing.Point(20, 8)
        Me.LCOD_CLIENTE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCOD_CLIENTE.Name = "LCOD_CLIENTE"
        Me.LCOD_CLIENTE.Size = New System.Drawing.Size(99, 18)
        Me.LCOD_CLIENTE.TabIndex = 44
        Me.LCOD_CLIENTE.Text = "COD_CLIENTE"
        '
        'MTXTTELEFONO
        '
        Me.MTXTTELEFONO.Location = New System.Drawing.Point(109, 177)
        Me.MTXTTELEFONO.Mask = "000-000-0000"
        Me.MTXTTELEFONO.Name = "MTXTTELEFONO"
        Me.MTXTTELEFONO.Size = New System.Drawing.Size(266, 22)
        Me.MTXTTELEFONO.TabIndex = 43
        '
        'MTXTCEDULA
        '
        Me.MTXTCEDULA.Location = New System.Drawing.Point(109, 137)
        Me.MTXTCEDULA.Mask = "000-0000000-0"
        Me.MTXTCEDULA.Name = "MTXTCEDULA"
        Me.MTXTCEDULA.Size = New System.Drawing.Size(266, 22)
        Me.MTXTCEDULA.TabIndex = 42
        '
        'CB_GENERO
        '
        Me.CB_GENERO.FormattingEnabled = True
        Me.CB_GENERO.Items.AddRange(New Object() {"F", "M"})
        Me.CB_GENERO.Location = New System.Drawing.Point(109, 304)
        Me.CB_GENERO.Name = "CB_GENERO"
        Me.CB_GENERO.Size = New System.Drawing.Size(266, 24)
        Me.CB_GENERO.TabIndex = 41
        '
        'CBESTADO
        '
        Me.CBESTADO.FormattingEnabled = True
        Me.CBESTADO.Items.AddRange(New Object() {"ACTIVO", "INACTIVO", "NUEVO"})
        Me.CBESTADO.Location = New System.Drawing.Point(109, 262)
        Me.CBESTADO.Name = "CBESTADO"
        Me.CBESTADO.Size = New System.Drawing.Size(266, 24)
        Me.CBESTADO.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label8.Location = New System.Drawing.Point(19, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 18)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "GENERO"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(1, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1309, 106)
        Me.Panel2.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(144, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 15)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Autor : Samuel Ramirez S."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(144, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 15)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Version 1.0.0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(143, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 17)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "SISTEMA DE VENTAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.new_add_user_16734
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BTN_ELIMINAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ELIMINAR.ForeColor = System.Drawing.SystemColors.Info
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(863, 557)
        Me.BTN_ELIMINAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(125, 37)
        Me.BTN_ELIMINAR.TabIndex = 42
        Me.BTN_ELIMINAR.Text = "ELIMINAR"
        Me.BTN_ELIMINAR.UseVisualStyleBackColor = False
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'BTN_ACTUALIZAR
        '
        Me.BTN_ACTUALIZAR.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BTN_ACTUALIZAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ACTUALIZAR.ForeColor = System.Drawing.SystemColors.Info
        Me.BTN_ACTUALIZAR.Location = New System.Drawing.Point(987, 557)
        Me.BTN_ACTUALIZAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR"
        Me.BTN_ACTUALIZAR.Size = New System.Drawing.Size(128, 37)
        Me.BTN_ACTUALIZAR.TabIndex = 43
        Me.BTN_ACTUALIZAR.Text = "ACTUALIZAR"
        Me.BTN_ACTUALIZAR.UseVisualStyleBackColor = False
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BTNMODIFICAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMODIFICAR.ForeColor = System.Drawing.SystemColors.Info
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(1114, 557)
        Me.BTNMODIFICAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(137, 37)
        Me.BTNMODIFICAR.TabIndex = 44
        Me.BTNMODIFICAR.Text = "MODIFICAR"
        Me.BTNMODIFICAR.UseVisualStyleBackColor = False
        '
        'Btn_consulta
        '
        Me.Btn_consulta.Location = New System.Drawing.Point(1176, 127)
        Me.Btn_consulta.Name = "Btn_consulta"
        Me.Btn_consulta.Size = New System.Drawing.Size(75, 23)
        Me.Btn_consulta.TabIndex = 47
        Me.Btn_consulta.Text = "Consultar"
        Me.Btn_consulta.UseVisualStyleBackColor = True
        '
        'F_CLIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1311, 665)
        Me.Controls.Add(Me.Btn_consulta)
        Me.Controls.Add(Me.BTNMODIFICAR)
        Me.Controls.Add(Me.BTN_ACTUALIZAR)
        Me.Controls.Add(Me.BTN_ELIMINAR)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.B_MENU)
        Me.Controls.Add(Me.B_REGISTRAR_CLIENTE)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "F_CLIENTE"
        Me.Text = "CLIENTE"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SISTEMA_DE_CLIENTESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents B_MENU As Button
    Friend WithEvents B_REGISTRAR_CLIENTE As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TXTAPELLIDO As TextBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CBMEMBRESIA As ComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CBESTADO As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BTN_ELIMINAR As Button
    Friend WithEvents SISTEMA_DE_CLIENTESDataSet As SISTEMA_DE_CLIENTESDataSet
    Friend WithEvents CLIENTESBindingSource As BindingSource
    Friend WithEvents CLIENTESTableAdapter As SISTEMA_DE_CLIENTESDataSetTableAdapters.CLIENTESTableAdapter
    Friend WithEvents CB_GENERO As ComboBox
    Friend WithEvents BTN_ACTUALIZAR As Button
    Friend WithEvents MTXTTELEFONO As MaskedTextBox
    Friend WithEvents MTXTCEDULA As MaskedTextBox
    Friend WithEvents BTNMODIFICAR As Button
    Friend WithEvents TXTCODCLIENTE As TextBox
    Friend WithEvents LCOD_CLIENTE As Label
    Friend WithEvents Btn_consulta As Button
End Class
