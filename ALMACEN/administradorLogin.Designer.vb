<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administradorLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administradorLogin))
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.txtAdmin = New System.Windows.Forms.TextBox()
        Me.lblContraseñaAdmin = New System.Windows.Forms.Label()
        Me.txtContraseñaAdmin = New System.Windows.Forms.TextBox()
        Me.btnEntrarAdmin = New System.Windows.Forms.Button()
        Me.MostrarContraseña = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Location = New System.Drawing.Point(28, 72)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(150, 13)
        Me.lblAdmin.TabIndex = 0
        Me.lblAdmin.Text = "USUARIO ADMINISTRADOR"
        '
        'txtAdmin
        '
        Me.txtAdmin.Location = New System.Drawing.Point(184, 69)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.Size = New System.Drawing.Size(213, 20)
        Me.txtAdmin.TabIndex = 1
        '
        'lblContraseñaAdmin
        '
        Me.lblContraseñaAdmin.AutoSize = True
        Me.lblContraseñaAdmin.Location = New System.Drawing.Point(28, 112)
        Me.lblContraseñaAdmin.Name = "lblContraseñaAdmin"
        Me.lblContraseñaAdmin.Size = New System.Drawing.Size(81, 13)
        Me.lblContraseñaAdmin.TabIndex = 2
        Me.lblContraseñaAdmin.Text = "CONTRASEÑA"
        '
        'txtContraseñaAdmin
        '
        Me.txtContraseñaAdmin.Location = New System.Drawing.Point(184, 110)
        Me.txtContraseñaAdmin.Name = "txtContraseñaAdmin"
        Me.txtContraseñaAdmin.Size = New System.Drawing.Size(213, 20)
        Me.txtContraseñaAdmin.TabIndex = 3
        '
        'btnEntrarAdmin
        '
        Me.btnEntrarAdmin.Location = New System.Drawing.Point(34, 172)
        Me.btnEntrarAdmin.Name = "btnEntrarAdmin"
        Me.btnEntrarAdmin.Size = New System.Drawing.Size(362, 49)
        Me.btnEntrarAdmin.TabIndex = 4
        Me.btnEntrarAdmin.Text = "ACCEDER"
        Me.btnEntrarAdmin.UseVisualStyleBackColor = True
        '
        'MostrarContraseña
        '
        Me.MostrarContraseña.AutoSize = True
        Me.MostrarContraseña.Location = New System.Drawing.Point(184, 136)
        Me.MostrarContraseña.Name = "MostrarContraseña"
        Me.MostrarContraseña.Size = New System.Drawing.Size(117, 17)
        Me.MostrarContraseña.TabIndex = 5
        Me.MostrarContraseña.Text = "Mostrar contraseña"
        Me.MostrarContraseña.UseVisualStyleBackColor = True
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 255)
        Me.Controls.Add(Me.MostrarContraseña)
        Me.Controls.Add(Me.btnEntrarAdmin)
        Me.Controls.Add(Me.txtContraseñaAdmin)
        Me.Controls.Add(Me.lblContraseñaAdmin)
        Me.Controls.Add(Me.txtAdmin)
        Me.Controls.Add(Me.lblAdmin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Administrador"
        Me.Text = "Administrador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdmin As Label
    Friend WithEvents txtAdmin As TextBox
    Friend WithEvents lblContraseñaAdmin As Label
    Friend WithEvents txtContraseñaAdmin As TextBox
    Friend WithEvents btnEntrarAdmin As Button
    Friend WithEvents MostrarContraseña As CheckBox
End Class
