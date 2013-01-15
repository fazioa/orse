<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class op85
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnAnteprimaOp85 = New System.Windows.Forms.Button()
        Me.lbComandiDestinatari = New System.Windows.Forms.ListBox()
        Me.tbProt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbProtInf = New System.Windows.Forms.TextBox()
        Me.tbComandiDestinatari = New System.Windows.Forms.TextBox()
        Me.BtnAggiungi = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idControllo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.generalita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet()
        Me.QAllegatoABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QAllegatoATableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter()
        Me.ModelliMezzoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelliMezzoTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter()
        Me.AllegatoABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllegatoATableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.allegatoATableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbNote = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelliMezzoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllegatoABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAnteprimaOp85
        '
        Me.btnAnteprimaOp85.Location = New System.Drawing.Point(9, 347)
        Me.btnAnteprimaOp85.Name = "btnAnteprimaOp85"
        Me.btnAnteprimaOp85.Size = New System.Drawing.Size(113, 37)
        Me.btnAnteprimaOp85.TabIndex = 45
        Me.btnAnteprimaOp85.Text = "Anteprima OP85"
        Me.btnAnteprimaOp85.UseVisualStyleBackColor = True
        '
        'lbComandiDestinatari
        '
        Me.lbComandiDestinatari.DisplayMember = "residenzacomunecitta"
        Me.lbComandiDestinatari.FormattingEnabled = True
        Me.lbComandiDestinatari.Location = New System.Drawing.Point(9, 45)
        Me.lbComandiDestinatari.Name = "lbComandiDestinatari"
        Me.lbComandiDestinatari.Size = New System.Drawing.Size(271, 69)
        Me.lbComandiDestinatari.TabIndex = 46
        Me.lbComandiDestinatari.ValueMember = "residenzacomunecitta"
        '
        'tbProt
        '
        Me.tbProt.Location = New System.Drawing.Point(122, 45)
        Me.tbProt.Name = "tbProt"
        Me.tbProt.Size = New System.Drawing.Size(100, 20)
        Me.tbProt.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Protocollo Arma"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Protocollo Informatico"
        '
        'tbProtInf
        '
        Me.tbProtInf.Location = New System.Drawing.Point(122, 19)
        Me.tbProtInf.Name = "tbProtInf"
        Me.tbProtInf.Size = New System.Drawing.Size(100, 20)
        Me.tbProtInf.TabIndex = 49
        '
        'tbComandiDestinatari
        '
        Me.tbComandiDestinatari.Location = New System.Drawing.Point(9, 19)
        Me.tbComandiDestinatari.Name = "tbComandiDestinatari"
        Me.tbComandiDestinatari.Size = New System.Drawing.Size(190, 20)
        Me.tbComandiDestinatari.TabIndex = 51
        '
        'BtnAggiungi
        '
        Me.BtnAggiungi.Location = New System.Drawing.Point(205, 17)
        Me.BtnAggiungi.Name = "BtnAggiungi"
        Me.BtnAggiungi.Size = New System.Drawing.Size(75, 23)
        Me.BtnAggiungi.TabIndex = 52
        Me.BtnAggiungi.Text = "Aggiungi"
        Me.BtnAggiungi.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idControllo, Me.generalita})
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(9, 154)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(675, 126)
        Me.DataGridView1.TabIndex = 54
        '
        'idControllo
        '
        Me.idControllo.HeaderText = "idControllo"
        Me.idControllo.Name = "idControllo"
        Me.idControllo.ReadOnly = True
        Me.idControllo.Visible = False
        Me.idControllo.Width = 60
        '
        'generalita
        '
        Me.generalita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.generalita.HeaderText = "generalita"
        Me.generalita.Name = "generalita"
        Me.generalita.ReadOnly = True
        '
        'DbAlegatoADataSet
        '
        Me.DbAlegatoADataSet.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QAllegatoABindingSource
        '
        Me.QAllegatoABindingSource.DataMember = "QAllegatoA"
        Me.QAllegatoABindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'QAllegatoATableAdapter
        '
        Me.QAllegatoATableAdapter.ClearBeforeFill = True
        '
        'ModelliMezzoBindingSource
        '
        Me.ModelliMezzoBindingSource.DataMember = "modelliMezzo"
        Me.ModelliMezzoBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'ModelliMezzoTableAdapter
        '
        Me.ModelliMezzoTableAdapter.ClearBeforeFill = True
        '
        'AllegatoABindingSource
        '
        Me.AllegatoABindingSource.DataMember = "allegatoA"
        Me.AllegatoABindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'AllegatoATableAdapter
        '
        Me.AllegatoATableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbComandiDestinatari)
        Me.GroupBox1.Controls.Add(Me.tbComandiDestinatari)
        Me.GroupBox1.Controls.Add(Me.BtnAggiungi)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 127)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comandi destinatari"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbProt)
        Me.GroupBox2.Controls.Add(Me.tbProtInf)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(312, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 80)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Protocollo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbNote)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 286)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(675, 52)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Note sul controllo"
        '
        'cbNote
        '
        Me.cbNote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbNote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbNote.Items.AddRange(New Object() {"Su posto di controllo", "Controllato/i in zona frequentata da pregiudicati", "Controllato/i in zona frequentata da prostitute", "Controllo mezzo sospetto"})
        Me.cbNote.Location = New System.Drawing.Point(6, 19)
        Me.cbNote.Name = "cbNote"
        Me.cbNote.Size = New System.Drawing.Size(663, 21)
        Me.cbNote.TabIndex = 60
        '
        'op85
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 403)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAnteprimaOp85)
        Me.Name = "op85"
        Me.Text = "Produzione OP85"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelliMezzoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllegatoABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAnteprimaOp85 As System.Windows.Forms.Button
    Friend WithEvents ComunecittaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResidenzaIndirizzoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comune1cittaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbComandiDestinatari As System.Windows.Forms.ListBox
    Friend WithEvents tbProt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbProtInf As System.Windows.Forms.TextBox
    Friend WithEvents tbComandiDestinatari As System.Windows.Forms.TextBox
    Friend WithEvents BtnAggiungi As System.Windows.Forms.Button
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents QAllegatoABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QAllegatoATableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
    Friend WithEvents ModelliMezzoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelliMezzoTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter
    Friend WithEvents AllegatoABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AllegatoATableAdapter As OrSe.dbAlegatoADataSetTableAdapters.allegatoATableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbNote As System.Windows.Forms.ComboBox
    Friend WithEvents idControllo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents generalita As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
