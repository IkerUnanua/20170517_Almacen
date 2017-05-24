<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class minijuego
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(minijuego))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPiedras = New System.Windows.Forms.Button()
        Me.btnTijeras = New System.Windows.Forms.Button()
        Me.btnPapel = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEmpezar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbx1 = New System.Windows.Forms.PictureBox()
        Me.pbx2 = New System.Windows.Forms.PictureBox()
        Me.pbx3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Piedra, papel y tijera. Adelante elige uno"
        '
        'btnPiedras
        '
        Me.btnPiedras.BackgroundImage = CType(resources.GetObject("btnPiedras.BackgroundImage"), System.Drawing.Image)
        Me.btnPiedras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPiedras.Location = New System.Drawing.Point(523, 107)
        Me.btnPiedras.Name = "btnPiedras"
        Me.btnPiedras.Size = New System.Drawing.Size(124, 102)
        Me.btnPiedras.TabIndex = 1
        Me.btnPiedras.UseVisualStyleBackColor = True
        '
        'btnTijeras
        '
        Me.btnTijeras.BackgroundImage = CType(resources.GetObject("btnTijeras.BackgroundImage"), System.Drawing.Image)
        Me.btnTijeras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTijeras.Location = New System.Drawing.Point(278, 107)
        Me.btnTijeras.Name = "btnTijeras"
        Me.btnTijeras.Size = New System.Drawing.Size(128, 102)
        Me.btnTijeras.TabIndex = 2
        Me.btnTijeras.UseVisualStyleBackColor = True
        '
        'btnPapel
        '
        Me.btnPapel.BackgroundImage = CType(resources.GetObject("btnPapel.BackgroundImage"), System.Drawing.Image)
        Me.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPapel.Location = New System.Drawing.Point(48, 107)
        Me.btnPapel.Name = "btnPapel"
        Me.btnPapel.Size = New System.Drawing.Size(117, 102)
        Me.btnPapel.TabIndex = 3
        Me.btnPapel.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(310, 389)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 230)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Este es el dios del juego, Podras vencerle?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Miguel de Unamusgo"
        '
        'btnEmpezar
        '
        Me.btnEmpezar.BackColor = System.Drawing.Color.Aquamarine
        Me.btnEmpezar.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpezar.Location = New System.Drawing.Point(248, 141)
        Me.btnEmpezar.Name = "btnEmpezar"
        Me.btnEmpezar.Size = New System.Drawing.Size(204, 68)
        Me.btnEmpezar.TabIndex = 8
        Me.btnEmpezar.Text = "Empezar Minijuego"
        Me.btnEmpezar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'pbx1
        '
        Me.pbx1.Image = CType(resources.GetObject("pbx1.Image"), System.Drawing.Image)
        Me.pbx1.Location = New System.Drawing.Point(278, 76)
        Me.pbx1.Name = "pbx1"
        Me.pbx1.Size = New System.Drawing.Size(159, 172)
        Me.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx1.TabIndex = 9
        Me.pbx1.TabStop = False
        '
        'pbx2
        '
        Me.pbx2.Image = CType(resources.GetObject("pbx2.Image"), System.Drawing.Image)
        Me.pbx2.Location = New System.Drawing.Point(278, 76)
        Me.pbx2.Name = "pbx2"
        Me.pbx2.Size = New System.Drawing.Size(159, 172)
        Me.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx2.TabIndex = 10
        Me.pbx2.TabStop = False
        '
        'pbx3
        '
        Me.pbx3.Image = CType(resources.GetObject("pbx3.Image"), System.Drawing.Image)
        Me.pbx3.Location = New System.Drawing.Point(278, 76)
        Me.pbx3.Name = "pbx3"
        Me.pbx3.Size = New System.Drawing.Size(159, 172)
        Me.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx3.TabIndex = 11
        Me.pbx3.TabStop = False
        '
        'minijuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 424)
        Me.Controls.Add(Me.pbx3)
        Me.Controls.Add(Me.pbx2)
        Me.Controls.Add(Me.pbx1)
        Me.Controls.Add(Me.btnEmpezar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPapel)
        Me.Controls.Add(Me.btnTijeras)
        Me.Controls.Add(Me.btnPiedras)
        Me.Controls.Add(Me.Label1)
        Me.Name = "minijuego"
        Me.Text = "minijuego"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnPiedras As Button
    Friend WithEvents btnTijeras As Button
    Friend WithEvents btnPapel As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEmpezar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pbx1 As PictureBox
    Friend WithEvents pbx2 As PictureBox
    Friend WithEvents pbx3 As PictureBox
End Class
