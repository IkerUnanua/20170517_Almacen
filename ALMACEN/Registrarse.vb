Imports System.IO

Public Class Registrarse
    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        If String.IsNullOrWhiteSpace(txtUsuario.Text) AndAlso String.IsNullOrWhiteSpace(txtContraseña.Text) Then

            MsgBox("Por favor rellene toda la información pedida para completar su registro. Gracias.")
        Else

            Dim usuario As New StreamWriter("usuarios.txt", True)
            'voy a la ultima linea
            If usuario.ToString.Contains(txtUsuario.Text) Then
                MsgBox("Lo sentimos pero ese usuario ya se encuentra registrado, por favor seleccione otro nombre para completar el registro.")
            Else
                usuario.WriteLine("Usuario: " + txtUsuario.Text)
                usuario.WriteLine("Contraseña: " + txtContraseña.Text)
                MsgBox("Usuario añadido")
                usuario.Close()
                Me.Close()
            End If

        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
        txtContraseña.PasswordChar = "*"
    End Sub

    Private Sub MostrarContraseñaRegistro_CheckedChanged(sender As Object, e As EventArgs) Handles MostrarContraseñaRegistro.CheckedChanged
        If MostrarContraseñaRegistro.Checked = True Then
            txtContraseña.PasswordChar = ""
        ElseIf MostrarContraseñaRegistro.Checked = False Then
            txtContraseña.PasswordChar = "*"
        End If
    End Sub
End Class