Imports System.IO

Public Class Administrador
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        Dim fichero As New StreamWriter("ficheros/articulos.txt")
        Dim articulos(9) As String
        For i = 0 To 9

            articulos(i) = InputBox("Que articulo desea introducir")
                If String.IsNullOrWhiteSpace(articulos(i)) = "" Then
                Exit Sub
            End If

    Next

        For i = 0 To articulos.Length - 1
            fichero.WriteLine("Articulo:" + articulos(i))
        Next
        fichero.Close()

    End Sub

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Spinning_Seal___GifSound, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Administrador_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Dim file As New StreamReader("ficheros/infoAdmin.txt")

        MsgBox(file.ReadToEnd())
        file.Close()
    End Sub

    Private Sub btnEnunciados_Click(sender As Object, e As EventArgs) Handles btnEnunciados.Click
        Dim file As New StreamWriter("ficheros/enunciados.txt")
        Dim cont As Integer = 0
        Dim articulo As String
        Dim cantidadStr As String
        Dim cantidad As Integer
        Dim esNumeroValido As Boolean = False
        Do
            cont = cont + 1
            articulo = InputBox("Por favor introduzca el " + cont.ToString + "º articulo")
            If articulo = "" Then
                MsgBox("Se ha terminado de introducir usuarios")
            Else
                Do

                    cantidadStr = InputBox("Cuanta cantidad desea?")
                    If String.IsNullOrWhiteSpace(cantidadStr) Then
                        Exit Sub
                    End If
                    If Not Integer.TryParse(cantidadStr, cantidad) Then
                        esNumeroValido = False
                        MsgBox("Error, número no válido")
                    Else
                        esNumeroValido = True
                    End If
                Loop Until esNumeroValido = True

                file.WriteLine(articulo + ";" + cantidadStr)
            End If
        Loop Until articulo = ""
        file.Close()
    End Sub

    Private Sub btnContraseñas_Click(sender As Object, e As EventArgs) Handles btnContraseñas.Click
        Dim file As New StreamReader("ficheros/usuarios.txt")

        MsgBox(file.ReadToEnd())
        file.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnMusica_Click(sender As Object, e As EventArgs) Handles btnMusica.Click
        If btnMusica.Text = "On" Then
            btnMusica.Text = "Off"
            btnMusica.BackColor = Color.Red
            My.Computer.Audio.Stop()
        ElseIf btnMusica.Text = "Off" Then
            btnMusica.Text = "On"
            My.Computer.Audio.Play(My.Resources.Spinning_Seal___GifSound, AudioPlayMode.BackgroundLoop)
            btnMusica.BackColor = Color.Green
        End If
    End Sub
End Class