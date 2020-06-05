Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class LOBCLIENTES

    'Private dv As New DataView
    Dim adapt As New SqlDataAdapter
    'Dim ds As New DataSet
    Dim tabla As DataTable
    Public connex As String = "Data Source=DESKTOP-T75D7KR;Initial Catalog=SISTEMA_DE_CLIENTES;Integrated Security=True"

    Private Sub LOBCLIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call VISTA_DE_DATOS3()


    End Sub

    Sub VISTA_DE_DATOS3()


        Try



            Dim da As New SqlDataAdapter("

select ID_CLIENTE AS 'CODIGO', NOMBRE + APELLIDO aS 'NOMBRE', CEDULA AS 'CEDULA', TELEFONO AS 'TELEFONO', MEMBRESIA AS 'MEMBRESIA', ESTADO AS 'ESTADO', GENERO AS 'GENERO' from CLIENTES

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
            F_FACTURAR.TXTCOD_CLI.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value()
            F_FACTURAR.TXTCLIENTE.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value()
            Me.Close()







        Catch ex As Exception

        End Try
    End Sub

End Class