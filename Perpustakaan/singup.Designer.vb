<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class singup
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
        Me.LabelSingUp = New System.Windows.Forms.Label()
        Me.LabelUsernameSingUp = New System.Windows.Forms.Label()
        Me.LabelPasswordSingUp = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.ButtonSingUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelSingUp
        '
        Me.LabelSingUp.AutoSize = True
        Me.LabelSingUp.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelSingUp.Location = New System.Drawing.Point(311, 35)
        Me.LabelSingUp.Name = "LabelSingUp"
        Me.LabelSingUp.Size = New System.Drawing.Size(128, 38)
        Me.LabelSingUp.TabIndex = 0
        Me.LabelSingUp.Text = "Sing-Up"
        '
        'LabelUsernameSingUp
        '
        Me.LabelUsernameSingUp.AutoSize = True
        Me.LabelUsernameSingUp.Location = New System.Drawing.Point(102, 104)
        Me.LabelUsernameSingUp.Name = "LabelUsernameSingUp"
        Me.LabelUsernameSingUp.Size = New System.Drawing.Size(91, 25)
        Me.LabelUsernameSingUp.TabIndex = 1
        Me.LabelUsernameSingUp.Text = "Username"
        '
        'LabelPasswordSingUp
        '
        Me.LabelPasswordSingUp.AutoSize = True
        Me.LabelPasswordSingUp.Location = New System.Drawing.Point(102, 170)
        Me.LabelPasswordSingUp.Name = "LabelPasswordSingUp"
        Me.LabelPasswordSingUp.Size = New System.Drawing.Size(87, 25)
        Me.LabelPasswordSingUp.TabIndex = 2
        Me.LabelPasswordSingUp.Text = "Password"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(268, 101)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(382, 31)
        Me.TxtUsername.TabIndex = 3
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(268, 167)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(382, 31)
        Me.TxtPassword.TabIndex = 4
        '
        'ButtonSingUp
        '
        Me.ButtonSingUp.Location = New System.Drawing.Point(538, 233)
        Me.ButtonSingUp.Name = "ButtonSingUp"
        Me.ButtonSingUp.Size = New System.Drawing.Size(112, 34)
        Me.ButtonSingUp.TabIndex = 5
        Me.ButtonSingUp.Text = "Sing-Up"
        Me.ButtonSingUp.UseVisualStyleBackColor = True
        '
        'singup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 291)
        Me.Controls.Add(Me.ButtonSingUp)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.LabelPasswordSingUp)
        Me.Controls.Add(Me.LabelUsernameSingUp)
        Me.Controls.Add(Me.LabelSingUp)
        Me.Name = "singup"
        Me.Text = "singup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSingUp As Label
    Friend WithEvents LabelUsernameSingUp As Label
    Friend WithEvents LabelPasswordSingUp As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents ButtonSingUp As Button
End Class
