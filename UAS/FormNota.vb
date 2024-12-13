Public Class FormNota
    Public Property NotaPembayaran As String
    Public Property antrian As String


    Private Sub FormNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBoxNota.Text = NotaPembayaran
        lblAntrian.Text = $"Nomor Antrian : {antrian}"
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim formInvoice As New FormInvoice()
        formInvoice.antrianInvoice = antrian
        formInvoice.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub
End Class
