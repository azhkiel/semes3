Imports MySql.Data.MySqlClient

Public Class FormSignUp
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        ' Validasi password dan repassword
        If txtPassword.Text <> txtRePassword.Text Then
            MsgBox("Password dan konfirmasi password tidak sama!")
            Return
        End If
        ' Validasi panjang nomor telepon
        If txtNotel.Text.Length < 11 Or txtNotel.Text.Length > 13 Then
            MsgBox("Nomor telepon harus antara 11 hingga 13 digit!")
            Return
        End If
        ' Koneksi ke database untuk cek username unik
        Using conn As MySqlConnection = GetKoneksi()
            conn.Open()
            Dim checkQuery As String = "SELECT COUNT(*) FROM user WHERE username=@username"
            Using cmd As New MySqlCommand(checkQuery, conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                Dim userExists As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If userExists > 0 Then
                    MsgBox("Username sudah digunakan!")
                    Return
                End If
            End Using
            ' Proses OTP
            Dim otpCode As String = New Random().Next(1000, 9999).ToString()
            Dim attempts As Integer = 0
            Dim inputOTP As String = ""

            Do While attempts < 3
                inputOTP = InputBox("Masukkan kode OTP (4 digit): " & otpCode, "Verifikasi OTP")
                If inputOTP = otpCode Then
                    ' Insert data user baru ke database
                    Dim insertQuery As String = "INSERT INTO user (username, password, notel, role) VALUES (@username, @password, @notel, 'customer')"
                    Using insertCmd As New MySqlCommand(insertQuery, conn)
                        insertCmd.Parameters.AddWithValue("@username", txtUsername.Text)
                        insertCmd.Parameters.AddWithValue("@password", txtPassword.Text)
                        insertCmd.Parameters.AddWithValue("@notel", txtNotel.Text)
                        insertCmd.ExecuteNonQuery()
                    End Using
                    MsgBox("Sign up berhasil! Silakan login.")
                    Me.Close()
                    FormLogin.Show()
                    Return
                Else
                    attempts += 1
                    MsgBox("Kode OTP salah! " & (3 - attempts) & " kesempatan tersisa.")
                End If
            Loop
            ' Jika OTP gagal 3 kali
            MsgBox("Kode OTP salah lebih dari 3 kali. Silakan coba lagi nanti.")
        End Using
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
    Private Sub txtRePassword_Enter(sender As Object, e As EventArgs) Handles txtRePassword.Enter
        If txtRePassword.Text = "RePassword" Then
            txtRePassword.Text = ""
            txtRePassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtRePassword_Leave(sender As Object, e As EventArgs) Handles txtRePassword.Leave
        If String.IsNullOrWhiteSpace(txtRePassword.Text) Then
            txtRePassword.Text = "RePassword"
            txtRePassword.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtNotel_Enter(sender As Object, e As EventArgs) Handles txtNotel.Enter
        If txtNotel.Text = "Nomor Telepon" Then
            txtNotel.Text = ""
            txtNotel.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNotel_Leave(sender As Object, e As EventArgs) Handles txtNotel.Leave
        If String.IsNullOrWhiteSpace(txtNotel.Text) Then
            txtNotel.Text = "Nomor Telepon"
            txtNotel.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = "Username"
        txtUsername.ForeColor = Color.Gray
        txtPassword.Text = "Password"
        txtPassword.ForeColor = Color.Gray
        txtRePassword.Text = "RePassword"
        txtRePassword.ForeColor = Color.Gray
        txtNotel.Text = "Nomor Telepon"
        txtNotel.ForeColor = Color.Gray
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormLogin.Show()
        Me.Hide()
    End Sub
End Class
