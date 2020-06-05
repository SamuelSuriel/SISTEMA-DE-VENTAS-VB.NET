Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class F_ARTICULO
    Private Sub B_MENU_Click(sender As Object, e As EventArgs) Handles B_MENU.Click
        F_MENU.Show()
        Me.Hide()
        Call LIMPIAR()
    End Sub

    Sub LIMPIAR()
        Try
            TextBox_ARTICULO.Clear()
            TextBox_DESCRIPCION.Clear()
            TextBox_PRECIO.Clear()
            TextBox_TIPO.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public connex As String = "Data Source=DESKTOP-T75D7KR;Initial Catalog=SISTEMA_DE_CLIENTES;Integrated Security=True"
    Sub Registrar_Articulo()

        Try

            Dim Conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEX").ConnectionString)
            Dim CMD As New SqlCommand("INSERTA_ARTICULO", Conex)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.Add("@ARTICULO", SqlDbType.VarChar).Value = TextBox_ARTICULO.Text

            CMD.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar).Value = TextBox_DESCRIPCION.Text

            CMD.Parameters.Add("@PRECIO", SqlDbType.VarChar).Value = TextBox_PRECIO.Text

            CMD.Parameters.Add("@TIPO", SqlDbType.VarChar).Value = TextBox_TIPO.Text

            Conex.Open()

            CMD.ExecuteNonQuery()

            Conex.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Sub Modificar_Articulo()


        Try

            Dim Conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEX").ConnectionString)
            Dim CMD As New SqlCommand("ModificarArticulo", Conex)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("@ID_ARTICULO", SqlDbType.Int).Value = TXTID_ART.Text

            CMD.Parameters.AddWithValue("@ARTICULO", SqlDbType.VarChar).Value = TextBox_ARTICULO.Text

            CMD.Parameters.AddWithValue("@DESCRIPCION", SqlDbType.VarChar).Value = TextBox_DESCRIPCION.Text

            CMD.Parameters.AddWithValue("@PRECIO", SqlDbType.VarChar).Value = TextBox_PRECIO.Text

            CMD.Parameters.AddWithValue("@TIPO", SqlDbType.VarChar).Value = TextBox_TIPO.Text


            Conex.Open()

            CMD.ExecuteNonQuery()

            Conex.Close()



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Sub ELIMINAR_ARTICULOS()


        Try

            Dim Conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEX").ConnectionString)
            Dim CMD As New SqlCommand("ELIMINAR_ARTICULO", Conex)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("@ID_ARTICULO", SqlDbType.VarChar).Value = TXTID_ART.Text


            Conex.Open()

            CMD.ExecuteNonQuery()

            Conex.Close()



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub TextBox_ARTICULO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_DESCRIPCION.KeyPress, TextBox_ARTICULO.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TextBox_DESCRIPCION.Focus()

        End If

    End Sub

    Private Sub TextBox_DESCRIPCION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_PRECIO.KeyPress, TextBox_DESCRIPCION.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TextBox_PRECIO.Focus()
        End If

    End Sub

    Private Sub TextBox_PRECIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_TIPO.KeyPress, TextBox_PRECIO.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TextBox_TIPO.Focus()

        End If

    End Sub

    Private Sub TextBox_TIPO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button1.KeyPress, TextBox_TIPO.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Button1.Focus()

        End If

    End Sub

    Sub VISTA_DE_DATOS1()

        Try

            Dim da As New SqlDataAdapter(" 

SELECT ID_ARTICULO AS 'CODIGO', ARTICULO AS 'DESCRIPCION',  PRECIO AS ' PRECIO' FROM ARTICULOS

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Registrar_Articulo()
        Call VISTA_DE_DATOS1()
        Call LIMPIAR()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call VISTA_DE_DATOS1()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        F_INVENTARIO.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

            TXTID_ART.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value()
            TextBox_ARTICULO.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value()
            TextBox_DESCRIPCION.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value()
            TextBox_PRECIO.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value()
            TextBox_TIPO.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(4).Value()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BTNMODIFICAR_Click(sender As Object, e As EventArgs) Handles BTNMODIFICAR.Click
        Call Modificar_Articulo()
        Call VISTA_DE_DATOS1()
        Call LIMPIAR()


    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        Call ELIMINAR_ARTICULOS()
        Call LIMPIAR()
        Call VISTA_DE_DATOS1()

    End Sub
End Class