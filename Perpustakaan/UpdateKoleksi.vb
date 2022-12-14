Public Class UpdateKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        PictureBoxSampulKoleksiUpdate.Load(perpustakaan.data_koleksi.GSFoto)
        PictureBoxSampulKoleksiUpdate.SizeMode = PictureBoxSizeMode.StretchImage
        DateTimePickerUpdateTglMasuk.Format = DateTimePickerFormat.Custom
        DateTimePickerUpdateTglMasuk.CustomFormat = "yyy/MM/dd"
        TxtUpdateNamaKoleksi.Text = perpustakaan.data_koleksi.GSNama
        CbxUpdateJenisKoleksi.SelectedItem = perpustakaan.data_koleksi.GSJenis
        RtxtUpdatedeskripsi.Text = perpustakaan.data_koleksi.GSDeskripsi
        TxtUpdatePenerbit.Text = perpustakaan.data_koleksi.GSPenertbit
        TxtUpdateTahunTerbit.Text = perpustakaan.data_koleksi.GSThnTerbit
        TxtUpdateLokasiRak.Text = perpustakaan.data_koleksi.GSLokasiRak
        DateTimePickerUpdateTglMasuk.Value = perpustakaan.data_koleksi.GSTanggalMasuk
        TxtUpdateStock.Text = perpustakaan.data_koleksi.GSStock

        If String.Compare(perpustakaan.data_koleksi.GSBahasa, "Bahasa Indonesia") = 0 Then
            RdbtnInd.Checked = True
        ElseIf String.Compare(perpustakaan.data_koleksi.GSBahasa, "Bahasa Inggris") = 0 Then
            RdbtnEng.Checked = True
        End If

        For Each kategoriItem In perpustakaan.data_koleksi.getKategoriItem
            If String.Compare(kategoriItem, "Sains") = 0 Then
                CheckBoxSains.Checked = True
            ElseIf String.Compare(kategoriItem, "Sosial") = 0 Then
                CheckBoxSosial.Checked = True
            ElseIf String.Compare(kategoriItem, "Teknologi") = 0 Then
                CheckBoxTeknologi.Checked = True
            ElseIf String.Compare(kategoriItem, "Budaya") = 0 Then
                CheckBoxBudaya.Checked = True
            End If
        Next
        perpustakaan.data_koleksi.resetKategori()
    End Sub

    Private Sub BtnUpdateGambarSampul_Click(sender As Object, e As EventArgs) Handles BtnUpdateGambarSampul.Click
        OpenFileDialog1.Title = "Tambah Gambar"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictureBoxSampulKoleksiUpdate.Load(OpenFileDialog1.FileName)
        PictureBoxSampulKoleksiUpdate.SizeMode = PictureBoxSizeMode.StretchImage
        perpustakaan.data_koleksi.GSFoto = OpenFileDialog1.FileName.ToString()
        perpustakaan.data_koleksi.GSFoto = perpustakaan.data_koleksi.GSFoto.Replace("\", "/")
    End Sub

    Private Sub BtnUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles BtnUpdateKoleksi.Click
        perpustakaan.data_koleksi.GSNama = TxtUpdateNamaKoleksi.Text.ToString()
        perpustakaan.data_koleksi.GSJenis = CbxUpdateJenisKoleksi.SelectedItem().ToString()
        perpustakaan.data_koleksi.GSDeskripsi = RtxtUpdatedeskripsi.Text.ToString()
        perpustakaan.data_koleksi.GSPenertbit = TxtUpdatePenerbit.Text.ToString()
        perpustakaan.data_koleksi.GSThnTerbit = Integer.Parse(TxtUpdateTahunTerbit.Text)

        perpustakaan.data_koleksi.GSLokasiRak = TxtUpdateLokasiRak.Text.ToString()
        perpustakaan.data_koleksi.GSTanggalMasuk = DateTimePickerUpdateTglMasuk.Value.ToString("yyyy/MM/dd")
        perpustakaan.data_koleksi.GSStock = Integer.Parse(TxtUpdateStock.Text)

        If RdbtnInd.Checked Then
            perpustakaan.data_koleksi.GSBahasa = "Indonesia"
        ElseIf RdbtnEng.Checked Then
            perpustakaan.data_koleksi.GSBahasa = "Inggris"
        End If

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

        'perpustakaan.data_koleksi.AddKoleksi(TxtUpdateNamaKoleksi.Text.ToString())

        Dim convertedKoleksi = perpustakaan.data_koleksi.ConvertKoleksiToString(perpustakaan.data_koleksi.getKategoriItem)

        perpustakaan.data_koleksi.UpdateDataKoleksiByIDDatabase(datagrid.selectedTableKoleksi,
                                                                perpustakaan.data_koleksi.GSFoto,
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
        Dim infoTambah = New info_tambah_koleksi()
        infoTambah.Show()
        Me.Close()
    End Sub
End Class