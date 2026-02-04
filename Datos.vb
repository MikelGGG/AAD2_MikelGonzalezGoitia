Imports System.Data.SqlClient
Imports System.IO

Public Class Datos
    Public Shared Function ObtenerConexion() As SqlConnection
        Dim builder As New SqlConnectionStringBuilder()
        builder.DataSource = "(LocalDB)\MSSQLLocalDB"
        builder.IntegratedSecurity = True
        builder.Pooling = False

        Dim carpetaApp As String = Application.StartupPath
        Dim rutaMdf As String = Path.Combine(carpetaApp, "CINE.mdf")
        Dim rutaLog As String = Path.Combine(carpetaApp, "CINE_log.ldf")


        If File.Exists(rutaMdf) AndAlso File.Exists(rutaLog) Then
            Try
                File.Delete(rutaLog)
            Catch ex As Exception

            End Try
        End If


        If Not File.Exists(rutaMdf) Then
            MsgBox("ERROR CRÍTICO: No encuentro CINE.mdf en: " & rutaMdf)
            Return Nothing
        End If

        builder.AttachDBFilename = rutaMdf
        Dim conexion As New SqlConnection(builder.ConnectionString)

        Try
            conexion.Open()
            Return conexion
        Catch ex As Exception
            MsgBox("Error al conectar: " & ex.Message)
            Return Nothing
        End Try
    End Function
End Class