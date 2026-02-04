Public Class Pelicula
    Private _titulo As String
    Private _añoEstreno As Date
    Private _duracion As TimeSpan
    Private _precio As Double
    Private _sinopsis As String
    Private _imagen As String

    Public Sub New(titulo As String, añoEstreno As Date, duracion As TimeSpan, precio As Double, sinopsis As String, imagen As String)
        Me._titulo = titulo
        Me._añoEstreno = añoEstreno
        Me._duracion = duracion
        Me._precio = precio
        Me._sinopsis = sinopsis
        Me._imagen = imagen
    End Sub

    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            _titulo = value
        End Set
    End Property

    Public Property AñoEstreno As Date
        Get
            Return _añoEstreno
        End Get
        Set(value As Date)
            _añoEstreno = value
        End Set
    End Property

    Public Property Duracion As TimeSpan
        Get
            Return _duracion
        End Get
        Set(value As TimeSpan)
            _duracion = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

    Public Property Sinopsis As String
        Get
            Return _sinopsis
        End Get
        Set(value As String)
            _sinopsis = value
        End Set
    End Property

    Public Property imagen As String
        Get
            Return _imagen
        End Get
        Set(value As String)
            _imagen = value
        End Set
    End Property
End Class