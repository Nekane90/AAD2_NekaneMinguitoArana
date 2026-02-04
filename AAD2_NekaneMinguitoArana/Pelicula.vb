Public Class Pelicula
    Private idPelicula As Integer
    Private tituloPeli As String
    Private añoEstreno As Integer
    Private duracion As Integer
    Private sinopsis As String
    Private urlImagen As String
    Private cantEntradasDispo As Integer
    Private precio As Integer



    ''Constructor
    Public Sub New(idPelicula As Integer, tituloPeli As String, añoEstreno As Integer, duracion As Integer, sinopsis As String,
                   urlImagen As String, cantEntradasDispo As Integer, precio As Integer)
        Me.idPelicula = idPelicula
        Me.tituloPeli = tituloPeli
        Me.añoEstreno = añoEstreno
        Me.duracion = duracion
        Me.sinopsis = sinopsis
        Me.urlImagen = urlImagen
        Me.cantEntradasDispo = cantEntradasDispo
        Me.precio = precio

    End Sub


    ''Getters y setters

    Public Property pidPeli() As String
        Get
            Return idPelicula
        End Get
        Set(ByVal value As String)
            idPelicula = value

        End Set
    End Property


    Public Property ptituloPeli() As String
        Get
            Return tituloPeli
        End Get
        Set(ByVal value As String)
            tituloPeli = value
        End Set
    End Property

    Public Property pañoEstreno() As Integer
        Get
            Return añoEstreno
        End Get
        Set(ByVal value As Integer)
            añoEstreno = value
        End Set
    End Property


    Public Property pduracion() As Integer
        Get
            Return duracion
        End Get
        Set(ByVal value As Integer)
            duracion = value
        End Set
    End Property

    Public Property psinopsis() As String
        Get
            Return sinopsis
        End Get
        Set(ByVal value As String)
            sinopsis = value
        End Set
    End Property

    Public Property purlImagen() As String
        Get
            Return urlImagen
        End Get
        Set(ByVal value As String)
            urlImagen = value
        End Set
    End Property

    Public Property pcantidadEntradasDispo() As Integer
        Get
            Return cantEntradasDispo
        End Get
        Set(ByVal value As Integer)
            cantEntradasDispo = value
        End Set
    End Property

    Public Property pprecio() As Integer
        Get
            Return precio
        End Get
        Set(ByVal value As Integer)
            precio = value
        End Set
    End Property


End Class
