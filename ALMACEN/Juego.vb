Imports System.IO

Public Class Juego
    Dim precio As Integer = 0
    Dim cantidadTotal As Integer = 0
    Dim contEnunciados As Integer = 0
    Dim lines2 As New List(Of String)
    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("ficheros/articulos.txt")
        Dim stringReader As String
        Dim lines As String()
        Dim cont As Integer = 0

        'Bucle recorre fichero
        Do

            'Analizar cada una de las líneas
            stringReader = fileReader.ReadLine()
            lines = stringReader.Split(":")
            Select Case cont
                Case 0
                    Button1.Text = lines(1)
                    tienda.Añadir(lines(1), 50)
                Case 1
                    Button2.Text = lines(1)
                    tienda.Añadir(lines(1), 50)
                Case 2
                    Button3.Text = lines(1)
                    tienda.Añadir(lines(1), 50)
                Case 3
                    Button4.Text = lines(1)
                    tienda.Añadir(lines(1), 50)
                Case 4
                    Button5.Text = lines(1)
                    tienda.Añadir(lines(1), 50)
                Case 5
                    Button6.Text = lines(1)
                    tienda.Añadir(lines(1), 50)
                Case 6
                    Button7.Text = lines(1)
                    tienda.Añadir(lines(1), 50)
                Case 7
                    Button8.Text = lines(1)
                    tienda.Añadir(lines(1), 50)
                Case 8
                    Button9.Text = lines(1)
                    tienda.Añadir(lines(1), 50)
                Case 9
                    Button10.Text = lines(1)
                    tienda.Añadir(lines(1), 50)
            End Select

            cont = cont + 1
            If cont = 10 Then
                fileReader.Close()
            End If
        Loop Until cont = 10

        Dim stock As String
        Dim nombre As String
        For i = 0 To tienda.Articulos.Count - 1
            nombre = tienda.Articulos(i).Nombre
            stock = tienda.Articulos(i).Stock
            lstAlmacen.Items.Add(stock + "-" + nombre)
        Next
        btnOtraPregunta.Enabled = False
        My.Computer.Audio.Play(My.Resources.Musica_electronica_para_juegos, AudioPlayMode.BackgroundLoop)
        Dim file As New StreamReader("ficheros/enunciados.txt")
        Dim stringReader2 As String
        Dim cont2 As Integer = 0

        Do
            stringReader2 = file.ReadLine()

            lines2.Add(stringReader2)
        Loop Until file.EndOfStream
        lblEnunciado.Text = lines2(cont2)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click
        Dim cantidadStr As String
        Dim esNumeroValido As Boolean = True
        Dim booleano2 As Boolean = True
        Dim cantidad As Integer
        Dim respuestaStr As String
        Dim respuesta As Integer
        Dim posArticulo As Integer = 0
        Dim boton As Button = TryCast(sender, Button)
        pCarrito.Visible = True
        'No se meten espacios en blanco o nada. Disculpen las molestias, estamos trabajando arduamente para solucionar el problema. Arkaitz esta hablando con sus contactos para solucionar el problema.
        Do
            cantidadStr = InputBox("Cuanta cantidad de " + boton.Text + " desea?")
            If String.IsNullOrWhiteSpace(cantidadStr) Then
                Exit Sub
            End If
            If Not Integer.TryParse(cantidadStr, cantidad) Then
                esNumeroValido = False
                MsgBox("Error, número no válido")
            Else
                esNumeroValido = True

                For i = 0 To tienda.Articulos.Count - 1
                    If boton.Text = tienda.Articulos(i).Nombre Then
                        posArticulo = i
                        If cantidad > tienda.Articulos(i).Stock Then
                            MsgBox("Error, cantidad mayor al stock")
                            esNumeroValido = False
                        End If
                        Exit For
                    End If

                Next
            End If
        Loop Until esNumeroValido = True


        Dim stock As Integer = 0
        If tienda.Articulos(posArticulo).Nombre = boton.Text Then
            lstPedidos.Items.Add(cantidadStr + "-" + boton.Text)
            stock = tienda.Articulos(posArticulo).Stock
            stock = stock - cantidad
            tienda.Articulos(posArticulo).Stock = stock
            cantidadTotal = cantidadTotal + cantidad

            Do

                respuestaStr = InputBox("¿Cuantos paquetes quedan en el articulo " + tienda.Articulos(posArticulo).Nombre + "?")

                If Not Integer.TryParse(respuestaStr, respuesta) Then
                    booleano2 = False
                    MsgBox("Error, número no válido")
                Else
                    booleano2 = True
                End If
            Loop Until booleano2 = True
            If respuesta = stock Then
                MsgBox("Enhorabuena crack! Has acertado, era justo esa cantidad la que queda en stock")
            Else

                MsgBox("Lo sentimos pero la cantidad que queda en stock de ese articulo es " + stock.ToString + ". Más suerte la próxima vez ;) ")
            End If
        End If



        btnComprar.Enabled = True
        btnOtraPregunta.Enabled = True
        boton.Enabled = False
        boton.BackColor = Color.Red
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        Dim comprarStr As String
        Dim comprar As Integer
        Dim booleano As Boolean = True
        Dim cantidadTotalStr As String
        contEnunciados = contEnunciados + 1
        Do
            comprarStr = InputBox("Cuanta cantidad de articulos has comprado amable señor/señora")
            If Not Integer.TryParse(comprarStr, comprar) Then
                booleano = False
                MsgBox("Error, número no válido")
            End If

        Loop Until booleano = True
        If comprar = cantidadTotal Then
            MsgBox("Muy bien, el número introducido es correcto")
        Else
            cantidadTotalStr = cantidadTotal
            MsgBox("Lo sentimos, la cantidad pedida es de " + cantidadTotalStr + " .Esperamos que tenga más suerte la próxima vez =)")
        End If

        lstAlmacen.Items.Clear()
        Dim stock As String
        Dim nombre As String
        For i = 0 To tienda.Articulos.Count - 1
            nombre = tienda.Articulos(i).Nombre
            stock = tienda.Articulos(i).Stock
            lstAlmacen.Items.Add(stock + "-" + nombre)
        Next
        btnComprar.Enabled = False
        If lines2.Count >= contEnunciados Then

            lblEnunciado.Text = lines2(contEnunciados)
        End If
        Button1.Enabled = False
        Button1.BackColor = Color.Blue
        Button2.Enabled = False
        Button2.BackColor = Color.Blue
        Button3.Enabled = False
        Button3.BackColor = Color.Blue
        Button4.Enabled = False
        Button4.BackColor = Color.Blue
        Button5.Enabled = False
        Button5.BackColor = Color.Blue
        Button6.Enabled = False
        Button6.BackColor = Color.Blue
        Button7.Enabled = False
        Button7.BackColor = Color.Blue
        Button8.Enabled = False
        Button8.BackColor = Color.Blue
        Button9.Enabled = False
        Button9.BackColor = Color.Blue
        Button10.Enabled = False
        Button10.BackColor = Color.Blue
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnOtraPregunta.Click
        pCarrito.Visible = False
        lstPedidos.Items.Clear()
        Button1.Enabled = True
        Button1.BackColor = Color.Beige
        Button2.Enabled = True
        Button2.BackColor = Color.Beige
        Button3.Enabled = True
        Button3.BackColor = Color.Beige
        Button4.Enabled = True
        Button4.BackColor = Color.Beige
        Button5.Enabled = True
        Button5.BackColor = Color.Beige
        Button6.Enabled = True
        Button6.BackColor = Color.Beige
        Button7.Enabled = True
        Button7.BackColor = Color.Beige
        Button8.Enabled = True
        Button8.BackColor = Color.Beige
        Button9.Enabled = True
        Button9.BackColor = Color.Beige
        Button10.Enabled = True
        Button10.BackColor = Color.Beige
        cantidadTotal = 0
        btnOtraPregunta.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Juego_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        My.Computer.Audio.Stop()

    End Sub

    Private Sub btnPedir_Click(sender As Object, e As EventArgs) Handles btnPedir.Click
        InputBox("Cuanta cantidad de paquetes desea?")


        lstAlmacen.ClearSelected()

    End Sub
End Class