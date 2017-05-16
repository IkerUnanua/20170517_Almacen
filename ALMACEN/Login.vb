Public Class Login
    Dim booleanoFalse As Boolean = False
    Dim booleanoTrue As Boolean = True
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Dim registrarse As New Registrarse
        registrarse.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("usuarios.txt")
        Dim stringReader As String
        Dim lines As String()
        Dim lines2 As String()

        'Bucle recorre fichero
        Do
            'Analizar cada una de las líneas
            stringReader = fileReader.ReadLine()
            lines = stringReader.Split(" ")
            Dim stringReader2 As String
            stringReader2 = fileReader.ReadLine()
            lines2 = stringReader2.Split(" ")
            If txtUsuario.Text = lines(1) AndAlso txtContraseña.Text = lines2(1) Then

                Dim juego As New Juego
                MsgBox("Bienvenido " & txtUsuario.Text & ". Disfrute del juego")
                juego.ShowDialog()
                Exit Do

            End If

        Loop Until fileReader.EndOfStream
        If txtUsuario.Text <> lines(1) AndAlso txtContraseña.Text <> lines2(1) Then
            MsgBox("Sentimos las molestias pero el usuario no esta registrado, puedes registrarte dándole al botón de registro =)")
        End If
        fileReader.Close()
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
        txtContraseña.PasswordChar = "*"
    End Sub

    Private Sub mostrarContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles mostrarContraseña.CheckedChanged
        If mostrarContraseña.Checked = True Then
            txtContraseña.PasswordChar = ""
        ElseIf mostrarContraseña.Checked = False Then
            txtContraseña.PasswordChar = "*"
        End If
    End Sub
End Class