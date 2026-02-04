Imports System.Data.SqlClient

Public Class PeliculaDAO
    Public Function ListarPeliculas() As List(Of Pelicula)
        Dim lista As New List(Of Pelicula)

        Using conn = Datos.ObtenerConexion()
            If conn Is Nothing Then
                Return lista
            End If
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
    Public Function ObtenerPorId(id As Integer) As Pelicula
        Dim p As Pelicula = Nothing
        Using conn = Datos.ObtenerConexion()
            Dim query As String = "SELECT Id, Titulo, Anio, Duracion, Precio, Sinopsis, UrlImagen, Stock FROM Pelicula WHERE Id = @id"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", id)

            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    p = New Pelicula(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        Convert.ToDouble(reader.GetDecimal(4)),
                        reader.GetString(5),
                        reader.GetString(6),
                        reader.GetInt32(7)
                    )
                End If
            End Using
        End Using
        Return p
    End Function
    Public Function ActualizarStock(id As Integer, nuevoStock As Integer) As Boolean
        Using conn = Datos.ObtenerConexion()
            Dim query As String = "UPDATE Pelicula SET Stock = @stock WHERE Id = @id"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@stock", nuevoStock)
            cmd.Parameters.AddWithValue("@id", id)

            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function
End Class