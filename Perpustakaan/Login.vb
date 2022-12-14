Imports Microsoft.SqlServer
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Login
    Public Shared users As users
    Public Shared Perpustakaan As New perpustakaan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Perpustakaan = New perpustakaan()
        users = New users
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPass.Text

        Dim data_user As List(Of String) = users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            users.GSUsername = data_user(1)
            Perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Salah Password")
        End If
    End Sub

    Private Sub BtnMenujuRegist_Click(sender As Object, e As EventArgs) Handles BtnMenujuRegist.Click
        Dim regist_akun As New singup()
        regist_akun.show()
    End Sub
End Class