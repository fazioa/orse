Imports System.Diagnostics
'Imports System.Threading
Imports System.UnhandledExceptionEventArgs
Imports System.IO
Imports System.Security.AccessControl
Imports CookComputing
Imports CookComputing.XmlRpc


Public Class FPrima


    ' = new UnhandledExceptionEventHandler(this.GLOBALERRORHANDLER);
    'Application.ThreadException +=new ThreadExceptionEventHandler(this.THREADERRORHANDLER);

    Dim feActions As New OrSe.ActionsLibrary
    Dim appPatch As New OrSe.ApplicazionePatch
    Dim infoScreen As New InfoScreen
    Dim parametri As New parametriControllo_e_OS
    Dim log_ As New XOrseLog
    Dim modalitaVisita As Boolean
    Dim bFlagExit As Boolean = False
    Dim log As XOrseLog


    Public Sub New()

        Dim pathDB As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName
        My.Settings.pathCartellaScrivibile = pathDB

        AppDomain.CurrentDomain.SetData("DataDirectory", pathDB)
        'controllo se il file del DB è presente, altrimenti restituisco errore ed esco dall'applicazione
        '        MsgBox(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName, MsgBoxStyle.Information)

        Dim sPathAndDBName = pathDB & "\dbAlegatoA.mdb"
        Dim a As String = System.Reflection.MethodBase.GetCurrentMethod().Name

        'SOLLEVO ECCEZIONE PER TEST
        ' Throw New Exception("operazione non valida.")

        'elimino il file dbAlegatoA2, nel caso sia presente
        Try
            If Not File.Exists(sPathAndDBName) Then
                File.Copy(AppDomain.CurrentDomain.BaseDirectory & My.Settings.nomeDB, sPathAndDBName)

            End If
        Catch ex As Exception
            MsgBox("Errore nella preparazione del file del database. " & ex.Message, MsgBoxStyle.Critical, "ERRORE")
            bFlagExit = True
        End Try


        'se il DB non è raggiungibile allora non viene eseguito InitializeComponent e l'app termina 
        If Not bFlagExit Then
            'try
            ' Dim compatta As New CompattaRipristina
            ' log_.xlogWriteEntry("Compatta DB", TraceEventType.Information)
            ' compatta.DoAction()
            ' Catch ex As Exception
            ' log_.xlogWriteException(ex, TraceEventType.Warning, "Compatta DB - Errore")
            ' End Try

            '======= Controlla la versione del software e si cura di effettuare eventuali modifiche sul DB)
            Dim versioneDBattuale As Double = appPatch.doControlloVersioneDB()

            'controllo se il DB è presente

            Dim bDBPresente As Boolean = True
            If Dir(sPathAndDBName) = "" Then bDBPresente = False


            '===========================================================================================
            If (Double.Parse(My.Settings.versioneDB.Replace(".", ",")) > versioneDBattuale) And bDBPresente Then
                Dim sInfoScreen As New InfoScreen
                sInfoScreen.aggiornamentoDB(My.Settings.versioneDB)
                'lanciare aggiornaVersioneDB indicando la vecchia versione rilevata
                appPatch.aggiornaversioneVersioneDB(versioneDBattuale)
            End If


            If Not bDBPresente Then
                MsgBox("Errore: DB non presente. " & Dir(sPathAndDBName), MsgBoxStyle.Critical, "Errore di avvio")
            Else

                ' This call is required by the Windows Form Designer.

                InitializeComponent()

                ' Add any initialization after the InitializeComponent() call.
            End If
        End If
    End Sub

    Private Sub Form1_myInit()
        'posizioni il cursore sull'ordine di servizio corrente

        Dim nIdOS = OrdineServizioTableAdapter1.FillByID(DbAlegatoADataSet1.ordineServizio, parametri.idOS)
        If nIdOS = 1 Then log_.xlogWriteEntry("Ordine di servizio id nr." & parametri.idOS & " selezionato (" & parametri.nomeOS & " del " & parametri.dataOS & ")", TraceEventType.Information)
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

        Dim myform As New DInsDatiPreliminari(DbAlegatoADataSet1, parametri)
        log_.xlogWriteEntry("Visualizza form per ins. dati preliminari", TraceEventType.Information)
        myform.ShowDialog()
        While (myform.DialogResult() = Windows.Forms.DialogResult.Cancel)
            log_.xlogWriteEntry("Form per ins. dati preliminari restituisce Cancel", TraceEventType.Information)
            myform.ShowDialog()
        End While
        If (myform.DialogResult() <> Windows.Forms.DialogResult.Abort) Then
            log_.xlogWriteEntry("Avvio", TraceEventType.Information)
            parametri = myform.getResultClassParametri()
            setModalitaVisita(False)
            Form1_myInit()
        Else
            parametri.idOS = -1
            log_.xlogWriteEntry("Form per ins. dati preliminari restituisce Abort, pertanto app. avvia in modalità visita", TraceEventType.Information)
            setModalitaVisita(True)
        End If
    End Sub

    Private Sub btnIntervento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntervento.Click
        log_.xlogWriteEntry("Apertura intervento", TraceEventType.Information)
        feActions.doApriFormInterventoInformazioni(parametri, paragrafoOS.interventi)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformazioni.Click
        log_.xlogWriteEntry("Apertura informazioni", TraceEventType.Information)
        feActions.doApriFormInterventoInformazioni(parametri, paragrafoOS.informazioni)
    End Sub

    Private Sub abilitaPulsanteOP85(ByVal b As Boolean)
        OP85ToolStripMenuItem.Enabled = b
    End Sub


    Private Sub btnAlegatoA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlegatoA.Click
        ' Dim timestamp As System.DateTime = System.DateTime.Now.ToString
        feActions.doApriFormAllegatoA(DbAlegatoADataSet1, parametri.Clone)
    End Sub

    Private Sub genericoDataGridView_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs)
        feActions.personalizzaGrid(sender)
    End Sub


    Private Sub apriDettaglioSoggetto(ByRef dgv As DataGridView)
        Dim v As Integer = dgv.CurrentRow.Cells("cID").Value
        parametri.nomeLuogoControllo = dgv.CurrentRow.Cells("cLuogoControllo").Value
        parametri.dataoraControllo = dgv.CurrentRow.Cells("cOra").Value
        feActions.doApriDettaglioSoggetto(DbAlegatoADataSet1, parametri, v)
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
            feActions.doApriDettaglioIntervento(sender, e, nomeColonnaId, parametri)
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
        form = New FOP85(parametri)
        form.Visible = True
    End Sub

    Private Sub CercaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CercaToolStripMenuItem.Click
        feActions.doApriFormRicerca()
    End Sub


    Private Sub logout()
        log_.xlogWriteEntry("Logout", TraceEventType.Information)
        DbAlegatoADataSet1.QInterventi.Clear()
        DbAlegatoADataSet1.QAllegatoA.Clear()
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
            log_.xlogWriteEntry("Visualizza finestra LOG", TraceEventType.Information)
            log_.show()
        Else
            log_.xlogWriteEntry("Nascondi finestra LOG", TraceEventType.Information)
            log_.hide()
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
        log_.xlogWriteEntry("Apertura sopralluogo", TraceEventType.Information)
        feActions.doApriFormSopralluogo(parametri.idOS, parametri.nomeOperatore)
    End Sub

    Private Sub ButtonRubrica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRubrica.Click, ButtonRubrica.Click
        log_.xlogWriteEntry("Apertura rubrica", TraceEventType.Information)
        feActions.doApriFormRubrica(parametri.idOS)
    End Sub


    Private Sub btnRicerca_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        feActions.doApriFormRicerca()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim ec As New DEccezione
        '     ec.test("asdfasdfkahsdjkfhasdjklfhasdkljhjklhjkl")


    End Sub

    Private Sub SopralluogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SopralluogoToolStripMenuItem.Click
        Dim form As System.Windows.Forms.Form
        form = New FSopralluogoAnnotazioneListaStampa(parametri)
        form.Visible = True
    End Sub


    Private Sub labelInfoOS_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelInfoOS.DoubleClick
        'apertura finestra modifica dati OS
        log_.xlogWriteEntry("Apertura form modifica dati OS", TraceEventType.Information)
        'db = db
        Dim form As System.Windows.Forms.Form
        form = New FModificaDatiOS(parametri.idOS)
        form.ShowDialog()
        If (form.DialogResult = Windows.Forms.DialogResult.OK) Then
            logout()
        End If

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        feActions.cancellaFileTemp()
        feActions.invioPeriodicoSegnalazioni()
    End Sub

    Private Sub RevisioneTabelleDatiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RevisioneTabelleDatiToolStripMenuItem.Click
        ActionsLibrary.doApriFormRevisioneTabelle()
    End Sub




    Private Sub ApriCartellaDatabaseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ApriCartellaDatabaseToolStripMenuItem.Click
        System.Diagnostics.Process.Start(My.Settings.pathCartellaScrivibile)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub StampaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StampaToolStripMenuItem.Click

    End Sub


    Public Structure blogInfo
        Public title As String
        Public description As String
    End Structure

    Public Interface IgetCatList
        <CookComputing.XmlRpc.XmlRpcMethod("metaWeblog.newPost")> _
        Function NewPage(ByVal blogId As Integer, ByVal strUserName As String, ByVal strPassword As String, ByVal content As blogInfo, ByVal publish As Integer) As String
    End Interface


    Public clientProtocol As XmlRpcClientProtocol
    Public categories As IgetCatList
    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnPost.Click
        Dim newBlogPost As blogInfo = Nothing
        newBlogPost.title = "Test"
        newBlogPost.description = "Testo del Post"
        categories = CType(XmlRpcProxyGen.Create(GetType(IgetCatList)), IgetCatList)
        clientProtocol = CType(categories, XmlRpcClientProtocol)
        clientProtocol.Url = "http://www.xorse.it/orse/xmlrpc.php"
        Dim result As String = Nothing
        result = ""
        Try
            result = categories.NewPage(1, "tonino", "ttony", newBlogPost, 1)
            MessageBox.Show("Posted to Blog successfullly! Post ID : " & result)
            'txtPost.Text = ""
            'txtTitle.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class


