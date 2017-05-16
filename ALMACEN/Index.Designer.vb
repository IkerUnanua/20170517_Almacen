<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(index))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.btnInstrucciones = New System.Windows.Forms.Button()
        Me.btnAdministrador = New System.Windows.Forms.Button()
        Me.btnRanking = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'btnJugar
        '
        Me.btnJugar.BackColor = System.Drawing.Color.ForestGreen
        resources.ApplyResources(Me.btnJugar, "btnJugar")
        Me.btnJugar.ForeColor = System.Drawing.Color.White
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.UseVisualStyleBackColor = False
        '
        'btnInstrucciones
        '
        Me.btnInstrucciones.BackColor = System.Drawing.SystemColors.ActiveCaption
        resources.ApplyResources(Me.btnInstrucciones, "btnInstrucciones")
        Me.btnInstrucciones.Name = "btnInstrucciones"
        Me.btnInstrucciones.UseVisualStyleBackColor = False
        '
        'btnAdministrador
        '
        Me.btnAdministrador.BackColor = System.Drawing.Color.DarkSlateBlue
        resources.ApplyResources(Me.btnAdministrador, "btnAdministrador")
        Me.btnAdministrador.ForeColor = System.Drawing.Color.White
        Me.btnAdministrador.Name = "btnAdministrador"
        Me.btnAdministrador.UseVisualStyleBackColor = False
        '
        'btnRanking
        '
        Me.btnRanking.BackColor = System.Drawing.SystemColors.ActiveCaption
        resources.ApplyResources(Me.btnRanking, "btnRanking")
        Me.btnRanking.Name = "btnRanking"
        Me.btnRanking.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'index
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRanking)
        Me.Controls.Add(Me.btnAdministrador)
        Me.Controls.Add(Me.btnInstrucciones)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "index"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnJugar As Button
    Friend WithEvents btnInstrucciones As Button
    Friend WithEvents btnAdministrador As Button
    Friend WithEvents btnRanking As Button
    Friend WithEvents btnSalir As Button
End Class
