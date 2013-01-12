<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRevisioneTabellaDatiComuni
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LuoghicontrolloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet()
        Me.ModelliMezzoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperatoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LuoghicontrolloTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.luoghicontrolloTableAdapter()
        Me.ModelliMezzoTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.OperatoreTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.operatoreTableAdapter()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ComuneDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComuneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ComuneTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.comuneTableAdapter()
        Me.TableAdapterManager = New OrSe.dbAlegatoADataSetTableAdapters.TableAdapterManager()
        CType(Me.LuoghicontrolloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelliMezzoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperatoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.ComuneDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComuneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LuoghicontrolloBindingSource
        '
        Me.LuoghicontrolloBindingSource.DataMember = "luoghicontrollo"
        Me.LuoghicontrolloBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'DbAlegatoADataSet
        '
        Me.DbAlegatoADataSet.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ModelliMezzoBindingSource
        '
        Me.ModelliMezzoBindingSource.DataMember = "modelliMezzo"
        Me.ModelliMezzoBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'OperatoreBindingSource
        '
        Me.OperatoreBindingSource.DataMember = "operatore"
        Me.OperatoreBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'LuoghicontrolloTableAdapter
        '
        Me.LuoghicontrolloTableAdapter.ClearBeforeFill = True
        '
        'ModelliMezzoTableAdapter
        '
        Me.ModelliMezzoTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 387)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(779, 38)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'OperatoreTableAdapter
        '
        Me.OperatoreTableAdapter.ClearBeforeFill = True
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.ComuneDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(771, 361)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "luoghi"
        Me.TabPage1.Text = "Comuni e Stati"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ComuneDataGridView
        '
        Me.ComuneDataGridView.AutoGenerateColumns = False
        Me.ComuneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComuneDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ComuneDataGridView.DataSource = Me.ComuneBindingSource
        Me.ComuneDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComuneDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ComuneDataGridView.Name = "ComuneDataGridView"
        Me.ComuneDataGridView.Size = New System.Drawing.Size(765, 355)
        Me.ComuneDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "citta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "citta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'ComuneBindingSource
        '
        Me.ComuneBindingSource.DataMember = "comune"
        Me.ComuneBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(779, 387)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.Tag = ""
        '
        'ComuneTableAdapter
        '
        Me.ComuneTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.allegatoATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.comuneTableAdapter = Me.ComuneTableAdapter
        Me.TableAdapterManager.controlloTableAdapter = Nothing
        Me.TableAdapterManager.interventiTableAdapter = Nothing
        Me.TableAdapterManager.luoghicontrolloTableAdapter = Me.LuoghicontrolloTableAdapter
        Me.TableAdapterManager.modelliMezzoTableAdapter = Me.ModelliMezzoTableAdapter
        Me.TableAdapterManager.operatoreTableAdapter = Me.OperatoreTableAdapter
        Me.TableAdapterManager.ordineServizioTableAdapter = Nothing
        Me.TableAdapterManager.personaTableAdapter = Nothing
        Me.TableAdapterManager.prioritaComuneTableAdapter = Nothing
        Me.TableAdapterManager.rubricaTableAdapter = Nothing
        Me.TableAdapterManager.sopralluogoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OrSe.dbAlegatoADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.versioneTableAdapter = Nothing
        '
        'FRevisioneTabellaDatiComuni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 425)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FRevisioneTabellaDatiComuni"
        Me.Text = "Revisione Tabella Comuni e Stati"
        CType(Me.LuoghicontrolloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelliMezzoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperatoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ComuneDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComuneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents LuoghicontrolloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LuoghicontrolloTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.luoghicontrolloTableAdapter
    Friend WithEvents ModelliMezzoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelliMezzoTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents OperatoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperatoreTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.operatoreTableAdapter
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ComuneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComuneTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.comuneTableAdapter
    Friend WithEvents TableAdapterManager As OrSe.dbAlegatoADataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComuneDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
