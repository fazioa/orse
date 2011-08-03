Public Class FIntervento
    Dim feActions As New OrSe.ActionsLibrary()

    Dim xdDataIntervento As Date
    Dim xsOS As String
    Dim bNuovoIntervento As Boolean = False
    Dim dlInizio, dlFine As Date
    Dim lTipo As paragrafoOS

    Public Sub New(ByVal idOS As Integer, ByVal tipo As paragrafoOS)
        sharedNew(Nothing, Nothing, idOS, tipo)
    End Sub
    Public Sub New(ByVal dInizio As Date, ByVal dFine As Date, ByVal idOS As Integer, ByVal tipo As paragrafoOS)
        sharedNew(dInizio, dFine, idOS, tipo)
    End Sub

    Private Sub sharedNew(ByVal dInizio As Date, ByVal dFine As Date, ByVal idOS As Integer, ByVal tipo As paragrafoOS)
        dlInizio = dInizio
        dlFine = dFine
        lTipo = tipo
        'esegue qui se è un nuovo intervento
        InitializeComponent()

        Me.OrdineServizioTableAdapter.FillByID(Me.DbAlegatoADataSet.ordineServizio, idOS)
        Me.InterventiBindingSource.AddNew()
        feActions.scriviCampoDB(InterventiBindingSource, "idOrdineServizio", idOS)

        Select Case tipo
            Case paragrafoOS.informazioni
                feActions.scriviCampoDB(InterventiBindingSource, "iParagrafo", paragrafoOS.informazioni)

            Case paragrafoOS.interventi
                feActions.scriviCampoDB(InterventiBindingSource, "iParagrafo", paragrafoOS.interventi)
        End Select

        Me.xdDataIntervento = feActions.leggiCampoDB(OrdineServizioBindingSource, "data")
        Me.xsOS = feActions.leggiCampoDB(OrdineServizioBindingSource, "nome")

        LabelData.Text = xdDataIntervento.Date
        labelOS.Text = xsOS

        bNuovoIntervento = True

    End Sub

    'coincidevano le firme. Aggiungo z solo per differenziarle, non ho voglia di escogitare altro
    Public Sub New(ByVal id As Integer, ByVal z As Boolean)
        InitializeComponent()
        feActions = New OrSe.ActionsLibrary()
        Me.InterventiTableAdapter.FillByID(DbAlegatoADataSet.interventi, id)
    End Sub

    Private Sub FIntervento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        feActions = New OrSe.ActionsLibrary()
        If bNuovoIntervento Then
            If (Not dlInizio = Nothing And Not dlFine = Nothing) Then
                DateTimePickerOraInizio.Value = dlInizio
                DateTimePickerOraFine.Value = dlFine
            Else
                DateTimePickerOraInizio.Value = My.Computer.Clock.LocalTime
                Timer1.Start()
                Me.GroupBoxOraFine.Enabled = False 'gruppo disabilitato
            End If
        Else
            'esegue qui se NON è un nuovo intervento
            'leggo l'id l'ordine di servizio
            Dim idOS = feActions.leggiCampoDB(InterventiBindingSource, "idOrdineServizio")
            'cerco l'os
            Me.OrdineServizioTableAdapter.FillByID(Me.DbAlegatoADataSet.ordineServizio, idOS)
            'leggo data e nome
            Dim data As DateTime = feActions.leggiCampoDB(OrdineServizioBindingSource, "data")
            LabelData.Text = data.Date
            labelOS.Text = feActions.leggiCampoDB(OrdineServizioBindingSource, "nome")

            'cambia il testo del label
            Me.LabelOraFine.Text = "Fine"
            Me.btnAutoOraFine.Visible = False
            Me.GroupBoxOraFine.Enabled = True 'gruppo disabilitato
        End If

        Select Case lTipo
            Case paragrafoOS.informazioni
                Me.Text = "Par.6 - Informazioni"
                LabelTipoIntervento.Text = "Sintesi Informazione"
            Case paragrafoOS.interventi
                Me.Text = "Par.9 - Interventi"
                LabelTipoIntervento.Text = "Tipo Intervento"
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DateTimePickerOraFine.Value = My.Computer.Clock.LocalTime
    End Sub


    Private Sub btnAutoOraFine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutoOraFine.Click
        If (bNuovoIntervento) Then
            'è un nuovo intervento
            Me.GroupBoxOraFine.Enabled = Not Me.GroupBoxOraFine.Enabled
            If (Me.GroupBoxOraFine.Enabled) Then
                Timer1.Stop()
                Me.LabelOraFine.Text = "Fine manuale"
                Me.btnAutoOraFine.Text = "Auto"
            Else
                Timer1.Start()
                Me.LabelOraFine.Text = "Fine automatica"
                Me.btnAutoOraFine.Text = "Manuale"
            End If
        Else
            ' NON è un nuovo intervento - apertura vecchio record
            Me.GroupBoxOraFine.Enabled = False 'gruppo sempre disabilitato
            Me.btnAutoOraFine.Visible = False
            Timer1.Stop() 'timer sempre stop
            Me.LabelOraFine.Text = "Fine"
        End If
    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click

        Me.InterventiBindingSource.EndEdit()
        Me.InterventiTableAdapter.Update(Me.DbAlegatoADataSet.interventi)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (MsgBox("Chiudere la finetra? Tutte le modifiche verrano perse. Sei sicuro?", MsgBoxStyle.YesNo, "Chiudi Finestra")=MsgBoxResult.Yes) Then
            Me.Close()

        End If
    End Sub

End Class