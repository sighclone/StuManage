Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class registerForm
    Private fcon As New FirebaseConfig() With
        {
            .AuthSecret = "uhgHYPofphdXK5p8eepWpy57qCJmWJP8lAxNv8ep",
            .BasePath = "https://stumanagehost-b6910-default-rtdb.firebaseio.com/"
        }
    Private client As IFirebaseClient

    Private Sub registerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        Try
            Dim NewUser As New MyUser() With
            {
            .username = reuser.Text,
            .password = repass.Text,
            .latestTask = Dashboard.TaskInputTextBox.Text
            }
            Dim setter = client.Set("Users/" + reuser.Text, NewUser)
            MessageBox.Show("Registration Successful!")
            Me.Hide()
            LoginPage.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to contact server, please check your internet connection!")
            LoadingForm.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If repass.PasswordChar = "" Then
            repass.PasswordChar = "*"
        Else
            repass.PasswordChar = ""
        End If
    End Sub
End Class