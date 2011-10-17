Public Class FPrima
    Dim feActions As New OrSe.ActionsLibrary
    Dim appPatch As New OrSe.ApplicazionePatch
    Dim infoScreen As New InfoScreen
    Dim parametri As New parametriControllo
    Dim log As New XOrseLog
    Dim modalitaVisita As Boolean
    Public Sub New()

        Dim compatta As New CompattaRipristina
        Try
            log.xlogWriteEntry("Compatta DB", TraceEventType.Information)
            compatta.DoAction()
        Catch ex As Exception
            log.xlogWriteException(ex, TraceEventType.Warning, "Compatta DB - Errore")
        End Try

        '======= Controlla la versione del software e si cura di effettuare eventuali modifiche sul DB)
        Dim versioneDBattuale As Double = appPatch.doControlloVersioneDB()
        '===========================================================================================
        If (Double.Parse(My.Settings.versioneDB.Replace(".", ",")) > versioneDBattuale) Then
            Dim s As New InfoScreen
            s.aggiornamentoDB(My.Settings.versioneDB)
            'lanciare aggiornaVersioneDB indicando la vecchia versione rilevata
            appPatch.aggiornaversioneVersioneDB(versioneDBattuale)
        End If

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        'se il parametro è a true allora visualizzo i report in prima pagina, altrimenti metto tutto a visible=false
        If (My.MySettings.Default.display_reportPrimaPagina = True) Then
            TableLayoutPanelRiepilogoInserimenti.Visible = True
            BtnVedi.Visible = False

        Else
            TableLayoutPanelRiepilogoInserimenti.Visible = False
            BtnVedi.Visible = True

        End If

    End Sub

    Private Sub Form1_myInit()
        'posizioni il cursore sull'ordine di servizio corrente
        Dim nIdOS = OrdineServizioTableAdapter.FillByID(DbAlegatoADataSet_Unico.ordineServizio, parametri.idOS)
        If nIdOS = 1 Then log.xlogWriteEntry("Ordine di servizio id nr." & parametri.idOS & " selezionato (" & parametri.nomeOS & " del " & parametri.dataOS & ")", TraceEventType.Information)
        textBoxInfoOS.Text = "Ordine di servizio: " + parametri.nomeOS + " del " + FormatDateTime(parametri.dataOS, DateFormat.ShortDate)
        feActions.setStandardFormSize(Me)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbAlegatoADataSet_Unico.QOrdineServizio' table. You can move, or remove it, as needed.
        caricaFinestraDatiOS()

        QInterventi_informazioniBindigSource.Filter = "iParagrafo=" & paragrafoOS.informazioni
        QInterventiBindingSource.Filter = "iParagrafo=" & paragrafoOS.interventi

        'Beta ======
        ExportToolStripMenuItem.Visible = True
        ImportToolStripMenuItem.Visible = True
        '===========
#If DEBUG Then

        ToolStripSeparator3.Visible = True
        ToolStripMenuItemLOG.Visible = True
        FinestraDiTestToolStripMenuItem.Visible = True

        '#ElseIf  Then

