Imports System.Data.SqlClient

Public Class Pantallaventa

    Private peliVenta As Pelicula

    Public Sub New(ByVal peli As Pelicula)
        InitializeComponent()
        Me.peliVenta = peli
    End Sub
    Private Sub Ventana3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lbTituloPeli.Text = peliVenta.ptituloPeli
    End Sub

    Private Sub btComprar_Click(sender As Object, e As EventArgs) Handles btComprar.Click


        Dim cantidadVenta As Integer = CInt(NumericUpDown1.Value)
        Dim db As New Conexion()

        If (cantidadVenta > peliVenta.pcantidadEntradasDispo) Then
            MsgBox("No hay tantas entradas disponibles")
        End If

        Try
            db.Conectar()

            Dim sql As String = "UPDATE pelicula SET cantidadEntradasDisponibles = cantidadEntradasDisponibles - @cant WHERE idPelicula = @id"
            Dim cmd As New SqlCommand(sql, db.GetConexion)

            cmd.Parameters.AddWithValue("@cant", cantidadVenta)

            cmd.Parameters.AddWithValue("@id", peliVenta.pidPeli)

            Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

            If filasAfectadas > 0 Then

                ' Creo el objeto fichero
                Dim miFich As New GestionFichero("ventas.txt")

                Dim mensaje As String = "Peli: " & peliVenta.ptituloPeli & " | Entradas: " & cantidadVenta

                ' Llamo al metodo para registrar el fichero
                miFich.RegistrarVenta(mensaje)
                ' ---------------------------

                MsgBox("¡Venta completada! El stock se ha actualizado.")

                Form1.Show()
                Me.Close()
            Else
                MsgBox("No se pudo actualizar. Revisa el ID de la película.")
            End If

        Catch ex As Exception
            MsgBox("Error al actualizar la base de datos: " & ex.Message)
        Finally
            db.Desconectar()
        End Try
    End Sub
End Class