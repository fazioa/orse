Public Class UserControlComboBox
    Private CurrentString As String
    Private iSelectedID, iCount As Integer
    Private bVoceSelezionata As Boolean = False
    Private tabella As tabellaEnum
    Dim log As New XOrseLog
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource

    Public Sub New()
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        Me.BindingSource.DataMember = "luoghicontrollo"
        'set dataset

        Me.BindingSource.DataSource = DbAlegatoADataSetBindingSource
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        'ListBox (Attenzione: viene creato da codice)
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.ListBox1.FormatString = "s"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 33
        Me.ListBox1.Name = "ListBox1"
        ' Me.ListBox1.Size = New System.Drawing.Size(20, 20)
        Me.Controls.Add(Me.ListBox1)

        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TextBox2.BorderStyle = Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(0, 0)
        Me.TextBox2.Name = "TextBox2"
        '  Me.TextBox2.Size = New System.Drawing.Size(20, 20)
        Me.TextBox2.TabIndex = 0
        Me.Controls.Add(Me.TextBox2)
        'TextBox2.Visible = True
        TextBox2.Enabled = False

        'abilito l'evento
        ListBox1_EventoSelectedValueChanged(True)
        TextBox1_EventoTextChanged(True)

        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private Sub ListBox1_EventoSelectedValueChanged(ByVal attivato As Boolean)
        If (attivato) Then
            AddHandler ListBox1.SelectedValueChanged, AddressOf Me.ListBox1_SelectedValueChanged
        Else
            RemoveHandler ListBox1.SelectedValueChanged, AddressOf Me.ListBox1_SelectedValueChanged
        End If
    End Sub

    Private Sub TextBox1_EventoTextChanged(ByVal attivato As Boolean)
        If (attivato) Then
            AddHandler TextBox1.TextChanged, AddressOf Me.TextBox1_TextChanged
        Else
            RemoveHandler TextBox1.TextChanged, AddressOf Me.TextBox1_TextChanged
        End If
    End Sub



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CurrentString = TextBox1.Text
        fill(CurrentString)
        ListBox1.Location = TextBox1.Location
        If ListBox1.Items.Count > 0 Then
            '    If ListBox1.SelectedItems.Count > 0 Then
            '================== posizionamento della listobox sotto alla textbox, dinamicamente
            If (Not ListBox1.FindForm.Controls.Contains(Me.ListBox1)) Then
                ListBox1.FindForm.Controls.Add(Me.ListBox1)
                TextBox2.FindForm.Controls.Add(Me.TextBox2)
            End If
            ListBox1.BringToFront()

            TextBox2.BringToFront()
            'calcola la posizione 
            Dim b = False
            Dim x, y As Integer

            x = TextBox1.Location.X
            y = TextBox1.Location.Y
            Dim o = TextBox1.Parent
            While o IsNot Nothing
                'y = y + o.Parent.Location.Y
                'x = x + o.Parent.Location.X
                y = y + o.Location.Y
                x = x + o.Location.X

                Try
                    'controllo se il parent è già un form
                    If o.parent.Equals(o.parentform) Then
                        Exit While
                    Else
                        o = o.parent
                    End If
                Catch ex As Exception
                    o = o.parent
                End Try

            End While
            Dim iDistanza As Integer = 1
            ListBox1.Location = New System.Drawing.Point(x, y + TextBox1.Height + iDistanza)
            TextBox2.Location = New System.Drawing.Point(x, y - TextBox2.Height - iDistanza / 2)

            ListBox1.Width = TextBox1.Width
            TextBox2.Width = TextBox1.Width
            '==================
            ListBox1_visible(True)
        End If
    End Sub

    ' Public Sub setDataSource(ByRef DataSource As System.Windows.Forms.BindingSource)
    '     Me.ListBox1.DataSource = DataSource
    '   BindingSource = DataSource
    ' Me.ListBox1.DataSource = LuoghicontrolloBindingSource
    ' BindingSource = LuoghicontrolloBindingSource
    ' End Sub


    Public Sub setSelectedValue(ByRef binding As System.Windows.Forms.BindingSource, ByVal sCampo As String)
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", binding, sCampo, True))
    End Sub

    Public Sub setDisplayMember(ByVal sMember As String)
        Me.ListBox1.DisplayMember = sMember
    End Sub

    Public Sub setValueMember(ByVal sValueMember As String)
        ListBox1.ValueMember = sValueMember
    End Sub

    Public Enum tabellaEnum
        ModelliMezzo = 1
        LuogoControllo = 2
    End Enum

    Public Sub setTabella(ByVal tab As tabellaEnum)
        tabella = tab
        Select Case tabella
            Case tabellaEnum.LuogoControllo
                Me.ListBox1.DataSource = LuoghicontrolloBindingSource
                BindingSource = LuoghicontrolloBindingSource
            Case tabellaEnum.ModelliMezzo
                Me.ListBox1.DataSource = ModelliMezzoBindingSource
                BindingSource = ModelliMezzoBindingSource
        End Select
    End Sub

    Private Sub fill(ByVal parametro As String)
        'se aggiorno il dataset vuol dire che non è stata selezionata alcuna voce
        bVoceSelezionata = False
        'disabilito l'evento del listobox
        ListBox1_EventoSelectedValueChanged(False)
        Select Case tabella
            Case tabellaEnum.LuogoControllo
                Me.LuoghicontrolloTableAdapter.FillByName(DbAlegatoADataSet.luoghicontrollo, parametro)
            Case tabellaEnum.ModelliMezzo
                ModelliMezzoTableAdapter.FillByMezzo(DbAlegatoADataSet.modelliMezzo, parametro)
        End Select
        'riattivo l'evento
        ListBox1_EventoSelectedValueChanged(True)
    End Sub

    Private Sub TextBox1_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Down Then
            'freccia giù - se listbox1 non è visibile allora la rendo visibile. Metto la condizione altrimenti ho altri effetti collaterali nel comportamento

            If (Not ListBox1.Visible) Then
                ListBox1_visible(True)
            End If
            ListBox1.Focus()
            'seleziono il primo elemento
            If (ListBox1.Items.Count > 0) Then ListBox1.SelectedIndex = 0


        ElseIf e.KeyCode = 13 Then
            'tasto invio
            InsNuovoValore()
        End If
    End Sub

    Private Sub ListBox1_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles ListBox1.PreviewKeyDown
        'carattere grigio
        ' TextBox1.ForeColor = Color.LightSlateGray
        If (ListBox1.SelectedIndex = 0) Then
            If e.KeyCode = 38 Then
                'freccia su se su primo elemento
                TextBox1.Focus()
            End If
        End If
        If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Tab Then
 
            selezionevoce()

        End If
    End Sub


    Private Sub selezionevoce()
        'sospende evento textchanged
        TextBox1_EventoTextChanged(False)

        'invio per selezionare una voce
        Dim drv As DataRowView = ListBox1.SelectedItem
        If (Not drv Is Nothing) Then
            TextBox1.Text = drv.Item(Me.ListBox1.DisplayMember)
            iSelectedID = ListBox1.SelectedValue
            'imposta il frag voece selezionata su true, viene disattivato al prossimo fill
            bVoceSelezionata = True
            'carattere NERO
            TextBox1.ForeColor = Color.Black
            ' ListBox1_visible(True)
            TextBox1.SelectionStart = 0
            TextBox1.SelectionLength = TextBox1.Text.Length
            TextBox1.Focus()
        End If

        'riprende evento textchanged
        TextBox1_EventoTextChanged(True)
    End Sub

    Private Sub BindingSource_ListChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles BindingSource.ListChanged
        iCount = BindingSource.Count
        If iCount <= 0 Then ListBox1_visible(False)
    End Sub

    Private Sub listbox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.Leave
        ListBox1_visible(False)
        'quando la list box perde il fuoco, il focus dovrebbe andare sull'elemento successivo a textbox1
        '        selezionevoce()
        TextBox1.Focus()

    End Sub

    Private Sub TextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        ' se il fuoco non è andato alla listbox1 allora la nasconde
        'se il fuoco non è andato alla listbox1 allora controllo se è stato selezionato un valore, altrimenti inseriso un nuovo valore
        If (Not ListBox1.Focus) Then
            ListBox1_visible(False)
            If (Not bVoceSelezionata) Then InsNuovoValore()
        End If

    End Sub

    Public Function InsNuovoValore()
        Try
            If (TextBox1.Text.Trim.Length > 0 And Me.FindStringExact() < 0) Then
                log.xlogWriteEntry("Inserimento """ & Me.Text & """ nella tabella """ & DbAlegatoADataSet.luoghicontrollo.ToString & """", TraceEventType.Critical)
                'inserisce il valore in tabella e poi lo seleziona nella listbox1
                Me.ins(CurrentString)
                Me.fill(CurrentString)
                ' ListBox1.SelectedIndex = Me.FindStringExact()
                iSelectedID = ListBox1.SelectedValue
                Return 1
            End If
        Catch ex As OleDb.OleDbException
            Throw New eccezione(ex.Message)
        End Try
        Return -1
    End Function

    Private Function ins(ByVal val As String)
        Select Case tabella
            Case tabellaEnum.LuogoControllo
                Return Me.LuoghicontrolloTableAdapter.Insert(val)
            Case tabellaEnum.ModelliMezzo
                Return Me.ModelliMezzoTableAdapter.Insert(val)
        End Select
        Return -1
    End Function

    Public Function getSelectedID()
        Return iSelectedID
    End Function

    Public Sub setSelectedID(ByVal i)
        Select Case tabella
            Case tabellaEnum.LuogoControllo
                'NON IMPLEMENTATO
            Case tabellaEnum.ModelliMezzo
                If (Me.ModelliMezzoTableAdapter.FillById(Me.DbAlegatoADataSet.modelliMezzo, i) >= 1) Then
                    'seleziono la prima voce del listbox. (il listbox è collegato al binding
                    ListBox1.SelectedIndex = 0
                    Dim drv As DataRowView = ListBox1.SelectedItem
                    'leggo il valore della voce selezionata
                    If (Not drv Is Nothing) Then
                        TextBox1.Text = drv.Item(Me.ListBox1.DisplayMember)
                        'la scrittura in textbox1 causa l'apparizione della listbox e della textbox2. Le nascondo
                        ListBox1_visible(False)
                    End If

                Else
                    Try

                    Catch
                        Dim e = New eccezione("Errore nella selezione del mezzo")
                    End Try
                End If
        End Select
       
    End Sub

    Public Function getCount()
        Return iCount
    End Function

    Public Function FindStringExact()
        Return ListBox1.FindStringExact(CurrentString)
    End Function

    Public Function getSelectedText()
        Return TextBox1.Text
        'Return ListBox1.SelectedItem.Item(Me.ListBox1.DisplayMember)
    End Function

    'funzione usata quando viene inserito un nuovo valore nel DB
    Shadows Function Text()
        Return TextBox1.Text
    End Function

    'evento attivato con addhandler
    Private Sub ListBox1_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            TextBox2.Text = ListBox1.SelectedItem.Item(Me.ListBox1.DisplayMember)
            '  iSelectedID = ListBox1.SelectedValue
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ListBox1_visible(ByVal stato As Boolean)
        ListBox1.Visible = stato
        TextBox2.Visible = stato
        If (stato) Then
            ListBox1.SelectedIndex = -1
        End If
    End Sub

    Private Sub ListBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        selezionevoce()

    End Sub
End Class
