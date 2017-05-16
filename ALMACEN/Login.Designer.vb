<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mostrarContraseña = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(125, 126)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(107, 196)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(61, 13)
        Me.lblContraseña.TabIndex = 1
        Me.lblContraseña.Text = "Contraseña"
        '
        'btnAcceder
        '
        Me.btnAcceder.Location = New System.Drawing.Point(151, 307)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(75, 23)
        Me.btnAcceder.TabIndex = 2
        Me.btnAcceder.Text = "Acceder"
        Me.btnAcceder.UseVisualStyleBackColor = True
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.Location = New System.Drawing.Point(268, 307)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrarse.TabIndex = 3
        Me.btnRegistrarse.Text = "Registrarse"
        Me.btnRegistrarse.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(410, 332)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(198, 126)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 5
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(198, 196)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(100, 20)
        Me.txtContraseña.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(209, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Login"
        '
        'mostrarContraseña
        '
        Me.mostrarContraseña.AutoSize = True
        Me.mostrarContraseña.Location = New System.Drawing.Point(198, 222)
        Me.mostrarContraseña.Name = "mostrarContraseña"
        Me.mostrarContraseña.Size = New System.Drawing.Size(117, 17)
        Me.mostrarContraseña.TabIndex = 8
        Me.mostrarContraseña.Text = "Mostrar contraseña"
        Me.mostrarContraseña.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 364)
        Me.Controls.Add(Me.mostrarContraseña)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnRegistrarse)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblContraseña As Label
    Friend WithEvents btnAcceder As Button
    Friend WithEvents btnRegistrarse As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mostrarContraseña As CheckBox
End Class
