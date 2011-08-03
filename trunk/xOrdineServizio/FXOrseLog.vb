Public Class FXOrseLog
    Public Sub add(ByVal message As String)
        LogTextBox.AppendText(message & vbCrLf)
    End Sub
    Public Sub clear()
        LogTextBox.Clear()
    End Sub
End Class