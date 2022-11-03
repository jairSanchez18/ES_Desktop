﻿Imports ES_Database

Public Class PerfilPage
    'RECIBO EL ID DE LA PAGINA DE LOGIN'
    Dim id_profesor = LoginPage.id_profesor
    'RECIBO UNA LISTA CON TODOS LOS DATOS DEL USUARIO'
    Dim ListaData = PerfilClass.DatosUserPerfil(id_profesor)
    Dim idP As Integer = ListaData(0)

    Private Sub PerfilPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'USO LA LISTA PARA ASIGAR LOS DATOS A LOS TXT'
        txtced.Text = ListaData(1)
        txtnom.Text = ListaData(2)
        txtape.Text = ListaData(3)
        txtfacu.Text = ListaData(4)
        txtdirec.Text = ListaData(5)
        txttel.Text = ListaData(6)
        txtcorreo.Text = ListaData(7)
    End Sub

    Private Sub UpdatePerfil_Click(sender As Object, e As EventArgs) Handles UpdatePerfil.Click

        If txtnom.Text = "" Then
            MsgBox("El campo nombre esta vacio")
        ElseIf txtape.Text = "" Then
            MsgBox("El campo apellido esta vacio")
        ElseIf txtfacu.Text = "" Then
            MsgBox("El campo facultad esta vacio")
        ElseIf txtdirec.Text = "" Then
            MsgBox("El campo direccion esta vacio")
        ElseIf txttel.Text = "" Then
            MsgBox("El campo telefono esta vacio")
        Else
            PerfilClass.ActualizarDatos(idP, txtced.Text, txtnom.Text, txtape.Text, txtfacu.Text, txtdirec.Text, txttel.Text, txtcorreo.Text)
            MsgBox("Los datos fueron actualizados")
        End If

    End Sub

    Private Sub UpdatePass_Click(sender As Object, e As EventArgs) Handles UpdatePass.Click

        'Valido la contrasena actual del usuario'
        If PerfilClass.ValidarContraseña(txtpass.Text) Then
        Else
            MsgBox("La contraseña actual es incorrecta")
        End If

        'TOMO EN CUENTA QUE EL CAMPO DE LA CONTRASENA ACTUAL NO ESTE VACIO'
        If txtpass.Text = ("") Then
            MsgBox("Debe introducir su contraseña actual para cambiarla")
        End If

        'VALIDO QUE LAS CONTRASENA NUEVAS SEAN IGUALES'
        If txtpassnew.Text = (txtpassnew2.Text) Then
            'AQUI SE LLAMA  AL UPDATE Y SE LE ENVIA EL NUEVO DATO DESDE TXTPASSNEW2.TEXT'
            PerfilClass.ActualizarPass(id_profesor, txtpassnew.Text)
        Else
            MsgBox("Las contraseñas nuevas no son iguales")
        End If

    End Sub
End Class