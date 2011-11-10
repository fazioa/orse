Imports System.Windows.Forms

Public Class DInserimentoLuogoControllo

    Dim parametri As parametriControllo_e_OS
    Dim feActions As New OrSe.ActionsLibrary
    Dim db As dbAlegatoADataSet
    Dim log As New XOrseLog


    Public Sub New(ByRef DataSet As dbAlegatoADataSet, ByRef parametri As parametriControllo_e_OS)
        Me.parametri = parametri
        db = DataSet
        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()
        ControlloBindingSource.DataSource = Me.db
        LuoghicontrolloBindingSource.DataSource = Me.db

        'creo una nuova riga ed inserisco subito il nome dell'ordine di servizio
        ControlloBindingSource.AddNew()
        'feActions.scriviCampoDB(ControlloBindingSource, "idOS", parametri.idOS)
    End Sub

    Private Sub DInserimentoLuogoControllo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbAlegatoADataSet.modelliMezzo' table. You can move, or remove it, as needed.
        Dim dataOra As System.DateTime = My.Computer.Clock.LocalTime
        ' DateTimePickerOra.Text = dataOra.ToShortTimeString
        DateTimePickerOra.Text = dataOra

    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            If (cbLuogoControllo.getSelectedText.Trim.Length > 0 And cbLuogoControllo.getSelectedID <> 0) Then
                'inserisce la riga nella tabella controllo
                ControlloTableAdapter.Insert(DateTimePickerOra.Value, cbLuogoControllo.getSelectedID, parametri.idOS)
                'leggo l'indice della riga inserita
                parametri.idControllo = Me.ControlloTableAdapter.MaxID()
                parametri.nomeLuogoControllo = cbLuogoControllo.getSelectedText
                parametri.dataoraControllo = DateTimePickerOra.Value

                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        Catch ex As OleDb.OleDbException
            Throw New eccezione(ex, "Errore di inserimento del luogo di controllo")
            Me.DialogResult = System.Windows.Forms.DialogResult.Abort
        End Try

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Function DialogResultClass()
        Return parametri
    End Function


    Private Sub button_enable()
        If (cbLuogoControllo.getCount > 0) Then
            Me.OK_Button.Enabled = True
        Else
            Me.OK_Button.Enabled = False
        End If
    End Sub


    Private Sub UserControlComboBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLuogoControllo.Load
        ' cbLuogoControllo.setDataSource(LuoghicontrolloBindingSource)
        'non passo il binding, perchè non funziona e non so perchè. Lo seleziono internamente al controllo nella funzione setTabella
        cbLuogoControllo.setSelectedValue(ControlloBindingSource, "idLuogo")
        cbLuogoControllo.setDisplayMember("luogo")
        cbLuogoControllo.setValueMember("id")
        cbLuogoControllo.setTabella(UserControlComboBox.tabellaEnum.LuogoControllo)
    End Sub

End Class
