Imports MySql.Data.MySqlClient
Imports System.Data

Public Class SolicitudesClass
    Public Shared Function InsertarSolicitud(id_profesor As String, cboequipo As String, txtcantidad As String, textsalon As String, txtdia As String) As Boolean
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim sw As Boolean = False
        Dim myConnectionString As String


        'TRY CATCH PARA VALIDAR CONEXION Y CONSULTAS'
        Try
            'SE REALIZA LA CONEXION CON LA BASE DE DATOS'
            myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=;" _
            & "database=proyecto_ds7"

            oConexion.ConnectionString = myConnectionString


            'PROCEDEMOS A HACER EL INSERT EN LA TABLA DE SOLICITUDES'

            sSql = "INSERT INTO solicitudes (id_profesor, id_inventario, equipo_solicitado , fecha_solicitud_pedido, fecha_solicitud_entrega, estado_solicitud,  salon) VALUES ( '" & id_profesor & "',   '" & txtcantidad & "','" & cboequipo & "'  , '" & txtdia & "' ,   CURDATE() , ' solicitado', '" & textsalon & "')"



            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "inventario")


            ' MsgBox("La solicitud fue enviada correctamente")


            ' End If

        Catch ex As Exception
            MsgBox(ex.Message)
            ' MsgBox("ERROR CANTIDAD INSUFICIENTE")
        End Try



        Return sw

    End Function


    Public Shared Function ValidarSolicitud(txtcantidad As String, cboequipo As String) As Boolean
        Dim oConexion As New MySqlConnection
        Dim oDataAdapter As New MySqlDataAdapter
        Dim oDataSet As New DataSet

        'CREACION DE CAMPOS PARA REALIZAR LAS CONSULTAS SQL'
        Dim sSql As String
        Dim sw As Boolean = False
        Dim myConnectionString As String


        'TRY CATCH PARA VALIDAR CONEXION Y CONSULTAS'
        Try
            'SE REALIZA LA CONEXION CON LA BASE DE DATOS'
            myConnectionString = "server=127.0.0.1;" _
            & "uid=root;" _
            & "pwd=;" _
            & "database=proyecto_ds7"

            oConexion.ConnectionString = myConnectionString

            'HACEMOS EL SELECT PARA OBTENER LA CANTIDAD DEL INVENTARIO'

            sSql = "SELECT cantidad  FROM inventario WHERE equipo = '" & cboequipo & "' "



            'NOS PERMITE ABRIR LA CONEXION'
            oConexion.Open()

            'NOS PERMITE REALIZAR LA CONSULTA CON LA CONEXION'
            oDataAdapter = New MySqlDataAdapter(sSql, oConexion)

            'LIMPIAMOS NUESTRO DATA SET EN CASO TENGA DATOS'
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "inventario")


            'IF PARA VALIDAR LA CANTIDAD DEL INVENTARIO'

            If oDataSet.Tables("inventario").Rows(0).Item(0) <= txtcantidad Then
                Return sw = True

            Else
                Return sw = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return sw

    End Function
End Class
