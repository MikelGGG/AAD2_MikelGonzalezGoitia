Public Class Form2
    Private _idPelicula As Integer
    Private _peliculaActual As Pelicula

    Public Sub New(ByVal id As Integer)
        InitializeComponent()
        Me._idPelicula = id
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosPelicula()
    End Sub

    Private Sub CargarDatosPelicula()
        Dim dao As New PeliculaDAO()
        _peliculaActual = dao.ObtenerPorId(_idPelicula)

        If _peliculaActual IsNot Nothing Then
            Me.Text = "Detalle: " & _peliculaActual.Titulo
            lblTitulo.Text = _peliculaActual.Titulo
            lblAnio.Text = "Año: " & _peliculaActual.AñoEstreno
            lblDuracion.Text = "Duración: " & _peliculaActual.Duracion & " min"
            lblPrecio.Text = "Precio: " & _peliculaActual.Precio.ToString("C2")
            txtSinopsis.Text = _peliculaActual.Sinopsis

            Dim ruta As String = IO.Path.Combine(Application.StartupPath, _peliculaActual.Imagen)
            If IO.File.Exists(ruta) Then
                pbImagenDetalle.Image = Image.FromFile(ruta)
            End If
        End If
    End Sub

    Private Sub btnVenderEntradas_Click(sender As Object, e As EventArgs) Handles btnVenderEntradas.Click
        Dim frmVenta As New Form3(_peliculaActual)
        frmVenta.ShowDialog()
    End Sub
End Class