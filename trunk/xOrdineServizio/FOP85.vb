Public Class FOP85
    Dim feActions As OrSe.ActionsLibrary

    Dim xOS As Integer
    Dim esitoSDI As tipoEsitoSDI = New tipoEsitoSDI()
    Dim parametri As parametriOP85
    'riempio una lista con i dati delle persone, che utilizzerò per compilare il documento word OP85
    Dim listaPersoneOP85 As List(Of OrSe.parametriPersona) = New List(Of OrSe.parametriPersona)()
    Dim log As New XOrseLog
    Dim parametriContr As parametriControllo_e_OS


    Private Sub OP85_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'STILI PER DATAGRID, PER IL RAGGRUPPAMENTO IN BASE AI CONTROLLI
        Dim stile1 As DataGridViewCellStyle
        stile1 = DataGridView1.DefaultCellStyle()
        stile1.BackColor = Color.Azure

        Dim stile2 As DataGridViewCellStyle
        stile2 = DataGridView1.DefaultCellStyle()
        stile2.BackColor = Color.WhiteSmoke
        '===========================================================================

        Me.QAllegatoATableAdapter.FillByOSSDI(Me.DbAlegatoADataSet.QAllegatoA, xOS, esitoSDI.si)
        Dim drv As DataRowView

        Dim iCount As Integer = QAllegatoABindingSource.Count
        Dim bEsc As Boolean = True 'variabile che indica quando è possibile uscire. Faccio così per inserire anche l'ultimo elemento, che altrimenti resta fuori e mi costringe ad inserire un if then fuori dal ciclo
        'dimensiono la griglia
        DataGridView1.RowCount() = iCount

        'cicla il binding per riempire la griglia e la lista dei Comandi destinatari
        Dim i = (-1), iIDControlloTmp = -1, iIDControllo
        Dim bFlag As Boolean = True 'usato per alternare stile

        QAllegatoABindingSource.MoveFirst()
        drv = QAllegatoABindingSource.Current()
        If (Not drv Is Nothing And iCount > 0) Then bEsc = False

        If (Not bEsc) Then
            'DATI DEL CONTROLLO
            '===========================
            With parametriContr
                .dataOS = FormatDateTime(drv.Item("dataora"), DateFormat.ShortDate)
                .dataoraControllo = FormatDateTime(drv.Item("dataora"), DateFormat.ShortTime)
                .nomeLuogoControllo = feActions.valoreDrv(drv, "luogo")
            End With
            '===========================
        End If
        While (Not bEsc)
            Dim p As New parametriPersona()
            drv = QAllegatoABindingSource.Current()
            If (drv IsNot Nothing) Then
                i = i + 1
                Dim datanascita = ""
                Try
                    datanascita = FormatDateTime(drv.Item("datanascita"), DateFormat.ShortDate)
                    ' INSERISCO DATI PERSONA
                    p.datanascita = datanascita
                Catch
                End Try
                Dim sValore As String
                sValore = drv.Item("cognome") & " " & drv.Item("nome") & " nato a " & drv.Item("cittanascita") & " il " & drv("datanascita") & ", residente a " & drv.Item("cittaresidenza") & " in via " & drv.Item("residenzaindirizzo")

                'DATAGRID
                DataGridView1.Item("generalita", i).Value = sValore
                iIDControllo = drv.Item("idControllo")
                'campo invisibile
                DataGridView1.Item("idControllo", i).Value = iIDControllo

                '---CAMBIO LO STILE RIGA IN BASE AL CONTROLLO
                'se il controllo cambia allora cambio stile
                If (iIDControllo <> iIDControlloTmp) Then bFlag = Not bFlag
                If (bFlag) Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Lavender
                Else
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FloralWhite
                End If
                iIDControlloTmp = iIDControllo
                '-----------------

                'Se arrivo a fine lista metto la boolean a true
                If (QAllegatoABindingSource.Position = iCount - 1) Then bEsc = True
                QAllegatoABindingSource.MoveNext()
            Else
                bEsc = True
            End If
        End While

        'list box Comandi destinatari, selezione persone dello stesso controllo sul datagridview e predisposizione listaPersone per OP85
        If (iCount > 0) Then
            aggiornaComandiDestinatari(DataGridView1)
            selezionaPersoneStessoControllo(Me.DataGridView1)
            btnAnteprimaOp85.Enabled = True
        Else
            btnAnteprimaOp85.Enabled = False
        End If
        '==== LEGGO VALORE PROTOCOLLO ARMA
        tbProt.Text = My.MySettings.Default.protocolloOP85
        '=================================


    End Sub

    Private Sub aggiornaComandiDestinatari(ByVal mDatagrid As DataGridView)
        'numero totale righe
        Dim iCount As Integer = QAllegatoABindingSource.Count
        Dim bEsc As Boolean 'variabile che indica quando è possibile uscire. Faccio così per inserire anche l'ultimo elemento, che altrimenti resta fuori e mi costringe ad inserire un if then fuori dal ciclo
        Dim drv As DataRowView
        Dim i, iIDControlloRiferimento, iIDControllo As Integer

        'Cancella tutte le voci
        lbComandiDestinatari.Items.Clear()
        Try
            i = mDatagrid.CurrentRow().Index()
        Catch ex As Exception
            i = 0
        End Try

        'IdControllo selezionato
        iIDControlloRiferimento = mDatagrid.Item("idControllo", i).Value

        'mi posizioni all'inizio della tabella
        QAllegatoABindingSource.MoveFirst()
        While (Not bEsc)
            drv = QAllegatoABindingSource.Current()
            i = i + 1
            iIDControllo = drv.Item("idControllo")
            If (iIDControllo = iIDControlloRiferimento) Then
                Dim s As String = drv.Item("cittaresidenza").ToString
                'aggiungo riga a list box Comandi destinatari
                If (s.Trim.Length > 0) Then
                    If (lbComandiDestinatari.FindStringExact(s) < 0) Then lbComandiDestinatari.Items().Add(s)
                End If
            End If
            '-----------------
            'Se arrivo a fine lista metto la boolean a true
            If (QAllegatoABindingSource.Position = iCount - 1) Then bEsc = True
            QAllegatoABindingSource.MoveNext()
        End While

    End Sub

    Public Sub New(ByVal p As parametriControllo_e_OS)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        xOS = p.idOS
        parametriContr = p
        'esitoSDI = New tipoEsitoSDI()
        feActions = New OrSe.ActionsLibrary()
        parametri = New parametriOP85()
        parametri.nomeClasse = "op85"

    End Sub

    Private Sub btnAnteprimaOp85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnteprimaOp85.Click
        Dim parametri As parametriOP85 = New parametriOP85()
        parametri.protocollo = tbProt.Text
        parametri.protocolloInformatico = tbProtInf.Text
        '---------- AGGIUNGE I COMANDI DESTINATARI ALLA CLASSE PARAMETRI

        '---------- AGGIUNGE NOTE ALLA CLASSE PARAMETRI
        parametri.sNote = cbNote.Text

        Dim iID As Integer = DataGridView1.Item("idControllo", DataGridView1.CurrentRow.Index()).Value
        '        feActions.doApriFormAnteprima(iID, parametri, tipoReport.op85)

        'listaPersone
        'parametri (contiene: protocollo, protInf, comandi destinatari
        'parametriContr
        Dim feActions As New OrSe.ActionsLibrary
        Try
            log.xlogWriteEntry("Word - Preparazione per generazione OP85", TraceEventType.Critical)
            Dim oWord As Microsoft.Office.Interop.Word.Application = feActions.wordInizializzaDocumentoOP85(listaPersoneOP85.Item(0).cognome)

            feActions.wordScriviSegnalibro(oWord, "regione", My.Settings.regione)
            feActions.wordScriviSegnalibro(oWord, "comando", My.Settings.comando)
            feActions.wordScriviSegnalibro(oWord, "comando2", My.Settings.comandoSecondaRiga)

            feActions.wordScriviSegnalibro(oWord, "comune", My.Settings.comune)



            feActions.wordScriviSegnalibro(oWord, "protocollo", parametri.protocollo)
            feActions.wordScriviSegnalibro(oWord, "protocolloinformatico", parametri.protocolloInformatico)
            '= INDIRIZZI ==================================================
            Dim n As Integer = lbComandiDestinatari.Items.Count
            For i As Integer = 0 To n - 1
                feActions.wordScriviSegnalibro(oWord, "destinatari", My.Settings.prefissoIndirizzoStazioneCC.ToString)
                feActions.wordScrivi(oWord, Chr(9) & lbComandiDestinatari.Items().Item(i))
                feActions.wordScriviEnter(oWord)
            Next
            '===================================================

            feActions.wordScriviSegnalibro(oWord, "dataora", FormatDateTime(parametriContr.dataoraControllo, DateFormat.ShortDate) & ", ore " & FormatDateTime(parametriContr.dataoraControllo, DateFormat.ShortTime))
            feActions.wordScriviSegnalibro(oWord, "luogocontrollo", parametriContr.nomeLuogoControllo)
            feActions.wordScriviSegnalibro(oWord, "operatori", parametriContr.nomeOperatore)
            feActions.wordScriviSegnalibro(oWord, "motivoControllo", parametri.sNote)
            feActions.wordScriviSegnalibro(oWord, "OS", parametriContr.nomeOS)

            'PERSONA - SOLO LA PRIMA
            feActions.wordScriviSegnalibro(oWord, "mezzo", listaPersoneOP85.Item(0).mezzo)
            feActions.wordScriviSegnalibro(oWord, "colore", listaPersoneOP85.Item(0).colore)
            feActions.wordScriviSegnalibro(oWord, "targa", listaPersoneOP85.Item(0).targa)
            riempiDatiPersona(oWord, listaPersoneOP85, 0)
            Dim accompagnatori As String = ""
            If (listaPersoneOP85.Count > 0) Then
                '=== ACCOMPAGNATORI====
                For i As Integer = 1 To listaPersoneOP85.Count - 1
                    accompagnatori = accompagnatori & listaPersoneOP85.Item(i).cognome.ToUpper & " " & listaPersoneOP85.Item(i).nome.ToUpper & ", nato a " & listaPersoneOP85.Item(i).luogonascita & " il " & listaPersoneOP85.Item(i).datanascita & ", residente in  " & listaPersoneOP85.Item(i).residenza
                    Dim sTmp As String
                    If (listaPersoneOP85.Item(i).precedenti.Trim.Length = 0) Then
                        sTmp = " - negativo"
                    Else
                        sTmp = " - positivo: " & listaPersoneOP85.Item(i).precedenti
                    End If
                    accompagnatori = accompagnatori & sTmp & Chr(13)
                Next
                '======================
            End If
            feActions.wordScriviSegnalibro(oWord, "accompagnatori", accompagnatori)
            If (My.Settings.ComandanteTitolare.ToString.Equals("True")) Then
                feActions.wordScriviSegnalibro(oWord, "comandante", My.Settings.GruppoFirmaRiga1)
                feActions.wordScriviEnter(oWord)
                feActions.wordScrivi(oWord, My.Settings.GruppoFirmaRiga2)
            Else
                feActions.wordScriviSegnalibro(oWord, "comandante", My.Settings.GruppoFirmaInterinaleRiga1)
                feActions.wordScriviEnter(oWord)
                feActions.wordScrivi(oWord, My.Settings.GruppoFirmaInterinaleRiga2)
            End If

            'attiva il documento, rendendolo visibile
            feActions.wordAttivaDocumento(oWord)
        Catch ex As Exception
            log.xlogWriteException(ex, TraceEventType.Error, "Word - Inizializza documento OP85 - Errore")
            Throw New eccezione(ex, "Generazione OP85 - Errore - E' probabile che Microsoft Word non sia installato, oppure che le licenze siano scadute")
        End Try
    End Sub

    Private Sub riempiDatiPersona(ByVal oword As Microsoft.Office.Interop.Word.Application, ByVal l As List(Of parametriPersona), ByVal i As Integer)
        feActions.wordScriviSegnalibro(oWord, "cognome", listaPersoneOP85.Item(i).cognome)
        feActions.wordScriviSegnalibro(oWord, "nome", listaPersoneOP85.Item(i).nome)
        feActions.wordScriviSegnalibro(oWord, "datanascita", listaPersoneOP85.Item(i).datanascita)
        feActions.wordScriviSegnalibro(oWord, "luogonascita", listaPersoneOP85.Item(i).luogonascita)
        feActions.wordScriviSegnalibro(oWord, "residenza", listaPersoneOP85.Item(i).residenza)
        If (l.Item(i).precedenti.Trim.Length = 0) Then
            feActions.wordScriviSegnalibro(oword, "SDI", "negativo")
        Else
            feActions.wordScriviSegnalibro(oword, "SDI", "positivo: " & listaPersoneOP85.Item(i).precedenti)
        End If
    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAggiungi.Click
        lbComandiDestinatari.Items.Add(tbComandiDestinatari.Text())
    End Sub


    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        'list box Comandi destinatari
        aggiornaComandiDestinatari(Me.DataGridView1)
    End Sub

    Private Sub selezionaPersoneStessoControllo(ByVal mDatagrid As DataGridView)
        Dim id As Integer
        'leggo l'id della riga solo se ce n'è una selezionata, altrimenti va in errore
        id = mDatagrid.Item("idControllo", mDatagrid.CurrentRow.Index()).Value
        Dim i As Integer
        For i = 0 To mDatagrid.RowCount() - 1
            If (mDatagrid.Item("idControllo", i).Value = id) Then
                mDatagrid.Rows(i).Selected = True
            End If
        Next

        Dim drv As DataRowView

        Dim iCount As Integer = QAllegatoABindingSource.Count
        Dim bEsc As Boolean = True

        'cicla il binding per riempire la lista
        If (iCount > 0) Then bEsc = False
        Dim iIDControlloTmp = -1
        i = (-1)

        'QAllegatoABindingSource.MoveFirst()

        Dim iteratore As IEnumerator = QAllegatoABindingSource.GetEnumerator()
        iteratore.Reset()
        bEsc = Not iteratore.MoveNext()
        'DATI DEL CONTROLLO
        listaPersoneOP85.Clear()
        While (Not bEsc)
            Dim p As parametriPersona = New parametriPersona
            '  drv = QAllegatoABindingSource.Current()

            drv = iteratore.Current
            If (drv IsNot Nothing And drv.Item("idControllo") = id) Then
                aggiornaParametriControllo(drv, parametriContr)
                i = i + 1
                Dim datanascita = ""
                Try
                    datanascita = FormatDateTime(drv.Item("datanascita"), DateFormat.ShortDate)
                    ' INSERISCO DATI PERSONA
                    p.datanascita = datanascita
                Catch
                End Try
                'Dim sValore As String
                'sValore = drv.Item("cognome") & " " & drv.Item("nome") & " nato a " & drv.Item("cittanascita") & " il " & drv("datanascita") & ", residente a " & drv.Item("cittaresidenza") & " in via " & drv.Item("residenzaindirizzo")
                ' INSERISCO DATI PERSONA
                '=======================
                With p
                    .cognome = feActions.valoreDrv(drv, "cognome")
                    .nome = feActions.valoreDrv(drv, "nome")
                    .luogonascita = feActions.valoreDrv(drv, "cittanascita")
                    .datanascita = feActions.valoreDrv(drv, "datanascita")
                    .residenza = feActions.valoreDrv(drv, "residenzaindirizzo") & " - " & feActions.valoreDrv(drv, "cittaresidenza")
                    .precedenti = feActions.valoreDrv(drv, "precedenti")
                    .mezzo = feActions.valoreDrv(drv, "mezzo")

                    .colore = feActions.valoreDrv(drv, "colore")
                    .targa = feActions.valoreDrv(drv, "targa")
                End With
                '=======================

                'Se arrivo a fine lista metto la boolean a true
                If (QAllegatoABindingSource.Position = iCount - 1) Then bEsc = True
                listaPersoneOP85.Add(p)
            End If

            bEsc = Not iteratore.MoveNext()
        End While


    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'evidenzia le persone che fanno parte dello stesso controllo su strada
        selezionaPersoneStessoControllo(Me.DataGridView1)
    End Sub
    Sub aggiornaParametriControllo(ByVal drv As DataRowView, ByVal p As parametriControllo_e_OS)
        parametriContr.dataoraControllo = feActions.valoreDrv(drv, "dataora")
        parametriContr.nomeLuogoControllo = feActions.valoreDrv(drv, "luogo")

    End Sub
End Class
