<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRubrica
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
        Me.components = New System.ComponentModel.Container()
        Me.btnChiudi = New System.Windows.Forms.Button()
        Me.btnSalvaChiudi = New System.Windows.Forms.Button()
        Me.tbRubrica = New System.Windows.Forms.TextBox()
        Me.RubricaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RubricaTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.rubricaTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.RubricaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.CausesValidation = False
        Me.btnChiudi.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChiudi.Location = New System.Drawing.Point(454, 580)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(199, 109)
        Me.btnChiudi.TabIndex = 26
        Me.btnChiudi.Text = "&Chiudi"
        Me.btnChiudi.UseVisualStyleBackColor = True
        '
        'btnSalvaChiudi
        '
        Me.btnSalvaChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvaChiudi.CausesValidation = False
        Me.btnSalvaChiudi.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvaChiudi.Location = New System.Drawing.Point(659, 580)
        Me.btnSalvaChiudi.Name = "btnSalvaChiudi"
        Me.btnSalvaChiudi.Size = New System.Drawing.Size(199, 109)
        Me.btnSalvaChiudi.TabIndex = 25
        Me.btnSalvaChiudi.Text = "&Salva e Chiudi"
        Me.btnSalvaChiudi.UseVisualStyleBackColor = True
        '
        'tbRubrica
        '
        Me.tbRubrica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRubrica.CausesValidation = False
        Me.tbRubrica.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RubricaBindingSource, "testo", True))
        Me.tbRubrica.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRubrica.Location = New System.Drawing.Point(0, 52)
        Me.tbRubrica.Multiline = True
        Me.tbRubrica.Name = "tbRubrica"
        Me.tbRubrica.Size = New System.Drawing.Size(870, 522)
        Me.tbRubrica.TabIndex = 0
        '
        'RubricaBindingSource
        '
        Me.RubricaBindingSource.DataMember = "rubrica"
        Me.RubricaBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'DbAlegatoADataSet
        '
        Me.DbAlegatoADataSet.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(12, 580)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(151, 88)
        Me.RichTextBox2.TabIndex = 29
        Me.RichTextBox2.Text = "Testo libero - Inserire tutti i dati necessari : cognome, nome, nome ditta, respo" & _
    "nsabile, indirizzi e numeri di telefono - Funzione ricerca full text"
        '
        'RubricaTableAdapter
        '
        Me.RubricaTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(333, 24)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Rubrica - Inserire le voci in testo libero."
        '
        'FRubrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 701)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.tbRubrica)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.btnSalvaChiudi)
        Me.Name = "FRubrica"
        Me.Text = "Inserimento voce rubrica"
        CType(Me.RubricaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Friend WithEvents btnSalvaChiudi As System.Windows.Forms.Button
    Friend WithEvents tbRubrica As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents RubricaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RubricaTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.rubricaTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
