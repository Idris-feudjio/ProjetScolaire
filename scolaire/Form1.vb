Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MessageBox.Show("Voulez-vous vraiment quitter l'application", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        FormlaireInscription.Show()
        Me.Hide()
    End Sub
End Class
