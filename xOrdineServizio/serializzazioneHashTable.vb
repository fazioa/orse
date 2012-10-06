Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
<Serializable()> Public Class serializzazioneHashTable
    Dim log As New XOrseLog

    Public Sub salvaHashTable(ByVal preferenze As Hashtable, path As String)

        '   Dim path As String = Application.StartupPath
        Dim sPath = path & "\preferenzeBackup.TSPref"
        Dim myFileStream As Stream = File.Create(sPath)
        Dim serializer As New BinaryFormatter()

        log.xlogWriteEntry("Backup Preferenze --> " & sPath, TraceEventType.Information)
        serializer.Serialize(myFileStream, preferenze)
        myFileStream.Close()

    End Sub

    Public Function loadHashTable(path As String) As Hashtable
        'carica le preferenze, solo se il file esiste
        ' Dim path As String = Application.StartupPath
        Dim bFlag As Boolean = False

        Dim sPath = path & "\preferenzeBackup.TSPref"
        If Dir(sPath) <> "" Then
            bFlag = True
        End If

        'se il file preferenzeBackup.OrSePref non esiste allora provo con preferenzeBackup.OrSe, che è il nome della versione precedente alla 2.67
        If Not bFlag Then
            sPath = path & "\preferenzeBackup.TSPref"
            If Dir(sPath) <> "" Then
                bFlag = True
            End If
        End If
        'se il file è presente allora lo recupero 
        If bFlag Then
            Dim myFileStream As New FileStream(sPath, FileMode.Open)
            Dim serializer As New BinaryFormatter()

            log.xlogWriteEntry("Ripristino Backup Preferenze --> " & sPath, TraceEventType.Information)
            Return serializer.Deserialize(myFileStream)
        Else
            log.xlogWriteEntry("Ripristino Backup Preferenze --> Non possibile, file assente: " & sPath, TraceEventType.Information)
        End If
        'sono qui se il file non esiste
        Return Nothing
    End Function
End Class
