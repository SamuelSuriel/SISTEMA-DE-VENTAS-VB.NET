Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Consulta

    Dim StrCn = "Data Source=DESKTOP-T75D7KR;Initial Catalog=SISTEMA_DE_CLIENTES;Integrated Security=True"

    Dim Cn As New SqlConnection(StrCn)

    Dim Da As New SqlDataAdapter

    Dim Cmd As New SqlCommand

    Dim Dt As DataTable

    Private Sub Consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If CheckBox_Vertodos.Checked = True Then

            LlamarDatos("SELECT * FROM SISTEMA_DE_CLIENTES")

            Dt = New DataTable

            Da.Fill(Dt)

            DataGridView1.DataSource = Dt

            TextBox1.Enabled = False

        End If

    End Sub
    Public Function LlamarDatos(ByVal Consulta As String)

        With Cmd

            .CommandType = CommandType.Text

            .CommandText = Consulta

            .Connection = Cn

        End With

        Da.SelectCommand = Cmd

#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

    Private Sub CheckBox_Vertodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox_Vertodos.CheckedChanged

        If Not CheckBox_Vertodos.Checked Then

            TextBox1.Enabled = True

            TextBox1.Text = ""

        Else

            TextBox1.Text = ""

            TextBox1.Enabled = False

        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        If Rbtn_Codigo.Checked = True Then

            LlamarDatos("SELECT * FROM SISTEMA_DE_CLIENTES Where Codigo Like '%" & TextBox1.Text & "%'")

            Dt = New DataTable

            Da.Fill(Dt)

            DataGridView1.DataSource = Dt

        End If

        If Rbtn_Nombre.Checked = True Then

            LlamarDatos("SELECT * FROM SISTEMA_DE_CLIENTES Where Nombre Like '%" & TextBox1.Text & "%'")

            Dt = New DataTable

            Da.Fill(Dt)

            DataGridView1.DataSource = Dt

        End If

        If Rbtn_Cedula.Checked = True Then

            LlamarDatos("SELECT * FROM SISTEMA_DE_CLIENTES Where Cedula Like '%" & TextBox1.Text & "%'")

            Dt = New DataTable

            Da.Fill(Dt)

            DataGridView1.DataSource = Dt

        End If

    End Sub



End Class