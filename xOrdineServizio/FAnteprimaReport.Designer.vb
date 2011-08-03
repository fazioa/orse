<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FanteprimaReport
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
        Me.btnPDF = New System.Windows.Forms.Button
        Me.btnWORD = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.reportInterventi = New OrSe.reportInterventi
        Me.reportAllegatoA = New OrSe.reportAllegatoA
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet
        Me.QAllegatoATableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
        Me.QAllegatoABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QInterventiTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QInterventiTableAdapter
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPDF
        '
        Me.btnPDF.BackgroundImage = Global.OrSe.My.Resources.Resources.PDF
        Me.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPDF.Location = New System.Drawing.Point(83, 12)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(51, 40)
        Me.btnPDF.TabIndex = 1
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'btnWORD
        '
        Me.btnWORD.BackgroundImage = Global.OrSe.My.Resources.Resources.WORD
        Me.btnWORD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWORD.Location = New System.Drawing.Point(139, 12)
        Me.btnWORD.Name = "btnWORD"
        Me.btnWORD.Size = New System.Drawing.Size(53, 40)
        Me.btnWORD.TabIndex = 2
        Me.btnWORD.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.SupportMultiDottedExtensions = True
        '
        'CrystalReportViewer
        '
        Me.CrystalReportViewer.ActiveViewIndex = 0
        Me.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer.CausesValidation = False
        Me.CrystalReportViewer.DisplayBackgroundEdge = False
        Me.CrystalReportViewer.DisplayGroupTree = False
        Me.CrystalReportViewer.DisplayStatusBar = False
        Me.CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer.EnableDrillDown = False
        Me.CrystalReportViewer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.ReportSource = Me.reportInterventi
        Me.CrystalReportViewer.ShowCloseButton = False
        Me.CrystalReportViewer.ShowExportButton = False
        Me.CrystalReportViewer.ShowGotoPageButton = False
        Me.CrystalReportViewer.ShowGroupTreeButton = False
        Me.CrystalReportViewer.ShowPageNavigateButtons = False
        Me.CrystalReportViewer.ShowRefreshButton = False
        Me.CrystalReportViewer.ShowTextSearchButton = False
        Me.CrystalReportViewer.ShowZoomButton = False
        Me.CrystalReportViewer.Size = New System.Drawing.Size(804, 458)
        Me.CrystalReportViewer.TabIndex = 0
        '
        'DbAlegatoADataSet
        '
        Me.DbAlegatoADataSet.DataSetName = "dbAlegatoADataSet"
        Me.DbAlegatoADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'QInterventiTableAdapter
        '
        Me.QInterventiTableAdapter.ClearBeforeFill = True
        '
        'FanteprimaReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 458)
        Me.Controls.Add(Me.btnWORD)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.CrystalReportViewer)
        Me.Name = "FanteprimaReport"
        Me.Text = "anteprimaReport"
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents reportInterventi As OrSe.reportInterventi
    Friend WithEvents QAllegatoATableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
    Friend WithEvents reportAllegatoA As OrSe.reportAllegatoA
    Friend WithEvents QAllegatoABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents btnWORD As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents QInterventiTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QInterventiTableAdapter

End Class
