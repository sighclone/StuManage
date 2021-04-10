Public Class MyUser
    Public Property username() As String
    Public Property password() As String
    Public Property latestTask() As String
    Public Property nick() As String

    Private Shared err As String = "Username not found!"
    Public Shared Sub showErrow()
        MessageBox.Show(err)
    End Sub

    Public Shared Function IsEqual(user1 As MyUser, user2 As MyUser)
        If (user1 Is Nothing Or user2 Is Nothing) Then
            err = "Username not found!"
            Return False
        End If

        If (user1.username <> user2.username) Then
            err = "Username not found!"
            Return False
        ElseIf (user1.password <> user2.password) Then
            err = "Username-Password mismatch!"
            Return False
        End If

        Return True

    End Function

End Class
