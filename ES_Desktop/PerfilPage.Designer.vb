<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerfilPage
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtape = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtced = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfacu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdirec = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.UpdatePerfil = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtpassnew = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtpassnew2 = New System.Windows.Forms.TextBox()
        Me.UpdatePass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(213, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(471, 42)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "BIENVENIDO A SU PERFIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(26, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 24)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nombre"
        '
        'txtnom
        '
        Me.txtnom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnom.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtnom.Location = New System.Drawing.Point(26, 148)
        Me.txtnom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(178, 31)
        Me.txtnom.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(213, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 24)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Apellido"
        '
        'txtape
        '
        Me.txtape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtape.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtape.Location = New System.Drawing.Point(213, 148)
        Me.txtape.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtape.Name = "txtape"
        Me.txtape.Size = New System.Drawing.Size(178, 31)
        Me.txtape.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(400, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 24)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Cedula"
        '
        'txtced
        '
        Me.txtced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtced.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtced.Location = New System.Drawing.Point(400, 148)
        Me.txtced.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtced.Name = "txtced"
        Me.txtced.Size = New System.Drawing.Size(178, 31)
        Me.txtced.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(587, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 24)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Facultad"
        '
        'txtfacu
        '
        Me.txtfacu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfacu.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtfacu.Location = New System.Drawing.Point(587, 148)
        Me.txtfacu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtfacu.Name = "txtfacu"
        Me.txtfacu.Size = New System.Drawing.Size(178, 31)
        Me.txtfacu.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(26, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 24)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Direccion"
        '
        'txtdirec
        '
        Me.txtdirec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdirec.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtdirec.Location = New System.Drawing.Point(26, 232)
        Me.txtdirec.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdirec.Name = "txtdirec"
        Me.txtdirec.Size = New System.Drawing.Size(178, 31)
        Me.txtdirec.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(213, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 24)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Telefono"
        '
        'txttel
        '
        Me.txttel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttel.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txttel.Location = New System.Drawing.Point(213, 232)
        Me.txttel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(178, 31)
        Me.txttel.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(400, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 24)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Correo electornico"
        '
        'txtcorreo
        '
        Me.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcorreo.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtcorreo.Location = New System.Drawing.Point(400, 229)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(178, 31)
        Me.txtcorreo.TabIndex = 37
        '
        'UpdatePerfil
        '
        Me.UpdatePerfil.BackColor = System.Drawing.Color.Black
        Me.UpdatePerfil.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpdatePerfil.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.UpdatePerfil.Location = New System.Drawing.Point(16, 280)
        Me.UpdatePerfil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UpdatePerfil.Name = "UpdatePerfil"
        Me.UpdatePerfil.Size = New System.Drawing.Size(775, 43)
        Me.UpdatePerfil.TabIndex = 41
        Me.UpdatePerfil.Text = "Guardar informacion de perfil"
        Me.UpdatePerfil.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(26, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 24)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Contraseña actual"
        '
        'txtpass
        '
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpass.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtpass.Location = New System.Drawing.Point(26, 409)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(178, 31)
        Me.txtpass.TabIndex = 42
        Me.txtpass.UseSystemPasswordChar = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(321, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(189, 24)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Contraseña nueva"
        '
        'txtpassnew
        '
        Me.txtpassnew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassnew.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtpassnew.Location = New System.Drawing.Point(321, 409)
        Me.txtpassnew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpassnew.Name = "txtpassnew"
        Me.txtpassnew.Size = New System.Drawing.Size(178, 31)
        Me.txtpassnew.TabIndex = 44
        Me.txtpassnew.UseSystemPasswordChar = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(610, 367)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(197, 24)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Repetir contraseña"
        '
        'txtpassnew2
        '
        Me.txtpassnew2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassnew2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtpassnew2.Location = New System.Drawing.Point(610, 409)
        Me.txtpassnew2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpassnew2.Name = "txtpassnew2"
        Me.txtpassnew2.Size = New System.Drawing.Size(178, 31)
        Me.txtpassnew2.TabIndex = 46
        Me.txtpassnew2.UseSystemPasswordChar = True
        '
        'UpdatePass
        '
        Me.UpdatePass.BackColor = System.Drawing.Color.Black
        Me.UpdatePass.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpdatePass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.UpdatePass.Location = New System.Drawing.Point(16, 472)
        Me.UpdatePass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UpdatePass.Name = "UpdatePass"
        Me.UpdatePass.Size = New System.Drawing.Size(775, 43)
        Me.UpdatePass.TabIndex = 48
        Me.UpdatePass.Text = "Guardar contraseña"
        Me.UpdatePass.UseVisualStyleBackColor = False
        '
        'PerfilPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(823, 549)
        Me.Controls.Add(Me.UpdatePass)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtpassnew2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtpassnew)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.UpdatePerfil)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdirec)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtfacu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtced)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtape)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnom)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PerfilPage"
        Me.Text = "Perfil de usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtape As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtced As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtfacu As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdirec As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txttel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents UpdatePerfil As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtpassnew As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtpassnew2 As TextBox
    Friend WithEvents UpdatePass As Button
End Class