#End If
    End Sub

    Private Sub caricaFinestraDatiOS()
        Dim myform As New DInsDatiPreliminari(DbAlegatoADataSet_Unico, parametri)
        log.xlogWriteEntry("Visualizza form per ins. dati preliminari", TraceEventType.Information)
        myform.ShowDialog()
        While (myform.DialogResult() = Windows.Forms.DialogResult.Cancel)
            log.xlogWriteEntry("Form per ins. dati preliminari restituisce Cancel", TraceEventType.Information)
            myform.ShowDialog()
        End While
        If (myform.DialogResult() <> Windows.Forms.DialogResult.Abort) Then
            log.xlogWriteEntry("Avvio", TraceEventType.Information)
            parametri = myform.getResultClassParametri()
            setModalitaVisita(False)
            Form1_myInit()
        Else
            parametri.idOS = -1
            log.xlogWriteEntry("Form per ins. dati preliminari restituisce Abort, pertanto app. avvia in modalità visita", TraceEventType.Information)
            setmodalitaVisita(True)
        End If
    End Sub

    Private Sub btnIntervento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntervento.Click
        log.xlogWriteEntry("Apertura intervento", TraceEventType.Information)
        feActions.doApriFormInterventoInformazioni(parametri.idOS, paragrafoOS.interventi)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformazioni.Click
        log.xlogWriteEntry("Apertura informazioni", TraceEventType.Information)
        feActions.doApriFormInterventoInformazioni(parametri.idOS, paragrafoOS.informazioni)
    End Sub

    'RICHIESTA CONFERMA CANCELLAZIONE RIGA
    Dim bEliminare = False
    Public Sub InterventiDataGrid_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridViewInterventi.UserDeletingRow
        'sub eseguita PRIMA della cancellazione
        iDeleted = DataGridViewInterventi.Item(DataGridViewInterventi.Columns("iddgvInterventi").Index(), DataGridViewInterventi.SelectedRows(0).Index()).Value()
        log.xlogWriteEntry("Cancellazione intervento ", TraceEventType.Critical)

        If (MsgBox("Eliminare riga?", MsgBoxStyle.OkCancel, "Cancellazione riga") = MsgBoxResult.Ok) Then
            bEliminare = True
        End If
    End Sub
    Public Sub InformazioniDataGrid_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridViewInformazioni.UserDeletingRow
        'sub eseguita PRIMA della cancellazione
        iDeleted = DataGridViewInformazioni.Item(DataGridViewInformazioni.Columns("iddgvInfo").Index(), DataGridViewInformazioni.SelectedRows(0).Index()).Value()
        log.xlogWriteEntry("Cancellazione intervento ", TraceEventType.Critical)

        If (MsgBox("Eliminare riga?", MsgBoxStyle.OkCancel, "Cancellazione riga") = MsgBoxResult.Ok) Then
            bEliminare = True
        End If
    End Sub
    'CANCELLAZIONE RIGA
    Public Sub InterventiDataGrid_UserDeletedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridViewInterventi.UserDeletedRow, DataGridViewInformazioni.UserDeletedRow
        'sub eseguita DOPO la cancellazione
        Try
            If (bEliminare) Then
                Me.InterventiTableAdapter.FillByID(Me.DbAlegatoADataSet_Unico.interventi, iDeleted)
                Me.DbAlegatoADataSet_Unico.interventi.Rows(0).Delete()
                Me.InterventiTableAdapter.Update(Me.DbAlegatoADataSet_Unico.interventi)
            End If
            log.xlogWriteEntry("Cancellazione intervento - UserDeletedRow - Eliminato=" + bEliminare.ToString, TraceEventType.Critical)
        Catch ex As Exception
            log.xlogWriteException(ex, TraceEventType.Error, "Errore cancellazione intervento")
        End Try
    End Sub


    Public Sub SoggettiDataGridView_UserDeletedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridViewAllegatoA.UserDeletedRow
        'sub eseguita DOPO la cancellazione
        Try
            If (bEliminare) Then
                'Query che restituisce un'unica riga
                Me.AllegatoATableAdapter.FillById(Me.DbAlegatoADataSet_Unico.allegatoA, iDeleted)
                'cancello la riga 0
                Me.DbAlegatoADataSet_Unico.allegatoA.Rows(0).Delete()
                Me.AllegatoATableAdapter.Update(Me.DbAlegatoADataSet_Unico.allegatoA)
            End If
            log.xlogWriteEntry("Cancellazione soggetto - UserDeletedRow - Eliminato=" & bEliminare.ToString, TraceEventType.Critical)
        Catch ex As Exception
            log.xlogWriteException(ex, TraceEventType.Error, "Errore cancellazione soggetto")
        End Try

    End Sub

    Dim iDeleted As Integer = -1
    Public Sub SoggettiDataGridView_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridViewAllegatoA.UserDeletingRow
        Dim sOS, sCognome, sNome As String
        sOS = DataGridViewAllegatoA.Item(DataGridViewAllegatoA.Columns("nomeOS").Index(), DataGridViewAllegatoA.SelectedRows(0).Index()).Value()
        sCognome = DataGridViewAllegatoA.Item(DataGridViewAllegatoA.Columns("nome").Index(), DataGridViewAllegatoA.SelectedRows(0).Index()).Value()
        sNome = DataGridViewAllegatoA.Item(DataGridViewAllegatoA.Columns("cognome").Index(), DataGridViewAllegatoA.SelectedRows(0).Index()).Value()


        iDeleted = DataGridViewAllegatoA.Item(DataGridViewAllegatoA.Columns("cId").Index(), DataGridViewAllegatoA.SelectedRows(0).Index()).Value()
        'sub eseguita PRIMA della cancellazione
        If (MsgBox("Eliminare riga?", MsgBoxStyle.OkCancel, "Cancellazione riga") = MsgBoxResult.Ok) Then
            bEliminare = True
        End If
        log.xlogWriteEntry("Cancellazione soggetto - """ & sOS & " " & sCognome & " " & sNome & """ - UserDeletingRow - MsgBox -->" & bEliminare, TraceEventType.Critical)
    End Sub



    Private Sub checkIntervalliVuoti(ByVal dgv As DataGridView, ByVal tabella As paragrafoOS)
        Try
            Dim dInizio, dFine As Date
            Dim ds = dgv.DataSource
            For i As Integer = 0 To dgv.RowCount - 1
                Select Case tabella
                    Case paragrafoOS.informazioni
                        dFine = FormatDateTime(dgv.Item("dataoraFineInfo", i).Value, DateFormat.GeneralDate)
                        dInizio = FormatDateTime(dgv.Item("dataoraInizioInfo", i + 1).Value, DateFormat.GeneralDate)
                    Case paragrafoOS.interventi
                        dFine = FormatDateTime(dgv.Item("dataoraFine", i).Value, DateFormat.GeneralDate)
                        dInizio = FormatDateTime(dgv.Item("dataoraInizio", i + 1).Value, DateFormat.GeneralDate)
                End Select
                Dim differenceInMinutes As Long = DateDiff(DateInterval.Minute, dFine, dInizio)
                If (differenceInMinutes > 0) Then
                    'operazione da fare per segnalare la presenza di intervalli utilizzabili
                    '===================================================
                    dgv.Rows(i).DividerHeight() = My.Settings.altezzaRigaDivisioneRigheDataGrigInterventi_IntervalliLiberi
                End If
            Next
            dgv.DataSource = ds
        Catch ex As Exception

        End Try
    End Sub

    Private Sub abilitaPulsanteOP85(ByVal b As Boolean)
        OP85ToolStripMenuItem.Enabled = b
    End Sub

    'pubblica, perchè viene utilizzata anche dal form di inserimento dei dati
    Public Sub dataGridFillByOS(ByVal datagridFPrima As tipoDato, ByVal xiOS As Integer)
        If (Not xiOS = Nothing) Then
            log.xlogWriteEntry("Fill Datagrid View by OS", TraceEventType.Information)
            Select Case datagridFPrima
                Case tipoDato.allegatoA
                    Me.QAllegatoATableAdapter.FillByOS(Me.DbAlegatoADataSet_Unico.QAllegatoA, xiOS)
                Case tipoDato.interventi
                    Me.QInterventiTableAdapter.FillByOSOrderByDataInizio(Me.DbAlegatoADataSet_Unico.QInterventi, xiOS)
            End Select
        End If
    End Sub

    Private Sub datagridFillAll(ByVal datagridFPrima As tipoDato, ByVal iPar As paragrafoOS)
        ' If (Me.rTutti.Checked) Then
        '  Me.dataGridFill(datagridFPrima)
        '  Else
        '   If (Me.rOS.Checked) Then
        Me.dataGridFillByOS(datagridFPrima, parametri.idOS)
        'Se i data grid sono vuoti allora disabilito i pulsante report OP85, altrimenti solleva eccezioni
        If (DataGridViewAllegatoA.RowCount <= 0) Then
            abilitaPulsanteOP85(False)
        Else
            abilitaPulsanteOP85(True)
        End If
        '=================================0
        checkIntervalliVuoti(DataGridViewInterventi, paragrafoOS.interventi)
        checkIntervalliVuoti(DataGridViewInformazioni, paragrafoOS.informazioni)
    End Sub

    Private Sub datagridAggiornaTuttiConFillAll()
        datagridFillAll(tipoDato.allegatoA, paragrafoOS.interventi)
        datagridFillAll(tipoDato.interventi, paragrafoOS.interventi)
        datagridFillAll(tipoDato.informazioni, paragrafoOS.informazioni)
    End Sub
    Private Sub rData_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim r As RadioButton = sender
        If r.Checked Then datagridAggiornaTuttiConFillAll()
    End Sub

    Private Sub rOS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim r As RadioButton = sender
        If r.Checked Then datagridAggiornaTuttiConFillAll()
    End Sub

    Private Sub rTutti_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim r As RadioButton = sender
        If r.Checked Then datagridAggiornaTuttiConFillAll()
    End Sub

    Private Sub btnAlegatoA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlegatoA.Click
        ' Dim timestamp As System.DateTime = System.DateTime.Now.ToString
        feActions.doApriFormAllegatoA(DbAlegatoADataSet_Unico, parametri)
    End Sub

    Private Sub genericoDataGridView_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridViewInterventi.CellPainting, DataGridViewInformazioni.CellPainting, DataGridViewAllegatoA.CellPainting
        feActions.personalizzaGrid(sender)
    End Sub


    Private Sub apriDettaglioSoggetto(ByRef dgv As DataGridView)
        Dim v As Integer = dgv.CurrentRow.Cells("cID").Value
        parametri.nomeLuogoControllo = dgv.CurrentRow.Cells("cLuogoControllo").Value
        parametri.dataoraControllo = dgv.CurrentRow.Cells("cOra").Value
        feActions.doApriDettaglioSoggetto(DbAlegatoADataSet_Unico, parametri, v)
    End Sub
    Private Sub SoggettiDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewAllegatoA.CellDoubleClick
        Dim dgv As DataGridView = sender
        apriDettaglioSoggetto(dgv)
    End Sub

    Private Sub OpzioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpzioniToolStripMenuItem.Click
        feActions.doApriFormOpzioni()
    End Sub

    Private Sub InterventiDataGrid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewInterventi.CellDoubleClick
        DataGridClickAperturaDettaglio(sender, e, "iddgvInterventi")
    End Sub
    Private Sub InformazioniDataGrid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewInformazioni.CellDoubleClick
        DataGridClickAperturaDettaglio(sender, e, "iddgvInfo")
    End Sub

    Private Sub DataGridClickAperturaDettaglio(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs, ByVal nomeColonnaId As String)
        Dim dgv As DataGridView = sender
        Dim pMousecoord As System.Drawing.Point = Control.MousePosition
        Dim a As System.Windows.Forms.AccessibleObject = dgv.Rows(e.RowIndex).AccessibilityObject
        If (pMousecoord.Y <= a.Bounds.Bottom - My.Settings.altezzaRigaDivisioneRigheDataGrigInterventi_IntervalliLiberi) Then
            'modifica cella. controllo le coordinate per filtrare i click sulla riga di divisione delle celle
            feActions.doApriDettaglioIntervento(sender, e, nomeColonnaId)
        End If
    End Sub

    Private Function getModalitaVisita()
        Return modalitaVisita
    End Function

    Public Sub setModalitaVisita(ByVal b As Boolean)
        modalitaVisita = b
        b = Not b
        btnAlegatoA.Enabled = b
        btnIntervento.Enabled = b
        btnInformazioni.Enabled = b
        btnSopralluogo.Enabled = b
        btnRubrica.Enabled = b
        BtnVedi.Enabled = b
        textBoxInfoOS.Text = ""
    End Sub

    Private Sub PreferenzeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreferenzeToolStripMenuItem1.Click
        feActions.doApriFormOpzioni()
    End Sub

    Private Sub bReportAllegatoA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        feActions.doApriFormAnteprima(parametri.idOS, parametri.nomeOS, tipoReport.allegatoA)
    End Sub

    Private Sub bReportInterventi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'passo anche il nome dell'OS per non doverlo rileggere dopo dal DB
        feActions.doApriFormAnteprima(parametri.idOS, parametri.nomeOS, tipoReport.interventi)
    End Sub

    Private Sub InterventiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        'passo anche il nome dell'OS per non doverlo rileggere dopo dal DB
        feActions.doApriFormAnteprima(parametri.idOS, parametri.nomeOS, tipoReport.interventi)
    End Sub
    Private Sub InformazioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformazioniToolStripMenuItem.Click
        'passo anche il nome dell'OS per non doverlo rileggere dopo dal DB
        feActions.doApriFormAnteprima(parametri.idOS, parametri.nomeOS, tipoReport.informazioni)
    End Sub
    Private Sub AllegatoAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllegatoAToolStripMenuItem.Click
        feActions.doApriFormAnteprima(parametri.idOS, parametri.nomeOS, tipoReport.allegatoA)
    End Sub

    Private Sub OP85ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OP85ToolStripMenuItem.Click
        Dim form As System.Windows.Forms.Form
        form = New op85(parametri)
        form.Visible = True
    End Sub

    Private Sub CercaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CercaToolStripMenuItem.Click
        feActions.doApriFormRicerca()
    End Sub


    Private Sub logout()
        log.xlogWriteEntry("Logout", TraceEventType.Information)
        DbAlegatoADataSet_Unico.QInterventi.Clear()
        DbAlegatoADataSet_Unico.QAllegatoA.Clear()
        caricaFinestraDatiOS()
    End Sub


    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        logout()
    End Sub


    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        feActions.toXmlFile()
    End Sub

    Private Sub ImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportToolStripMenuItem.Click
        feActions.fromXmlFile()

    End Sub

    Private Sub CancellaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancellaToolStripMenuItem.Click
        feActions.clearDB()
        If (Not feActions.appStateLogin) Then
            logout()
        End If
    End Sub

    Private Sub CercaAggiornamentiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CercaAggiornamentiToolStripMenuItem.Click
        feActions.doUpgrade()
    End Sub


    Private Sub ToolStripMenuItemLOG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemLOG.Click
        Dim voceMenu As ToolStripMenuItem = sender
        If (voceMenu.Checked) Then
            log.xlogWriteEntry("Visualizza finestra LOG", TraceEventType.Information)
            log.show()
        Else
            log.xlogWriteEntry("Nascondi finestra LOG", TraceEventType.Information)
            log.hide()
        End If

    End Sub

    Private Sub aggiornamentoDataGrid(ByVal datagridFPrima As tipoDato)
        Me.datagridFillAll(datagridFPrima, paragrafoOS.interventi)

    End Sub

    'AGGIORNAMENTO DEL DATAGRID
    Private Sub FPrima_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        If (Not DataGridViewInterventi.DataBindings.IsSynchronized And Not getModalitaVisita()) Then aggiornamentoDataGrid(tipoDato.interventi)
        If (Not DataGridViewAllegatoA.DataBindings.IsSynchronized And Not getModalitaVisita()) Then aggiornamentoDataGrid(tipoDato.allegatoA)
        If (Not DataGridViewInformazioni.DataBindings.IsSynchronized And Not getModalitaVisita()) Then aggiornamentoDataGrid(tipoDato.informazioni)
    End Sub

    Private Sub interventiDataGrid_RowDividerDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowDividerDoubleClickEventArgs) Handles DataGridViewInterventi.RowDividerDoubleClick
        Dim dFine, dInizio As Date
        Dim dgv As DataGridView = sender
        Dim iRiga = e.RowIndex
        If (iRiga >= 0) Then
            dFine = FormatDateTime(dgv.Item("dataoraFine", iRiga).Value, DateFormat.GeneralDate)
            dInizio = FormatDateTime(dgv.Item("dataoraInizio", iRiga + 1).Value, DateFormat.GeneralDate)
            log.xlogWriteEntry("Apertura intervento su intervallo libero: " & dInizio.ToString & " - " & dFine.ToString, TraceEventType.Information)
            'inizio e fine sono relativi devono essere invertiti, perchè devono rappresentare inizio e fine del nuovo intervento
            feActions.doApriFormInterventoInformazioni(dFine, dInizio, parametri.idOS, paragrafoOS.interventi)
        End If
    End Sub
    Private Sub informazioniDataGrid_RowDividerDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowDividerDoubleClickEventArgs) Handles DataGridViewInformazioni.RowDividerDoubleClick
        Dim dFine, dInizio As Date
        Dim dgv As DataGridView = sender
        Dim iRiga = e.RowIndex
        If (iRiga >= 0) Then
            dFine = FormatDateTime(dgv.Item("dataoraFine", iRiga).Value, DateFormat.GeneralDate)
            dInizio = FormatDateTime(dgv.Item("dataoraInizio", iRiga + 1).Value, DateFormat.GeneralDate)
            log.xlogWriteEntry("Apertura informazioni su intervallo libero: " & dInizio.ToString & " - " & dFine.ToString, TraceEventType.Information)
            'inizio e fine sono relativi devono essere invertiti, perchè devono rappresentare inizio e fine del nuovo intervento
            feActions.doApriFormInterventoInformazioni(dFine, dInizio, parametri.idOS, paragrafoOS.informazioni)
        End If
    End Sub

    Private Sub VersioneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersioneToolStripMenuItem.Click
        feActions.doApriFormAbout()
    End Sub

    Private Sub EseguiBackupDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EseguiBackupDBToolStripMenuItem.Click
        feActions.doDBBackup()
    End Sub


    Private Sub RipristinaBackupDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RipristinaBackupDBToolStripMenuItem.Click
        feActions.doRipristinaDBBackup()

    End Sub

    Private Sub FPrima_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        ' 'Creating a new Rectangle as similar width and height of the base form 
        ' Dim oRAngle As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)

        'Creating a new Gradient style brush.
        'Change the colors here to get different color combination.
        '"Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal" can be changed accordingly to get different styles like
        'ForwardDiagonal, Horizontal, Vertical.
        'Dim oGradientBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(oRAngle, Color.Beige, Color.OrangeRed, Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal)

        'With the help of fillrectangle function drawing rectangle in to form
        'e.Graphics.FillRectangle(oGradientBrush, oRAngle)

    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVedi.Click
        Dim form As System.Windows.Forms.Form
        form = New FVedi(parametri)
        form.Visible = True
    End Sub

    Dim flagCheckIntervalliEseguito As Boolean = False
    Private Sub DataGridViewInterventi_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If (Not flagCheckIntervalliEseguito) Then
            log.xlogWriteEntry("evento Paint su scheda Interventi - check intervalli vuoti", TraceEventType.Information)
            checkIntervalliVuoti(DataGridViewInterventi, paragrafoOS.interventi)
            flagCheckIntervalliEseguito = True
        End If
    End Sub

    Dim flagCheckInformazioniEseguito As Boolean = False
    Private Sub DataGridViewInformazioni_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If (Not flagCheckInformazioniEseguito) Then
            log.xlogWriteEntry("evento Paint su scheda Informazioni - check intervalli vuoti", TraceEventType.Information)
            checkIntervalliVuoti(DataGridViewInformazioni, paragrafoOS.informazioni)
            flagCheckInformazioniEseguito = True
        End If
    End Sub


    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSopralluogo.Click
        log.xlogWriteEntry("Apertura sopralluogo", TraceEventType.Information)
        feActions.doApriFormSopralluogo(parametri.idOS, parametri.nomeOperatore)
    End Sub

    Private Sub ButtonRubrica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRubrica.Click, ButtonRubrica.Click
        log.xlogWriteEntry("Apertura rubrica", TraceEventType.Information)
        feActions.doApriFormRubrica(parametri.idOS)
    End Sub


End Class

