<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSopralluogo
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
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBoxTipoAltro = New System.Windows.Forms.TextBox
        Me.RadioButtonTipoAltro = New System.Windows.Forms.RadioButton
        Me.RadioButtonTipoFurtoAbitazione = New System.Windows.Forms.RadioButton
        Me.DateTimePickerOraVerbale = New System.Windows.Forms.DateTimePicker
        Me.SopralluogoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxLuogo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxVia = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxContatti = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePickerOraRichiesta = New System.Windows.Forms.DateTimePicker
        Me.RichTextBoxResoconto = New System.Windows.Forms.RichTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.btnAnnulla = New System.Windows.Forms.Button
        Me.btnSalvaChiudi = New System.Windows.Forms.Button
        Me.ButtonGeneraReport = New System.Windows.Forms.Button
        Me.SopralluogoTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.sopralluogoTableAdapter
        Me.TimerSalvataggioAutomatico = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.SopralluogoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxTipoAltro)
        Me.GroupBox1.Controls.Add(Me.RadioButtonTipoAltro)
        Me.GroupBox1.Controls.Add(Me.RadioButtonTipoFurtoAbitazione)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo reato"
        '
        'TextBoxTipoAltro
        '
        Me.TextBoxTipoAltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTipoAltro.Location = New System.Drawing.Point(7, 103)
        Me.TextBoxTipoAltro.MaxLength = 50
        Me.TextBoxTipoAltro.Name = "TextBoxTipoAltro"
        Me.TextBoxTipoAltro.Size = New System.Drawing.Size(214, 32)
        Me.TextBoxTipoAltro.TabIndex = 2
        '
        'RadioButtonTipoAltro
        '
        Me.RadioButtonTipoAltro.AutoSize = True
        Me.RadioButtonTipoAltro.Location = New System.Drawing.Point(7, 67)
        Me.RadioButtonTipoAltro.Name = "RadioButtonTipoAltro"
        Me.RadioButtonTipoAltro.Size = New System.Drawing.Size(72, 30)
        Me.RadioButtonTipoAltro.TabIndex = 1
        Me.RadioButtonTipoAltro.Text = "altro"
        Me.RadioButtonTipoAltro.UseVisualStyleBackColor = True
        '
        'RadioButtonTipoFurtoAbitazione
        '
        Me.RadioButtonTipoFurtoAbitazione.AutoSize = True
        Me.RadioButtonTipoFurtoAbitazione.Checked = True
        Me.RadioButtonTipoFurtoAbitazione.Location = New System.Drawing.Point(7, 31)
        Me.RadioButtonTipoFurtoAbitazione.Name = "RadioButtonTipoFurtoAbitazione"
        Me.RadioButtonTipoFurtoAbitazione.Size = New System.Drawing.Size(208, 30)
        Me.RadioButtonTipoFurtoAbitazione.TabIndex = 0
        Me.RadioButtonTipoFurtoAbitazione.TabStop = True
        Me.RadioButtonTipoFurtoAbitazione.Text = "Furto in abitazione"
        Me.RadioButtonTipoFurtoAbitazione.UseVisualStyleBackColor = True
        '
        'DateTimePickerOraVerbale
        '
        Me.DateTimePickerOraVerbale.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.DateTimePickerOraVerbale.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SopralluogoBindingSource, "oraRedazione", True))
        Me.DateTimePickerOraVerbale.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.DateTimePickerOraVerbale.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerOraVerbale.Location = New System.Drawing.Point(253, 31)
        Me.DateTimePickerOraVerbale.Name = "DateTimePickerOraVerbale"
        Me.DateTimePickerOraVerbale.Size = New System.Drawing.Size(220, 32)
        Me.DateTimePickerOraVerbale.TabIndex = 1
        '
        'SopralluogoBindingSource
        '
        Me.SopralluogoBindingSource.DataMember = "sopralluogo"
        Me.SopralluogoBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'DbAlegatoADataSet
        '
        Me.DbAlegatoADataSet.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(15, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ora redazione verbale:"
        '
        'TextBoxLuogo
        '
        Me.TextBoxLuogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxLuogo.CausesValidation = False
        Me.TextBoxLuogo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SopralluogoBindingSource, "luogo_citta", True))
        Me.TextBoxLuogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TextBoxLuogo.Location = New System.Drawing.Point(213, 183)
        Me.TextBoxLuogo.MaxLength = 50
        Me.TextBoxLuogo.Name = "TextBoxLuogo"
        Me.TextBoxLuogo.Size = New System.Drawing.Size(873, 32)
        Me.TextBoxLuogo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(14, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "luogo (comune):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(14, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "via/presso:"
        '
        'TextBoxVia
        '
        Me.TextBoxVia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxVia.CausesValidation = False
        Me.TextBoxVia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SopralluogoBindingSource, "via", True))
        Me.TextBoxVia.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TextBoxVia.Location = New System.Drawing.Point(213, 221)
        Me.TextBoxVia.MaxLength = 150
        Me.TextBoxVia.Name = "TextBoxVia"
        Me.TextBoxVia.Size = New System.Drawing.Size(873, 32)
        Me.TextBoxVia.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label4.Location = New System.Drawing.Point(14, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "pressi contatti con:"
        '
        'TextBoxContatti
        '
        Me.TextBoxContatti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxContatti.CausesValidation = False
        Me.TextBoxContatti.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SopralluogoBindingSource, "contatti_con", True))
        Me.TextBoxContatti.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TextBoxContatti.Location = New System.Drawing.Point(213, 259)
        Me.TextBoxContatti.MaxLength = 200
        Me.TextBoxContatti.Name = "TextBoxContatti"
        Me.TextBoxContatti.Size = New System.Drawing.Size(873, 32)
        Me.TextBoxContatti.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label5.Location = New System.Drawing.Point(5, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 26)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ora richiesta intervento:"
        '
        'DateTimePickerOraRichiesta
        '
        Me.DateTimePickerOraRichiesta.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.DateTimePickerOraRichiesta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SopralluogoBindingSource, "oraRichiesta", True))
        Me.DateTimePickerOraRichiesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.DateTimePickerOraRichiesta.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerOraRichiesta.Location = New System.Drawing.Point(253, 69)
        Me.DateTimePickerOraRichiesta.Name = "DateTimePickerOraRichiesta"
        Me.DateTimePickerOraRichiesta.Size = New System.Drawing.Size(220, 32)
        Me.DateTimePickerOraRichiesta.TabIndex = 9
        '
        'RichTextBoxResoconto
        '
        Me.RichTextBoxResoconto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxResoconto.CausesValidation = False
        Me.RichTextBoxResoconto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SopralluogoBindingSource, "resoconto", True))
        Me.RichTextBoxResoconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.RichTextBoxResoconto.Location = New System.Drawing.Point(213, 326)
        Me.RichTextBoxResoconto.Name = "RichTextBoxResoconto"
        Me.RichTextBoxResoconto.Size = New System.Drawing.Size(873, 165)
        Me.RichTextBoxResoconto.TabIndex = 11
        Me.RichTextBoxResoconto.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label6.Location = New System.Drawing.Point(14, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 26)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "resoconto:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(19, 357)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(188, 134)
        Me.RichTextBox2.TabIndex = 13
        Me.RichTextBox2.Text = "descrizione del luogo - descrizione refurtiva - ammontare del danno  subito - ora" & _
            " presunta del fatto - eventuali sospetti - trovati elementi utili alle indagini?" & _
            " - coperto da assicurazione?"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePickerOraVerbale)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerOraRichiesta)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(245, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 151)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Orari"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox3.Location = New System.Drawing.Point(557, 492)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(543, 115)
        Me.GroupBox3.TabIndex = 155
        Me.GroupBox3.TabStop = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnAnnulla)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnSalvaChiudi)
        Me.FlowLayoutPanel2.Controls.Add(Me.ButtonGeneraReport)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(537, 96)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.btnAnnulla.Location = New System.Drawing.Point(3, 3)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(172, 84)
        Me.btnAnnulla.TabIndex = 202
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = True
        '
        'btnSalvaChiudi
        '
        Me.btnSalvaChiudi.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.btnSalvaChiudi.Location = New System.Drawing.Point(181, 3)
        Me.btnSalvaChiudi.Name = "btnSalvaChiudi"
        Me.btnSalvaChiudi.Size = New System.Drawing.Size(172, 84)
        Me.btnSalvaChiudi.TabIndex = 203
        Me.btnSalvaChiudi.Text = "&Salva e Chiudi"
        Me.btnSalvaChiudi.UseVisualStyleBackColor = True
        '
        'ButtonGeneraReport
        '
        Me.ButtonGeneraReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.ButtonGeneraReport.Location = New System.Drawing.Point(359, 3)
        Me.ButtonGeneraReport.Name = "ButtonGeneraReport"
        Me.ButtonGeneraReport.Size = New System.Drawing.Size(172, 84)
        Me.ButtonGeneraReport.TabIndex = 204
        Me.ButtonGeneraReport.Text = "Salva e &Genera report"
        Me.ButtonGeneraReport.UseVisualStyleBackColor = True
        '
        'SopralluogoTableAdapter
        '
        Me.SopralluogoTableAdapter.ClearBeforeFill = True
        '
        'TimerSalvataggioAutomatico
        '
        '
        'FSopralluogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 619)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RichTextBoxResoconto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxContatti)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxVia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxLuogo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FSopralluogo"
        Me.Text = "Sopralluogo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SopralluogoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTipoAltro As System.Windows.Forms.TextBox
    Friend WithEvents RadioButtonTipoAltro As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTipoFurtoAbitazione As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePickerOraVerbale As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxLuogo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxVia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxContatti As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerOraRichiesta As System.Windows.Forms.DateTimePicker
    Friend WithEvents RichTextBoxResoconto As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAnnulla As System.Windows.Forms.Button
    Friend WithEvents btnSalvaChiudi As System.Windows.Forms.Button
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents SopralluogoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SopralluogoTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.sopralluogoTableAdapter
    Friend WithEvents ButtonGeneraReport As System.Windows.Forms.Button
    Friend WithEvents TimerSalvataggioAutomatico As System.Windows.Forms.Timer
End Class
