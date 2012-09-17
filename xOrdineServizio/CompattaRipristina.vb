Public Class CompattaRipristina
    Public Sub DoAction()

        Dim pathDB As String = Application.StartupPath

        Dim jro As JRO.JetEngine
        jro = New JRO.JetEngine

        Dim sPathOriginale = pathDB & "\dbAlegatoA.mdb"
        Dim sPathCopia = pathDB & "\dbAlegatoA2.mdb"

        'elimino il file dbAlegatoA2, nel caso sia presente
        If Dir(sPathCopia) <> "" Then
            Kill(sPathCopia)
        End If

        Try
            'compatta il DB
            jro.CompactDatabase("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sPathOriginale & ";Jet OLEDB:Database Password=", _
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sPathCopia & ";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Password=")

            'nuovo file dbAlegatoA2. Devo cancellare il vecchio e rinominare il nuovo
            Kill(sPathOriginale)
            FileCopy(sPathCopia, sPathOriginale)

        Catch ex As Exception

        End Try

    End Sub
End Class
