Public Class DBCommand
    Dim log As New XOrseLog
    Dim objconn As New OleDb.OleDbConnection(My.Settings.dbAlegatoAConnectionString)
    Public Function getCommand() As OleDb.OleDbCommand
        Dim objcomm As New OleDb.OleDbCommand
        Return objcomm
    End Function

    Public Sub closeConnection()
        objconn.Close()
    End Sub

    Public Function SQLTest(ByVal objcomm As OleDb.OleDbCommand, ByVal nome As String) As Integer
        Dim sComandoSql As String = "SELECT TOP 1 numeroversione FROM(versione) ORDER BY numeroversione DESC"

        objconn.Open()
        'objcomm()


        Dim prm As New OleDb.OleDbParameter()
        prm.DbType = DbType.AnsiString
        prm.Value = nome
        objcomm.Parameters.Add(prm)

        Return objcomm.ExecuteNonQuery
    End Function

End Class
