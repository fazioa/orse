<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlComboBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.LuoghicontrolloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet
        Me.OperatoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelliMezzoTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter
        Me.LuoghicontrolloTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.luoghicontrolloTableAdapter
        Me.ControlloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperatoreTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.operatoreTableAdapter
        Me.ComuneTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.comuneTableAdapter
        Me.ControlloTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.controlloTableAdapter
        Me.ModelliMezzoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.LuoghicontrolloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperatoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelliMezzoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.CausesValidation = False
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.MaxLength = 150
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(419, 41)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.WordWrap = False
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
        'OperatoreBindingSource
        '
        Me.OperatoreBindingSource.DataMember = "operatore"
        Me.OperatoreBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'ModelliMezzoTableAdapter
        '
        Me.ModelliMezzoTableAdapter.ClearBeforeFill = True
        '
        'LuoghicontrolloTableAdapter
        '
        Me.LuoghicontrolloTableAdapter.ClearBeforeFill = True
        '
        'ControlloBindingSource
        '
        Me.ControlloBindingSource.DataMember = "controllo"
        Me.ControlloBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'OperatoreTableAdapter
        '
        Me.OperatoreTableAdapter.ClearBeforeFill = True
        '
        'ComuneTableAdapter
        '
        Me.ComuneTableAdapter.ClearBeforeFill = True
        '
        'ControlloTableAdapter
        '
        Me.ControlloTableAdapter.ClearBeforeFill = True
        '
        'ModelliMezzoBindingSource
        '
        Me.ModelliMezzoBindingSource.DataMember = "modelliMezzo"
        Me.ModelliMezzoBindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'UserControlComboBox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CausesValidation = False
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "UserControlComboBox"
        Me.Size = New System.Drawing.Size(419, 46)
        CType(Me.LuoghicontrolloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperatoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelliMezzoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents ModelliMezzoTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter
    Friend WithEvents LuoghicontrolloTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.luoghicontrolloTableAdapter
    Friend WithEvents LuoghicontrolloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperatoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperatoreTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.operatoreTableAdapter
    Friend WithEvents ComuneTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.comuneTableAdapter
    Friend WithEvents ControlloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ControlloTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.controlloTableAdapter
    Friend WithEvents ModelliMezzoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
