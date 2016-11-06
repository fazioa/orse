<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FModificaDatiOS
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim IdOperatoriLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FModificaDatiOS))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet()
        Me.OrdineServizioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdineServizioTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OperatoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperatoreTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.operatoreTableAdapter()
        Me.OperatoriComboBox = New System.Windows.Forms.ComboBox()
        Me.OSMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        NomeLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        IdOperatoriLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdineServizioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperatoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(7, 15)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 4
        NomeLabel.Text = "Nome:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(7, 42)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 6
        DataLabel.Text = "Data:"
        '
        'IdOperatoriLabel
        '
        IdOperatoriLabel.AutoSize = True
        IdOperatoriLabel.Location = New System.Drawing.Point(7, 67)
        IdOperatoriLabel.Name = "IdOperatoriLabel"
        IdOperatoriLabel.Size = New System.Drawing.Size(53, 13)
        IdOperatoriLabel.TabIndex = 8
        IdOperatoriLabel.Text = "Operatori:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(348, 98)
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
        'OrdineServizioBindingSource
        '
        Me.OrdineServizioBindingSource.AllowNew = False
        Me.OrdineServizioBindingSource.DataMember = "ordineServizio"
        Me.OrdineServizioBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'OrdineServizioTableAdapter
        '
        Me.OrdineServizioTableAdapter.ClearBeforeFill = True
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdineServizioBindingSource, "data", True))
        Me.DataDateTimePicker.Location = New System.Drawing.Point(77, 38)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DataDateTimePicker.TabIndex = 7
        '
        'OperatoreBindingSource
        '
        Me.OperatoreBindingSource.AllowNew = False
        Me.OperatoreBindingSource.DataMember = "operatore"
        Me.OperatoreBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'OperatoreTableAdapter
        '
        Me.OperatoreTableAdapter.ClearBeforeFill = True
        '
        'OperatoriComboBox
        '
        Me.OperatoriComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.OperatoriComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DbAlegatoADataSet, "ordineServizio.idOperatori", True))
        Me.OperatoriComboBox.DataSource = Me.OperatoreBindingSource
        Me.OperatoriComboBox.DisplayMember = "operatori"
        Me.OperatoriComboBox.FormattingEnabled = True
        Me.OperatoriComboBox.Location = New System.Drawing.Point(77, 64)
        Me.OperatoriComboBox.Name = "OperatoriComboBox"
        Me.OperatoriComboBox.Size = New System.Drawing.Size(418, 21)
        Me.OperatoriComboBox.TabIndex = 31
        Me.OperatoriComboBox.ValueMember = "id"
        '
        'OSMaskedTextBox
        '
        Me.OSMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DbAlegatoADataSet, "ordineServizio.nome", True))
        Me.OSMaskedTextBox.Location = New System.Drawing.Point(77, 12)
        Me.OSMaskedTextBox.Name = "OSMaskedTextBox"
        Me.OSMaskedTextBox.Size = New System.Drawing.Size(64, 20)
        Me.OSMaskedTextBox.TabIndex = 32
        '
        'FModificaDatiOS
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(506, 139)
        Me.Controls.Add(Me.OSMaskedTextBox)
        Me.Controls.Add(Me.OperatoriComboBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Controls.Add(IdOperatoriLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FModificaDatiOS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FModificaDatiOS"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdineServizioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperatoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents OrdineServizioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdineServizioTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter
    Friend WithEvents DataDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OperatoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperatoreTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.operatoreTableAdapter
    Friend WithEvents OperatoriComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OSMaskedTextBox As System.Windows.Forms.MaskedTextBox

End Class
