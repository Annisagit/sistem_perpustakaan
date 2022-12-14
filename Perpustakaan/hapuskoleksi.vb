Public Class hapuskoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        LblNamaItem.Text = perpustakaan.koleksi_perpus


    End Sub

    Private Sub BtnKonfirmasiHapus_Click(sender As Object, e As EventArgs) Handles BtnKonfirmasiHapus.Click
        'perpustakaan.data_koleksi.RemoveKoleksi(perpustakaan.ListboxKoleksiBuku.SelectedItem)
        'perpustakaan.data_koleksi.getKoleksiDataTable.Remove(perpustakaan.data_koleksi.GSNama = perpustakaan.ListboxKoleksiBuku.SelectedItem)
        perpustakaan.data_koleksi.DeleteDataKoleksiByIDDatabase(datagrid.selectedTableKoleksi)
        Me.Close()
    End Sub

End Class