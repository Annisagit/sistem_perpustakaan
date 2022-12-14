Public Class info_tambah_koleksi
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(perpustakaan.data_koleksi.GSFoto) Then
            PictureBoxKoleksiTampil.Load(perpustakaan.data_koleksi.GSFoto)
            PictureBoxKoleksiTampil.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblValueNama.Text = perpustakaan.data_koleksi.GSNama
        LblValJenis.Text = perpustakaan.data_koleksi.GSJenis
        Lblvaldeskripsi.Text = perpustakaan.data_koleksi.GSDeskripsi
        LblValPenerbit.Text = perpustakaan.data_koleksi.GSPenertbit
        LblValTahun.Text = perpustakaan.data_koleksi.GSThnTerbit
        LblValLokasi.Text = perpustakaan.data_koleksi.GSLokasiRak
        LblValTanggal.Text = perpustakaan.data_koleksi.GSTanggalMasuk
        LblValStock.Text = perpustakaan.data_koleksi.GSStock
        LblValBahasa.Text = perpustakaan.data_koleksi.GSBahasa

        ListBoxValueKategori.Items.Clear()

        For Each kel In perpustakaan.data_koleksi.getKategoriItem
            ListBoxValueKategori.Items.Add(kel)
        Next
    End Sub
    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        perpustakaan.data_koleksi.GSFoto = ""
        Me.Close()
    End Sub
End Class