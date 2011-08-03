<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DInserimentoLuogoControllo
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
        Me.components = New System.ComponentModel.Container
        Dim Label3 As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.OK_Button = New System.Windows.Forms.Button
        Me.LabelPostoControllo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ControlloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet
        Me.LuoghicontrolloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LuoghicontrolloTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.luoghicontrolloTableAdapter
        Me.ControlloTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.controlloTableAdapter
        Me.DateTimePickerOra = New System.Windows.Forms.DateTimePicker
        Me.cbLuogoControllo = New OrSe.UserControlComboBox
        Label3 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ControlloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LuoghicontrolloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Label3.Location = New System.Drawing.Point(20, 58)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(59, 29)
        Label3.TabIndex = 9
        Label3.Text = "Ora:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(711, 165)
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
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 6
        Me.Cancel_Button.Text = "Annulla"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 4
        Me.OK_Button.Text = "OK"
        '
        'LabelPostoControllo
        '
        Me.LabelPostoControllo.AutoSize = True
        Me.LabelPostoControllo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPostoControllo.Location = New System.Drawing.Point(5, 9)
        Me.LabelPostoControllo.Name = "LabelPostoControllo"
        Me.LabelPostoControllo.Size = New System.Drawing.Size(271, 37)
        Me.LabelPostoControllo.TabIndex = 0
        Me.LabelPostoControllo.Text = "Posto di Controllo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Località:"
        '
        'ControlloBindingSource
        '
        Me.ControlloBindingSource.DataMember = "controllo"
        Me.ControlloBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'DbAlegatoADataSet
        '
        Me.DbAlegatoADataSet.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LuoghicontrolloBindingSource
        '
        Me.LuoghicontrolloBindingSource.DataMember = "luoghicontrollo"
        Me.LuoghicontrolloBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'LuoghicontrolloTableAdapter
        '
        Me.LuoghicontrolloTableAdapter.ClearBeforeFill = True
        '
        'ControlloTableAdapter
        '
        Me.ControlloTableAdapter.ClearBeforeFill = True
        '
        'DateTimePickerOra
        '
        Me.DateTimePickerOra.CustomFormat = "HH.mm"
        Me.DateTimePickerOra.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!)
        Me.DateTimePickerOra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerOra.Location = New System.Drawing.Point(119, 52)
        Me.DateTimePickerOra.Name = "DateTimePickerOra"
        Me.DateTimePickerOra.Size = New System.Drawing.Size(101, 39)
        Me.DateTimePickerOra.TabIndex = 10
        '
        'cbLuogoControllo
        '
        Me.cbLuogoControllo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLuogoControllo.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.cbLuogoControllo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cbLuogoControllo.CausesValidation = False
        Me.cbLuogoControllo.Location = New System.Drawing.Point(119, 97)
        Me.cbLuogoControllo.Name = "cbLuogoControllo"
        Me.cbLuogoControllo.Size = New System.Drawing.Size(735, 46)
        Me.cbLuogoControllo.TabIndex = 0
        '
        'DInserimentoLuogoControllo
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(869, 206)
        Me.Controls.Add(Me.cbLuogoControllo)
        Me.Controls.Add(Me.DateTimePickerOra)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelPostoControllo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DInserimentoLuogoControllo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DInserimentoLuogoControllo"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ControlloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LuoghicontrolloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents LabelPostoControllo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LuoghicontrolloTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.luoghicontrolloTableAdapter
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents LuoghicontrolloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ControlloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ControlloTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.controlloTableAdapter
    Friend WithEvents DateTimePickerOra As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbLuogoControllo As OrSe.UserControlComboBox

End Class
