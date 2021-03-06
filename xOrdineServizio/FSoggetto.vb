Public Class FSoggetto
    Dim parametri As parametriControllo_e_OS
    Dim log As New XOrseLog
    Dim xiOrdine As Integer
    Dim bNuovoSoggetto As Boolean = False
    Dim feActions As New OrSe.ActionsLibrary
    Dim accomp As tipoAccompagnatore
    'Flag utilizzato per non fare eseguire il check persona all'evento changeText dei textbox delle generalit� della persona, sino a quanto non � stato completato il disegno de form
    Dim bFlagBloccoCheckPersona As Boolean = True
    Dim bPersonaInteresseOperativo As Boolean = False  'utilizzata per segnalare che non si sta inserendo una nuova persona ma una di inter.operativo

    'nuovo soggetto
    Public Sub New(ByRef DataSet As dbAlegatoADataSet, ByVal parametri As parametriControllo_e_OS, ByVal iOrdine As Integer, ByVal accompagnatore As tipoAccompagnatore)
        Me.parametri = parametri
        ' Chiamata richiesta da Progettazione Windows Form.
        DbDataSetComuneNascita = DataSet
        InitializeComponent()
        UserControlInit()

        xiOrdine = iOrdine
        accomp = accompagnatore

        AllegatoABindingSource.AddNew()
        PersonaBindingSource.AddNew()

        Me.TipoPerquisizioneTableAdapter.Fill(Me.DbDataSetTipoPerquisizione.tipoPerquisizione)
        perquisizioneComboBox.SelectedIndex = "0"

        'scrivo ID del controllo
        If (parametri.idControllo <> Nothing) Then
            feActions.scriviCampoDB(AllegatoABindingSource, "idControllo", parametri.idControllo)

            labelOSWrite(parametri.idControllo)
        Else
            Me.Close()
        End If

        bNuovoSoggetto = True
        Dim drv As DataRowView = AllegatoABindingSource.Current
        drv.Item("positivoSDI") = PositivoSDIComboBox.Items(0)

    End Sub
    Private Sub UserControlInit()
        '       ComboBoxModelliMezzo.setDataSource(MezzoBindingSource)

        ComboBoxModelliMezzo.setSelectedValue(AllegatoABindingSource, "idMezzo")
        ComboBoxModelliMezzo.setDisplayMember("mezzo")
        ComboBoxModelliMezzo.setValueMember("id")
        ComboBoxModelliMezzo.setTabella(UserControlComboBox.tabellaEnum.ModelliMezzo)
        ComboBoxModelliMezzo.MaxLength(50) 'imposto la lunghezza massima del campo. E' uguale a quella del DB

        tbTarga.MaxLength = DbDataSetComuneNascita.modelliMezzo.mezzoColumn.MaxLength
        tbColore.MaxLength = DbDataSetComuneNascita.allegatoA.coloreColumn.MaxLength
        tbCognome.MaxLength = DbDataSetComuneNascita.persona.cognomeColumn.MaxLength
        tbNome.MaxLength = DbDataSetComuneNascita.persona.nomeColumn.MaxLength
        tbIndirizzo.MaxLength = DbDataSetComuneNascita.persona.residenzaindirizzoColumn.MaxLength
        tbDocumento.MaxLength = DbDataSetComuneNascita.persona.documentoColumn.MaxLength
        tbPrecedenti.MaxLength = DbDataSetComuneNascita.persona.precedentiColumn.MaxLength
        tbNote.MaxLength = DbDataSetComuneNascita.allegatoA.NOTEColumn.MaxLength

    End Sub

    'modifica soggetto
    Public Sub New(ByRef DataSet As dbAlegatoADataSet, ByVal parametri As parametriControllo_e_OS, ByVal n As Integer)
        DbDataSetComuneNascita = DataSet
        InitializeComponent()
        feActions.setStandardFormSize(Me)
        'inizializza lo user controll con i parametri richiesti
        UserControlInit()

        Me.parametri = parametri

        'fill della tabella alegatoA e degli altri dataset
        Me.AllegatoATableAdapter.FillByID(Me.DbDataSetComuneNascita.allegatoA, n)

        Dim i = feActions.leggiCampoDB(Me.AllegatoABindingSource, "idPersona")
        Me.PersonaTableAdapter.FillByID(Me.DbDataSetComuneNascita.persona, i)

        i = feActions.leggiCampoDB(Me.AllegatoABindingSource, "idMezzo")
        If (Not i Is DBNull.Value) Then
            ' Me.modelliMezzoTableAdapter.FillById(Me.DbDataSet.modelliMezzo, i)
            ComboBoxModelliMezzo.setSelectedID(i)
        End If

        i = feActions.leggiCampoDB(Me.PersonaBindingSource, "idLuogoNascita")
        If (Not i Is DBNull.Value And Not i Is Nothing) Then Me.QComuneTableAdapter.FillByID(Me.DbDataSetComuneNascita.QComune, Integer.Parse(i))

        i = feActions.leggiCampoDB(Me.PersonaBindingSource, "idResidenzaComune")
        If (Not i Is DBNull.Value And Not i Is Nothing) Then Me.QComuneTableAdapter.FillByID(Me.DbDataSetComuneResidenza.QComune, Integer.Parse(i))

        Dim idPerquisizione = feActions.leggiCampoDB(Me.AllegatoABindingSource, "perquisizione")
        Me.TipoPerquisizioneTableAdapter.Fill(Me.DbDataSetTipoPerquisizione.tipoPerquisizione)

        If (Not idPerquisizione Is DBNull.Value And Not idPerquisizione Is Nothing) Then
            perquisizioneComboBox.SelectedText = idPerquisizione
        End If


        parametri.idControllo = feActions.leggiCampoDB(Me.AllegatoABindingSource, "idControllo")
        labelOSWrite(parametri.idControllo)

    End Sub

    Private Sub labelOSWrite(ByVal iId As Integer)
        'se il fill restituisce 0 vuol dire che sto inserendo un nuovo controllo, quindi ho gi� tutti i par necessati nella classe parametri
        If (QAllegatoATableAdapter.FillByIdControllo(Me.DbDataSetComuneNascita.QAllegatoA, iId) > 0) Then
            parametri.dataOS = feActions.leggiCampoDB(Me.QAllegatoABindingSource, "dataOS")
            parametri.nomeOS = feActions.leggiCampoDB(Me.QAllegatoABindingSource, "nomeOS")
            parametri.nomeOperatore = feActions.leggiCampoDB(Me.QAllegatoABindingSource, "operatori")
        End If

        'leggo il nome dell'ordine di servizio
        labelOS.Text = parametri.nomeOS + " del " + FormatDateTime(parametri.dataOS, DateFormat.ShortDate)
        LabelControllo.Text = "Controllo: ore " + FormatDateTime(parametri.dataoraControllo, DateFormat.ShortTime) + " in " + parametri.nomeLuogoControllo
        LabelOperatori.Text = "Operatori: " + parametri.nomeOperatore
    End Sub

    Private Sub FSoggetto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbAlegatoADataSet.tipoPerquisizione' table. You can move, or remove it, as needed.
        Me.TipoPerquisizioneTableAdapter.Fill(Me.DbAlegatoADataSet.tipoPerquisizione)
        If bNuovoSoggetto Then
            'esegue qui se � un nuovo soggetto
            'valore di default per PositivoSDIComboBox
            'il cursore si posiziona su questo oggetto
            ComboBoxModelliMezzo.Focus()

            'caso PASSEGGERO
            If (xiOrdine > 0) Then
                ComboBoxModelliMezzo.Visible = False
                tbColore.Visible = False
                tbTarga.Visible = False
                'Solo se � un nuovo soggetto e se � un passeggero forzo la scritta "passeggero" e rendo invisibili mezzo targa e colore
                Dim s As String
                If (accomp = tipoAccompagnatore.a_piedi) Then
                    s = "a piedi"
                Else
                    s = "passeggero"
                End If
                If (modelliMezzoTableAdapter.FillByMezzo_StringaEsatta(DbDataSetComuneNascita.modelliMezzo, s) <= 0) Then
                    Me.modelliMezzoTableAdapter.Insert(s)
                    'rifaccio il fill, per evitare di avere un risultato nullo nella ricerca del valore appena inserito
                    modelliMezzoTableAdapter.FillByMezzo(DbDataSetComuneNascita.modelliMezzo, s)
                End If


                'recupero l'id del mezzo e lo metto in bindig. Faccio cos� perch� la textbox � invisibile

                Dim drv As DataRowView = AllegatoABindingSource.Current()
                Dim i = feActions.leggiCampoDB(MezzoBindingSource, "id")
                If i Is Nothing Then i = DBNull.Value
                drv.Item("idMezzo") = i
                ComboBoxModelliMezzo.setSelectedID(i)
                drv.Item("idControllo") = parametri.idControllo
                ComboBoxModelliMezzo.Visible = False
                tbColore.Visible = False
                tbTarga.Visible = False
            End If
        End If
        'permette alla sub checkpersona di venire eseguita
        bFlagBloccoCheckPersona = False

        'la caption del form � formato da cognome e nome
        '  Dim sCaption As String = tbCognome.Text & " " & tbNome.Text
        ' If (sCaption.Trim.Length = 0) Then
        ' Me.Text = My.Settings.nomeFinestraSoggetto
        updateCaption()
        'Else
        'Me.Text = sCaption
        'End If

    End Sub



    Private Sub ComuneDataGridView_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs)
        Me.ComuneTableAdapter.Update(Me.DbDataSetComuneNascita.comune)

    End Sub


    Private Sub btnSalvaChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvaChiudi.Click
        Try
            Me.Validate()
            'creazione persona

            Me.PersonaBindingSource.EndEdit()
            Me.PersonaTableAdapter.Update(Me.DbDataSetComuneNascita.persona)

            Dim drv As DataRowView = Me.AllegatoABindingSource.Current()
            If (bNuovoSoggetto) Then

                'se ho inserito una persona in i.o. allora non devo recuperare l'id dell'ultima persona inserita
                Dim idpersona As Integer
                If (Not bPersonaInteresseOperativo) Then
                    'recupero l'id persona. E' l'ultima persona inserita
                    idpersona = Me.PersonaTableAdapter.MaxID()
                Else
                    Dim dataRowPersona As DataRowView
                    dataRowPersona = PersonaBindingSource.Current()
                    idpersona = dataRowPersona.Item("id")
                End If

                drv.Item("idpersona") = idpersona
                'memorizzo l'id del controllo nella riga dell'allegatoA

                If (ComboBoxModelliMezzo.getSelectedID > 0) Then drv.Item("idmezzo") = ComboBoxModelliMezzo.getSelectedID

                drv.Item("idControllo") = parametri.idControllo

                'memorizzo l'ordine di inserimento della persona nel controllo
                drv.Item("ordine") = Me.xiOrdine
            Else
                'c'� un bug che non riesco a risolvere. Inspiegabilmente sparisce il mezzo. Lo scrivo forzatamente
                If (ComboBoxModelliMezzo.getSelectedID > 0) Then drv.Item("idmezzo") = ComboBoxModelliMezzo.getSelectedID

            End If
            drv.EndEdit()
            'update modifiche riga allegato A
            '  Me.AllegatoABindingSource.EndEdit()
            Me.AllegatoATableAdapter.Update(Me.DbDataSetComuneNascita.allegatoA)
            Me.Close()

        Catch ex As Exception
            log.xlogWriteEntry("Errore inserimento soggetto. " & ex.Message, TraceEventType.Error)
            MsgBox("Errore inserimento soggetto. " & ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub


    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
        Me.Close()
    End Sub


    Private Sub btnPasseggero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPasseggero.Click
        '   Me.PersonaBindingSource.EndEdit()
        'Me.AllegatoABindingSource.EndEdit()

        feActions.doApriFormAllegatoA(DbDataSetComuneNascita, parametri.Clone, 1, tipoAccompagnatore.passeggero)
    End Sub


    Private Sub btnAPiedi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAPiedi.Click
        feActions.doApriFormAllegatoA(DbDataSetComuneNascita, parametri.Clone, 1, tipoAccompagnatore.a_piedi)
    End Sub

    Private Sub FSoggetto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.Alt) Then
            Select Case (Chr(e.KeyValue))
                Case "M" : Me.ComboBoxModelliMezzo.Focus() 'mezzo
                    e.SuppressKeyPress = True
                Case "C" : Me.tbCognome.Focus()     'cognome
                    e.SuppressKeyPress = True
                Case "N" : Me.tbNome.Focus()        'nome
                    e.SuppressKeyPress = True
                Case "O" : Me.tbColore.Focus()      'colore
                    e.SuppressKeyPress = True
                Case "T" : Me.tbTarga.Focus()      'targa
                    e.SuppressKeyPress = True
                Case "D" : Me.DataNascitaMaskedTextBox.Focus() 'data nascita
                    e.SuppressKeyPress = True
                Case "L" : Me.ComboBoxComuneNascita.Focus()      'luogo nascita
                    e.SuppressKeyPress = True
                Case "A" : Me.ComboBoxComuneResidenza.Focus()      'luogo nascita
                    e.SuppressKeyPress = True
                Case "Z" : Me.tbIndirizzo.Focus()      'luogo nascita
                    e.SuppressKeyPress = True
                Case "U" : Me.tbDocumento.Focus()      'luogo nascita
                    e.SuppressKeyPress = True
                Case "V" : Me.PositivoSDIComboBox.Focus()      'luogo nascita
                    e.SuppressKeyPress = True
                Case "R" : Me.tbPrecedenti.Focus()      'luogo nascita
                    e.SuppressKeyPress = True
            End Select
        End If
    End Sub


    Private Sub tbCognome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCognome.TextChanged
        If (Not bFlagBloccoCheckPersona) Then checkPersona()

    End Sub

    Dim bVisualizzato = False
    Private Sub checkPersona()
        Dim dNascita As Date
        'se la data non � valida, allora imposta data a Nothing
        Try
            dNascita = DataNascitaMaskedTextBox.Text
        Catch ex As Exception
            dNascita = Nothing

        End Try


        Dim i As Integer = Me.PersonaTableAdapter.ScalarQueryCountPersona(tbCognome.Text(), tbNome.Text(), ComboBoxComuneNascita.SelectedValue, dNascita)
        If (i > 0) Then
            bPIOSel.BackgroundImage = My.Resources.pulsanteSoleVerde
            bPIOSel.Enabled = True
            If Not bVisualizzato Then
                bVisualizzato = True
                InfoScreen.soggettoGiaPresente()

            End If
        Else
            bPIOSel.BackgroundImage = My.Resources.pulsanteSoleGrigio
        End If
    End Sub

    Private Sub tbNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNome.TextChanged
        If (Not bFlagBloccoCheckPersona) Then checkPersona()
    End Sub

    Private Sub DataNascitaMaskedTextBox_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Not bFlagBloccoCheckPersona) Then checkPersona()
    End Sub

    Private Sub LuogoNascitaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Not bFlagBloccoCheckPersona) Then checkPersona()
    End Sub

    Private Sub btnAddPIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPIO.Click
        Dim idPersona = feActions.doArpiFormListaPIO()


        If (idPersona >= 0) Then
            'in allegato A il soggetto di int.op. che inserisco corrisponde ad un nuovo soggetto. (altrimenti compaiono a video tutti i dati ma poi, se siamo in modalit� modifica, con "Salva e Chiudi" non viene memorizzata la persona
            bNuovoSoggetto = True
            'se viene selezionata una persona di int.operativo allora rimuovo la riga inserita prima e posiziono il binding
            bPersonaInteresseOperativo = True
            Me.PersonaTableAdapter.FillByID(DbDataSetComuneNascita.persona, idPersona)
            PersonaBindingSource.MoveFirst()
            Dim i = feActions.leggiCampoDB(Me.PersonaBindingSource, "idLuogoNascita")
            If (Not (i Is DBNull.Value Or i Is Nothing)) Then Me.QComuneTableAdapter.FillByID(Me.DbDataSetComuneNascita.QComune, Integer.Parse(i))

            i = feActions.leggiCampoDB(Me.PersonaBindingSource, "idResidenzaComune")
            If (Not (i Is DBNull.Value Or i Is Nothing)) Then Me.QComuneTableAdapter.FillByID(Me.DbDataSetComuneResidenza.QComune, Integer.Parse(i))



        End If
    End Sub

    Private Sub cbPip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPip.CheckedChanged
        Dim cb As CheckBox = sender

        If (cb.CheckState = CheckState.Checked) Then
            'checked
            cb.BackgroundImage = Global.OrSe.My.Resources.Resources.sagomaON
        Else
            'unchecked
            cb.BackgroundImage = Global.OrSe.My.Resources.Resources.sagomaOFF
        End If
    End Sub

    Private Sub bPIOSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPIOSel.Click
        'lettura dell'id persona esistente in base ai parametri indicati
        Me.PersonaTableAdapter.FillByDati(DbDataSetComuneNascita.persona, tbCognome.Text(), tbNome.Text(), ComboBoxComuneNascita.SelectedValue, DataNascitaMaskedTextBox.Text)

        PersonaBindingSource.MoveFirst()

        Dim i = feActions.leggiCampoDB(Me.PersonaBindingSource, "idResidenzaComune")

        If (Not i Is DBNull.Value And Not i Is Nothing) Then Me.QComuneTableAdapter.FillByID(Me.DbDataSetComuneResidenza.QComune, Integer.Parse(i))

        bPersonaInteresseOperativo = True
        'non mi occorre fare altre operazioni. Il binding della persona � gi� posizionato sull'elemento che mi interessa

        'disabilito i textbox delle generalit�
        tbCognome.Enabled = False
        tbNome.Enabled = False
        DataNascitaMaskedTextBox.Enabled = False
        ComboBoxComuneNascita.Enabled = False

    End Sub

    Private Sub cittaIndirizzoComboBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim cbox As ComboBox = sender
        Dim i = cbox.SelectedValue
        If (i Is Nothing) Then
            cbox.BackColor = Color.Red
        Else
            cbox.BackColor = Color.White
        End If
    End Sub

    '=============================================
    '=============================================


    Dim bSemaforo As Boolean = True
    Dim bSemaforo2 As Boolean = True


    Private Sub ComboBoxComuneNascita_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxComuneNascita.KeyUp
        Dim cb As ComboBox = sender
        EventoKeyUpComboComune(DbDataSetComuneNascita, cb)
    End Sub

    Private Sub ComboBoxComuneResidenza_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxComuneResidenza.KeyUp
        Dim cb As ComboBox = sender
        EventoKeyUpComboComune(DbDataSetComuneResidenza, cb)

    End Sub
    Sub EventoKeyUpComboComune(ByVal dataset As dbAlegatoADataSet, ByVal cb As ComboBox)
        Static Dim sChiaveRicercaComuni As String
        Dim iLenght = cb.Text.Length
        Dim iSelLenght = cb.SelectionLength

        cb.DroppedDown = True

        If (Not cb.SelectionStart = 0) Then
            sChiaveRicercaComuni = cb.Text.Substring(0, iLenght - iSelLenght)
            'la variabile booleana semaforo permette di non effettuare ulteriori interrogazioni se gi� ne � in esecuzione una
            If (bSemaforo2) Then
                bSemaforo2 = False
                Dim n = Me.QComuneTableAdapter.FillByComune(dataset.QComune, sChiaveRicercaComuni.Trim)
                bSemaforo2 = True
            End If

            cb.SelectedText() = sChiaveRicercaComuni


        End If
    End Sub


    Private Sub tbTarga_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTarga.Leave
        tbTarga.Text = (tbTarga.Text.Trim())
        tbTarga.Text = tbTarga.Text.ToUpper()
    End Sub

    Private Sub textbox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCognome.Leave, tbNome.Leave, tbIndirizzo.Leave, tbDocumento.Leave
        Dim tb As TextBox = sender
        tb.Text() = tb.Text().Trim()

        'Aggiorno il Caption del Form
        updateCaption()

    End Sub

    Sub updateCaption()
        Me.Text = tbCognome.Text & " " & tbNome.Text & " - " & My.Settings.nomeFinestraSoggetto.ToString
    End Sub
    '  Private Sub ComboBoxModelliMezzo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   inserimentovalore(sender)
    ' End Sub
    'Private Sub inserimentovalore(ByVal sender As System.Object)
    '    feActions.doComboInsNuovoValore(sender, modelliMezzoTableAdapter, DbDataSet.modelliMezzo)

    ' End Sub
    Private Sub ComboBoxComuneNascita_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxComuneNascita.Leave
        comboboxLeave(sender)
    End Sub

    Private Sub comboboxLeave(ByVal cb As ComboBox)
        'se non ci sono elementi selezionati ed il combobox ne contiene almeno uno allora seleziono il primo
        If (cb.Items.Count > 0 And cb.SelectedItem Is Nothing) Then
            cb.SelectedItem = cb.Items.Item(0)
        End If

        'se non viene selezionato alcun elemento allora coloro il combobox di rosso
        If (cb.SelectedIndex < 0) Then
            cb.BackColor = Color.Red
        Else
            cb.BackColor = Color.White
        End If

        aggiornoDataUltimoUsoComune(cb.SelectedValue)

    End Sub

    Private Sub ComboBoxComuneResidenza_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxComuneResidenza.Leave
        comboboxLeave(sender)
    End Sub

    ' Private Sub ComboBoxModelliMezzo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '   If (e.KeyCode = 13) Then
    '      inserimentovalore(sender)
    '   End If

    ' End Sub


    Private Sub aggiornoDataUltimoUsoComune(ByVal id As Integer)
        Dim log As New XOrseLog
        If (id > 0) Then
            If (Me.PrioritaComuneTableAdapter.FillByID(Me.DbDataSetComuneNascita.prioritaComune, id) > 0) Then
                Try
                    Dim objconn As New OleDb.OleDbConnection(My.Settings.dbAlegatoAConnectionString)
                    Dim objcomm As New OleDb.OleDbCommand("UPDATE prioritaComune SET dataOraUltimoUso=" & ActionsLibrary.getTimeStamp() & " WHERE idComune= " & id, objconn)
                    objconn.Open()

                    Dim risputente As Integer
                    Try
                        risputente = objcomm.ExecuteNonQuery()
                        If risputente = 1 Then
                            log.xlogWriteEntry("Aggiornamento priorit� Comune: " & id, TraceEventType.Information)
                        End If
                    Catch es As Exception
                        log.xlogWriteEntry("Errore aggiornamento priorit� Comune: " & id & " - " & es.Message, TraceEventType.Error)
                    End Try
                Catch ex As Exception
                    log.xlogWriteEntry("Errore aggiornamento priorit� Comune - " & ex.Message, TraceEventType.Error)
                End Try
            Else
                Me.PrioritaComuneTableAdapter.Insert(id, ActionsLibrary.getTimeStamp)
                log.xlogWriteEntry("Nuova priotit� Comune: " & id, TraceEventType.Information)
            End If
        End If
    End Sub



    Private Sub ComboBoxComuneNascita_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxComuneNascita.KeyDown
        Dim cb As ComboBox = sender
        If (e.KeyCode = 13) Then
            'se premo invio allora sposto il focus su OK
            ComboBoxComuneResidenza.Focus()
        End If

    End Sub

    Private Sub ComboBoxComuneResidenza_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxComuneResidenza.KeyDown
        Dim cb As ComboBox = sender
        If (e.KeyCode = 13) Then
            'se premo invio allora sposto il focus su OK
            tbIndirizzo.Focus()
        End If

    End Sub
    'MUOVERE UN CONTROLLO A RUNTIME TEST
    ' Public Const WM_NCLBUTTONDOWN = &HA1
    ' Public Const HTCAPTION = 2
    ' Private Sub TextBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseDown
    '     If e.Button = Windows.Forms.MouseButtons.Left Then
    '         TextBox1.Capture = False
    ' Dim msg As Message = _
    '     Message.Create(TextBox1.Handle, WM_NCLBUTTONDOWN, _
    '         New IntPtr(HTCAPTION), IntPtr.Zero)
    '         Me.DefWndProc(msg)
    '     End If
    ' End Sub


    Private Sub DataNascitaMaskedTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataNascitaMaskedTextBox.TextChanged
        If (Not bFlagBloccoCheckPersona) Then checkPersona()

    End Sub

    Private Sub ComboBoxComuneNascita_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxComuneNascita.TextChanged
        If (Not bFlagBloccoCheckPersona) Then checkPersona()

    End Sub

    Private Sub LabelControllo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControllo.DoubleClick
        'modifica luogo e ora controllo
        log.xlogWriteEntry("Apertura form modifica dati controllo", TraceEventType.Information)
        'db = db
        Dim form As System.Windows.Forms.Form
        form = New DInserimentoLuogoControllo(DbDataSetComuneNascita, parametri, True)
        form.ShowDialog()
        If form.DialogResult = Windows.Forms.DialogResult.OK Then
            'aggiorno le informazioni sul controllo 
            labelOSWrite(parametri.idControllo)
        End If
    End Sub


End Class
