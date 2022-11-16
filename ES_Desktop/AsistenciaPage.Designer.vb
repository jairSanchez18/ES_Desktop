<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsistenciaPage
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
        Me.Asistenciadgv = New System.Windows.Forms.DataGridView()
        Me.NombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsistenciaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuardarColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salon = New System.Windows.Forms.Label()
        CType(Me.Asistenciadgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(203, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 33)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "LISTA DE ASISTENCIA"
        '
        'Asistenciadgv
        '
        Me.Asistenciadgv.AllowUserToAddRows = False
        Me.Asistenciadgv.AllowUserToDeleteRows = False
        Me.Asistenciadgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Asistenciadgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreColumn, Me.ApellidoColumn, Me.CorreoColumn, Me.CedulaColumn, Me.AsistenciaColumn, Me.PorcentajeColumn, Me.ObservacionesColumn, Me.GuardarColumn})
        Me.Asistenciadgv.Location = New System.Drawing.Point(12, 126)
        Me.Asistenciadgv.Name = "Asistenciadgv"
        Me.Asistenciadgv.ReadOnly = True
        Me.Asistenciadgv.RowHeadersVisible = False
        Me.Asistenciadgv.RowTemplate.Height = 25
        Me.Asistenciadgv.Size = New System.Drawing.Size(696, 235)
        Me.Asistenciadgv.TabIndex = 20
        '
        'NombreColumn
        '
        Me.NombreColumn.HeaderText = "Nombre"
        Me.NombreColumn.Name = "NombreColumn"
        Me.NombreColumn.ReadOnly = True
        '
        'ApellidoColumn
        '
        Me.ApellidoColumn.HeaderText = "Apellido"
        Me.ApellidoColumn.Name = "ApellidoColumn"
        Me.ApellidoColumn.ReadOnly = True
        '
        'CorreoColumn
        '
        Me.CorreoColumn.HeaderText = "Correo"
        Me.CorreoColumn.Name = "CorreoColumn"
        Me.CorreoColumn.ReadOnly = True
        '
        'CedulaColumn
        '
        Me.CedulaColumn.HeaderText = "Cedula"
        Me.CedulaColumn.Name = "CedulaColumn"
        Me.CedulaColumn.ReadOnly = True
        '
        'AsistenciaColumn
        '
        Me.AsistenciaColumn.HeaderText = "Asistencia"
        Me.AsistenciaColumn.Name = "AsistenciaColumn"
        Me.AsistenciaColumn.ReadOnly = True
        '
        'PorcentajeColumn
        '
        Me.PorcentajeColumn.HeaderText = "Porcentaje"
        Me.PorcentajeColumn.Name = "PorcentajeColumn"
        Me.PorcentajeColumn.ReadOnly = True
        '
        'ObservacionesColumn
        '
        Me.ObservacionesColumn.HeaderText = "Observaciones"
        Me.ObservacionesColumn.Name = "ObservacionesColumn"
        Me.ObservacionesColumn.ReadOnly = True
        '
        'GuardarColumn
        '
        Me.GuardarColumn.HeaderText = "Guardar"
        Me.GuardarColumn.Name = "GuardarColumn"
        Me.GuardarColumn.ReadOnly = True
        '
        'salon
        '
        Me.salon.AutoSize = True
        Me.salon.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.salon.Location = New System.Drawing.Point(12, 83)
        Me.salon.Name = "salon"
        Me.salon.Size = New System.Drawing.Size(167, 23)
        Me.salon.TabIndex = 21
        Me.salon.Text = "SALON: #SALON"
        '
        'AsistenciaPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(720, 412)
        Me.Controls.Add(Me.salon)
        Me.Controls.Add(Me.Asistenciadgv)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AsistenciaPage"
        Me.Text = "Pagina de asistencias"
        CType(Me.Asistenciadgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Asistenciadgv As DataGridView
    Friend WithEvents NombreColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaColumn As DataGridViewTextBoxColumn
    Friend WithEvents AsistenciaColumn As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesColumn As DataGridViewTextBoxColumn
    Friend WithEvents GuardarColumn As DataGridViewTextBoxColumn
    Friend WithEvents salon As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
