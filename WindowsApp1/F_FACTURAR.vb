Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class F_FACTURAR
    'Private dv As New DataView
    Dim adapt As New SqlDataAdapter
    'Dim ds As New DataSet
    Dim tabla As DataTable
    Public connex As String = "Data Source=DESKTOP-T75D7KR;Initial Catalog=SISTEMA_DE_CLIENTES;Integrated Security=True"


    Private Sub B_MENU_Click(sender As Object, e As EventArgs) Handles BTNREGRESAR.Click
        F_MENU.Show()
        Me.Hide()
        Call LIMPIAR()

    End Sub



    Sub Datos_Cliente()

        Try

            Dim Conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEX").ConnectionString)

            Conex.Open()

            Dim CMD As New SqlCommand("select * from Clientes where cliente = '" & TXTCLIENTE.Text & "'", Conex)

            Dim lector As SqlDataReader

            lector = CMD.ExecuteReader

            While (lector.Read)

                TXTCLIENTE.Text = (lector(1))

            End While

            Conex.Close()

        Catch ex As Exception

            ' MessageBox.Show(ex.Message)

        End Try
    End Sub

    Sub Calculos_Factura_Head()

        Try
            Dim Conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEX").ConnectionString)
            Conex.Open()
            Dim CMD As New SqlCommand("Select Sum(TOTAL) - Sum(ITBIS) 'SUBTOTAL',Sum(ITBIS) 'ITBIS',Sum(TOTAL) 'TOTAL' from FACTURAR where FACTURA ='" & TXTFACTURA.Text & "'", Conex)
            Dim lector As SqlDataReader
            lector = CMD.ExecuteReader
            While (lector.Read)

                TXTSUBTOT.Text = (lector(0))
                TXTITBIS.Text = (lector(1))
                TXTTOT.Text = (lector(2))

            End While
            Conex.Close()

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub


    Sub LIMPIAR()
        Try
            TXTCANTIDAD.Clear()
            TXTPRECIO.Clear()
            TXTSUBTOT.Clear()
            TXTITBIS.Clear()
            TXTTOT.Clear()
            TXTCOD_ART.Clear()
            TXTDESCRIP.Clear()
            TXTCOD_CLI.Clear()
            TXTCLIENTE.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Datos_Articulo()

        Try
            Dim Conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEX").ConnectionString)
            Conex.Open()
            Dim CMD As New SqlCommand("select * from ARTICULOS  where ARTICULO = '" & TXTCOD_ART.Text & "'", Conex)
            Dim lector As SqlDataReader
            lector = CMD.ExecuteReader
            While (lector.Read)

                TXTDESCRIP.Text = (lector(1))
                TXTPRECIO.Text = (lector(2))

            End While
            Conex.Close()

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub Datos_Articulo_Reversar_Linea()

        Try
            Dim Conex As New SqlConnection(ConfigurationManager.ConnectionStrings("CONEX").ConnectionString)
            Conex.Open()
            Dim CMD As New SqlCommand("Select ARTICULO, DESCRIPCION, CANTIDAD, PRECIO, ITBIS, TOTAL From FACTURAR  where FACTURA ='" & TXTFACTURA.Text & "'", Conex)
            Dim lector As SqlDataReader
            lector = CMD.ExecuteReader
            While (lector.Read)

                TXTCOD_ART.Text = (lector(0))
                TXTCANTIDAD.Text = (lector(2))

            End While
            Conex.Close()

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub Carga_datos_Facturar()

        Try
            Dim da As New SqlDataAdapter("Select DESCRIPCION,CANTIDAD, PRECIO,ITBIS,TOTAL From FACTURAR where FACTURA ='" & TXTFACTURA.Text & "'", connex)
            Dim ds As New DataSet
            Dim dv As New DataView
            da.Fill(ds)
            dv.Table = ds.Tables(0)
            DataGridView1.DataSource = dv

            '  DataGridView1.Columns(0).Width = 80
            ' DataGridView1.Columns(1).Width = 200

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TXTCANTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCANTIDAD.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True

        Else

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub BTNREPORTE_Click(sender As Object, e As EventArgs) Handles BTNREPORTE.Click
        F_REPORTE.Show()
        Me.Hide()
        Call LIMPIAR()

    End Sub

    Private Sub TXTDETALLE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPRECIO.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TXTPRECIO.Focus()

        End If
    End Sub

    Private Sub TXTPRECIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BTNGENERAR.KeyPress, TXTPRECIO.KeyPress

        If Asc(e.KeyChar) = 13 Then
            BTNGENERAR.Focus()

        End If
    End Sub

    Private Sub BTNGENERAR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BTNREGRESAR.KeyPress, BTNGENERAR.KeyPress

        If Asc(e.KeyChar) = 13 Then
            BTNREGRESAR.Focus()

        End If
    End Sub

    Private Sub TXTCANTIDAD_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTCANTIDAD.KeyDown
        If e.KeyCode = Keys.F10 Then
            LOBARTICULOS.Show()

        End If
    End Sub

    Private Sub TXTCOD_ART_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTCOD_ART.KeyDown
        If e.KeyCode = Keys.F10 Then
            LOBARTICULOS.Show()

        End If
    End Sub

    Private Sub TXTCOD_CLI_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTCOD_CLI.KeyDown
        If e.KeyCode = Keys.F10 Then
            LOBCLIENTES.Show()

        End If
    End Sub


    Sub Calculos_art()

        Try

            Dim Precio, ITBIS, Total, subtotal As Decimal

            Dim Cantidad As Integer



            Precio = CStr(TXTPRECIO.Text)

            Cantidad = CStr(TXTCANTIDAD.Text)



            subtotal = (Precio * Cantidad)

            TXTSUBTOT.Text = CStr(subtotal)



            ITBIS = subtotal * 0.18

            TXTITBIS.Text = CStr(ITBIS)



            Total = subtotal + ITBIS

            TXTTOT.Text = CStr(Total)


        Catch ex As Exception


        End Try

    End Sub

    Private Sub BTNGENERAR_Click(sender As Object, e As EventArgs) Handles BTNGENERAR.Click
        Call Calculos_art()
        Call Datos_Cliente()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

End Class