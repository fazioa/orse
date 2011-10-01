Public Class FVedi
    Dim feActions As New OrSe.ActionsLibrary
    Dim parametri As New parametriControllo
    Dim iId As Integer
    Dim log As New XOrseLog
    Dim iDeleted As Integer = -1

    Private Sub FVedi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        QInterventi_informazioniBindigSource.Filter = "iParagrafo=" & paragrafoOS.informazioni
        QInterventiBindingSource.Filter = "iParagrafo=" & paragrafoOS.interventi
        Fill()

    End Sub

    Private Sub Fill()
        dataGridFillByOS(tipoDato.allegatoA, iId)
        dataGridFillByOS(tipoDato.interventi, iId)
        dataGridFillByOS(tipoDato.sopralluoghi, iId)
        dataGridFillByOS(tipoDato.rubrica, iId)
    End Sub

    Public Sub dataGridFillByOS(ByVal datagridFPrima As tipoDato, ByVal xidOS As Integer)
        If (Not xidOS = Nothing) Then
            Select Case datagridFPrima
                Case tipoDato.allegatoA
                    Me.QAllegatoATableAdapter.FillByOS(Me.DbAlegatoADataSet.QAllegatoA, xidOS)
                Case tipoDato.interventi
                    'la tabella Interventi contiene anche le informazioni, il filtro è a livello di datagrid
                    Me.QInterventiTableAdapter.FillByOSOrderByDataInizio(Me.DbAlegatoADataSet.QInterventi, xidOS)
                Case tipoDato.sopralluoghi
                    Me.SopralluogoTableAdapter.FillByOS(Me.DbAlegatoADataSet.sopralluogo, xidOS)
                Case tipoDato.rubrica
                    Me.RubricaTableAdapter.FillByOS(Me.DbAlegatoADataSet.rubrica, xidOS)
            End Select
        End If
    End Sub

    Public Sub New(ByVal iIdOS As Integer)
        iId = iIdOS
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        feActions.setStandardFormSize(Me)
        'a volte capita che la disposizione delle colonne sballi da sola. Forse un bug. La reimposto manualmente per sicurezza
        'Me.SuspendLayout()
        'Me.DataGridViewAllegatoA.Columns.Clear()
        'Me.DataGridViewAllegatoA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cLuogoControllo, Me.cOra, Me.cognome, Me.nome, Me.DataGridViewTextBoxColumn13, Me.cittanascita, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn18, Me.cID, Me.nomeOS})
        'Me.ResumeLayout()
    End Sub
    Private Sub checkIntervalliVuoti(ByVal dgv As DataGridView, ByVal tabella As paragrafoOS)
        Try
            Dim dInizio, dFine As Date
            Dim ds = dgv.DataSource
            For i As Integer = 0 To dgv.RowCount - 2
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
                    log.xlogWriteEntry("Rilevato intervallo libero (in datagrid interventi o informazioni)", TraceEventType.Information)
                    dgv.Rows(i).DividerHeight() = My.Settings.altezzaRigaDivisioneRigheDataGrigInterventi_IntervalliLiberi
                End If
            Next
            dgv.DataSource = ds
        Catch ex As Exception

        End Try
    End Sub

    Private Sub interventiDataGrid_RowDividerDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowDividerDoubleClickEventArgs) Handles DataGridViewInterventi.RowDividerDoubleClick

        Dim dFine, dInizio As Date
        Dim dgv As DataGridView = sender
        Dim iRiga = e.RowIndex
        If (iRiga >= 0) Then
            dInizio = FormatDateTime(dgv.Item("dataoraFine", iRiga).Value, DateFormat.GeneralDate)
            dFine = FormatDateTime(dgv.Item("dataoraInizio", iRiga + 1).Value, DateFormat.GeneralDate)
            log.xlogWriteEntry("Apertura 'intervento' su intervallo libero: " & dInizio.ToString & " - " & dFine.ToString, TraceEventType.Information)
            'inizio e fine sono relativi devono essere invertiti, perchè devono rappresentare inizio e fine del nuovo intervento
            feActions.doApriFormInterventoInformazioni(dInizio, dFine, iId, paragrafoOS.interventi)
        End If
    End Sub
    Private Sub informazioniDataGrid_RowDividerDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowDividerDoubleClickEventArgs) Handles DataGridViewInformazioni.RowDividerDoubleClick
        Dim dFine, dInizio As Date
        Dim dgv As DataGridView = sender
        Dim iRiga = e.RowIndex
        If (iRiga >= 0) Then
            dFine = FormatDateTime(dgv.Item("dataoraFine", iRiga).Value, DateFormat.GeneralDate)
            dInizio = FormatDateTime(dgv.Item("dataoraInizio", iRiga + 1).Value, DateFormat.GeneralDate)
            log.xlogWriteEntry("Apertura 'informazioni' su intervallo libero: " & dInizio.ToString & " - " & dFine.ToString, TraceEventType.Information)
            'inizio e fine sono relativi devono essere invertiti, perchè devono rappresentare inizio e fine del nuovo intervento
            feActions.doApriFormInterventoInformazioni(dFine, dInizio, iId, paragrafoOS.informazioni)
        End If
    End Sub


    Private Sub DataGridClickAperturaDettaglio(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs, ByVal nomeColonnaId As String)
        Dim dgv As DataGridView = sender
        Dim pMousecoord As System.Drawing.Point = Control.MousePosition
        Try
            Dim a As System.Windows.Forms.AccessibleObject = dgv.Rows(e.RowIndex).AccessibilityObject
            If (pMousecoord.Y <= a.Bounds.Bottom - My.Settings.altezzaRigaDivisioneRigheDataGrigInterventi_IntervalliLiberi) Then
                '  modifica cella. controllo le coordinate per filtrare i click sulla riga di divisione delle celle
                feActions.doApriDettaglioIntervento(sender, e, nomeColonnaId)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridViewInterventi_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewInterventi.CellDoubleClick
        DataGridClickAperturaDettaglio(sender, e, "iddgvInterventi")
    End Sub


    Private Sub DataGridViewInformazioni_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewInformazioni.CellDoubleClick
        DataGridClickAperturaDettaglio(sender, e, "iddgvInfo")
    End Sub


    Private Sub DataGridViewAllegatoA_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewAllegatoA.CellDoubleClick
        Dim dgv As DataGridView = sender
        apriDettaglioSoggetto(dgv)
    End Sub

    Private Sub apriDettaglioSoggetto(ByRef dgv As DataGridView)
        Dim v As Integer = dgv.CurrentRow.Cells("cID").Value
        parametri.nomeLuogoControllo = dgv.CurrentRow.Cells("cLuogoControllo").Value
        parametri.dataoraControllo = dgv.CurrentRow.Cells("cOra").Value
        feActions.doApriDettaglioSoggetto(DbAlegatoADataSet, parametri, v)
    End Sub

    Private Sub apriDettaglioSopralluogo(ByRef dgv As DataGridView)
        Dim v As Integer = dgv.CurrentRow.Cells("id").Value
        ' parametri.nomeLuogoControllo = dgv.CurrentRow.Cells("cLuogoControllo").Value
        ' parametri.dataoraControllo = dgv.CurrentRow.Cells("cOra").Value
        feActions.doApriDettaglioSopralluogo(v)
    End Sub

    Private Sub apriDettaglioRubrica(ByRef dgv As DataGridView)
        Dim v As Integer = dgv.CurrentRow.Cells("idRubrica").Value
        ' parametri.nomeLuogoControllo = dgv.CurrentRow.Cells("cLuogoControllo").Value
        ' parametri.dataoraControllo = dgv.CurrentRow.Cells("cOra").Value
        feActions.doApriDettaglioRubrica(v)
    End Sub
    Private Sub aggiornamentoDataGrid(ByVal datagridFPrima As tipoDato)
        Me.datagridFillAll(datagridFPrima, iId)

    End Sub
    Private Sub datagridFillAll(ByVal datagridFPrima As tipoDato, ByVal idOS As Integer)
        Me.dataGridFillByOS(datagridFPrima, idOS)
        If (datagridFPrima = tipoDato.interventi) Then
            checkIntervalliVuoti(DataGridViewInterventi, paragrafoOS.interventi)
        Else
            checkIntervalliVuoti(DataGridViewInformazioni, paragrafoOS.informazioni)
        End If
    End Sub


    Private Sub FVedi_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        If (Not DataGridViewInterventi.DataBindings.IsSynchronized) Then
            log.xlogWriteEntry("Aggiornamento DataGrid Interventi", TraceEventType.Information)
            aggiornamentoDataGrid(tipoDato.interventi)
        End If

        If (Not DataGridViewInformazioni.DataBindings.IsSynchronized) Then
            log.xlogWriteEntry("Aggiornamento DataGrid Informazioni", TraceEventType.Information)
            aggiornamentoDataGrid(tipoDato.informazioni)
        End If

        If (Not DataGridViewAllegatoA.DataBindings.IsSynchronized) Then
            log.xlogWriteEntry("Aggiornamento DataGrid AllegatoA", TraceEventType.Information)
            aggiornamentoDataGrid(tipoDato.allegatoA)
        End If

        If (Not DataGridViewSopralluogo.DataBindings.IsSynchronized) Then
            log.xlogWriteEntry("Aggiornamento DataGrid Sopralluogo", TraceEventType.Information)
            aggiornamentoDataGrid(tipoDato.sopralluoghi)
        End If

        If (Not DataGridViewRubrica.DataBindings.IsSynchronized) Then
            log.xlogWriteEntry("Aggiornamento DataGrid Rubrica", TraceEventType.Information)
            aggiornamentoDataGrid(tipoDato.rubrica)
        End If
    End Sub

    Dim flagCheckIntervalliEseguito As Boolean = False
    Private Sub DataGridViewInterventi_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridViewInterventi.Paint
        If (Not flagCheckIntervalliEseguito) Then
            log.xlogWriteEntry("evento Paint su scheda Interventi - check intervalli vuoti", TraceEventType.Information)
            checkIntervalliVuoti(DataGridViewInterventi, paragrafoOS.interventi)
            flagCheckIntervalliEseguito = True
        End If
    End Sub

    Dim flagCheckInformazioniEseguito As Boolean = False
    Private Sub DataGridViewInformazioni_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DataGridViewInformazioni.Paint
        If (Not flagCheckInformazioniEseguito) Then
            log.xlogWriteEntry("evento Paint su scheda Informazioni - check intervalli vuoti", TraceEventType.Information)
            checkIntervalliVuoti(DataGridViewInformazioni, paragrafoOS.informazioni)
            flagCheckInformazioniEseguito = True
        End If
    End Sub

  
    Private Sub DataGridViewAllegatoA_UserDeletedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridViewAllegatoA.UserDeletedRow
        'sub eseguita DOPO la cancellazione
        Try
            If (bEliminare) Then
                'Query che restituisce un'unica riga
                Me.AllegatoATableAdapter.FillById(Me.DbAlegatoADataSet.allegatoA, iDeleted)
                'cancello la riga 0
                Me.DbAlegatoADataSet.allegatoA.Rows(0).Delete()
                Me.AllegatoATableAdapter.Update(Me.DbAlegatoADataSet.allegatoA)
            End If
            log.xlogWriteEntry("Cancellazione soggetto - UserDeletedRow - Eliminato=" & bEliminare.ToString, TraceEventType.Critical)
        Catch ex As Exception
            log.xlogWriteException(ex, TraceEventType.Error, "Errore cancellazione soggetto")
        End Try
    End Sub

    Private Sub DataGridViewAllegatoA_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridViewAllegatoA.UserDeletingRow
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

    Private Sub DataGridViewInterventi_UserDeletedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridViewInterventi.UserDeletedRow
        'sub eseguita DOPO la cancellazione
        Try
            If (bEliminare) Then
                Me.InterventiTableAdapter.FillByID(Me.DbAlegatoADataSet.interventi, iDeleted)
                Me.DbAlegatoADataSet.interventi.Rows(0).Delete()
                Me.InterventiTableAdapter.Update(Me.DbAlegatoADataSet.interventi)
            End If
            log.xlogWriteEntry("Cancellazione intervento - UserDeletedRow - Eliminato=" + bEliminare.ToString, TraceEventType.Critical)
        Catch ex As Exception
            log.xlogWriteException(ex, TraceEventType.Error, "Errore cancellazione intervento")
        End Try
    End Sub

    Dim bEliminare = False
    Private Sub DataGridViewInterventi_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridViewInterventi.UserDeletingRow
        'sub eseguita PRIMA della cancellazione
        iDeleted = DataGridViewInterventi.Item(DataGridViewInterventi.Columns("iddgvInterventi").Index(), DataGridViewInterventi.SelectedRows(0).Index()).Value()
        log.xlogWriteEntry("Cancellazione intervento ", TraceEventType.Critical)

        If (MsgBox("Eliminare riga?", MsgBoxStyle.OkCancel, "Cancellazione riga") = MsgBoxResult.Ok) Then
            bEliminare = True
        End If
    End Sub

    Private Sub DataGridViewInformazioni_UserDeletedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridViewInformazioni.UserDeletedRow
        DataGridViewInterventi_UserDeletedRow(sender, e)
    End Sub

    Private Sub DataGridViewInformazioni_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridViewInformazioni.UserDeletingRow
        'sub eseguita PRIMA della cancellazione
        iDeleted = DataGridViewInformazioni.Item(DataGridViewInformazioni.Columns("iddgvInfo").Index(), DataGridViewInformazioni.SelectedRows(0).Index()).Value()
        log.xlogWriteEntry("Cancellazione intervento ", TraceEventType.Critical)

        If (MsgBox("Eliminare riga?", MsgBoxStyle.OkCancel, "Cancellazione riga") = MsgBoxResult.Ok) Then
            bEliminare = True
        End If
    End Sub

   

    Private Sub datagridviewSetup(ByVal sender As System.Object)
        Dim dgv As DataGridView = sender
        dgv.MultiSelect = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.ColumnHeadersVisible = True
        dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        'dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        dgv.RowHeadersVisible = False
        dgv.AllowUserToResizeColumns = True
        dgv.AllowUserToResizeRows = True
        dgv.AllowUserToAddRows = False
        dgv.ReadOnly = True
        '----------------
        dgv.BackgroundColor = Color.Silver
        dgv.BorderStyle = BorderStyle.FixedSingle
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgv.GridColor = Color.WhiteSmoke
        dgv.DefaultCellStyle.BackColor = Color.FloralWhite
    End Sub

    Private Sub genericoDataGridView_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridViewInterventi.CellPainting, DataGridViewInformazioni.CellPainting, DataGridViewSopralluogo.CellPainting, DataGridViewRubrica.CellPainting
        Dim dgv As DataGridView = sender
        datagridviewSetup(dgv)
        Dim stile As DataGridViewCellStyle = New DataGridViewCellStyle()
        stile.BackColor() = Color.Lavender
        dgv.AlternatingRowsDefaultCellStyle() = stile

    End Sub

    Private Sub AllegatoADataGridView_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridViewAllegatoA.CellPainting
        'colora Righe AllegatoA Raggruppandole per appartenenza allo stesso controllo

        Dim dgv As DataGridView = sender
        datagridviewSetup(dgv)

        Dim bFlag As Boolean = False
        Dim iIdcontrollo, iIDControlloTmp As Integer
        If (dgv.RowCount > 0) Then
            iIdcontrollo = dgv.Item("idControllo", 0).Value
            iIDControlloTmp = iIdcontrollo

            For i As Integer = 1 To dgv.RowCount - 1
                '---CAMBIO LO STILE RIGA IN BASE AL CONTROLLO
                'se il controllo cambia allora cambio stile
                iIdcontrollo = dgv.Item("idControllo", i).Value
                If (iIdcontrollo <> iIDControlloTmp) Then bFlag = Not bFlag

                If (bFlag) Then
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.Lavender
                Else
                    '  dgv.Rows(i).DefaultCellStyle.BackColor = Color.FloralWhite 'DEFAULT
                End If
                iIDControlloTmp = iIdcontrollo

            Next
        End If

    End Sub

    Private Sub SopralluogoDataGridView_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridViewSopralluogo.UserDeletingRow
        'sub eseguita PRIMA della cancellazione
        bEliminare = False
        iDeleted = DataGridViewSopralluogo.Item(DataGridViewSopralluogo.Columns("id").Index(), DataGridViewSopralluogo.SelectedRows(0).Index()).Value()
        log.xlogWriteEntry("Cancellazione sopralluogo ", TraceEventType.Critical)

        If (MsgBox("Eliminare riga?", MsgBoxStyle.OkCancel, "Cancellazione riga") = MsgBoxResult.Ok) Then
            bEliminare = True
        End If



    End Sub

    Private Sub DataGridViewSopralluogo_UserDeletedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridViewSopralluogo.UserDeletedRow
        Try
            If (bEliminare) Then
                Me.SopralluogoTableAdapter.FillById(Me.DbAlegatoADataSet.sopralluogo, iDeleted)
                Me.DbAlegatoADataSet.sopralluogo.Rows(0).Delete()
                Me.SopralluogoTableAdapter.Update(Me.DbAlegatoADataSet.sopralluogo)
            End If
            log.xlogWriteEntry("Cancellazione sopralluogo - UserDeletedRow - Eliminato=" + bEliminare.ToString, TraceEventType.Critical)
        Catch ex As Exception
            log.xlogWriteException(ex, TraceEventType.Error, "Errore cancellazione sopralluogo")
        End Try
        log.xlogWriteEntry("Aggiornamento DataGrid Sopralluogo", TraceEventType.Information)
        aggiornamentoDataGrid(tipoDato.sopralluoghi)

    End Sub

    Private Sub DataGridViewSopralluogo_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewSopralluogo.CellDoubleClick
        Dim dgv As DataGridView = sender
        apriDettaglioSopralluogo(dgv)
    End Sub

    Private Sub DataGridViewRubrica_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewRubrica.CellContentDoubleClick
        Dim dgv As DataGridView = sender
        apriDettaglioRubrica(dgv)
    End Sub


    Private Sub DataGridViewRubrica_UserDeletedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridViewRubrica.UserDeletedRow
        Try
            If (bEliminare) Then
                Me.RubricaTableAdapter.FillById(Me.DbAlegatoADataSet.rubrica, iDeleted)
                Me.DbAlegatoADataSet.rubrica.Rows(0).Delete()
                Me.RubricaTableAdapter.Update(Me.DbAlegatoADataSet.rubrica)
            End If
            log.xlogWriteEntry("Cancellazione voce rubrica - UserDeletedRow - Eliminato=" + bEliminare.ToString, TraceEventType.Critical)
        Catch ex As Exception
            log.xlogWriteException(ex, TraceEventType.Error, "Errore cancellazione voce rubrica")
        End Try
        log.xlogWriteEntry("Aggiornamento DataGrid rubrica", TraceEventType.Information)
        aggiornamentoDataGrid(tipoDato.rubrica)
    End Sub

    Private Sub DataGridViewRubrica_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridViewRubrica.UserDeletingRow
        'sub eseguita PRIMA della cancellazione
        bEliminare = False
        iDeleted = DataGridViewRubrica.Item(DataGridViewRubrica.Columns("idRubrica").Index(), DataGridViewRubrica.SelectedRows(0).Index()).Value()
        log.xlogWriteEntry("Cancellazione voce rubrica ", TraceEventType.Critical)
        If (MsgBox("Eliminare riga?", MsgBoxStyle.OkCancel, "Cancellazione riga") = MsgBoxResult.Ok) Then
            bEliminare = True
        End If

    End Sub
End Class