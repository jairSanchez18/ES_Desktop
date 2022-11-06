Imports ES_Database

Public Class SolicitudPage
    Public cant As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id_profesor = LoginPage.id_profesor
        Dim id_inventario As Integer

        If SolicitudesClass.ValidarSolicitud(textcantidad.Text, cboequipo.Text) = True Then
            id_inventario = SolicitudesClass.VerProducto(cboequipo.Text)
            SolicitudesClass.InsertarSolicitud(id_profesor, id_inventario, cboequipo.Text, textcantidad.Text, textsalon.Text)
            MsgBox("La solicitud fue enviada correctamente")
        Else
            MsgBox("la cantidad es insuficiente en el inventario")
        End If

    End Sub

    Private Sub SolicitudPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class