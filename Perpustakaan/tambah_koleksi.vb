Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class tambah_koleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateTimePickerTglMasuk.Format = DateTimePickerFormat.Custom
        DateTimePickerTglMasuk.CustomFormat = "yyy/MM/dd"

    End Sub
    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        perpustakaan.data_koleksi.GSNama = TxtNamaKoleksi.Text
        perpustakaan.data_koleksi.GSJenis = CbxJenisKoleksi.SelectedItem()
        perpustakaan.data_koleksi.GSDeskripsi = Rtxtdeskripsi.Text
        perpustakaan.data_koleksi.GSPenertbit = TxtPenerbit.Text
        perpustakaan.data_koleksi.GSThnTerbit = TxtTahunTerbit.Text
        perpustakaan.data_koleksi.GSLokasiRak = TxtLokasiRak.Text
        perpustakaan.data_koleksi.GSTanggalMasuk = DateTimePickerTglMasuk.Value.ToShortDateString
        perpustakaan.data_koleksi.GSStock = TxtStock.Text

        'If RdbtnEng.Checked() Then
        '    perpustakaan.data_koleksi.GSBahasa = RdbtnEng.Text
        'ElseIf RdbtnInd.Checked() Then
        '    perpustakaan.data_koleksi.GSBahasa = RdbtnInd.Text
        'End If

        If CheckBoxSains.Checked() Then
            perpustakaan.data_koleksi.AddKategori("Sains")
        End If

        If CheckBoxSosial.Checked() Then
            perpustakaan.data_koleksi.AddKategori("Sosial")
        End If

        If CheckBoxTeknologi.Checked() Then
            perpustakaan.data_koleksi.AddKategori("Teknologi")
        End If

        If CheckBoxBudaya.Checked() Then
            perpustakaan.data_koleksi.AddKategori("Budaya")
        End If

        '' Menambahkan nama ke listbox di pendaftaran
        'perpustakaan.data_koleksi.(TxtNamaKoleksi.Text)


        Dim convertedKoleksi = perpustakaan.data_koleksi.ConvertKoleksiToString(perpustakaan.data_koleksi.getKategoriItem)

        perpustakaan.data_koleksi.AddDataKoleksiDatabase(perpustakaan.data_koleksi.GSFoto,
                                                      perpustakaan.data_koleksi.GSNama,
                                                      perpustakaan.data_koleksi.GSJenis,
                                                      perpustakaan.data_koleksi.GSPenertbit,
                                                      perpustakaan.data_koleksi.GSDeskripsi,
                                                      perpustakaan.data_koleksi.GSThnTerbit,
                                                      perpustakaan.data_koleksi.GSLokasiRak,
                                                      perpustakaan.data_koleksi.GSTanggalMasuk,
                                                      perpustakaan.data_koleksi.GSStock,
                                                      perpustakaan.data_koleksi.GSBahasa,
                                                      convertedKoleksi)
        'Membuka form tampil info tambah koleksi
        Dim formtampil = New info_tambah_koleksi()
        formtampil.Show()
        Me.Close()


    End Sub

    Private Sub BtnTambahGambarSampul_Click(sender As Object, e As EventArgs) Handles BtnTambahGambarSampul.Click
        OpenFileDialog1.Title = "Tambah Gambar"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictureBoxSampulKoleksi.Load(OpenFileDialog1.FileName)
        PictureBoxSampulKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        perpustakaan.data_koleksi.GSFoto = OpenFileDialog1.FileName.ToString()
        perpustakaan.data_koleksi.GSFoto = perpustakaan.data_koleksi.GSFoto.Replace("\", "/")
    End Sub
    Private Sub TxtNamaKoleksi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNamaKoleksi.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only")
        End If
    End Sub
    Private Sub TxtPenerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPenerbit.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only")
        End If
    End Sub
    Private Sub TxtTahunTerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTahunTerbit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub
    Private Sub TxtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub RdbtnEng_CheckedChanged(sender As Object, e As EventArgs) Handles RdbtnEng.CheckedChanged
        perpustakaan.data_koleksi.GSBahasa = "Bahasa Inggris"
    End Sub

    Private Sub RdbtnInd_CheckedChanged(sender As Object, e As EventArgs) Handles RdbtnInd.CheckedChanged
        perpustakaan.data_koleksi.GSBahasa = "Bahasa Indonesia"
    End Sub
End Class
