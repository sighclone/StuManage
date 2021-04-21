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

        Dim NewUser As New MyUser() With
            {
            .username = reuser.Text,
            .password = repass.Text,
            .latestTask = Dashboard.TaskInputTextBox.Text
            }
        Dim existchkr As UInteger = 0
        Dim existchk = client.Get("Users/" + reuser.Text)
        Dim tsk As New MyUser()
        tsk = existchk.ResultAs(Of MyUser)
        Try
            If tsk.username <> Nothing Then
                MessageBox.Show("Unable to contact server, please check your internet connection!\n\n(NOTE: If the error repeatedly occurs with an active internet connection, it could be due to limited size of server database)")
                LoadingForm.Close()
            Else
                MessageBox.Show("User already exists")
            End If
        Catch ex As NullReferenceException
            Dim setter = client.Set("Users/" + reuser.Text, NewUser)
            MessageBox.Show("Registration Successful!")
            Me.Hide()
            LoginPage.Show()
            Me.Close()
        End Try
    End Sub

    Private Sub Button1_Hover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        repass.PasswordChar = ""
    End Sub

    Private Sub Button1_Leave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        repass.PasswordChar = "*"
    End Sub

End Class