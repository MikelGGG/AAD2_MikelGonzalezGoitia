Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCartelera()
    End Sub

    Private Sub CargarCartelera()
        Dim dao As New PeliculaDAO()
        Dim lista As List(Of Pelicula) = dao.ListarPeliculas()

        flpPeliculas.Controls.Clear()

        For Each pel As Pelicula In lista
            Dim uc As New ucPelicula()

            uc.lblTitulo.Text = pel.Titulo

            Dim rutaCompleta As String = IO.Path.Combine(Application.StartupPath, pel.Imagen)

            If IO.File.Exists(rutaCompleta) Then
                uc.pbImagen.Image = Image.FromFile(rutaCompleta)

            End If
            uc.Tag = pel.Id


            AddHandler uc.Click, AddressOf AbrirDetalle
            AddHandler uc.pbImagen.Click, AddressOf AbrirDetalle
            AddHandler uc.lblTitulo.Click, AddressOf AbrirDetalle

            flpPeliculas.Controls.Add(uc)
        Next
    End Sub

    Private Sub AbrirDetalle(sender As Object, e As EventArgs)
        Dim controlActual = DirectCast(sender, Control)
        Dim idPeli As Integer
        If TypeOf controlActual Is ucPelicula Then
            idPeli = CInt(controlActual.Tag)
        Else
            idPeli = CInt(controlActual.Parent.Tag)
        End If

        Dim frmDetalle As New Form2(idPeli)
        frmDetalle.Show()
    End Sub

    Private Sub Pelicula_Click(sender As Object, e As EventArgs)
        Dim control = DirectCast(sender, Control)
        Dim idPelicula As Integer = CInt(control.Tag)
        MessageBox.Show("Has seleccionado la película con ID: " & idPelicula)
    End Sub
End Class