<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBelanja
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListViewBelanja = New System.Windows.Forms.ListView()
        Me.ListViewPesanan = New System.Windows.Forms.ListView()
        Me.lbl = New System.Windows.Forms.Label()
        Me.btnBayarPesanan = New System.Windows.Forms.Button()
        Me.lblAntrian = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListViewBelanja
        '
        Me.ListViewBelanja.FullRowSelect = True
        Me.ListViewBelanja.HideSelection = False
        Me.ListViewBelanja.Location = New System.Drawing.Point(23, 54)
        Me.ListViewBelanja.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListViewBelanja.Name = "ListViewBelanja"
        Me.ListViewBelanja.Size = New System.Drawing.Size(678, 209)
        Me.ListViewBelanja.TabIndex = 0
        Me.ListViewBelanja.UseCompatibleStateImageBehavior = False
        '
        'ListViewPesanan
        '
        Me.ListViewPesanan.HideSelection = False
        Me.ListViewPesanan.Location = New System.Drawing.Point(23, 281)
        Me.ListViewPesanan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListViewPesanan.Name = "ListViewPesanan"
        Me.ListViewPesanan.Size = New System.Drawing.Size(678, 282)
        Me.ListViewPesanan.TabIndex = 1
        Me.ListViewPesanan.UseCompatibleStateImageBehavior = False
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(76, 18)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(133, 16)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "Welcome, Pengguna"
        '
        'btnBayarPesanan
        '
        Me.btnBayarPesanan.BackColor = System.Drawing.Color.Red
        Me.btnBayarPesanan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBayarPesanan.Location = New System.Drawing.Point(607, 590)
        Me.btnBayarPesanan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBayarPesanan.Name = "btnBayarPesanan"
        Me.btnBayarPesanan.Size = New System.Drawing.Size(94, 39)
        Me.btnBayarPesanan.TabIndex = 3
        Me.btnBayarPesanan.Text = "bayar"
        Me.btnBayarPesanan.UseVisualStyleBackColor = False
        '
        'lblAntrian
        '
        Me.lblAntrian.AutoSize = True
        Me.lblAntrian.Location = New System.Drawing.Point(543, 18)
        Me.lblAntrian.Name = "lblAntrian"
        Me.lblAntrian.Size = New System.Drawing.Size(47, 16)
        Me.lblAntrian.TabIndex = 4
        Me.lblAntrian.Text = "antrian"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogout.Location = New System.Drawing.Point(23, 590)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 38)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Exit"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UAS.My.Resources.Resources.mie__1_
        Me.PictureBox1.Location = New System.Drawing.Point(23, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 47)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FormBelanja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(726, 640)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblAntrian)
        Me.Controls.Add(Me.btnBayarPesanan)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.ListViewPesanan)
        Me.Controls.Add(Me.ListViewBelanja)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormBelanja"
        Me.Text = "FormBelanja"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListViewBelanja As ListView
    Friend WithEvents ListViewPesanan As ListView
    Friend WithEvents lbl As Label
    Friend WithEvents btnBayarPesanan As Button
    Friend WithEvents lblAntrian As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
