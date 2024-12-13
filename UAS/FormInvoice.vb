Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class FormInvoice
    Public Property antrianInvoice As String
    Private Sub FormInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
        lblAntrian.Text = $"Nomor Antrian : {antrianInvoice}"
        Print()
    End Sub
    Private Sub Print()
        Dim orderID As String = antrianInvoice ' Ambil nilai dari TextBox tbOrder dan hapus spasi
        Dim dt As New DataTable()
        Dim conn As MySqlConnection = ModuleKoneksi.GetKoneksi()

        ' Query SQL untuk mengambil data
        Dim query As String = "
        SELECT
            `id`,
            `username`,
            `nama_Menu`,
            `kategori`,
            `jumlah`,
            `harga_total`,
            `waktu`,
            `no_antrian`,
            (SELECT SUM(`harga_total`) FROM `order` WHERE `no_antrian` = @orderID) AS total_pesanan
        FROM
            `order`
        WHERE
            `no_antrian` = @orderID;"

        Try
            ' Eksekusi query dan isi DataTable
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@orderID", orderID)
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using

            ' Cek jika data ditemukan
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No data found for the given Order ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Bind DataTable ke ReportViewer
            Dim rds As New ReportDataSource("DataSet1", dt)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub
End Class
