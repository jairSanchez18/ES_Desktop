Imports ES_Database

Public Class AsistenciaPage
    Private Sub AsistenciaPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Asistenciadgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        salon.Text = "SALON: " + OpcionesPage.cbogrupo.Text
        Dim id_horario = OpcionesPage.id_horario
        Dim id_grupo = OpcionesPage.id_grupo
        Dim id_profesor = LoginPage.id_profesor
        Dim fecha = OpcionesPage.fechatxt

        Dim asistencia = AsistenciaClass.ListaAsistencia(id_horario, id_grupo, fecha, id_profesor)

        For i As Integer = 0 To asistencia.Count - 1
            Asistenciadgv.Rows.Add(asistencia(i).nombre, asistencia(i).apellido, asistencia(i).correo,
            asistencia(i).cedula, asistencia(i).asistencia, asistencia(i).porcentaje,
            asistencia(i).observaciones, "")
        Next
    End Sub
End Class