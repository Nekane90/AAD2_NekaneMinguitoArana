Imports System.Data.SqlClient



Public Class Conexion
        ' 1. La cadena de conexión
        ' Data Source: Suele ser "." o "(localdb)\MSSQLLocalDB" o "TU_PC\SQLEXPRESS"
        ' Initial Catalog: El nombre de tu base de datos (CINE)
        ' Integrated Security: True para usar tu usuario de Windows (sin contraseña)
        Private cadena As String = "Data Source=.;Initial Catalog=Cine;Integrated Security=True"

        ' 2. Objeto de conexión
        Protected cn As New SqlConnection

        ' Método para abrir la conexión
        Public Sub Conectar()
            Try
                cn.ConnectionString = cadena
                cn.Open()
            Catch ex As Exception
                MsgBox("Error al conectar a la base de datos: " & ex.Message)
            End Try
        End Sub
        'Metodo para cerrar la conexion
        Public Sub Desconectar()
            Try
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            Catch ex As Exception
                MsgBox("Error al cerrar la conexión: " & ex.Message)
            End Try
        End Sub

        Public ReadOnly Property GetConexion As SqlConnection
            Get
                Return cn
            End Get
        End Property
    End Class


