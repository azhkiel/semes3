<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOwner
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListViewHistoryPembelian = New System.Windows.Forms.ListView()
        Me.LabelTotalPendapatan = New System.Windows.Forms.Label()
        Me.btnTambahMenu = New System.Windows.Forms.Button()
        Me.ListViewMenu = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEditStok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnData = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(15, 503)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Log out"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListViewHistoryPembelian
        '
        Me.ListViewHistoryPembelian.HideSelection = False
        Me.ListViewHistoryPembelian.Location = New System.Drawing.Point(15, 341)
        Me.ListViewHistoryPembelian.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListViewHistoryPembelian.Name = "ListViewHistoryPembelian"
        Me.ListViewHistoryPembelian.Size = New System.Drawing.Size(612, 158)
        Me.ListViewHistoryPembelian.TabIndex = 1
        Me.ListViewHistoryPembelian.UseCompatibleStateImageBehavior = False
        Me.ListViewHistoryPembelian.View = System.Windows.Forms.View.Details
        '
        'LabelTotalPendapatan
        '
        Me.LabelTotalPendapatan.AutoSize = True
        Me.LabelTotalPendapatan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalPendapatan.ForeColor = System.Drawing.Color.Red
        Me.LabelTotalPendapatan.Location = New System.Drawing.Point(403, 7)
        Me.LabelTotalPendapatan.Name = "LabelTotalPendapatan"
        Me.LabelTotalPendapatan.Size = New System.Drawing.Size(224, 20)
        Me.LabelTotalPendapatan.TabIndex = 3
        Me.LabelTotalPendapatan.Text = "Total Pendapatan: 1000000,00"
        '
        'btnTambahMenu
        '
        Me.btnTambahMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahMenu.Location = New System.Drawing.Point(15, 282)
        Me.btnTambahMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTambahMenu.Name = "btnTambahMenu"
        Me.btnTambahMenu.Size = New System.Drawing.Size(125, 32)
        Me.btnTambahMenu.TabIndex = 10
        Me.btnTambahMenu.Text = " Tambah Menu"
        Me.btnTambahMenu.UseVisualStyleBackColor = True
        '
        'ListViewMenu
        '
        Me.ListViewMenu.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListViewMenu.FullRowSelect = True
        Me.ListViewMenu.HideSelection = False
        Me.ListViewMenu.Location = New System.Drawing.Point(15, 35)
        Me.ListViewMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListViewMenu.Name = "ListViewMenu"
        Me.ListViewMenu.Size = New System.Drawing.Size(612, 242)
        Me.ListViewMenu.TabIndex = 12
        Me.ListViewMenu.UseCompatibleStateImageBehavior = False
        Me.ListViewMenu.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.HapusToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(121, 52)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'HapusToolStripMenuItem
        '
        Me.HapusToolStripMenuItem.Name = "HapusToolStripMenuItem"
        Me.HapusToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.HapusToolStripMenuItem.Text = "Hapus"
        '
        'btnEditStok
        '
        Me.btnEditStok.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditStok.Location = New System.Drawing.Point(146, 282)
        Me.btnEditStok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditStok.Name = "btnEditStok"
        Me.btnEditStok.Size = New System.Drawing.Size(125, 32)
        Me.btnEditStok.TabIndex = 14
        Me.btnEditStok.Text = "Tambah Stok"
        Me.btnEditStok.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(15, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "History Pendapatan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(63, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Menu Saat Ini"
        '
        'btnData
        '
        Me.btnData.Location = New System.Drawing.Point(492, 504)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(135, 31)
        Me.btnData.TabIndex = 21
        Me.btnData.Text = "Lihat data yang lain"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'FormOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 542)
        Me.Controls.Add(Me.btnData)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEditStok)
        Me.Controls.Add(Me.ListViewMenu)
        Me.Controls.Add(Me.btnTambahMenu)
        Me.Controls.Add(Me.LabelTotalPendapatan)
        Me.Controls.Add(Me.ListViewHistoryPembelian)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormOwner"
        Me.Text = "FormOwner"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListViewHistoryPembelian As ListView
    Friend WithEvents LabelTotalPendapatan As Label
    Friend WithEvents btnTambahMenu As Button
    Friend WithEvents ListViewMenu As ListView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HapusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnEditStok As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnData As Button
End Class
