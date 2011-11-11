Imports System.Diagnostics
Public Class FPrima

    Dim feActions As New OrSe.ActionsLibrary
    Dim appPatch As New OrSe.ApplicazionePatch
    Dim infoScreen As New InfoScreen
    Dim parametri As New parametriControllo_e_OS
    Dim log As New XOrseLog
    Dim modalitaVisita As Boolean
    Dim bFlagExit As Boolean = False

    Public Sub New()

        'controllo se il file del DB è presente, altrimenti restituisco errore ed esco dall'applicazione
        Dim pathDB As String = Application.StartupPath

        Dim sPath = pathDB & "\dbAlegatoA.mdb"

        'elimino il file dbAlegatoA2, nel caso sia presente
        If Dir(sPath) = "" Then
            MsgBox("Il file """ & sPath & ", necessario all'applicazione, non sembra essere presente. Controllare che sulla cartella di installazione """ & sPath & """ ci siano i permessi di scrittura. Eventualmente, richiedere assistenza al produttore", MsgBoxStyle.Critical, "ERRORE")
            bFlagExit = True

            'Codice da inserire in una funzione o evento click del pulsante

            '            For Each p As Process In Process.GetProcesses()

            '            If p.Id = Process.GetCurrentProcess().Id Then
            'MessageBox.Show("Nome Processo: " & Process.GetCurrentProcess().ProcessName)
            'p.CloseMainWindow()
            'p.Close()
            'End If
            '  Next
        End If


        If Not bFlagExit Then
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
        End If
    End Sub

    Private Sub Form1_myInit()
        'posizioni il cursore sull'ordine di servizio corrente
        Dim nIdOS = OrdineServizioTableAdapter.FillByID(DbAlegatoADataSet_Unico.ordineServizio, parametri.idOS)
        If nIdOS = 1 Then log.xlogWriteEntry("Ordine di servizio id nr." & parametri.idOS & " selezionato (" & parametri.nomeOS & " del " & parametri.dataOS & ")", TraceEventType.Information)
        labelInfoOS.Text = "Ordine di servizio: " + parametri.nomeOS + " del " + FormatDateTime(parametri.dataOS, DateFormat.ShortDate)
        feActions.setStandardFormSize(Me)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not bFlagExit Then
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

            '#ElseIf  Then

#End If
        Else
            Application.ExitThread()
        End If
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
            setModalitaVisita(True)
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

    Private Sub abilitaPulsanteOP85(ByVal b As Boolean)
        OP85ToolStripMenuItem.Enabled = b
    End Sub


    Private Sub btnAlegatoA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlegatoA.Click
        ' Dim timestamp As System.DateTime = System.DateTime.Now.ToString
        feActions.doApriFormAllegatoA(DbAlegatoADataSet_Unico, parametri)
    End Sub

    Private Sub genericoDataGridView_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs)
        feActions.personalizzaGrid(sender)
    End Sub


    Private Sub apriDettaglioSoggetto(ByRef dgv As DataGridView)
        Dim v As Integer = dgv.CurrentRow.Cells("cID").Value
        parametri.nomeLuogoControllo = dgv.CurrentRow.Cells("cLuogoControllo").Value
        parametri.dataoraControllo = dgv.CurrentRow.Cells("cOra").Value
        feActions.doApriDettaglioSoggetto(DbAlegatoADataSet_Unico, parametri, v)
    End Sub
    Private Sub SoggettiDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim dgv As DataGridView = sender
        apriDettaglioSoggetto(dgv)
    End Sub

    Private Sub OpzioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpzioniToolStripMenuItem.Click
        feActions.doApriFormOpzioni()
    End Sub

    Private Sub InterventiDataGrid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        DataGridClickAperturaDettaglio(sender, e, "iddgvInterventi")
    End Sub
    Private Sub InformazioniDataGrid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
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
        labelInfoOS.Text = ""
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
    Private Sub InformazioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles informazioniToolStripMenuItem.Click
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


    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSopralluogo.Click
        log.xlogWriteEntry("Apertura sopralluogo", TraceEventType.Information)
        feActions.doApriFormSopralluogo(parametri.idOS, parametri.nomeOperatore)
    End Sub

    Private Sub ButtonRubrica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRubrica.Click, ButtonRubrica.Click
        log.xlogWriteEntry("Apertura rubrica", TraceEventType.Information)
        feActions.doApriFormRubrica(parametri.idOS)
    End Sub


    Private Sub btnRicerca_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        feActions.doApriFormRicerca()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim client As ImapX.ImapClient = New ImapX.ImapClient("imap.gmail.com", 993, True)

        Dim result As Boolean = False

        result = client.Connection()
        If (result) Then

            log.xlogWriteEntry("@Connected", TraceEventType.Information)

            result = client.LogIn("fazioa", "Chiara4262")
            If (result) Then
                log.xlogWriteEntry("@Logged in", TraceEventType.Information)
            End If
        End If


        'Folder Collection
        'Dim folders As ImapX.FolderCollection = client.Folders

        'Create folder
        '  client.CreateFolder("NEW FOLDER")
        'Message collection 1st option
        ' Dim messages As ImapX.MessageCollection = client.Folders("INBOX").Search("ALL", True) ' true - means all message parts will be received from server
        '2nd option
        ' For Each m As ImapX.Message In client.Folders("INBOX").Messages

        ' m.Process()
        ' Dim attachments As List(Of ImapX.Attachment) = m.Attachments
        ' Dim textBody As String = m.TextBody.TextData
        ' Dim htmlBody As String = m.HtmlBody.TextData
        ' log.xlogWriteEntry(textBody & " - " & htmlBody, TraceEventType.Information)'

        'Next


        Dim msg As ImapX.Message = New ImapX.Message()
        msg.Subject = "hello yahoo"
        msg.From.Add(New ImapX.MailAddress("ToninoTest", "test@test.it"))
        msg.To.Add(New ImapX.MailAddress("provaToFazioa", "fazioa@gmail.com"))
        msg.HtmlBody.ContentType = "text/html"
        msg.HtmlBody.TextData = "<strong>it is test message</strong>"
        Dim atach As ImapX.Attachment = New ImapX.Attachment()
        'atach.FileName = attachmentPath
        'msg.Attachments.Add(atach)
        If (client.Folders("INBOX").AppendMessage(msg, "")) Then
            log.xlogWriteEntry("message has been appended to INBOX", TraceEventType.Information)
        End If
    End Sub

    Private Sub SopralluogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SopralluogoToolStripMenuItem.Click
        Dim form As System.Windows.Forms.Form
        form = New FSopralluogoListaStampa(parametri)
        form.Visible = True
    End Sub

    
    Private Sub labelInfoOS_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelInfoOS.DoubleClick
        'apertura finestra modifica dati OS
        log.xlogWriteEntry("Apertura form modifica dati OS", TraceEventType.Information)
        'db = db
        Dim form As System.Windows.Forms.Form
        form = New FModificaDatiOS(parametri.idOS)
        form.ShowDialog()
        If (form.DialogResult = Windows.Forms.DialogResult.OK) Then
            logout()
        End If

    End Sub

End Class

