<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FElencosoggetti
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCognome = New System.Windows.Forms.TextBox()
        Me.QPersonaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QPersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet()
        Me.gbFiltri = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.rTutti = New System.Windows.Forms.RadioButton()
        Me.rIO = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.bntAnnulla = New System.Windows.Forms.Button()
        Me.QPersonaTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QPersonaTableAdapter()
        CType(Me.QPersonaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QPersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltri.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbNome
        '
        Me.tbNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.tbNome.Location = New System.Drawing.Point(264, 41)
        Me.tbNome.Name = "tbNome"
        Me.tbNome.Size = New System.Drawing.Size(241, 45)
        Me.tbNome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(259, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cognome"
        '
        'tbCognome
        '
        Me.tbCognome.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.tbCognome.Location = New System.Drawing.Point(17, 41)
        Me.tbCognome.Name = "tbCognome"
        Me.tbCognome.Size = New System.Drawing.Size(241, 45)
        Me.tbCognome.TabIndex = 0
        '
        'QPersonaDataGridView
        '
        Me.QPersonaDataGridView.AllowUserToAddRows = False
        Me.QPersonaDataGridView.AllowUserToDeleteRows = False
        Me.QPersonaDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QPersonaDataGridView.AutoGenerateColumns = False
        Me.QPersonaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.ID, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn12})
        Me.QPersonaDataGridView.DataSource = Me.QPersonaBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.QPersonaDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.QPersonaDataGridView.Location = New System.Drawing.Point(3, 58)
        Me.QPersonaDataGridView.MultiSelect = False
        Me.QPersonaDataGridView.Name = "QPersonaDataGridView"
        Me.QPersonaDataGridView.ReadOnly = True
        Me.QPersonaDataGridView.RowTemplate.Height = 32
        Me.QPersonaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.QPersonaDataGridView.Size = New System.Drawing.Size(1019, 311)
        Me.QPersonaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cognome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cognome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 76
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nome"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 58
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "datanascita"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.HeaderText = "datanascita"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 87
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cittanascita"
        Me.DataGridViewTextBoxColumn6.HeaderText = "cittanascita"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 86
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "precedenti"
        Me.DataGridViewTextBoxColumn12.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "precedenti"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'QPersonaBindingSource
        '
        Me.QPersonaBindingSource.DataMember = "QPersona"
        Me.QPersonaBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'DbAlegatoADataSet
        '
        Me.DbAlegatoADataSet.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbFiltri
        '
        Me.gbFiltri.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbFiltri.Controls.Add(Me.FlowLayoutPanel1)
        Me.gbFiltri.Location = New System.Drawing.Point(3, 3)
        Me.gbFiltri.Name = "gbFiltri"
        Me.gbFiltri.Size = New System.Drawing.Size(179, 49)
        Me.gbFiltri.TabIndex = 2
        Me.gbFiltri.TabStop = False
        Me.gbFiltri.Text = "Filtri"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.rTutti)
        Me.FlowLayoutPanel1.Controls.Add(Me.rIO)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(173, 30)
        Me.FlowLayoutPanel1.TabIndex = 21
        '
        'rTutti
        '
        Me.rTutti.Appearance = System.Windows.Forms.Appearance.Button
        Me.rTutti.AutoSize = True
        Me.rTutti.Checked = True
        Me.rTutti.Location = New System.Drawing.Point(3, 3)
        Me.rTutti.Name = "rTutti"
        Me.rTutti.Size = New System.Drawing.Size(38, 23)
        Me.rTutti.TabIndex = 0
        Me.rTutti.TabStop = True
        Me.rTutti.Text = "Tutti"
        Me.rTutti.UseVisualStyleBackColor = True
        '
        'rIO
        '
        Me.rIO.Appearance = System.Windows.Forms.Appearance.Button
        Me.rIO.AutoSize = True
        Me.rIO.Location = New System.Drawing.Point(47, 3)
        Me.rIO.Name = "rIO"
        Me.rIO.Size = New System.Drawing.Size(109, 23)
        Me.rIO.TabIndex = 1
        Me.rIO.Text = "Interesse Operativo"
        Me.rIO.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.Controls.Add(Me.gbFiltri)
        Me.FlowLayoutPanel2.Controls.Add(Me.QPersonaDataGridView)
        Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel3)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 92)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1022, 444)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnAdd)
        Me.FlowLayoutPanel3.Controls.Add(Me.bntAnnulla)
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 375)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(1019, 59)
        Me.FlowLayoutPanel3.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnAdd.Location = New System.Drawing.Point(812, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(204, 52)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Aggiungi selezionato"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'bntAnnulla
        '
        Me.bntAnnulla.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.bntAnnulla.Location = New System.Drawing.Point(602, 3)
        Me.bntAnnulla.Name = "bntAnnulla"
        Me.bntAnnulla.Size = New System.Drawing.Size(204, 52)
        Me.bntAnnulla.TabIndex = 9
        Me.bntAnnulla.Text = "Annulla"
        Me.bntAnnulla.UseVisualStyleBackColor = True
        '
        'QPersonaTableAdapter
        '
        Me.QPersonaTableAdapter.ClearBeforeFill = True
        '
        'FElencosoggetti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1034, 548)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCognome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbNome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FElencosoggetti"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Persone di interesso operativo"
        CType(Me.QPersonaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QPersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltri.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbNome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbCognome As System.Windows.Forms.TextBox
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents QPersonaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QPersonaTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QPersonaTableAdapter
    Friend WithEvents QPersonaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents gbFiltri As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents rTutti As System.Windows.Forms.RadioButton
    Friend WithEvents rIO As System.Windows.Forms.RadioButton
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents bntAnnulla As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
