Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class LOBARTICULOS

    'Private dv As New DataView
    Dim adapt As New SqlDataAdapter
    'Dim ds As New DataSet
    Dim tabla As DataTable
    Public connex As String = "Data Source=DESKTOP-T75D7KR;Initial Catalog=SISTEMA_DE_CLIENTES;Integrated Security=True"

    Private Sub LOBARTICULO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call VISTA_DE_DATOS2()


    End Sub

    Sub VISTA_DE_DATOS2()


        Try



            Dim da As New SqlDataAdapter(" 

SELECT ID_ARTICULO AS 'CODIGO', ARTICULO AS 'DESCRIPCION',  PRECIO AS ' PRECIO' FROM ARTICULOS

", connex)



            Dim ds As New DataSet

            Dim dv As New DataView

            da.Fill(ds)

            dv.Table = ds.Tables(0)

            DataGridView1.DataSource = dv

            DataGridView1.DataSource = dv




        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            F_FACTURAR.TXTCOD_ART.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value()
            F_FACTURAR.TXTDESCRIP.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value()
            Me.Close()




        Catch ex As Exception

        End Try
    End Sub
End Class




