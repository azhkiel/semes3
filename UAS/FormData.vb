Imports MySql.Data.MySqlClient

Public Class FormData
    Private Sub FormData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAkunCustomer()
        ' Inisialisasi kolom untuk ListViewAkunCustomer
        With ListViewAkunCustomer
            .Columns.Clear() ' Hapus kolom yang ada jika ada
            .Columns.Add("Username", 150) ' Lebar kolom 150 piksel
            .Columns.Add("No. Telepon", 100) ' Lebar kolom 100 piksel
            .View = View.Details ' Mengatur tampilan menjadi detail
        End With
        LoadTopCustomers()
        With ListViewTopCustomers
            .Columns.Clear() ' Hapus kolom yang ada jika ada
            .Columns.Add("Username", 150) ' Lebar kolom 150 piksel
            .Columns.Add("Total Pembelian", 100) ' Lebar kolom 100 piksel
            .View = View.Details ' Mengatur tampilan menjadi detail
        End With
        LoadTopProducts()
        With ListViewTopProducts
            .Columns.Clear() ' Hapus kolom yang ada jika ada
            .Columns.Add("Nama Produk", 150) ' Lebar kolom 150 piksel
            .Columns.Add("Total Terjual", 100) ' Lebar kolom 100 piksel
            .View = View.Details ' Mengatur tampilan menjadi detail
        End With
    End Sub
    Private Sub LoadAkunCustomer()
        Try
            Using conn As MySqlConnection = GetKoneksi()
                Dim cmd As New MySqlCommand("SELECT username, notel FROM user", conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                ListViewAkunCustomer.Items.Clear()

                While reader.Read()
                    Dim item As New ListViewItem(reader("username").ToString())
                    item.SubItems.Add(reader("notel").ToString())
                    ListViewAkunCustomer.Items.Add(item)
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadTopCustomers()
        Try
            ' Membuka koneksi ke database
            Using conn As MySqlConnection = GetKoneksi()
                ' Query untuk mendapatkan daftar pelanggan dengan total pembelian tertinggi
                Dim query As String = "
                SELECT 
                    u.username, 
                    SUM(o.harga_total) AS total_pembelian 
                FROM 
                    `order` o 
                JOIN 
                    `user` u 
                ON 
                    o.username = u.username 
                WHERE 
                    u.role = 'customer' 
                GROUP BY 
                    u.username 
                ORDER BY 
                    total_pembelian DESC;"
                Dim cmd As New MySqlCommand(query, conn)
                conn.Open()

                ' Eksekusi query dan membaca hasilnya
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                ListViewTopCustomers.Items.Clear()

                ' Menambahkan hasil ke ListView
                While reader.Read()
                    Dim item As New ListViewItem(reader("username").ToString()) ' Username pelanggan
                    item.SubItems.Add(reader("total_pembelian").ToString())     ' Total pembelian
                    ListViewTopCustomers.Items.Add(item)
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            ' Menampilkan pesan kesalahan jika ada masalah
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadTopProducts()
        Try
            ' Membuka koneksi ke database
            Using conn As MySqlConnection = GetKoneksi()
                ' Query untuk mendapatkan daftar produk terlaris
                Dim query As String = "SELECT 
                                        nama_Menu, 
                                        SUM(jumlah) AS total_terjual 
                                   FROM 
                                        `order` 
                                   GROUP BY 
                                        nama_Menu 
                                   ORDER BY 
                                        total_terjual DESC;"
                Dim cmd As New MySqlCommand(query, conn)
                conn.Open()

                ' Eksekusi query dan membaca hasilnya
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                ListViewTopProducts.Items.Clear()

                ' Menambahkan hasil ke ListView
                While reader.Read()
                    Dim item As New ListViewItem(reader("nama_Menu").ToString()) ' Nama menu
                    item.SubItems.Add(reader("total_terjual").ToString())       ' Total terjual
                    ListViewTopProducts.Items.Add(item)
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            ' Menampilkan pesan kesalahan jika ada masalah
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        FormOwner.Show()
        Me.Hide()
    End Sub
End Class