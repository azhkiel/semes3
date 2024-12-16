Imports MySql.Data.MySqlClient

Public Class FormData
    ' Event saat FormData dimuat
    Private Sub FormData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListViewTopCustomers()
        LoadTopCustomers()
        SetupListViewTopProducts()
        LoadTopProducts()
    End Sub

    ' Konfigurasi ListView untuk pelanggan
    Private Sub SetupListViewTopCustomers()
        With ListViewTopCustomers
            .FullRowSelect = True
            .Columns.Clear()
            .Columns.Add("Username", 150)
            .Columns.Add("Total Pembelian", 100)
            .View = View.Details
        End With
    End Sub

    ' Konfigurasi ListView untuk produk
    Private Sub SetupListViewTopProducts()
        With ListViewTopProducts
            .FullRowSelect = True
            .Columns.Clear()
            .Columns.Add("Nama Produk", 150)
            .Columns.Add("Total Terjual", 100)
            .View = View.Details
        End With
    End Sub

    ' Memuat pelanggan dengan total pembelian tertinggi
    Private Sub LoadTopCustomers()
        Try
            Using conn As MySqlConnection = GetKoneksi()
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
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ListViewTopCustomers.Items.Clear()

                While reader.Read()
                    Dim item As New ListViewItem(reader("username").ToString())
                    item.SubItems.Add(reader("total_pembelian").ToString())
                    ListViewTopCustomers.Items.Add(item)
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Memuat produk terlaris
    Private Sub LoadTopProducts()
        Try
            Using conn As MySqlConnection = GetKoneksi()
                Dim query As String = "
                SELECT 
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
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ListViewTopProducts.Items.Clear()

                While reader.Read()
                    Dim item As New ListViewItem(reader("nama_Menu").ToString())
                    item.SubItems.Add(reader("total_terjual").ToString())
                    ListViewTopProducts.Items.Add(item)
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Tombol keluar untuk kembali ke FormOwner
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        FormOwner.Show()
        Me.Hide()
    End Sub

    ' Tombol untuk melihat akun
    Private Sub btnLiatAkun_Click(sender As Object, e As EventArgs) Handles btnLiatAkun.Click
        FormAkun.Show()
        Me.Hide()
    End Sub
End Class
