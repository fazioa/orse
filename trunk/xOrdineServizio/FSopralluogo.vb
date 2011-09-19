Public Class FSopralluogo
    Dim log As New XOrseLog
    Dim feActions As New OrSe.ActionsLibrary

    Private Sub btnSalvaChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvaChiudi.Click
        salva()
        Me.Close()
    End Sub

    Private Sub salva()
        Dim drv As DataRowView = SopralluogoBindingSource.Current()

        If (RadioButtonTipoFurtoAbitazione.Checked) Then
            drv.Item("tipoReato") = "Furto in abitazione"
        Else
            drv.Item("tipoReato") = TextBoxTipoAltro.Text
        End If


        drv.Item("oraRedazione") = DateTimePicker1.Value
        drv.Item("oraRichiesta") = DateTimePicker2.Value
        Me.Validate()
        Me.SopralluogoBindingSource.EndEdit()
        Me.SopralluogoTableAdapter.Update(Me.DbAlegatoADataSet.sopralluogo)
    End Sub

   

    Private Sub FSopralluogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbAlegatoADataSet.sopralluogo' table. You can move, or remove it, as needed.
        If (idSopralluogo >= 0) Then
            log.xlogWriteEntry("Apertura form sopralluogo per modifica", TraceEventType.Information)
            Me.SopralluogoTableAdapter.FillById(Me.DbAlegatoADataSet.sopralluogo, idSopralluogo)

            Dim tipoR As String = feActions.leggiCampoDB(SopralluogoBindingSource, "tipoReato")

            If (tipoR = "Furto in abitazione") Then
                RadioButtonTipoFurtoAbitazione.Checked = True
            Else
                RadioButtonTipoAltro.Checked = True
                TextBoxTipoAltro.Text = tipoR
            End If

        End If

    End Sub

    Private idSopralluogo As Integer = -1
    Private nomiOperatori As String
    Public Sub New(ByVal idOS As Integer, ByVal idS As Integer, ByVal nomiOp As String)
        

        nomiOperatori = nomiOp
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'inizializzo datetimepicker, perchè altrimenti danno DBNull

        'se idOS=-1 allora sono in modalità modifica
        '  If (idOS < 0) Then

        ' End If

        'se l'id è maggiore di zero allora sto modificando, altrimenti inserisco un nuovo elemento
        If (idS >= 0) Then
            idSopralluogo = idS

        Else
            Me.SopralluogoBindingSource.AddNew()
            log.xlogWriteEntry("Apertura form sopralluogo - nuovo sopralluogo", TraceEventType.Information)
            Dim drv As DataRowView = SopralluogoBindingSource.Current()
            drv.Item("idOS") = idOS
        End If

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    
    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
        If (MsgBox("Chiudere la finetra? Tutte le modifiche verrano perse. Sei sicuro?", MsgBoxStyle.YesNo, "Chiudi Finestra") = MsgBoxResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonGeneraReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGeneraReport.Click
        'salva il verbale di sopralluovo
        salva()
        Try
            log.xlogWriteEntry("Word - Preparazione per generazione verbale di sopralluogo", TraceEventType.Critical)

            Dim oWord As Microsoft.Office.Interop.Word.Application = feActions.wordInizializzaDocumentoVerbaleSopralluogo()

            feActions.wordScriviSegnalibro(oWord, "regione", My.Settings.regione)
            feActions.wordScriviSegnalibro(oWord, "comando", My.Settings.comando)
            feActions.wordScriviSegnalibro(oWord, "tipoReato", feActions.leggiCampoDB(SopralluogoBindingSource, "tipoReato"))
            feActions.wordScriviSegnalibro(oWord, "luogo", feActions.leggiCampoDB(SopralluogoBindingSource, "luogo_citta"))
            feActions.wordScriviSegnalibro(oWord, "via", feActions.leggiCampoDB(SopralluogoBindingSource, "via"))
            'il segnalibro non permette che esistano più istanze sullo stesso documento. Quindi devo duplicarlo, quando serve scrivere due volte le stesse informazioni.
            feActions.wordScriviSegnalibro(oWord, "luogo2", feActions.leggiCampoDB(SopralluogoBindingSource, "luogo_citta"))
            feActions.wordScriviSegnalibro(oWord, "via2", feActions.leggiCampoDB(SopralluogoBindingSource, "via"))

            Dim d As Date = feActions.leggiCampoDB(SopralluogoBindingSource, "oraRedazione")
            feActions.wordScriviSegnalibro(oWord, "dataRedazione", d.ToShortDateString)
            feActions.wordScriviSegnalibro(oWord, "oraRedazione", d.ToShortTimeString)

            d = feActions.leggiCampoDB(SopralluogoBindingSource, "oraRichiesta")
            feActions.wordScriviSegnalibro(oWord, "dataRichiesta", d.ToShortDateString)
            feActions.wordScriviSegnalibro(oWord, "oraRichiesta", d.ToShortTimeString)

            feActions.wordScriviSegnalibro(oWord, "nomiOperatori", nomiOperatori)

            feActions.wordScriviSegnalibro(oWord, "contatti", feActions.leggiCampoDB(SopralluogoBindingSource, "contatti_con"))
            feActions.wordScriviSegnalibro(oWord, "resoconto", feActions.leggiCampoDB(SopralluogoBindingSource, "resoconto"))

        Catch

        End Try

    End Sub
End Class