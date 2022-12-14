<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tambah_koleksi
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
        Me.TxtNamaKoleksi = New System.Windows.Forms.TextBox()
        Me.BtnTambahKoleksi = New System.Windows.Forms.Button()
        Me.LblTambahKoleksi = New System.Windows.Forms.Label()
        Me.PictureBoxSampulKoleksi = New System.Windows.Forms.PictureBox()
        Me.BtnTambahGambarSampul = New System.Windows.Forms.Button()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblJenis = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.LblPenerbit = New System.Windows.Forms.Label()
        Me.LblTahun = New System.Windows.Forms.Label()
        Me.LblLokasiRak = New System.Windows.Forms.Label()
        Me.LblTglMasuk = New System.Windows.Forms.Label()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.gr = New System.Windows.Forms.Label()
        Me.LblKategori = New System.Windows.Forms.Label()
        Me.CbxJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.Rtxtdeskripsi = New System.Windows.Forms.RichTextBox()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.TxtTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TxtLokasiRak = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.DateTimePickerTglMasuk = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbtnEng = New System.Windows.Forms.RadioButton()
        Me.RdbtnInd = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSosial = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSains = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBoxSampulKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNamaKoleksi
        '
        Me.TxtNamaKoleksi.Location = New System.Drawing.Point(493, 71)
        Me.TxtNamaKoleksi.Name = "TxtNamaKoleksi"
        Me.TxtNamaKoleksi.Size = New System.Drawing.Size(235, 31)
        Me.TxtNamaKoleksi.TabIndex = 0
        '
        'BtnTambahKoleksi
        '
        Me.BtnTambahKoleksi.Location = New System.Drawing.Point(321, 798)
        Me.BtnTambahKoleksi.Name = "BtnTambahKoleksi"
        Me.BtnTambahKoleksi.Size = New System.Drawing.Size(170, 34)
        Me.BtnTambahKoleksi.TabIndex = 1
        Me.BtnTambahKoleksi.Text = "Tambah Koleksi"
        Me.BtnTambahKoleksi.UseVisualStyleBackColor = True
        '
        'LblTambahKoleksi
        '
        Me.LblTambahKoleksi.AutoSize = True
        Me.LblTambahKoleksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTambahKoleksi.Location = New System.Drawing.Point(27, 18)
        Me.LblTambahKoleksi.Name = "LblTambahKoleksi"
        Me.LblTambahKoleksi.Size = New System.Drawing.Size(192, 32)
        Me.LblTambahKoleksi.TabIndex = 2
        Me.LblTambahKoleksi.Text = "Tambah Koleksi"
        '
        'PictureBoxSampulKoleksi
        '
        Me.PictureBoxSampulKoleksi.Location = New System.Drawing.Point(27, 74)
        Me.PictureBoxSampulKoleksi.Name = "PictureBoxSampulKoleksi"
        Me.PictureBoxSampulKoleksi.Size = New System.Drawing.Size(159, 188)
        Me.PictureBoxSampulKoleksi.TabIndex = 3
        Me.PictureBoxSampulKoleksi.TabStop = False
        '
        'BtnTambahGambarSampul
        '
        Me.BtnTambahGambarSampul.Location = New System.Drawing.Point(27, 268)
        Me.BtnTambahGambarSampul.Name = "BtnTambahGambarSampul"
        Me.BtnTambahGambarSampul.Size = New System.Drawing.Size(159, 34)
        Me.BtnTambahGambarSampul.TabIndex = 4
        Me.BtnTambahGambarSampul.Text = "Tambah Gambar"
        Me.BtnTambahGambarSampul.UseVisualStyleBackColor = True
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(221, 71)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(119, 25)
        Me.LblNama.TabIndex = 5
        Me.LblNama.Text = "Nama Koleksi"
        '
        'LblJenis
        '
        Me.LblJenis.AutoSize = True
        Me.LblJenis.Location = New System.Drawing.Point(221, 107)
        Me.LblJenis.Name = "LblJenis"
        Me.LblJenis.Size = New System.Drawing.Size(109, 25)
        Me.LblJenis.TabIndex = 6
        Me.LblJenis.Text = "Jenis Koleksi"
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Location = New System.Drawing.Point(221, 146)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(84, 25)
        Me.LblDeskripsi.TabIndex = 7
        Me.LblDeskripsi.Text = "Deskripsi"
        '
        'LblPenerbit
        '
        Me.LblPenerbit.AutoSize = True
        Me.LblPenerbit.Location = New System.Drawing.Point(221, 286)
        Me.LblPenerbit.Name = "LblPenerbit"
        Me.LblPenerbit.Size = New System.Drawing.Size(76, 25)
        Me.LblPenerbit.TabIndex = 8
        Me.LblPenerbit.Text = "Penerbit"
        '
        'LblTahun
        '
        Me.LblTahun.AutoSize = True
        Me.LblTahun.Location = New System.Drawing.Point(221, 323)
        Me.LblTahun.Name = "LblTahun"
        Me.LblTahun.Size = New System.Drawing.Size(106, 25)
        Me.LblTahun.TabIndex = 9
        Me.LblTahun.Text = "Tahun Terbit"
        '
        'LblLokasiRak
        '
        Me.LblLokasiRak.AutoSize = True
        Me.LblLokasiRak.Location = New System.Drawing.Point(221, 360)
        Me.LblLokasiRak.Name = "LblLokasiRak"
        Me.LblLokasiRak.Size = New System.Drawing.Size(95, 25)
        Me.LblLokasiRak.TabIndex = 10
        Me.LblLokasiRak.Text = "Lokasi Rak"
        '
        'LblTglMasuk
        '
        Me.LblTglMasuk.AutoSize = True
        Me.LblTglMasuk.Location = New System.Drawing.Point(221, 397)
        Me.LblTglMasuk.Name = "LblTglMasuk"
        Me.LblTglMasuk.Size = New System.Drawing.Size(190, 25)
        Me.LblTglMasuk.TabIndex = 11
        Me.LblTglMasuk.Text = "Tanggal Masuk Koleksi"
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Location = New System.Drawing.Point(221, 434)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(55, 25)
        Me.LblStock.TabIndex = 12
        Me.LblStock.Text = "Stock"
        '
        'gr
        '
        Me.gr.AutoSize = True
        Me.gr.Location = New System.Drawing.Point(221, 471)
        Me.gr.Name = "gr"
        Me.gr.Size = New System.Drawing.Size(67, 25)
        Me.gr.TabIndex = 13
        Me.gr.Text = "Bahasa"
        '
        'LblKategori
        '
        Me.LblKategori.AutoSize = True
        Me.LblKategori.Location = New System.Drawing.Point(221, 590)
        Me.LblKategori.Name = "LblKategori"
        Me.LblKategori.Size = New System.Drawing.Size(78, 25)
        Me.LblKategori.TabIndex = 14
        Me.LblKategori.Text = "Kategori"
        '
        'CbxJenisKoleksi
        '
        Me.CbxJenisKoleksi.FormattingEnabled = True
        Me.CbxJenisKoleksi.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"})
        Me.CbxJenisKoleksi.Location = New System.Drawing.Point(493, 107)
        Me.CbxJenisKoleksi.Name = "CbxJenisKoleksi"
        Me.CbxJenisKoleksi.Size = New System.Drawing.Size(235, 33)
        Me.CbxJenisKoleksi.TabIndex = 15
        '
        'Rtxtdeskripsi
        '
        Me.Rtxtdeskripsi.Location = New System.Drawing.Point(493, 146)
        Me.Rtxtdeskripsi.Name = "Rtxtdeskripsi"
        Me.Rtxtdeskripsi.Size = New System.Drawing.Size(235, 117)
        Me.Rtxtdeskripsi.TabIndex = 16
        Me.Rtxtdeskripsi.Text = "Koleksi Buku"
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(493, 286)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(235, 31)
        Me.TxtPenerbit.TabIndex = 17
        '
        'TxtTahunTerbit
        '
        Me.TxtTahunTerbit.Location = New System.Drawing.Point(493, 323)
        Me.TxtTahunTerbit.Name = "TxtTahunTerbit"
        Me.TxtTahunTerbit.Size = New System.Drawing.Size(235, 31)
        Me.TxtTahunTerbit.TabIndex = 18
        '
        'TxtLokasiRak
        '
        Me.TxtLokasiRak.Location = New System.Drawing.Point(493, 360)
        Me.TxtLokasiRak.Name = "TxtLokasiRak"
        Me.TxtLokasiRak.Size = New System.Drawing.Size(235, 31)
        Me.TxtLokasiRak.TabIndex = 19
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(493, 434)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(235, 31)
        Me.TxtStock.TabIndex = 20
        '
        'DateTimePickerTglMasuk
        '
        Me.DateTimePickerTglMasuk.Location = New System.Drawing.Point(493, 397)
        Me.DateTimePickerTglMasuk.Name = "DateTimePickerTglMasuk"
        Me.DateTimePickerTglMasuk.Size = New System.Drawing.Size(235, 31)
        Me.DateTimePickerTglMasuk.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdbtnEng)
        Me.GroupBox1.Controls.Add(Me.RdbtnInd)
        Me.GroupBox1.Location = New System.Drawing.Point(493, 471)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 113)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'RdbtnEng
        '
        Me.RdbtnEng.AutoSize = True
        Me.RdbtnEng.Location = New System.Drawing.Point(14, 63)
        Me.RdbtnEng.Name = "RdbtnEng"
        Me.RdbtnEng.Size = New System.Drawing.Size(152, 29)
        Me.RdbtnEng.TabIndex = 1
        Me.RdbtnEng.TabStop = True
        Me.RdbtnEng.Text = "Bahasa Inggris"
        Me.RdbtnEng.UseVisualStyleBackColor = True
        '
        'RdbtnInd
        '
        Me.RdbtnInd.AutoSize = True
        Me.RdbtnInd.Location = New System.Drawing.Point(14, 28)
        Me.RdbtnInd.Name = "RdbtnInd"
        Me.RdbtnInd.Size = New System.Drawing.Size(174, 29)
        Me.RdbtnInd.TabIndex = 0
        Me.RdbtnInd.TabStop = True
        Me.RdbtnInd.Text = "Bahasa Indonesia"
        Me.RdbtnInd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxBudaya)
        Me.GroupBox2.Controls.Add(Me.CheckBoxTeknologi)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSosial)
        Me.GroupBox2.Controls.Add(Me.CheckBoxSains)
        Me.GroupBox2.Location = New System.Drawing.Point(493, 590)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 190)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'CheckBoxBudaya
        '
        Me.CheckBoxBudaya.AutoSize = True
        Me.CheckBoxBudaya.Location = New System.Drawing.Point(6, 135)
        Me.CheckBoxBudaya.Name = "CheckBoxBudaya"
        Me.CheckBoxBudaya.Size = New System.Drawing.Size(96, 29)
        Me.CheckBoxBudaya.TabIndex = 3
        Me.CheckBoxBudaya.Text = "Budaya"
        Me.CheckBoxBudaya.UseVisualStyleBackColor = True
        '
        'CheckBoxTeknologi
        '
        Me.CheckBoxTeknologi.AutoSize = True
        Me.CheckBoxTeknologi.Location = New System.Drawing.Point(6, 100)
        Me.CheckBoxTeknologi.Name = "CheckBoxTeknologi"
        Me.CheckBoxTeknologi.Size = New System.Drawing.Size(114, 29)
        Me.CheckBoxTeknologi.TabIndex = 2
        Me.CheckBoxTeknologi.Text = "Teknologi"
        Me.CheckBoxTeknologi.UseVisualStyleBackColor = True
        '
        'CheckBoxSosial
        '
        Me.CheckBoxSosial.AutoSize = True
        Me.CheckBoxSosial.Location = New System.Drawing.Point(6, 65)
        Me.CheckBoxSosial.Name = "CheckBoxSosial"
        Me.CheckBoxSosial.Size = New System.Drawing.Size(84, 29)
        Me.CheckBoxSosial.TabIndex = 1
        Me.CheckBoxSosial.Text = "Sosial"
        Me.CheckBoxSosial.UseVisualStyleBackColor = True
        '
        'CheckBoxSains
        '
        Me.CheckBoxSains.AutoSize = True
        Me.CheckBoxSains.Location = New System.Drawing.Point(6, 30)
        Me.CheckBoxSains.Name = "CheckBoxSains"
        Me.CheckBoxSains.Size = New System.Drawing.Size(79, 29)
        Me.CheckBoxSains.TabIndex = 0
        Me.CheckBoxSains.Text = "Sains"
        Me.CheckBoxSains.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tambah_koleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 858)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePickerTglMasuk)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.TxtLokasiRak)
        Me.Controls.Add(Me.TxtTahunTerbit)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.Rtxtdeskripsi)
        Me.Controls.Add(Me.CbxJenisKoleksi)
        Me.Controls.Add(Me.LblKategori)
        Me.Controls.Add(Me.gr)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.LblTglMasuk)
        Me.Controls.Add(Me.LblLokasiRak)
        Me.Controls.Add(Me.LblTahun)
        Me.Controls.Add(Me.LblPenerbit)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.LblJenis)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.BtnTambahGambarSampul)
        Me.Controls.Add(Me.PictureBoxSampulKoleksi)
        Me.Controls.Add(Me.LblTambahKoleksi)
        Me.Controls.Add(Me.BtnTambahKoleksi)
        Me.Controls.Add(Me.TxtNamaKoleksi)
        Me.Name = "tambah_koleksi"
        Me.Text = "Form1"
        CType(Me.PictureBoxSampulKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNamaKoleksi As TextBox
    Friend WithEvents BtnTambahKoleksi As Button
    Friend WithEvents LblTambahKoleksi As Label
    Friend WithEvents PictureBoxSampulKoleksi As PictureBox
    Friend WithEvents BtnTambahGambarSampul As Button
    Friend WithEvents LblNama As Label
    Friend WithEvents LblJenis As Label
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents LblPenerbit As Label
    Friend WithEvents LblTahun As Label
    Friend WithEvents LblLokasiRak As Label
    Friend WithEvents LblTglMasuk As Label
    Friend WithEvents LblStock As Label
    Friend WithEvents gr As Label
    Friend WithEvents LblKategori As Label
    Friend WithEvents CbxJenisKoleksi As ComboBox
    Friend WithEvents Rtxtdeskripsi As RichTextBox
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents TxtTahunTerbit As TextBox
    Friend WithEvents TxtLokasiRak As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents DateTimePickerTglMasuk As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbtnEng As RadioButton
    Friend WithEvents RdbtnInd As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBoxBudaya As CheckBox
    Friend WithEvents CheckBoxTeknologi As CheckBox
    Friend WithEvents CheckBoxSosial As CheckBox
    Friend WithEvents CheckBoxSains As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
