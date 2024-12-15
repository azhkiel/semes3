Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FormAdmin
    ' Menyimpan nama customer setelah login
    Public Property CustomerName As String
    Dim nomorAntrian As String = GenerateQueueId()

    ' Event handler yang dijalankan ketika FormBelanja dimuat
    Private Sub FormBelanja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AntrianBaru()

        ' Konfigurasi ListView untuk menampilkan menu belanja
        ListViewBelanja.FullRowSelect = True ' Pilih seluruh baris ketika item dipilih
        ListViewBelanja.View = View.Details ' Menampilkan data dalam format detail

        ' Konfigurasi ListView untuk menampilkan pesanan
        ListViewPesanan.FullRowSelect = True
        ListViewPesanan.View = View.Details

        ' Menambahkan kolom pada ListViewBelanja
        ListViewBelanja.Columns.Add("Nama Menu", 150)
        ListViewBelanja.Columns.Add("Kategori", 100)
        ListViewBelanja.Columns.Add("Harga", 100)
        ListViewBelanja.Columns.Add("Stok", 80)
        ListViewBelanja.Columns.Add("Deskripsi", 250)

        ' Menginisialisasi ContextMenu untuk pengelolaan pesanan
        InitializeContextMenu()

        ' Menambahkan kolom pada ListViewPesanan
        ListViewPesanan.Columns.Add("Nama Menu", 150)
        ListViewPesanan.Columns.Add("Kategori", 80)
        ListViewPesanan.Columns.Add("Jumlah", 80)
        ListViewPesanan.Columns.Add("Total Harga", 100)

        ' Memuat data menu dari database
        LoadDataBelanja(ListViewBelanja)
    End Sub

    ' Event handler untuk saat memilih item di ListViewBelanja
    Private Sub ListViewBelanja_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewBelanja.SelectedIndexChanged
        ' Cek jika ada item yang dipilih di ListViewBelanja
        If ListViewBelanja.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewBelanja.SelectedItems(0)
            Dim namaMenu As String = selectedItem.SubItems(0).Text ' Nama menu
            Dim kategori As String = selectedItem.SubItems(1).Text ' Kategori produk
            Dim harga As Decimal = Convert.ToDecimal(selectedItem.SubItems(2).Text) ' Harga per item
            Dim stok As Integer = Convert.ToInt32(selectedItem.SubItems(3).Text) ' Stok tersedia
            Dim deskripsi As String = selectedItem.SubItems(4).Text ' Deskripsi produk

            ' Menampilkan input box untuk meminta jumlah pesanan
            Dim inputJumlah As String = InputBox("Masukkan jumlah untuk " & namaMenu, "Input Jumlah")
            Dim jumlah As Integer

            If Integer.TryParse(inputJumlah, jumlah) AndAlso jumlah > 0 Then
                ' Validasi stok
                If stok = 0 Then
                    MessageBox.Show("Stok untuk produk ini habis.", "Stok Habis", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                ElseIf jumlah > stok Then
                    MessageBox.Show("Jumlah yang dipesan melebihi stok yang tersedia (" & stok & "). Harap kurangi jumlah pesanan.", "Stok Tidak Cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Menghitung total harga pesanan
                Dim totalHarga As Decimal = jumlah * harga

                ' Menambahkan pesanan ke ListViewPesanan
                Dim pesananItem As New ListViewItem(namaMenu)
                pesananItem.SubItems.Add(kategori) ' Menambahkan kategori ke ListViewPesanan
                pesananItem.SubItems.Add(jumlah.ToString()) ' Menambahkan jumlah pesanan
                pesananItem.SubItems.Add(totalHarga.ToString("F2")) ' Menambahkan total harga
                ListViewPesanan.Items.Add(pesananItem)
            Else
                MessageBox.Show("Jumlah tidak valid. Harap masukkan angka positif.")
            End If
        End If
    End Sub

    ' Inisialisasi ContextMenuStrip yang akan muncul saat item dipilih di ListViewPesanan
    Private contextMenu As ContextMenuStrip
    Private Sub InitializeContextMenu()
        ' Membuat instance dari ContextMenuStrip
        contextMenu = New ContextMenuStrip()

        ' Membuat item "Ubah" dalam context menu
        Dim menuItemUbah As New ToolStripMenuItem("Ubah")
        ' Menambahkan event handler untuk klik item "Ubah"
        AddHandler menuItemUbah.Click, AddressOf MenuItemUbah_Click
        ' Menambahkan item "Ubah" ke ContextMenuStrip
        contextMenu.Items.Add(menuItemUbah)

        ' Membuat item "Hapus" dalam context menu
        Dim menuItemHapus As New ToolStripMenuItem("Hapus")
        ' Menambahkan event handler untuk klik item "Hapus"
        AddHandler menuItemHapus.Click, AddressOf MenuItemHapus_Click
        ' Menambahkan item "Hapus" ke ContextMenuStrip
        contextMenu.Items.Add(menuItemHapus)
    End Sub

    ' Event handler untuk saat memilih item di ListViewPesanan
    Private Sub ListViewPesanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewPesanan.SelectedIndexChanged
        ' Cek jika ada item yang dipilih di ListViewPesanan
        If ListViewPesanan.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewPesanan.SelectedItems(0)
            ' Mendapatkan posisi mouse saat ini
            Dim mousePos As Point = ListViewPesanan.PointToClient(Cursor.Position)
            ' Menampilkan context menu pada posisi mouse
            contextMenu.Show(ListViewPesanan, mousePos)
        End If
    End Sub

    ' Event handler untuk item "Ubah" dalam context menu
    Private Sub MenuItemUbah_Click(sender As Object, e As EventArgs)
        If ListViewPesanan.SelectedItems.Count > 0 Then
            ' Mengambil item yang dipilih
            Dim selectedItem As ListViewItem = ListViewPesanan.SelectedItems(0)
            ' Menampilkan input box untuk mengubah jumlah
            Dim inputJumlah As String = InputBox("Masukkan jumlah baru untuk " & selectedItem.Text, "Ubah Jumlah")

            Dim jumlahBaru As Integer
            If Integer.TryParse(inputJumlah, jumlahBaru) AndAlso jumlahBaru > 0 Then
                ' Mengupdate jumlah dan total harga
                selectedItem.SubItems(2).Text = jumlahBaru.ToString()
                ' Menghitung ulang harga berdasarkan jumlah baru
                Dim hargaPerItem As Decimal = Convert.ToDecimal(selectedItem.SubItems(3).Text) / Convert.ToDecimal(selectedItem.SubItems(2).Text)
                selectedItem.SubItems(3).Text = (hargaPerItem * jumlahBaru).ToString("F2")
            Else
                MessageBox.Show("Jumlah tidak valid. Harap masukkan angka positif.")
            End If
        End If
    End Sub

    ' Event handler untuk item "Hapus" dalam context menu
    Private Sub MenuItemHapus_Click(sender As Object, e As EventArgs)
        If ListViewPesanan.SelectedItems.Count > 0 Then
            ' Mengambil item yang dipilih
            Dim selectedItem As ListViewItem = ListViewPesanan.SelectedItems(0)
            ' Konfirmasi untuk menghapus pesanan
            Dim confirm = MessageBox.Show($"Apakah Anda yakin ingin menghapus pesanan {selectedItem.Text}?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirm = DialogResult.Yes Then
                ' Menghapus item dari ListViewPesanan
                ListViewPesanan.Items.Remove(selectedItem)
            End If
        End If
    End Sub

    Private Sub btnBayarPesanan_Click(sender As Object, e As EventArgs) Handles btnBayarPesanan.Click
        ' Memeriksa apakah tbUser (nama customer) kosong
        Dim cus As String = tbUser.Text
        If String.IsNullOrWhiteSpace(tbUser.Text) Then
            MessageBox.Show("Harap isi nama Customer terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ListViewPesanan.Items.Count = 0 Then
            MessageBox.Show("Tidak ada pesanan untuk dibayar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim totalBayar As Decimal = 0
        Dim daftarPesanan As New StringBuilder()

        ' Menghitung total dan mengumpulkan daftar pesanan
        For Each item As ListViewItem In ListViewPesanan.Items
            Dim namaMenu As String = item.SubItems(0).Text
            Dim kategori As String = item.SubItems(1).Text
            Dim jumlah As Integer = Convert.ToInt32(item.SubItems(2).Text)
            Dim totalHarga As Decimal = Convert.ToDecimal(item.SubItems(3).Text)

            totalBayar += totalHarga
            daftarPesanan.AppendLine($"{namaMenu} ({kategori}) x{jumlah} - {totalHarga.ToString("F2")}")

            ' Simpan Data ke tabel pendapatan untuk setiap produk
            If SimpanOrder(CustomerName, namaMenu, kategori, jumlah, totalHarga, nomorAntrian, cus) Then
                ' Hanya Update stok jika simpan pendapatan berhasil
                If UpdateStokProduk(namaMenu, jumlah) Then
                    ' Update stok di ListViewBelanja
                    UpdateListViewBelanjaStok(namaMenu, jumlah)
                Else
                    MessageBox.Show("Gagal memperbarui stok untuk produk: " & namaMenu, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Else
                MessageBox.Show("Gagal menyimpan pendapatan untuk produk: " & namaMenu, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        ' Mengambil waktu transaksi saat ini
        Dim waktuTransaksi As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        ' Membuat nota pembayaran
        Dim nota As String = $"========= NOTA PEMBAYARAN ========={Environment.NewLine}" &
                         $"Nomor Antrian: {nomorAntrian}{Environment.NewLine}" &
                         $"Nama Customer: {cus}{Environment.NewLine}" &
                         $"Waktu: {waktuTransaksi}{Environment.NewLine}" &
                         "===================================" & Environment.NewLine &
                         "Daftar Pesanan:" & Environment.NewLine &
                         daftarPesanan.ToString() &
                         "-----------------------------------" & Environment.NewLine &
                         $"Total Bayar: Rp {totalBayar.ToString("N2")}{Environment.NewLine}" &
                         "===================================" & Environment.NewLine &
                         "Terima kasih telah berbelanja!" & Environment.NewLine &
                         "Semoga hari Anda menyenangkan!" & Environment.NewLine &
                         "==================================="

        ' Menampilkan form nota dengan opsi untuk mencetak
        Dim formNota As New FormNota()
        formNota.NotaPembayaran = nota
        formNota.antrian = nomorAntrian
        formNota.Show()

        ' Membersihkan data setelah transaksi selesai
        ListViewPesanan.Items.Clear()
        LoadDataBelanja(ListViewBelanja)
        AntrianBaru()
    End Sub


    Public Function SimpanOrder(CustomerName As String, namaMenu As String, kategori As String, jumlah As Integer, totalharga As Decimal, nomorAntrian As String, cus As String) As Boolean
        Try
            ' Pastikan koneksi database sudah benar
            Using conn As MySqlConnection = GetKoneksi()
                ' Query SQL untuk memasukkan data pesanan
                Dim cmd As New MySqlCommand("INSERT INTO `order` (`username`, `nama_Menu`, `kategori`, `jumlah`, `harga_total`, `waktu`, `no_antrian`, `who`) VALUES (@customerName, @namaMenu, @kategori, @jumlah, @totalHarga, @purchaseDate, @antrian,@cus)", conn)

                ' Menambahkan parameter yang sesuai dengan kolom tabel 'order'
                cmd.Parameters.AddWithValue("@customerName", CustomerName)
                cmd.Parameters.AddWithValue("@namaMenu", namaMenu)
                cmd.Parameters.AddWithValue("@kategori", kategori)
                cmd.Parameters.AddWithValue("@jumlah", jumlah)
                cmd.Parameters.AddWithValue("@totalHarga", totalharga)
                cmd.Parameters.AddWithValue("@purchaseDate", DateTime.Now)
                cmd.Parameters.AddWithValue("@antrian", nomorAntrian)
                cmd.Parameters.AddWithValue("@cus", cus)

                ' Membuka koneksi dan mengeksekusi query
                conn.Open()
                cmd.ExecuteNonQuery()

                Return True
            End Using
        Catch ex As Exception
            ' Menangani error jika query gagal
            MessageBox.Show("Gagal menyimpan pendapatan: " & ex.Message)
            Return False
        End Try
    End Function
    ' Fungsi untuk memperbarui stok produk di ListViewBelanja
    Private Sub UpdateListViewBelanjaStok(namaMenu As String, jumlahDikurangi As Integer)
        For Each item As ListViewItem In ListViewBelanja.Items
            If item.SubItems(0).Text = namaMenu Then ' Asumsikan nama produk ada di subitem 0
                Dim currentStock As Integer = Convert.ToInt32(item.SubItems(3).Text) ' Asumsikan stok ada di subitem 4
                item.SubItems(3).Text = (currentStock - jumlahDikurangi).ToString()
                Exit For
            End If
        Next
    End Sub

    ' Fungsi untuk memperbarui stok produk di database
    Private Function UpdateStokProduk(namaMenu As String, jumlahDikurangi As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetKoneksi()
                Dim cmd As New MySqlCommand("UPDATE menu SET stok = stok - @jumlahDikurangi WHERE nama_Menu = @namaMenu", conn)
                cmd.Parameters.AddWithValue("@namaMenu", namaMenu)
                cmd.Parameters.AddWithValue("@jumlahDikurangi", jumlahDikurangi)
                conn.Open()
                cmd.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saat memperbarui stok: " & ex.Message)
            Return False
        End Try
    End Function
    Private Function GenerateQueueId() As String
        Dim newQueueID As String = ""
        Dim lastQueueID As String = ""
        Dim query As String = "SELECT no_antrian FROM `order` ORDER BY no_antrian DESC LIMIT 1"
        Dim conn As MySqlConnection = GetKoneksi()
        Using command As New MySqlCommand(query, conn)
            Try
                conn.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    lastQueueID = reader("no_antrian").ToString()
                End If
                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("Error : " & ex.Message)
            Finally
                'Pastikan koneksi ditutup
                conn.Close()
            End Try
        End Using
        ' Step 2: Generate new Order ID based on the last Order ID
        If lastQueueID = "" Then
            ' If no records found, start with a base ID
            newQueueID = "antrian00001"
        Else
            ' Extract the numeric part and increment it
            Dim numericPart As Integer = Integer.Parse(lastQueueID.Substring(7)) ' Extracts the number after "ORD"
            numericPart += 1
            newQueueID = "antrian" & numericPart.ToString("D5") ' Formats to ensure 4 digits, e.g., ORD1002
        End If
        Return newQueueID
    End Function
    Private Sub AntrianBaru()
        Dim antrianbaru As String = GenerateQueueId()
        ' Update label dengan nomor antrian yang baru
        lblAntrian.Text = $"Nomor Antrian : {antrianbaru}"
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim formLogin As New FormLogin()
        formLogin.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FormInvoice.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FormAM.Show()
        Me.Close()
    End Sub
End Class
