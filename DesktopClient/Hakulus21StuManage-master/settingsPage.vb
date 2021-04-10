Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces

Public Class settingsPage
    Private Sub DashboardQuitButton_Click(sender As Object, e As EventArgs) Handles DashboardQuitButton.Click
        Me.Close()
    End Sub

    Private fcon As New FirebaseConfig() With
        {
            .AuthSecret = "uhgHYPofphdXK5p8eepWpy57qCJmWJP8lAxNv8ep",
            .BasePath = "https://stumanagehost-b6910-default-rtdb.firebaseio.com/"
        }
    Private client As IFirebaseClient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim res = client.Get("Users/" + TextBox3.Text)
            Dim resUser = res.ResultAs(Of MyUser)
            Dim CurUser As New MyUser With
            {
            .username = TextBox3.Text,
            .password = TextBox1.Text
            }
            If (MyUser.IsEqual(resUser, CurUser)) Then
                Dim passChange As New MyUser() With
            {
            .username = Me.TextBox3.Text,
            .password = Me.TextBox2.Text
            }
                Dim setter = client.Update("Users/" + LoginPage.UsernameT.Text, passChange)
                Dim ThisUsr = TextBox3.Text
                TextBox1.Text = ""

            Else
                MyUser.showErrow()
            End If
        Catch
            MessageBox.Show("Unable to contact server, please check your internet connection!")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.PasswordChar = "" Then
            TextBox2.PasswordChar = "*"
        Else
            TextBox2.PasswordChar = ""
        End If
    End Sub
End Class