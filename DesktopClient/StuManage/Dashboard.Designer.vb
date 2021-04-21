<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TasksCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.DashboardQuitButton = New System.Windows.Forms.Button()
        Me.TaskListHeading = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.paintButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AddTaskButton = New System.Windows.Forms.Button()
        Me.TaskInputTextBox = New System.Windows.Forms.TextBox()
        Me.TaskNameInputLabel = New System.Windows.Forms.Label()
        Me.GetTaskNameButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RedStyle = New System.Windows.Forms.Button()
        Me.CyanStyle = New System.Windows.Forms.Button()
        Me.YellowStyle = New System.Windows.Forms.Button()
        Me.GreenStyle = New System.Windows.Forms.Button()
        Me.TaskTimeLabel = New System.Windows.Forms.Label()
        Me.TaskHoursBox = New System.Windows.Forms.TextBox()
        Me.TaskMinsBox = New System.Windows.Forms.TextBox()
        Me.TaskHourLabel = New System.Windows.Forms.Label()
        Me.TaskMinutesLabel = New System.Windows.Forms.Label()
        Me.ClearCheckedTasksButton = New System.Windows.Forms.Button()
        Me.SortTasksButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DashQuitBtn = New System.Windows.Forms.Button()
        Me.SecL = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PurpleStyle = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.HourT = New System.Windows.Forms.TextBox()
        Me.minT = New System.Windows.Forms.TextBox()
        Me.timerstarterbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TaskL = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.CalcBtn = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.SpotifyT = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.primaryT = New System.Windows.Forms.TextBox()
        Me.addPrimary = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AM = New System.Windows.Forms.TextBox()
        Me.AD = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AddAssignmentBtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AyT = New System.Windows.Forms.TextBox()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.AY = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.Yellow
        Me.MonthCalendar1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        resources.ApplyResources(Me.MonthCalendar1, "MonthCalendar1")
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowTodayCircle = False
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.LimeGreen
        Me.MonthCalendar1.TitleForeColor = System.Drawing.Color.AliceBlue
        '
        'TasksCheckedListBox
        '
        Me.TasksCheckedListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TasksCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TasksCheckedListBox.CheckOnClick = True
        Me.TasksCheckedListBox.Cursor = System.Windows.Forms.Cursors.UpArrow
        Me.TasksCheckedListBox.ForeColor = System.Drawing.Color.White
        Me.TasksCheckedListBox.FormattingEnabled = True
        resources.ApplyResources(Me.TasksCheckedListBox, "TasksCheckedListBox")
        Me.TasksCheckedListBox.Name = "TasksCheckedListBox"
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CheckedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox2.CheckOnClick = True
        Me.CheckedListBox2.Cursor = System.Windows.Forms.Cursors.UpArrow
        Me.CheckedListBox2.ForeColor = System.Drawing.Color.White
        Me.CheckedListBox2.FormattingEnabled = True
        resources.ApplyResources(Me.CheckedListBox2, "CheckedListBox2")
        Me.CheckedListBox2.Name = "CheckedListBox2"
        '
        'DashboardQuitButton
        '
        Me.DashboardQuitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DashboardQuitButton.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.DashboardQuitButton, "DashboardQuitButton")
        Me.DashboardQuitButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DashboardQuitButton.Name = "DashboardQuitButton"
        Me.DashboardQuitButton.UseVisualStyleBackColor = False
        '
        'TaskListHeading
        '
        resources.ApplyResources(Me.TaskListHeading, "TaskListHeading")
        Me.TaskListHeading.BackColor = System.Drawing.Color.Transparent
        Me.TaskListHeading.ForeColor = System.Drawing.Color.White
        Me.TaskListHeading.Name = "TaskListHeading"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'paintButton
        '
        Me.paintButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.paintButton.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.paintButton, "paintButton")
        Me.paintButton.ForeColor = System.Drawing.Color.Aqua
        Me.paintButton.Name = "paintButton"
        Me.paintButton.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'AddTaskButton
        '
        Me.AddTaskButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddTaskButton.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.AddTaskButton, "AddTaskButton")
        Me.AddTaskButton.ForeColor = System.Drawing.Color.Lime
        Me.AddTaskButton.Name = "AddTaskButton"
        Me.AddTaskButton.UseVisualStyleBackColor = False
        '
        'TaskInputTextBox
        '
        resources.ApplyResources(Me.TaskInputTextBox, "TaskInputTextBox")
        Me.TaskInputTextBox.Name = "TaskInputTextBox"
        '
        'TaskNameInputLabel
        '
        resources.ApplyResources(Me.TaskNameInputLabel, "TaskNameInputLabel")
        Me.TaskNameInputLabel.BackColor = System.Drawing.Color.Transparent
        Me.TaskNameInputLabel.ForeColor = System.Drawing.Color.White
        Me.TaskNameInputLabel.Name = "TaskNameInputLabel"
        '
        'GetTaskNameButton
        '
        Me.GetTaskNameButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GetTaskNameButton.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.GetTaskNameButton, "GetTaskNameButton")
        Me.GetTaskNameButton.ForeColor = System.Drawing.Color.Lime
        Me.GetTaskNameButton.Name = "GetTaskNameButton"
        Me.GetTaskNameButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RedStyle
        '
        Me.RedStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RedStyle.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.RedStyle, "RedStyle")
        Me.RedStyle.ForeColor = System.Drawing.Color.Lime
        Me.RedStyle.Name = "RedStyle"
        Me.RedStyle.UseVisualStyleBackColor = False
        '
        'CyanStyle
        '
        Me.CyanStyle.BackColor = System.Drawing.Color.Aqua
        Me.CyanStyle.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.CyanStyle, "CyanStyle")
        Me.CyanStyle.ForeColor = System.Drawing.Color.Lime
        Me.CyanStyle.Name = "CyanStyle"
        Me.CyanStyle.UseVisualStyleBackColor = False
        '
        'YellowStyle
        '
        Me.YellowStyle.BackColor = System.Drawing.Color.Yellow
        Me.YellowStyle.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.YellowStyle, "YellowStyle")
        Me.YellowStyle.ForeColor = System.Drawing.Color.Lime
        Me.YellowStyle.Name = "YellowStyle"
        Me.YellowStyle.UseVisualStyleBackColor = False
        '
        'GreenStyle
        '
        Me.GreenStyle.BackColor = System.Drawing.Color.Lime
        Me.GreenStyle.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.GreenStyle, "GreenStyle")
        Me.GreenStyle.ForeColor = System.Drawing.Color.Lime
        Me.GreenStyle.Name = "GreenStyle"
        Me.GreenStyle.UseVisualStyleBackColor = False
        '
        'TaskTimeLabel
        '
        resources.ApplyResources(Me.TaskTimeLabel, "TaskTimeLabel")
        Me.TaskTimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.TaskTimeLabel.ForeColor = System.Drawing.Color.White
        Me.TaskTimeLabel.Name = "TaskTimeLabel"
        '
        'TaskHoursBox
        '
        resources.ApplyResources(Me.TaskHoursBox, "TaskHoursBox")
        Me.TaskHoursBox.Name = "TaskHoursBox"
        '
        'TaskMinsBox
        '
        resources.ApplyResources(Me.TaskMinsBox, "TaskMinsBox")
        Me.TaskMinsBox.Name = "TaskMinsBox"
        '
        'TaskHourLabel
        '
        resources.ApplyResources(Me.TaskHourLabel, "TaskHourLabel")
        Me.TaskHourLabel.BackColor = System.Drawing.Color.Transparent
        Me.TaskHourLabel.ForeColor = System.Drawing.Color.White
        Me.TaskHourLabel.Name = "TaskHourLabel"
        '
        'TaskMinutesLabel
        '
        resources.ApplyResources(Me.TaskMinutesLabel, "TaskMinutesLabel")
        Me.TaskMinutesLabel.BackColor = System.Drawing.Color.Transparent
        Me.TaskMinutesLabel.ForeColor = System.Drawing.Color.White
        Me.TaskMinutesLabel.Name = "TaskMinutesLabel"
        '
        'ClearCheckedTasksButton
        '
        Me.ClearCheckedTasksButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClearCheckedTasksButton.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.ClearCheckedTasksButton, "ClearCheckedTasksButton")
        Me.ClearCheckedTasksButton.ForeColor = System.Drawing.Color.Red
        Me.ClearCheckedTasksButton.Name = "ClearCheckedTasksButton"
        Me.ClearCheckedTasksButton.UseVisualStyleBackColor = False
        '
        'SortTasksButton
        '
        Me.SortTasksButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SortTasksButton.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.SortTasksButton, "SortTasksButton")
        Me.SortTasksButton.ForeColor = System.Drawing.Color.Yellow
        Me.SortTasksButton.Name = "SortTasksButton"
        Me.SortTasksButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'DashQuitBtn
        '
        Me.DashQuitBtn.BackColor = System.Drawing.Color.Transparent
        Me.DashQuitBtn.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.DashQuitBtn, "DashQuitBtn")
        Me.DashQuitBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DashQuitBtn.Name = "DashQuitBtn"
        Me.DashQuitBtn.UseVisualStyleBackColor = False
        '
        'SecL
        '
        resources.ApplyResources(Me.SecL, "SecL")
        Me.SecL.BackColor = System.Drawing.Color.Transparent
        Me.SecL.Name = "SecL"
        '
        'Timer1
        '
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.ForeColor = System.Drawing.Color.Fuchsia
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PurpleStyle
        '
        Me.PurpleStyle.BackColor = System.Drawing.Color.Fuchsia
        Me.PurpleStyle.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.PurpleStyle, "PurpleStyle")
        Me.PurpleStyle.ForeColor = System.Drawing.Color.Lime
        Me.PurpleStyle.Name = "PurpleStyle"
        Me.PurpleStyle.UseVisualStyleBackColor = False
        '
        'NotifyIcon1
        '
        resources.ApplyResources(Me.NotifyIcon1, "NotifyIcon1")
        '
        'HourT
        '
        resources.ApplyResources(Me.HourT, "HourT")
        Me.HourT.Name = "HourT"
        '
        'minT
        '
        resources.ApplyResources(Me.minT, "minT")
        Me.minT.Name = "minT"
        '
        'timerstarterbtn
        '
        Me.timerstarterbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.timerstarterbtn.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.timerstarterbtn, "timerstarterbtn")
        Me.timerstarterbtn.ForeColor = System.Drawing.Color.Fuchsia
        Me.timerstarterbtn.Name = "timerstarterbtn"
        Me.timerstarterbtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Name = "Label5"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Name = "Label8"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.ForeColor = System.Drawing.Color.Fuchsia
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TaskL
        '
        resources.ApplyResources(Me.TaskL, "TaskL")
        Me.TaskL.BackColor = System.Drawing.Color.Transparent
        Me.TaskL.ForeColor = System.Drawing.Color.Gray
        Me.TaskL.Name = "TaskL"
        '
        'SearchBox
        '
        resources.ApplyResources(Me.SearchBox, "SearchBox")
        Me.SearchBox.Name = "SearchBox"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.ForeColor = System.Drawing.Color.Lime
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.ForeColor = System.Drawing.Color.Yellow
        Me.Button7.Name = "Button7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button8, "Button8")
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.Name = "Button8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button9.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button9, "Button9")
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.Name = "Button9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'CalcBtn
        '
        Me.CalcBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CalcBtn.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.CalcBtn, "CalcBtn")
        Me.CalcBtn.ForeColor = System.Drawing.Color.Aqua
        Me.CalcBtn.Name = "CalcBtn"
        Me.CalcBtn.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button10.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button10, "Button10")
        Me.Button10.ForeColor = System.Drawing.Color.Lime
        Me.Button10.Name = "Button10"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button11.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button11, "Button11")
        Me.Button11.ForeColor = System.Drawing.Color.Red
        Me.Button11.Name = "Button11"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button13.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button13, "Button13")
        Me.Button13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button13.Name = "Button13"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button15.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button15, "Button15")
        Me.Button15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button15.Name = "Button15"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'SpotifyT
        '
        resources.ApplyResources(Me.SpotifyT, "SpotifyT")
        Me.SpotifyT.Name = "SpotifyT"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button12.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button12, "Button12")
        Me.Button12.ForeColor = System.Drawing.Color.Red
        Me.Button12.Name = "Button12"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Name = "Label6"
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button14.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button14, "Button14")
        Me.Button14.ForeColor = System.Drawing.Color.Fuchsia
        Me.Button14.Name = "Button14"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'primaryT
        '
        resources.ApplyResources(Me.primaryT, "primaryT")
        Me.primaryT.Name = "primaryT"
        '
        'addPrimary
        '
        Me.addPrimary.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addPrimary.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.addPrimary, "addPrimary")
        Me.addPrimary.ForeColor = System.Drawing.Color.Lime
        Me.addPrimary.Name = "addPrimary"
        Me.addPrimary.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button16.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button16, "Button16")
        Me.Button16.ForeColor = System.Drawing.Color.Red
        Me.Button16.Name = "Button16"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Name = "Label7"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Name = "Label9"
        '
        'AM
        '
        resources.ApplyResources(Me.AM, "AM")
        Me.AM.Name = "AM"
        '
        'AD
        '
        resources.ApplyResources(Me.AD, "AD")
        Me.AD.Name = "AD"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Name = "Label10"
        '
        'AddAssignmentBtn
        '
        Me.AddAssignmentBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddAssignmentBtn.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.AddAssignmentBtn, "AddAssignmentBtn")
        Me.AddAssignmentBtn.ForeColor = System.Drawing.Color.Lime
        Me.AddAssignmentBtn.Name = "AddAssignmentBtn"
        Me.AddAssignmentBtn.UseVisualStyleBackColor = False
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Name = "Label11"
        '
        'AyT
        '
        resources.ApplyResources(Me.AyT, "AyT")
        Me.AyT.Name = "AyT"
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button17.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button17, "Button17")
        Me.Button17.ForeColor = System.Drawing.Color.Yellow
        Me.Button17.Name = "Button17"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button18.FlatAppearance.BorderSize = 0
        resources.ApplyResources(Me.Button18, "Button18")
        Me.Button18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button18.Name = "Button18"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'AY
        '
        resources.ApplyResources(Me.AY, "AY")
        Me.AY.Name = "AY"
        '
        'Dashboard
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.CancelButton = Me.DashQuitBtn
        Me.Controls.Add(Me.AY)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AM)
        Me.Controls.Add(Me.AD)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.AddAssignmentBtn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AyT)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.addPrimary)
        Me.Controls.Add(Me.primaryT)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.SpotifyT)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.CalcBtn)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.TaskL)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.timerstarterbtn)
        Me.Controls.Add(Me.minT)
        Me.Controls.Add(Me.HourT)
        Me.Controls.Add(Me.PurpleStyle)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.SecL)
        Me.Controls.Add(Me.DashQuitBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SortTasksButton)
        Me.Controls.Add(Me.ClearCheckedTasksButton)
        Me.Controls.Add(Me.TaskMinutesLabel)
        Me.Controls.Add(Me.TaskHourLabel)
        Me.Controls.Add(Me.TaskMinsBox)
        Me.Controls.Add(Me.TaskHoursBox)
        Me.Controls.Add(Me.TaskTimeLabel)
        Me.Controls.Add(Me.GreenStyle)
        Me.Controls.Add(Me.YellowStyle)
        Me.Controls.Add(Me.CyanStyle)
        Me.Controls.Add(Me.RedStyle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GetTaskNameButton)
        Me.Controls.Add(Me.TaskNameInputLabel)
        Me.Controls.Add(Me.TaskInputTextBox)
        Me.Controls.Add(Me.AddTaskButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.paintButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TaskListHeading)
        Me.Controls.Add(Me.DashboardQuitButton)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.TasksCheckedListBox)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents TasksCheckedListBox As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents DashboardQuitButton As Button
    Friend WithEvents TaskListHeading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents paintButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents AddTaskButton As Button
    Friend WithEvents TaskInputTextBox As TextBox
    Friend WithEvents TaskNameInputLabel As Label
    Friend WithEvents GetTaskNameButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RedStyle As Button
    Friend WithEvents CyanStyle As Button
    Friend WithEvents YellowStyle As Button
    Friend WithEvents GreenStyle As Button
    Friend WithEvents TaskTimeLabel As Label
    Friend WithEvents TaskHoursBox As TextBox
    Friend WithEvents TaskMinsBox As TextBox
    Friend WithEvents TaskHourLabel As Label
    Friend WithEvents TaskMinutesLabel As Label
    Friend WithEvents ClearCheckedTasksButton As Button
    Friend WithEvents SortTasksButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DashQuitBtn As Button
    Friend WithEvents SecL As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button4 As Button
    Friend WithEvents PurpleStyle As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents HourT As TextBox
    Friend WithEvents minT As TextBox
    Friend WithEvents timerstarterbtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents TaskL As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents CalcBtn As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents SpotifyT As TextBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button14 As Button
    Friend WithEvents primaryT As TextBox
    Friend WithEvents addPrimary As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents AM As TextBox
    Friend WithEvents AD As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents AddAssignmentBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents AyT As TextBox
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents AY As TextBox
End Class
