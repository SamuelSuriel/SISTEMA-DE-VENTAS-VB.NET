Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class F_CLIENTE
    'Private dv As New DataView
    Dim adapt As New SqlDataAdapter
    'Dim ds As New DataSet
    Dim tabla As DataTable
    Public connex As String = "Data Source=DESKTOP-T75D7KR;Initial Catalog=SISTEMA_DE_CLIENTES;Integrated Security=True"

    Sub VISTA_DE_DATOS()
        Try

            Dim da As New SqlDataAdapter(" 
select ID_CLIENTE AS 'CODIGO', NOMBRE AS 'NOMBRE', APELLIDO AS 'APELLIDO', CEDULA AS 'CEDULA', TELEFONO AS 'TELEFONO', MEMBRESIA AS 'MEMBRESIA', ESTADO AS 'ESTADO', GENERO AS 'GENERO' from CLIENTES
", connex)

            Dim ds As New DataSet
            Dim dv As New DataView
            da.Fill(ds)
            dv.Table = ds.Tables(0)
            DataGridView1.DataSource = dv

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Sub LIMPIAR()
        Try

            TXTCODCLIENTE.Clear()
            TXTNOMBRE.Clear()
            TXTAPELLIDO.Clear()
            MTXTCEDULA.Clear()
            MTXTTELEFONO.Clear()
            CBMEMBRESIA.Text = ""
            CBESTADO.Text = ""
            CB_GENERO.Text = ""


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub Registrar_Cliente()

        Try

            Dim Conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEX").ConnectionString)
            Dim CMD As New SqlCommand("INSERTA_CLIENTES", Conex)
            CMD.CommandType = CommandType.StoredProcedure



            CMD.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = TXTNOMBRE.Text

            CMD.Parameters.Add("@APELLIDO", SqlDbType.VarChar).Value = TXTAPELLIDO.Text

            CMD.Parameters.Add("@CEDULA", SqlDbType.VarChar).Value = MTXTCEDULA.Text

            CMD.Parameters.Add("@TELEFONO", SqlDbType.VarChar).Value = MTXTTELEFONO.Text

            CMD.Parameters.Add("@MEMBRESIA", SqlDbType.VarChar).Value = CBMEMBRESIA.Text

            CMD.Parameters.Add("@ESTADO", SqlDbType.VarChar).Value = CBESTADO.Text

            CMD.Parameters.Add("@GENERO", SqlDbType.VarChar).Value = CB_GENERO.Text

            Conex.Open()

            CMD.ExecuteNonQuery()

            Conex.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub B_MENU_Click(sender As Object, e As EventArgs) Handles B_MENU.Click
        F_MENU.Show()
        Me.Hide()
        Call LIMPIAR()


    End Sub

    Private Sub F_CLIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call VISTA_DE_DATOS()


    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TXTTELEFONO_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True

        Else

        End If
        If Asc(e.KeyChar) = 13 Then
            CBMEMBRESIA.Focus()

        End If
    End Sub


    Private Sub TXTNOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTAPELLIDO.KeyPress, TXTNOMBRE.KeyPress

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True



        End If
        If Asc(e.KeyChar) = 13 Then
            TXTAPELLIDO.Focus()

        End If
    End Sub

    Private Sub TXTAPELLIDO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MTXTCEDULA.KeyPress, TXTAPELLIDO.KeyPress

        If Asc(e.KeyChar) = 13 Then
            MTXTCEDULA.Focus()


        End If


    End Sub


    Private Sub TXTCEDULA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MTXTTELEFONO.KeyPress, MTXTCEDULA.KeyPress

        If Asc(e.KeyChar) = 13 Then
            MTXTTELEFONO.Focus()




        End If


    End Sub


    Private Sub B_REGISTRAR_CLIENTE_Click(sender As Object, e As EventArgs) Handles B_REGISTRAR_CLIENTE.Click
        Call Registrar_Cliente()
        Call VISTA_DE_DATOS()
        Call LIMPIAR()


    End Sub

    Private Sub BTN_ACTUALIZAR_Click(sender As Object, e As EventArgs) Handles BTN_ACTUALIZAR.Click
        Call VISTA_DE_DATOS()
        Call LIMPIAR()


    End Sub

    Private Sub BTNMODIFICAR_Click(sender As Object, e As EventArgs) Handles BTNMODIFICAR.Click
        Call Modificar_Cliente()
        Call VISTA_DE_DATOS()
        Call LIMPIAR()


    End Sub

    Sub Modificar_Cliente()


        Try

            Dim Conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEX").ConnectionString)
            Dim CMD As New SqlCommand("ModificarCliente", Conex)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("@ID_CLIENTE", SqlDbType.Int).Value = TXTCODCLIENTE.Text

            CMD.Parameters.AddWithValue("@NOMBRE", SqlDbType.VarChar).Value = TXTNOMBRE.Text

            CMD.Parameters.AddWithValue("@APELLIDO", SqlDbType.VarChar).Value = TXTAPELLIDO.Text

            CMD.Parameters.AddWithValue("@CEDULA", SqlDbType.VarChar).Value = MTXTCEDULA.Text

            CMD.Parameters.AddWithValue("@TELEFONO", SqlDbType.VarChar).Value = MTXTTELEFONO.Text

            CMD.Parameters.AddWithValue("@MEMBRESIA", SqlDbType.VarChar).Value = CBMEMBRESIA.Text

            CMD.Parameters.AddWithValue("@ESTADO", SqlDbType.VarChar).Value = CBESTADO.Text

            CMD.Parameters.AddWithValue("@GENERO", SqlDbType.VarChar).Value = CB_GENERO.Text

            Conex.Open()

            CMD.ExecuteNonQuery()

            Conex.Close()



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Sub ELIMINAR_CLIENTE()


        Try

            Dim Conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEX").ConnectionString)
            Dim CMD As New SqlCommand("ELIMINAR_CLIENTE", Conex)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("@ID_CLIENTE", SqlDbType.VarChar).Value = TXTCODCLIENTE.Text


            Conex.Open()

            CMD.ExecuteNonQuery()

            Conex.Close()



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

            TXTCODCLIENTE.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value()
            TXTNOMBRE.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value()
            TXTAPELLIDO.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value()
            MTXTCEDULA.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value()
            MTXTTELEFONO.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(4).Value()
            CBMEMBRESIA.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(5).Value()
            CBESTADO.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(6).Value()
            CB_GENERO.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(7).Value()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BTN_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.Click
        Call ELIMINAR_CLIENTE()
        Call LIMPIAR()
        Call VISTA_DE_DATOS()


    End Sub

    Private Sub Btn_buscar_Click(sender As Object, e As EventArgs) Handles Btn_consulta.Click
        Consulta.Show()
        Me.Hide()

    End Sub
End Class