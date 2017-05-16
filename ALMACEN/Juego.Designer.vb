<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Juego
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Juego))
        Me.pCarrito = New System.Windows.Forms.PictureBox()
        Me.lstPedidos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.lstAlmacen = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.pCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pCarrito
        '
        Me.pCarrito.Image = CType(resources.GetObject("pCarrito.Image"), System.Drawing.Image)
        Me.pCarrito.Location = New System.Drawing.Point(474, 277)
        Me.pCarrito.Name = "pCarrito"
        Me.pCarrito.Size = New System.Drawing.Size(274, 198)
        Me.pCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pCarrito.TabIndex = 11
        Me.pCarrito.TabStop = False
        Me.pCarrito.Visible = False
        '
        'lstPedidos
        '
        Me.lstPedidos.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lstPedidos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPedidos.FormattingEnabled = True
        Me.lstPedidos.ItemHeight = 17
        Me.lstPedidos.Location = New System.Drawing.Point(628, 61)
        Me.lstPedidos.Name = "lstPedidos"
        Me.lstPedidos.Size = New System.Drawing.Size(120, 140)
        Me.lstPedidos.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(660, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Pedidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(403, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(417, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Por favor arrastre los paquetes de tus pedidos a el carrito para hacer el pedido." &
    " Gracias"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 63)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(213, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 63)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(69, 129)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 63)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(213, 129)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 63)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(69, 230)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 63)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(213, 230)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 63)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(69, 317)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(85, 63)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(213, 317)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(85, 63)
        Me.Button8.TabIndex = 22
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(69, 397)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(85, 63)
        Me.Button9.TabIndex = 23
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(213, 397)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(85, 63)
        Me.Button10.TabIndex = 24
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'btnComprar
        '
        Me.btnComprar.Location = New System.Drawing.Point(763, 103)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(75, 23)
        Me.btnComprar.TabIndex = 25
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'lstAlmacen
        '
        Me.lstAlmacen.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lstAlmacen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAlmacen.FormattingEnabled = True
        Me.lstAlmacen.ItemHeight = 17
        Me.lstAlmacen.Location = New System.Drawing.Point(406, 61)
        Me.lstAlmacen.Name = "lstAlmacen"
        Me.lstAlmacen.Size = New System.Drawing.Size(120, 140)
        Me.lstAlmacen.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(393, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Pedidos en el almacen"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(763, 132)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 28
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(850, 472)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstAlmacen)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPedidos)
        Me.Controls.Add(Me.pCarrito)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Juego"
        Me.Text = "Juego"
        CType(Me.pCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pCarrito As PictureBox
    Friend WithEvents lstPedidos As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents btnComprar As Button
    Friend WithEvents lstAlmacen As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnReset As Button
End Class
