Imports MySql.Data.MySqlClient
Imports Windows.Win32.System

Public Class FormLogin
    ' Fungsi ini dijalankan ketika tombol "Login" diklik
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginUsers As Tuple(Of String, String) = LoginUser(txtUsername.Text, txtPassword.Text)

        If loginUsers IsNot Nothing Then
            Dim role As String = loginUsers.Item1
            Dim nama As String = loginUsers.Item2

            Select Case role
                Case "owner"
                    MsgBox("Login sebagai Owner berhasil!")
                    FormOwner.Show()
                Case "admin"
                    MsgBox("Login sebagai Admin berhasil!")
                ' FormAdmin.Show()
                Case "customer"
                    MsgBox("Login berhasil! Selamat datang, " & nama & "!")
                    Dim formBelanja As New FormBelanja()
                    formBelanja.CustomerName = nama ' Mengatur nama customer
                    formBelanja.Show()
            End Select
            Me.Hide()
        Else
            MsgBox("Username atau Password salah!")
        End If
    End Sub


    ' Tombol untuk membuka form Sign Up
    Private Sub linkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkToSignUp.LinkClicked
        FormSignUp.Show()
        Me.Hide()
    End Sub
    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.PasswordChar = "*" ' Sembunyikan password
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Gray
        End If
    End Sub


    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = "Username"
        txtUsername.ForeColor = Color.Gray
        txtPassword.Text = "Password"
        txtPassword.ForeColor = Color.Gray
    End Sub
    Private liatpw As Boolean = False

    Private Sub mataLiat_Click(sender As Object, e As EventArgs) Handles mataLiat.Click
        ' Toggle visibility of password
        liatpw = Not liatpw

        If liatpw Then
            txtPassword.PasswordChar = "" ' Tampilkan password
            mataLiat.Image = My.Resources.mataTerbuka ' Ganti gambar menjadi mata terbuka
        Else
            txtPassword.PasswordChar = "*" ' Sembunyikan password
            mataLiat.Image = My.Resources.mataTertutup ' Ganti gambar menjadi mata tertutup
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
