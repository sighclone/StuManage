<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerForm))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.repass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reuser = New System.Windows.Forms.TextBox()
        Me.Register = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password:"
        '
        'repass
        '
        Me.repass.Location = New System.Drawing.Point(179, 47)
        Me.repass.Name = "repass"
        Me.repass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.repass.PlaceholderText = "Enter your password here..."
        Me.repass.Size = New System.Drawing.Size(238, 26)
        Me.repass.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username:"
        '
        'reuser
        '
        Me.reuser.Location = New System.Drawing.Point(179, 16)
        Me.reuser.Name = "reuser"
        Me.reuser.PlaceholderText = "Enter your username here..."
        Me.reuser.Size = New System.Drawing.Size(275, 26)
        Me.reuser.TabIndex = 6
        '
        'Register
        '
        Me.Register.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Register.Font = New System.Drawing.Font("ROG Fonts", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Register.ForeColor = System.Drawing.Color.SpringGreen
        Me.Register.Location = New System.Drawing.Point(12, 79)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(442, 181)
        Me.Register.TabIndex = 10
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(423, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 25)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "👁"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'registerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(468, 272)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.repass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.reuser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "registerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registerForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents repass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents reuser As TextBox
    Friend WithEvents Register As Button
    Friend WithEvents Button1 As Button
End Class
