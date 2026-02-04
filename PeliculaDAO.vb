Imports System.Data.SqlClient

Public Class PeliculaDAO
    Public Function ListarPeliculas() As List(Of Pelicula)
        Dim lista As New List(Of Pelicula)

        Using conn = Datos.ObtenerConexion()
            Dim query As String = "SELECT Id, Titulo, Anio, Duracion, Precio, Sinopsis, UrlImagen, Stock FROM Pelicula"
            Dim cmd As New SqlCommand(query, conn)

            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ' Creamos nueva pelicula
                    Dim p As New Pelicula(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        Convert.ToDouble(reader.GetDecimal(4)),
                        reader.GetString(5),
                        reader.GetString(6),
                        reader.GetInt32(7)
                    )
                    lista.Add(p)
                End While
            End Using
        End Using

        Return lista
    End Function
End Class