<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateKoleksi
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
        Me.TxtUpdatePenerbit = New System.Windows.Forms.TextBox()
        Me.RtxtUpdatedeskripsi = New System.Windows.Forms.RichTextBox()
        Me.CbxUpdateJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.LblUpdatePenerbit = New System.Windows.Forms.Label()
        Me.LblUpdateDeskripsi = New System.Windows.Forms.Label()
        Me.LblUpdateJenis = New System.Windows.Forms.Label()
        Me.LblUpdateNama = New System.Windows.Forms.Label()
        Me.BtnUpdateGambarSampul = New System.Windows.Forms.Button()
        Me.PictureBoxSampulKoleksiUpdate = New System.Windows.Forms.PictureBox()
        Me.LblUpdateKoleksi = New System.Windows.Forms.Label()
        Me.TxtUpdateNamaKoleksi = New System.Windows.Forms.TextBox()
        Me.GroupBoxUpdateKategori = New System.Windows.Forms.GroupBox()
        Me.CheckBoxBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSosial = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSains = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbtnEng = New System.Windows.Forms.RadioButton()
        Me.RdbtnInd = New System.Windows.Forms.RadioButton()
        Me.DateTimePickerUpdateTglMasuk = New System.Windows.Forms.DateTimePicker()
        Me.TxtUpdateStock = New System.Windows.Forms.TextBox()
        Me.TxtUpdateLokasiRak = New System.Windows.Forms.TextBox()
        Me.TxtUpdateTahunTerbit = New System.Windows.Forms.TextBox()
        Me.LblUpdateKategori = New System.Windows.Forms.Label()
        Me.LblUpdateBahasa = New System.Windows.Forms.Label()
        Me.LblUpdateStock = New System.Windows.Forms.Label()
        Me.LblUpdateTglMasuk = New System.Windows.Forms.Label()
        Me.LblUpdateLokasiRak = New System.Windows.Forms.Label()
        Me.LblUpdateTahun = New System.Windows.Forms.Label()
        Me.BtnUpdateKoleksi = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBoxSampulKoleksiUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxUpdateKategori.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtUpdatePenerbit
        '
        Me.TxtUpdatePenerbit.Location = New System.Drawing.Point(497, 292)
        Me.TxtUpdatePenerbit.Name = "TxtUpdatePenerbit"
        Me.TxtUpdatePenerbit.Size = New System.Drawing.Size(235, 31)
        Me.TxtUpdatePenerbit.TabIndex = 28
        '
        'RtxtUpdatedeskripsi
        '
        Me.RtxtUpdatedeskripsi.Location = New System.Drawing.Point(497, 152)
        Me.RtxtUpdatedeskripsi.Name = "RtxtUpdatedeskripsi"
        Me.RtxtUpdatedeskripsi.Size = New System.Drawing.Size(235, 117)
        Me.RtxtUpdatedeskripsi.TabIndex = 27
        Me.RtxtUpdatedeskripsi.Text = "Koleksi Buku"
        '
        'CbxUpdateJenisKoleksi
        '
        Me.CbxUpdateJenisKoleksi.FormattingEnabled = True
        Me.CbxUpdateJenisKoleksi.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"})
        Me.CbxUpdateJenisKoleksi.Location = New System.Drawing.Point(497, 113)
        Me.CbxUpdateJenisKoleksi.Name = "CbxUpdateJenisKoleksi"
        Me.CbxUpdateJenisKoleksi.Size = New System.Drawing.Size(235, 33)
        Me.CbxUpdateJenisKoleksi.TabIndex = 26
        '
        'LblUpdatePenerbit
        '
        Me.LblUpdatePenerbit.AutoSize = True
        Me.LblUpdatePenerbit.Location = New System.Drawing.Point(225, 292)
        Me.LblUpdatePenerbit.Name = "LblUpdatePenerbit"
        Me.LblUpdatePenerbit.Size = New System.Drawing.Size(76, 25)
        Me.LblUpdatePenerbit.TabIndex = 25
        Me.LblUpdatePenerbit.Text = "Penerbit"
        '
        'LblUpdateDeskripsi
        '
        Me.LblUpdateDeskripsi.AutoSize = True
        Me.LblUpdateDeskripsi.Location = New System.Drawing.Point(225, 152)
        Me.LblUpdateDeskripsi.Name = "LblUpdateDeskripsi"
        Me.LblUpdateDeskripsi.Size = New System.Drawing.Size(84, 25)
        Me.LblUpdateDeskripsi.TabIndex = 24
        Me.LblUpdateDeskripsi.Text = "Deskripsi"
        '
        'LblUpdateJenis
        '
        Me.LblUpdateJenis.AutoSize = True
        Me.LblUpdateJenis.Location = New System.Drawing.Point(225, 113)
        Me.LblUpdateJenis.Name = "LblUpdateJenis"
        Me.LblUpdateJenis.Size = New System.Drawing.Size(109, 25)
        Me.LblUpdateJenis.TabIndex = 23
        Me.LblUpdateJenis.Text = "Jenis Koleksi"
        '
        'LblUpdateNama
        '
        Me.LblUpdateNama.AutoSize = True
        Me.LblUpdateNama.Location = New System.Drawing.Point(225, 77)
        Me.LblUpdateNama.Name = "LblUpdateNama"
        Me.LblUpdateNama.Size = New System.Drawing.Size(119, 25)
        Me.LblUpdateNama.TabIndex = 22
        Me.LblUpdateNama.Text = "Nama Koleksi"
        '
        'BtnUpdateGambarSampul
        '
        Me.BtnUpdateGambarSampul.Location = New System.Drawing.Point(31, 274)
        Me.BtnUpdateGambarSampul.Name = "BtnUpdateGambarSampul"
        Me.BtnUpdateGambarSampul.Size = New System.Drawing.Size(159, 34)
        Me.BtnUpdateGambarSampul.TabIndex = 21
        Me.BtnUpdateGambarSampul.Text = "Tambah Gambar"
        Me.BtnUpdateGambarSampul.UseVisualStyleBackColor = True
        '
        'PictureBoxSampulKoleksiUpdate
        '
        Me.PictureBoxSampulKoleksiUpdate.Location = New System.Drawing.Point(31, 80)
        Me.PictureBoxSampulKoleksiUpdate.Name = "PictureBoxSampulKoleksiUpdate"
        Me.PictureBoxSampulKoleksiUpdate.Size = New System.Drawing.Size(159, 188)
        Me.PictureBoxSampulKoleksiUpdate.TabIndex = 20
        Me.PictureBoxSampulKoleksiUpdate.TabStop = False
        '
        'LblUpdateKoleksi
        '
        Me.LblUpdateKoleksi.AutoSize = True
        Me.LblUpdateKoleksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblUpdateKoleksi.Location = New System.Drawing.Point(31, 24)
        Me.LblUpdateKoleksi.Name = "LblUpdateKoleksi"
        Me.LblUpdateKoleksi.Size = New System.Drawing.Size(185, 32)
        Me.LblUpdateKoleksi.TabIndex = 19
        Me.LblUpdateKoleksi.Text = "Update Koleksi"
        '
        'TxtUpdateNamaKoleksi
        '
        Me.TxtUpdateNamaKoleksi.Location = New System.Drawing.Point(497, 77)
        Me.TxtUpdateNamaKoleksi.Name = "TxtUpdateNamaKoleksi"
        Me.TxtUpdateNamaKoleksi.Size = New System.Drawing.Size(235, 31)
        Me.TxtUpdateNamaKoleksi.TabIndex = 18
        '
        'GroupBoxUpdateKategori
        '
        Me.GroupBoxUpdateKategori.Controls.Add(Me.CheckBoxBudaya)
        Me.GroupBoxUpdateKategori.Controls.Add(Me.CheckBoxTeknologi)
        Me.GroupBoxUpdateKategori.Controls.Add(Me.CheckBoxSosial)
        Me.GroupBoxUpdateKategori.Controls.Add(Me.CheckBoxSains)
        Me.GroupBoxUpdateKategori.Location = New System.Drawing.Point(497, 596)
        Me.GroupBoxUpdateKategori.Name = "GroupBoxUpdateKategori"
        Me.GroupBoxUpdateKategori.Size = New System.Drawing.Size(235, 190)
        Me.GroupBoxUpdateKategori.TabIndex = 41
        Me.GroupBoxUpdateKategori.TabStop = False
        Me.GroupBoxUpdateKategori.Text = "Kategori"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdbtnEng)
        Me.GroupBox1.Controls.Add(Me.RdbtnInd)
        Me.GroupBox1.Location = New System.Drawing.Point(497, 477)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 113)
        Me.GroupBox1.TabIndex = 40
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
        'DateTimePickerUpdateTglMasuk
        '
        Me.DateTimePickerUpdateTglMasuk.Location = New System.Drawing.Point(497, 403)
        Me.DateTimePickerUpdateTglMasuk.Name = "DateTimePickerUpdateTglMasuk"
        Me.DateTimePickerUpdateTglMasuk.Size = New System.Drawing.Size(235, 31)
        Me.DateTimePickerUpdateTglMasuk.TabIndex = 39
        '
        'TxtUpdateStock
        '
        Me.TxtUpdateStock.Location = New System.Drawing.Point(497, 440)
        Me.TxtUpdateStock.Name = "TxtUpdateStock"
        Me.TxtUpdateStock.Size = New System.Drawing.Size(235, 31)
        Me.TxtUpdateStock.TabIndex = 38
        '
        'TxtUpdateLokasiRak
        '
        Me.TxtUpdateLokasiRak.Location = New System.Drawing.Point(497, 366)
        Me.TxtUpdateLokasiRak.Name = "TxtUpdateLokasiRak"
        Me.TxtUpdateLokasiRak.Size = New System.Drawing.Size(235, 31)
        Me.TxtUpdateLokasiRak.TabIndex = 37
        '
        'TxtUpdateTahunTerbit
        '
        Me.TxtUpdateTahunTerbit.Location = New System.Drawing.Point(497, 329)
        Me.TxtUpdateTahunTerbit.Name = "TxtUpdateTahunTerbit"
        Me.TxtUpdateTahunTerbit.Size = New System.Drawing.Size(235, 31)
        Me.TxtUpdateTahunTerbit.TabIndex = 36
        '
        'LblUpdateKategori
        '
        Me.LblUpdateKategori.AutoSize = True
        Me.LblUpdateKategori.Location = New System.Drawing.Point(225, 596)
        Me.LblUpdateKategori.Name = "LblUpdateKategori"
        Me.LblUpdateKategori.Size = New System.Drawing.Size(78, 25)
        Me.LblUpdateKategori.TabIndex = 35
        Me.LblUpdateKategori.Text = "Kategori"
        '
        'LblUpdateBahasa
        '
        Me.LblUpdateBahasa.AutoSize = True
        Me.LblUpdateBahasa.Location = New System.Drawing.Point(225, 477)
        Me.LblUpdateBahasa.Name = "LblUpdateBahasa"
        Me.LblUpdateBahasa.Size = New System.Drawing.Size(67, 25)
        Me.LblUpdateBahasa.TabIndex = 34
        Me.LblUpdateBahasa.Text = "Bahasa"
        '
        'LblUpdateStock
        '
        Me.LblUpdateStock.AutoSize = True
        Me.LblUpdateStock.Location = New System.Drawing.Point(225, 440)
        Me.LblUpdateStock.Name = "LblUpdateStock"
        Me.LblUpdateStock.Size = New System.Drawing.Size(55, 25)
        Me.LblUpdateStock.TabIndex = 33
        Me.LblUpdateStock.Text = "Stock"
        '
        'LblUpdateTglMasuk
        '
        Me.LblUpdateTglMasuk.AutoSize = True
        Me.LblUpdateTglMasuk.Location = New System.Drawing.Point(225, 403)
        Me.LblUpdateTglMasuk.Name = "LblUpdateTglMasuk"
        Me.LblUpdateTglMasuk.Size = New System.Drawing.Size(190, 25)
        Me.LblUpdateTglMasuk.TabIndex = 32
        Me.LblUpdateTglMasuk.Text = "Tanggal Masuk Koleksi"
        '
        'LblUpdateLokasiRak
        '
        Me.LblUpdateLokasiRak.AutoSize = True
        Me.LblUpdateLokasiRak.Location = New System.Drawing.Point(225, 366)
        Me.LblUpdateLokasiRak.Name = "LblUpdateLokasiRak"
        Me.LblUpdateLokasiRak.Size = New System.Drawing.Size(95, 25)
        Me.LblUpdateLokasiRak.TabIndex = 31
        Me.LblUpdateLokasiRak.Text = "Lokasi Rak"
        '
        'LblUpdateTahun
        '
        Me.LblUpdateTahun.AutoSize = True
        Me.LblUpdateTahun.Location = New System.Drawing.Point(225, 329)
        Me.LblUpdateTahun.Name = "LblUpdateTahun"
        Me.LblUpdateTahun.Size = New System.Drawing.Size(106, 25)
        Me.LblUpdateTahun.TabIndex = 30
        Me.LblUpdateTahun.Text = "Tahun Terbit"
        '
        'BtnUpdateKoleksi
        '
        Me.BtnUpdateKoleksi.Location = New System.Drawing.Point(325, 804)
        Me.BtnUpdateKoleksi.Name = "BtnUpdateKoleksi"
        Me.BtnUpdateKoleksi.Size = New System.Drawing.Size(170, 34)
        Me.BtnUpdateKoleksi.TabIndex = 29
        Me.BtnUpdateKoleksi.Text = "Update Koleksi"
        Me.BtnUpdateKoleksi.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 882)
        Me.Controls.Add(Me.GroupBoxUpdateKategori)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePickerUpdateTglMasuk)
        Me.Controls.Add(Me.TxtUpdateStock)
        Me.Controls.Add(Me.TxtUpdateLokasiRak)
        Me.Controls.Add(Me.TxtUpdateTahunTerbit)
        Me.Controls.Add(Me.LblUpdateKategori)
        Me.Controls.Add(Me.LblUpdateBahasa)
        Me.Controls.Add(Me.LblUpdateStock)
        Me.Controls.Add(Me.LblUpdateTglMasuk)
        Me.Controls.Add(Me.LblUpdateLokasiRak)
        Me.Controls.Add(Me.LblUpdateTahun)
        Me.Controls.Add(Me.BtnUpdateKoleksi)
        Me.Controls.Add(Me.TxtUpdatePenerbit)
        Me.Controls.Add(Me.RtxtUpdatedeskripsi)
        Me.Controls.Add(Me.CbxUpdateJenisKoleksi)
        Me.Controls.Add(Me.LblUpdatePenerbit)
        Me.Controls.Add(Me.LblUpdateDeskripsi)
        Me.Controls.Add(Me.LblUpdateJenis)
        Me.Controls.Add(Me.LblUpdateNama)
        Me.Controls.Add(Me.BtnUpdateGambarSampul)
        Me.Controls.Add(Me.PictureBoxSampulKoleksiUpdate)
        Me.Controls.Add(Me.LblUpdateKoleksi)
        Me.Controls.Add(Me.TxtUpdateNamaKoleksi)
        Me.Name = "UpdateKoleksi"
        Me.Text = "UpdateKoleksi"
        CType(Me.PictureBoxSampulKoleksiUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxUpdateKategori.ResumeLayout(False)
        Me.GroupBoxUpdateKategori.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUpdatePenerbit As TextBox
    Friend WithEvents RtxtUpdatedeskripsi As RichTextBox
    Friend WithEvents CbxUpdateJenisKoleksi As ComboBox
    Friend WithEvents LblUpdatePenerbit As Label
    Friend WithEvents LblUpdateDeskripsi As Label
    Friend WithEvents LblUpdateJenis As Label
    Friend WithEvents LblUpdateNama As Label
    Friend WithEvents BtnUpdateGambarSampul As Button
    Friend WithEvents PictureBoxSampulKoleksiUpdate As PictureBox
    Friend WithEvents LblUpdateKoleksi As Label
    Friend WithEvents TxtUpdateNamaKoleksi As TextBox
    Friend WithEvents GroupBoxUpdateKategori As GroupBox
    Friend WithEvents CheckBoxBudaya As CheckBox
    Friend WithEvents CheckBoxTeknologi As CheckBox
    Friend WithEvents CheckBoxSosial As CheckBox
    Friend WithEvents CheckBoxSains As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbtnEng As RadioButton
    Friend WithEvents RdbtnInd As RadioButton
    Friend WithEvents DateTimePickerUpdateTglMasuk As DateTimePicker
    Friend WithEvents TxtUpdateStock As TextBox
    Friend WithEvents TxtUpdateLokasiRak As TextBox
    Friend WithEvents TxtUpdateTahunTerbit As TextBox
    Friend WithEvents LblUpdateKategori As Label
    Friend WithEvents LblUpdateBahasa As Label
    Friend WithEvents LblUpdateStock As Label
    Friend WithEvents LblUpdateTglMasuk As Label
    Friend WithEvents LblUpdateLokasiRak As Label
    Friend WithEvents LblUpdateTahun As Label
    Friend WithEvents BtnUpdateKoleksi As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
