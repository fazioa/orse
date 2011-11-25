Public Class FSopralluogo
    Dim log As New XOrseLog
    Dim feActions As New OrSe.ActionsLibrary
    Private idSopralluogo As Integer = -1
    Private xIdOS As Integer

    Private nomiOperatori As String

    Private Sub btnSalvaChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvaChiudi.Click
        salva()
        Me.Close()
    End Sub

    Dim bSaved As Boolean = False
    Private Sub salva()
        Dim sTipoReato As String

        'quando assegno un valore a drv.item, tutti i campi del binding vengono riportati allo stato dell'ultimo salvataggio, perdo quindi tutte le modifiche.
        ' ho risolto inserendo il flag saved
        If (RadioButtonTipoFurtoAbitazione.Checked) Then
            sTipoReato = "Furto in abitazione"
        Else
            sTipoReato = TextBoxTipoAltro.Text
        End If
        Try
            Dim drv As DataRowView = SopralluogoBindingSource.Current()
            If (Not bSaved) Then
                drv.Item("tipoReato") = sTipoReato
                drv.Item("oraRedazione") = DateTimePickerOraVerbale.Value
                drv.Item("oraRichiesta") = DateTimePickerOraRichiesta.Value
            End If
          

            Me.Validate()
            Me.SopralluogoBindingSource.EndEdit()
            Me.SopralluogoTableAdapter.Update(Me.DbAlegatoADataSet.sopralluogo)
            'se non si è sollevata eccezione vuol dire che il salvataggio è andato a buon fine
            bSaved = True
            'leggo l'id del sopralluogo e lo salvo. Mi servirà nei salvataggi intermedi, quando l'update solleverà l'eccezione. Allora nella sezione Catch eseguirà l comando SQL update. Conviene fare così, per evitare altri problemi col binding. Cursore che si sposta etc...
            idSopralluogo = SopralluogoTableAdapter.MaxID
            log.xlogWriteEntry("Inserimento sopralluogo - Salvataggio dati", TraceEventType.Critical)
        Catch ex As DBConcurrencyException
            Try
                sTipoReato = sTipoReato.Replace("'", "''")
                Dim sLuogo As String = TextBoxLuogo.Text.Replace("'", "''")
                Dim sVia As String = TextBoxVia.Text.Replace("'", "''")
                Dim sContatti As String = TextBoxContatti.Text.Replace("'", "''")
                Dim sResoconto As String = TextBoxResoconto.Text.Replace("'", "''")

                log.xlogWriteEntry("Inserimento sopralluogo - Salvataggio automatico - Eseguo comando SQL Update", TraceEventType.Critical)
                Dim i = feActions.esegueSQL("UPDATE sopralluogo SET idOS=" & xIdOS & ", tipoReato='" & sTipoReato & "', oraRichiesta=#" & DateTimePickerOraRichiesta.Value & "#, oraRedazione=#" & DateTimePickerOraVerbale.Value & "#, luogo_citta='" & sLuogo & "', via='" & sVia & "', contatti_con='" & sContatti & "', resoconto='" & sResoconto & "' WHERE idSopralluogo=" & idSopralluogo)
                log.xlogWriteEntry("Numero righe modificate: " & i, TraceEventType.Information)
                If i = 0 Then MsgBox("Contenuto non salvato!", MsgBoxStyle.Critical, "ATTENZIONE")
            Catch exc As Exception
                log.xlogWriteEntry("Inserimento sopralluogo - Errore Salvataggio automatico - " & exc.Message, TraceEventType.Critical)
                MsgBox("Contenuto non salvato!" & ex.Message, MsgBoxStyle.Critical, "ATTENZIONE")
            End Try
        End Try



    
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
        Else
            'il salvataggio automatico è disattivato quando si modifica un record
            'imposto l'intervallo per il salvataggio automatico al valore delle impostazioni (in secondi)
            If (Integer.Parse(My.Settings.intervalloSalvataggioAutomatico) > 0) Then
                TimerSalvataggioAutomatico.Interval = My.Settings.intervalloSalvataggioAutomatico * 1000
                TimerSalvataggioAutomatico.Start()
            End If
        End If

        'leggo le frasi dal file delle impostazioni e le carico nella listbox. Nota: nelle impostazione c'è un'unica stringa divisa da &&
        Dim sVociRapide As String = My.Settings.sopralluogoListBoxVociRapide
        Dim ArrayVociRapide As Array = sVociRapide.Split("&")


        For i As Integer = 0 To ArrayVociRapide.Length - 1
            ListBoxFrasi.Items.Add(ArrayVociRapide(i))
        Next

        'carico il testo del promemoria dalle impostazioni
        RichTextBoxPromemoria.Text = My.Settings.sopralluogoPromemoria
    End Sub


    Public Sub New(ByVal idOS As Integer, ByVal idS As Integer, ByVal nomiOp As String)
        xIdOS = idOS

        nomiOperatori = nomiOp
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        feActions.setStandardFormSize(Me)
        'se l'id è maggiore di zero allora sto modificando, altrimenti inserisco un nuovo elemento
        If (idS >= 0) Then
            idSopralluogo = idS
        Else
            Me.SopralluogoBindingSource.AddNew()
            log.xlogWriteEntry("Apertura form sopralluogo - nuovo sopralluogo", TraceEventType.Information)
            Dim drv As DataRowView = SopralluogoBindingSource.Current()
            drv.Item("idOS") = xIdOS
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
            feActions.wordInizializzaEcompilaVerbaleSopralluogo(SopralluogoBindingSource, nomiOperatori)
        

        Catch

        End Try

    End Sub

    Dim contenutoCambiato As Boolean = False

    Private Sub setChanged(ByVal contenutoCamb As Boolean)
        '  log.xlogWriteEntry("Inserimento sopralluogo - Contenuto cambiato=" & contenutoCamb.ToString, TraceEventType.Information)
        contenutoCambiato = contenutoCamb
        'se il contenuto del form è cambiato allora setto il flag e aggiungo un asterisco al titolo
        'altrimenti tolgo l'asterisco
        If Me.Text.Length > 0 Then
            If (contenutoCambiato) Then
                'se l'asterisco c'è già allora non ne aggiungo altri
                If (Me.Text.Substring(0, 1) <> "*") Then Me.Text = "*" & Me.Text
            Else
                If (Me.Text.Substring(0, 1) = "*") Then Me.Text = Me.Text.Substring(1)
            End If
        End If
    End Sub

    Private Sub RadioButtonTipoFurtoAbitazione_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonTipoFurtoAbitazione.CheckedChanged
        setChanged(True)
    End Sub

    Private Sub TextBoxTipoAltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxTipoAltro.TextChanged, TextBoxVia.TextChanged, TextBoxLuogo.TextChanged, TextBoxContatti.TextChanged, DateTimePickerOraVerbale.ValueChanged, DateTimePickerOraRichiesta.ValueChanged, TextBoxResoconto.TextChanged
        setChanged(True)
    End Sub

    Private Sub TimerSalvataggioAutomatico_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSalvataggioAutomatico.Tick
        If (Not (TextBoxContatti.Text = "" And TextBoxLuogo.Text = "" And TextBoxVia.Text = "" And TextBoxResoconto.Text = "" And TextBoxTipoAltro.Text = "") And contenutoCambiato = True) Then
            log.xlogWriteEntry("Inserimento sopralluogo - Salvataggio automatico", TraceEventType.Critical)
            salva()
            setChanged(False)
        End If
    End Sub

    Private dragBounds As Rectangle
    Private dragMethod As String
    Private Sub TextBoxResoconto_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBoxResoconto.DragEnter
        ' ----- Yes, we accept the items.
        'If (e.Data.GetDataPresent(ListBoxFrasi. SelectedItems.GetType()) = True) Then
        If (e.Data.GetDataPresent(String.Empty.GetType) = True) Then
            e.Effect = DragDropEffects.Move
        End If


    End Sub

    '  Private Sub TextBoxResoconto_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBoxResoconto.DragDrop
    ' ----- Accept the dropped items.
    ' For Each oneItem As Object In e.Data.GetData(ListBoxFrasi.SelectedItems.GetType())
    '     For Each oneItem As Object In e.Data.GetData(String.Empty.GetType)
    '        TextBoxResoconto.AppendText(oneItem.ToString)
    '    Next oneItem
    'End Sub

    ' Drop the text into the TextBox.
    Private Sub TextBoxResoconto_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBoxResoconto.DragDrop
        TextBoxResoconto.SelectedText = e.Data.GetData(DataFormats.StringFormat)
    End Sub

    Private Sub ListBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxFrasi.MouseDown ', ListBox2.MouseDown
        ' ----- Prepare the draggable content.
        If (CType(sender, ListBox).SelectedItems.Count = 0) Then Return

        ' ----- Don't start the drag yet. Wait until we move a
        '       certain amount.
        dragBounds = New Rectangle(New Point(e.X - (SystemInformation.DragSize.Width / 2), e.Y - (SystemInformation.DragSize.Height / 2)), SystemInformation.DragSize)
        If (sender Is ListBoxFrasi) Then
            dragMethod = "1to2"
        Else
            dragMethod = "2to1"
        End If
    End Sub

    Private Sub ListBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxFrasi.MouseMove
        ' ----- Ignore if not dragging from ListBox1.
        If (dragMethod <> "1to2") Then Return

        ' ----- Have we left the drag boundary?
        If (dragBounds.Contains(e.X, e.Y) = False) Then
            ' ----- Start the drag-and-drop operation.
            If (ListBoxFrasi.DoDragDrop(ListBoxFrasi.SelectedItem.ToString, DragDropEffects.Copy) = DragDropEffects.Copy) Then
                ' ----- Successful move. Remove the items from
                '       this list.
                '  Do While ListBoxFrasi.SelectedItems.Count > 0
                'ListBoxFrasi.Items.Remove(ListBox1.SelectedItems(0))
                'Loop
            End If
            dragMethod = ""
        End If
    End Sub

    Private Sub ListBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxFrasi.MouseUp ', ListBox2.MouseUp
        ' ----- End of drag-and-drop.
        dragMethod = ""
    End Sub

    Private Sub TextBoxResoconto_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBoxResoconto.DragOver
        If e.Data.GetDataPresent(DataFormats.StringFormat) Then
            ' Allow the drop.
            e.Effect = DragDropEffects.Copy

            ' Optionally move the cursor position so
            ' the user can see where the drop would happen.
            TextBoxResoconto.Select(TextBoxCursorPos(TextBoxResoconto, e.X, e.Y), 0)

        Else
            ' Do not allow the drop.
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Const EM_CHARFROMPOS As Int32 = &HD7

    'When a drag moves over the TextBox, the DragOver event handler calls the TextBoxCursorPos function to see where the cursor is over the TextBox and it places the insertion position there.
    'If the user drops on the TextBox, the program inserts the dropped text at the current insertion position. 
    Private Declare Function SendMessageLong Lib "user32" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As Int32) As Long
    'Function TextBoxCursorPos converts the mouse's coordinates from screen coordinates to the TextBox's coordinate system (both are in pixels). It then sends the EM_CHARFROMPOS message to the TextBox to get the position within the TextBox corresponding to the mouse's position. sends the Text 
    ' Return the character position under the mouse.
    Public Function TextBoxCursorPos(ByVal txt As TextBox, ByVal X As Single, ByVal Y As Single) As Long
        ' Convert screen coordinates into control coordinates.
        Dim pt As Point = TextBoxResoconto.PointToClient(New Point(X, Y))

        ' Get the character number
        TextBoxCursorPos = SendMessageLong(txt.Handle, EM_CHARFROMPOS, 0&, CLng(pt.X + pt.Y * &H10000)) And &HFFFF&
    End Function

    'in caso di doppio click aggiungo la frase in fondo al textbox
    Private Sub ListBoxFrasi_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxFrasi.MouseDoubleClick
        TextBoxResoconto.AppendText(ListBoxFrasi.SelectedItem.ToString() & ControlChars.NewLine)
    End Sub

End Class
