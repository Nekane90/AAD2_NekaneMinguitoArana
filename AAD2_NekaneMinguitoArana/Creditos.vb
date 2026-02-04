Imports System.Net.Http
Imports System.Web.Script.Serialization
Public Class Creditos
    Dim urlPerfil As String = ""

    Private Async Sub FormCreditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Await CargarDatosGithub("Nekane90")
    End Sub

    Private Async Function CargarDatosGithub(usuario As String) As Task
        Dim cliente As New HttpClient()
        ' GitHub pide obligatoriamente un "User-Agent"
        cliente.DefaultRequestHeaders.Add("User-Agent", "request")

        Try
            Dim respuesta As String = Await cliente.GetStringAsync("https://api.github.com/users/" & usuario)

            ' Usamos un serializador para leer el JSON
            Dim js As New JavaScriptSerializer()
            Dim datos As Dictionary(Of String, Object) = js.Deserialize(Of Dictionary(Of String, Object))(respuesta)

            '  Nombre de perfil
            lbNombre.Text = "Usuario: " & datos("login").ToString()

            '  Repositorios públicos
            lbNumRepos.Text = "Repositorios públicos: " & datos("public_repos").ToString()

            '  Guardamos la URL del perfil para luego
            urlPerfil = datos("html_url").ToString()

            '  Foto de perfil
            Dim rutaFoto As String = datos("avatar_url").ToString()
            pcImagen.Load(rutaFoto)
            pcImagen.SizeMode = PictureBoxSizeMode.StretchImage

        Catch ex As Exception
            MsgBox("Error al conectar con GitHub: " & ex.Message)
        End Try
    End Function

    ' Evento para abrir el navegador al pulsar la foto
    Private Sub pbGithub_Click(sender As Object, e As EventArgs) Handles pcImagen.Click
        If Not String.IsNullOrEmpty(urlPerfil) Then
            Process.Start(New ProcessStartInfo(urlPerfil) With {.UseShellExecute = True})
        End If
    End Sub

End Class