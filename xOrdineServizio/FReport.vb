
Public Class FReport
    Dim iOrdineServizio As Integer
    Dim sOrdineServizio As String
    Dim tiIDControllo As Integer
    Dim feActions As New OrSe.ActionsLibrary
    Dim esitoSDI As tipoEsitoSDI
    Dim _tipo As tipoReport
    'classe che puàò contenere diversi parametri
    Dim parametri As parametriOP85


    Private Sub FReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbAlegatoADataSet.QInterventi' table. You can move, or remove it, as needed.
        Me.QInterventiTableAdapter.Fill(Me.DbAlegatoADataSet.QInterventi)
        Dim reportPath As String = ""
        Dim sCartella As String = "\Resources\automazione\"
        Dim sPath As String = My.Settings.pathCartellaScrivibile & sCartella

        'Dim sPath As String = Application.StartupPath & sCartella
        'Dim sCartella As String = "\Resources\"


        Dim sOS As String = ""
        Dim esitoSDI As tipoEsitoSDI = New tipoEsitoSDI()

        If (_tipo = tipoReport.interventi) Then
            'settaggi per report INTERVENTI
            'sOS = "{interventi.ordineservizio} like ""*" & tOrdineServizio & "*"""
            sOS = ""
            reportPath = sPath & "reportInterventi.rpt"
            MsgBox(reportPath, MsgBoxStyle.Information, "REPORT")

            QInterventiTableAdapter.FillByOSOrderByDataInizio_Paragrafo(dbAlegatoADataSet.QInterventi, iOrdineServizio, paragrafoOS.interventi)
            ' QInterventiTableAdapter.FillByOSOrderByDataInizio(DbAlegatoADataSet.QInterventi, iOrdineServizio)
        ElseIf (_tipo = tipoReport.informazioni) Then
            reportPath = sPath & "reportInterventi.rpt"
            QInterventiTableAdapter.FillByOSOrderByDataInizio_Paragrafo(dbAlegatoADataSet.QInterventi, iOrdineServizio, paragrafoOS.informazioni)
            'QInterventiTableAdapter.FillByOSOrderByDataInizio(DbAlegatoADataSet.QInterventi, iOrdineServizio)
        ElseIf (_tipo = tipoReport.allegatoA) Then
            'settaggi per report ALLEGATO A
            sOS = "{QAllegatoA.idOS} = " & iOrdineServizio
            reportPath = sPath & "reportAllegatoA.rpt"
            ' MsgBox(reportPath, MsgBoxStyle.Information, "PATH Report")
            QAllegatoATableAdapter.Fill(dbAlegatoADataSet.QAllegatoA)
            ' MsgBox("fill ok", MsgBoxStyle.Information, "PATH Report")
        Else
            'settaggi per report OP85
            sOS = "{QAllegatoA.ordine} =0"
            reportPath = sPath & "reportOP85.rpt"
            QAllegatoATableAdapter.FillByIdControllo(dbAlegatoADataSet.QAllegatoA, tiIDControllo)
        End If

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = reportPath

        'imposto il subreport per l'AllegatoA
        'If (_tipo = tipoReport.allegatoA) Then
        '    Dim sQuerysubReport = sOS + " AND {QAllegatoA.positivoSDI}=" + """" + esitoSDI.si + """"
        '    Me.ReportViewer1.LocalReport.LoadSubreportDefinition(

        '    cr.Subreports("subreportAllegatoAPrecedenti").SetDataSource(Me.DbAlegatoADataSet)
        '    cr.Subreports("subreportAllegatoAPrecedenti").RecordSelectionFormula() = sQuerysubReport
        'End If

        'imposto i parametri da passare al report
        'If (My.MySettings.Default.ComandanteTitolare) Then
        '    cr.SetParameterValue("gruppoFirmaRiga1", My.MySettings.Default.GruppoFirmaRiga1)
        '    cr.SetParameterValue("gruppoFirmaRiga2", My.MySettings.Default.GruppoFirmaRiga2)
        'Else
        '    cr.SetParameterValue("gruppoFirmaRiga1", My.MySettings.Default.GruppoFirmaInterinaleRiga1)
        '    cr.SetParameterValue("gruppoFirmaRiga2", My.MySettings.Default.GruppoFirmaInterinaleRiga2)
        'End If

        'If (_tipo = tipoReport.interventi Or _tipo = tipoReport.informazioni Or _tipo = tipoReport.op85) Then
        '    cr.SetParameterValue("regione", My.MySettings.Default.regione)
        '    cr.SetParameterValue("comando", My.MySettings.Default.comando)
        '    cr.SetParameterValue("comando2", My.MySettings.Default.comandoSecondaRiga)
        '    If (_tipo = tipoReport.op85) Then
        '        cr.SetParameterValue("comune", My.MySettings.Default.comune)
        '        cr.SetParameterValue("protocollo", parametri.protocollo)
        '        cr.SetParameterValue("protocolloInformatico", parametri.protocolloInformatico)

        '        ================ COMANDI DESTINATARI
        '        Dim sArray As String() = parametri.ComandiDestinatari.ToArray
        '        cr.SetParameterValue("citta", sArray)
        '        ================ 
        '        ================ NOTE
        '        cr.SetParameterValue("note", parametri.sNote.ToString)
        '        ================ 
        '    End If
        'End If

        'passo la descrizione del paragrafo: 9 Interventi o 6 Informazioni
        'If (_tipo = tipoReport.interventi) Then
        '    cr.SetParameterValue("descrizioneParagrafo", My.MySettings.Default.descrizioneParagrafoInterventi)
        'ElseIf (_tipo = tipoReport.informazioni) Then
        '    cr.SetParameterValue("descrizioneParagrafo", My.MySettings.Default.descrizioneParagrafoInformazioni)
        'End If

        '---mainreport selection formula
        'cr.RecordSelectionFormula() = sOS

        '     CrystalReportViewer.SelectionFormula = sOS
        'CrystalReportViewer.Refresh()

        'CrystalReportViewer.ReportSource = cr



        Me.ReportViewer1.RefreshReport()


    End Sub

    Public Sub New(ByVal tOS As Integer, ByVal sNomeOS As String, ByVal tipo As tipoReport)

        ' This call is required by the designer.
        InitializeComponent()

        feActions.setStandardFormSize(Me)
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        iOrdineServizio = tOS
        sOrdineServizio = sNomeOS
        _tipo = tipo
    End Sub
End Class