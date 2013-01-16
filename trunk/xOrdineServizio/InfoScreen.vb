Public Class InfoScreen

    Public Sub aggiornamentoDB(ByVal nuovaVersione As String)
        MsgBox("Il database verr� aggiornato alla versione " & nuovaVersione, MsgBoxStyle.Information, "Aggiornamento database")

    End Sub
    Public Sub giainesecuzione()
        MsgBox("Applicazione gi� in esecuzione", MsgBoxStyle.Information, "Avvio applicazione")
    End Sub

    Public Function aggiornamentoApplicazione() As Microsoft.VisualBasic.MsgBoxResult
        Return MsgBox("Verr� controllata la disponibilit� di aggiornamenti in rete.", MsgBoxStyle.OkCancel, "Aggiornamento applicazione")
    End Function
    Public Function versioneDisponibile_domandaAggiornamento(ByVal sVersioneInstallata As String, ByVal sVersioneInRete As String) As Microsoft.VisualBasic.MsgBoxResult
        Return MsgBox("E' disponibile la versione " & sVersioneInRete & " (installata versione " & sVersioneInstallata & vbCrLf & "Scaricare la nuova versione?", MsgBoxStyle.OkCancel, "Aggiornamento applicazione")
    End Function
    Public Sub SWattualeAggiornato()
        MsgBox("La versione gi� installata � la pi� recente.", MsgBoxStyle.Information, "Aggiornamento applicazione")
    End Sub
    Public Sub reteNonDisponibile()
        MsgBox("Rete non disponibile.", MsgBoxStyle.Information, "Aggiornamento applicazione")
    End Sub
    Public Sub erroreDownloadFileVersione()
        MsgBox("Versione online non disponibile o errore nell'accesso alla rete.", MsgBoxStyle.Information, "Aggiornamento applicazione")
    End Sub

    Public Sub salvataggioBackupVecchioDB(ByVal sNomeFile As String)
        MsgBox("E' stata effettuata una copia del vecchio DB, con il nome " & sNomeFile, MsgBoxStyle.Information, "Backup DB")
    End Sub

    Public Sub ripristinoBackupDB(ByVal sNomeFile As String)
        MsgBox("E' stata rispristinato il file DB: " & sNomeFile, MsgBoxStyle.Information, "Ripristino Backup DB")
    End Sub
    Public Sub erroreRipristinoBackupDB(ByVal sNomeFile As String)
        MsgBox("Errore nel ripristino del file: " & sNomeFile, MsgBoxStyle.Information, "Ripristino Backup DB")
    End Sub

    Public Sub erroreRipristinoBackupDB_sceltoStessoFile()
        MsgBox("Errore nel ripristino del file. Attenzione, il file scelto � quello in uso.", MsgBoxStyle.Information, "Ripristino Backup DB")
    End Sub

    Public Shared Sub soggettoGiaPresente()
        MsgBox("ATTENZIONE: Il soggetto che stai inserendo � gi� stato controllato in passato. Clicca sul pulsante verde per recuperare tutti i dati, altrimenti continua per inserirlo come nuovo soggetto (es: omonimia)", MsgBoxStyle.Information, "Soggetto gi� in memoria")
    End Sub


End Class
