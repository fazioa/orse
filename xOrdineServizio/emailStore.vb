Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()> Public Class emailStore
    Dim log As New XOrseLog
    Dim listaEmail As New Stack(Of emailObj)
    Dim sStoreFileName As String = My.Settings.pathCartellaScrivibile & "\listaSegnalazioni.dat"

    'Public Sub New(ByVal l As List(Of emailObj))
    '   listaEmail = l
    'End Sub

    Public Sub save()
        Dim path As String = Application.StartupPath
        Dim sPath = path & sStoreFileName
        Dim myFileStream As Stream = File.Create(sPath)
        Try
            Dim serializer As New BinaryFormatter()
            log.xlogWriteEntry("Salvataggio file segnalazioni --> " & sPath, TraceEventType.Information)
            serializer.Serialize(myFileStream, listaEmail)
            myFileStream.Close()
        Catch ex As Exception
            myFileStream.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Carica il file dati lista segnalazioni. Carica in memoria il tipo Stack(Of emailObj)
    ''' </summary>
    Public Sub load()
        'carica le preferenze, solo se il file esiste
        Dim path As String = Application.StartupPath
        Dim bFlag As Boolean = False

        Dim sPath = path & sStoreFileName
        If Dir(sPath) <> "" Then
            bFlag = True
        End If

        'se il file è presente allora lo recupero 
        If bFlag Then
            Dim myFileStream As New FileStream(sPath, FileMode.Open)
            Dim serializer As New BinaryFormatter()

            log.xlogWriteEntry("Carico file dati lista segnalazioni --> " & sPath, TraceEventType.Information)
            Try
                listaEmail = serializer.Deserialize(myFileStream)
            Catch ex As Exception

            End Try
            myFileStream.Close()
        Else
            log.xlogWriteEntry("Caricamento file dati lista segnalazioni --> Non possibile, file assente: " & sPath, TraceEventType.Information)
        End If
        'sono qui se il file non esiste
    End Sub


    ''' <summary>
    ''' inserisce una nuova segnalazione in lista. Esegue automaticamente load e save
    ''' </summary>
    ''' <param name="sTesto"></param>
    ''' <param name="img"></param>
    ''' <remarks></remarks>
    Public Sub push(ByVal sTesto As String, ByVal img As Image)
        'carica in memoria la lista
        load()
        'aggiunge elemento
        listaEmail.Push(New emailObj(sTesto, img))
        'salva la lista su file
        save()
    End Sub

    ''' <summary>
    ''' Preleva una segnalazione dalla lista
    ''' </summary>
    ''' <returns>emailObj</returns>
    ''' <remarks></remarks>
    Public Function pop() As emailObj
        'Dim e As New emailObj
        Dim e As emailObj = Nothing
        load()
        If listaEmail.Count > 0 Then
            e = listaEmail.Pop()
            save()
        End If

        Return e
    End Function

End Class


<Serializable()> Public Class emailObj
    'classe che rappresenta i dati di un'email di segnalazione di errore
    'testo - screenshot

    Public testoEmail As String
    Public screenShot As Image


    Public Sub New(ByVal t As String, ByVal i As Image)
        testoEmail = t
        screenShot = i
    End Sub

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

End Class
