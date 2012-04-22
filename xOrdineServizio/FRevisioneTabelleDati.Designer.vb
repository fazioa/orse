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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRevisioneTabelleDati))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LuoghicontrolloDataGridView = New System.Windows.Forms.DataGridView()
        Me.LuoghicontrolloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ModelliMezzoDataGridView = New System.Windows.Forms.DataGridView()
        Me.ModelliMezzoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LuoghicontrolloTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.luoghicontrolloTableAdapter()
        Me.LuoghicontrolloBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LuoghicontrolloBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ModelliMezzoTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnUnisci = New System.Windows.Forms.Button()
        Me.idLuogo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.luogo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idMezzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mezzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.LuoghicontrolloDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LuoghicontrolloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ModelliMezzoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelliMezzoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LuoghicontrolloBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LuoghicontrolloBindingNavigator.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(779, 372)
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
        Me.TabPage1.Size = New System.Drawing.Size(771, 346)
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
        Me.LuoghicontrolloDataGridView.Size = New System.Drawing.Size(765, 340)
        Me.LuoghicontrolloDataGridView.TabIndex = 0
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
        Me.TabPage2.Size = New System.Drawing.Size(771, 346)
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
        Me.ModelliMezzoDataGridView.Size = New System.Drawing.Size(765, 340)
        Me.ModelliMezzoDataGridView.TabIndex = 0
        '
        'ModelliMezzoBindingSource
        '
        Me.ModelliMezzoBindingSource.DataMember = "modelliMezzo"
        Me.ModelliMezzoBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'LuoghicontrolloTableAdapter
        '
        Me.LuoghicontrolloTableAdapter.ClearBeforeFill = True
        '
        'LuoghicontrolloBindingNavigator
        '
        Me.LuoghicontrolloBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LuoghicontrolloBindingNavigator.BindingSource = Me.LuoghicontrolloBindingSource
        Me.LuoghicontrolloBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LuoghicontrolloBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LuoghicontrolloBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LuoghicontrolloBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LuoghicontrolloBindingNavigatorSaveItem})
        Me.LuoghicontrolloBindingNavigator.Location = New System.Drawing.Point(0, 400)
        Me.LuoghicontrolloBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LuoghicontrolloBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LuoghicontrolloBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LuoghicontrolloBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LuoghicontrolloBindingNavigator.Name = "LuoghicontrolloBindingNavigator"
        Me.LuoghicontrolloBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LuoghicontrolloBindingNavigator.Size = New System.Drawing.Size(779, 25)
        Me.LuoghicontrolloBindingNavigator.TabIndex = 1
        Me.LuoghicontrolloBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
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
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'LuoghicontrolloBindingNavigatorSaveItem
        '
        Me.LuoghicontrolloBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LuoghicontrolloBindingNavigatorSaveItem.Image = CType(resources.GetObject("LuoghicontrolloBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LuoghicontrolloBindingNavigatorSaveItem.Name = "LuoghicontrolloBindingNavigatorSaveItem"
        Me.LuoghicontrolloBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LuoghicontrolloBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ModelliMezzoTableAdapter
        '
        Me.ModelliMezzoTableAdapter.ClearBeforeFill = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnUnisci)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 372)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(779, 28)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Elimina voci inutilizzate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Location = New System.Drawing.Point(263, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Salva tutto"
        Me.Button2.UseVisualStyleBackColor = True
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
        'idLuogo
        '
        Me.idLuogo.DataPropertyName = "id"
        Me.idLuogo.HeaderText = "id"
        Me.idLuogo.Name = "idLuogo"
        '
        'luogo
        '
        Me.luogo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.luogo.DataPropertyName = "luogo"
        Me.luogo.HeaderText = "luogo"
        Me.luogo.Name = "luogo"
        '
        'idMezzo
        '
        Me.idMezzo.DataPropertyName = "id"
        Me.idMezzo.HeaderText = "id"
        Me.idMezzo.Name = "idMezzo"
        '
        'mezzo
        '
        Me.mezzo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.mezzo.DataPropertyName = "mezzo"
        Me.mezzo.HeaderText = "mezzo"
        Me.mezzo.Name = "mezzo"
        '
        'FRevisioneTabelleDati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 425)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.LuoghicontrolloBindingNavigator)
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
        CType(Me.LuoghicontrolloBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LuoghicontrolloBindingNavigator.ResumeLayout(False)
        Me.LuoghicontrolloBindingNavigator.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents LuoghicontrolloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LuoghicontrolloTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.luoghicontrolloTableAdapter
    Friend WithEvents LuoghicontrolloBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LuoghicontrolloBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LuoghicontrolloDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ModelliMezzoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModelliMezzoTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter
    Friend WithEvents ModelliMezzoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnUnisci As System.Windows.Forms.Button
    Friend WithEvents idLuogo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents luogo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idMezzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mezzo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
