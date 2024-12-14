<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInvoice
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAntrian = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "UAS.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 63)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAntrian
        '
        Me.lblAntrian.AutoSize = True
        Me.lblAntrian.Location = New System.Drawing.Point(12, 9)
        Me.lblAntrian.Name = "lblAntrian"
        Me.lblAntrian.Size = New System.Drawing.Size(48, 16)
        Me.lblAntrian.TabIndex = 5
        Me.lblAntrian.Text = "Antrian"
        '
        'FormInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 450)
        Me.Controls.Add(Me.lblAntrian)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormInvoice"
        Me.Text = "FormInvoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAntrian As Label
End Class
