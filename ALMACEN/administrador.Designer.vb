<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrador))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.btnEnunciados = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnContraseñas = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMusica = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hola administradora"
        '
        'btnArticulos
        '
        Me.btnArticulos.Location = New System.Drawing.Point(542, 299)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(113, 23)
        Me.btnArticulos.TabIndex = 1
        Me.btnArticulos.Text = "Cambiar productos"
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'btnEnunciados
        '
        Me.btnEnunciados.Location = New System.Drawing.Point(137, 299)
        Me.btnEnunciados.Name = "btnEnunciados"
        Me.btnEnunciados.Size = New System.Drawing.Size(113, 23)
        Me.btnEnunciados.TabIndex = 2
        Me.btnEnunciados.Text = "Cambiar enunciados"
        Me.btnEnunciados.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(629, 53)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnInfo.TabIndex = 3
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnContraseñas
        '
        Me.btnContraseñas.Location = New System.Drawing.Point(68, 54)
        Me.btnContraseñas.Name = "btnContraseñas"
        Me.btnContraseñas.Size = New System.Drawing.Size(75, 23)
        Me.btnContraseñas.TabIndex = 4
        Me.btnContraseñas.Text = "Contraseñas"
        Me.btnContraseñas.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(352, 378)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(271, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(249, 231)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnMusica
        '
        Me.btnMusica.BackColor = System.Drawing.Color.LimeGreen
        Me.btnMusica.Location = New System.Drawing.Point(708, 372)
        Me.btnMusica.Name = "btnMusica"
        Me.btnMusica.Size = New System.Drawing.Size(39, 29)
        Me.btnMusica.TabIndex = 34
        Me.btnMusica.Text = "On"
        Me.btnMusica.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(695, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Música on/off"
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 413)
        Me.Controls.Add(Me.btnMusica)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnContraseñas)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnEnunciados)
        Me.Controls.Add(Me.btnArticulos)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Administrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnArticulos As Button
    Friend WithEvents btnEnunciados As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnContraseñas As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMusica As Button
    Friend WithEvents Label4 As Label
End Class
