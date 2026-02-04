Imports System.Data.SqlClient

Public Class Datos
    Private Shared _cadenaConexion As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CINE.mdf;Integrated Security=True"


    Public Shared Function ObtenerConexion() As SqlConnection
        Dim conexion As New SqlConnection(_cadenaConexion)
        Try
            conexion.Open()
            Return conexion
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos: " & ex.Message)
            Return Nothing
        End Try
    End Function
End Class