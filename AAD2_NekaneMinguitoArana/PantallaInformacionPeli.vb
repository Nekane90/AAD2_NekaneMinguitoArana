Public Class PantallaInformacionPeli

    Private peliActual As Pelicula

    Public Sub New(ByVal peliRecibida As Pelicula)
            ' Esta línea es obligatoria para que el diseñador de Windows Forms funcione
            InitializeComponent()

            ' Guardamos la película que nos pasan en nuestra variable local
            Me.peliActual = peliRecibida
        End Sub

        ' 3. Al cargar la pantalla, rellenamos los datos
        Private Sub FormDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Usamos los nombres de tu clase y de tus Labels
        Me.lbTituloPeli.Text = peliActual.ptituloPeli
        Me.lbSinopsis.Text = peliActual.psinopsis
        Me.lbAñoestreno.Text = peliActual.pañoEstreno.ToString()
        Me.lbDuracion.Text = peliActual.pduracion
        Me.lbPrecio.Text = peliActual.pprecio

        Dim rutaImagen As String = peliActual.purlImagen

        If IO.File.Exists(rutaImagen) Then
            ' Usamos este método que es más "amigable" y no bloquea el archivo
            Using fs As New IO.FileStream(rutaImagen, IO.FileMode.Open, IO.FileAccess.Read)
                Me.pcImagen.Image = Image.FromStream(fs)
            End Using
        Else
            ' Si no existe la ruta de la BBDD, intentamos buscarla en la carpeta del programa por si acaso
            Dim nombreArchivo As String = IO.Path.GetFileName(rutaImagen)
            Dim rutaAlternativa As String = IO.Path.Combine(Application.StartupPath, "Imagenes", nombreArchivo)

            If IO.File.Exists(rutaAlternativa) Then
                Me.pcImagen.Image = Image.FromFile(rutaAlternativa)
            Else
                MsgBox("No se encuentra en C: ni en la carpeta del proyecto: " & rutaImagen)
            End If
        End If
    End Sub

    Private Sub btVender_Click(sender As Object, e As EventArgs) Handles btVender.Click
        Dim pantallaventa As New Pantallaventa(Me.peliActual)
        pantallaventa.Show()
        Me.Hide()

    End Sub
End Class


