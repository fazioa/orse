<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FVedi
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGridViewAllegatoA = New System.Windows.Forms.DataGridView
        Me.cLuogoControllo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cOra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cognome = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cittanascita = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nomeOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QAllegatoABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DataGridViewInterventi = New System.Windows.Forms.DataGridView
        Me.dataoraInizio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dataOraFine = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tipointervento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.resoconto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.iddgvInterventi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QInterventiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.DataGridViewInformazioni = New System.Windows.Forms.DataGridView
        Me.dataoraInizioInfo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dataoraFineInfo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.iddgvInfo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QInterventi_informazioniBindigSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QAllegatoATableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
        Me.QInterventiTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QInterventiTableAdapter
        Me.InterventiTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.interventiTableAdapter
        Me.AllegatoATableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.allegatoATableAdapter
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewAllegatoA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewInterventi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QInterventiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridViewInformazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QInterventi_informazioniBindigSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.AllowDrop = True
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.HotTrack = True
        Me.TabControl.ItemSize = New System.Drawing.Size(90, 35)
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1192, 666)
        Me.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridViewAllegatoA)
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1184, 623)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Allegato A"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridViewAllegatoA
        '
        Me.DataGridViewAllegatoA.AllowUserToAddRows = False
        Me.DataGridViewAllegatoA.AutoGenerateColumns = False
        Me.DataGridViewAllegatoA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.DataGridViewAllegatoA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cLuogoControllo, Me.cOra, Me.cognome, Me.nome, Me.DataGridViewTextBoxColumn13, Me.cittanascita, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn18, Me.cID, Me.nomeOS})
        Me.DataGridViewAllegatoA.DataSource = Me.QAllegatoABindingSource
        Me.DataGridViewAllegatoA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewAllegatoA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewAllegatoA.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewAllegatoA.MultiSelect = False
        Me.DataGridViewAllegatoA.Name = "DataGridViewAllegatoA"
        Me.DataGridViewAllegatoA.ReadOnly = True
        Me.DataGridViewAllegatoA.RowHeadersVisible = False
        Me.DataGridViewAllegatoA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewAllegatoA.Size = New System.Drawing.Size(1178, 617)
        Me.DataGridViewAllegatoA.TabIndex = 24
        '
        'cLuogoControllo
        '
        Me.cLuogoControllo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.cLuogoControllo.DataPropertyName = "luogo"
        Me.cLuogoControllo.FillWeight = 80.0!
        Me.cLuogoControllo.HeaderText = "Luogo"
        Me.cLuogoControllo.Name = "cLuogoControllo"
        Me.cLuogoControllo.ReadOnly = True
        Me.cLuogoControllo.Width = 5
        '
        'cOra
        '
        Me.cOra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.cOra.DataPropertyName = "dataora"
        DataGridViewCellStyle9.Format = "g"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.cOra.DefaultCellStyle = DataGridViewCellStyle9
        Me.cOra.HeaderText = "Data e ora"
        Me.cOra.Name = "cOra"
        Me.cOra.ReadOnly = True
        Me.cOra.Width = 5
        '
        'cognome
        '
        Me.cognome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.cognome.DataPropertyName = "cognome"
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cognome.DefaultCellStyle = DataGridViewCellStyle10
        Me.cognome.HeaderText = "Cognome"
        Me.cognome.Name = "cognome"
        Me.cognome.ReadOnly = True
        Me.cognome.Width = 5
        '
        'nome
        '
        Me.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.nome.DataPropertyName = "nome"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nome.DefaultCellStyle = DataGridViewCellStyle11
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        Me.nome.Width = 5
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "datanascita"
        DataGridViewCellStyle12.Format = "d"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn13.HeaderText = "Data Nascita"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 5
        '
        'cittanascita
        '
        Me.cittanascita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cittanascita.DataPropertyName = "cittanascita"
        Me.cittanascita.FillWeight = 50.0!
        Me.cittanascita.HeaderText = "Citta Nascita"
        Me.cittanascita.Name = "cittanascita"
        Me.cittanascita.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "mezzo"
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn7.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Mezzo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 5
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "targa"
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn10.HeaderText = "Targa"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 5
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "positivoSDI"
        Me.DataGridViewTextBoxColumn18.HeaderText = "SDI pos."
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 5
        '
        'cID
        '
        Me.cID.DataPropertyName = "id"
        Me.cID.HeaderText = "id"
        Me.cID.Name = "cID"
        Me.cID.ReadOnly = True
        Me.cID.Visible = False
        '
        'nomeOS
        '
        Me.nomeOS.DataPropertyName = "nomeOS"
        Me.nomeOS.HeaderText = "nomeOS"
        Me.nomeOS.Name = "nomeOS"
        Me.nomeOS.ReadOnly = True
        Me.nomeOS.Visible = False
        '
        'QAllegatoABindingSource
        '
        Me.QAllegatoABindingSource.DataMember = "QAllegatoA"
        Me.QAllegatoABindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'DbAlegatoADataSet
        '
        Me.DbAlegatoADataSet.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridViewInterventi)
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1184, 623)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Interventi"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewInterventi
        '
        Me.DataGridViewInterventi.AllowUserToAddRows = False
        Me.DataGridViewInterventi.AutoGenerateColumns = False
        Me.DataGridViewInterventi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.DataGridViewInterventi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataoraInizio, Me.dataOraFine, Me.tipointervento, Me.resoconto, Me.iddgvInterventi})
        Me.DataGridViewInterventi.DataSource = Me.QInterventiBindingSource
        Me.DataGridViewInterventi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewInterventi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewInterventi.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewInterventi.MultiSelect = False
        Me.DataGridViewInterventi.Name = "DataGridViewInterventi"
        Me.DataGridViewInterventi.ReadOnly = True
        Me.DataGridViewInterventi.RowHeadersVisible = False
        Me.DataGridViewInterventi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInterventi.Size = New System.Drawing.Size(1178, 617)
        Me.DataGridViewInterventi.TabIndex = 20
        '
        'dataoraInizio
        '
        Me.dataoraInizio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dataoraInizio.DataPropertyName = "dataoraInizio"
        Me.dataoraInizio.HeaderText = "Inizio"
        Me.dataoraInizio.Name = "dataoraInizio"
        Me.dataoraInizio.ReadOnly = True
        Me.dataoraInizio.Width = 54
        '
        'dataOraFine
        '
        Me.dataOraFine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.dataOraFine.DataPropertyName = "dataOraFine"
        DataGridViewCellStyle15.Format = "t"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.dataOraFine.DefaultCellStyle = DataGridViewCellStyle15
        Me.dataOraFine.HeaderText = "Fine"
        Me.dataOraFine.Name = "dataOraFine"
        Me.dataOraFine.ReadOnly = True
        Me.dataOraFine.Width = 5
        '
        'tipointervento
        '
        Me.tipointervento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.tipointervento.DataPropertyName = "tipointervento"
        Me.tipointervento.FillWeight = 50.0!
        Me.tipointervento.HeaderText = "Tipo Intervento"
        Me.tipointervento.Name = "tipointervento"
        Me.tipointervento.ReadOnly = True
        Me.tipointervento.Width = 102
        '
        'resoconto
        '
        Me.resoconto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.resoconto.DataPropertyName = "resoconto"
        Me.resoconto.FillWeight = 50.0!
        Me.resoconto.HeaderText = "Resoconto"
        Me.resoconto.Name = "resoconto"
        Me.resoconto.ReadOnly = True
        '
        'iddgvInterventi
        '
        Me.iddgvInterventi.DataPropertyName = "id"
        Me.iddgvInterventi.HeaderText = "id"
        Me.iddgvInterventi.Name = "iddgvInterventi"
        Me.iddgvInterventi.ReadOnly = True
        Me.iddgvInterventi.Visible = False
        '
        'QInterventiBindingSource
        '
        Me.QInterventiBindingSource.DataMember = "QInterventi"
        Me.QInterventiBindingSource.DataSource = Me.DbAlegatoADataSet
        Me.QInterventiBindingSource.Filter = ""
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridViewInformazioni)
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1184, 623)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Informazioni"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridViewInformazioni
        '
        Me.DataGridViewInformazioni.AllowUserToAddRows = False
        Me.DataGridViewInformazioni.AutoGenerateColumns = False
        Me.DataGridViewInformazioni.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.DataGridViewInformazioni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dataoraInizioInfo, Me.dataoraFineInfo, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.iddgvInfo})
        Me.DataGridViewInformazioni.DataSource = Me.QInterventi_informazioniBindigSource
        Me.DataGridViewInformazioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewInformazioni.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewInformazioni.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewInformazioni.MultiSelect = False
        Me.DataGridViewInformazioni.Name = "DataGridViewInformazioni"
        Me.DataGridViewInformazioni.ReadOnly = True
        Me.DataGridViewInformazioni.RowHeadersVisible = False
        Me.DataGridViewInformazioni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInformazioni.Size = New System.Drawing.Size(1178, 617)
        Me.DataGridViewInformazioni.TabIndex = 21
        '
        'dataoraInizioInfo
        '
        Me.dataoraInizioInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dataoraInizioInfo.DataPropertyName = "dataoraInizio"
        Me.dataoraInizioInfo.HeaderText = "Inizio"
        Me.dataoraInizioInfo.Name = "dataoraInizioInfo"
        Me.dataoraInizioInfo.ReadOnly = True
        Me.dataoraInizioInfo.Width = 54
        '
        'dataoraFineInfo
        '
        Me.dataoraFineInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.dataoraFineInfo.DataPropertyName = "dataOraFine"
        DataGridViewCellStyle16.Format = "t"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.dataoraFineInfo.DefaultCellStyle = DataGridViewCellStyle16
        Me.dataoraFineInfo.HeaderText = "Fine"
        Me.dataoraFineInfo.Name = "dataoraFineInfo"
        Me.dataoraFineInfo.ReadOnly = True
        Me.dataoraFineInfo.Width = 5
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tipointervento"
        Me.DataGridViewTextBoxColumn3.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo Intervento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 102
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "resoconto"
        Me.DataGridViewTextBoxColumn4.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Resoconto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'iddgvInfo
        '
        Me.iddgvInfo.DataPropertyName = "id"
        Me.iddgvInfo.HeaderText = "id"
        Me.iddgvInfo.Name = "iddgvInfo"
        Me.iddgvInfo.ReadOnly = True
        Me.iddgvInfo.Visible = False
        '
        'QInterventi_informazioniBindigSource
        '
        Me.QInterventi_informazioniBindigSource.DataMember = "QInterventi"
        Me.QInterventi_informazioniBindigSource.DataSource = Me.DbAlegatoADataSet
        Me.QInterventi_informazioniBindigSource.Filter = ""
        '
        'QAllegatoATableAdapter
        '
        Me.QAllegatoATableAdapter.ClearBeforeFill = True
        '
        'QInterventiTableAdapter
        '
        Me.QInterventiTableAdapter.ClearBeforeFill = True
        '
        'InterventiTableAdapter
        '
        Me.InterventiTableAdapter.ClearBeforeFill = True
        '
        'AllegatoATableAdapter
        '
        Me.AllegatoATableAdapter.ClearBeforeFill = True
        '
        'FVedi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 666)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "FVedi"
        Me.Text = "OrSe - Vedi inserimenti effettuati"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridViewAllegatoA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewInterventi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QInterventiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridViewInformazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QInterventi_informazioniBindigSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents QAllegatoATableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
    Friend WithEvents QAllegatoABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QInterventi_informazioniBindigSource As System.Windows.Forms.BindingSource
    Friend WithEvents QInterventiTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QInterventiTableAdapter
    Friend WithEvents QInterventiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewAllegatoA As System.Windows.Forms.DataGridView
    Friend WithEvents cLuogoControllo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cognome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cittanascita As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomeOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewInterventi As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewInformazioni As System.Windows.Forms.DataGridView
    Friend WithEvents dataoraInizioInfo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataoraFineInfo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iddgvInfo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataoraInizio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataOraFine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipointervento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents resoconto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iddgvInterventi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InterventiTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.interventiTableAdapter
    Friend WithEvents AllegatoATableAdapter As OrSe.dbAlegatoADataSetTableAdapters.allegatoATableAdapter
End Class