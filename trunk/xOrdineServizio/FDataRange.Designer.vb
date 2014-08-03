<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDataRange
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.DateTimePickerInizio = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFine = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Inizio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonUltimoMese = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(274, 261)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'DateTimePickerInizio
        '
        Me.DateTimePickerInizio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.DateTimePickerInizio.Location = New System.Drawing.Point(66, 49)
        Me.DateTimePickerInizio.Name = "DateTimePickerInizio"
        Me.DateTimePickerInizio.Size = New System.Drawing.Size(254, 26)
        Me.DateTimePickerInizio.TabIndex = 1
        '
        'DateTimePickerFine
        '
        Me.DateTimePickerFine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.DateTimePickerFine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePickerFine.Location = New System.Drawing.Point(66, 91)
        Me.DateTimePickerFine.Name = "DateTimePickerFine"
        Me.DateTimePickerFine.Size = New System.Drawing.Size(254, 26)
        Me.DateTimePickerFine.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Esportazione dei dati"
        '
        'Inizio
        '
        Me.Inizio.AutoSize = True
        Me.Inizio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Inizio.Location = New System.Drawing.Point(12, 52)
        Me.Inizio.Name = "Inizio"
        Me.Inizio.Size = New System.Drawing.Size(48, 20)
        Me.Inizio.TabIndex = 4
        Me.Inizio.Text = "Inizio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fine"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(17, 254)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(234, 48)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = "Scegliere il periodo desiderato. In automatico sono state impostate le date limit" & _
    "e disponibili. Premere OK per esportare i dati."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonUltimoMese)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 98)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Inizio"
        '
        'RadioButtonUltimoMese
        '
        Me.RadioButtonUltimoMese.AutoSize = True
        Me.RadioButtonUltimoMese.Location = New System.Drawing.Point(6, 64)
        Me.RadioButtonUltimoMese.Name = "RadioButtonUltimoMese"
        Me.RadioButtonUltimoMese.Size = New System.Drawing.Size(82, 17)
        Me.RadioButtonUltimoMese.TabIndex = 13
        Me.RadioButtonUltimoMese.Text = "Ultimo mese"
        Me.RadioButtonUltimoMese.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 41)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(141, 17)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.Text = "Data ultima esportazione"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Prima data disponibile"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'DbAlegatoADataSet
        '
        Me.DbAlegatoADataSet.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FDataRange
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(432, 302)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Inizio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePickerFine)
        Me.Controls.Add(Me.DateTimePickerInizio)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FDataRange"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Esportazione dati - Scelta data"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerInizio As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerFine As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Inizio As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonUltimoMese As System.Windows.Forms.RadioButton
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet

End Class
