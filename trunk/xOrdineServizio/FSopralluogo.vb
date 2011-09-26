Public Class FSopralluogo
    Dim log As New XOrseLog
    Dim feActions As New OrSe.ActionsLibrary
    Private idSopralluogo As Integer = -1
    Private xIdOS As Integer

    Private nomiOperatori As String

    Private Sub btnSalvaChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvaChiudi.Click
        salva()
        Me.Close()
    End Sub

    Dim bSaved As Boolean = False
    Private Sub salva()
        Dim sTipoReato As String

        'quando assegno un valore a drv.item, tutti i campi del binding vengono riportati allo stato dell'ultimo salvataggio, perdo quidi tutte le modifiche.
        'le ripristino salvandole prima di usare l'oogeto drv
        'Dim xoraRichiesta As Date = DateTimePickerOraRichiesta.Value
        'Dim xoraRedazione As Date = DateTimePickerOraVerbale.Value
        'Dim sLuogo As String = TextBoxLuogo.Text
        'Dim sVia As String = TextBoxVia.Text
        'Dim sContatti As String = TextBoxContatti.Text
        'Dim sResoconto As String = RichTextBoxResoconto.Text

        Try
            Dim drv As DataRowView = SopralluogoBindingSource.Current()
            If (Not bSaved) Then

                If (RadioButtonTipoFurtoAbitazione.Checked) Then
                    sTipoReato = "Furto in abitazione"
                    drv.Item("tipoReato") = sTipoReato
                Else
                    sTipoReato = TextBoxTipoAltro.Text
                    drv.Item("tipoReato") = sTipoReato
                End If

                drv.Item("oraRedazione") = DateTimePickerOraVerbale.Value
                drv.Item("oraRichiesta") = DateTimePickerOraRichiesta.Value
            End If
            'ripristino i nuovi valori
            'DateTimePickerOraRichiesta.Value = xoraRichiesta
            'DateTimePickerOraVerbale.Value = xoraRedazione
            'TextBoxLuogo.Text = sLuogo
            'TextBoxVia.Text = sVia
            'TextBoxContatti.Text = sContatti
            'RichTextBoxResoconto.Text = sResoconto

            Me.Validate()
            Me.SopralluogoBindingSource.EndEdit()
            Me.SopralluogoTableAdapter.Update(Me.DbAlegatoADataSet.sopralluogo)
            'se non si è sollevata eccezione vuol dire che il salvataggio è andato a buon fine
            bSaved = True
            'leggo l'id del sopralluogo e lo salvo. Mi servirà nei salvataggi intermedi, quando l'update solleverà l'eccezione. Allora nella sezione Catch eseguirà l comando SQL update. Conviene fare così, per evitare altri problemi col binding. Cursore che si sposta etc...
            idSopralluogo = SopralluogoTableAdapter.MaxID
            log.xlogWriteEntry("Inserimento sopralluogo - Salvataggio dati", TraceEventType.Critical)
        Catch ex As DBConcurrencyException
            log.xlogWriteEntry("Inserimento sopralluogo - Salvataggio automatico - Eseguo comando SQL Update", TraceEventType.Critical)
            feActions.esegueSQL("UPDATE sopralluogo SET idOS=" & xIdOS & ", tipoReato='" & sTipoReato & "', oraRichiesta=#" & DateTimePickerOraRichiesta.Value & "#, oraRedazione=#" & DateTimePickerOraVerbale.Value & "#, luogo_citta='" & TextBoxLuogo.Text & "', via='" & TextBoxVia.Text & "', contatti_con='" & TextBoxContatti.Text & "', resoconto='" & RichTextBoxResoconto.Text & "' WHERE id=" & idSopralluogo)
        End Try

    End Sub



    Private Sub FSopralluogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbAlegatoADataSet.sopralluogo' table. You can move, or remove it, as needed.
        If (idSopralluogo >= 0) Then
            log.xlogWriteEntry("Apertura form sopralluogo per modifica", TraceEventType.Information)
            Me.SopralluogoTableAdapter.FillById(Me.DbAlegatoADataSet.sopralluogo, idSopralluogo)

            Dim tipoR As String = feActions.leggiCampoDB(SopralluogoBindingSource, "tipoReato")

            If (tipoR = "Furto in abitazione") Then
                RadioButtonTipoFurtoAbitazione.Checked = True
            Else
                RadioButtonTipoAltro.Checked = True
                TextBoxTipoAltro.Text = tipoR
            End If
        Else
            'il salvataggio automatico è disattivato quando si modifica un record
            'imposto l'intervallo per il salvataggio automatico al valore delle impostazioni (in secondi)
            If (Integer.Parse(My.Settings.intervalloSalvataggioAutomatico) > 0) Then
                TimerSalvataggioAutomatico.Interval = My.Settings.intervalloSalvataggioAutomatico * 1000
                TimerSalvataggioAutomatico.Start()
            End If
        End If

    End Sub


    Public Sub New(ByVal idOS As Integer, ByVal idS As Integer, ByVal nomiOp As String)
        xIdOS = idOS

        nomiOperatori = nomiOp
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        'se l'id è maggiore di zero allora sto modificando, altrimenti inserisco un nuovo elemento
        If (idS >= 0) Then
            idSopralluogo = idS
        Else
            Me.SopralluogoBindingSource.AddNew()
            log.xlogWriteEntry("Apertura form sopralluogo - nuovo sopralluogo", TraceEventType.Information)
            Dim drv As DataRowView = SopralluogoBindingSource.Current()
            drv.Item("idOS") = xIdOS
        End If

        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
        If (MsgBox("Chiudere la finetra? Tutte le modifiche verrano perse. Sei sicuro?", MsgBoxStyle.YesNo, "Chiudi Finestra") = MsgBoxResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonGeneraReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGeneraReport.Click
        'salva il verbale di sopralluovo
        salva()
        Try
            log.xlogWriteEntry("Word - Preparazione per generazione verbale di sopralluogo", TraceEventType.Critical)

            Dim oWord As Microsoft.Office.Interop.Word.Application = feActions.wordInizializzaDocumentoVerbaleSopralluogo()

            feActions.wordScriviSegnalibro(oWord, "regione", My.Settings.regione)
            feActions.wordScriviSegnalibro(oWord, "comando", My.Settings.comando)
            feActions.wordScriviSegnalibro(oWord, "tipoReato", feActions.leggiCampoDB(SopralluogoBindingSource, "tipoReato"))
            feActions.wordScriviSegnalibro(oWord, "luogo", feActions.leggiCampoDB(SopralluogoBindingSource, "luogo_citta"))
            feActions.wordScriviSegnalibro(oWord, "via", feActions.leggiCampoDB(SopralluogoBindingSource, "via"))
            'il segnalibro non permette che esistano più istanze sullo stesso documento. Quindi devo duplicarlo, quando serve scrivere due volte le stesse informazioni.
            feActions.wordScriviSegnalibro(oWord, "luogo2", feActions.leggiCampoDB(SopralluogoBindingSource, "luogo_citta"))
            feActions.wordScriviSegnalibro(oWord, "via2", feActions.leggiCampoDB(SopralluogoBindingSource, "via"))

            Dim d As Date = feActions.leggiCampoDB(SopralluogoBindingSource, "oraRedazione")
            feActions.wordScriviSegnalibro(oWord, "dataRedazione", d.ToShortDateString)
            feActions.wordScriviSegnalibro(oWord, "oraRedazione", d.ToShortTimeString)

            d = feActions.leggiCampoDB(SopralluogoBindingSource, "oraRichiesta")
            feActions.wordScriviSegnalibro(oWord, "dataRichiesta", d.ToShortDateString)
            feActions.wordScriviSegnalibro(oWord, "oraRichiesta", d.ToShortTimeString)

            feActions.wordScriviSegnalibro(oWord, "nomiOperatori", nomiOperatori)

            feActions.wordScriviSegnalibro(oWord, "contatti", feActions.leggiCampoDB(SopralluogoBindingSource, "contatti_con"))
            feActions.wordScriviSegnalibro(oWord, "resoconto", feActions.leggiCampoDB(SopralluogoBindingSource, "resoconto"))

        Catch

        End Try

    End Sub

    Dim contenutoCambiato As Boolean = False

    Private Sub setChanged(ByVal contenutoCamb As Boolean)
        log.xlogWriteEntry("Inserimento sopralluogo - Contenuto cambiato=" & contenutoCamb.ToString, TraceEventType.Information)
        contenutoCambiato = contenutoCamb
        'se il contenuto del form è cambiato allora setto il flag e aggiungo un asterisco al titolo
        'altrimenti tolgo l'asterisco
        If Me.Text.Length > 0 Then
            If (contenutoCambiato) Then
                'se l'asterisco c'è già allora non ne aggiungo altri
                If (Me.Text.Substring(0, 1) <> "*") Then Me.Text = "*" & Me.Text
            Else
                If (Me.Text.Substring(0, 1) = "*") Then Me.Text = Me.Text.Substring(1)
            End If
        End If
    End Sub

    Private Sub RadioButtonTipoFurtoAbitazione_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonTipoFurtoAbitazione.CheckedChanged
        setChanged(True)
    End Sub

    Private Sub TextBoxTipoAltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxTipoAltro.TextChanged, TextBoxVia.TextChanged, TextBoxLuogo.TextChanged, TextBoxContatti.TextChanged, RichTextBoxResoconto.TextChanged, DateTimePickerOraVerbale.ValueChanged, DateTimePickerOraRichiesta.ValueChanged
        setChanged(True)
    End Sub

    Private Sub TimerSalvataggioAutomatico_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSalvataggioAutomatico.Tick
        If (Not (TextBoxContatti.Text = "" And TextBoxLuogo.Text = "" And TextBoxVia.Text = "" And RichTextBoxResoconto.Text = "" And TextBoxTipoAltro.Text = "") And contenutoCambiato = True) Then
            log.xlogWriteEntry("Inserimento sopralluogo - Salvataggio automatico", TraceEventType.Critical)
            salva()
            setChanged(False)
        End If
    End Sub
End Class