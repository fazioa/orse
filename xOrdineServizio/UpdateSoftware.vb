'Imports System.Security.AccessControl
Imports System.IO
Public Class UpdateSoftware
    Dim log As New XOrseLog
    Dim i As New InfoScreen
    Dim sVersioneAttuale, sVersioneInRete As String
    Dim feActions As ActionsLibrary = New ActionsLibrary
    Dim sPathDatiSistema As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName

    Public Function lookForNewVersion()
        Dim isAvailable As Boolean
        log.xlogWriteEntry("Controllo disponibilità rete", TraceEventType.Information)
        isAvailable = My.Computer.Network.IsAvailable
        If (isAvailable) Then
            log.xlogWriteEntry("Controllo numero versione disponibile in rete", TraceEventType.Information)
            Dim sNomeFile = "/versione.txt"
            Try
                '===========================
                Dim sFileDest As String = My.Application.Info.DirectoryPath & sNomeFile
                'elimino il file versione.txt, nel caso sia presente
                If Dir(sFileDest) <> "" Then
                    Kill(sFileDest)
                End If
                My.Computer.Network.DownloadFile(My.Settings.urlAggiornamenti.ToString & sNomeFile, sFileDest)
                'mi assicuro che il file sia presente
                If Dir(sFileDest) <> "" Then
                    'se il file è presente allora leggo la prima riga e la confronto con la verione attuale del software
                    Dim file As New IO.StreamReader(sFileDest)
                    'trasformo la stringa in double (es: versione 2.04)
                    '                    Dim iVersioneInRete As Double = stringToDouble(file.ReadLine)
                    sVersioneInRete = file.ReadLine
                    file.Close()
                    'controllo la versione attuale del SW
                    Dim M, min As String
                    With My.Application.Info.Version
                        M = .Major
                        min = Format(.Minor, "00")
                    End With

                    '                    Dim iVersioneAttuale As Double = stringToDouble(M & "." & min)
                    sVersioneAttuale = M & "." & min
                    log.xlogWriteEntry("Versione disponibile in rete nr." & sVersioneInRete, TraceEventType.Information)
                    log.xlogWriteEntry("Versione attuale nr." & sVersioneAttuale, TraceEventType.Information)

                    If (sVersioneInRete > sVersioneAttuale) Then
                        'ritorna valore risposta utente
                        Return True
                        'i.versioneDisponibile_domandaAggiornamento(iVersioneAttuale, iVersioneInRete)
                    Else
                        Return False
                    End If
                Else
                    log.xlogWriteEntry("Errore nello scaricamento del file. File non presente", TraceEventType.Critical)
                    i.erroreDownloadFileVersione()
                End If
                '===========================
            Catch ex As Exception
                log.xlogWriteEntry("Errore nell'accesso alla rete, o file non disponibili", TraceEventType.Critical)
                i.erroreDownloadFileVersione()
            End Try
        Else
            i.reteNonDisponibile()
        End If
        Return False
    End Function

    Private Function stringToDouble(ByVal s As String) As Double
        Try
            Dim d As Double
            'sostituisce la virgola al punto
            Dim newS As String = Replace(s, ".", ",")
            Double.TryParse(newS, d)
            Return d
        Catch ex As Exception
            Return -1
        End Try

    End Function

    Public Sub upgradeDownload()
        '==============================
        '==============================
        '==============================
        Dim FDownload As FDownloadLink = New FDownloadLink(sVersioneAttuale, sVersioneInRete)
        FDownload.Show()

        'aggiornamento applicazione - scaricamento nuova versione
        '==============================
        '==============================
        '==============================

    End Sub

    Public Sub eseguiBackup()
        Dim pathDB As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Dim sPathBackup = ""
        '======== finestra di dialogo file
        Dim saveDialog As SaveFileDialog = New SaveFileDialog()
        saveDialog.InitialDirectory = pathDB
        saveDialog.FileName = "dbAlegatoA_BACKUP.mdb"
        saveDialog.Title = "Esegui backup del dB e delle preferenze"
        If (saveDialog.ShowDialog() = DialogResult.OK) Then
            eseguiDBBackup(saveDialog.FileName)
            Dim sPath = Left(saveDialog.FileName, InStrRev(saveDialog.FileName, "\"))
            eseguiBackupPreferenze(sPath)
        End If
    End Sub

    Public Sub eseguiDBBackup(sPathBackup As String)
        Dim sPathOriginale = sPathDatiSistema & "\dbAlegatoA.mdb"

        'elimino il file dbAlegatoA2, nel caso sia presente
        If File.Exists(sPathBackup) Then
            Kill(sPathBackup)
        End If

        FileCopy(sPathOriginale, sPathBackup)


    End Sub

    Public Sub ripristinaDBBackup(sPathDB As String)


        'sovrascrive il file del DB
        'faccio una copia del DB attuale
        Dim sNomeDBInUso As String = sPathDatiSistema & "\dbAlegatoA.mdb"
      
        If (sPathDB.Equals(sNomeDBInUso)) Then

            i.erroreRipristinoBackupDB_sceltoStessoFile()
            log.xlogWriteEntry("Errore. Ripristino DB non eseguito. Scelto file in uso", TraceEventType.Error)
        Else
            'eseguo backup del DB in uso
            Dim sPathNomeSalvataggioVecchioDB = sNomeDBInUso & ActionsLibrary.getTimeStamp & ".mdb"
            FileCopy(sNomeDBInUso, sPathNomeSalvataggioVecchioDB)

            'messaggio, indica il nome del file di backup
            i.salvataggioBackupVecchioDB(sPathNomeSalvataggioVecchioDB)
            log.xlogWriteEntry("Backup DB --> " & sPathNomeSalvataggioVecchioDB, TraceEventType.Information)

            'cancello il db in uso
            Kill(sNomeDBInUso)

            Try
                'sorgente --> destinazione
                FileCopy(sPathDB, sNomeDBInUso)
                i.ripristinoBackupDB(sPathDB)
                log.xlogWriteEntry("E' stato ripristinato il file " & sPathDB, TraceEventType.Information)
            Catch ex As Exception
                i.erroreRipristinoBackupDB(sPathDB)
                log.xlogWriteEntry("Errore nel ripristino del DB", TraceEventType.Information)
            End Try

        End If
    End Sub

    Public Sub eseguiBackupPreferenze(sPath As String)
        'salvataggio preferenze in un file
        Dim S As New serializzazioneHashTable
        Dim hashTablePreferenze As New Hashtable
        For Each Item As Configuration.SettingsProperty In My.Settings.Properties
            hashTablePreferenze.Add(Item.Name, My.Settings.PropertyValues.Item(Item.Name).PropertyValue)
        Next
        S.salvaHashTable(hashTablePreferenze, sPath)
    End Sub

    Public Sub ripristinaBackupPreferenze(sPath As String)
        Dim S As New serializzazioneHashTable
        Dim hashTablePreferenze As Hashtable = S.loadHashTable(sPath)
        'esegue la lettura dei parametro solo che la hashtable non è vuota
        If (Not hashTablePreferenze Is Nothing) Then
            For Each item As DictionaryEntry In hashTablePreferenze
                My.Settings.PropertyValues.Item(item.Key).PropertyValue = item.Value
            Next
        End If
    End Sub

    Sub ripristinaBackup()
        Dim pathDB As String = sPathDatiSistema
        Dim sPathBackup = ""
        Dim sPathDB = pathDB & "\dbAlegatoA.mdb"
        '======== finestra di dialogo file
        Dim openDialog As OpenFileDialog = New OpenFileDialog
        openDialog.InitialDirectory = pathDB
        openDialog.Filter = "Microsoft Access Files (*.mdb)|*.mdb|All files (*.*)|*.*"
        openDialog.Title = "Ripristina DB da backup"

        If (openDialog.ShowDialog() = DialogResult.OK) Then
            ripristinaDBBackup(openDialog.FileName)

            Dim sPath = Left(openDialog.FileName, InStrRev(openDialog.FileName, "\"))
            ripristinaBackupPreferenze(sPath)
        End If
    End Sub

End Class
