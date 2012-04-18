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
        Me.components = New System.ComponentModel.Container()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnWORD = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.DbAlegatoADataSet = New OrSe.dbAlegatoADataSet()
        Me.QAllegatoATableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter()
        Me.QAllegatoABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QInterventiTableAdapter = New OrSe.dbAlegatoADataSetTableAdapters.QInterventiTableAdapter()
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPDF
        '
        Me.btnPDF.BackgroundImage = Global.OrSe.My.Resources.Resources.PDF
        Me.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPDF.Location = New System.Drawing.Point(693, 51)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(51, 40)
        Me.btnPDF.TabIndex = 1
        Me.btnPDF.UseVisualStyleBackColor = True
        Me.btnPDF.Visible = False
        '
        'btnWORD
        '
        Me.btnWORD.BackgroundImage = Global.OrSe.My.Resources.Resources.WORD
        Me.btnWORD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWORD.Location = New System.Drawing.Point(693, 97)
        Me.btnWORD.Name = "btnWORD"
        Me.btnWORD.Size = New System.Drawing.Size(53, 40)
        Me.btnWORD.TabIndex = 2
        Me.btnWORD.UseVisualStyleBackColor = True
        Me.btnWORD.Visible = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.SupportMultiDottedExtensions = True
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
        'CrystalReportViewer
        '
        Me.CrystalReportViewer.ActiveViewIndex = -1
        Me.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer.CausesValidation = False
        Me.CrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer.DisplayBackgroundEdge = False
        Me.CrystalReportViewer.DisplayStatusBar = False
        Me.CrystalReportViewer.DisplayToolbar = False
        Me.CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer.EnableDrillDown = False
        Me.CrystalReportViewer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CrystalReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.SelectionFormula = ""
        Me.CrystalReportViewer.ShowCloseButton = False
        Me.CrystalReportViewer.ShowCopyButton = False
        Me.CrystalReportViewer.ShowGotoPageButton = False
        Me.CrystalReportViewer.ShowGroupTreeButton = False
        Me.CrystalReportViewer.ShowPageNavigateButtons = False
        Me.CrystalReportViewer.ShowRefreshButton = False
        Me.CrystalReportViewer.ShowTextSearchButton = False
        Me.CrystalReportViewer.ShowZoomButton = False
        Me.CrystalReportViewer.Size = New System.Drawing.Size(804, 458)
        Me.CrystalReportViewer.TabIndex = 0
        Me.CrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer.ViewTimeSelectionFormula = ""
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(165, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "PDF"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(84, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "DOC"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(804, 32)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "STAMPA"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FanteprimaReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 458)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnWORD)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.CrystalReportViewer)
        Me.Name = "FanteprimaReport"
        Me.Text = "anteprimaReport"
        CType(Me.DbAlegatoADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QAllegatoABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DbAlegatoADataSet As OrSe.dbAlegatoADataSet
    Friend WithEvents QAllegatoATableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
    Friend WithEvents QAllegatoABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents btnWORD As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents QInterventiTableAdapter As OrSe.dbAlegatoADataSetTableAdapters.QInterventiTableAdapter
    Friend WithEvents CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
