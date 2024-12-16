Imports MySql.Data.MySqlClient

Public Class FormAkun
    ' Event saat FormAkun dimuat
    Private Sub FormAkun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAkunCustomer()
        SetupListView()
        InitializeContextMenu()
    End Sub

    ' Konfigurasi ListView untuk menampilkan data
    Private Sub SetupListView()
        With ListViewAkunCustomer
            .FullRowSelect = True
            .Columns.Clear()
            .Columns.Add("Username", 150)
            .Columns.Add("Password", 100)
            .Columns.Add("No. Telepon", 100)
            .Columns.Add("Role", 100)
            .View = View.Details
        End With
    End Sub

    ' Memuat data dari database ke ListView
    Private Sub LoadAkunCustomer()
        Try
            Using conn As MySqlConnection = GetKoneksi()
                Dim cmd As New MySqlCommand("SELECT username, password, notel, role FROM user", conn)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                ListViewAkunCustomer.Items.Clear()

                While reader.Read()
                    Dim item As New ListViewItem(reader("username").ToString())
                    item.SubItems.Add(reader("password").ToString())
                    item.SubItems.Add(reader("notel").ToString())
                    item.SubItems.Add(reader("role").ToString())
                    ListViewAkunCustomer.Items.Add(item)
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Tombol kembali ke FormData
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormData.Show()
        Me.Hide()
    End Sub

    ' Tombol untuk menambah admin baru
    Private Sub btnTambahAdmin_Click(sender As Object, e As EventArgs) Handles btnTambahAdmin.Click
        Dim nama As String = InputBox("Silahkan input nama")
        Dim password As String = InputBox("Silahkan input password")
        Dim notel As String = InputBox("Silahkan input Nomor Telepon")

        If String.IsNullOrWhiteSpace(nama) OrElse String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(notel) Then
            MessageBox.Show("Semua kolom harus diisi.")
            Return
        End If

        Try
            Using conn As MySqlConnection = GetKoneksi()
                conn.Open()
                Dim query As String = "INSERT INTO user (username, password, notel, role) VALUES (@username, @password, @notel, 'admin')"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", nama)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@notel", notel)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Admin berhasil ditambahkan.")
                LoadAkunCustomer()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Context menu untuk ListView
    Private contextMenu As ContextMenuStrip

    ' Inisialisasi ContextMenuStrip
    Private Sub InitializeContextMenu()
        contextMenu = New ContextMenuStrip()

        Dim menuItemUbah As New ToolStripMenuItem("Ubah")
        AddHandler menuItemUbah.Click, AddressOf MenuItemUbah_Click
        contextMenu.Items.Add(menuItemUbah)

        Dim menuItemHapus As New ToolStripMenuItem("Hapus")
        AddHandler menuItemHapus.Click, AddressOf MenuItemHapus_Click
        contextMenu.Items.Add(menuItemHapus)
    End Sub

    ' Menampilkan ContextMenuStrip pada item yang dipilih
    Private Sub ListViewAkunCustomer_MouseClick(sender As Object, e As MouseEventArgs) Handles ListViewAkunCustomer.MouseClick
        If e.Button = MouseButtons.Right AndAlso ListViewAkunCustomer.SelectedItems.Count > 0 Then
            contextMenu.Show(ListViewAkunCustomer, e.Location)
        End If
    End Sub

    ' Fungsi untuk menghapus akun
    Private Sub MenuItemHapus_Click(sender As Object, e As EventArgs)
        If ListViewAkunCustomer.SelectedItems.Count > 0 Then
            Dim akun As ListViewItem = ListViewAkunCustomer.SelectedItems(0)
            If MessageBox.Show("Apakah Anda yakin ingin menghapus akun ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Using conn As MySqlConnection = GetKoneksi()
                        Dim cmd As New MySqlCommand("DELETE FROM user WHERE username = @nama", conn)
                        cmd.Parameters.AddWithValue("@nama", akun.Text)
                        conn.Open()
                        cmd.ExecuteNonQuery()

                        MessageBox.Show("Akun berhasil dihapus.")
                        LoadAkunCustomer()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Silakan pilih akun yang ingin dihapus.")
        End If
    End Sub

    ' Fungsi untuk mengubah akun
    Private Sub MenuItemUbah_Click(sender As Object, e As EventArgs)
        If ListViewAkunCustomer.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewAkunCustomer.SelectedItems(0)

            Dim namaLama As String = selectedItem.SubItems(0).Text
            Dim namaBaru As String = InputBox("Edit nama Akun:", "Edit Akun", namaLama)
            Dim passwordBaru As String = InputBox("Edit Password Akun:", "Edit Akun", selectedItem.SubItems(1).Text)
            Dim notelBaru As String = InputBox("Edit Nomor Telepon Akun:", "Edit Akun", selectedItem.SubItems(2).Text)
            Dim roleBaru As String = InputBox("Edit Role Akun:", "Edit Akun", selectedItem.SubItems(3).Text)

            If String.IsNullOrWhiteSpace(namaBaru) OrElse String.IsNullOrWhiteSpace(passwordBaru) OrElse String.IsNullOrWhiteSpace(notelBaru) OrElse String.IsNullOrWhiteSpace(roleBaru) Then
                MessageBox.Show("Semua kolom harus diisi.")
                Return
            End If

            Try
                Using conn As MySqlConnection = GetKoneksi()
                    Dim cmd As New MySqlCommand("UPDATE user SET username = @namaBaru, password = @password, notel = @notel, role = @role WHERE username = @namaLama", conn)
                    cmd.Parameters.AddWithValue("@namaLama", namaLama)
                    cmd.Parameters.AddWithValue("@namaBaru", namaBaru)
                    cmd.Parameters.AddWithValue("@password", passwordBaru)
                    cmd.Parameters.AddWithValue("@notel", notelBaru)
                    cmd.Parameters.AddWithValue("@role", roleBaru)
                    conn.Open()
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Akun berhasil diperbarui.")
                    LoadAkunCustomer()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Silakan pilih akun yang ingin diedit.")
            'akdalk
        End If
    End Sub
End Class
