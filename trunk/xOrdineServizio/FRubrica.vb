Public Class FRubrica
    Dim feActions As New OrSe.ActionsLibrary
    Dim log As New XOrseLog

    Public Sub New(ByVal idOS As Integer, ByVal idRubrica As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        feActions.setStandardFormSize(Me)


        'se l'id è maggiore di zero allora sto modificando, altrimenti inserisco un nuovo elemento
        If (idRubrica >= 0) Then
            RubricaTableAdapter.FillById(DbAlegatoADataSet.rubrica, idRubrica)
        Else
            Me.RubricaBindingSource.AddNew()
            log.xlogWriteEntry("Apertura form rubrica - nuova voce", TraceEventType.Information)
            Dim drv As DataRowView = RubricaBindingSource.Current()
            drv.Item("idOS") = idOS
        End If

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub btnSalvaChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvaChiudi.Click
        Try
            ' Me.InterventiTableAdapter.Insert(DateTimePickerOraInizio.Value, DateTimePickerOraFine.Value, tbTipoServizio.Text, tbResoconto.Text, xIdOS, xlTipo)
            Me.Validate()
            Me.RubricaBindingSource.EndEdit()
            Me.RubricaTableAdapter.Update(Me.DbAlegatoADataSet.rubrica)

        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        If (MsgBox("Chiudere la finetra? Tutte le modifiche verrano perse. Sei sicuro?", MsgBoxStyle.YesNo, "Chiudi Finestra") = MsgBoxResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class