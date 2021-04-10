<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoadingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadingForm))
        Me.LoadProgBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'LoadProgBar
        '
        Me.LoadProgBar.ForeColor = System.Drawing.Color.Red
        Me.LoadProgBar.Location = New System.Drawing.Point(12, 12)
        Me.LoadProgBar.Name = "LoadProgBar"
        Me.LoadProgBar.Size = New System.Drawing.Size(1368, 197)
        Me.LoadProgBar.TabIndex = 0
        Me.LoadProgBar.UseWaitCursor = True
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1392, 221)
        Me.Controls.Add(Me.LoadProgBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoadingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Synchronising with server, please wait..."
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoadProgBar As ProgressBar
End Class
