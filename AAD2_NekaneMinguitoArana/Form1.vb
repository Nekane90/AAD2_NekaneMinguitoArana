Imports System.Data.SqlClient

Public Class Form1

    ' Este método se ejecutará sin importar en qué foto hagas clic
    Private Sub SeleccionarPelicula_Click(sender As Object, e As EventArgs) Handles pcAida.Click, pcAvatar.Click, pcLaAsistenta.Click, pcJurassic.Click, pcTitanic.Click

        ' "sender" es el objeto que recibió el clic (el PictureBox que el usuario pulsó)
        Dim pb As PictureBox = DirectCast(sender, PictureBox)

        ' Obtenemos el ID de la propiedad tag
        Dim idSeleccionado As Integer = CInt(pb.Tag)

        ' Llamamos a la BBDD para traer los datos de esa película específica
        Dim peli As Pelicula = ObtenerPeliculaPorId(idSeleccionado)

        ' Si encontramos la película, pasamos a la Pantalla 2
        If peli IsNot Nothing Then
            Dim pantalla2 As New PantallaInformacionPeli(peli)
            pantalla2.Show()
            ' Opcional: Me.Hide() si quieres que la pantalla 1 desaparezca
        End If
    End Sub


    ' Función para buscar una sola película por su ID
    Private Function ObtenerPeliculaPorId(id As Integer) As Pelicula
        Dim p As Pelicula = Nothing
        Dim con As New Conexion()
        con.Conectar()

        Try
            Dim sqlConnection = con.GetConexion()
            ' Usamos los nombres de columna
            Dim query As String = "SELECT * FROM pelicula WHERE idPelicula = @id"
            Dim cmd As New SqlCommand(query, con.GetConexion)
            cmd.Parameters.AddWithValue("@id", id)

            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                ' Creamos el objeto con los datos de la fila encontrada
                p = New Pelicula(
                CInt(dr("idPelicula")),
                dr("tituloPelicula").ToString(),
                CInt(dr("añoEstreno")),
                CInt(dr("duracion")),
                dr("sinopsis").ToString(),
                dr("urlImagen").ToString(),
                CInt(dr("cantidadEntradasDisponibles")),
                CInt(dr("precio"))
            )
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Desconectar()
        End Try

        Return p
    End Function

    Private Sub btCreditos_Click(sender As Object, e As EventArgs) Handles btCreditos.Click
        Creditos.Show()
    End Sub
End Class
