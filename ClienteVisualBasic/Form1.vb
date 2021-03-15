Public Class Form1
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        MsgBox(servicio.Agregar(txtCodescuela.Text, txtEscuela.Text))
        dgvEscuela.DataSource = servicio.Listar.Tables(0)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        MsgBox(servicio.Actualizar(txtCodescuela, Text, txtEscuela.Text))
        dgvEscuela.DataSource = servicio.Listar.Tables(0)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvEscuela.DataSource = servicio.Buscar(txtEscuela.Text).Tables(0)
    End Sub
End Class
