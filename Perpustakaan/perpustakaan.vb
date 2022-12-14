Public Class perpustakaan

    Public Shared data_koleksi As DataKoleksi
    Public Shared data_user As users
    Public Shared koleksi_perpus As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        data_koleksi = New DataKoleksi()
        'tambah_koleksi.CbxJenisKoleksi.DataSource = data_koleksi.GSJenis
    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim tbhkoleksi = New tambah_koleksi()
        tbhkoleksi.Show()
    End Sub

    Private Sub ToolStripBtnPlus_Click(sender As Object, e As EventArgs) Handles ToolStripBtnPlus.Click
        Dim tbhkoleksi = New tambah_koleksi()
        tbhkoleksi.Show()
    End Sub

    Private Sub ToolStripBtnMinus_Click(sender As Object, e As EventArgs) Handles ToolStripBtnMinus.Click
        Dim name_koleksi As String
        name_koleksi = ListboxKoleksiBuku.SelectedItem()

        If name_koleksi = "" Then
            MessageBox.Show("Pilih koleksi yang dihapus!")
        Else
            Dim hpskoleksi = New hapuskoleksi()
            hpskoleksi.Show()
        End If

    End Sub

    Private Sub perpustakaan_activated(sender As Object, e As EventArgs) Handles Me.Activated
    End Sub

    Private Sub ListboxKoleksiBuku_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListboxKoleksiBuku.SelectedIndexChanged
        'koleksi_perpus = ListboxKoleksiBuku.SelectedItem()
    End Sub

    Private Sub ArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrayToolStripMenuItem.Click
        Dim contoharray = New ctharray()
        contoharray.Show()
    End Sub



    Private Sub KoleksiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KoleksiToolStripMenuItem1.Click
        Dim daftar_koleksi = New datagrid()
        daftar_koleksi.Show()
    End Sub

End Class