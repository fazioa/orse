'Classe che definisce le azioni da effettuare in seguito ad un comando dato da uno dei form

Imports OrSe

Imports System.XML.Serialization
Imports System.IO

Public Enum tipoDato
    allegatoA = 1
    interventi = 2
    informazioni = 3
    sopralluoghi = 4
    rubrica = 5
End Enum


Public Enum tipoReport
    allegatoA = 1
    interventi = 2
    op85 = 3
    informazioni = 4
End Enum

Public Enum paragrafoOS
    interventi = 9
    informazioni = 6

End Enum

Public Enum tipoAccompagnatore
    passeggero = 1
    a_piedi = 2
End Enum

Public Class tipoEsitoSDI
    Public noCOPE = "--"
    Public si = "SI"
    Public no = "NO"
End Class
Public Enum tipoFile
    PDF = 1
    WORD = 2
    EXCEL = 3
End Enum

Public Class parametriGenerale
    'classe che può contenere diverse info, da passare come parametro
    Public nomeClasse As String
    Public protocollo As String
    Public protocolloInformatico As String
    ' Public ComandiDestinatari As Array
    Public ComandiDestinatari As List(Of String)
    Public sNote As String
    Public Sub New()
        ComandiDestinatari = New List(Of String)

    End Sub

End Class
Public Class parametriControllo
    'classe che può contenere diverse info, da passare come parametro
    Public idOS As Integer
    Public nomeOS As String
    Public dataOS As Date
    Public idControllo As Integer
    Public idLuogoControllo As Integer
    Public dataoraControllo As Date
    Public nomeLuogoControllo As String
    Public idOperatore As Integer
    Public nomeOperatore As String

End Class

Public Class parametriPersona
    Public cognome As String
    Public nome As String
    Public datanascita As String
    Public luogonascita As String
    Public residenza As String
    Public precedenti As String
    Public mezzo As String
    Public colore As String
    Public targa As String
End Class

Class XOrseLog
    Public Shared LogForm As New FXOrseLog
    Public Sub New()

    End Sub

    Public Sub hide()
        LogForm.Hide()
    End Sub
    Public Sub show()
        LogForm.Show()
    End Sub
    Public Sub xlogWriteEntry(ByVal sMsg As String, ByVal livello As System.Diagnostics.TraceEventType)
#If DEBUG Then
        Dim sMessaggio As String = Now.ToLocalTime + " " + sMsg
        My.Application.Log.WriteEntry(sMessaggio, livello)
        LogForm.add(sMessaggio)
#End If
    End Sub
    Public Sub xlogWriteException(ByVal ex As Exception, ByVal livello As System.Diagnostics.TraceEventType, ByVal addInfo As String)
#If DEBUG Then
        Dim sMessaggio As String = "Gestione errore: " & addInfo & " - livello: " & livello.ToString & " - messaggio sistema: " & ex.ToString
        My.Application.Log.WriteException(ex, livello, addInfo)
        LogForm.add(sMessaggio)
#End If
    End Sub
End Class


