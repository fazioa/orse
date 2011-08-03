Public Class eccezione
    Inherits System.Exception

    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub

    Public Sub New(ByVal message As String, ByVal inner As Exception)
        MyBase.New(message, inner)
    End Sub

    Public Sub New( _
        ByVal info As System.Runtime.Serialization.SerializationInfo, _
        ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context)
    End Sub


    Public Sub New()

    End Sub

    Public Sub New(ByVal ex As OleDb.OleDbException, ByVal cb As ComboBox)
        MyBase.New(ex.Message)
        Dim sMessaggio As String
        sMessaggio = ex.Message & " - Errore causato in fase di inserimento di valore nel database, proveniente dal combobox: " & cb.Name & " - Tentativo di inserimento valore: " & cb.Text
        sMessaggio = sMessaggio & " - Oggetto che ha causato l'errore: " & ex.Source
        sMessaggio = sMessaggio & " - Stacktrace:" & ex.StackTrace.ToString
        MsgBox(sMessaggio, MsgBoxStyle.Critical, "Errore")
    End Sub

    Public Sub New(ByVal ex As OleDb.OleDbException, ByVal cb As UserControlComboBox)
        MyBase.New(ex.Message)
        Dim sMessaggio As String
        sMessaggio = ex.Message & " - Errore causato in fase di inserimento di valore nel database, proveniente dal combobox: " & cb.Name
        sMessaggio = sMessaggio & " - Oggetto che ha causato l'errore: " & ex.Source
        sMessaggio = sMessaggio & " - Stacktrace:" & ex.StackTrace.ToString
        MsgBox(sMessaggio, MsgBoxStyle.Critical, "Errore")
    End Sub

    Public Sub New(ByVal ex As OleDb.OleDbException, ByVal sMsg As String)
        MyBase.New(ex.Message)
        Dim sMessaggio As String
        sMessaggio = sMsg & " - " & ex.Message
        sMessaggio = sMessaggio & " - Stacktrace:" & ex.StackTrace.ToString
        MsgBox(sMessaggio, MsgBoxStyle.Critical, "Errore")
    End Sub

    Public Sub New(ByVal ex As Exception, ByVal sMsg As String)
        MyBase.New(ex.Message)
        Dim sMessaggio As String
        sMessaggio = sMsg & " - " & ex.Message
        sMessaggio = sMessaggio & " - Stacktrace:" & ex.StackTrace.ToString
        MsgBox(sMessaggio, MsgBoxStyle.Critical, "Errore")
    End Sub

End Class
