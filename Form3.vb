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
        ActualizarPrecio()
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click

        Dim cantidad As Integer = numCantidad.Value
        Dim total As Decimal = _pelicula.Precio * cantidad
        Dim fecha As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Dim rutaProyecto As String = Path.Combine(Application.StartupPath, "ventas.txt")

        Dim lineaVenta As String = $"{fecha} | Película: {_pelicula.Titulo} | Entradas: {cantidad} | Total: {total.ToString("C")}"

        Try
            System.IO.File.AppendAllText(rutaProyecto, lineaVenta & Environment.NewLine)

            MsgBox("¡Compra realizada con éxito!", MsgBoxStyle.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MsgBox("Error al guardar el ticket: " & ex.Message)
        End Try

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
    Private Sub ActualizarPrecio()
        If _pelicula Is Nothing Then
            Return
        End If
        Dim precioUnitario As Decimal = _pelicula.Precio

        Dim cantidad As Integer = numCantidad.Value

        Dim total As Decimal = precioUnitario * cantidad

        lblTotal.Text = total.ToString("C")
    End Sub

    Private Sub nudCantidad_ValueChanged(sender As Object, e As EventArgs) Handles numCantidad.ValueChanged
        ActualizarPrecio()
    End Sub
End Class