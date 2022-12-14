<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hapuskoleksi
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
        Me.LblKonfirmasi = New System.Windows.Forms.Label()
        Me.LblNamaItem = New System.Windows.Forms.Label()
        Me.BtnKonfirmasiHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblKonfirmasi
        '
        Me.LblKonfirmasi.AutoSize = True
        Me.LblKonfirmasi.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblKonfirmasi.Location = New System.Drawing.Point(187, 48)
        Me.LblKonfirmasi.Name = "LblKonfirmasi"
        Me.LblKonfirmasi.Size = New System.Drawing.Size(299, 28)
        Me.LblKonfirmasi.TabIndex = 0
        Me.LblKonfirmasi.Text = "Apakah ingin menghapus koleksi"
        '
        'LblNamaItem
        '
        Me.LblNamaItem.Font = New System.Drawing.Font("Segoe UI Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNamaItem.ForeColor = System.Drawing.Color.Maroon
        Me.LblNamaItem.Location = New System.Drawing.Point(230, 139)
        Me.LblNamaItem.Name = "LblNamaItem"
        Me.LblNamaItem.Size = New System.Drawing.Size(206, 54)
        Me.LblNamaItem.TabIndex = 1
        Me.LblNamaItem.Text = "Koleksi A"
        Me.LblNamaItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnKonfirmasiHapus
        '
        Me.BtnKonfirmasiHapus.Location = New System.Drawing.Point(280, 284)
        Me.BtnKonfirmasiHapus.Name = "BtnKonfirmasiHapus"
        Me.BtnKonfirmasiHapus.Size = New System.Drawing.Size(112, 34)
        Me.BtnKonfirmasiHapus.TabIndex = 2
        Me.BtnKonfirmasiHapus.Text = "Hapus"
        Me.BtnKonfirmasiHapus.UseVisualStyleBackColor = True
        '
        'hapuskoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 372)
        Me.Controls.Add(Me.BtnKonfirmasiHapus)
        Me.Controls.Add(Me.LblNamaItem)
        Me.Controls.Add(Me.LblKonfirmasi)
        Me.Name = "hapuskoleksi"
        Me.Text = "hapuskoleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblKonfirmasi As Label
    Friend WithEvents LblNamaItem As Label
    Friend WithEvents BtnKonfirmasiHapus As Button
End Class
