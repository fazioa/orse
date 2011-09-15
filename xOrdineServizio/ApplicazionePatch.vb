Public Class ApplicazionePatch
    Dim feActions As New OrSe.ActionsLibrary
    Dim log As New XOrseLog

    Private Function patch1_creaTabellaVersione()
        'crea tabella ed inserisce il numero versione DB 2.00
        feActions.esegueSQL("CREATE TABLE versione (id COUNTER CONSTRAINT ChiavePrimariaConstraint PRIMARY KEY, numeroversione CHAR, about CHAR );")
        Dim versione As dbAlegatoADataSetTableAdapters.versioneTableAdapter = New dbAlegatoADataSetTableAdapters.versioneTableAdapter
        Dim sVersionePartenza = "2.00"
        versione.Insert("", sVersionePartenza)
        Return sVersionePartenza
    End Function

    Private Function patch2_aggiornamentoMaxsizeCampoLuogoControllo()
        'esegue update del campo luogo controllo, passando da 50 caratteri massimi a 150, inserisce il numero versione DB 2.10
        feActions.esegueSQL("ALTER TABLE luoghicontrollo ALTER COLUMN luogo TEXT(150);")
        Dim versione As dbAlegatoADataSetTableAdapters.versioneTableAdapter = New dbAlegatoADataSetTableAdapters.versioneTableAdapter
        Dim sVersionePartenza = "2.20"
        versione.Insert("", sVersionePartenza)
        Return sVersionePartenza
    End Function

    Private Function patch3_creazionetabellasopralluogo()
        'esegue la creazione della tabella sopralluogo, inserisce il numero versione DB 2.50
        feActions.esegueSQL("CREATE TABLE sopralluogo  (id COUNTER CONSTRAINT ChiavePrimariaConstraint PRIMARY KEY, idOS INTEGER, tipoReato TEXT(50),oraRedazione DATETIME, oraRichiesta DATETIME,luogo_citta TEXT(50), via TEXT(150), contatti_con TEXT(200),resoconto MEMO,FOREIGN KEY (idOS) REFERENCES ordineServizio(id));")

        Dim versione As dbAlegatoADataSetTableAdapters.versioneTableAdapter = New dbAlegatoADataSetTableAdapters.versioneTableAdapter
        Dim sVersionePartenza = "2.50"
        versione.Insert("", sVersionePartenza)
        Return sVersionePartenza
    End Function

    Public Function doControlloVersioneDB()
        Dim versione As dbAlegatoADataSetTableAdapters.versioneTableAdapter = New dbAlegatoADataSetTableAdapters.versioneTableAdapter
        Dim sVersione As String
        Dim dVersione As Double
        Try
            log.xlogWriteEntry("Controllo versione DB.", TraceEventType.Information)
            'versione del DB installata
            sVersione = versione.ScalarNumeroVersione()
            'sostituisco la virgola al punto perchè altrimenti il parse da errore
            dVersione = sVersione.Replace(".", ",")
            log.xlogWriteEntry("Versione DB: " & sVersione, TraceEventType.Information)
        Catch ex As Exception
            log.xlogWriteEntry("Errore. Non esiste la tabella Versione. Creazione tabella Versione.", TraceEventType.Critical)
            Return -1
        End Try
        'restituisce il numero di versine (2.00 se è la prima modifica al db)
        Return dVersione
    End Function

    Public Sub aggiornaversioneVersioneDB(ByVal versione As Double)

        Select Case versione
            Case -1
                patch1_creaTabellaVersione()
                patch2_aggiornamentoMaxsizeCampoLuogoControllo()
            Case Is < 2.5
                patch2_aggiornamentoMaxsizeCampoLuogoControllo()
                patch3_creazionetabellasopralluogo()
                '   +patch1
        End Select
    End Sub



End Class
