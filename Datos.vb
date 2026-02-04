Imports System.Data.SqlClient
Imports System.IO

Public Class Datos
    Public Shared Function ObtenerConexion() As SqlConnection
        Dim builder As New SqlConnectionStringBuilder()

        builder.DataSource = "(LocalDB)\MSSQLLocalDB"
        builder.IntegratedSecurity = True
        Dim rutaDb As String = Path.Combine(Application.StartupPath, "CINE.mdf")

        If Not File.Exists(rutaDb) Then
            MsgBox("ERROR CRÍTICO: No encuentro el archivo CINE.mdf en:" & vbCrLf & rutaDb)
            Return Nothing
        End If

        builder.AttachDBFilename = rutaDb

        Dim conexion As New SqlConnection(builder.ConnectionString)

        Try
            conexion.Open()
            Return conexion
        Catch ex As Exception
            MsgBox("Error al abrir la conexión: " & ex.Message)
            Return Nothing
        End Try
    End Function
End Class