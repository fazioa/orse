Public Class FIntervento
    Dim feActions As New OrSe.ActionsLibrary()

    Dim xdDataIntervento As Date
    Dim xsOS As String
    dim xIdOS as integer
    Dim bNuovoIntervento As Boolean = False
    Dim dlInizio, dlFine As New Date
    Dim xlTipo As paragrafoOS
    Dim log As New XOrseLog
    Dim xidIntervento As Integer
    'modifica
    ' Public Sub New(ByVal idOS As Integer, ByVal tipo As paragrafoOS)
    ''      sharedNew(Nothing, Nothing, idOS, tipo)
    ' End Sub

    'nuovo inserimento
    Public Sub New(ByVal dInizio As Date, ByVal dFine As Date, ByVal idOS As Integer, ByVal tipo As paragrafoOS)
        sharedNew(dInizio, dFine, idOS, tipo)
    End Sub

    Private Sub sharedNew(ByVal dInizio As Date, ByVal dFine As Date, ByVal idOS As Integer, ByVal tipo As paragrafoOS)
        xlTipo = tipo
        dlInizio = dInizio
        dlFine = dFine

        'esegue qui se è un nuovo intervento
        myInitializeComponent()
        feActions.setStandardFormSize(Me)

        Me.OrdineServizioTableAdapter.FillByID(Me.DbAlegatoADataSet.ordineServizio, idOS)
        Me.InterventiBindingSource.AddNew()
        feActions.scriviCampoDB(InterventiBindingSource, "idOrdineServizio", idOS)
        'salvo l'id dell'OS
        xIdOS = idOS

        Select Case tipo
            Case paragrafoOS.informazioni
                feActions.scriviCampoDB(InterventiBindingSource, "iParagrafo", paragrafoOS.informazioni)

            Case paragrafoOS.interventi
                feActions.scriviCampoDB(InterventiBindingSource, "iParagrafo", paragrafoOS.interventi)
        End Select

        Me.xdDataIntervento = feActions.leggiCampoDB(OrdineServizioBindingSource, "data")
        Me.xsOS = feActions.leggiCampoDB(OrdineServizioBindingSource, "nome")

        LabelData.Text = xdDataIntervento.Date
        labelOS.Text = xsOS

        bNuovoIntervento = True

    End Sub
    Sub myInitializeComponent()
        InitializeComponent()
        tbTipoServizio.MaxLength = DbAlegatoADataSet.interventi.tipointerventoColumn.MaxLength
        tbResoconto.MaxLength = DbAlegatoADataSet.interventi.resocontoColumn.MaxLength
    End Sub
    'Modifica. Coincidevano le firme. Aggiungo z solo per differenziarle, non ho voglia di escogitare altro
    Public Sub New(ByVal id As Integer, ByVal z As Boolean)
        myInitializeComponent()
        feActions.setStandardFormSize(Me)
        xidIntervento = id
        feActions = New OrSe.ActionsLibrary()
        Me.InterventiTableAdapter.FillByID(DbAlegatoADataSet.interventi, id)

    End Sub

    Private Sub FIntervento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        feActions = New OrSe.ActionsLibrary()

        If bNuovoIntervento Then

            If (dlInizio = Nothing Or dlFine = Nothing) Then
                DateTimePickerOraInizio.Value = My.Computer.Clock.LocalTime
                DateTimePickerOraFine.Value = My.Computer.Clock.LocalTime
                'ora fine automatica
                Timer1.Start()
                Me.GroupBoxOraFine.Enabled = False 'gruppo disabilitato
            Else
                'caso dell'inserimento dell'intervento cliccando su un intervallo di tempo libero

                DateTimePickerOraInizio.Value = dlInizio
                DateTimePickerOraFine.Value = dlFine
                'imposto la data di fine a 'manuale'
                'ho copiato il codice da altre parti del file. Non è una bella soluzione ma risolvo così e non perdo tempo
                Me.LabelOraFine.Text = "Fine"
                Me.btnAutoOraFine.Visible = False
                Me.GroupBoxOraFine.Enabled = True 'gruppo abilitato
            End If



            'il salvataggio automatico funziona solo se si tratta di un nuovo intervento/informazione
            'imposto l'intervallo per il salvataggio automatico al valore delle impostazioni (in secondi)
            If (Integer.Parse(My.Settings.intervalloSalvataggioAutomatico) > 0) Then
                TimerSalvataggioAutomatico.Interval = My.Settings.intervalloSalvataggioAutomatico * 1000
                TimerSalvataggioAutomatico.Start()
            End If

        Else
            'esegue qui se NON è un nuovo intervento
            'leggo l'id l'ordine di servizio
            Dim idOS = feActions.leggiCampoDB(InterventiBindingSource, "idOrdineServizio")
            'cerco l'os
            Me.OrdineServizioTableAdapter.FillByID(Me.DbAlegatoADataSet.ordineServizio, idOS)
            'leggo data e nome
            Dim data As DateTime = feActions.leggiCampoDB(OrdineServizioBindingSource, "data")
            LabelData.Text = data.Date
            labelOS.Text = feActions.leggiCampoDB(OrdineServizioBindingSource, "nome")

            'cambia il testo del label
            Me.LabelOraFine.Text = "Fine"
            Me.btnAutoOraFine.Visible = False
            Me.GroupBoxOraFine.Enabled = True 'gruppo abilitato
        End If

        Select Case xlTipo
            Case paragrafoOS.informazioni
                Me.Text = "Par.6 - Informazioni"
                LabelTipoIntervento.Text = "Sintesi Informazione"
            Case paragrafoOS.interventi
                Me.Text = "Par.9 - Interventi"
                LabelTipoIntervento.Text = "Tipo Intervento"
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DateTimePickerOraFine.Value = My.Computer.Clock.LocalTime
    End Sub


    Private Sub btnAutoOraFine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoOraFine.Click
        If (bNuovoIntervento) Then
            'è un nuovo intervento
            Me.GroupBoxOraFine.Enabled = Not Me.GroupBoxOraFine.Enabled
            If (Me.GroupBoxOraFine.Enabled) Then
                Timer1.Stop()
                Me.LabelOraFine.Text = "Fine manuale"
                Me.btnAutoOraFine.Text = "Auto"
            Else
                Timer1.Start()
                Me.LabelOraFine.Text = "Fine automatica"
                Me.btnAutoOraFine.Text = "Manuale"
            End If
        Else
            ' NON è un nuovo intervento - apertura vecchio record
            Me.GroupBoxOraFine.Enabled = False 'gruppo sempre disabilitato
            Me.btnAutoOraFine.Visible = False
            Timer1.Stop() 'timer sempre stop
            Me.LabelOraFine.Text = "Fine"
        End If
    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        salva()
        Me.Close()
    End Sub


    Private Sub salva()
        Try
            ' Me.InterventiTableAdapter.Insert(DateTimePickerOraInizio.Value, DateTimePickerOraFine.Value, tbTipoServizio.Text, tbResoconto.Text, xIdOS, xlTipo)
            Me.Validate()
            Me.InterventiBindingSource.EndEdit()
            Me.InterventiTableAdapter.Update(Me.DbAlegatoADataSet.interventi)
            log.xlogWriteEntry("Inserimento intervento - Salvataggio dati", TraceEventType.Critical)
            'leggo l'id dell'intervento e lo salvo. Mi servirà nei salvataggi intermedi, quando l'update solleverà l'eccezione. Allora nella sezione Catch eseguirà l comando SQL update. Conviene fare così, per evitare altri problemi col binding. Cursore che si sposta etc...
            xidIntervento = Me.InterventiTableAdapter.MaxId
        Catch ex As DBConcurrencyException
            log.xlogWriteEntry("Inserimento intervento - Salvataggio automatico - Eseguo comando SQL Update", TraceEventType.Critical)
            Try
                Dim sTipoServizio As String = tbTipoServizio.Text.Replace("'", "''")
                Dim sResoconto As String = tbResoconto.Text.Replace("'", "''")
                Dim i = feActions.esegueSQL("UPDATE interventi SET dataOraInizio=#" & DateTimePickerOraInizio.Value & "#, dataOraFine=#" & DateTimePickerOraFine.Value & "#, tipointervento='" & sTipoServizio & "', resoconto='" & sResoconto & "' WHERE id=" & xidIntervento)
                log.xlogWriteEntry("Numero righe modificate: " & i, TraceEventType.Information)
                If i = 0 Then MsgBox("Contenuto non salvato!", MsgBoxStyle.Critical, "ATTENZIONE")
            Catch exc As Exception
                log.xlogWriteEntry("Inserimento intervento - Errore Salvataggio automatico - " & exc.Message, TraceEventType.Critical)
                MsgBox("Contenuto non salvato!" & ex.Message, MsgBoxStyle.Critical, "ATTENZIONE")
            End Try

        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (MsgBox("Chiudere la finetra? Tutte le modifiche verrano perse. Sei sicuro?", MsgBoxStyle.YesNo, "Chiudi Finestra") = MsgBoxResult.Yes) Then
            Me.Close()

        End If
    End Sub




    Dim contenutoCambiato As Boolean = False
    Private Sub setChanged(ByVal contenutoCamb As Boolean)
        'log.xlogWriteEntry("Inserimento intervento - Contenuto cambiato=" & contenutoCamb.ToString, TraceEventType.Information)
        contenutoCambiato = contenutoCamb
        'se il contenuto del form è cambiato allora setto il flag e aggiungo un asterisco al titolo
        'altrimenti tolgo l'asterisco
        If (contenutoCambiato) Then
            'se l'asterisco c'è già allora non ne aggiungo altri
            If (Me.Text.Substring(0, 1) <> "*") Then Me.Text = "*" & Me.Text
        Else
            If (Me.Text.Substring(0, 1) = "*") Then Me.Text = Me.Text.Substring(1)
        End If
    End Sub

    Private Sub DateTimePickerOraInizio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePickerOraInizio.ValueChanged
        setChanged(True)
    End Sub


    Private Sub tbTipoServizio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTipoServizio.TextChanged, tbResoconto.TextChanged
        setChanged(True)
    End Sub

    Private Sub TimerSalvataggioAutomatico_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSalvataggioAutomatico.Tick
        If (Not (tbTipoServizio.Text = "" And tbResoconto.Text = "") And contenutoCambiato = True) Then
            log.xlogWriteEntry("Inserimento intervento - Salvataggio automatico", TraceEventType.Critical)
            salva()
            setChanged(False)
        End If

    End Sub


End Class