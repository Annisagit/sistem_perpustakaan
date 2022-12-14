Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports System.Text

Public Class users
    Private TripleDes As New TripleDESCryptoServiceProvider
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "perpustakaan"

    Private user_username As String
    'Private user_password As String

    Public Property GSUsername() As String
        Get
            Return user_username
        End Get
        Set(value As String)
            user_username = value
        End Set
    End Property

    'Public Property GSPassword() As String
    '    Get
    '        Return user_password
    '    End Get
    '    Set(value As String)
    '        user_password = value
    '    End Set
    'End Property
    Public Function EncryptData(ByVal plaintext As String) As String
        ' Convert the plaintext string ti a byte array.
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream

        ' Create the encoder to write the stream.
        Dim encStream As New CryptoStream(ms, tripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string.
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    'Public Function CheckAuth(username As String, ByVal plainPassword As String) As String
    '    Dim DataUsername As ArrayList = New ArrayList()
    '    Dim DataPassword As ArrayList = New ArrayList()

    '    DataUsername.Add({"Annisa", "Icha"})

    '    DataPassword.Add({"1234", "4321"})

    '    ' Static Password
    '    For Each rowUsername In DataUsername
    '        For Each rowPassword In DataPassword
    '            Dim password As String = EncryptData(rowPassword(0))
    '            Dim password2 As String = EncryptData(rowPassword(1))
    '            If String.Compare(username, rowUsername(0)) = 0 And String.Compare(EncryptData(plainPassword), password) = 0 Then
    '                Return True
    '            ElseIf String.Compare(username, rowUsername(1)) = 0 And String.Compare(EncryptData(plainPassword), password2) = 0 Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        Next
    '    Next
    'End Function

    'fungsi enkripsi MD 5

    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    'fungsi tambah user pada class user
    Public Function AddUsersDatabase(username_regist As String, password_regist As String)
        Try
            Dim today = Date.Now()
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database =" + database
            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO USERS( username, password, registered_at) VALUE('" _
                        & username_regist & "', '" _
                        & EncryptMD5(password_regist) & "', '" _
                        & today.ToString("yyyy/MM/dd") & "')"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database = " + database
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT id_user, username FROM users WHERE username ='" & username_login & "' AND password='" & EncryptMD5(password_login) & "'"

            sqlCommand.CommandText = queryAuth
            'Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                'MessageBox.Show(sqlRead.HasRows)
                While sqlRead.Read()
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
