<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblAntrian = New System.Windows.Forms.Label()
        Me.btnBayarPesanan = New System.Windows.Forms.Button()
        Me.ListViewPesanan = New System.Windows.Forms.ListView()
        Me.ListViewBelanja = New System.Windows.Forms.ListView()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogout.Location = New System.Drawing.Point(18, 589)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 38)
        Me.btnLogout.TabIndex = 12
        Me.btnLogout.Text = "Exit"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblAntrian
        '
        Me.lblAntrian.AutoSize = True
        Me.lblAntrian.Location = New System.Drawing.Point(538, 17)
        Me.lblAntrian.Name = "lblAntrian"
        Me.lblAntrian.Size = New System.Drawing.Size(47, 16)
        Me.lblAntrian.TabIndex = 11
        Me.lblAntrian.Text = "antrian"
        '
        'btnBayarPesanan
        '
        Me.btnBayarPesanan.BackColor = System.Drawing.Color.Red
        Me.btnBayarPesanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayarPesanan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBayarPesanan.Location = New System.Drawing.Point(500, 588)
        Me.btnBayarPesanan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBayarPesanan.Name = "btnBayarPesanan"
        Me.btnBayarPesanan.Size = New System.Drawing.Size(94, 39)
        Me.btnBayarPesanan.TabIndex = 10
        Me.btnBayarPesanan.Text = "bayar"
        Me.btnBayarPesanan.UseVisualStyleBackColor = False
        '
        'ListViewPesanan
        '
        Me.ListViewPesanan.HideSelection = False
        Me.ListViewPesanan.Location = New System.Drawing.Point(18, 280)
        Me.ListViewPesanan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListViewPesanan.Name = "ListViewPesanan"
        Me.ListViewPesanan.Size = New System.Drawing.Size(678, 282)
        Me.ListViewPesanan.TabIndex = 8
        Me.ListViewPesanan.UseCompatibleStateImageBehavior = False
        '
        'ListViewBelanja
        '
        Me.ListViewBelanja.FullRowSelect = True
        Me.ListViewBelanja.HideSelection = False
        Me.ListViewBelanja.Location = New System.Drawing.Point(18, 53)
        Me.ListViewBelanja.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListViewBelanja.Name = "ListViewBelanja"
        Me.ListViewBelanja.Size = New System.Drawing.Size(678, 209)
        Me.ListViewBelanja.TabIndex = 7
        Me.ListViewBelanja.UseCompatibleStateImageBehavior = False
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(71, 17)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(243, 22)
        Me.tbUser.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UAS.My.Resources.Resources.mie__1_
        Me.PictureBox1.Location = New System.Drawing.Point(18, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 47)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(602, 588)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 39)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Data"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 640)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblAntrian)
        Me.Controls.Add(Me.btnBayarPesanan)
        Me.Controls.Add(Me.ListViewPesanan)
        Me.Controls.Add(Me.ListViewBelanja)
        Me.Name = "FormAdmin"
        Me.Text = "FormAdmin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblAntrian As Label
    Friend WithEvents btnBayarPesanan As Button
    Friend WithEvents ListViewPesanan As ListView
    Friend WithEvents ListViewBelanja As ListView
    Friend WithEvents tbUser As TextBox
    Friend WithEvents Button1 As Button
End Class
