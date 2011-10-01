<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DInsDatiPreliminari
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim OperatoriLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.OK_Button = New System.Windows.Forms.Button
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TreeViewOS = New System.Windows.Forms.TreeView
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet
        Me.OSMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.OperatoriComboBox = New System.Windows.Forms.ComboBox
        Me.OperatoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QOrdineServizioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdineServizioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdineServizioTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter
        Me.OperatoreTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.operatoreTableAdapter
        Me.QOrdineServizioTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QOrdineServizioTableAdapter
        Me.QAllegatoABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QAllegatoATableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
        Me.QInterventiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QInterventiTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QInterventiTableAdapter
        Me.QSopralluogoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QSopralluogoTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QSopralluogoTableAdapter
        Label2 = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        OperatoriLabel = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperatoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QOrdineServizioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdineServizioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QInterventiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QSopralluogoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(168, 348)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(90, 13)
        Label2.TabIndex = 14
        Label2.Text = "Ordine di servizio:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(32, 348)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(33, 13)
        Label1.TabIndex = 13
        Label1.Text = "Data:"
        '
        'OperatoriLabel
        '
        OperatoriLabel.AutoSize = True
        OperatoriLabel.Location = New System.Drawing.Point(12, 317)
        OperatoriLabel.Name = "OperatoriLabel"
        OperatoriLabel.Size = New System.Drawing.Size(53, 13)
        OperatoriLabel.TabIndex = 11
        OperatoriLabel.Text = "Operatori:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(514, 355)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(3, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 10
        Me.Cancel_Button.Text = "Chiudi"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(76, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 20
        Me.OK_Button.Text = "OK"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.TreeViewOS)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(667, 308)
        Me.FlowLayoutPanel1.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(652, 46)
        Me.Panel1.TabIndex = 8
        '
        'TreeViewOS
        '
        Me.TreeViewOS.Location = New System.Drawing.Point(3, 55)
        Me.TreeViewOS.Name = "TreeViewOS"
        Me.TreeViewOS.Size = New System.Drawing.Size(652, 253)
        Me.TreeViewOS.TabIndex = 41
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DbAlegatoADataSet, "ordineServizio.data", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(71, 344)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker1.TabIndex = 40
        '
        'DbAlegatoADataSet
        '
        Me.DbAlegatoADataSet.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OSMaskedTextBox
        '
        Me.OSMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DbAlegatoADataSet, "ordineServizio.nome", True))
        Me.OSMaskedTextBox.Location = New System.Drawing.Point(264, 345)
        Me.OSMaskedTextBox.Mask = "OS 00/00"
        Me.OSMaskedTextBox.Name = "OSMaskedTextBox"
        Me.OSMaskedTextBox.Size = New System.Drawing.Size(64, 20)
        Me.OSMaskedTextBox.TabIndex = 0
        '
        'OperatoriComboBox
        '
        Me.OperatoriComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.OperatoriComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DbAlegatoADataSet, "ordineServizio.idOperatori", True))
        Me.OperatoriComboBox.DataSource = Me.OperatoreBindingSource
        Me.OperatoriComboBox.DisplayMember = "operatori"
        Me.OperatoriComboBox.FormattingEnabled = True
        Me.OperatoriComboBox.Location = New System.Drawing.Point(69, 314)
        Me.OperatoriComboBox.Name = "OperatoriComboBox"
        Me.OperatoriComboBox.Size = New System.Drawing.Size(587, 21)
        Me.OperatoriComboBox.TabIndex = 30
        Me.OperatoriComboBox.ValueMember = "id"
        '
        'OperatoreBindingSource
        '
        Me.OperatoreBindingSource.DataMember = "operatore"
        Me.OperatoreBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'QOrdineServizioBindingSource
        '
        Me.QOrdineServizioBindingSource.DataMember = "QOrdineServizio"
        Me.QOrdineServizioBindingSource.DataSource = Me.DbAlegatoADataSet
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
        'OperatoreTableAdapter
        '
        Me.OperatoreTableAdapter.ClearBeforeFill = True
        '
        'QOrdineServizioTableAdapter
        '
        Me.QOrdineServizioTableAdapter.ClearBeforeFill = True
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
        'QInterventiBindingSource
        '
        Me.QInterventiBindingSource.DataMember = "QInterventi"
        Me.QInterventiBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'QInterventiTableAdapter
        '
        Me.QInterventiTableAdapter.ClearBeforeFill = True
        '
        'QSopralluogoBindingSource
        '
        Me.QSopralluogoBindingSource.DataMember = "QSopralluogo"
        Me.QSopralluogoBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'QSopralluogoTableAdapter
        '
        Me.QSopralluogoTableAdapter.ClearBeforeFill = True
        '
        'DInsDatiPreliminari
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(667, 396)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.OSMaskedTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(OperatoriLabel)
        Me.Controls.Add(Me.OperatoriComboBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DInsDatiPreliminari"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DInsDatiPreliminariNew"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperatoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QOrdineServizioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdineServizioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QInterventiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QSopralluogoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents OSMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents OperatoriComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents OrdineServizioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdineServizioTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter
    Friend WithEvents OperatoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperatoreTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.operatoreTableAdapter
    Friend WithEvents QOrdineServizioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QOrdineServizioTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QOrdineServizioTableAdapter
    Friend WithEvents TreeViewOS As System.Windows.Forms.TreeView
    Friend WithEvents QAllegatoABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QAllegatoATableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
    Friend WithEvents QInterventiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QInterventiTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QInterventiTableAdapter
    Friend WithEvents QSopralluogoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QSopralluogoTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QSopralluogoTableAdapter

End Class
