Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
<Serializable()> Public Class serializzazione
    Dim log As New XOrseLog

    Public Sub salvaHashTable(ByVal preferenze As Hashtable)

        Dim path As String = Application.StartupPath
        Dim sPath = path & "\preferenzeBackup.OrSe"
        Dim myFileStream As Stream = File.Create(sPath)
        Dim serializer As New BinaryFormatter()

        log.xlogWriteEntry("Backup Preferenze --> " & sPath, TraceEventType.Information)
        serializer.Serialize(myFileStream, preferenze)
        myFileStream.Close()
    End Sub

    Public Function loadHashTable() As Hashtable
        Dim path As String = Application.StartupPath
        Dim sPath = path & "\preferenzeBackup.OrSe"

        'se il file è presente allora lo recupero 
        If Dir(sPath) <> "" Then
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
