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
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.RevisioneTabelleDatiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SessioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferenzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpzioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.labelInfoOS = New System.Windows.Forms.Label()
        Me.ButtonRubrica = New System.Windows.Forms.Button()
        Me.barramenu = New System.Windows.Forms.MenuStrip()
        Me.BtnVedi = New System.Windows.Forms.Button()
        Me.btnSopralluogo = New System.Windows.Forms.Button()
        Me.btnInformazioni = New System.Windows.Forms.Button()
        Me.btnIntervento = New System.Windows.Forms.Button()
        Me.btnAlegatoA = New System.Windows.Forms.Button()
        Me.FlowLayoutPanelEsterno = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnRubrica = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.QAllegatoABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QInterventiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QInterventi_informazioniBindigSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InterventiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllegatoABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdineServizioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdineServizioTableAdapter1 = New OrSe.dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter()
        Me.DbAlegatoADataSet1 = New OrSe.dbAlegatoADataSet()
        Me.VerticalLabel2 = New OrSe.verticalLabel()
        Me.RevisioneTabelleComuniEStariiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.barramenu.SuspendLayout()
        Me.FlowLayoutPanelEsterno.SuspendLayout()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QInterventiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QInterventi_informazioniBindigSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InterventiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllegatoABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdineServizioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbAlegatoADataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PreferenzeToolStripMenuItem1
        '
        Me.PreferenzeToolStripMenuItem1.Name = "PreferenzeToolStripMenuItem1"
        resources.ApplyResources(Me.PreferenzeToolStripMenuItem1, "PreferenzeToolStripMenuItem1")
        '
        'StampaToolStripMenuItem
        '
        Me.StampaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.informazioniToolStripMenuItem, Me.AllegatoAToolStripMenuItem, Me.OP85ToolStripMenuItem, Me.SopralluogoToolStripMenuItem})
        Me.StampaToolStripMenuItem.Name = "StampaToolStripMenuItem"
        resources.ApplyResources(Me.StampaToolStripMenuItem, "StampaToolStripMenuItem")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.OrSe.My.Resources.Resources.printInterventi
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'informazioniToolStripMenuItem
        '
        Me.informazioniToolStripMenuItem.Image = Global.OrSe.My.Resources.Resources.printInterventi
        Me.informazioniToolStripMenuItem.Name = "informazioniToolStripMenuItem"
        resources.ApplyResources(Me.informazioniToolStripMenuItem, "informazioniToolStripMenuItem")
        '
        'AllegatoAToolStripMenuItem
        '
        Me.AllegatoAToolStripMenuItem.Image = Global.OrSe.My.Resources.Resources.printAllegatoA
        Me.AllegatoAToolStripMenuItem.Name = "AllegatoAToolStripMenuItem"
        resources.ApplyResources(Me.AllegatoAToolStripMenuItem, "AllegatoAToolStripMenuItem")
        '
        'OP85ToolStripMenuItem
        '
        Me.OP85ToolStripMenuItem.Image = Global.OrSe.My.Resources.Resources.printOP85
        Me.OP85ToolStripMenuItem.Name = "OP85ToolStripMenuItem"
        resources.ApplyResources(Me.OP85ToolStripMenuItem, "OP85ToolStripMenuItem")
        '
        'SopralluogoToolStripMenuItem
        '
        Me.SopralluogoToolStripMenuItem.Image = Global.OrSe.My.Resources.Resources.printOP85
        Me.SopralluogoToolStripMenuItem.Name = "SopralluogoToolStripMenuItem"
        resources.ApplyResources(Me.SopralluogoToolStripMenuItem, "SopralluogoToolStripMenuItem")
        '
        'StrumentiToolStripMenuItem
        '
        Me.StrumentiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CercaToolStripMenuItem, Me.ToolStripSeparator2, Me.ExportToolStripMenuItem, Me.ImportToolStripMenuItem, Me.ToolStripSeparator3, Me.CancellaToolStripMenuItem, Me.CercaAggiornamentiToolStripMenuItem, Me.ToolStripMenuItemLOG, Me.ToolStripSeparator1, Me.EseguiBackupDBToolStripMenuItem, Me.RipristinaBackupDBToolStripMenuItem, Me.ToolStripSeparator4, Me.RevisioneTabelleDatiToolStripMenuItem, Me.RevisioneTabelleComuniEStariiToolStripMenuItem})
        Me.StrumentiToolStripMenuItem.Name = "StrumentiToolStripMenuItem"
        resources.ApplyResources(Me.StrumentiToolStripMenuItem, "StrumentiToolStripMenuItem")
        '
        'CercaToolStripMenuItem
        '
        Me.CercaToolStripMenuItem.Image = Global.OrSe.My.Resources.Resources.DBFind
        Me.CercaToolStripMenuItem.Name = "CercaToolStripMenuItem"
        resources.ApplyResources(Me.CercaToolStripMenuItem, "CercaToolStripMenuItem")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        resources.ApplyResources(Me.ExportToolStripMenuItem, "ExportToolStripMenuItem")
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        resources.ApplyResources(Me.ImportToolStripMenuItem, "ImportToolStripMenuItem")
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'CancellaToolStripMenuItem
        '
        Me.CancellaToolStripMenuItem.Name = "CancellaToolStripMenuItem"
        resources.ApplyResources(Me.CancellaToolStripMenuItem, "CancellaToolStripMenuItem")
        '
        'CercaAggiornamentiToolStripMenuItem
        '
        Me.CercaAggiornamentiToolStripMenuItem.Name = "CercaAggiornamentiToolStripMenuItem"
        resources.ApplyResources(Me.CercaAggiornamentiToolStripMenuItem, "CercaAggiornamentiToolStripMenuItem")
        '
        'ToolStripMenuItemLOG
        '
        Me.ToolStripMenuItemLOG.CheckOnClick = True
        Me.ToolStripMenuItemLOG.Name = "ToolStripMenuItemLOG"
        resources.ApplyResources(Me.ToolStripMenuItemLOG, "ToolStripMenuItemLOG")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'EseguiBackupDBToolStripMenuItem
        '
        Me.EseguiBackupDBToolStripMenuItem.Name = "EseguiBackupDBToolStripMenuItem"
        resources.ApplyResources(Me.EseguiBackupDBToolStripMenuItem, "EseguiBackupDBToolStripMenuItem")
        '
        'RipristinaBackupDBToolStripMenuItem
        '
        Me.RipristinaBackupDBToolStripMenuItem.Name = "RipristinaBackupDBToolStripMenuItem"
        resources.ApplyResources(Me.RipristinaBackupDBToolStripMenuItem, "RipristinaBackupDBToolStripMenuItem")
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'RevisioneTabelleDatiToolStripMenuItem
        '
        Me.RevisioneTabelleDatiToolStripMenuItem.Name = "RevisioneTabelleDatiToolStripMenuItem"
        resources.ApplyResources(Me.RevisioneTabelleDatiToolStripMenuItem, "RevisioneTabelleDatiToolStripMenuItem")
        '
        'SessioneToolStripMenuItem
        '
        Me.SessioneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem1})
        Me.SessioneToolStripMenuItem.Name = "SessioneToolStripMenuItem"
        resources.ApplyResources(Me.SessioneToolStripMenuItem, "SessioneToolStripMenuItem")
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        resources.ApplyResources(Me.LogoutToolStripMenuItem1, "LogoutToolStripMenuItem1")
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersioneToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        '
        'VersioneToolStripMenuItem
        '
        Me.VersioneToolStripMenuItem.Name = "VersioneToolStripMenuItem"
        resources.ApplyResources(Me.VersioneToolStripMenuItem, "VersioneToolStripMenuItem")
        '
        'PreferenzeToolStripMenuItem
        '
        Me.PreferenzeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpzioniToolStripMenuItem})
        Me.PreferenzeToolStripMenuItem.Name = "PreferenzeToolStripMenuItem"
        resources.ApplyResources(Me.PreferenzeToolStripMenuItem, "PreferenzeToolStripMenuItem")
        '
        'OpzioniToolStripMenuItem
        '
        Me.OpzioniToolStripMenuItem.Name = "OpzioniToolStripMenuItem"
        resources.ApplyResources(Me.OpzioniToolStripMenuItem, "OpzioniToolStripMenuItem")
        '
        'FlowLayoutPanel2
        '
        resources.ApplyResources(Me.FlowLayoutPanel2, "FlowLayoutPanel2")
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        '
        'FlowLayoutPanel1
        '
        resources.ApplyResources(Me.FlowLayoutPanel1, "FlowLayoutPanel1")
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        '
        'TableLayoutPanel2
        '
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.labelInfoOS)
        resources.ApplyResources(Me.FlowLayoutPanel3, "FlowLayoutPanel3")
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        '
        'labelInfoOS
        '
        resources.ApplyResources(Me.labelInfoOS, "labelInfoOS")
        Me.labelInfoOS.Name = "labelInfoOS"
        '
        'ButtonRubrica
        '
        resources.ApplyResources(Me.ButtonRubrica, "ButtonRubrica")
        Me.ButtonRubrica.Name = "ButtonRubrica"
        Me.ButtonRubrica.UseCompatibleTextRendering = True
        Me.ButtonRubrica.UseVisualStyleBackColor = True
        '
        'barramenu
        '
        Me.barramenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.barramenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferenzeToolStripMenuItem1, Me.StampaToolStripMenuItem, Me.StrumentiToolStripMenuItem, Me.SessioneToolStripMenuItem, Me.HelpToolStripMenuItem})
        resources.ApplyResources(Me.barramenu, "barramenu")
        Me.barramenu.Name = "barramenu"
        '
        'BtnVedi
        '
        Me.BtnVedi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnVedi.FlatAppearance.BorderSize = 3
        resources.ApplyResources(Me.BtnVedi, "BtnVedi")
        Me.BtnVedi.Name = "BtnVedi"
        Me.BtnVedi.UseVisualStyleBackColor = True
        '
        'btnSopralluogo
        '
        resources.ApplyResources(Me.btnSopralluogo, "btnSopralluogo")
        Me.btnSopralluogo.Image = Global.OrSe.My.Resources.Resources.pulsanteSoleGrigio
        Me.btnSopralluogo.Name = "btnSopralluogo"
        Me.btnSopralluogo.UseCompatibleTextRendering = True
        Me.btnSopralluogo.UseVisualStyleBackColor = True
        '
        'btnInformazioni
        '
        resources.ApplyResources(Me.btnInformazioni, "btnInformazioni")
        Me.btnInformazioni.Image = Global.OrSe.My.Resources.Resources.pulsanteSoleVerde
        Me.btnInformazioni.Name = "btnInformazioni"
        Me.btnInformazioni.UseCompatibleTextRendering = True
        Me.btnInformazioni.UseVisualStyleBackColor = True
        '
        'btnIntervento
        '
        resources.ApplyResources(Me.btnIntervento, "btnIntervento")
        Me.btnIntervento.Image = Global.OrSe.My.Resources.Resources.db_addVerde
        Me.btnIntervento.Name = "btnIntervento"
        Me.btnIntervento.UseCompatibleTextRendering = True
        Me.btnIntervento.UseVisualStyleBackColor = True
        '
        'btnAlegatoA
        '
        resources.ApplyResources(Me.btnAlegatoA, "btnAlegatoA")
        Me.btnAlegatoA.Image = Global.OrSe.My.Resources.Resources.db_addBlu
        Me.btnAlegatoA.Name = "btnAlegatoA"
        Me.btnAlegatoA.UseCompatibleTextRendering = True
        Me.btnAlegatoA.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelEsterno
        '
        resources.ApplyResources(Me.FlowLayoutPanelEsterno, "FlowLayoutPanelEsterno")
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.btnAlegatoA)
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.btnIntervento)
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.btnInformazioni)
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.btnSopralluogo)
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.btnRubrica)
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.BtnVedi)
        Me.FlowLayoutPanelEsterno.Controls.Add(Me.Button1)
        Me.FlowLayoutPanelEsterno.Name = "FlowLayoutPanelEsterno"
        '
        'btnRubrica
        '
        resources.ApplyResources(Me.btnRubrica, "btnRubrica")
        Me.btnRubrica.Name = "btnRubrica"
        Me.btnRubrica.UseCompatibleTextRendering = True
        Me.btnRubrica.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Image = Global.OrSe.My.Resources.Resources.DBFind
        Me.Button1.Name = "Button1"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 90000
        '
        'QAllegatoABindingSource
        '
        Me.QAllegatoABindingSource.DataMember = "QAllegatoA"
        '
        'QInterventiBindingSource
        '
        Me.QInterventiBindingSource.DataMember = "QInterventi"
        Me.QInterventiBindingSource.Filter = ""
        '
        'QInterventi_informazioniBindigSource
        '
        Me.QInterventi_informazioniBindigSource.DataMember = "QInterventi"
        Me.QInterventi_informazioniBindigSource.Filter = ""
        '
        'InterventiBindingSource
        '
        Me.InterventiBindingSource.DataMember = "interventi"
        '
        'AllegatoABindingSource
        '
        Me.AllegatoABindingSource.DataMember = "allegatoA"
        '
        'OrdineServizioBindingSource
        '
        Me.OrdineServizioBindingSource.DataMember = "ordineServizio"
        '
        'OrdineServizioTableAdapter1
        '
        Me.OrdineServizioTableAdapter1.ClearBeforeFill = True
        '
        'DbAlegatoADataSet1
        '
        Me.DbAlegatoADataSet1.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VerticalLabel2
        '
        resources.ApplyResources(Me.VerticalLabel2, "VerticalLabel2")
        Me.VerticalLabel2.Name = "VerticalLabel2"
        '
        'RevisioneTabelleComuniEStariiToolStripMenuItem
        '
        Me.RevisioneTabelleComuniEStariiToolStripMenuItem.Name = "RevisioneTabelleComuniEStariiToolStripMenuItem"
        resources.ApplyResources(Me.RevisioneTabelleComuniEStariiToolStripMenuItem, "RevisioneTabelleComuniEStariiToolStripMenuItem")
        '
        'FPrima
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanelEsterno)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.barramenu)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.barramenu
        Me.Name = "FPrima"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.barramenu.ResumeLayout(False)
        Me.barramenu.PerformLayout()
        Me.FlowLayoutPanelEsterno.ResumeLayout(False)
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QInterventiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QInterventi_informazioniBindigSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InterventiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllegatoABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdineServizioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbAlegatoADataSet1, System.ComponentModel.ISupportInitialize).EndInit()
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
    ' Friend WithEvents OrdineServizioTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter
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
    Friend WithEvents barramenu As System.Windows.Forms.MenuStrip
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
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RevisioneTabelleDatiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdineServizioTableAdapter1 As OrSe.dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter
    Friend WithEvents DbAlegatoADataSet1 As OrSe.dbAlegatoADataSet
    Friend WithEvents RevisioneTabelleComuniEStariiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
