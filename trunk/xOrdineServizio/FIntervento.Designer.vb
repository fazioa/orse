<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FIntervento
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FIntervento))
        Me.GroupBoxOraIntervento = New System.Windows.Forms.GroupBox
        Me.DateTimePickerOraInizio = New System.Windows.Forms.DateTimePicker
        Me.InterventiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.LabelOraFine = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxOraFine = New System.Windows.Forms.GroupBox
        Me.DateTimePickerOraFine = New System.Windows.Forms.DateTimePicker
        Me.btnAutoOraFine = New System.Windows.Forms.Button
        Me.tbTipoServizio = New System.Windows.Forms.TextBox
        Me.LabelTipoIntervento = New System.Windows.Forms.Label
        Me.LabelResoconto = New System.Windows.Forms.Label
        Me.tbResoconto = New System.Windows.Forms.TextBox
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.InterventiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.InterventiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.labelOS = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LabelData = New System.Windows.Forms.Label
        Me.InterventiTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.interventiTableAdapter
        Me.OrdineServizioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdineServizioTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBoxOraIntervento.SuspendLayout()
        CType(Me.InterventiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOraFine.SuspendLayout()
        CType(Me.InterventiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InterventiBindingNavigator.SuspendLayout()
        CType(Me.OrdineServizioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxOraIntervento
        '
        Me.GroupBoxOraIntervento.Controls.Add(Me.DateTimePickerOraInizio)
        Me.GroupBoxOraIntervento.Controls.Add(Me.Label1)
        Me.GroupBoxOraIntervento.Location = New System.Drawing.Point(12, 53)
        Me.GroupBoxOraIntervento.Name = "GroupBoxOraIntervento"
        Me.GroupBoxOraIntervento.Size = New System.Drawing.Size(228, 134)
        Me.GroupBoxOraIntervento.TabIndex = 9
        Me.GroupBoxOraIntervento.TabStop = False
        '
        'DateTimePickerOraInizio
        '
        Me.DateTimePickerOraInizio.CausesValidation = False
        Me.DateTimePickerOraInizio.CustomFormat = "HH.mm"
        Me.DateTimePickerOraInizio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InterventiBindingSource, "dataoraInizio", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "G"))
        Me.DateTimePickerOraInizio.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.DateTimePickerOraInizio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerOraInizio.Location = New System.Drawing.Point(12, 50)
        Me.DateTimePickerOraInizio.Name = "DateTimePickerOraInizio"
        Me.DateTimePickerOraInizio.Size = New System.Drawing.Size(144, 49)
        Me.DateTimePickerOraInizio.TabIndex = 24
        '
        'InterventiBindingSource
        '
        Me.InterventiBindingSource.DataMember = "interventi"
        Me.InterventiBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'DbAlegatoADataSet
        '
        Me.DbAlegatoADataSet.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ora"
        '
        'LabelOraFine
        '
        Me.LabelOraFine.AutoSize = True
        Me.LabelOraFine.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOraFine.Location = New System.Drawing.Point(6, 17)
        Me.LabelOraFine.Name = "LabelOraFine"
        Me.LabelOraFine.Size = New System.Drawing.Size(207, 31)
        Me.LabelOraFine.TabIndex = 7
        Me.LabelOraFine.Text = "Fine automatica"
        '
        'Timer1
        '
        '
        'GroupBoxOraFine
        '
        Me.GroupBoxOraFine.Controls.Add(Me.DateTimePickerOraFine)
        Me.GroupBoxOraFine.Controls.Add(Me.LabelOraFine)
        Me.GroupBoxOraFine.Enabled = False
        Me.GroupBoxOraFine.Location = New System.Drawing.Point(246, 53)
        Me.GroupBoxOraFine.Name = "GroupBoxOraFine"
        Me.GroupBoxOraFine.Size = New System.Drawing.Size(228, 134)
        Me.GroupBoxOraFine.TabIndex = 10
        Me.GroupBoxOraFine.TabStop = False
        '
        'DateTimePickerOraFine
        '
        Me.DateTimePickerOraFine.CausesValidation = False
        Me.DateTimePickerOraFine.CustomFormat = "HH.mm"
        Me.DateTimePickerOraFine.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InterventiBindingSource, "dataOraFine", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "G"))
        Me.DateTimePickerOraFine.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!)
        Me.DateTimePickerOraFine.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerOraFine.Location = New System.Drawing.Point(12, 50)
        Me.DateTimePickerOraFine.Name = "DateTimePickerOraFine"
        Me.DateTimePickerOraFine.Size = New System.Drawing.Size(144, 49)
        Me.DateTimePickerOraFine.TabIndex = 25
        '
        'btnAutoOraFine
        '
        Me.btnAutoOraFine.Location = New System.Drawing.Point(440, 53)
        Me.btnAutoOraFine.Name = "btnAutoOraFine"
        Me.btnAutoOraFine.Size = New System.Drawing.Size(75, 23)
        Me.btnAutoOraFine.TabIndex = 11
        Me.btnAutoOraFine.Text = "Manuale"
        Me.btnAutoOraFine.UseVisualStyleBackColor = True
        '
        'tbTipoServizio
        '
        Me.tbTipoServizio.CausesValidation = False
        Me.tbTipoServizio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventiBindingSource, "tipointervento", True))
        Me.tbTipoServizio.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTipoServizio.ForeColor = System.Drawing.Color.YellowGreen
        Me.tbTipoServizio.Location = New System.Drawing.Point(18, 221)
        Me.tbTipoServizio.Name = "tbTipoServizio"
        Me.tbTipoServizio.Size = New System.Drawing.Size(625, 47)
        Me.tbTipoServizio.TabIndex = 1
        '
        'LabelTipoIntervento
        '
        Me.LabelTipoIntervento.AutoSize = True
        Me.LabelTipoIntervento.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTipoIntervento.Location = New System.Drawing.Point(12, 187)
        Me.LabelTipoIntervento.Name = "LabelTipoIntervento"
        Me.LabelTipoIntervento.Size = New System.Drawing.Size(196, 31)
        Me.LabelTipoIntervento.TabIndex = 7
        Me.LabelTipoIntervento.Text = "Tipo Intervento"
        '
        'LabelResoconto
        '
        Me.LabelResoconto.AutoSize = True
        Me.LabelResoconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelResoconto.Location = New System.Drawing.Point(12, 271)
        Me.LabelResoconto.Name = "LabelResoconto"
        Me.LabelResoconto.Size = New System.Drawing.Size(145, 31)
        Me.LabelResoconto.TabIndex = 13
        Me.LabelResoconto.Text = "Resoconto"
        '
        'tbResoconto
        '
        Me.tbResoconto.CausesValidation = False
        Me.tbResoconto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InterventiBindingSource, "resoconto", True))
        Me.tbResoconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResoconto.Location = New System.Drawing.Point(18, 305)
        Me.tbResoconto.Multiline = True
        Me.tbResoconto.Name = "tbResoconto"
        Me.tbResoconto.Size = New System.Drawing.Size(672, 210)
        Me.tbResoconto.TabIndex = 2
        '
        'btnChiudi
        '
        Me.btnChiudi.CausesValidation = False
        Me.btnChiudi.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChiudi.Location = New System.Drawing.Point(696, 402)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(199, 109)
        Me.btnChiudi.TabIndex = 4
        Me.btnChiudi.Text = "&Salva e Chiudi"
        Me.btnChiudi.UseVisualStyleBackColor = True
        '
        'InterventiBindingNavigator
        '
        Me.InterventiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InterventiBindingNavigator.BindingSource = Me.InterventiBindingSource
        Me.InterventiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InterventiBindingNavigator.DeleteItem = Me.BindingNavigatorMoveLastItem
        Me.InterventiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InterventiBindingNavigatorSaveItem})
        Me.InterventiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InterventiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InterventiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InterventiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InterventiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InterventiBindingNavigator.Name = "InterventiBindingNavigator"
        Me.InterventiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InterventiBindingNavigator.Size = New System.Drawing.Size(1134, 25)
        Me.InterventiBindingNavigator.TabIndex = 17
        Me.InterventiBindingNavigator.Text = "BindingNavigator1"
        Me.InterventiBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Aggiungi nuovo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Sposta indietro"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Sposta avanti"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Elimina"
        '
        'InterventiBindingNavigatorSaveItem
        '
        Me.InterventiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InterventiBindingNavigatorSaveItem.Image = CType(resources.GetObject("InterventiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InterventiBindingNavigatorSaveItem.Name = "InterventiBindingNavigatorSaveItem"
        Me.InterventiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InterventiBindingNavigatorSaveItem.Text = "Salva dati"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Ordine di Servizio"
        '
        'labelOS
        '
        Me.labelOS.AutoSize = True
        Me.labelOS.CausesValidation = False
        Me.labelOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelOS.Location = New System.Drawing.Point(172, 26)
        Me.labelOS.Name = "labelOS"
        Me.labelOS.Size = New System.Drawing.Size(77, 24)
        Me.labelOS.TabIndex = 20
        Me.labelOS.Text = "labelOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 24)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "del"
        '
        'LabelData
        '
        Me.LabelData.AutoSize = True
        Me.LabelData.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelData.Location = New System.Drawing.Point(300, 26)
        Me.LabelData.Name = "LabelData"
        Me.LabelData.Size = New System.Drawing.Size(93, 24)
        Me.LabelData.TabIndex = 21
        Me.LabelData.Text = "LabelData"
        '
        'InterventiTableAdapter
        '
        Me.InterventiTableAdapter.ClearBeforeFill = True
        '
        'OrdineServizioBindingSource
        '
        Me.OrdineServizioBindingSource.DataMember = "ordineServizio"
        Me.OrdineServizioBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'OrdineServizioTableAdapter
        '
        Me.OrdineServizioTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.CausesValidation = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(696, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 56)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "&Chiudi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FIntervento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 567)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelData)
        Me.Controls.Add(Me.labelOS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAutoOraFine)
        Me.Controls.Add(Me.InterventiBindingNavigator)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.LabelResoconto)
        Me.Controls.Add(Me.tbResoconto)
        Me.Controls.Add(Me.LabelTipoIntervento)
        Me.Controls.Add(Me.tbTipoServizio)
        Me.Controls.Add(Me.GroupBoxOraFine)
        Me.Controls.Add(Me.GroupBoxOraIntervento)
        Me.Name = "FIntervento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FIntervento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxOraIntervento.ResumeLayout(False)
        Me.GroupBoxOraIntervento.PerformLayout()
        CType(Me.InterventiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOraFine.ResumeLayout(False)
        Me.GroupBoxOraFine.PerformLayout()
        CType(Me.InterventiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InterventiBindingNavigator.ResumeLayout(False)
        Me.InterventiBindingNavigator.PerformLayout()
        CType(Me.OrdineServizioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxOraIntervento As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelOraFine As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBoxOraFine As System.Windows.Forms.GroupBox
    Friend WithEvents btnAutoOraFine As System.Windows.Forms.Button
    Friend WithEvents tbTipoServizio As System.Windows.Forms.TextBox
    Friend WithEvents LabelTipoIntervento As System.Windows.Forms.Label
    Friend WithEvents LabelResoconto As System.Windows.Forms.Label
    Friend WithEvents tbResoconto As System.Windows.Forms.TextBox
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents InterventiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InterventiTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.interventiTableAdapter
    Friend WithEvents InterventiBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InterventiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents labelOS As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelData As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerOraInizio As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerOraFine As System.Windows.Forms.DateTimePicker
    Friend WithEvents OrdineServizioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdineServizioTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
