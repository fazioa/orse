<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSoggetto
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdMezzoLabel As System.Windows.Forms.Label
        Dim TargaLabel As System.Windows.Forms.Label
        Dim CognomeLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim IdLuogoNascitaLabel As System.Windows.Forms.Label
        Dim DatanascitaLabel As System.Windows.Forms.Label
        Dim ResidenzaLabel As System.Windows.Forms.Label
        Dim DocumentoLabel As System.Windows.Forms.Label
        Dim ContravvenzioniLabel As System.Windows.Forms.Label
        Dim PerquisizioneLabel As System.Windows.Forms.Label
        Dim PositivoSDILabel As System.Windows.Forms.Label
        Dim PrecedentiLabel As System.Windows.Forms.Label
        Dim NOTELabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.ColoreLabel = New System.Windows.Forms.Label()
        Me.tbColore = New System.Windows.Forms.TextBox()
        Me.AllegatoABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbDataSet = New OrSe.dbAlegatoADataSet()
        Me.tbTarga = New System.Windows.Forms.TextBox()
        Me.tbCognome = New System.Windows.Forms.TextBox()
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbNome = New System.Windows.Forms.TextBox()
        Me.tbDocumento = New System.Windows.Forms.TextBox()
        Me.ContravvenzioniCheckBox = New System.Windows.Forms.CheckBox()
        Me.PerquisizioneCheckBox = New System.Windows.Forms.CheckBox()
        Me.tbPrecedenti = New System.Windows.Forms.TextBox()
        Me.tbNote = New System.Windows.Forms.TextBox()
        Me.btnSalvaChiudi = New System.Windows.Forms.Button()
        Me.btnAnnulla = New System.Windows.Forms.Button()
        Me.labelOS = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPasseggero = New System.Windows.Forms.Button()
        Me.PositivoSDIComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAPiedi = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBoxResidenza = New System.Windows.Forms.GroupBox()
        Me.ComboBoxComuneResidenza = New System.Windows.Forms.ComboBox()
        Me.ComuneResidenzaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbDataSet2 = New OrSe.dbAlegatoADataSet()
        Me.tbIndirizzo = New System.Windows.Forms.TextBox()
        Me.GroupBoxDatiAnagrafici = New System.Windows.Forms.GroupBox()
        Me.DataNascitaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBoxComuneNascita = New System.Windows.Forms.ComboBox()
        Me.ComuneNascitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBoxMezzo = New System.Windows.Forms.GroupBox()
        Me.ComboBoxModelliMezzo = New OrSe.UserControlComboBox()
        Me.MezzoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cbPip = New System.Windows.Forms.CheckBox()
        Me.btnAddPIO = New System.Windows.Forms.Button()
        Me.bPIOSel = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelControllo = New System.Windows.Forms.Label()
        Me.LabelOperatori = New System.Windows.Forms.Label()
        Me.modelliMezzoTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter()
        Me.AllegatoATableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.allegatoATableAdapter()
        Me.PersonaTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.personaTableAdapter()
        Me.QComuneTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QComuneTableAdapter()
        Me.ComuneTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.comuneTableAdapter()
        Me.PrioritaComuneTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.prioritaComuneTableAdapter()
        Me.QAllegatoATableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter()
        Me.QAllegatoABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        IdMezzoLabel = New System.Windows.Forms.Label()
        TargaLabel = New System.Windows.Forms.Label()
        CognomeLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        IdLuogoNascitaLabel = New System.Windows.Forms.Label()
        DatanascitaLabel = New System.Windows.Forms.Label()
        ResidenzaLabel = New System.Windows.Forms.Label()
        DocumentoLabel = New System.Windows.Forms.Label()
        ContravvenzioniLabel = New System.Windows.Forms.Label()
        PerquisizioneLabel = New System.Windows.Forms.Label()
        PositivoSDILabel = New System.Windows.Forms.Label()
        PrecedentiLabel = New System.Windows.Forms.Label()
        NOTELabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.AllegatoABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GroupBoxResidenza.SuspendLayout()
        CType(Me.ComuneResidenzaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDatiAnagrafici.SuspendLayout()
        CType(Me.ComuneNascitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxMezzo.SuspendLayout()
        CType(Me.MezzoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdMezzoLabel
        '
        IdMezzoLabel.AutoSize = True
        IdMezzoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdMezzoLabel.Location = New System.Drawing.Point(6, 16)
        IdMezzoLabel.Name = "IdMezzoLabel"
        IdMezzoLabel.Size = New System.Drawing.Size(102, 31)
        IdMezzoLabel.TabIndex = 5
        IdMezzoLabel.Text = "&Mezzo:"
        '
        'TargaLabel
        '
        TargaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TargaLabel.AutoSize = True
        TargaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TargaLabel.Location = New System.Drawing.Point(326, 15)
        TargaLabel.Name = "TargaLabel"
        TargaLabel.Size = New System.Drawing.Size(93, 31)
        TargaLabel.TabIndex = 17
        TargaLabel.Text = "&Targa:"
        '
        'CognomeLabel
        '
        CognomeLabel.AutoSize = True
        CognomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CognomeLabel.Location = New System.Drawing.Point(1, 16)
        CognomeLabel.Name = "CognomeLabel"
        CognomeLabel.Size = New System.Drawing.Size(139, 31)
        CognomeLabel.TabIndex = 19
        CognomeLabel.Text = "&Cognome:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(370, 16)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(94, 31)
        NomeLabel.TabIndex = 21
        NomeLabel.Text = "&Nome:"
        '
        'IdLuogoNascitaLabel
        '
        IdLuogoNascitaLabel.AutoSize = True
        IdLuogoNascitaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLuogoNascitaLabel.Location = New System.Drawing.Point(366, 58)
        IdLuogoNascitaLabel.Name = "IdLuogoNascitaLabel"
        IdLuogoNascitaLabel.Size = New System.Drawing.Size(97, 31)
        IdLuogoNascitaLabel.TabIndex = 23
        IdLuogoNascitaLabel.Text = "&Luogo:"
        '
        'DatanascitaLabel
        '
        DatanascitaLabel.AutoSize = True
        DatanascitaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DatanascitaLabel.Location = New System.Drawing.Point(1, 58)
        DatanascitaLabel.Name = "DatanascitaLabel"
        DatanascitaLabel.Size = New System.Drawing.Size(174, 31)
        DatanascitaLabel.TabIndex = 25
        DatanascitaLabel.Text = "&Data nascita:"
        '
        'ResidenzaLabel
        '
        ResidenzaLabel.AutoSize = True
        ResidenzaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ResidenzaLabel.Location = New System.Drawing.Point(5, 17)
        ResidenzaLabel.Name = "ResidenzaLabel"
        ResidenzaLabel.Size = New System.Drawing.Size(79, 31)
        ResidenzaLabel.TabIndex = 27
        ResidenzaLabel.Text = "Citt&à:"
        '
        'DocumentoLabel
        '
        DocumentoLabel.AutoSize = True
        DocumentoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DocumentoLabel.Location = New System.Drawing.Point(5, 17)
        DocumentoLabel.Name = "DocumentoLabel"
        DocumentoLabel.Size = New System.Drawing.Size(161, 31)
        DocumentoLabel.TabIndex = 29
        DocumentoLabel.Text = "Doc&umento:"
        '
        'ContravvenzioniLabel
        '
        ContravvenzioniLabel.AutoSize = True
        ContravvenzioniLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContravvenzioniLabel.Location = New System.Drawing.Point(10, 1)
        ContravvenzioniLabel.Name = "ContravvenzioniLabel"
        ContravvenzioniLabel.Size = New System.Drawing.Size(126, 31)
        ContravvenzioniLabel.TabIndex = 31
        ContravvenzioniLabel.Text = "Contrav.:"
        '
        'PerquisizioneLabel
        '
        PerquisizioneLabel.AutoSize = True
        PerquisizioneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PerquisizioneLabel.Location = New System.Drawing.Point(172, 1)
        PerquisizioneLabel.Name = "PerquisizioneLabel"
        PerquisizioneLabel.Size = New System.Drawing.Size(87, 31)
        PerquisizioneLabel.TabIndex = 33
        PerquisizioneLabel.Text = "Perq.:"
        '
        'PositivoSDILabel
        '
        PositivoSDILabel.AutoSize = True
        PositivoSDILabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PositivoSDILabel.Location = New System.Drawing.Point(6, 20)
        PositivoSDILabel.Name = "PositivoSDILabel"
        PositivoSDILabel.Size = New System.Drawing.Size(171, 31)
        PositivoSDILabel.TabIndex = 35
        PositivoSDILabel.Text = "Positi&vo SDI:"
        '
        'PrecedentiLabel
        '
        PrecedentiLabel.AutoSize = True
        PrecedentiLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecedentiLabel.Location = New System.Drawing.Point(6, 56)
        PrecedentiLabel.Name = "PrecedentiLabel"
        PrecedentiLabel.Size = New System.Drawing.Size(152, 31)
        PrecedentiLabel.TabIndex = 37
        PrecedentiLabel.Text = "P&recedenti:"
        '
        'NOTELabel
        '
        NOTELabel.AutoSize = True
        NOTELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOTELabel.Location = New System.Drawing.Point(4, 23)
        NOTELabel.Name = "NOTELabel"
        NOTELabel.Size = New System.Drawing.Size(80, 31)
        NOTELabel.TabIndex = 43
        NOTELabel.Text = "Note:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(394, 17)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(124, 31)
        Label1.TabIndex = 150
        Label1.Text = "Indiri&zzo:"
        '
        'ColoreLabel
        '
        Me.ColoreLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ColoreLabel.AutoSize = True
        Me.ColoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColoreLabel.Location = New System.Drawing.Point(575, 16)
        Me.ColoreLabel.Name = "ColoreLabel"
        Me.ColoreLabel.Size = New System.Drawing.Size(102, 31)
        Me.ColoreLabel.TabIndex = 15
        Me.ColoreLabel.Text = "Col&ore:"
        '
        'tbColore
        '
        Me.tbColore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbColore.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllegatoABindingSource, "colore", True))
        Me.tbColore.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbColore.Location = New System.Drawing.Point(679, 11)
        Me.tbColore.Name = "tbColore"
        Me.tbColore.Size = New System.Drawing.Size(118, 41)
        Me.tbColore.TabIndex = 30
        Me.tbColore.Text = " "
        '
        'AllegatoABindingSource
        '
        Me.AllegatoABindingSource.DataMember = "allegatoA"
        Me.AllegatoABindingSource.DataSource = Me.DbDataSet
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "DbAlegatoADataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbTarga
        '
        Me.tbTarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTarga.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllegatoABindingSource, "targa", True))
        Me.tbTarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTarga.Location = New System.Drawing.Point(420, 10)
        Me.tbTarga.Name = "tbTarga"
        Me.tbTarga.Size = New System.Drawing.Size(153, 41)
        Me.tbTarga.TabIndex = 20
        Me.tbTarga.Text = " "
        '
        'tbCognome
        '
        Me.tbCognome.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "cognome", True))
        Me.tbCognome.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCognome.Location = New System.Drawing.Point(140, 11)
        Me.tbCognome.Name = "tbCognome"
        Me.tbCognome.Size = New System.Drawing.Size(217, 41)
        Me.tbCognome.TabIndex = 40
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataMember = "persona"
        Me.PersonaBindingSource.DataSource = Me.DbDataSet
        '
        'tbNome
        '
        Me.tbNome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNome.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "nome", True))
        Me.tbNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNome.Location = New System.Drawing.Point(464, 11)
        Me.tbNome.Name = "tbNome"
        Me.tbNome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbNome.Size = New System.Drawing.Size(333, 41)
        Me.tbNome.TabIndex = 50
        '
        'tbDocumento
        '
        Me.tbDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDocumento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "documento", True))
        Me.tbDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDocumento.Location = New System.Drawing.Point(172, 13)
        Me.tbDocumento.MaxLength = 50
        Me.tbDocumento.Name = "tbDocumento"
        Me.tbDocumento.Size = New System.Drawing.Size(270, 41)
        Me.tbDocumento.TabIndex = 100
        Me.tbDocumento.Text = " "
        '
        'ContravvenzioniCheckBox
        '
        Me.ContravvenzioniCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AllegatoABindingSource, "contravvenzioni", True))
        Me.ContravvenzioniCheckBox.FlatAppearance.BorderSize = 3
        Me.ContravvenzioniCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContravvenzioniCheckBox.Location = New System.Drawing.Point(136, 8)
        Me.ContravvenzioniCheckBox.Name = "ContravvenzioniCheckBox"
        Me.ContravvenzioniCheckBox.Size = New System.Drawing.Size(18, 22)
        Me.ContravvenzioniCheckBox.TabIndex = 110
        Me.ContravvenzioniCheckBox.UseCompatibleTextRendering = True
        '
        'PerquisizioneCheckBox
        '
        Me.PerquisizioneCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AllegatoABindingSource, "perquisizione", True))
        Me.PerquisizioneCheckBox.Location = New System.Drawing.Point(259, 8)
        Me.PerquisizioneCheckBox.Name = "PerquisizioneCheckBox"
        Me.PerquisizioneCheckBox.Size = New System.Drawing.Size(18, 22)
        Me.PerquisizioneCheckBox.TabIndex = 120
        '
        'tbPrecedenti
        '
        Me.tbPrecedenti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPrecedenti.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "precedenti", True))
        Me.tbPrecedenti.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrecedenti.Location = New System.Drawing.Point(12, 90)
        Me.tbPrecedenti.MaxLength = 536870910
        Me.tbPrecedenti.Multiline = True
        Me.tbPrecedenti.Name = "tbPrecedenti"
        Me.tbPrecedenti.Size = New System.Drawing.Size(331, 118)
        Me.tbPrecedenti.TabIndex = 140
        Me.tbPrecedenti.Text = " "
        '
        'tbNote
        '
        Me.tbNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllegatoABindingSource, "NOTE", True))
        Me.tbNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNote.Location = New System.Drawing.Point(94, 19)
        Me.tbNote.Multiline = True
        Me.tbNote.Name = "tbNote"
        Me.tbNote.Size = New System.Drawing.Size(346, 91)
        Me.tbNote.TabIndex = 150
        Me.tbNote.Text = " "
        '
        'btnSalvaChiudi
        '
        Me.btnSalvaChiudi.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.btnSalvaChiudi.Location = New System.Drawing.Point(3, 67)
        Me.btnSalvaChiudi.Name = "btnSalvaChiudi"
        Me.btnSalvaChiudi.Size = New System.Drawing.Size(172, 84)
        Me.btnSalvaChiudi.TabIndex = 203
        Me.btnSalvaChiudi.Text = "&Salva e Chiudi"
        Me.btnSalvaChiudi.UseVisualStyleBackColor = True
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.btnAnnulla.Location = New System.Drawing.Point(3, 3)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(172, 58)
        Me.btnAnnulla.TabIndex = 202
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = True
        '
        'labelOS
        '
        Me.labelOS.AutoSize = True
        Me.labelOS.CausesValidation = False
        Me.labelOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelOS.Location = New System.Drawing.Point(375, 9)
        Me.labelOS.Name = "labelOS"
        Me.labelOS.Size = New System.Drawing.Size(77, 24)
        Me.labelOS.TabIndex = 147
        Me.labelOS.Text = "labelOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(210, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 24)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Ordine di Servizio"
        '
        'btnPasseggero
        '
        Me.btnPasseggero.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnPasseggero.Location = New System.Drawing.Point(3, 3)
        Me.btnPasseggero.Name = "btnPasseggero"
        Me.btnPasseggero.Size = New System.Drawing.Size(172, 53)
        Me.btnPasseggero.TabIndex = 200
        Me.btnPasseggero.Text = "&Passeggero..."
        Me.btnPasseggero.UseVisualStyleBackColor = True
        '
        'PositivoSDIComboBox
        '
        Me.PositivoSDIComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllegatoABindingSource, "positivoSDI", True))
        Me.PositivoSDIComboBox.FormattingEnabled = True
        Me.PositivoSDIComboBox.Items.AddRange(New Object() {"--", "NO", "SI"})
        Me.PositivoSDIComboBox.Location = New System.Drawing.Point(183, 27)
        Me.PositivoSDIComboBox.MaxLength = 2
        Me.PositivoSDIComboBox.Name = "PositivoSDIComboBox"
        Me.PositivoSDIComboBox.Size = New System.Drawing.Size(47, 21)
        Me.PositivoSDIComboBox.TabIndex = 130
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 139)
        Me.GroupBox1.TabIndex = 153
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Accompagnatore"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPasseggero)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAPiedi)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(184, 120)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnAPiedi
        '
        Me.btnAPiedi.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnAPiedi.Location = New System.Drawing.Point(3, 62)
        Me.btnAPiedi.Name = "btnAPiedi"
        Me.btnAPiedi.Size = New System.Drawing.Size(172, 53)
        Me.btnAPiedi.TabIndex = 201
        Me.btnAPiedi.Text = "A p&iedi..."
        Me.btnAPiedi.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 355)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 174)
        Me.GroupBox2.TabIndex = 154
        Me.GroupBox2.TabStop = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnAnnulla)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnSalvaChiudi)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(184, 155)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'GroupBoxResidenza
        '
        Me.GroupBoxResidenza.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxResidenza.Controls.Add(Me.ComboBoxComuneResidenza)
        Me.GroupBoxResidenza.Controls.Add(ResidenzaLabel)
        Me.GroupBoxResidenza.Controls.Add(Me.tbIndirizzo)
        Me.GroupBoxResidenza.Controls.Add(Label1)
        Me.GroupBoxResidenza.Location = New System.Drawing.Point(12, 253)
        Me.GroupBoxResidenza.Name = "GroupBoxResidenza"
        Me.GroupBoxResidenza.Size = New System.Drawing.Size(803, 59)
        Me.GroupBoxResidenza.TabIndex = 2
        Me.GroupBoxResidenza.TabStop = False
        Me.GroupBoxResidenza.Text = "Residenza"
        '
        'ComboBoxComuneResidenza
        '
        Me.ComboBoxComuneResidenza.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PersonaBindingSource, "idResidenzaComune", True))
        Me.ComboBoxComuneResidenza.DataSource = Me.ComuneResidenzaBindingSource
        Me.ComboBoxComuneResidenza.DisplayMember = "citta"
        Me.ComboBoxComuneResidenza.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.ComboBoxComuneResidenza.FormattingEnabled = True
        Me.ComboBoxComuneResidenza.Location = New System.Drawing.Point(80, 12)
        Me.ComboBoxComuneResidenza.MaxDropDownItems = 10
        Me.ComboBoxComuneResidenza.Name = "ComboBoxComuneResidenza"
        Me.ComboBoxComuneResidenza.Size = New System.Drawing.Size(304, 41)
        Me.ComboBoxComuneResidenza.TabIndex = 80
        Me.ComboBoxComuneResidenza.ValueMember = "id"
        '
        'ComuneResidenzaBindingSource
        '
        Me.ComuneResidenzaBindingSource.DataMember = "QComune"
        Me.ComuneResidenzaBindingSource.DataSource = Me.DbDataSet2
        '
        'DbDataSet2
        '
        Me.DbDataSet2.DataSetName = "DbDataSet2"
        Me.DbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbIndirizzo
        '
        Me.tbIndirizzo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbIndirizzo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "residenzaindirizzo", True))
        Me.tbIndirizzo.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIndirizzo.Location = New System.Drawing.Point(520, 12)
        Me.tbIndirizzo.MaxLength = 50
        Me.tbIndirizzo.Name = "tbIndirizzo"
        Me.tbIndirizzo.Size = New System.Drawing.Size(277, 41)
        Me.tbIndirizzo.TabIndex = 90
        Me.tbIndirizzo.Text = " "
        '
        'GroupBoxDatiAnagrafici
        '
        Me.GroupBoxDatiAnagrafici.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxDatiAnagrafici.Controls.Add(Me.DataNascitaMaskedTextBox)
        Me.GroupBoxDatiAnagrafici.Controls.Add(Me.ComboBoxComuneNascita)
        Me.GroupBoxDatiAnagrafici.Controls.Add(DatanascitaLabel)
        Me.GroupBoxDatiAnagrafici.Controls.Add(IdLuogoNascitaLabel)
        Me.GroupBoxDatiAnagrafici.Controls.Add(Me.tbNome)
        Me.GroupBoxDatiAnagrafici.Controls.Add(NomeLabel)
        Me.GroupBoxDatiAnagrafici.Controls.Add(Me.tbCognome)
        Me.GroupBoxDatiAnagrafici.Controls.Add(CognomeLabel)
        Me.GroupBoxDatiAnagrafici.Location = New System.Drawing.Point(12, 153)
        Me.GroupBoxDatiAnagrafici.Name = "GroupBoxDatiAnagrafici"
        Me.GroupBoxDatiAnagrafici.Size = New System.Drawing.Size(803, 100)
        Me.GroupBoxDatiAnagrafici.TabIndex = 1
        Me.GroupBoxDatiAnagrafici.TabStop = False
        Me.GroupBoxDatiAnagrafici.Text = "Dati anagrafici"
        '
        'DataNascitaMaskedTextBox
        '
        Me.DataNascitaMaskedTextBox.CausesValidation = False
        Me.DataNascitaMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "datanascita", True))
        Me.DataNascitaMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.DataNascitaMaskedTextBox.Location = New System.Drawing.Point(180, 54)
        Me.DataNascitaMaskedTextBox.Mask = "00/00/0000"
        Me.DataNascitaMaskedTextBox.Name = "DataNascitaMaskedTextBox"
        Me.DataNascitaMaskedTextBox.Size = New System.Drawing.Size(177, 41)
        Me.DataNascitaMaskedTextBox.TabIndex = 60
        Me.DataNascitaMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ComboBoxComuneNascita
        '
        Me.ComboBoxComuneNascita.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxComuneNascita.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PersonaBindingSource, "idLuogoNascita", True))
        Me.ComboBoxComuneNascita.DataSource = Me.ComuneNascitaBindingSource
        Me.ComboBoxComuneNascita.DisplayMember = "citta"
        Me.ComboBoxComuneNascita.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.ComboBoxComuneNascita.FormattingEnabled = True
        Me.ComboBoxComuneNascita.Location = New System.Drawing.Point(464, 54)
        Me.ComboBoxComuneNascita.Name = "ComboBoxComuneNascita"
        Me.ComboBoxComuneNascita.Size = New System.Drawing.Size(333, 41)
        Me.ComboBoxComuneNascita.TabIndex = 70
        Me.ComboBoxComuneNascita.ValueMember = "id"
        '
        'ComuneNascitaBindingSource
        '
        Me.ComuneNascitaBindingSource.DataMember = "QComune"
        Me.ComuneNascitaBindingSource.DataSource = Me.DbDataSet
        '
        'GroupBoxMezzo
        '
        Me.GroupBoxMezzo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxMezzo.Controls.Add(Me.ComboBoxModelliMezzo)
        Me.GroupBoxMezzo.Controls.Add(IdMezzoLabel)
        Me.GroupBoxMezzo.Controls.Add(Me.tbColore)
        Me.GroupBoxMezzo.Controls.Add(TargaLabel)
        Me.GroupBoxMezzo.Controls.Add(Me.ColoreLabel)
        Me.GroupBoxMezzo.Controls.Add(Me.tbTarga)
        Me.GroupBoxMezzo.Location = New System.Drawing.Point(12, 96)
        Me.GroupBoxMezzo.Name = "GroupBoxMezzo"
        Me.GroupBoxMezzo.Size = New System.Drawing.Size(803, 57)
        Me.GroupBoxMezzo.TabIndex = 0
        Me.GroupBoxMezzo.TabStop = False
        Me.GroupBoxMezzo.Text = "Mezzo"
        '
        'ComboBoxModelliMezzo
        '
        Me.ComboBoxModelliMezzo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxModelliMezzo.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ComboBoxModelliMezzo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ComboBoxModelliMezzo.CausesValidation = False
        Me.ComboBoxModelliMezzo.Location = New System.Drawing.Point(111, 11)
        Me.ComboBoxModelliMezzo.Name = "ComboBoxModelliMezzo"
        Me.ComboBoxModelliMezzo.Size = New System.Drawing.Size(209, 42)
        Me.ComboBoxModelliMezzo.TabIndex = 0
        '
        'MezzoBindingSource
        '
        Me.MezzoBindingSource.DataMember = "modelliMezzo"
        Me.MezzoBindingSource.DataSource = Me.DbDataSet
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.tbPrecedenti)
        Me.GroupBox6.Controls.Add(PrecedentiLabel)
        Me.GroupBox6.Controls.Add(PositivoSDILabel)
        Me.GroupBox6.Controls.Add(Me.PositivoSDIComboBox)
        Me.GroupBox6.Location = New System.Drawing.Point(466, 312)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(349, 214)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Interesse Operativo"
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.tbDocumento)
        Me.GroupBox7.Controls.Add(DocumentoLabel)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 312)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(448, 64)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Identificazione"
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(NOTELabel)
        Me.GroupBox8.Controls.Add(Me.tbNote)
        Me.GroupBox8.Location = New System.Drawing.Point(12, 410)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(448, 116)
        Me.GroupBox8.TabIndex = 6
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Note - Informazioni che non verranno incluse nei report"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(ContravvenzioniLabel)
        Me.Panel1.Controls.Add(Me.PerquisizioneCheckBox)
        Me.Panel1.Controls.Add(PerquisizioneLabel)
        Me.Panel1.Controls.Add(Me.ContravvenzioniCheckBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 376)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 34)
        Me.Panel1.TabIndex = 5
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.FlowLayoutPanel3)
        Me.GroupBox9.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(171, 86)
        Me.GroupBox9.TabIndex = 159
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Persone di Interesse Operativo"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.cbPip)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnAddPIO)
        Me.FlowLayoutPanel3.Controls.Add(Me.bPIOSel)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(165, 67)
        Me.FlowLayoutPanel3.TabIndex = 0
        '
        'cbPip
        '
        Me.cbPip.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbPip.BackgroundImage = Global.OrSe.My.Resources.Resources.sagomaOFF
        Me.cbPip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cbPip.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PersonaBindingSource, "pio", True))
        Me.cbPip.FlatAppearance.BorderSize = 0
        Me.cbPip.Location = New System.Drawing.Point(3, 3)
        Me.cbPip.Name = "cbPip"
        Me.cbPip.Size = New System.Drawing.Size(60, 60)
        Me.cbPip.TabIndex = 0
        Me.cbPip.Text = "    "
        Me.ToolTip.SetToolTip(Me.cbPip, "Contrassegna come Persona di Interesse Operativo")
        Me.cbPip.UseVisualStyleBackColor = True
        '
        'btnAddPIO
        '
        Me.btnAddPIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPIO.Location = New System.Drawing.Point(69, 3)
        Me.btnAddPIO.Name = "btnAddPIO"
        Me.btnAddPIO.Size = New System.Drawing.Size(82, 26)
        Me.btnAddPIO.TabIndex = 158
        Me.btnAddPIO.Text = "Sele&ziona..."
        Me.ToolTip.SetToolTip(Me.btnAddPIO, "Seleziona una persona tra quelle già memorizzate.")
        Me.btnAddPIO.UseVisualStyleBackColor = True
        '
        'bPIOSel
        '
        Me.bPIOSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bPIOSel.Enabled = False
        Me.bPIOSel.Location = New System.Drawing.Point(69, 35)
        Me.bPIOSel.Name = "bPIOSel"
        Me.bPIOSel.Size = New System.Drawing.Size(82, 26)
        Me.bPIOSel.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.bPIOSel, "Se la persona esiste, si può selezionare per completare i dati")
        Me.bPIOSel.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel4.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(819, 0)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(205, 532)
        Me.FlowLayoutPanel4.TabIndex = 160
        '
        'LabelControllo
        '
        Me.LabelControllo.AutoSize = True
        Me.LabelControllo.CausesValidation = False
        Me.LabelControllo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControllo.Location = New System.Drawing.Point(376, 33)
        Me.LabelControllo.Name = "LabelControllo"
        Me.LabelControllo.Size = New System.Drawing.Size(99, 17)
        Me.LabelControllo.TabIndex = 163
        Me.LabelControllo.Text = "LabelControllo"
        '
        'LabelOperatori
        '
        Me.LabelOperatori.AutoSize = True
        Me.LabelOperatori.CausesValidation = False
        Me.LabelOperatori.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelOperatori.Location = New System.Drawing.Point(376, 50)
        Me.LabelOperatori.Name = "LabelOperatori"
        Me.LabelOperatori.Size = New System.Drawing.Size(103, 17)
        Me.LabelOperatori.TabIndex = 164
        Me.LabelOperatori.Text = "LabelOperatori"
        '
        'modelliMezzoTableAdapter
        '
        Me.modelliMezzoTableAdapter.ClearBeforeFill = True
        '
        'AllegatoATableAdapter
        '
        Me.AllegatoATableAdapter.ClearBeforeFill = True
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'QComuneTableAdapter
        '
        Me.QComuneTableAdapter.ClearBeforeFill = True
        '
        'ComuneTableAdapter
        '
        Me.ComuneTableAdapter.ClearBeforeFill = True
        '
        'PrioritaComuneTableAdapter
        '
        Me.PrioritaComuneTableAdapter.ClearBeforeFill = True
        '
        'QAllegatoATableAdapter
        '
        Me.QAllegatoATableAdapter.ClearBeforeFill = True
        '
        'QAllegatoABindingSource
        '
        Me.QAllegatoABindingSource.DataMember = "QAllegatoA"
        Me.QAllegatoABindingSource.DataSource = Me.DbDataSet
        '
        'FSoggetto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 532)
        Me.Controls.Add(Me.LabelOperatori)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.LabelControllo)
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBoxMezzo)
        Me.Controls.Add(Me.GroupBoxResidenza)
        Me.Controls.Add(Me.labelOS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBoxDatiAnagrafici)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "FSoggetto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Soggetti"
        CType(Me.AllegatoABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.GroupBoxResidenza.ResumeLayout(False)
        Me.GroupBoxResidenza.PerformLayout()
        CType(Me.ComuneResidenzaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDatiAnagrafici.ResumeLayout(False)
        Me.GroupBoxDatiAnagrafici.PerformLayout()
        CType(Me.ComuneNascitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxMezzo.ResumeLayout(False)
        Me.GroupBoxMezzo.PerformLayout()
        CType(Me.MezzoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbDataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents AllegatoABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tbColore As System.Windows.Forms.TextBox
    Friend WithEvents tbTarga As System.Windows.Forms.TextBox
    Friend WithEvents tbCognome As System.Windows.Forms.TextBox
    Friend WithEvents tbNome As System.Windows.Forms.TextBox
    Friend WithEvents tbDocumento As System.Windows.Forms.TextBox
    Friend WithEvents ContravvenzioniCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PerquisizioneCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents tbPrecedenti As System.Windows.Forms.TextBox
    Friend WithEvents tbNote As System.Windows.Forms.TextBox
    Friend WithEvents MezzoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents modelliMezzoTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter
    Friend WithEvents ComuneNascitaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnSalvaChiudi As System.Windows.Forms.Button
    Friend WithEvents btnAnnulla As System.Windows.Forms.Button
    Friend WithEvents labelOS As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnPasseggero As System.Windows.Forms.Button
    Friend WithEvents PositivoSDIComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AllegatoATableAdapter As OrSe.dbAlegatoADataSetTableAdapters.allegatoATableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAPiedi As System.Windows.Forms.Button
    Friend WithEvents ColoreLabel As System.Windows.Forms.Label
    Friend WithEvents PersonaTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.personaTableAdapter
    Friend WithEvents PersonaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GroupBoxResidenza As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxDatiAnagrafici As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxMezzo As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents tbIndirizzo As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cbPip As System.Windows.Forms.CheckBox
    Friend WithEvents btnAddPIO As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents bPIOSel As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelControllo As System.Windows.Forms.Label
    Friend WithEvents DbDataSet2 As OrSe.dbAlegatoADataSet
    Friend WithEvents ComboBoxComuneNascita As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxComuneResidenza As System.Windows.Forms.ComboBox
    Friend WithEvents ComuneResidenzaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QComuneTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QComuneTableAdapter
    Friend WithEvents ComuneTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.comuneTableAdapter
    Friend WithEvents PrioritaComuneTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.prioritaComuneTableAdapter
    Friend WithEvents LabelOperatori As System.Windows.Forms.Label
    Friend WithEvents QAllegatoATableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
    Friend WithEvents QAllegatoABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataNascitaMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ComboBoxModelliMezzo As OrSe.UserControlComboBox
End Class
