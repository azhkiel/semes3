Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    Private connectionString As String = "server=localhost;port=3307;userid=root;password=;database=mi"
    Public Function GetKoneksi() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    Public Function LoginUser(username As String, password As String) As Tuple(Of String, String)
        Using conn As MySqlConnection = GetKoneksi()
            conn.Open()
            Dim query As String = "SELECT role, username FROM user WHERE username=@username AND password=@password"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    Dim role As String = reader("role").ToString()
                    Dim nama As String = reader("username").ToString()
                    Return Tuple.Create(role, nama)
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function
    Public Sub LoadDataBelanja(listView As ListView)
        Try
            Using conn As MySqlConnection = GetKoneksi()
                Dim cmd As New MySqlCommand("SELECT nama_menu, kategori, harga, stok, deskripsi FROM menu", conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                listView.Items.Clear()
                While reader.Read()
                    Dim namaMenu As String = reader("nama_menu").ToString()
                    Dim kategori As String = reader("kategori").ToString()
                    Dim harga As String = Convert.ToDecimal(reader("harga")).ToString("F2")
                    Dim stok As String = reader("stok").ToString()
                    Dim deskripsi As String = reader("deskripsi").ToString()
                    Dim item As New ListViewItem(namaMenu)
                    item.SubItems.Add(kategori)
                    item.SubItems.Add(harga)
                    item.SubItems.Add(stok)
                    item.SubItems.Add(deskripsi)
                    listView.Items.Add(item)
                End While
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
