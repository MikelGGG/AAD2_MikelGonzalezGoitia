Imports System.IO

Public Class Form3
    Private _pelicula As Pelicula

    Public Sub New(pel As Pelicula)
        InitializeComponent()
        Me._pelicula = pel
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombrePeli.Text = _pelicula.Titulo
        lblStockDisponible.Text = "Disponibles: " & _pelicula.Stock
        numCantidad.Maximum = Math.Min(10, _pelicula.Stock)
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        Dim cantidad As Integer = CInt(numCantidad.Value)

        If cantidad > _pelicula.Stock Then
            MessageBox.Show("Lo sentimos, no hay suficientes entradas.")
            Exit Sub
        End If

        Dim dao As New PeliculaDAO()
        If dao.ActualizarStock(_pelicula.Id, _pelicula.Stock - cantidad) Then

            GuardarVentaEnFichero(_pelicula.Titulo, cantidad)
            MessageBox.Show("Compra realizada con éxito.")

            Application.OpenForms("Form2").Close()
            Me.Close()
        Else
            MessageBox.Show("Error al procesar la venta en la base de datos.")
        End If
    End Sub

    Private Sub GuardarVentaEnFichero(titulo As String, cant As Integer)
        Dim rutaFichero As String = Path.Combine(Application.StartupPath, "ventas.txt")
        Try
            Using sw As StreamWriter = File.AppendText(rutaFichero)
                sw.WriteLine($"{DateTime.Now} - Película: {titulo} - Entradas: {cant}")
            End Using
        Catch ex As Exception
            MsgBox("No se pudo escribir en el archivo de ventas.")
        End Try
    End Sub
End Class