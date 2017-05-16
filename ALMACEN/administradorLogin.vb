Public Class administradorLogin


    Private Sub btnEntrarAdmin_Click(sender As Object, e As EventArgs) Handles btnEntrarAdmin.Click
        If txtAdmin.Text = "miriam" AndAlso txtContraseñaAdmin.Text = "miriam" Then
            MsgBox("Bienvenida Miriam")
            Dim administrador As New Administrador
            administrador.ShowDialog()

        Else
            MsgBox("Sentimos las molestias pero usted no tiene permiso para entrar a modo administrador. Gracias por su compresión")
        End If
    End Sub

    Private Sub MostrarContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles MostrarContraseña.CheckedChanged
        If MostrarContraseña.Checked = True Then
            txtContraseñaAdmin.PasswordChar = ""
        ElseIf MostrarContraseña.Checked = False Then
            txtContraseñaAdmin.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtContraseñaAdmin_TextChanged(sender As Object, e As EventArgs) Handles txtContraseñaAdmin.TextChanged
        txtContraseñaAdmin.PasswordChar = "*"
    End Sub
End Class