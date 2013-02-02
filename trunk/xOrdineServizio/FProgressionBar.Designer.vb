<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProgressionBar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBoxInfo = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(518, 23)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Value = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-3, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'RichTextBoxInfo
        '
        Me.RichTextBoxInfo.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.RichTextBoxInfo.Location = New System.Drawing.Point(0, 23)
        Me.RichTextBoxInfo.Name = "RichTextBoxInfo"
        Me.RichTextBoxInfo.ReadOnly = True
        Me.RichTextBoxInfo.Size = New System.Drawing.Size(518, 24)
        Me.RichTextBoxInfo.TabIndex = 14
        Me.RichTextBoxInfo.Text = ""
        '
        'FProgressionBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 66)
        Me.ControlBox = False
        Me.Controls.Add(Me.RichTextBoxInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FProgressionBar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendere..."
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxInfo As System.Windows.Forms.RichTextBox
End Class
