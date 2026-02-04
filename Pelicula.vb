Public Class Pelicula
    ' Atributos
    Private _id As Integer
    Private _titulo As String
    Private _añoEstreno As Integer
    Private _duracion As Integer
    Private _precio As Double
    Private _sinopsis As String
    Private _imagen As String
    Private _stock As Integer
    Private _sala As Integer

    ' Constructor
    Public Sub New(id As Integer, titulo As String, año As Integer, duracion As Integer, precio As Double, sinopsis As String, imagen As String, stock As Integer, Optional sala As Integer = 1)
        Me._id = id
        Me._titulo = titulo
        Me._añoEstreno = año
        Me._duracion = duracion
        Me._precio = precio
        Me._sinopsis = sinopsis
        Me._imagen = imagen
        Me._stock = stock
        Me._sala = sala
    End Sub

    ' Propiedades (Getters y Setters)
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            _titulo = value
        End Set
    End Property

    Public Property AñoEstreno As Integer
        Get
            Return _añoEstreno
        End Get
        Set(value As Integer)
            _añoEstreno = value
        End Set
    End Property

    Public Property Duracion As Integer
        Get
            Return _duracion
        End Get
        Set(value As Integer)
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

    Public Property Imagen As String
        Get
            Return _imagen
        End Get
        Set(value As String)
            _imagen = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            _stock = value
        End Set
    End Property
    Public Property Sala As Integer
        Get
            Return _sala
        End Get
        Set(value As Integer)
            _sala = value
        End Set
    End Property
End Class