<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPrima
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPrima))
        Me.PreferenzeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StampaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.informazioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllegatoAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OP85ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SopralluogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrumentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancellaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CercaAggiornamentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemLOG = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EseguiBackupDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RipristinaBackupDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SessioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferenzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpzioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QAllegatoABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbAlegatoADataSet_Unico = New OrSe.dbAlegatoADataSet()
        Me.QInterventiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QInterventi_informazioniBindigSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.InterventiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InterventiTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.interventiTableAdapter()
        Me.AllegatoABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QAllegatoATableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter()
        Me.AllegatoATableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.allegatoATableAdapter()
        Me.OrdineServizioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdineServizioTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter()
        Me.QInterventiTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QInterventiTableAdapter()
        Me.ComuneTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.comuneTableAdapter()
        Me.ModelliMezzoTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.labelInfoOS = New System.Windows.Forms.Label()
        Me.ButtonRubrica = New System.Windows.Forms.Button()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.BtnVedi = New System.Windows.Forms.Button()
        Me.btnSopralluogo = New System.Windows.Forms.Button()
        Me.btnInformazioni = New System.Windows.Forms.Button()
        Me.btnIntervento = New System.Windows.Forms.Button()
        Me.btnAlegatoA = New System.Windows.Forms.Button()
        Me.FlowLayoutPanelEsterno = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnRubrica = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VerticalLabel2 = New OrSe.verticalLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbAlegatoADataSet_Unico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QInterventiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QInterventi_informazioniBindigSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.InterventiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllegatoABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdineServizioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.menu.SuspendLayout()
        Me.FlowLayoutPanelEsterno.SuspendLayout()
        Me.SuspendLayout()
        '
        'PreferenzeToolStripMenuItem1
        '
        Me.PreferenzeToolStripMenuItem1.Name = "PreferenzeToolStripMenuItem1"
        Me.PreferenzeToolStripMenuItem1.Size = New System.Drawing.Size(74, 20)
        Me.PreferenzeToolStripMenuItem1.Text = "Preferenze"
        '
        'StampaToolStripMenuItem
        '
        Me.StampaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.informazioniToolStripMenuItem, Me.AllegatoAToolStripMenuItem, Me.OP85ToolStripMenuItem, Me.SopralluogoToolStripMenuItem})
        Me.StampaToolStripMenuItem.Name = "StampaToolStripMenuItem"
        Me.StampaToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.StampaToolStripMenuItem.Text = "Stampa..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.OrSe.My.Resources.Resources.printInterventi
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripMenuItem1.Text = "Interventi..."
        '
        'informazioniToolStripMenuItem
        '
        Me.informazioniToolStripMenuItem.Image = Global.OrSe.My.Resources.Resources.printInterventi
        Me.informazioniToolStripMenuItem.Name = "informazioniToolStripMenuItem"
        Me.informazioniToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.informazioniToolStripMenuItem.Text = "Informazioni..."
        '
        'AllegatoAToolStripMenuItem
        '
        Me.AllegatoAToolStripMenuItem.Image = Global.OrSe.My.Resources.Resources.printAllegatoA
        Me.AllegatoAToolStripMenuItem.Name = "AllegatoAToolStripMenuItem"
        Me.AllegatoAToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AllegatoAToolStripMenuItem.Text = "Allegato A..."
        '
        'OP85ToolStripMenuItem
        '
        Me.OP85ToolStripMenuItem.Image = Global.OrSe.My.Resources.Resources.printOP85
        Me.OP85ToolStripMenuItem.Name = "OP85ToolStripMenuItem"
        Me.OP85ToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.OP85ToolStripMenuItem.Text = "OP85..."
        '
        'SopralluogoToolStripMenuItem
        '
        Me.SopralluogoToolStripMenuItem.Image = Global.OrSe.My.Resources.Resources.printOP85
        Me.SopralluogoToolStripMenuItem.Name = "SopralluogoToolStripMenuItem"
        Me.SopralluogoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SopralluogoToolStripMenuItem.Text = "Sopralluogo..."
        '
        'StrumentiToolStripMenuItem
        '
        Me.StrumentiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CercaToolStripMenuItem, Me.ToolStripSeparator2, Me.ExportToolStripMenuItem, Me.ImportToolStripMenuItem, Me.ToolStripSeparator3, Me.CancellaToolStripMenuItem, Me.CercaAggiornamentiToolStripMenuItem, Me.ToolStripMenuItemLOG, Me.ToolStripSeparator1, Me.EseguiBackupDBToolStripMenuItem, Me.RipristinaBackupDBToolStripMenuItem})
        Me.StrumentiToolStripMenuItem.Name = "StrumentiToolStripMenuItem"
        Me.StrumentiToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.StrumentiToolStripMenuItem.Text = "Strumenti..."
        '
        'CercaToolStripMenuItem
        '
        Me.CercaToolStripMenuItem.Image = Global.OrSe.My.Resources.Resources.DBFind
        Me.CercaToolStripMenuItem.Name = "CercaToolStripMenuItem"
        Me.CercaToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.CercaToolStripMenuItem.Text = "Cerca..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(247, 6)
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.ExportToolStripMenuItem.Text = "export..."
        Me.ExportToolStripMenuItem.Visible = False
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.ImportToolStripMenuItem.Text = "import..."
        Me.ImportToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(247, 6)
        Me.ToolStripSeparator3.Visible = False
        '
        'CancellaToolStripMenuItem
        '
        Me.CancellaToolStripMenuItem.Name = "CancellaToolStripMenuItem"
        Me.CancellaToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.CancellaToolStripMenuItem.Text = "Cancella..."
        '
        'CercaAggiornamentiToolStripMenuItem
        '
        Me.CercaAggiornamentiToolStripMenuItem.Name = "CercaAggiornamentiToolStripMenuItem"
        Me.CercaAggiornamentiToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.CercaAggiornamentiToolStripMenuItem.Text = "Controlla aggiornamenti..."
        '
        'ToolStripMenuItemLOG
        '
        Me.ToolStripMenuItemLOG.CheckOnClick = True
        Me.ToolStripMenuItemLOG.Name = "ToolStripMenuItemLOG"
        Me.ToolStripMenuItemLOG.Size = New System.Drawing.Size(250, 22)
        Me.ToolStripMenuItemLOG.Text = "Finestra log"
        Me.ToolStripMenuItemLOG.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(247, 6)
        '
        'EseguiBackupDBToolStripMenuItem
        '
        Me.EseguiBackupDBToolStripMenuItem.Name = "EseguiBackupDBToolStripMenuItem"
        Me.EseguiBackupDBToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.EseguiBackupDBToolStripMenuItem.Text = "Esegui backup DB e preferenze"
        '
        'RipristinaBackupDBToolStripMenuItem
        '
        Me.RipristinaBackupDBToolStripMenuItem.Name = "RipristinaBackupDBToolStripMenuItem"
        Me.RipristinaBackupDBToolStripMenuItem.Size = New System.Drawing.Size(250, 22)
        Me.RipristinaBackupDBToolStripMenuItem.Text = "Ripristina backup DB e preferenze"
        '
        'SessioneToolStripMenuItem
        '
        Me.SessioneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem1})
        Me.SessioneToolStripMenuItem.Name = "SessioneToolStripMenuItem"
        Me.SessioneToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.SessioneToolStripMenuItem.Text = "Sessione..."
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.LogoutToolStripMenuItem1.Text = "Logout..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersioneToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'VersioneToolStripMenuItem
        '
        Me.VersioneToolStripMenuItem.Name = "VersioneToolStripMenuItem"
        Me.VersioneToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.VersioneToolStripMenuItem.Text = "About OrSe"
        '
        'PreferenzeToolStripMenuItem
        '
        Me.PreferenzeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpzioniToolStripMenuItem})
        Me.PreferenzeToolStripMenuItem.Name = "PreferenzeToolStripMenuItem"
        Me.PreferenzeToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.PreferenzeToolStripMenuItem.Text = "Preferenze"
        '
        'OpzioniToolStripMenuItem
        '
        Me.OpzioniToolStripMenuItem.Name = "OpzioniToolStripMenuItem"
        Me.OpzioniToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.OpzioniToolStripMenuItem.Text = "Opzioni..."
        '
        'QAllegatoABindingSource
        '
        Me.QAllegatoABindingSource.DataMember = "QAllegatoA"
        Me.QAllegatoABindingSource.DataSource = Me.DbAlegatoADataSet_Unico
        '
        'DbAlegatoADataSet_Unico
        '
        Me.DbAlegatoADataSet_Unico.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet_Unico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QInterventiBindingSource
        '
        Me.QInterventiBindingSource.DataMember = "QInterventi"
        Me.QInterventiBindingSource.DataSource = Me.DbAlegatoADataSet_Unico
        Me.QInterventiBindingSource.Filter = ""
        '
        'QInterventi_informazioniBindigSource
        '
        Me.QInterventi_informazioniBindigSource.DataMember = "QInterventi"
        Me.QInterventi_informazioniBindigSource.DataSource = Me.DbAlegatoADataSet_Unico
        Me.QInterventi_informazioniBindigSource.Filter = ""
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel2.TabIndex = 23
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1008, 0)
        Me.FlowLayoutPanel1.TabIndex = 24
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 512)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1008, 0)
        Me.TableLayoutPanel2.TabIndex = 27
        '
        'InterventiBindingSource
        '
        Me.InterventiBindingSource.DataMember = "interventi"
        Me.InterventiBindingSource.DataSource = Me.DbAlegatoADataSet_Unico
        '
        'InterventiTableAdapter
        '
        Me.InterventiTableAdapter.ClearBeforeFill = True
        '
        'AllegatoABindingSource
        '
        Me.AllegatoABindingSource.DataMember = "allegatoA"
        Me.AllegatoABindingSource.DataSource = Me.DbAlegatoADataSet_Unico
        '
        'QAllegatoATableAdapter
        '
        Me.QAllegatoATableAdapter.ClearBeforeFill = True
        '
        'AllegatoATableAdapter
        '
        Me.AllegatoATableAdapter.ClearBeforeFill = True
        '
        'OrdineServizioBindingSource
        '
        Me.OrdineServizioBindingSource.DataMember = "ordineServizio"
        Me.OrdineServizioBindingSource.DataSource = Me.DbAlegatoADataSet_Unico
        '
        'OrdineServizioTableAdapter
        '
        Me.OrdineServizioTableAdapter.ClearBeforeFill = True
        '
        'QInterventiTableAdapter
        '
        Me.QInterventiTableAdapter.ClearBeforeFill = True
        '
        'ComuneTableAdapter
        '
        Me.ComuneTableAdapter.ClearBeforeFill = True
        '
        'ModelliMezzoTableAdapter
        '
        Me.ModelliMezzoTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.labelInfoOS)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 24)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(1008, 53)
        Me.FlowLayoutPanel3.TabIndex = 29
        '
        'labelInfoOS
        '
        Me.labelInfoOS.AutoSize = True
        Me.labelInfoOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.labelInfoOS.Location = New System.Drawing.Point(3, 6)
        Me.labelInfoOS.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.labelInfoOS.Name = "labelInfoOS"
        Me.labelInfoOS.Size = New System.Drawing.Size(134, 44)
        Me.labelInfoOS.TabIndex = 13
        Me.labelInfoOS.Text = "Label1"
        '
        'ButtonRubrica
        '
        Me.ButtonRubrica.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.ButtonRubrica.Image = CType(resources.GetObject("ButtonRubrica.Image"), System.Drawing.Image)
        Me.ButtonRubrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRubrica.Location = New System.Drawing.Point(309, 94)
        Me.ButtonRubrica.Name = "ButtonRubrica"
        Me.ButtonRubrica.Size = New System.Drawing.Size(300, 85)
        Me.ButtonRubrica.TabIndex = 10
        Me.ButtonRubrica.Text = " &Rubrica..."
        Me.ButtonRubrica.UseCompatibleTextRendering = True
        Me.ButtonRubrica.UseVisualStyleBackColor = True
        '
        'menu
        '
        Me.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferenzeToolStripMenuItem1, Me.StampaToolStripMenuItem, Me.StrumentiToolStripMenuItem, Me.SessioneToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(1008, 24)
        Me.menu.TabIndex = 22
        Me.menu.Text = "menu"
        '
        'BtnVedi
        '
        Me.BtnVedi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnVedi.FlatAppearance.BorderSize = 3
        Me.BtnVedi.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.BtnVedi.Location = New System.Drawing.Point(615, 94)
        Me.BtnVedi.Name = "BtnVedi"
        Me.BtnVedi.Size = New System.Drawing.Size(300, 85)
        Me.BtnVedi.TabIndex = 8
        Me.BtnVedi.Text = "V&edi..."
        Me.BtnVedi.UseVisualStyleBackColor = True
        '
        'btnSopralluogo
        '
        Me.btnSopralluogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.btnSopralluogo.Image = Global.OrSe.My.Resources.Resources.pulsanteSoleGrigio
        Me.btnSopralluogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSopralluogo.Location = New System.Drawing.Point(3, 94)
        Me.btnSopralluogo.Name = "btnSopralluogo"
        Me.btnSopralluogo.Size = New System.Drawing.Size(300, 85)
        Me.btnSopralluogo.TabIndex = 9
        Me.btnSopralluogo.Text = "Sopra&lluogo..."
        Me.btnSopralluogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSopralluogo.UseCompatibleTextRendering = True
        Me.btnSopralluogo.UseVisualStyleBackColor = True
        '
        'btnInformazioni
        '
        Me.btnInformazioni.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.btnInformazioni.Image = Global.OrSe.My.Resources.Resources.pulsanteSoleVerde
        Me.btnInformazioni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInformazioni.Location = New System.Drawing.Point(615, 3)
        Me.btnInformazioni.Name = "btnInformazioni"
        Me.btnInformazioni.Size = New System.Drawing.Size(300, 85)
        Me.btnInformazioni.TabIndex = 7
        Me.btnInformazioni.Text = "I&nformazioni..."
        Me.btnInformazioni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInformazioni.UseCompatibleTextRendering = True
        Me.btnInformazioni.UseVisualStyleBackColor = True
        '
        'btnIntervento
        '
        Me.btnIntervento.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.btnIntervento.Image = Global.OrSe.My.Resources.Resources.db_addVerde
        Me.btnIntervento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIntervento.Location = New System.Drawing.Point(309, 3)
        Me.btnIntervento.Name = "btnIntervento"
        Me.btnIntervento.Size = New System.Drawing.Size(300, 85)
        Me.btnIntervento.TabIndex = 0
        Me.btnIntervento.Text = "&Intervento..."
        Me.btnIntervento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIntervento.UseCompatibleTextRendering = True
        Me.btnIntervento.UseVisualStyleBackColor = True
        '
        'btnAlegatoA
        '
        Me.btnAlegatoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.btnAlegatoA.Image = Global.OrSe.My.Resources.Resources.db_addBlu
        Me.btnAlegatoA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlegatoA.Location = New System.Drawing.Point(3, 3)
        Me.btnAlegatoA.Name = "btnAlegatoA"
        Me.btnAlegatoA.Size = New System.Drawing.Size(300, 85)
        Me.btnAlegatoA.TabIndex = 6
        Me.btnAlegatoA.Text = "Contr&ollo..."
        Me.btnAlegatoA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlegatoA.UseCompatibleTextRendering = True
        Me.btnAlegatoA.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelEsterno
        '
        Me.FlowLayoutPanelEsterno.AutoSize = True
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.btnAlegatoA)
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.btnIntervento)
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.btnInformazioni)
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.btnSopralluogo)
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.btnRubrica)
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.BtnVedi)
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.Button1)
        Me.FlowLayoutPanelEsterno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelEsterno.Location = New System.Drawing.Point(0, 77)
        Me.FlowLayoutPanelEsterno.Name = "FlowLayoutPanelEsterno"
        Me.FlowLayoutPanelEsterno.Size = New System.Drawing.Size(1008, 435)
        Me.FlowLayoutPanelEsterno.TabIndex = 28
        '
        'btnRubrica
        '
        Me.btnRubrica.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.btnRubrica.Image = CType(resources.GetObject("btnRubrica.Image"), System.Drawing.Image)
        Me.btnRubrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRubrica.Location = New System.Drawing.Point(309, 94)
        Me.btnRubrica.Name = "btnRubrica"
        Me.btnRubrica.Size = New System.Drawing.Size(300, 85)
        Me.btnRubrica.TabIndex = 10
        Me.btnRubrica.Text = " &Rubrica..."
        Me.btnRubrica.UseCompatibleTextRendering = True
        Me.btnRubrica.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!)
        Me.Button1.Image = Global.OrSe.My.Resources.Resources.DBFind
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(300, 85)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = " &Cerca..."
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VerticalLabel2
        '
        Me.VerticalLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.VerticalLabel2.Location = New System.Drawing.Point(3, 0)
        Me.VerticalLabel2.Name = "VerticalLabel2"
        Me.VerticalLabel2.Size = New System.Drawing.Size(24, 114)
        Me.VerticalLabel2.TabIndex = 26
        Me.VerticalLabel2.Text = "Interventi"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 90000
        '
        'FPrima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1008, 512)
        Me.Controls.Add(Me.FlowLayoutPanelEsterno)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.menu)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu
        Me.Name = "FPrima"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrSe"
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbAlegatoADataSet_Unico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QInterventiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QInterventi_informazioniBindigSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.InterventiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllegatoABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdineServizioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.FlowLayoutPanelEsterno.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbAlegatoADataSet_Unico As OrSe.dbAlegatoADataSet
    Friend WithEvents QAllegatoABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InterventiTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.interventiTableAdapter
    Friend WithEvents InterventiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AllegatoABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CittaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreferenzeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpzioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QAllegatoATableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nrOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents citta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColoreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComunenascitacittaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResidenzaIndirizzoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResidenzacomunecittaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NrOSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResidenzaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllegatoATableAdapter As OrSe.dbAlegatoADataSetTableAdapters.allegatoATableAdapter
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdineServizioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdineServizioTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter
    Friend WithEvents QInterventiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QInterventiTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QInterventiTableAdapter
    Friend WithEvents PreferenzeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComuneTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.comuneTableAdapter
    Friend WithEvents ModelliMezzoTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter
    Friend WithEvents StampaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents informazioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllegatoAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OP85ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StrumentiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CercaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerticalLabel2 As OrSe.verticalLabel
    Friend WithEvents SessioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancellaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CercaAggiornamentiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemLOG As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EseguiBackupDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RipristinaBackupDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QInterventi_informazioniBindigSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iddgvInformazioni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataoraInizioInfo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonRubrica As System.Windows.Forms.Button
    Friend WithEvents menu As System.Windows.Forms.MenuStrip
    Friend WithEvents BtnVedi As System.Windows.Forms.Button
    Friend WithEvents btnSopralluogo As System.Windows.Forms.Button
    Friend WithEvents btnInformazioni As System.Windows.Forms.Button
    Friend WithEvents btnIntervento As System.Windows.Forms.Button
    Friend WithEvents btnAlegatoA As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanelEsterno As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnRubrica As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SopralluogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents labelInfoOS As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
