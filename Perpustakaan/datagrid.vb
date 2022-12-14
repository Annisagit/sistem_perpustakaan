Public Class datagrid
    Public Shared selectedTableKoleksi As Integer
    Dim selectedTableKoleksiNama As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = perpustakaan.data_koleksi.GetDataKoleksiDatabase()
    End Sub
    Public Sub UpdateDataTableArrayList()
        DataGridView1.Rows.Clear()
        For Each rowKoleksi In perpustakaan.data_koleksi.getKoleksiDataTable()
            Dim dataTable As String() = {rowKoleksi(1), rowKoleksi(2), rowKoleksi(3), rowKoleksi(4), rowKoleksi(5), rowKoleksi(6), rowKoleksi(7), rowKoleksi(8), rowKoleksi(9), rowKoleksi(10)}
            DataGridView1.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub datagrid_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'selectedTableKoleksi = DataGridView1.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    'Private Sub BtnShowDataGrid_Click(sender As Object, e As EventArgs) Handles BtnShowDataGrid.Click
    '    Dim dataselected = perpustakaan.data_koleksi.getKoleksiDataTable.Item(selectedTableKoleksi)

    '    perpustakaan.data_koleksi.GSFoto = dataselected(0)
    '    perpustakaan.data_koleksi.GSNama = dataselected(1)
    '    perpustakaan.data_koleksi.GSJenis = dataselected(2)
    '    perpustakaan.data_koleksi.GSDeskripsi = dataselected(3)
    '    perpustakaan.data_koleksi.GSPenertbit = dataselected(4)
    '    perpustakaan.data_koleksi.GSThnTerbit = dataselected(5)
    '    perpustakaan.data_koleksi.GSLokasiRak = dataselected(6)
    '    perpustakaan.data_koleksi.GSTanggalMasuk = dataselected(7)
    '    perpustakaan.data_koleksi.GSStock = dataselected(8)
    '    perpustakaan.data_koleksi.GSBahasa = dataselected(9)

    '    Dim koleksi_data As List(Of String) = perpustakaan.data_koleksi.ConvertStringToKoleksi(dataselected(10))

    '    For Each info_tambah In koleksi_data

    '        perpustakaan.data_koleksi.AddKategori(info_tambah)
    '    Next

    '    Dim infoTambah = New info_tambah_koleksi()
    '    infoTambah.Show()
    'End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selectedKoleksi As List(Of String) = perpustakaan.data_koleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        perpustakaan.data_koleksi.GSFoto = selectedKoleksi(2)
        perpustakaan.data_koleksi.GSNama = selectedKoleksi(1)
        perpustakaan.data_koleksi.GSJenis = selectedKoleksi(5)
        perpustakaan.data_koleksi.GSDeskripsi = selectedKoleksi(3)
        perpustakaan.data_koleksi.GSPenertbit = selectedKoleksi(4)
        perpustakaan.data_koleksi.GSThnTerbit = selectedKoleksi(6)
        perpustakaan.data_koleksi.GSLokasiRak = selectedKoleksi(7)
        perpustakaan.data_koleksi.GSTanggalMasuk = selectedKoleksi(8)
        perpustakaan.data_koleksi.GSStock = selectedKoleksi(9)
        perpustakaan.data_koleksi.GSBahasa = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = perpustakaan.data_koleksi.ConvertStringToKoleksi(selectedKoleksi(11))


        For Each info_kategori In data_kategori
            perpustakaan.data_koleksi.AddKategori(info_kategori)
        Next

        Dim formUpdate = New UpdateKoleksi()
        formUpdate.Show()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim formhapus = New hapuskoleksi()
        formhapus.Show()
    End Sub

    Private Sub Btnselect_Click(sender As Object, e As EventArgs) Handles Btnselect.Click
        Dim selectedKoleksi As List(Of String) = perpustakaan.data_koleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        perpustakaan.data_koleksi.GSFoto = selectedKoleksi(2)
        perpustakaan.data_koleksi.GSNama = selectedKoleksi(1)
        perpustakaan.data_koleksi.GSJenis = selectedKoleksi(5)
        perpustakaan.data_koleksi.GSDeskripsi = selectedKoleksi(3)
        perpustakaan.data_koleksi.GSPenertbit = selectedKoleksi(4)
        perpustakaan.data_koleksi.GSThnTerbit = selectedKoleksi(6)
        perpustakaan.data_koleksi.GSLokasiRak = selectedKoleksi(7)
        perpustakaan.data_koleksi.GSTanggalMasuk = selectedKoleksi(8)
        perpustakaan.data_koleksi.GSStock = selectedKoleksi(9)
        perpustakaan.data_koleksi.GSBahasa = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = perpustakaan.data_koleksi.ConvertStringToKoleksi(selectedKoleksi(11))


        For Each info_kategori In data_kategori
            perpustakaan.data_koleksi.AddKategori(info_kategori)
        Next

        Dim formInfo = New info_tambah_koleksi()
        formInfo.Show()
    End Sub
End Class