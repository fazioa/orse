<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FReport))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet()
        Me.QInterventiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QInterventiTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QInterventiTableAdapter()
        Me.TableAdapterManager = New OrSe.dbAlegatoADataSetTableAdapters.TableAdapterManager()
        Me.QAllegatoATableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter()
        Me.QAllegatoABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QInterventiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.IsDocumentMapWidthFixed = True
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.PromptAreaCollapsed = True
        Me.ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("", System.UriKind.Relative)
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowCredentialPrompts = False
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(804, 464)
        Me.ReportViewer1.TabIndex = 0
        '
        'DbAlegatoADataSet
        '
        Me.DbAlegatoADataSet.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.allegatoATableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.comuneTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.controlloTableAdapter = Nothing
        Me.TableAdapterManager.interventiTableAdapter = Nothing
        Me.TableAdapterManager.luoghicontrolloTableAdapter = Nothing
        Me.TableAdapterManager.modelliMezzoTableAdapter = Nothing
        Me.TableAdapterManager.operatoreTableAdapter = Nothing
        Me.TableAdapterManager.ordineServizioTableAdapter = Nothing
        Me.TableAdapterManager.personaTableAdapter = Nothing
        Me.TableAdapterManager.prioritaComuneTableAdapter = Nothing
        Me.TableAdapterManager.rubricaTableAdapter = Nothing
        Me.TableAdapterManager.sopralluogoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OrSe.dbAlegatoADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.versioneTableAdapter = Nothing
        '
        'QAllegatoATableAdapter
        '
        Me.QAllegatoATableAdapter.ClearBeforeFill = True
        '
        'QAllegatoABindingSource
        '
        Me.QAllegatoABindingSource.DataMember = "QAllegatoA"
        Me.QAllegatoABindingSource.DataSource = Me.DbAlegatoADataSet
        '
        'FReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 464)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FReport"
        Me.Text = "FReport"
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QInterventiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents QInterventiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QInterventiTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QInterventiTableAdapter
    Friend WithEvents TableAdapterManager As OrSe.dbAlegatoADataSetTableAdapters.TableAdapterManager
    Friend WithEvents QAllegatoATableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
    Friend WithEvents QAllegatoABindingSource As System.Windows.Forms.BindingSource
End Class
