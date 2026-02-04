Imports System.Net.Http
Imports System.Text.Json

Public Class FormCreditos


    Private Const MI_USUARIO_GITHUB As String = "MikelGGG"

    Private Async Sub FormCreditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using client As New HttpClient()

                client.DefaultRequestHeaders.UserAgent.ParseAdd("AppCine-Mikel")

                Dim url As String = $"https://api.github.com/users/{MI_USUARIO_GITHUB}"
                Dim respuestaJson As String = Await client.GetStringAsync(url)

                Dim usuario As GithubUser = JsonSerializer.Deserialize(Of GithubUser)(respuestaJson)

                lblNombre.Text = If(usuario.name, usuario.login)
                lblBio.Text = usuario.bio

                pbAvatar.Load(usuario.avatar_url)

                lnkPerfil.Tag = usuario.html_url
                lnkPerfil.Text = "Ver perfil"

                lblRep.Text = "Repositorios: " & usuario.public_repos

            End Using

        Catch ex As Exception
            MessageBox.Show("Error técnico: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace)
            Me.Close()
        End Try
    End Sub

    Private Sub lnkPerfil_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPerfil.LinkClicked
        If lnkPerfil.Tag IsNot Nothing Then
            Process.Start(New ProcessStartInfo(lnkPerfil.Tag.ToString()) With {.UseShellExecute = True})
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class