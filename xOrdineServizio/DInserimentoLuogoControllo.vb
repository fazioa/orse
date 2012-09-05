Imports System.Windows.Forms

Public Class DInserimentoLuogoControllo

    Dim parametri As parametriControllo_e_OS
    Dim feActions As New OrSe.ActionsLibrary
    Dim db As dbAlegatoADataSet
    Dim log As New XOrseLog
    Dim bFlagModalitaModifica As Boolean = False


    Public Sub New(ByRef DataSet As dbAlegatoADataSet, ByRef parametri As parametriControllo_e_OS, ByVal bModifica As Boolean)
        Me.parametri = parametri
        db = DataSet
        InitializeComponent()
        initLuogoComboBox()

        If Not bModifica Then
            'QUI inserimetno controllo
            'creo una nuova riga ed inserisco subito il nome dell'ordine di servizio
            ControlloBindingSource.DataSource = Me.db
            LuoghicontrolloBindingSource.DataSource = Me.db
            ControlloBindingSource.AddNew()
            'feActions.scriviCampoDB(ControlloBindingSource, "idOS", parametri.idOS)
        Else
            'QUI modifica controllo
            LuoghicontrolloTableAdapter.Fill(Me.DbAlegatoADataSet.luoghicontrollo)
            ControlloTableAdapter.FillByID(Me.DbAlegatoADataSet.controllo, parametri.idControllo)
            'leggo l'idluogo e setto l'id su l'user control. Non lo fa in automatico
            Dim i = feActions.leggiCampoDB(Me.ControlloBindingSource, "idLuogo")
            cbLuogoControllo.setSelectedID(i)

            bFlagModalitaModifica = True

        End If

    End Sub


    Private Sub initLuogoComboBox()
        ' cbLuogoControllo.setDataSource(LuoghicontrolloBindingSource)
        'non passo il binding, perchè non funziona e non so perchè. Lo seleziono internamente al controllo nella funzione setTabella
        cbLuogoControllo.setSelectedValue(ControlloBindingSource, "idLuogo")
        cbLuogoControllo.setDisplayMember("luogo")
        cbLuogoControllo.setValueMember("id")
        cbLuogoControllo.setTabella(UserControlComboBox.tabellaEnum.LuogoControllo)
    End Sub
    



    Private Sub DInserimentoLuogoControllo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not bFlagModalitaModifica Then
            Dim dataOra As System.DateTime = My.Computer.Clock.LocalTime
            ' DateTimePickerOra.Text = dataOra.ToShortTimeString
            DateTimePickerOra.Text = dataOra
        End If

    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        OK_Button.Focus()
        Try

            If (cbLuogoControllo.getSelectedText.Trim.Length > 0 And cbLuogoControllo.getSelectedID <> 0) Then

                If Not bFlagModalitaModifica Then
                    ' QUI se sono in modalitò inserimento
                    'inserisce la riga nella tabella controllo
                    ControlloTableAdapter.Insert(DateTimePickerOra.Value, parametri.idOS, cbLuogoControllo.getSelectedID)
                    'leggo l'indice della riga inserita
                    parametri.idControllo = Me.ControlloTableAdapter.MaxID()

                Else
                    'QUI se sono in modalità modifica
                    Me.Validate()
                    Me.ControlloBindingSource.EndEdit()
                    Me.ControlloTableAdapter.Update(Me.DbAlegatoADataSet.controllo)

                End If

                'aggiorno i dati che verranno mostrati nel form soggetto
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

    
End Class
