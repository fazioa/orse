Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FanteprimaReport
    Dim iOrdineServizio As Integer
    Dim sOrdineServizio As String
    Dim tiIDControllo As Integer
    Dim feActions As OrSe.ActionsLibrary
    Dim esitoSDI As tipoEsitoSDI
    Dim _tipo As tipoReport
    'classe che puàò contenere diversi parametri
    Dim parametri As parametriGenerale
    'oggetto REPORT
    Dim cr As New ReportDocument()

    Public Sub New(ByVal tOS As Integer, ByVal sNomeOS As String, ByVal tipo As tipoReport)
        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()
        feActions.setStandardFormSize(Me)
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        iOrdineServizio = tOS
        sOrdineServizio = sNomeOS
        _tipo = tipo
    End Sub
    '    Public Sub New(ByVal iIDControllo As Integer, ByVal par As parametriGenerale, ByVal tipo As tipoReport)
    '        InitializeComponent()
    '        parametri = par

    'tiIDControllo = iIDControllo
    '_tipo = tipo
    'End Sub

    Private Sub FanteprimaReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim reportPath As String = ""
        Dim sOS As String = ""
        Dim esitoSDI As tipoEsitoSDI = New tipoEsitoSDI()

        If (_tipo = tipoReport.interventi) Then
            'settaggi per report INTERVENTI
            'sOS = "{interventi.ordineservizio} like ""*" & tOrdineServizio & "*"""
            sOS = ""
            reportPath = Application.StartupPath & "\Resources\reportInterventi.rpt"
            QInterventiTableAdapter.FillByOSOrderByDataInizio_Paragrafo(DbAlegatoADataSet.QInterventi, iOrdineServizio, paragrafoOS.interventi)
            ' QInterventiTableAdapter.FillByOSOrderByDataInizio(DbAlegatoADataSet.QInterventi, iOrdineServizio)
        ElseIf (_tipo = tipoReport.informazioni) Then
            reportPath = Application.StartupPath & "\Resources\reportInterventi.rpt"
            QInterventiTableAdapter.FillByOSOrderByDataInizio_Paragrafo(DbAlegatoADataSet.QInterventi, iOrdineServizio, paragrafoOS.informazioni)
            'QInterventiTableAdapter.FillByOSOrderByDataInizio(DbAlegatoADataSet.QInterventi, iOrdineServizio)
        ElseIf (_tipo = tipoReport.allegatoA) Then
            'settaggi per report ALLEGATO A
            sOS = "{QAllegatoA.idOS} = " & iOrdineServizio
            reportPath = Application.StartupPath & "\Resources\reportAllegatoA.rpt"
            QAllegatoATableAdapter.Fill(DbAlegatoADataSet.QAllegatoA)
        Else
            'settaggi per report OP85
            sOS = "{QAllegatoA.ordine} =0"
            reportPath = Application.StartupPath & "\Resources\reportOP85.rpt"
            QAllegatoATableAdapter.FillByIdControllo(DbAlegatoADataSet.QAllegatoA, tiIDControllo)
        End If


        'carico il file report
        cr.Load(reportPath)
        cr.SetDataSource(Me.DbAlegatoADataSet)

        'imposto report e subreport subreport per il mod. OP85
        If (_tipo = tipoReport.op85) Then
            '---subreport
            Dim sOSsubReport = "{QAllegatoA.ordine} > 0"
            cr.Subreports("subreportOP85").SetDataSource(Me.DbAlegatoADataSet)
            cr.Subreports("subreportOP85").RecordSelectionFormula() = sOSsubReport
        End If

        'imposto il subreport per l'AllegatoA
        If (_tipo = tipoReport.allegatoA) Then
            Dim sQuerysubReport = sOS + " AND {QAllegatoA.positivoSDI}=" + """" + esitoSDI.si + """"
            cr.Subreports("subreportAllegatoAPrecedenti").SetDataSource(Me.DbAlegatoADataSet)
            cr.Subreports("subreportAllegatoAPrecedenti").RecordSelectionFormula() = sQuerysubReport
        End If



        'imposto i parametri da passare al report
        If (My.MySettings.Default.ComandanteTitolare) Then
            cr.SetParameterValue("gruppoFirmaRiga1", My.MySettings.Default.GruppoFirmaRiga1)
            cr.SetParameterValue("gruppoFirmaRiga2", My.MySettings.Default.GruppoFirmaRiga2)
        Else
            cr.SetParameterValue("gruppoFirmaRiga1", My.MySettings.Default.GruppoFirmaInterinaleRiga1)
            cr.SetParameterValue("gruppoFirmaRiga2", My.MySettings.Default.GruppoFirmaInterinaleRiga2)
        End If

        If (_tipo = tipoReport.interventi Or _tipo = tipoReport.informazioni Or _tipo = tipoReport.op85) Then
            cr.SetParameterValue("regione", My.MySettings.Default.regione)
            cr.SetParameterValue("comando", My.MySettings.Default.comando)
            If (_tipo = tipoReport.op85) Then
                cr.SetParameterValue("comune", My.MySettings.Default.comune)
                cr.SetParameterValue("protocollo", parametri.protocollo)
                cr.SetParameterValue("protocolloInformatico", parametri.protocolloInformatico)

                '================ COMANDI DESTINATARI
                Dim sArray As String() = parametri.ComandiDestinatari.ToArray
                cr.SetParameterValue("citta", sArray)
                '================ 
                '================ NOTE
                cr.SetParameterValue("note", parametri.sNote.ToString)
                '================ 
            End If
        End If

        'passo la descrizione del paragrafo: 9 Interventi o 6 Informazioni
        If (_tipo = tipoReport.interventi) Then
            cr.SetParameterValue("descrizioneParagrafo", My.MySettings.Default.descrizioneParagrafoInterventi)
        ElseIf (_tipo = tipoReport.informazioni) Then
            cr.SetParameterValue("descrizioneParagrafo", My.MySettings.Default.descrizioneParagrafoInformazioni)
        End If

        '---mainreport selection formula
        cr.RecordSelectionFormula() = sOS

        '     CrystalReportViewer.SelectionFormula = sOS
        'CrystalReportViewer.Refresh()

        CrystalReportViewer.ReportSource = cr


    End Sub

    Private Sub btnPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPDF.Click
        esporta(_tipo, tipoFile.PDF)
    End Sub

    Private Sub btnWORD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWORD.Click
        esporta(_tipo, tipoFile.WORD)
    End Sub

    Private Sub btnEXCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        esporta(_tipo, tipoFile.EXCEL)
    End Sub

    Public Sub esporta(ByVal tipoReport As tipoReport, ByVal tipo As tipoFile)
        Dim sFileSuffisso As String = ""
        Dim tipoExport As ExportFormatType = ExportFormatType.PortableDocFormat

        If (tipoReport = OrSe.tipoReport.allegatoA) Then
            sFileSuffisso = "_AllegatoA"
        ElseIf (tipoReport = OrSe.tipoReport.interventi) Then
            sFileSuffisso = "_Interventi"
        ElseIf (tipoReport = OrSe.tipoReport.op85) Then
            sFileSuffisso = "_OP85"
            sOrdineServizio = parametri.protocollo
        End If

        If (tipo = tipoFile.PDF) Then
            tipoExport = ExportFormatType.PortableDocFormat
            SaveFileDialog1.Filter = "*.pdf|*.*"
            sFileSuffisso = sFileSuffisso + ".pdf"
        ElseIf (tipo = tipoFile.WORD) Then
            tipoExport = ExportFormatType.WordForWindows
            SaveFileDialog1.Filter = "*.doc|*.*"
            sFileSuffisso = sFileSuffisso + ".doc"
        End If

        SaveFileDialog1.FileName = sOrdineServizio.Replace("/", "_") + sFileSuffisso
        Dim bResult As DialogResult = SaveFileDialog1.ShowDialog()
        If (bResult = Windows.Forms.DialogResult.OK) Then
            Dim sFileName = SaveFileDialog1.FileName
            cr.ExportToDisk(tipoExport, sFileName)
            cr.Close()
        End If
    End Sub
End Class
