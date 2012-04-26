Public Class FRevisioneTabelleDati
    Dim feActions As New ActionsLibrary
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        feActions.setStandardFormSize(Me)
        feActions.datagridviewSetup(LuoghicontrolloDataGridView)
        feActions.datagridviewSetup(ModelliMezzoDataGridView)

        LuoghicontrolloDataGridView.MultiSelect = True
        ModelliMezzoDataGridView.MultiSelect = True
        LuoghicontrolloDataGridView.ReadOnly = False
        ModelliMezzoDataGridView.ReadOnly = False
    End Sub

    Private Sub LuoghicontrolloBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LuoghicontrolloBindingSource.EndEdit()
        Me.LuoghicontrolloTableAdapter.Update(Me.DbAlegatoADataSet.luoghicontrollo)

    End Sub

    Private Sub FRevisioneTabelleDati_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updateDataGridView()

    End Sub

    Private Sub updateDataGridView()
        Me.ModelliMezzoTableAdapter.Fill(Me.DbAlegatoADataSet.modelliMezzo)
        Me.LuoghicontrolloTableAdapter.Fill(Me.DbAlegatoADataSet.luoghicontrollo)
    End Sub


    Private Sub btnEliminaVoci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaVoci.Click
        'query per cancellare voci non utilizzate

        Dim iNrMezziEliminati = feActions.esegueSQL("DELETE * FROM modelliMezzo WHERE id NOT IN (SELECT idMezzo FROM allegatoA)")
        Dim iNrLuoghiEliminati = feActions.esegueSQL("DELETE * FROM luoghicontrollo WHERE id NOT IN (SELECT idLuogo FROM controllo)")
        'aggiorna vista
        MessageBox.Show("Mezzi: " & iNrMezziEliminati & vbCrLf & "Luoghi: " & iNrLuoghiEliminati, "Voci eliminate")

        updateDataGridView()
    End Sub

    Private Sub btnSalva_Click(sender As System.Object, e As System.EventArgs) Handles btnSalva.Click
        Dim bErrFlag As Boolean = False

        Me.Validate()
        Me.LuoghicontrolloBindingSource.EndEdit()
        Me.ModelliMezzoBindingSource.EndEdit()
        Try

            Me.LuoghicontrolloTableAdapter.Update(Me.DbAlegatoADataSet.luoghicontrollo)
        Catch ex As Exception
            bErrFlag = True
        End Try
        Try
            Me.ModelliMezzoTableAdapter.Update(Me.DbAlegatoADataSet.modelliMezzo)
        Catch ex As Exception
            bErrFlag = True
        End Try

        If bErrFlag Then
            MsgBox("Impossibile eseguire la cancellazione. E' possibile che esistano informazioni collegate alla voce che si sta tentando di cancellare.", MsgBoxStyle.Exclamation, "Cancellazione")
        End If
    End Sub

    Private Sub btnUnisci_Click(sender As System.Object, e As System.EventArgs) Handles btnUnisci.Click
        'svolgo l'unione solo sul datagrid selezionato
        Dim sSQL As String = ""
        Dim sSQLDel As String = ""
        Dim bFlag As Boolean = True
        Dim i As Integer = 1
        Select Case TabControl1.SelectedTab.Text
            Case "Luoghi controllo"
                Dim iValorePrimaRiga As Integer = LuoghicontrolloDataGridView.SelectedRows(0).Cells.Item("idLuogo").Value
                'se è selezionata solo una righa allora esci dal ciclo
                If LuoghicontrolloDataGridView.SelectedRows.Count <= 1 Then
                    bFlag = False
                Else
                    sSQL = "UPDATE controllo SET idluogo=" & iValorePrimaRiga & " WHERE "
                    sSQLDel = "DELETE * FROM luoghicontrollo WHERE "
                End If
                'nota: il ciclo parte da 1, perchè il val 0 è usato come valore da sostituire a tutte le altre righe
                Dim sTmp As String = ""
                While (bFlag)
                    sSQL = sSQL & " idLuogo= " & LuoghicontrolloDataGridView.SelectedRows(i).Cells.Item("idLuogo").Value
                    sSQLDel = sSQLDel & " id= " & LuoghicontrolloDataGridView.SelectedRows(i).Cells.Item("idLuogo").Value
                    i += 1
                    If i >= LuoghicontrolloDataGridView.SelectedRows.Count Then
                        bFlag = False
                    Else
                        sTmp = " OR "
                        sSQL = sSQL & sTmp
                        sSQLDel = sSQLDel & sTmp
                    End If
                End While

            Case "Mezzi"
                Dim iValorePrimaRiga As Integer = ModelliMezzoDataGridView.SelectedRows(0).Cells.Item("idMezzo").Value
                'se è selezionata solo una righa allora esci dal ciclo
                If ModelliMezzoDataGridView.SelectedRows.Count <= 1 Then
                    bFlag = False
                Else
                    sSQL = "UPDATE allegatoA SET idMezzo=" & iValorePrimaRiga & " WHERE "
                    sSQLDel = "DELETE * FROM modelliMezzo WHERE "
                End If
                'nota: il ciclo parte da 1, perchè il val 0 è usato come valore da sostituire a tutte le altre righe
                Dim sTmp As String = ""
                While (bFlag)
                    sSQL = sSQL & " idMezzo= " & ModelliMezzoDataGridView.SelectedRows(i).Cells.Item("idMezzo").Value
                    sSQLDel = sSQLDel & " id= " & ModelliMezzoDataGridView.SelectedRows(i).Cells.Item("idMezzo").Value
                    i += 1
                    If i >= LuoghicontrolloDataGridView.SelectedRows.Count Then
                        bFlag = False
                    Else
                        sTmp = " OR "
                        sSQL = sSQL & sTmp
                        sSQLDel = sSQLDel & sTmp
                    End If
                End While
        End Select

        Dim sNuovaVoceRiunita As String = ""
        Select Case TabControl1.SelectedTab.Text
            Case "Luoghi controllo"
                sNuovaVoceRiunita = LuoghicontrolloDataGridView.SelectedRows(0).Cells.Item("luogo").Value
            Case "Mezzi"
                sNuovaVoceRiunita = ModelliMezzoDataGridView.SelectedRows(0).Cells.Item("mezzo").Value
        End Select
        updateDataGridView()
        If Not String.IsNullOrEmpty(sSQL) Then
            Dim iNrRigheModificate As Integer = feActions.esegueSQL(sSQL)
            MsgBox("Sono state modificate " & iNrRigheModificate & " righe, ed unite nella voce """ & sNuovaVoceRiunita & """", MsgBoxStyle.Information, "Unione voci")
            feActions.esegueSQL(sSQLDel)
        End If
    End Sub

    Private Sub LuoghicontrolloDataGridView_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LuoghicontrolloDataGridView.CellValueChanged
        Me.Validate()
        Me.LuoghicontrolloBindingSource.EndEdit()
        Me.LuoghicontrolloTableAdapter.Update(Me.DbAlegatoADataSet.luoghicontrollo)

        updateDataGridView()
    End Sub

    Private Sub ModelliMezzoDataGridView_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ModelliMezzoDataGridView.CellValueChanged
        Me.Validate()
        Me.ModelliMezzoBindingSource.EndEdit()
        Me.ModelliMezzoTableAdapter.Update(Me.DbAlegatoADataSet.modelliMezzo)

        updateDataGridView()
    End Sub


    Private Sub UserDeletedRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles LuoghicontrolloDataGridView.UserDeletedRow, ModelliMezzoDataGridView.UserDeletedRow
        Dim bErrFlag As Boolean = False

        Me.Validate()
        Me.LuoghicontrolloBindingSource.EndEdit()
        Me.ModelliMezzoBindingSource.EndEdit()
        Try

            Me.LuoghicontrolloTableAdapter.Update(Me.DbAlegatoADataSet.luoghicontrollo)
        Catch ex As Exception
            bErrFlag = True
        End Try
        Try
            Me.ModelliMezzoTableAdapter.Update(Me.DbAlegatoADataSet.modelliMezzo)
        Catch ex As Exception
            bErrFlag = True
        End Try

        If bErrFlag Then
            MsgBox("Impossibile eseguire la cancellazione. E' possibile che esistano informazioni collegate alla voce che si sta tentando di cancellare.", MsgBoxStyle.Exclamation, "Cancellazione")
        End If
        updateDataGridView()
    End Sub
End Class