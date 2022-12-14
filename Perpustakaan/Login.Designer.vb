<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnMenujuRegist = New System.Windows.Forms.Button()
        Me.Labelbelumpunyaakun = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(24, 43)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(91, 25)
        Me.LblUsername.TabIndex = 0
        Me.LblUsername.Text = "Username"
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Location = New System.Drawing.Point(24, 94)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(87, 25)
        Me.LblPass.TabIndex = 1
        Me.LblPass.Text = "Password"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(121, 40)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(301, 31)
        Me.TxtUsername.TabIndex = 2
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(121, 91)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(301, 31)
        Me.TxtPass.TabIndex = 3
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(310, 140)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(112, 34)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnMenujuRegist)
        Me.GroupBox1.Controls.Add(Me.Labelbelumpunyaakun)
        Me.GroupBox1.Controls.Add(Me.LblUsername)
        Me.GroupBox1.Controls.Add(Me.BtnLogin)
        Me.GroupBox1.Controls.Add(Me.TxtUsername)
        Me.GroupBox1.Controls.Add(Me.TxtPass)
        Me.GroupBox1.Controls.Add(Me.LblPass)
        Me.GroupBox1.Location = New System.Drawing.Point(93, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 254)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'BtnMenujuRegist
        '
        Me.BtnMenujuRegist.Location = New System.Drawing.Point(310, 183)
        Me.BtnMenujuRegist.Name = "BtnMenujuRegist"
        Me.BtnMenujuRegist.Size = New System.Drawing.Size(112, 34)
        Me.BtnMenujuRegist.TabIndex = 6
        Me.BtnMenujuRegist.Text = "Regist"
        Me.BtnMenujuRegist.UseVisualStyleBackColor = True
        '
        'Labelbelumpunyaakun
        '
        Me.Labelbelumpunyaakun.AutoSize = True
        Me.Labelbelumpunyaakun.Location = New System.Drawing.Point(121, 188)
        Me.Labelbelumpunyaakun.Name = "Labelbelumpunyaakun"
        Me.Labelbelumpunyaakun.Size = New System.Drawing.Size(166, 25)
        Me.Labelbelumpunyaakun.TabIndex = 5
        Me.Labelbelumpunyaakun.Text = "Belum punya akun?"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 381)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPass As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Labelbelumpunyaakun As Label
    Friend WithEvents BtnMenujuRegist As Button
End Class
