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
    End Sub

    Public Sub dataGridFillByOS(ByVal datagridFPrima As tipoDato, ByVal xiOS As Integer)
        If (Not xiOS = Nothing) Then
            Select Case datagridFPrima
                Case tipoDato.allegatoA
                    Me.QAllegatoATableAdapter.FillByOS(Me.DbAlegatoADataSet.QAllegatoA, xiOS)
                Case tipoDato.interventi
                    'la tabella Interventi contiene anche le informazioni, il filtro è a livello di datagrid
                    Me.QInterventiTableAdapter.FillByOSOrderByDataInizio(Me.DbAlegatoADataSet.QInterventi, xiOS)
            End Select
        End If
    End Sub

    Public Sub New(ByVal iIdOS As Integer)
        iId = iIdOS
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
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
                    dgv.Rows(i).DividerHeight() = My.Settings.altezzaRigaDivisioneRigheDataGrigInterventi_IntervalliLibero
                End If
            Next
            dgv.DataSource = ds
        Catch ex As Exception

        End Try
    End Sub

    Private Sub interventiDataGrid_RowDividerDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowDividerDoubleClickEventArgs) Handles DataGridViewInterventi.RowDividerDoubleClick

        Dim messageBoxVB As New System.Text.StringBuilder()
        messageBoxVB.AppendFormat("{0} = {1}", "RowIndex", e.RowIndex)
        messageBoxVB.AppendLine()
        messageBoxVB.AppendFormat("{0} = {1}", "Handled", e.Handled)
        messageBoxVB.AppendLine()
        messageBoxVB.AppendFormat("{0} = {1}", "Button", e.Button)
        messageBoxVB.AppendLine()
        messageBoxVB.AppendFormat("{0} = {1}", "Clicks", e.Clicks)
        messageBoxVB.AppendLine()
        messageBoxVB.AppendFormat("{0} = {1}", "X", e.X)
        messageBoxVB.AppendLine()
        messageBoxVB.AppendFormat("{0} = {1}", "Y", e.Y)
        messageBoxVB.AppendLine()
        messageBoxVB.AppendFormat("{0} = {1}", "Delta", e.Delta)
        messageBoxVB.AppendLine()
        messageBoxVB.AppendFormat("{0} = {1}", "Location", e.Location)
        messageBoxVB.AppendLine()
        MessageBox.Show(messageBoxVB.ToString(), "RowDividerDoubleClick Event")




        Dim dFine, dInizio As Date
        Dim dgv As DataGridView = sender
        Dim iRiga = e.RowIndex
        If (iRiga >= 0) Then
            dFine = FormatDateTime(dgv.Item("dataoraFine", iRiga).Value, DateFormat.GeneralDate)
            dInizio = FormatDateTime(dgv.Item("dataoraInizio", iRiga + 1).Value, DateFormat.GeneralDate)
            log.xlogWriteEntry("Apertura 'intervento' su intervallo libero: " & dInizio.ToString & " - " & dFine.ToString, TraceEventType.Information)
            'inizio e fine sono relativi devono essere invertiti, perchè devono rappresentare inizio e fine del nuovo intervento
            feActions.doApriFormInterventoInformazioni(dFine, dInizio, iId, paragrafoOS.interventi)
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
        Dim a As System.Windows.Forms.AccessibleObject = dgv.Rows(e.RowIndex).AccessibilityObject
        If (pMousecoord.Y <= a.Bounds.Bottom - My.Settings.altezzaRigaDivisioneRigheDataGrigInterventi_IntervalliLibero) Then
            'modifica cella. controllo le coordinate per filtrare i click sulla riga di divisione delle celle
            feActions.doApriDettaglioIntervento(sender, e, nomeColonnaId)
        End If
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
End Class