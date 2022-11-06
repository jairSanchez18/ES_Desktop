Imports ES_Database

Public Class AsistenciaPage

    Dim ListaData1 = AsistenciaClass.CargarCombobox()
    Dim ListaData2 = AsistenciaClass.CargarLista()
    Dim guardar = "Guardar"
    Dim acumulador = ListaData2.lenght

    Private Sub AsistenciaPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            ComboBox1.Items.Add(ListaData1(0))

            For index As Integer = 0 To acumulador

                AsistenciaGrid(0, acumulador).Value = ListaData2(0)
                AsistenciaGrid(1, acumulador).Value = ListaData2(1)
                AsistenciaGrid(2, acumulador).Value = ListaData2(2)
                AsistenciaGrid(3, acumulador).Value = ListaData2(3)
                AsistenciaGrid(4, acumulador).Value = ListaData2(4)
                AsistenciaGrid(5, acumulador).Value = ListaData2(5)
                AsistenciaGrid(6, acumulador).Value = ListaData2(6)

                'BOTÓN DE GUARDAR'
                AsistenciaGrid(7, acumulador).Value = guardar

                AsistenciaGrid.Rows.Add()

            Next





        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub AsistenciaGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AsistenciaGrid.CellContentClick


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class