<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNota
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
        Me.RichTextBoxNota = New System.Windows.Forms.RichTextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAntrian = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RichTextBoxNota
        '
        Me.RichTextBoxNota.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBoxNota.Name = "RichTextBoxNota"
        Me.RichTextBoxNota.Size = New System.Drawing.Size(394, 409)
        Me.RichTextBoxNota.TabIndex = 0
        Me.RichTextBoxNota.Text = ""
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Red
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Location = New System.Drawing.Point(12, 415)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 31)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(306, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAntrian
        '
        Me.lblAntrian.AutoSize = True
        Me.lblAntrian.Location = New System.Drawing.Point(108, 422)
        Me.lblAntrian.Name = "lblAntrian"
        Me.lblAntrian.Size = New System.Drawing.Size(47, 16)
        Me.lblAntrian.TabIndex = 3
        Me.lblAntrian.Text = "antrian"
        '
        'FormNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 450)
        Me.Controls.Add(Me.lblAntrian)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.RichTextBoxNota)
        Me.Name = "FormNota"
        Me.Text = "FormNota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBoxNota As RichTextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAntrian As Label
End Class
