<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSopralluogoAnnotazioneListaStampa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSopralluogoAnnotazioneListaStampa))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet()
        Me.SopralluogoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SopralluogoTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.sopralluogoTableAdapter()
        Me.SopralluogoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idSopralluogo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.InterventiDataGridView = New System.Windows.Forms.DataGridView()
        Me.idIntervento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterventiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InterventiTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.interventiTableAdapter()
        Me.TableAdapterManager = New OrSe.dbAlegatoADataSetTableAdapters.TableAdapterManager()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SopralluogoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SopralluogoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.InterventiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InterventiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(791, 259)
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
        'DbAlegatoADataSet
        '
        Me.DbAlegatoADataSet.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SopralluogoBindingSource
        '
        Me.SopralluogoBindingSource.DataMember = "sopralluogo"
        Me.SopralluogoBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'SopralluogoTableAdapter
        '
        Me.SopralluogoTableAdapter.ClearBeforeFill = True
        '
        'SopralluogoDataGridView
        '
        Me.SopralluogoDataGridView.AllowUserToAddRows = False
        Me.SopralluogoDataGridView.AllowUserToDeleteRows = False
        Me.SopralluogoDataGridView.AutoGenerateColumns = False
        Me.SopralluogoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.idSopralluogo})
        Me.SopralluogoDataGridView.DataSource = Me.SopralluogoBindingSource
        Me.SopralluogoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SopralluogoDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SopralluogoDataGridView.Name = "SopralluogoDataGridView"
        Me.SopralluogoDataGridView.Size = New System.Drawing.Size(935, 219)
        Me.SopralluogoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tipoReato"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo reato"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "oraRichiesta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ora richiesta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 5
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "oraRedazione"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ora verbale"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 5
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "luogo_citta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Luogo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "via"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Via"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "contatti_con"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Contatti"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "resoconto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Resoconto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'idSopralluogo
        '
        Me.idSopralluogo.DataPropertyName = "idSopralluogo"
        Me.idSopralluogo.HeaderText = "idSopralluogo"
        Me.idSopralluogo.Name = "idSopralluogo"
        Me.idSopralluogo.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(949, 251)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SopralluogoDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(941, 225)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sopralluogo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.InterventiDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(941, 225)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Annotazione"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'InterventiDataGridView
        '
        Me.InterventiDataGridView.AllowUserToAddRows = False
        Me.InterventiDataGridView.AllowUserToDeleteRows = False
        Me.InterventiDataGridView.AutoGenerateColumns = False
        Me.InterventiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InterventiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idIntervento, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.InterventiDataGridView.DataSource = Me.InterventiBindingSource
        Me.InterventiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InterventiDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.InterventiDataGridView.Name = "InterventiDataGridView"
        Me.InterventiDataGridView.Size = New System.Drawing.Size(935, 219)
        Me.InterventiDataGridView.TabIndex = 0
        '
        'idIntervento
        '
        Me.idIntervento.DataPropertyName = "id"
        Me.idIntervento.HeaderText = "id"
        Me.idIntervento.Name = "idIntervento"
        Me.idIntervento.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "dataOraInizio"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ora Inizio"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "dataOraFine"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Ora Fine"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "tipointervento"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Tipo Intervento"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "resoconto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Resoconto"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "idOrdineservizio"
        Me.DataGridViewTextBoxColumn13.HeaderText = "idOrdineservizio"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "iParagrafo"
        Me.DataGridViewTextBoxColumn14.HeaderText = "iParagrafo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'InterventiBindingSource
        '
        Me.InterventiBindingSource.DataMember = "interventi"
        Me.InterventiBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'InterventiTableAdapter
        '
        Me.InterventiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.allegatoATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.comuneTableAdapter = Nothing
        Me.TableAdapterManager.controlloTableAdapter = Nothing
        Me.TableAdapterManager.interventiTableAdapter = Me.InterventiTableAdapter
        Me.TableAdapterManager.luoghicontrolloTableAdapter = Nothing
        Me.TableAdapterManager.modelliMezzoTableAdapter = Nothing
        Me.TableAdapterManager.operatoreTableAdapter = Nothing
        Me.TableAdapterManager.ordineServizioTableAdapter = Nothing
        Me.TableAdapterManager.personaTableAdapter = Nothing
        Me.TableAdapterManager.prioritaComuneTableAdapter = Nothing
        Me.TableAdapterManager.rubricaTableAdapter = Nothing
        Me.TableAdapterManager.sopralluogoTableAdapter = Me.SopralluogoTableAdapter
        Me.TableAdapterManager.UpdateOrder = OrSe.dbAlegatoADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.versioneTableAdapter = Nothing
        '
        'FSopralluogoAnnotazioneListaStampa
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(949, 300)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FSopralluogoAnnotazioneListaStampa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sopralluoghi / Annotazioni"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SopralluogoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SopralluogoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.InterventiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InterventiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents SopralluogoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SopralluogoTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.sopralluogoTableAdapter
    Friend WithEvents SopralluogoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents InterventiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InterventiTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.interventiTableAdapter
    Friend WithEvents TableAdapterManager As OrSe.dbAlegatoADataSetTableAdapters.TableAdapterManager
    Friend WithEvents InterventiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idSopralluogo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idIntervento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
