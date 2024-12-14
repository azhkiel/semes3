<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormData
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
        Me.ListViewTopCustomers = New System.Windows.Forms.ListView()
        Me.ListViewTopProducts = New System.Windows.Forms.ListView()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListViewAkunCustomer
        '
        Me.ListViewAkunCustomer.HideSelection = False
        Me.ListViewAkunCustomer.Location = New System.Drawing.Point(3, 75)
        Me.ListViewAkunCustomer.Name = "ListViewAkunCustomer"
        Me.ListViewAkunCustomer.Size = New System.Drawing.Size(258, 363)
        Me.ListViewAkunCustomer.TabIndex = 0
        Me.ListViewAkunCustomer.UseCompatibleStateImageBehavior = False
        '
        'ListViewTopCustomers
        '
        Me.ListViewTopCustomers.HideSelection = False
        Me.ListViewTopCustomers.Location = New System.Drawing.Point(272, 75)
        Me.ListViewTopCustomers.Name = "ListViewTopCustomers"
        Me.ListViewTopCustomers.Size = New System.Drawing.Size(258, 363)
        Me.ListViewTopCustomers.TabIndex = 1
        Me.ListViewTopCustomers.UseCompatibleStateImageBehavior = False
        '
        'ListViewTopProducts
        '
        Me.ListViewTopProducts.HideSelection = False
        Me.ListViewTopProducts.Location = New System.Drawing.Point(537, 75)
        Me.ListViewTopProducts.Name = "ListViewTopProducts"
        Me.ListViewTopProducts.Size = New System.Drawing.Size(258, 363)
        Me.ListViewTopProducts.TabIndex = 2
        Me.ListViewTopProducts.UseCompatibleStateImageBehavior = False
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(12, 51)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(97, 16)
        Me.lbl.TabIndex = 3
        Me.lbl.Text = "Akun Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Top Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(534, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Top Produk"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(713, 48)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Back"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FormData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.ListViewTopProducts)
        Me.Controls.Add(Me.ListViewTopCustomers)
        Me.Controls.Add(Me.ListViewAkunCustomer)
        Me.Name = "FormData"
        Me.Text = "FormData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListViewAkunCustomer As ListView
    Friend WithEvents ListViewTopCustomers As ListView
    Friend WithEvents ListViewTopProducts As ListView
    Friend WithEvents lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As Button
End Class
