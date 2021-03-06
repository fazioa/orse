﻿Imports Microsoft.Reporting.WinForms

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
        Try
            Dim reportPath As String = ""
        Dim sCartella As String = "\Resources\automazione\"
        Dim sPath As String = My.Settings.pathCartellaScrivibile & sCartella

        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()

        Dim sOS As String = ""
        Dim esitoSDI As tipoEsitoSDI = New tipoEsitoSDI()

        If (_tipo = tipoReport.interventi) Then
            'settaggi per report INTERVENTI
            'sOS = "{interventi.ordineservizio} like ""*" & tOrdineServizio & "*"""
            sOS = ""
            reportPath = sPath & "reportInterventi.rdlc"
            QInterventiTableAdapter.FillByOSOrderByDataInizio_Paragrafo(DbAlegatoADataSet.QInterventi, iOrdineServizio, paragrafoOS.interventi)

            ReportDataSource1.Value = Me.QInterventiBindingSource
        ElseIf (_tipo = tipoReport.informazioni) Then
            reportPath = sPath & "reportInterventi.rdlc"
            QInterventiTableAdapter.FillByOSOrderByDataInizio_Paragrafo(DbAlegatoADataSet.QInterventi, iOrdineServizio, paragrafoOS.informazioni)

            ReportDataSource1.Value = Me.QInterventiBindingSource

        ElseIf (_tipo = tipoReport.allegatoA) Then
            'settaggi per report ALLEGATO A
            sOS = "{QAllegatoA.idOS} = " & iOrdineServizio
            reportPath = sPath & "reportAllegatoA.rdlc"
            ' MsgBox(reportPath, MsgBoxStyle.Information, "PATH Report")
            QAllegatoATableAdapter.FillByOS(DbAlegatoADataSet.QAllegatoA, iOrdineServizio)

            ReportDataSource1.Value = Me.QAllegatoABindingSource
        End If

        ReportDataSource1.Name = "DataSet1"
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        'setta il path del report.
        Me.ReportViewer1.LocalReport.ReportPath = reportPath

        'imposto i parametri da passare al report
        Dim rPar As ReportParameter = New ReportParameter
        Dim rParCollection As ReportParameterCollection = New ReportParameterCollection


        If (My.MySettings.Default.ComandanteTitolare) Then

            rPar = New ReportParameter("gruppoFirmaRiga1", My.MySettings.Default.GruppoFirmaRiga1)
            rParCollection.Add(rPar)

            rPar = New ReportParameter("gruppoFirmaRiga2", My.MySettings.Default.GruppoFirmaRiga2)
            rParCollection.Add(rPar)

        Else
            rPar = New ReportParameter("gruppoFirmaRiga1", My.MySettings.Default.GruppoFirmaInterinaleRiga1)
            rParCollection.Add(rPar)

            rPar = New ReportParameter("gruppoFirmaRiga2", My.MySettings.Default.GruppoFirmaInterinaleRiga2)
            rParCollection.Add(rPar)
        End If


        If (_tipo = tipoReport.interventi Or _tipo = tipoReport.informazioni Or _tipo = tipoReport.op85) Then
            Dim sParVal As String = " "
            'IL REPORT NON CARICA SE MANCA UN PARAMETRO, ALLORA MI ASSICURO CHE TUTTI CONTENGANO ALMENO UNO SPAZIO. E' IL CASO DELLE STAZION
            If My.MySettings.Default.regione = "" Or My.MySettings.Default.regione = Nothing Then
                sParVal = " "
            Else
                sParVal = My.MySettings.Default.regione
            End If
            rPar = New ReportParameter("regione", sParVal)
            rParCollection.Add(rPar)

            If My.MySettings.Default.comando = "" Or My.MySettings.Default.comando = Nothing Then
                sParVal = " "
            Else
                sParVal = My.MySettings.Default.comando
            End If
            rPar = New ReportParameter("comando", sParVal)
            rParCollection.Add(rPar)
            If My.MySettings.Default.comandoSecondaRiga = "" Or My.MySettings.Default.comandoSecondaRiga = Nothing Then
                sParVal = " "
            Else
                sParVal = My.MySettings.Default.comandoSecondaRiga
            End If
            rPar = New ReportParameter("comando2", sParVal)
            rParCollection.Add(rPar)

        End If

            'passo la descrizione del paragrafo: 9 Interventi o 6 Informazioni
            If (_tipo = tipoReport.interventi) Then
                rPar = New ReportParameter("descrizioneParagrafo", My.MySettings.Default.descrizioneParagrafoInterventi)
                rParCollection.Add(rPar)

            ElseIf (_tipo = tipoReport.informazioni) Then
                rPar = New ReportParameter("descrizioneParagrafo", My.MySettings.Default.descrizioneParagrafoInformazioni)
                rParCollection.Add(rPar)
            End If

        Me.ReportViewer1.LocalReport.SetParameters(rParCollection)
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox("Windows Report deve essere installato. Eseguire nuovamente l'installazione di OrSe ed acconsentire al download ed installazione di Windows Report", MsgBoxStyle.Critical, "Errore")
        End Try
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