Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class F_INVENTARIO
    'Private dv As New DataView

    Dim adapt As New SqlDataAdapter

    'Dim ds As New DataSet

    Dim tabla As DataTable

    Public connex As String = "Data Source=DESKTOP-T75D7KR;Initial Catalog=SISTEMA_DE_CLIENTES;Integrated Security=True"
    Sub AGREGAR()
        Try

            Dim Conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEX").ConnectionString)
            Dim CMD As New SqlCommand("AGREGAR", Conex)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.Add("@ARTICULO", SqlDbType.VarChar).Value = TextBox_ARTICULO.Text

            CMD.Parameters.Add("@ALMACEN", SqlDbType.VarChar).Value = TextBox_ALMACEN.Text

            CMD.Parameters.Add("@CANTIDAD", SqlDbType.VarChar).Value = TextBox_CANTIDAD.Text


            Conex.Open()

            CMD.ExecuteNonQuery()

            Conex.Close()



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Sub LIMPIAR()
        Try


            TextBox_ARTICULO.Clear()
            TextBox_ALMACEN.Clear()
            TextBox_CANTIDAD.Clear()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Sub VISTA_DE_DATOS()
        Try

            Dim da As New SqlDataAdapter(" 
select ARTICULO AS 'ARTICULO', ALMACEN AS 'ALMACEN', CANTIDAD AS 'CANTIDAD' from INVENTARIO
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

    Private Sub TextBox_ARTICULO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ALMACEN.KeyPress, TextBox_ARTICULO.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TextBox_ALMACEN.Focus()




        End If


    End Sub
    Private Sub TextBox_ALMACEN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_CANTIDAD.KeyPress, TextBox_ALMACEN.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TextBox_CANTIDAD.Focus()




        End If


    End Sub
    Private Sub TextBox_CANTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BTNAGREGAR.KeyPress, TextBox_CANTIDAD.KeyPress

        If Asc(e.KeyChar) = 13 Then
            BTNAGREGAR.Focus()




        End If


    End Sub



    Private Sub B_MENU_Click(sender As Object, e As EventArgs) Handles B_MENU.Click
        F_MENU.Show()
        Me.Hide()
        Call LIMPIAR()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNAGREGAR.Click
        Call AGREGAR()
        Call VISTA_DE_DATOS()
        Call LIMPIAR()



    End Sub

    Private Sub BTNFACTURA_Click(sender As Object, e As EventArgs) Handles BTNFACTURA.Click
        F_FACTURAR.Show()
        Me.Hide()

    End Sub
End Class