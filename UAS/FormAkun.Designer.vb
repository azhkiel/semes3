<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAkun
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListViewAkunCustomer = New System.Windows.Forms.ListView()
        Me.lbl = New System.Windows.Forms.Label()
        Me.btnTambahAdmin = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListViewAkunCustomer
        '
        Me.ListViewAkunCustomer.HideSelection = False
        Me.ListViewAkunCustomer.Location = New System.Drawing.Point(12, 28)
        Me.ListViewAkunCustomer.Name = "ListViewAkunCustomer"
        Me.ListViewAkunCustomer.Size = New System.Drawing.Size(456, 410)
        Me.ListViewAkunCustomer.TabIndex = 1
        Me.ListViewAkunCustomer.UseCompatibleStateImageBehavior = False
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Red
        Me.lbl.Location = New System.Drawing.Point(12, 5)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(133, 20)
        Me.lbl.TabIndex = 4
        Me.lbl.Text = "Akun Terdaftar"
        '
        'btnTambahAdmin
        '
        Me.btnTambahAdmin.BackColor = System.Drawing.Color.Red
        Me.btnTambahAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTambahAdmin.Location = New System.Drawing.Point(474, 28)
        Me.btnTambahAdmin.Name = "btnTambahAdmin"
        Me.btnTambahAdmin.Size = New System.Drawing.Size(75, 23)
        Me.btnTambahAdmin.TabIndex = 5
        Me.btnTambahAdmin.Text = "Tambah "
        Me.btnTambahAdmin.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(474, 57)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FormAkun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnTambahAdmin)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.ListViewAkunCustomer)
        Me.Name = "FormAkun"
        Me.Text = "FormAkun"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListViewAkunCustomer As ListView
    Friend WithEvents lbl As Label
    Friend WithEvents btnTambahAdmin As Button
    Friend WithEvents btnBack As Button
End Class
