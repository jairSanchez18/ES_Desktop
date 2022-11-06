Imports System.Data
Imports MySql.Data.MySqlClient


Public Class AsistenciaClass

    Public Shared Function CargarLista() As List(Of String)

        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String



        Try

            'SE REALIZA LA CONEXION CON LA BASE DE DATOS'
            myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=;" _
            & "database=proyecto_ds7"



            oConexion.ConnectionString = myConnectionString

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()


            'PROCEDEMOS A HACER EL SELECT EN LA TABLA DE ESTUDIANTES'

            sSql = "SELECT * FROM estudiante a INNER JOIN lista_asist b on a.id = b.id "


            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'

            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)


            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "estudiante")

            Dim nombre = "a"
            Dim ListaData As New List(Of String)

            For index As Integer = 1 To 100000

                If nombre <> String.Empty Then


                    nombre = oDataSet.Tables("estudiante").Rows(0).Item(1).ToString
                    Dim apellido = oDataSet.Tables("estudiante").Rows(0).Item(2).ToString
                    Dim cedula = oDataSet.Tables("estudiante").Rows(0).Item(3).ToString
                    Dim correo = oDataSet.Tables("estudiante").Rows(0).Item(6).ToString
                    Dim asistencia = oDataSet.Tables("estudiante").Rows(0).Item("asistencia").ToString
                    Dim porcentaje = oDataSet.Tables("estudiante").Rows(0).Item("porcentaje").ToString
                    Dim observaciones = oDataSet.Tables("estudiante").Rows(0).Item("observaciones").ToString


                    ListaData.Add(nombre)
                    ListaData.Add(apellido)
                    ListaData.Add(correo)
                    ListaData.Add(cedula)
                    ListaData.Add(asistencia)
                    ListaData.Add(porcentaje)
                    ListaData.Add(observaciones)

                Else
                    nombre = ""
                    Exit For

                End If

            Next


            Return ListaData


        Catch ex As Exception
            MsgBox(ex.Message)
            oConexion.Close()


        End Try



    End Function

    Public Shared Function CargarCombobox() As List(Of String)


        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet


        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim myConnectionString As String



        Try

            'SE REALIZA LA CONEXION CON LA BASE DE DATOS'
            myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=;" _
            & "database=proyecto_ds7"



            oConexion.ConnectionString = myConnectionString

            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()


            'PROCEDEMOS A HACER EL SELECT EN LA TABLA DE SALONES'
            sSql = " SELECT salon FROM salones "

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "salones")


            Dim salones = oDataSet.Tables("salones").Rows(0).Item(0).ToString

            Dim ListaData As New List(Of String)
            ListaData.Add(salones)
            Return ListaData



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Function



End Class
