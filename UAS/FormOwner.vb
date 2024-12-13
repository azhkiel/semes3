Imports MySql.Data.MySqlClient

Public Class FormOwner
    Private Sub FormOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMenu()
        With ListViewMenu
            .Columns.Clear() ' Hapus kolom yang ada jika ada
            .Columns.Add("Nama Menu", 150) ' Lebar kolom 150 piksel
            .Columns.Add("Kategori", 100) ' Lebar kolom 100 piksel
            .Columns.Add("Harga", 100) ' Lebar kolom 100 piksel
            .Columns.Add("Stok saat ini", 100) ' Lebar kolom 100 piksel
            .View = View.Details ' Mengatur tampilan menjadi detail
        End With
        LoadHistoryPembelian()
        ' Inisialisasi kolom untuk ListViewHistoryPembelian
        With ListViewHistoryPembelian
            .Columns.Clear() ' Hapus kolom yang ada jika ada
            .Columns.Add("Username", 100) ' Lebar kolom 100 piksel
            .Columns.Add("Nama Menu", 150) ' Lebar kolom 150 piksel
            .Columns.Add("Jumlah", 70) ' Lebar kolom 70 piksel
            .Columns.Add("Harga Total", 100) ' Lebar kolom 100 piksel
            .Columns.Add("Waktu", 120) ' Lebar kolom 120 piksel
            .Columns.Add("Stok Tersisa", 70) ' Lebar kolom 70 piksel
            .View = View.Details ' Mengatur tampilan menjadi detail
        End With
        LoadTotalPendapatan()
    End Sub
    Private Sub LoadMenu()
        Try
            Using conn As MySqlConnection = GetKoneksi()
                Dim cmd As New MySqlCommand("SELECT nama_Menu, kategori, harga, stok FROM menu", conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                ListViewMenu.Items.Clear()

                While reader.Read()
                    Dim item As New ListViewItem(reader("nama_Menu").ToString())
                    item.SubItems.Add(reader("kategori").ToString())
                    item.SubItems.Add(Convert.ToDecimal(reader("harga")).ToString("F2"))
                    item.SubItems.Add(reader("stok").ToString()) ' Tambahkan stok sebagai subitem baru
                    ListViewMenu.Items.Add(item)
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnTambahMenu_Click(sender As Object, e As EventArgs) Handles btnTambahMenu.Click
        Dim namaMenu As String = InputBox("Masukkan nama Menu:", "Tambah Menu")
        Dim kategoriMenu As String = InputBox("Masukkan kategori Menu:", "Tambah Menu")
        Dim hargaMenuInput As String = InputBox("Masukkan harga Menu:", "Tambah Menu")
        Dim hargaMenu As Decimal
        Dim stokInput As String = InputBox("Masukkan stok Menu:", "Tambah Menu")
        Dim stok As Integer

        ' Validasi input harga dan stok
        If Decimal.TryParse(hargaMenuInput, hargaMenu) AndAlso
           Integer.TryParse(stokInput, stok) AndAlso
           Not String.IsNullOrWhiteSpace(namaMenu) AndAlso
           Not String.IsNullOrWhiteSpace(kategoriMenu) Then
            'stok > 0 AndAlso

            Try
                Using conn As MySqlConnection = GetKoneksi()
                    Dim cmd As New MySqlCommand("INSERT INTO Menu (nama_Menu, kategori, harga, stok) VALUES (@nama, @kategori, @harga, @stok)", conn)
                    cmd.Parameters.AddWithValue("@nama", namaMenu)
                    cmd.Parameters.AddWithValue("@kategori", kategoriMenu)
                    cmd.Parameters.AddWithValue("@harga", hargaMenu)
                    cmd.Parameters.AddWithValue("@stok", stok) ' Menambahkan parameter untuk stok
                    conn.Open()
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Menu berhasil ditambahkan.")
                    LoadMenu() ' Refresh ListViewMenu
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Input tidak valid. Pastikan semua field diisi dan stok minimal 20.")
        End If
    End Sub

    Private Sub EditMenu()
        If ListViewMenu.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewMenu.SelectedItems(0)

            ' Mendapatkan nilai saat ini dari Menu
            Dim namaMenuLama As String = selectedItem.SubItems(0).Text
            Dim namaMenuBaru As String = InputBox("Edit nama Menu:", "Edit Menu", namaMenuLama)
            Dim kategoriMenu As String = InputBox("Edit kategori Menu:", "Edit Menu", selectedItem.SubItems(1).Text)
            Dim hargaMenuInput As String = InputBox("Edit harga Menu:", "Edit Menu", selectedItem.SubItems(2).Text)
            Dim hargaMenu As Decimal
            Dim stokInput As String = InputBox("Edit stok Menu:", "Edit Menu", selectedItem.SubItems(3).Text) ' Menambahkan input untuk stok
            Dim stok As Integer

            ' Validasi harga Menu dan stok
            If Decimal.TryParse(hargaMenuInput, hargaMenu) AndAlso Integer.TryParse(stokInput, stok) Then
                Try
                    ' Update ke database
                    Using conn As MySqlConnection = GetKoneksi()
                        Dim cmd As New MySqlCommand("UPDATE Menu SET nama_Menu = @namaBaru, kategori = @kategori, harga = @harga, stok = @stok WHERE nama_Menu = @namaLama", conn)
                        cmd.Parameters.AddWithValue("@namaLama", namaMenuLama)
                        cmd.Parameters.AddWithValue("@namaBaru", namaMenuBaru)
                        cmd.Parameters.AddWithValue("@kategori", kategoriMenu)
                        cmd.Parameters.AddWithValue("@harga", hargaMenu)
                        cmd.Parameters.AddWithValue("@stok", stok) ' Menambahkan parameter untuk stok
                        conn.Open()
                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Menu berhasil diperbarui.")
                        LoadMenu() ' Muat ulang ListView untuk menampilkan perubahan
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Input tidak valid.")
            End If
        Else
            MessageBox.Show("Silakan pilih Menu yang ingin diedit.")
        End If
    End Sub
    Private Sub HapusMenu()
        If ListViewMenu.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewMenu.SelectedItems(0)
            Dim namaMenu As String = selectedItem.SubItems(0).Text

            ' Memeriksa stok sebelum menghapus
            Dim stok As Integer = Convert.ToInt32(selectedItem.SubItems(3).Text) ' Mengambil stok dari ListView

            If stok > 0 Then
                MessageBox.Show("Menu ini masih memiliki stok. Silakan hapus stok terlebih dahulu sebelum menghapus Menu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If MessageBox.Show("Apakah Anda yakin ingin menghapus Menu ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Using conn As MySqlConnection = GetKoneksi()
                        Dim cmd As New MySqlCommand("DELETE FROM Menu WHERE nama_Menu = @nama", conn)
                        cmd.Parameters.AddWithValue("@nama", namaMenu)
                        conn.Open()
                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Menu berhasil dihapus.")
                        LoadMenu()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Silakan pilih Menu yang ingin dihapus.")
        End If
    End Sub

    Private Sub ContextMenuEdit_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        EditMenu()
    End Sub

    Private Sub ContextMenuHapus_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        HapusMenu()
    End Sub
    Private Sub LoadTotalPendapatan()
        Try
            Using conn As MySqlConnection = GetKoneksi()
                Dim cmd As New MySqlCommand("SELECT SUM(harga_total) AS TotalPendapatan FROM `order`", conn)
                conn.Open()
                Dim total As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                LabelTotalPendapatan.Text = "Total Pendapatan: " & total.ToString("F2")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadHistoryPembelian()
        Try
            Using conn As MySqlConnection = GetKoneksi()
                ' Kueri untuk menampilkan history pembelian dengan stok tersisa
                Dim cmd As New MySqlCommand("SELECT c.username, pr.nama_Menu, pd.jumlah, pd.harga_total, pd.waktu, pr.stok " &
                                        "FROM `order` pd " &
                                        "JOIN `user`  c ON pd.username = c.username " &
                                        "JOIN Menu pr ON pd.nama_Menu = pr.nama_Menu " &
                                        "ORDER BY pd.waktu DESC", conn)

                conn.Open()

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                ListViewHistoryPembelian.Items.Clear()

                While reader.Read()
                    Dim item As New ListViewItem(reader("username").ToString())
                    item.SubItems.Add(reader("nama_Menu").ToString())
                    item.SubItems.Add(reader("jumlah").ToString())
                    item.SubItems.Add(reader("harga_total").ToString())
                    item.SubItems.Add(Convert.ToDateTime(reader("waktu")).ToString("yyyy-MM-dd HH:mm:ss"))
                    item.SubItems.Add(reader("stok").ToString()) ' Tambahkan stok ke tampilan

                    ListViewHistoryPembelian.Items.Add(item)
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formLogin As New FormLogin()
        formLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnData_Click(sender As Object, e As EventArgs) Handles btnData.Click
        FormData.Show()
        Me.Close()
    End Sub
End Class