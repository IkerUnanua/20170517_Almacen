Imports System.Collections.ObjectModel
Imports CapaClases
Public Class Tienda
    Private _Articulo As New List(Of Articulo)
    Public ReadOnly Property Articulos As ReadOnlyCollection(Of Articulo)
        Get
            Return _Articulo.AsReadOnly
        End Get
    End Property

    Public Function Añadir(ByVal nombre As String, ByVal stock As Integer) As String

        If stock <= 0 Then
            Return "Error, el stock no puede ser nagativo"
        End If
        If _Articulo.Contains(New Articulo(nombre, stock)) Then
            Return "Error, el producto ya estaba contenido con anterioridad"
        End If
        _Articulo.Add(New Articulo(nombre, stock))
        Return ""
    End Function
    Public Function Comprar(ByVal nombreArticulo As String, ByVal cantidadCompra As Integer) As String

        If Not _Articulo.Contains(New Articulo(nombreArticulo, cantidadCompra)) Then
            Return "Error, el articulo que intentas comprar no existe"
        End If
        For Each arti As Articulo In _Articulo
            If arti.Nombre = nombreArticulo AndAlso arti.Stock >= cantidadCompra Then
                arti.Stock -= cantidadCompra
                Return "Quedan " & arti.Stock & " de " & arti.Nombre
            End If
        Next
        Return "Error, la cantidad de " & nombreArticulo & " que intentas comparar es demasiada, no hay suficiente en stock"

    End Function
End Class
