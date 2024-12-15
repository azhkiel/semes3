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
        Me.ListViewTopCustomers = New System.Windows.Forms.ListView()
        Me.ListViewTopProducts = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLiatAkun = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListViewTopCustomers
        '
        Me.ListViewTopCustomers.HideSelection = False
        Me.ListViewTopCustomers.Location = New System.Drawing.Point(9, 29)
        Me.ListViewTopCustomers.Name = "ListViewTopCustomers"
        Me.ListViewTopCustomers.Size = New System.Drawing.Size(364, 409)
        Me.ListViewTopCustomers.TabIndex = 1
        Me.ListViewTopCustomers.UseCompatibleStateImageBehavior = False
        '
        'ListViewTopProducts
        '
        Me.ListViewTopProducts.HideSelection = False
        Me.ListViewTopProducts.Location = New System.Drawing.Point(379, 29)
        Me.ListViewTopProducts.Name = "ListViewTopProducts"
        Me.ListViewTopProducts.Size = New System.Drawing.Size(328, 409)
        Me.ListViewTopProducts.TabIndex = 2
        Me.ListViewTopProducts.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Top Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(409, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Top Produk"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(713, 58)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Back"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLiatAkun
        '
        Me.btnLiatAkun.BackColor = System.Drawing.Color.Red
        Me.btnLiatAkun.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiatAkun.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLiatAkun.Location = New System.Drawing.Point(713, 29)
        Me.btnLiatAkun.Name = "btnLiatAkun"
        Me.btnLiatAkun.Size = New System.Drawing.Size(75, 23)
        Me.btnLiatAkun.TabIndex = 7
        Me.btnLiatAkun.Text = "Akun"
        Me.btnLiatAkun.UseVisualStyleBackColor = False
        '
        'FormData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLiatAkun)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListViewTopProducts)
        Me.Controls.Add(Me.ListViewTopCustomers)
        Me.Name = "FormData"
        Me.Text = "FormData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewTopCustomers As ListView
    Friend WithEvents ListViewTopProducts As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLiatAkun As Button
End Class
