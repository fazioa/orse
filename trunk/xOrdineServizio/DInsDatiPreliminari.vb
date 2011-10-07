Imports System.Windows.Forms

Public Class DInsDatiPreliminari
    Dim feActions As OrSe.ActionsLibrary
    Dim parametri As parametriControllo
    Private iOSID As Integer = -1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Me.Validate()

        If (OperatoriComboBox.Text = "" Or OSMaskedTextBox.Text = "OS   /") Then
            OK_Button.Text = "OK (inserire tutti i dati richiesti)"
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            If (OrdineServizioTableAdapter.ScalarQueryOS(DateTimePicker1.Value.Date, OSMaskedTextBox.Text) > 0) Then
                'se il record esiste ne prendo l'ID
                FPrima.OrdineServizioTableAdapter.FillByDataNome(DbAlegatoADataSet.ordineServizio, DateTimePicker1.Value.Date, OSMaskedTextBox.Text)
                FPrima.OrdineServizioBindingSource.MoveFirst()
                parametri.idOS = feActions.leggiCampoDB(OrdineServizioBindingSource, "id")
            Else
                'altrimenti lo inserisco
                Try
                    'inserisco con insert perchè il metodo .addnew() da errore al secondo inserimento
                    OrdineServizioTableAdapter.Insert(OSMaskedTextBox.Text, DateTimePicker1.Value.Date, OperatoriComboBox.SelectedValue)
                    parametri.idOS = Me.OrdineServizioTableAdapter.MaxID()
                    OrdineServizioTableAdapter.FillByID(Me.DbAlegatoADataSet.ordineServizio, parametri.idOS)
                Catch ex As Exception
                    Throw New eccezione(ex, "Errore in fase di inserimento OS")
                End Try
            End If
            parametri.nomeOperatore = OperatoriComboBox.Text
            parametri.idOperatore = OperatoriComboBox.SelectedValue
            parametri.dataOS = DateTimePicker1.Value.Date
            parametri.nomeOS = OSMaskedTextBox.Text
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        FPrima.setModalitaVisita(True)
    End Sub

    Private Sub DInsDatiPreliminariNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim iNrOS = Me.QOrdineServizioTableAdapter.Fill(Me.DbAlegatoADataSet.QOrdineServizio)
        'TODO: This line of code loads data into the 'DbAlegatoADataSet.operatore' table. You can move, or remove it, as needed.
        Dim iNrOp = Me.OperatoreTableAdapter.Fill(Me.DbAlegatoADataSet.operatore)
        feActions = New OrSe.ActionsLibrary()
        feActions.doPersonalizzaCombo(Me.OperatoriComboBox)
        DateTimePicker1.Value = Date.Now
        If (iNrOp > 0) Then OperatoriComboBox.SelectedIndex() = 0

        OSMaskedTextBox.Text = ""
        OSMaskedTextBox.Focus()

        'chiamata asincrona tramite funzione delegate
        'Dim del As MyDelegateCallBack
        'del = New MyDelegateCallBack(AddressOf caricaDati)

        caricaDati()

        'BeginInvoke(del)

        'acquisisce il focus
        Me.Focus()

    End Sub

    '  Public Delegate Function MyDelegateCallBack()

    Private Function caricaDati()

        Dim pb As New FProgressionBar()
        pb.TopLevel = True

        pb.Show()

        'ITERAZIONE SU QOrdineServizio
        'inserisce il nome dell'ordine di servizio come nodo ed i nomi delle persone controllate come figli
        Dim iteratore As IEnumerator = QOrdineServizioBindingSource.GetEnumerator()
        iteratore.Reset()
        Dim bEsc = iteratore.MoveNext()
        Dim drv As DataRowView

        pb.Maximum(QOrdineServizioBindingSource.Count)
        While (bEsc)
            drv = iteratore.Current
            FillTreeOS(drv.Item("id"), drv.Item("nome") & " del " & FormatDateTime(drv.Item("data"), DateFormat.ShortDate) & " - " & drv.Item("operatori"))
            bEsc = iteratore.MoveNext()
            pb.PerformStep()
        End While
        pb.Dispose()
        Return 0
    End Function


    Public Sub New(ByRef DataSet As dbAlegatoADataSet, ByRef parametri As parametriControllo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.parametri = parametri

    End Sub

    Public Function getResultClassParametri() As parametriControllo
        getResultClassParametri = parametri
    End Function

    Private Sub OperatoriComboBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperatoriComboBox.Leave
        inserimentoValore(sender)
    End Sub
    Private Function inserimentoValore(ByVal sender As System.Object) As Integer
        Return feActions.doComboInsNuovoValore(sender, OperatoreTableAdapter, DbAlegatoADataSet.operatore)
    End Function

    Sub FillTreeOS(ByVal idOS As Integer, ByVal nomeNodo As String)
        'crea il nodo e poi lo riempie con il contenuro dei nomi dell'allegato A
        TreeViewOS.Nodes.Add(idOS, nomeNodo)
        Dim log As New XOrseLog
        log.xlogWriteEntry("Aggiornamento albero (TreeView ordini di servizio:" & idOS & ", " & nomeNodo, TraceEventType.Information)
    End Sub

    Function fillTreeNodePersona(ByVal treeOS As TreeView, ByVal treeNodes As TreeNode, ByVal binding As BindingSource) As TreeNode
        Dim iCount As Integer = binding.Count
        Dim bEsc As Boolean = True
        Dim drv As DataRowView

        Dim iteratore As IEnumerator = binding.GetEnumerator()
        iteratore.Reset()
        bEsc = Not iteratore.MoveNext()
        Dim i = (-1)
        While (Not bEsc)
            Dim p As parametriPersona = New parametriPersona
            drv = iteratore.Current
            If (drv IsNot Nothing) Then
                i = i + 1

                ' INSERISCO DATI PERSONA
                '=======================
                With p
                    .cognome = feActions.valoreDrv(drv, "cognome")
                    .nome = feActions.valoreDrv(drv, "nome")
                    .luogonascita = feActions.valoreDrv(drv, "cittanascita")
                    '.datanascita = FormatDateTime(feActions.valoreDrv(drv, "datanascita"), DateFormat.ShortDate) '
                    If (Not drv.Item("datanascita") Is System.DBNull.Value) Then
                        .datanascita = FormatDateTime(drv.Item("datanascita"), DateFormat.ShortDate)
                    End If

                    If (Not drv.Item("residenzaindirizzo") Is System.DBNull.Value And Not drv.Item("cittaresidenza") Is System.DBNull.Value) Then .residenza = drv.Item("residenzaindirizzo") & " - " & drv.Item("cittaresidenza")
                    .precedenti = feActions.valoreDrv(drv, "precedenti")
                    .mezzo = feActions.valoreDrv(drv, "mezzo")
                    .colore = feActions.valoreDrv(drv, "colore")
                    .targa = feActions.valoreDrv(drv, "targa")
                End With
                '=======================

                'Se arrivo a fine lista metto la boolean a true
                If (binding.Position = iCount - 1) Then bEsc = True
                treeNodes.Nodes.Add(p.cognome & " " & p.nome & " nato a " & p.luogonascita & " il " & p.datanascita)
            End If
            bEsc = Not iteratore.MoveNext()
        End While
        fillTreeNodePersona = treeNodes
    End Function

    Function fillTreeNodeInterventi_Informazioni(ByVal treeOS As TreeView, ByVal treeNodes As TreeNode, ByVal binding As BindingSource, ByVal paragrafo As paragrafoOS) As TreeNode
        Dim iCount As Integer = binding.Count
        Dim bEsc As Boolean = True
        Dim drv As DataRowView

        Dim iteratore As IEnumerator = binding.GetEnumerator()
        iteratore.Reset()
        bEsc = Not iteratore.MoveNext()
        Dim i = (-1)
        While (Not bEsc)
            ' Dim p As parametriPersona = New parametriPersona
            drv = iteratore.Current
            If (drv IsNot Nothing) Then
                i = i + 1
                'Se arrivo a fine lista metto la boolean a true
                If (binding.Position = iCount - 1) Then bEsc = True
                treeNodes.Nodes.Add(feActions.troncaStringa(feActions.valoreDrv(drv, "tipointervento"), 30) & " - " & feActions.troncaStringa(feActions.valoreDrv(drv, "resoconto"), 60))
            End If
            bEsc = Not iteratore.MoveNext()
        End While
        fillTreeNodeInterventi_Informazioni = treeNodes
    End Function


    Function fillTreeNodeSopralluogo(ByVal treeOS As TreeView, ByVal treeNodes As TreeNode, ByVal binding As BindingSource) As TreeNode
        Dim iCount As Integer = binding.Count
        Dim bEsc As Boolean = True
        Dim drv As DataRowView

        Dim iteratore As IEnumerator = binding.GetEnumerator()
        iteratore.Reset()
        bEsc = Not iteratore.MoveNext()
        Dim i = (-1)
        While (Not bEsc)
            ' Dim p As parametriPersona = New parametriPersona
            drv = iteratore.Current
            If (drv IsNot Nothing) Then
                i = i + 1
                'Se arrivo a fine lista metto la boolean a true
                If (binding.Position = iCount - 1) Then bEsc = True
                treeNodes.Nodes.Add(feActions.troncaStringa(feActions.valoreDrv(drv, "tiporeato"), 30) & " - " & feActions.troncaStringa(feActions.valoreDrv(drv, "luogo_citta"), 30) & " - " & feActions.troncaStringa(feActions.valoreDrv(drv, "via"), 30))
            End If
            bEsc = Not iteratore.MoveNext()
        End While
        fillTreeNodeSopralluogo = treeNodes
    End Function


    Private Sub TreeViewOS_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewOS.AfterSelect
        Dim tv As TreeView = sender
        'Popolamento TREVIEW
        Dim idOS As Integer
        If (Integer.TryParse(tv.SelectedNode.Name, idOS)) Then
            QOrdineServizioTableAdapter.FillById(DbAlegatoADataSet.QOrdineServizio, idOS)
            OSMaskedTextBox.Text = feActions.leggiCampoDB(QOrdineServizioBindingSource, "nome")
            DateTimePicker1.Value = feActions.leggiCampoDB(QOrdineServizioBindingSource, "data")

            If Not (tv.SelectedNode.Nodes.Find("p", False).Length > 0 And tv.SelectedNode.Nodes.Find("i", False).Length > 0 And tv.SelectedNode.Nodes.Find("f", False).Length > 0) Then
                'non viene eseguito se già sono presenti le chiavi P e I

                Dim nrP = QAllegatoATableAdapter.FillByOS(DbAlegatoADataSet.QAllegatoA, idOS)
                TreeViewOS.SelectedNode.Nodes.Add("p", "Persone: " & nrP)
                fillTreeNodePersona(TreeViewOS, TreeViewOS.SelectedNode.Nodes("p"), QAllegatoABindingSource)

                Dim nrI = QInterventiTableAdapter.FillByOS(DbAlegatoADataSet.QInterventi, idOS, paragrafoOS.interventi)
                TreeViewOS.SelectedNode.Nodes.Add("i", "Interventi: " & nrI)
                fillTreeNodeInterventi_Informazioni(TreeViewOS, TreeViewOS.SelectedNode.Nodes("i"), QInterventiBindingSource, paragrafoOS.interventi)

                Dim nrInf = QInterventiTableAdapter.FillByOS(DbAlegatoADataSet.QInterventi, idOS, paragrafoOS.informazioni)
                TreeViewOS.SelectedNode.Nodes.Add("f", "Informazioni: " & nrInf)
                fillTreeNodeInterventi_Informazioni(TreeViewOS, TreeViewOS.SelectedNode.Nodes("f"), QInterventiBindingSource, paragrafoOS.informazioni)
                QSopralluogoTableAdapter.FillByOS(DbAlegatoADataSet.QSopralluogo, idOS)
                Dim nrSopr = QSopralluogoTableAdapter.FillByOS(DbAlegatoADataSet.QSopralluogo, idOS)
                TreeViewOS.SelectedNode.Nodes.Add("s", "Sopralluogo: " & nrSopr)
                fillTreeNodeSopralluogo(TreeViewOS, TreeViewOS.SelectedNode.Nodes("s"), QSopralluogoBindingSource)
            End If

        End If
    End Sub

    Private Sub OperatoriComboBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'inserimentoValore(sender)
    End Sub
End Class
