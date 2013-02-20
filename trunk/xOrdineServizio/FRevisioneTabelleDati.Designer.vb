<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRevisioneTabelleDati
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LuoghicontrolloDataGridView = New System.Windows.Forms.DataGridView()
        Me.idLuogo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.luogo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LuoghicontrolloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ModelliMezzoDataGridView = New System.Windows.Forms.DataGridView()
        Me.idMezzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mezzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelliMezzoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.OperatoreDataGridView = New System.Windows.Forms.DataGridView()
        Me.idOperatore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operatori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperatoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LuoghicontrolloTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.luoghicontrolloTableAdapter()
        Me.ModelliMezzoTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnEliminaVoci = New System.Windows.Forms.Button()
        Me.btnUnisci = New System.Windows.Forms.Button()
        Me.OperatoreTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.operatoreTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.LuoghicontrolloDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LuoghicontrolloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ModelliMezzoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelliMezzoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.OperatoreDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperatoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(779, 387)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.Tag = ""
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.LuoghicontrolloDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(771, 361)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "luoghi"
        Me.TabPage1.Text = "Luoghi controllo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LuoghicontrolloDataGridView
        '
        Me.LuoghicontrolloDataGridView.AutoGenerateColumns = False
        Me.LuoghicontrolloDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LuoghicontrolloDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idLuogo, Me.luogo})
        Me.LuoghicontrolloDataGridView.DataSource = Me.LuoghicontrolloBindingSource
        Me.LuoghicontrolloDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LuoghicontrolloDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.LuoghicontrolloDataGridView.Name = "LuoghicontrolloDataGridView"
        Me.LuoghicontrolloDataGridView.Size = New System.Drawing.Size(765, 355)
        Me.LuoghicontrolloDataGridView.TabIndex = 0
        '
        'idLuogo
        '
        Me.idLuogo.DataPropertyName = "id"
        Me.idLuogo.HeaderText = "id"
        Me.idLuogo.Name = "idLuogo"
        Me.idLuogo.Visible = False
        '
        'luogo
        '
        Me.luogo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.luogo.DataPropertyName = "luogo"
        Me.luogo.HeaderText = "luogo"
        Me.luogo.Name = "luogo"
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
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ModelliMezzoDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(771, 361)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Tag = "mezzi"
        Me.TabPage2.Text = "Mezzi"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ModelliMezzoDataGridView
        '
        Me.ModelliMezzoDataGridView.AutoGenerateColumns = False
        Me.ModelliMezzoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModelliMezzoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMezzo, Me.mezzo})
        Me.ModelliMezzoDataGridView.DataSource = Me.ModelliMezzoBindingSource
        Me.ModelliMezzoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModelliMezzoDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ModelliMezzoDataGridView.Name = "ModelliMezzoDataGridView"
        Me.ModelliMezzoDataGridView.Size = New System.Drawing.Size(765, 355)
        Me.ModelliMezzoDataGridView.TabIndex = 0
        '
        'idMezzo
        '
        Me.idMezzo.DataPropertyName = "id"
        Me.idMezzo.HeaderText = "id"
        Me.idMezzo.Name = "idMezzo"
        Me.idMezzo.Visible = False
        '
        'mezzo
        '
        Me.mezzo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.mezzo.DataPropertyName = "mezzo"
        Me.mezzo.HeaderText = "mezzo"
        Me.mezzo.Name = "mezzo"
        '
        'ModelliMezzoBindingSource
        '
        Me.ModelliMezzoBindingSource.DataMember = "modelliMezzo"
        Me.ModelliMezzoBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.OperatoreDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(771, 361)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Operatori"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'OperatoreDataGridView
        '
        Me.OperatoreDataGridView.AutoGenerateColumns = False
        Me.OperatoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OperatoreDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idOperatore, Me.operatori})
        Me.OperatoreDataGridView.DataSource = Me.OperatoreBindingSource
        Me.OperatoreDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OperatoreDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.OperatoreDataGridView.Name = "OperatoreDataGridView"
        Me.OperatoreDataGridView.Size = New System.Drawing.Size(765, 355)
        Me.OperatoreDataGridView.TabIndex = 0
        '
        'idOperatore
        '
        Me.idOperatore.DataPropertyName = "id"
        Me.idOperatore.HeaderText = "id"
        Me.idOperatore.Name = "idOperatore"
        Me.idOperatore.Visible = False
        '
        'operatori
        '
        Me.operatori.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.operatori.DataPropertyName = "operatori"
        Me.operatori.HeaderText = "operatori"
        Me.operatori.Name = "operatori"
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
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEliminaVoci)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnUnisci)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 387)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(779, 38)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btnEliminaVoci
        '
        Me.btnEliminaVoci.AutoSize = True
        Me.btnEliminaVoci.Location = New System.Drawing.Point(3, 3)
        Me.btnEliminaVoci.Name = "btnEliminaVoci"
        Me.btnEliminaVoci.Size = New System.Drawing.Size(124, 23)
        Me.btnEliminaVoci.TabIndex = 0
        Me.btnEliminaVoci.Text = "Elimina voci inutilizzate"
        Me.btnEliminaVoci.UseVisualStyleBackColor = True
        '
        'btnUnisci
        '
        Me.btnUnisci.AutoSize = True
        Me.btnUnisci.Location = New System.Drawing.Point(133, 3)
        Me.btnUnisci.Name = "btnUnisci"
        Me.btnUnisci.Size = New System.Drawing.Size(124, 23)
        Me.btnUnisci.TabIndex = 2
        Me.btnUnisci.Text = "Unisci..."
        Me.btnUnisci.UseVisualStyleBackColor = True
        '
        'OperatoreTableAdapter
        '
        Me.OperatoreTableAdapter.ClearBeforeFill = True
        '
        'FRevisioneTabelleDati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 425)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FRevisioneTabelleDati"
        Me.Text = "Revisione Tabelle Dati"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.LuoghicontrolloDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LuoghicontrolloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ModelliMezzoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelliMezzoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.OperatoreDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperatoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents LuoghicontrolloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LuoghicontrolloTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.luoghicontrolloTableAdapter
    Friend WithEvents LuoghicontrolloDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ModelliMezzoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelliMezzoTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter
    Friend WithEvents ModelliMezzoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnEliminaVoci As System.Windows.Forms.Button
    Friend WithEvents btnUnisci As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents OperatoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperatoreTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.operatoreTableAdapter
    Friend WithEvents OperatoreDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents idLuogo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents luogo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idMezzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mezzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idOperatore As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents operatori As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
