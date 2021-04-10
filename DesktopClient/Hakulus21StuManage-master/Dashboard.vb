Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class Dashboard
    Public Shared latestTask As String
    Public Shared username As String

    Private fcon As New FirebaseConfig() With
        {
            .AuthSecret = "uhgHYPofphdXK5p8eepWpy57qCJmWJP8lAxNv8ep",
            .BasePath = "https://stumanagehost-b6910-default-rtdb.firebaseio.com/"
        }
    Private client As IFirebaseClient

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Label2.Text += LoginPage.UsernameT.Text + "!"


    End Sub

    Private Sub DashboardQuitButton_Click(sender As Object, e As EventArgs) Handles DashboardQuitButton.Click
        Me.Hide()
        LoginPage.ShowDialog()
        Me.Close()
    End Sub

    Private Sub AddTaskButton_Click(sender As Object, e As EventArgs) Handles AddTaskButton.Click
        TaskNameInputLabel.Show()
        TaskInputTextBox.Show()
        GetTaskNameButton.Show()
        TaskTimeLabel.Show()
        TaskHourLabel.Show()
        TaskHoursBox.Show()
        TaskMinutesLabel.Show()
        TaskMinsBox.Show()
    End Sub

    Friend Sub GetTaskNameButton_Click(sender As Object, e As EventArgs) Handles GetTaskNameButton.Click
        GetTaskNameButton.Hide()
        TaskInputTextBox.Hide()
        TaskNameInputLabel.Hide()
        TaskTimeLabel.Hide()
        TaskHourLabel.Hide()
        TaskHoursBox.Hide()
        TaskMinutesLabel.Hide()
        TaskMinsBox.Hide()
        If TaskHoursBox.Text = "" And TaskMinsBox.Text <> "" Then
            TasksCheckedListBox.Items.Add(TaskInputTextBox.Text + " >Time: " + TaskMinsBox.Text + "Min")
        ElseIf TaskHoursBox.Text = "" And TaskMinsBox.Text = "" Then
            TasksCheckedListBox.Items.Add(TaskInputTextBox.Text)
        ElseIf TaskHoursBox.Text <> "" And TaskMinsBox.Text = "" Then
            TasksCheckedListBox.Items.Add(TaskInputTextBox.Text + " >Time: " + TaskHoursBox.Text + "Hr ")
        ElseIf TaskHoursBox.Text <> "" And TaskMinsBox.text <> "" Then
            TasksCheckedListBox.Items.Add(TaskInputTextBox.Text + " >Time: " + TaskHoursBox.Text + "Hr " + TaskMinsBox.Text + "Min")
        End If
        TaskInputTextBox.Text = ""
        TaskHoursBox.Text = ""
        TaskMinsBox.Text = ""


    End Sub

    Private Sub paintButton_Click(sender As Object, e As EventArgs) Handles paintButton.Click
        Dim openfile As New OpenFileDialog
        openfile.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*png;*.gif"
        If (openfile.ShowDialog = DialogResult.OK) Then
            Me.BackgroundImage = Image.FromFile(openfile.FileName)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        settingsPage.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", "https://mail.google.com/mail/u/0/#inbox")
        Catch ex As Exception
            Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://mail.google.com/mail/u/0/#inbox")
        End Try
    End Sub

    Private Sub RedStyle_Click(sender As Object, e As EventArgs) Handles RedStyle.Click
        Me.BackgroundImage = Image.FromFile("AdditionalFiles\Imagery\Internal\RedImg.png")
    End Sub

    Private Sub CyanStyle_Click(sender As Object, e As EventArgs) Handles CyanStyle.Click
        Me.BackgroundImage = Image.FromFile("AdditionalFiles\Imagery\Internal\CyanImg.jpg")
    End Sub

    Private Sub YellowStyle_Click(sender As Object, e As EventArgs) Handles YellowStyle.Click
        Me.BackgroundImage = Image.FromFile("AdditionalFiles\Imagery\Internal\YellowImg.jpg")
    End Sub

    Private Sub GreenStyle_Click(sender As Object, e As EventArgs) Handles GreenStyle.Click
        Me.BackgroundImage = Image.FromFile("AdditionalFiles\Imagery\Internal\LimeImg.jpg")
    End Sub

    Private Sub ClearCheckedTasksButton_Click(sender As Object, e As EventArgs) Handles ClearCheckedTasksButton.Click

        With TasksCheckedListBox
            If .CheckedItems.Count > 0 Then
                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1
                    .Items.Remove(.CheckedItems(checked))
                Next
            Else
                MessageBox.Show("No tasks were selected!")
            End If
        End With
    End Sub

    Private Sub DashQuitBtn_Hover(sender As Object, e As EventArgs) Handles DashQuitBtn.MouseHover
        DashQuitBtn.BackColor = Color.FromArgb(0, 255, 128, 128)
    End Sub

    Dim counter As Integer
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If counter = 0 Then
            SecL.Text = "0000"
            Timer1.Stop()
            NotifyIcon1.ShowBalloonTip(5000, "Time's up!!!", "Time allocated for your most recent task on StuManage has expired", ToolTipIcon.None)

            My.Computer.Audio.Play("AdditionalFiles\Audio\TimeUp.wav", AudioPlayMode.WaitToComplete)
        Else
            counter = counter - 1
            SecL.Text = Convert.ToString(counter)
        End If
    End Sub

    Private Sub PurpleStyle_Click(sender As Object, e As EventArgs) Handles PurpleStyle.Click
        Me.BackgroundImage = Image.FromFile("AdditionalFiles\Imagery\Internal\PurpleImg.jpg")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label3.Show()
        Label4.Show()
        HourT.Show()
        minT.Show()
        timerstarterbtn.Show()
    End Sub

    Public Sub timerstarterbtn_Click(sender As Object, e As EventArgs) Handles timerstarterbtn.Click
        Label3.Hide()
        Label4.Hide()
        HourT.Hide()
        minT.Hide()
        timerstarterbtn.Hide()
        If HourT.Text = "" Then
            HourT.Text = 0
        End If
        If minT.Text = "" Then
            minT.Text = 1
        End If
        Dim x = Convert.ToInt32(HourT.Text)
        Dim y = Convert.ToInt32(minT.Text)
        counter = x * 3600 + y * 60
        Timer1.Start()
        Timer1.Interval = 1000
        HourT.Text = ""
        minT.Text = ""
    End Sub

    Private Sub SortTasksButton_Click(sender As Object, e As EventArgs) Handles SortTasksButton.Click

        Dim taskUpdate As New MyUser() With
            {
            .latestTask = "No task allocated as primary"
            }
        Dim setter = client.Update("Users/" + LoginPage.UsernameT.Text + "TaskList", taskUpdate)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim res = client.Get("Users/" + LoginPage.UsernameT.Text + "/TaskList")
            Dim tsk As New MyUser()
            tsk = res.ResultAs(Of MyUser)
            TaskL.Text = tsk.latestTask
            TaskL.ForeColor = Color.White
        Catch ex As Exception
            MessageBox.Show("Unable to contact server, please check your internet connection!")
            LoadingForm.Close()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", "https://www.google.co.in/search?q=" + SearchBox.Text)
        Catch ex As Exception
            Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://www.google.co.in/search?q=" + SearchBox.Text)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", "https://duckduckgo.com/?q=" + SearchBox.Text)
        Catch ex As Exception
            Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://duckduckgo.com/?q=" + SearchBox.Text)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", "https://stackoverflow.com/search?q=" + SearchBox.Text)
        Catch ex As Exception
            Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://stackoverflow.com/search?q=" + SearchBox.Text)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", "https://www.wolframalpha.com/input/?i=" + SearchBox.Text)
        Catch ex As Exception
            Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://www.wolframalpha.com/input/?i=" + SearchBox.Text)
        End Try
    End Sub

    Private Sub CalcBtn_Click(sender As Object, e As EventArgs) Handles CalcBtn.Click
        Process.Start("C:\Windows\System32\calc.exe")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", "https://www.desmos.com/calculator")
        Catch ex As Exception
            Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://www.desmos.com/calculator")
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", "https://doubtnut.com/")
        Catch ex As Exception
            Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://doubtnut.com/")
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Try
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", "https://www.youtube.com/")
        Catch ex As Exception
            Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://www.youtube.com/")
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", "https://www.udemy.com/")
        Catch ex As Exception
            Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://www.udemy.com/")
        End Try
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", "https://www.youtube.com/results?search_query=" + SearchBox.Text)
        Catch ex As Exception
            Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://www.youtube.com/results?search_query=" + SearchBox.Text)
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            Process.Start("C:\Program Files\Google\Chrome\Application\chrome.exe", "https://open.spotify.com/search/" + SpotifyT.Text)
        Catch ex As Exception
            Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://open.spotify.com/search/" + SpotifyT.Text)
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        primaryT.Show()
        addPrimary.Show()
    End Sub

    Private Sub addPrimary_Click(sender As Object, e As EventArgs) Handles addPrimary.Click
        primaryT.Hide()
        addPrimary.Hide()
        Try
            Dim taskUpdate As New MyUser() With
            {
            .latestTask = Me.primaryT.Text
            }
            Dim setter = client.Update("Users/" + LoginPage.UsernameT.Text + "/" + "TaskList", taskUpdate)
        Catch ex As Exception
            MessageBox.Show("Unable to contact server, please check your internet connection!")
            LoadingForm.Close()
        End Try
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Label11.Show()
        AD.Show()
        AM.Show()
        AyT.Show()
        Label10.Show()
        Label9.Show()
        Label7.Show()
        AddAssignmentBtn.Show()
    End Sub

    Private Sub AddAssignmentBtn_Click(sender As Object, e As EventArgs) Handles AddAssignmentBtn.Click
        If AD.Text <> "" And AM.Text <> "" And AY.Text <> "" Then
            CheckedListBox2.Items.Add(AyT.Text + ">Sub.m: " + AD.Text + "/" + AM.Text + "/" + AY.Text)
        Else
            CheckedListBox2.Items.Add(AyT.Text)
        End If
        Label11.Hide()
        AD.Hide()
        AM.Hide()
        AyT.Hide()
        Label10.Hide()
        Label9.Hide()
        Label7.Hide()
        AddAssignmentBtn.Hide()
        AD.Text = ""
        AM.Text = ""
        AY.Text = ""
        AyT.Text = ""
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim FileStream As New System.IO.FileStream("AdditionalFiles\SaveFile\AssignmentsList.stumanage", IO.FileMode.Create)
        Dim BinaryWriter As New System.IO.BinaryWriter(FileStream)
        For i = 0 To CheckedListBox2.Items.Count - 1
            BinaryWriter.Write(CStr(CheckedListBox2.Items(i)))
            BinaryWriter.Write(CBool(CheckedListBox2.GetItemChecked(i)))
        Next
        BinaryWriter.Close()
        FileStream.Dispose()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        CheckedListBox2.Items.Clear()

        Dim FileStream As New System.IO.FileStream("AdditionalFiles\SaveFile\AssignmentsList.stumanage", IO.FileMode.Open)
        Dim BinaryReader As New System.IO.BinaryReader(FileStream)

        CheckedListBox2.BeginUpdate()
        Do While FileStream.Position < FileStream.Length
            CheckedListBox2.Items.Add(BinaryReader.ReadString)
            CheckedListBox2.SetItemChecked(CheckedListBox2.Items.Count - 1, BinaryReader.ReadBoolean)
        Loop
        CheckedListBox2.EndUpdate()

        BinaryReader.Close()
        FileStream.Dispose()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        With CheckedListBox2
            If .CheckedItems.Count > 0 Then
                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1
                    .Items.Remove(.CheckedItems(checked))
                Next
            Else
                MessageBox.Show("No assignments were selected!")
            End If
        End With
    End Sub
End Class