Public Class ActionsLibrary
    Dim db As dbAlegatoADataSet
    Dim log As New XOrseLog
    'indica lo stato dell'applicazione. In caso di cancellazione del DB indica all'applicaizone di uscire dall'ordine di servizio corrente
    Public appStateLogin As Boolean = True
    Public Sub New()
        db = New dbAlegatoADataSet()
    End Sub
    'restituisce una stringa costituita da anno mese giorno ora minuti secondi
    Public Function getTimeStamp() As String
        Dim d As Date = DateTime.Now
        getTimeStamp = d.Year & Format(d.Month, "d2") & Format(d.Day, "d2") & Format(d.Hour, "d2") & Format(d.Minute, "d2") & Format(d.Second, "d2")
    End Function

    'apro form intervento
    Public Sub doApriFormInterventoInformazioni(ByVal idOS As Integer, ByVal tipo As paragrafoOS)
        doApriFormInterventoInformazioni(Nothing, Nothing, idOS, tipo)
    End Sub


    Public Sub doApriFormInterventoInformazioni(ByVal dInizio As Date, ByVal dFine As Date, ByVal idOS As Integer, ByVal tipo As paragrafoOS)
        Dim form As System.Windows.Forms.Form
        form = New FIntervento(dInizio, dFine, idOS, tipo)
        form.Visible = True
    End Sub



    Public Sub doApriFormAbout()
        Dim form As System.Windows.Forms.Form
        form = New FAbout()
        form.Visible = True
    End Sub




    Public Sub doApriFormAnteprima(ByVal tos As String, ByVal sNomeOS As String, ByVal tipo As tipoReport)
        Dim form As System.Windows.Forms.Form
        form = New FanteprimaReport(tos, sNomeOS, tipo)
        form.Visible = True
    End Sub


    Public Sub doApriFormOpzioni()
        log.xlogWriteEntry("Apertura preferenze", TraceEventType.Information)
        Dim form As System.Windows.Forms.Form
        form = New opzioni()
        form.Visible = True
    End Sub

    Public Function doArpiFormListaPIO()
        Dim form As OrSe.FElencosoggetti
        form = New FElencosoggetti()
        'restituisce il risultato del dialogForm
        form.ShowDialog()
        'se è stata scelta una persona restituisce l'indice, altrimenti restituisce indice negativo
        If (form.DialogResult = DialogResult.OK) Then
            doArpiFormListaPIO = form.getResult()
        Else
            doArpiFormListaPIO = -1
        End If
    End Function

    'inserimento passeggero
    Public Sub doApriFormAllegatoA(ByRef DataSet As dbAlegatoADataSet, ByRef parametri As parametriControllo, ByVal iOrdine As Integer, ByVal accompagnatore As tipoAccompagnatore)

        log.xlogWriteEntry("Inserimento Controllo e Allegato A - ", TraceEventType.Information)
        db = DataSet
        Dim form As System.Windows.Forms.Form

        'caso di inserimento di un passeggero
        form = New FSoggetto(db, parametri, iOrdine, accompagnatore)
        form.Visible = True

    End Sub

    'caso di nuovo controllo
    Public Sub doApriFormAllegatoA(ByVal DataSet As dbAlegatoADataSet, ByRef parametri As parametriControllo)
        db = DataSet
        log.xlogWriteEntry("Inserimento Controllo e Allegato A", TraceEventType.Information)

        Dim myform As New DInserimentoLuogoControllo(db, parametri)
        'Dim myform As New DInserimentoLuogoControllo()
        Dim form As OrSe.FSoggetto
        'caso di nuovo controllo, perchè la località non è ancora stata selezionata
        myform.ShowDialog()
        If (myform.DialogResult = DialogResult.OK) Then
            'caso di inserimento nuova persona
            'recupero i dati inseriti nel form di inserimento dei dati del controllo
            form = New FSoggetto(db, myform.DialogResultClass(), 0, Nothing)
            form.Visible = True
        End If
    End Sub

    'ritorna vero solo che la griglia è vuota
    Public Function isGridEmpty(ByVal myGrid As System.Windows.Forms.DataGridView) As Boolean
        If (myGrid.RowCount() - 1 = 0) Then
            Return True
        End If
        Return False
    End Function

    Public Sub doPersonalizzaCombo(ByVal sender As System.Object)
        Dim cmbbox As ComboBox = sender
        cmbbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbbox.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Public Function doComboInsNuovoValore(ByRef sender As System.Windows.Forms.ComboBox, ByRef tableAdapter As Object, ByVal datasetTable As Object) As Integer
        Try
            If (sender.Text.Trim.Length > 0 And sender.FindStringExact(sender.Text.Trim) < 0) Then
                log.xlogWriteEntry("Inserimento """ & sender.Text & """ nella tabella """ & datasetTable.ToString & """", TraceEventType.Critical)
                tableAdapter.Insert(sender.Text)
                Dim sTemp = sender.Text
                tableAdapter.Fill(datasetTable)
                sender.Text = sTemp
                Return 1
            End If
        Catch ex As OleDb.OleDbException
            Throw New eccezione(ex, sender)
        End Try
        Return -1
    End Function

    Public Function doComboInsNuovoValore(ByRef sender As UserControlComboBox, ByRef tableAdapter As Object, ByVal datasetTable As Object) As Integer
        Try
            If (sender.Text.Trim.Length > 0 And sender.FindStringExact() <= 0) Then
                log.xlogWriteEntry("Inserimento """ & sender.Text & """ nella tabella """ & datasetTable.ToString & """", TraceEventType.Critical)
                tableAdapter.Insert(sender.Text)
                tableAdapter.Fill(datasetTable)
                Return 1
            End If
        Catch ex As OleDb.OleDbException
            Throw New eccezione(ex, sender)
        End Try
        Return -1
    End Function

    Public Sub doApriDettaglioSoggetto(ByRef db As dbAlegatoADataSet, ByRef parametri As parametriControllo, ByVal v As Integer)
        log.xlogWriteEntry("Apertura dettaglio soggetto", TraceEventType.Information)
        db = db
        Dim form As System.Windows.Forms.Form
        form = New FSoggetto(db, parametri, v)
        form.Show()
    End Sub

    Public Sub doApriDettaglioSopralluogo(ByVal v As Integer, ByVal sOperatori As String)
        log.xlogWriteEntry("Apertura dettaglio sopralluogo", TraceEventType.Information)
        'db = db
        Dim form As System.Windows.Forms.Form
        form = New FSopralluogo(-1, v, sOperatori)
        form.Show()
    End Sub


    Public Sub doApriDettaglioRubrica(ByVal v As Integer)
        log.xlogWriteEntry("Apertura dettaglio rubrica", TraceEventType.Information)
        Dim form As System.Windows.Forms.Form
        form = New FRubrica(-1, v)
        form.Show()
    End Sub

    Public Sub doApriFormRicerca()
        Dim form As System.Windows.Forms.Form
        form = New FRicerca()
        form.Show()
    End Sub

    Public Sub doApriDettaglioIntervento(ByVal dgv As DataGridView, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs, ByVal nomeColonnaId As String)
        log.xlogWriteEntry("Apertura form dettaglio intervento/Informazione", TraceEventType.Information)
        Dim form As System.Windows.Forms.Form
        'il parametro boolean non serve a niente, messo solo per differenziare le firme del costruttore
        form = New FIntervento(dgv.Rows(e.RowIndex).Cells(nomeColonnaId).Value, True)
        form.Show()
    End Sub

    Public Sub doApriFormSopralluogo(ByRef idOS As Integer, ByVal nomiOperatori As String)
        log.xlogWriteEntry("Apertura form sopralluogo", TraceEventType.Information)
        'db = db
        Dim form As System.Windows.Forms.Form
        form = New FSopralluogo(idOS, -1, nomiOperatori) 'passo -1 perchè il parametro idS non mi serve, in questo caso
        form.Show()
    End Sub

    Public Sub doApriFormRubrica(ByRef idOS As Integer)
        log.xlogWriteEntry("Apertura form rubrica", TraceEventType.Information)
        Dim form As System.Windows.Forms.Form
        form = New FRubrica(idOS, -1) 'passo -1 perchè il parametro non mi serve, in questo caso
        form.Show()
    End Sub

    'legge il valore corrente dall'item indicato
    Public Function leggiCampoDB(ByVal databinding As BindingSource, ByVal nomeItem As String)
        Dim drv As DataRowView = databinding.Current
        Dim sVal As String = Nothing
        log.xlogWriteEntry("Legge campo DB: " & nomeItem, TraceEventType.Critical)
        Try
            sVal = drv.Item(nomeItem)
            log.xlogWriteEntry("...val: " & sVal, TraceEventType.Critical)
        Catch ex As Exception
            log.xlogWriteEntry("Errore", TraceEventType.Error)
        End Try


        leggiCampoDB = sVal
    End Function

    'scrive il valore indicato sul recordo corrente del databinding
    Public Sub scriviCampoDB(ByVal databinding As BindingSource, ByVal nomeItem As String, ByVal val As Object)
        Dim drv As DataRowView = databinding.Current
        log.xlogWriteEntry("Scrive campo DB: " & nomeItem & ", val: " & val, TraceEventType.Critical)
        drv.Item(nomeItem) = val
    End Sub


    Public Sub wordScriviSegnalibro(ByVal oWord As Microsoft.Office.Interop.Word.Application, ByVal nome As String, ByVal valore As String)
        If Not oWord Is Nothing Then
            With oWord
                .Selection.GoTo(What:=Microsoft.Office.Interop.Word.WdGoToItem.wdGoToBookmark, Name:=nome)
                log.xlogWriteEntry("Word - scrive su segnalibro """ & nome & """:" & valore, TraceEventType.Critical)
                .Selection.TypeText(Text:=valore)
            End With
        Else
            log.xlogWriteEntry("Word - oggetto oWord vuoto", TraceEventType.Critical)
        End If
    End Sub

    Public Sub wordScrivi(ByVal oWord As Microsoft.Office.Interop.Word.Application, ByVal valore As String)
        oWord.Selection.TypeText(Text:=valore)
    End Sub

    Public Sub wordScriviEnter(ByVal oWord As Microsoft.Office.Interop.Word.Application)
        log.xlogWriteEntry("Word - scrive ENTER", TraceEventType.Critical)
        oWord.Selection.TypeParagraph()
    End Sub

    Public Function wordInizializzaDocumentoOP85(ByVal sParteNomeFile As String)
        Try
            log.xlogWriteEntry("Word - Inizializza documento OP85", TraceEventType.Critical)

            Dim oWord As Microsoft.Office.Interop.Word.Application = CreateObject("Word.Application")
            Dim oDoc As Microsoft.Office.Interop.Word.Application
            Dim strDocumentName As String = ""
            oWord.Visible = True

            Dim sPath As String = Application.StartupPath & "\Resources\automazione\"

            strDocumentName = "op85_" & sParteNomeFile & ".doc"
            Try
                If Dir(sPath & strDocumentName) = "" Then
                    Dim n As String = sPath & strDocumentName
                    log.xlogWriteEntry("Word - Utilizza modello .dot - Scrive file word" & n, TraceEventType.Critical)

                    oWord.Documents.Add(sPath & "op85.dot").SaveAs(FileName:=n)
                Else
                    'Se il file esiste allora fare qualcosa, magari aprire la maschera per la scelta del percorso
                    'oWord.Documents.Add(sPath & "op85.dot").SaveAs(FileName:=sPath & strDocumentName)
                    oWord.Documents.Add(sPath & "op85.dot")
                End If
            Catch ex As Exception
                log.xlogWriteEntry("Word - Gestione eccezione - Probabilmente il SO è windows seven. Impossibile scrivere sul percorso di default.", TraceEventType.Critical)
                oWord.Documents.Add(sPath & "op85.dot")
            End Try
            oWord.Caption = "OP85 - Persone di interesse operativo notate sul territorio"
            oDoc = Nothing
            Return oWord
        Catch ex As Exception
            log.xlogWriteException(ex, TraceEventType.Error, "Word - Inizializza documento OP85 - Errore")
            Return Nothing
        End Try


    End Function
    Public Function wordInizializzaDocumentoVerbaleSopralluogo()
        Try
            log.xlogWriteEntry("Word - Inizializza verbale sopralluogo", TraceEventType.Critical)

            Dim oWord As Microsoft.Office.Interop.Word.Application = CreateObject("Word.Application")
            Dim oDoc As Microsoft.Office.Interop.Word.Application
            Dim strDocumentName As String = ""
            oWord.Visible = True

            Dim sPath As String = Application.StartupPath & "\Resources\automazione\"

            strDocumentName = "verbaleSopralluogo.doc"
            Try
                If Dir(sPath & strDocumentName) = "" Then
                    Dim n As String = sPath & strDocumentName
                    log.xlogWriteEntry("Word - Utilizza modello .dot - Scrive file word" & n, TraceEventType.Critical)

                    oWord.Documents.Add(sPath & "verbaleSopralluogo.dot").SaveAs(FileName:=n)
                Else
                    'Se il file esiste allora fare qualcosa, magari aprire la maschera per la scelta del percorso
                    'oWord.Documents.Add(sPath & "op85.dot").SaveAs(FileName:=sPath & strDocumentName)
                    oWord.Documents.Add(sPath & "verbaleSopralluogo.dot")
                End If
            Catch ex As Exception
                log.xlogWriteEntry("Word - Gestione eccezione - Probabilmente il SO è windows seven. Impossibile scrivere sul percorso di default.", TraceEventType.Critical)
                oWord.Documents.Add(sPath & "verbaleSopralluogo.dot")
            End Try
            oWord.Caption = "Verbale di sopralluogo"
            oDoc = Nothing
            Return oWord
        Catch ex As Exception
            log.xlogWriteException(ex, TraceEventType.Error, "Word - Inizializza verbale di sopralluogo - Errore")
            Return Nothing
        End Try


    End Function

    Public Sub wordAttivaDocumento(ByVal oWord As Microsoft.Office.Interop.Word.Application)
        log.xlogWriteEntry("Word - attiva documento", TraceEventType.Critical)
        'oWord.ActiveDocument.PrintPreview()
        oWord.ActiveDocument.Saved = False
        oWord.Activate()
        oWord = Nothing
    End Sub

    Public Sub personalizzaGrid(ByVal sender As System.Object)
        Dim dgv As DataGridView = sender
        dgv.MultiSelect = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.BackgroundColor = Color.Silver
        dgv.BorderStyle = BorderStyle.FixedSingle
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgv.GridColor = Color.WhiteSmoke
        dgv.RowHeadersVisible = False
        dgv.AllowUserToResizeColumns = True
        dgv.AllowUserToResizeRows = False
        dgv.AllowUserToAddRows = False
        dgv.EditMode = DataGridViewEditMode.EditProgrammatically
        dgv.ReadOnly = True

        dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.ColumnHeadersVisible = False
        dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells

        dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgv.RowHeadersVisible = False
        dgv.ColumnHeadersVisible = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.Dock = DockStyle.Fill

        Dim stile As DataGridViewCellStyle = New DataGridViewCellStyle()
        stile.BackColor() = Color.Azure
        dgv.AlternatingRowsDefaultCellStyle() = stile

    End Sub



    Function valoreDrv(ByVal drv As DataRowView, ByVal val As String)
        If (Not drv.Item(val) Is System.DBNull.Value) Then
            valoreDrv = drv.Item(val)
        Else
            valoreDrv = ""
        End If
    End Function

    Function troncaStringa(ByVal s As String, ByVal l As Integer) As String
        If (s.Length > l) Then
            Return s.Substring(0, l) & "..."
        End If
        Return s
    End Function


    Sub toXmlFile()
        Dim dInizio As DateTime             '= "#01/06/2010 00:00:00#"
        Dim dFine As DateTime               '= "#31/12/2010 23:59:59#"
        Dim dataRange As FDataRange = New FDataRange
        dataRange.ShowDialog()
        dInizio = dataRange.getStartDateResult()
        dFine = dataRange.getEndDateResult
        'trasformo le date per eseguire la ricerca dalla mezzanotte della data di part alla mezzanotte della data di fine

        dInizio = New Date(dInizio.Year, dInizio.Month, dInizio.Day, 0, 0, 0)
        dFine = New Date(dFine.Year, dFine.Month, dFine.Day, 23, 59, 59)
      


        Dim fDialog As SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        fDialog.Title = "Salva file OrSe"
        fDialog.Filter = "Orse Files|*.OrSe"
        fDialog.AddExtension = True
        fDialog.DefaultExt = ".OrSe"
        fDialog.FileName = "orseExport.OrSe"
        If (fDialog.ShowDialog() = DialogResult.OK) Then
            Dim os As New OrSe.FillTreeOS


            'AllegatoA
            Dim writer As New XmlSerializer(GetType(dbAlegatoADataSet.QAllegatoADataTable))
            Dim file As New StreamWriter("ordiniServizioAllegatoAData.OrseXML")
            Dim d As New dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
            d.FillByDataRange(db.QAllegatoA, dInizio, dFine)
            writer.Serialize(file, db.QAllegatoA)
            file.Close()


            'Informazioni
            writer = New XmlSerializer(GetType(dbAlegatoADataSet.QInterventiDataTable))
            file = New StreamWriter("ordiniServizioInformazioniData.OrseXML")
            Dim d2 As New dbAlegatoADataSetTableAdapters.QInterventiTableAdapter
            d2.FillByDataRange(db.QInterventi, paragrafoOS.informazioni, dInizio, dFine)
            writer.Serialize(file, db.QInterventi)
            file.Close()

            'Interventi
            file = New StreamWriter("ordiniServizioInterventiData.OrseXML")
            Dim d3 As New dbAlegatoADataSetTableAdapters.QInterventiTableAdapter
            d3.FillByDataRange(db.QInterventi, paragrafoOS.interventi, dInizio, dFine)
            writer.Serialize(file, db.QInterventi)
            file.Close()

            'Sopralluogo
            writer = New XmlSerializer(GetType(dbAlegatoADataSet.QSopralluogoDataTable))
            file = New StreamWriter("ordiniServizioSopralluogoData.OrseXML")
            Dim d4 As New dbAlegatoADataSetTableAdapters.QSopralluogoTableAdapter
            d4.FillByDataRange(db.QSopralluogo, dInizio, dFine)
            writer.Serialize(file, db.QSopralluogo)
            file.Close()

            'Rubrica
            writer = New XmlSerializer(GetType(dbAlegatoADataSet.QRubricaDataTable))
            file = New StreamWriter("ordiniServizioRubricaData.OrseXML")
            Dim d5 As New dbAlegatoADataSetTableAdapters.QRubricaTableAdapter
            d5.FillByDataRange(db.QRubrica, dInizio, dFine)
            writer.Serialize(file, db.QRubrica)
            file.Close()


            Try
                Using zip As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile
                    zip.AddFile("ordiniServizioAllegatoAData.OrseXML", "")
                    zip.AddFile("ordiniServizioInformazioniData.OrseXML", "")
                    zip.AddFile("ordiniServizioInterventiData.OrseXML", "")
                    zip.AddFile("ordiniServizioSopralluogoData.OrseXML", "")
                    zip.AddFile("ordiniServizioRubricaData.OrseXML", "")
                    zip.Save(fDialog.FileName)
                End Using
                System.IO.File.Delete("ordiniServizioAllegatoAData.OrseXML")
                System.IO.File.Delete("ordiniServizioInformazioniData.OrseXML")
                System.IO.File.Delete("ordiniServizioInterventiData.OrseXML")
                System.IO.File.Delete("ordiniServizioSopralluogoData.OrseXML")
                System.IO.File.Delete("ordiniServizioRubricaData.OrseXML")

            Catch ex1 As Exception
                Throw New eccezione(ex1.ToString)
            End Try

        End If

    End Sub

    Sub fromXmlFile()

        'Dim reader As New XmlSerializer(GetType(dbAlegatoADataSet.QAllegatoADataTable))
        Dim fDialog As OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        fDialog.Title = "Apri file OrseXML"
        fDialog.Filter = "Orse Files|*.OrSe"
        If (fDialog.ShowDialog() = DialogResult.OK) Then

            Try
                Using zip As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(fDialog.FileName)
                    Dim e As Ionic.Zip.ZipEntry
                    For Each e In zip
                        Dim s = e.FileName
                        System.IO.File.Delete("ordiniServizioAllegatoAData.OrseXML")
                        System.IO.File.Delete("ordiniServizioInformazioniData.OrseXML")
                        System.IO.File.Delete("ordiniServizioInterventiData.OrseXML")
                        System.IO.File.Delete("ordiniServizioSopralluogoData.OrseXML")
                        System.IO.File.Delete("ordiniServizioRubricaData.OrseXML")

                        e.Extract()
                        Select Case s
                            Case "ordiniServizioAllegatoAData.OrseXML"
                                inserisci(tipoDato.allegatoA, s)
                                System.IO.File.Delete("ordiniServizioAllegatoAData.OrseXML")
                            Case "ordiniServizioInformazioniData.OrseXML"
                                inserisci(tipoDato.informazioni, s)
                                System.IO.File.Delete("ordiniServizioInformazioniData.OrseXML")
                            Case "ordiniServizioInterventiData.OrseXML"
                                inserisci(tipoDato.interventi, s)
                                System.IO.File.Delete("ordiniServizioInterventiData.OrseXML")

                            Case "ordiniServizioSopralluogoData.OrseXML"
                                inserisci(tipoDato.sopralluoghi, s)
                                System.IO.File.Delete("ordiniServizioSopralluogoData.OrseXML")

                            Case "ordiniServizioRubricaData.OrseXML"
                                inserisci(tipoDato.rubrica, s)
                                System.IO.File.Delete("ordiniServizioRubricaData.OrseXML")

                        End Select
                    Next
                End Using
            Catch ex1 As Exception
                Throw New eccezione("Errore estrazione file - " & ex1.ToString)
            End Try
        End If
    End Sub
    Private Sub inserisci(ByVal t As tipoDato, ByVal nomeFile As String)
        Try
            Dim Obj As Xml.XmlDocument
            Dim orseNodeList As Xml.XmlNodeList = Nothing
            Dim orseNode, campo As Xml.XmlNode
            Dim idControllo As Integer
            'accesso al fileQAllegatoA
            Obj = New Xml.XmlDocument
            '  Obj.async = False
            Obj.Load(nomeFile)
            'seleziono il nodo da leggere
            Select Case t
                Case tipoDato.allegatoA
                    orseNodeList = Obj.GetElementsByTagName("QAllegatoA")
                    'interventi ed informazioni sono contenuti nella stessa tabella ma in questo caso sono stati divisi in due file distinti
                Case tipoDato.interventi
                    orseNodeList = Obj.GetElementsByTagName("QInterventi")
                Case tipoDato.informazioni
                    orseNodeList = Obj.GetElementsByTagName("QInterventi")
                Case tipoDato.sopralluoghi
                    orseNodeList = Obj.GetElementsByTagName("QSopralluogo")
                Case tipoDato.rubrica
                    orseNodeList = Obj.GetElementsByTagName("QRubrica")
            End Select

            'leggo tutti i dati del libro
            Dim a As New System.Collections.Hashtable

            'PROGRESS BAR

            Dim pb As New FProgressionBar()
            pb.Show()
            pb.Maximum(orseNodeList.Count)

            For Each orseNode In orseNodeList
                For Each campo In orseNode.ChildNodes()
                    Try
                        a.Add(campo.Name, campo.InnerText)
                        'log.xlogWriteEntry(campo.Name & " - " & campo.InnerText, TraceEventType.Information)
                    Catch ex As Exception
                        log.xlogWriteEntry("Errore lettura dati da file XML " & nomeFile, TraceEventType.Error)
                    End Try

                Next
                'se l'op non esiste allora viene inserito, altrimento la funz restituisce l'id
                pb.PerformStep()

                Dim idOperatori = inserimentoOperatori(a.Item("operatori").ToString())
                'passo anche l'ID operatori così se l'OS non esiste già allora lo inserisco. (in questo caso serve l'idOperatori)
                Dim idOS = inserimentoOS(a.Item("nomeOS").ToString(), a.Item("dataOS"), idOperatori)

                Select Case t
                    Case tipoDato.allegatoA
                        If (Not (a.Item("luogo") Is Nothing Or a.Item("dataora") Is Nothing)) Then
                            'se luogo o data sono vuoti allora c'è un'incongruenza sui dati. Ignori l'inserimento.
                            'E' capitato che alcuni inserimenti eseguiti in presenza di bug mancasso il luogo del controllo
                            idControllo = inserimentoControllo(a.Item("dataora"), a.Item("luogo"), idOS)
                            Dim idPersona = inserimentoPersone(a, idOS, idControllo)
                            If (idPersona > 0) Then inserimentoVoceAllegatoA(a, idControllo, idPersona)
                        Else
                            log.xlogWriteEntry("Incongruenza dati. Viene ignorato il seguente inserimento: luogo=" & a.Item("luogo") & ", dataora: " & a.Item("dataora") & ". Persona: " & a.Item("cognome") & ", nome: " & a.Item("nome"), TraceEventType.Critical)
                        End If
                    Case tipoDato.informazioni
                        inserimentoInterventiInformazioni(a, idOS)
                    Case tipoDato.interventi
                        inserimentoInterventiInformazioni(a, idOS)
                    Case tipoDato.sopralluoghi
                        inserimentoSopralluogo(a, idOS)
                    Case tipoDato.rubrica
                        inserimentoRubrica(a, idOS)
                End Select
                a.Clear()
            Next
            pb.Dispose()

        Catch ex As Exception
            Throw New eccezione(ex, "Errore nell'importazione dei dati XML")
        End Try

    End Sub

    Private Function inserimentoControllo(ByVal d As Date, ByVal sLuogo As String, ByVal idOS As Integer)
        Dim dControllo As New dbAlegatoADataSet.controlloDataTable
        Dim t As New dbAlegatoADataSetTableAdapters.controlloTableAdapter
        Dim idLuogo, idControllo As Integer
        Dim dLuogo As New dbAlegatoADataSet.luoghicontrolloDataTable
        Dim tLuogo As New dbAlegatoADataSetTableAdapters.luoghicontrolloTableAdapter

        'se sLuogo è nothing si solleva un eccezione. Allora se è nothing posto la stringa a ""
        If (sLuogo = Nothing) Then sLuogo = ""
        'se il luogo non esiste allora lo inserisco, e poi ne prendo l'ID
        tLuogo.FillByName(dLuogo, sLuogo)
        If (dLuogo.Count <= 0) Then
            log.xlogWriteEntry("Inserimento luogo controllo:" & sLuogo & ", id:" & idLuogo, TraceEventType.Critical)
            tLuogo.Insert(sLuogo)
            idLuogo = tLuogo.MaxID()

        Else
            idLuogo = dLuogo.Item(0).id
        End If
        t.Fill_ricercaDoppione(dControllo, d, idLuogo, idOS)
        If (dControllo.Count > 0) Then
            'se c'è già allora restituisco l'id, altrimenti inserisco
            log.xlogWriteEntry("Inserimento controllo - IGNORATO, perchè già esistente, idLuogo: " & idLuogo & ", data: " & d & "idOS:" & idOS, TraceEventType.Critical)
            Return dControllo.Item(0).ID
        Else
            'inserisco il controllo
            log.xlogWriteEntry("Inserimento controllo, idLuogo: " & idLuogo & ", data: " & d & "idOS:" & idOS, TraceEventType.Critical)
            t.Insert(d, idLuogo, idOS)
            idControllo = t.MaxID()
            log.xlogWriteEntry("Inserimento controllo, idControllo: " & idControllo, TraceEventType.Critical)
            Return idControllo
        End If
        Return -1
    End Function


    Public Function inserimentoPersone(ByVal a As System.Collections.Hashtable, ByVal idOS As Integer, ByVal idControllo As Integer)
        Dim idPersona As Integer = -1
        Dim dPersona As New dbAlegatoADataSet.personaDataTable
        Dim t As New dbAlegatoADataSetTableAdapters.personaTableAdapter

        Dim idLuogoNascita, idLuogoResidenza As Integer
        'trovo gli id delle città di nascita e residenza
        idLuogoNascita = cittaToID(a.Item("cittanascita"))
        idLuogoResidenza = cittaToID(a.Item("cittaresidenza"))

        Dim sCognome = IIf(a.Item("cognome") = Nothing, "", a.Item("cognome"))
        Dim sNome = IIf(a.Item("nome") = Nothing, "", a.Item("nome"))
        Dim bFlagInserimentoPersona As Boolean = True
        Dim dDataNascita As Date

        If (a.Item("datanascita") = Nothing) Then
            bFlagInserimentoPersona = False
        Else
            dDataNascita = a.Item("datanascita")
        End If

        If idLuogoNascita < 0 Or sCognome = "" Or sNome = "" Then bFlagInserimentoPersona = False


        If Not bFlagInserimentoPersona Then 'se non ci sono dati di identificazione certi, allora ometto la ricerca e l'inserimento
            log.xlogWriteEntry("Inserimento persona OMESSO per mancanza dati d'identificazione completi", TraceEventType.Critical)
            idPersona = -1
        Else
            t.FillByDati(dPersona, sCognome, sNome, idLuogoNascita, dDataNascita)
            If (dPersona.Count > 0) Then
                'prendi id
                idPersona = dPersona.Item(0).ID
            Else
                'inserisce e poi prendi id
                'fare il validate dei dati. nothing non è consentito

                Dim sResidenzaIndirizzo = IIf(a.Item("residenzaindirizzo") = Nothing, "", a.Item("residenzaindirizzo"))
                Dim sDocumento = IIf(a.Item("documento") = Nothing, "", a.Item("documento"))
                Dim sPrecedenti = IIf(a.Item("precedenti") = Nothing, "", a.Item("precedenti"))
                Dim bPio As Boolean = IIf(a.Item("pio") = Nothing, False, a.Item("pio"))


                log.xlogWriteEntry("Inserimento persona, Cognome e Nome: " & sCognome & " " & sNome, TraceEventType.Critical)
                t.Insert(sCognome, sNome, idLuogoNascita, sResidenzaIndirizzo, idLuogoResidenza, sDocumento, sPrecedenti, bPio, dDataNascita)
                idPersona = t.MaxID
            End If
        End If
        Return idPersona
    End Function

    Private Function inserimentoVoceAllegatoA(ByVal a As Hashtable, ByVal idControllo As Integer, ByVal idPersona As Integer)
        Dim ds As New dbAlegatoADataSet.allegatoADataTable
        Dim t As New dbAlegatoADataSetTableAdapters.allegatoATableAdapter

        t.FillByidPersona_idControllo(ds, idControllo, idPersona)
        If (ds.Count <= 0) Then
            'se sono qui vuol dire che la voce in allegato A non esiste.
            'inserisco 
            Dim iOrdine As Integer = a.Item("ordine")
            Dim sColore As String = IIf(a.Item("colore") = Nothing, "", a.Item("colore"))
            Dim sTarga As String = IIf(a.Item("targa") = Nothing, "", a.Item("targa"))
            Dim bContravvenzioni As Boolean = IIf(a.Item("contravvenzioni") = Nothing, False, a.Item("contravvenzioni"))
            Dim bPerquisizioni As Boolean = IIf(a.Item("perquisizioni") = Nothing, False, a.Item("perquisizioni"))
            Dim sPositivoSDI As String = IIf(a.Item("positivoSDI") = Nothing, "", a.Item("positivoSDI"))
            Dim sNote As String = IIf(a.Item("note") = Nothing, "", a.Item("note"))

            log.xlogWriteEntry("Inserimento riga allegatoA, idControllo:" & idControllo & ", mezzo:" & a.Item("mezzo") & " " & sTarga, TraceEventType.Critical)
            Dim idMezzo As Integer = mezzoToID(a.Item("mezzo"))
            Return t.Insert(idControllo, iOrdine, idMezzo, sColore, sTarga, idPersona, bContravvenzioni, bPerquisizioni, sPositivoSDI, sNote)
        Else
            log.xlogWriteEntry("Inserimento riga allegatoA - IGNORATA - idPersona=" & idPersona & " - idControllo= " & idControllo, TraceEventType.Critical)
            Return ds.Item(0).id
        End If
        Return -1
    End Function

    Private Function cittaToID(ByVal sNomeCitta As String)
        Static Dim dL As New dbAlegatoADataSet.comuneDataTable
        Static Dim ta As New dbAlegatoADataSetTableAdapters.comuneTableAdapter
        If (Not sNomeCitta Is Nothing) Then
            ta.FillByComune(dL, sNomeCitta)
            If (dL.Count > 0) Then
                Return dL.Item(0).id
            Else
                Return -1
            End If
        End If
        Return -1
    End Function

    Private Function mezzoToID(ByVal sNomeMezzo As String) As Integer
        If sNomeMezzo Is Nothing Then
            sNomeMezzo = " "
        End If


        Dim dM As New dbAlegatoADataSet.modelliMezzoDataTable
        Dim t As New dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter
        Dim idMezzo As Integer
        'se il luogo non esiste allora lo inserisco, e poi ne prendo l'ID


        If (t.FillByMezzo_stringaEsatta(dM, sNomeMezzo) <= 0) Then
            t.Insert(sNomeMezzo)
            idMezzo = t.MaxID()
        Else
            idMezzo = dM.Item(0).id
        End If
        Return idMezzo
    End Function

    'la funzione inserisce un intervento/informazione in base ai dati indicati nell'hastable a
    Private Function inserimentoInterventiInformazioni(ByVal a As System.Collections.Hashtable, ByVal idOS As Integer)

        If Not (a.Item("dataOraInizio") = Nothing Or a.Item("dataOraFine") = Nothing) Then

            Dim dQI As New dbAlegatoADataSet.QInterventiDataTable
            Dim tQInterventi As New dbAlegatoADataSetTableAdapters.QInterventiTableAdapter

            'se dataorainizio e fine sono valorizzati allora proseguo. FAccio questo perchè alcuni inserimenti in passato sono stati fatti male, ed a volte dataorainizio è nullo
            '  If Not (a.Item("dataOraInizio") = Nothing Or a.Item("dataOraFine") = Nothing Or a.Item("iParagrafo") = Nothing) Then
            Dim dataOraInizio As DateTime = a.Item("dataOraInizio")
            Dim dataOraFine As DateTime = a.Item("dataOraFine")

            Dim tipointervento As String = a.Item("tipointervento")
            Dim resoconto As String = a.Item("resoconto")
            Dim iParagrafo As Integer = a.Item("iParagrafo")


            'controllo doppione
            Dim c As Integer = -1


            c = tQInterventi.FillRicercaDoppione(dQI, resoconto, idOS)

            If (c <= 0) Then
                Dim i As Integer
                log.xlogWriteEntry("Inserimento intervento/informazione. idOS:" & idOS & ", inizio: " & dataOraInizio & ", fine:" & dataOraFine, TraceEventType.Critical)
                Dim d As New dbAlegatoADataSet.interventiDataTable
                Dim tInterventi As New dbAlegatoADataSetTableAdapters.interventiTableAdapter

                i = tInterventi.Insert(dataOraInizio, dataOraFine, tipointervento, resoconto, idOS, iParagrafo)
                Return i
            Else
                log.xlogWriteEntry("Inserimento intervento/informazione IGNORATO, perchè già presente. idOS:" & idOS & ", inizio: " & dataOraInizio & ", fine:" & dataOraFine, TraceEventType.Critical)
                Return -1
            End If
        Else
            'se dataOraInizio o dataOraFine è nullo allora ignoro l'inserimento
            log.xlogWriteEntry("Incongruenza dati Intervento/Informazione. La data/ora di inizio o fine è nulla. L'inserimento viene ignorato.", TraceEventType.Critical)
        End If
        Return -1
    End Function



    'la funzione inserisce la stringa f nella tabella operatori, solo se tale stringa non è già presente
    Public Function inserimentoOperatori(ByVal s As String) As Integer
        Dim id As Integer = -1
        'creo dataset e tableadapter, faccio il fill, cerco il valore, se non c'è allora lo inserisco
        Dim d As New dbAlegatoADataSet.operatoreDataTable
        Dim t As New OrSe.dbAlegatoADataSetTableAdapters.operatoreTableAdapter
        If (t.FillByNomeOperatore(d, s) > 0) Then
            'log.xlogWriteEntry("Operatore già presente, non iserisco e restituisco l'id del record già presente", TraceEventType.Information)
            id = d.Item(0).id
        Else
            log.xlogWriteEntry("Inserimento """ & s & """ nella tabella """ & d.ToString & """", TraceEventType.Critical)
            If (t.Insert(s) > 0) Then
                id = t.ScalarQuery_lastID()
            Else
                log.xlogWriteEntry("Errore nell'inserimento degli operatori", TraceEventType.Error)
                id = -1
            End If
        End If
        Return id
    End Function

    Public Function inserimentoSopralluogo(ByVal a As System.Collections.Hashtable, ByVal idOS As Integer) As Integer
        If Not (a.Item("oraRedazione") = Nothing Or a.Item("oraRichiesta") = Nothing) Then

            Dim dQS As New dbAlegatoADataSet.QSopralluogoDataTable
            Dim tQSopralluogo As New dbAlegatoADataSetTableAdapters.QSopralluogoTableAdapter

            'se oraRedazione e oraRichiesta sono valorizzati allora proseguo. 

            Dim dataOraRichiesta As DateTime = a.Item("oraRedazione")
            Dim dataOraRedazione As DateTime = a.Item("oraRichiesta")

            Dim sTipoReato As String = a.Item("tipoReato")
            Dim sLuogo_citta As String = a.Item("luogo_citta")
            Dim sVia As String = a.Item("via")
            Dim sContatti_con As String = a.Item("contatti_con")
            Dim sResoconto As String = a.Item("resoconto")


            'controllo doppione
            Dim c As Integer = -1

            'cerco il doppione solo confrontando idOS e oraRichiesa
            c = tQSopralluogo.FillByRicercaDoppione(dQS, idOS, "#" & dataOraRichiesta & "#")


            If (c <= 0) Then
                Dim i As Integer
                log.xlogWriteEntry("Inserimento sopralluogo. idOS:" & idOS & ", dataOraRichiesta: " & dataOraRichiesta, TraceEventType.Critical)
                Dim d As New dbAlegatoADataSet.QSopralluogoDataTable
                Dim tSopralluogo As New dbAlegatoADataSetTableAdapters.sopralluogoTableAdapter

                i = tSopralluogo.Insert(idOS, sTipoReato, dataOraRichiesta, sLuogo_citta, sVia, sContatti_con, sResoconto, dataOraRedazione)
                Return i
            Else
                log.xlogWriteEntry("Inserimento sopralluogo IGNORATO, perchè già presente. idOS:" & idOS & ", inizio: " & dataOraRichiesta, TraceEventType.Critical)
                Return -1
            End If
        Else
            'se dataOraInizio o dataOraFine è nullo allora ignoro l'inserimento
            log.xlogWriteEntry("Incongruenza dati sopralluogo. L'inserimento viene ignorato.", TraceEventType.Critical)
        End If
        Return -1
    End Function

    Public Function inserimentoRubrica(ByVal a As System.Collections.Hashtable, ByVal idOS As Integer) As Integer
        If Not (a.Item("testo") = Nothing) Then

            Dim dR As New dbAlegatoADataSet.rubricaDataTable
            Dim tRubrica As New dbAlegatoADataSetTableAdapters.rubricaTableAdapter

            Dim sTesto As String = a.Item("testo")

            'controllo doppione
            Dim c As Integer = -1

            'cerco il doppione solo confrontando idOS e oraRichiesa
            c = tRubrica.FillByRicercaDoppione(dR, idOS, sTesto)


            If (c <= 0) Then
                Dim i As Integer
                log.xlogWriteEntry("Inserimento voce rubrica. idOS:" & idOS, TraceEventType.Critical)
                Dim tSopralluogo As New dbAlegatoADataSetTableAdapters.rubricaTableAdapter
                i = tSopralluogo.Insert(idOS, sTesto)
                Return i
            Else
                log.xlogWriteEntry("Inserimento voce rubrica IGNORATO, perchè già presente. idOS:" & idOS, TraceEventType.Critical)
                Return -1
            End If
        Else
            'se ci sono errori allora ignoro l'inserimento
            log.xlogWriteEntry("Incongruenza dati rubrica. L'inserimento viene ignorato.", TraceEventType.Critical)
        End If
        Return -1
    End Function

    Private Function inserimentoOS(ByVal nomeOS As String, ByVal dataOS As String, ByVal idOperatori As Integer)
        Dim idOS As Integer
        Dim OrdineServizioTableAdapter As New OrSe.dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter
        Dim datasetOS As New dbAlegatoADataSet.ordineServizioDataTable
        If (OrdineServizioTableAdapter.FillByDataNome(datasetOS, Date.Parse(dataOS).Date, nomeOS) > 0) Then
            'sono qui se l'OS esiste già
            idOS = datasetOS.Item(0).ID
        Else
            'se non esiste allora lo inserisco
            log.xlogWriteEntry("Inserimento """ & nomeOS & """ del """ & Date.Parse(dataOS).Date & """", TraceEventType.Critical)
            If (OrdineServizioTableAdapter.Insert(nomeOS, Date.Parse(dataOS).Date, idOperatori) > 0) Then
                idOS = OrdineServizioTableAdapter.MaxID()
            Else
                log.xlogWriteEntry("Errore nell'inserimento dell'ordine di servizio", TraceEventType.Error)
                idOS = -1
            End If
        End If
        Return idOS

    End Function



    Public Sub clearDB()
        Dim bDomanda1 As Boolean = MsgBox("Cancellare tutti i dati contenuti nel database?", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Cancellazione database") = MsgBoxResult.Ok
        Dim bDomanda2 As Boolean = False
        If bDomanda1 Then bDomanda2 = MsgBox("ATTENZIONE, tutti i dati contenuti nel database verranno cancellati definitivamente! (escluso elenco Comuni e Stati)", MsgBoxStyle.OkCancel Or MsgBoxStyle.DefaultButton2, "Cancellazione database") = MsgBoxResult.Ok

        If bDomanda1 And bDomanda2 Then

            cancellaTabellaAllegatoA()
            cancellaTabellaControllo()
            cancellaTabellaPersone()
            cancellaTabellaMezzo()


            cancellaTabellaInterventi()
            cancellaTabellaSopralluogo()
            cancellaTabellaRubrica()

            cancellaTabellaLuoghiControllo()
            cancellaTabellaPrioritaComune()
            cancellaTabellaOrdineServizio()
            cancellaTabellaOperatore()
            'inserisce lo stato di logout, l'applicazione esce dallordine di servizio corrente
            appStateLogin = False
        End If
    End Sub

    Private Sub cancellaTabellaOrdineServizio()
        Dim tabellaOrdineServizio As dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter = New dbAlegatoADataSetTableAdapters.ordineServizioTableAdapter()
        tabellaOrdineServizio.DeleteAll()
        tabellaOrdineServizio.Update(db)
    End Sub
    Private Sub cancellaTabellaInterventi()
        Dim tabellaInterventi As dbAlegatoADataSetTableAdapters.interventiTableAdapter = New dbAlegatoADataSetTableAdapters.interventiTableAdapter()
        tabellaInterventi.DeleteAll()
        tabellaInterventi.Update(db)
    End Sub

    Private Sub cancellaTabellaSopralluogo()
        Dim tabellaSopralluogo As dbAlegatoADataSetTableAdapters.sopralluogoTableAdapter = New dbAlegatoADataSetTableAdapters.sopralluogoTableAdapter()
        tabellaSopralluogo.Deleteall()
        tabellaSopralluogo.Update(db)
    End Sub

    Private Sub cancellaTabellaRubrica()
        Dim tabellaRubrica As dbAlegatoADataSetTableAdapters.rubricaTableAdapter = New dbAlegatoADataSetTableAdapters.rubricaTableAdapter()
        tabellaRubrica.Deleteall()
        tabellaRubrica.Update(db)
    End Sub

    Private Sub cancellaTabellaPersone()
        Dim tabellaPersone As dbAlegatoADataSetTableAdapters.personaTableAdapter = New dbAlegatoADataSetTableAdapters.personaTableAdapter()
        tabellaPersone.DeleteAll()
        tabellaPersone.Update(db)
    End Sub
    Private Sub cancellaTabellaControllo()
        Dim tabellaControllo As dbAlegatoADataSetTableAdapters.controlloTableAdapter = New dbAlegatoADataSetTableAdapters.controlloTableAdapter()
        tabellaControllo.DeleteAll()
        tabellaControllo.Update(db)
    End Sub
    Private Sub cancellaTabellaMezzo()
        Dim modelliMezzoTableAdapter As dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter = New dbAlegatoADataSetTableAdapters.modelliMezzoTableAdapter()
        modelliMezzoTableAdapter.DeleteAll()
        modelliMezzoTableAdapter.Update(db)
    End Sub
    Private Sub cancellaTabellaLuoghiControllo()
        Dim tabellaLuoghiControllo As dbAlegatoADataSetTableAdapters.luoghicontrolloTableAdapter = New dbAlegatoADataSetTableAdapters.luoghicontrolloTableAdapter
        tabellaLuoghiControllo.DeleteAll()
        tabellaLuoghiControllo.Update(db)
    End Sub
    Private Sub cancellaTabellaOperatore()
        Dim tabellaOperatore As dbAlegatoADataSetTableAdapters.operatoreTableAdapter = New dbAlegatoADataSetTableAdapters.operatoreTableAdapter
        tabellaOperatore.DeleteAll()
        tabellaOperatore.Update(db)
    End Sub
    Private Sub cancellaTabellaAllegatoA()
        Dim tabellaAllegatoA As dbAlegatoADataSetTableAdapters.allegatoATableAdapter = New dbAlegatoADataSetTableAdapters.allegatoATableAdapter
        tabellaAllegatoA.DeleteAll()
        tabellaAllegatoA.Update(db)
    End Sub
    Private Sub cancellaTabellaPrioritaComune()
        Dim tabellaPrioritaComune As dbAlegatoADataSetTableAdapters.prioritaComuneTableAdapter = New dbAlegatoADataSetTableAdapters.prioritaComuneTableAdapter
        tabellaPrioritaComune.DeleteAll()
        tabellaPrioritaComune.Update(db)
    End Sub


    Public Function esegueSQL(ByVal sComandoSQL As String)
        'non gestisce alcuna eccezione
        Dim objconn As New OleDb.OleDbConnection(My.Settings.dbAlegatoAConnectionString)
        Dim objcomm As New OleDb.OleDbCommand(sComandoSQL, objconn)
        objconn.Open()
        log.xlogWriteEntry("Esegue comando SQL: " & sComandoSQL, TraceEventType.Information)
        Dim nrRighe = objcomm.ExecuteNonQuery()
        Return nrRighe
    End Function


    Public Sub doUpgrade()
        Dim InfoScreen As New InfoScreen
        If (InfoScreen.aggiornamentoApplicazione() = MsgBoxResult.Ok) Then
            Dim updateSW As UpdateSoftware = New UpdateSoftware
            Dim b As Boolean = updateSW.lookForNewVersion()
            If b Then
                updateSW.eseguiDBBackup()
                updateSW.upgradeDownload()
            Else
                InfoScreen.SWattualeAggiornato()
            End If
        End If
    End Sub
    Sub doDBBackup()
        Dim updateSW As UpdateSoftware = New UpdateSoftware
        updateSW.eseguiDBBackup()
    End Sub
    Sub doRipristinaDBBackup()
        Dim updateSW As UpdateSoftware = New UpdateSoftware
        updateSW.ripristinaDBBackup()
    End Sub

    Sub setStandardFormSize(ByVal f As Form)
        f.Size = New Size(My.Settings.formWidth, My.Settings.formHeight)
        f.StartPosition = FormStartPosition.CenterScreen
    End Sub

End Class
