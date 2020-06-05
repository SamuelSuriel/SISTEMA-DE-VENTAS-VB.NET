Public Class F_MENU
    Private Sub B_REGISTRAR_CLIENTE_Click(sender As Object, e As EventArgs) Handles B_REGISTRAR_CLIENTE.Click
        F_CLIENTE.Show()
        Me.Hide()


    End Sub

    Private Sub B_ARTICULO_Click(sender As Object, e As EventArgs) Handles B_ARTICULO.Click
        F_ARTICULO.Show()
        Me.Hide()


    End Sub

    Private Sub B_INVENTARIO_Click(sender As Object, e As EventArgs) Handles B_INVENTARIO.Click
        F_INVENTARIO.Show()
        Me.Hide()


    End Sub

    Private Sub B_FACTURACION_Click(sender As Object, e As EventArgs) Handles B_FACTURACION.Click
        F_FACTURAR.Show()
        Me.Hide()

    End Sub

    Private Sub B_REPORTE_Click(sender As Object, e As EventArgs) Handles B_REPORTE.Click
        F_REPORTE.Show()
        Me.Hide()


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub

End Class
