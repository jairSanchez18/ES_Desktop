Imports ES_Database

Public Class SolicitudPage
    Public cant As Integer
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboequipo.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id_profesor = LoginPage.id_profesor

        If SolicitudesClass.ValidarSolicitud(textcantidad.Text, cboequipo.Text) = True Then

            SolicitudesClass.InsertarSolicitud(id_profesor, cboequipo.Text, textcantidad.Text, textsalon.Text, textdia.Text)
            MsgBox("La solicitud fue enviada correctamente")
        Else
            MsgBox("la cantidad insuficiente en el inevntario")
        End If

    End Sub
End Class