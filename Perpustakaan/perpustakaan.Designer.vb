<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class perpustakaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(perpustakaan))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KoleksiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListboxKoleksiBuku = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnPlus = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnMinus = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(640, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem, Me.ArrayToolStripMenuItem, Me.KoleksiToolStripMenuItem1})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(236, 34)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'ArrayToolStripMenuItem
        '
        Me.ArrayToolStripMenuItem.Name = "ArrayToolStripMenuItem"
        Me.ArrayToolStripMenuItem.Size = New System.Drawing.Size(236, 34)
        Me.ArrayToolStripMenuItem.Text = "array"
        '
        'KoleksiToolStripMenuItem1
        '
        Me.KoleksiToolStripMenuItem1.Name = "KoleksiToolStripMenuItem1"
        Me.KoleksiToolStripMenuItem1.Size = New System.Drawing.Size(236, 34)
        Me.KoleksiToolStripMenuItem1.Text = "Koleksi"
        '
        'ListboxKoleksiBuku
        '
        Me.ListboxKoleksiBuku.FormattingEnabled = True
        Me.ListboxKoleksiBuku.ItemHeight = 25
        Me.ListboxKoleksiBuku.Items.AddRange(New Object() {"Koleksi Buku"})
        Me.ListboxKoleksiBuku.Location = New System.Drawing.Point(12, 75)
        Me.ListboxKoleksiBuku.Name = "ListboxKoleksiBuku"
        Me.ListboxKoleksiBuku.Size = New System.Drawing.Size(616, 304)
        Me.ListboxKoleksiBuku.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnPlus, Me.ToolStripBtnMinus})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 33)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(640, 33)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripBtnPlus
        '
        Me.ToolStripBtnPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtnPlus.Image = CType(resources.GetObject("ToolStripBtnPlus.Image"), System.Drawing.Image)
        Me.ToolStripBtnPlus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnPlus.Name = "ToolStripBtnPlus"
        Me.ToolStripBtnPlus.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripBtnPlus.Text = "ToolStripButton2"
        '
        'ToolStripBtnMinus
        '
        Me.ToolStripBtnMinus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripBtnMinus.Image = CType(resources.GetObject("ToolStripBtnMinus.Image"), System.Drawing.Image)
        Me.ToolStripBtnMinus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnMinus.Name = "ToolStripBtnMinus"
        Me.ToolStripBtnMinus.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripBtnMinus.Text = "ToolStripBtnMinus"
        '
        'perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ListboxKoleksiBuku)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "perpustakaan"
        Me.Text = "perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListboxKoleksiBuku As ListBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnPlus As ToolStripButton
    Friend WithEvents ToolStripBtnMinus As ToolStripButton
    Friend WithEvents ArrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KoleksiToolStripMenuItem1 As ToolStripMenuItem
End Class
