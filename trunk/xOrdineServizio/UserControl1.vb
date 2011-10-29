Public Class UserControlComboBox
    Public CurrentString As String
    Dim iSelectedID As Integer
    Private tabella As tabellaEnum
    Dim log As New XOrseLog

    Dim frm As frmList


    Public Enum tabellaEnum
        ModelliMezzo = 1
        LuogoControllo = 2
    End Enum

    Public Sub New()
        InitializeComponent()
        TextBox1_AbilitazioneEventoTextChanged(True)
        frm = New frmList(Me, TextBox1)
        Timer1.Start()
    End Sub

    Public Sub setSelectedValue(ByRef binding As System.Windows.Forms.BindingSource, ByVal sCampo As String)
        frm.setSelectedValue(binding, sCampo)
    End Sub

    Public Sub setDisplayMember(ByVal sMember As String)
        frm.setDisplayMember(sMember)
    End Sub

    Public Sub setValueMember(ByVal sValueMember As String)
        frm.setValueMember(sValueMember)
    End Sub

    Public Sub setTabella(ByVal tab As tabellaEnum)
        tabella = tab
        Select Case tabella
            Case tabellaEnum.LuogoControllo
                frm.ListBox1.DataSource = LuoghicontrolloBindingSource
                frm.BindingSource = LuoghicontrolloBindingSource
                TextBox1.MaxLength = DbAlegatoADataSet.luoghicontrollo.luogoColumn.MaxLength

            Case tabellaEnum.ModelliMezzo
                frm.ListBox1.DataSource = ModelliMezzoBindingSource
                frm.BindingSource = ModelliMezzoBindingSource
                TextBox1.MaxLength = DbAlegatoADataSet.modelliMezzo.mezzoColumn.MaxLength
        End Select
    End Sub

    Private Sub fill(ByVal parametro As String)
        'se aggiorno il dataset vuol dire che non è stata selezionata alcuna voce
        'bVoceSelezionata = False
        'disabilito l'evento del listobox
        ' frm.ListBox1_AbilitaEventiListBox(False)
        Select Case tabella
            Case tabellaEnum.LuogoControllo
                Me.LuoghicontrolloTableAdapter.FillByName(DbAlegatoADataSet.luoghicontrollo, parametro)
            Case tabellaEnum.ModelliMezzo
                ModelliMezzoTableAdapter.FillByMezzo(DbAlegatoADataSet.modelliMezzo, parametro)
        End Select
        'riattivo l'evento
        'frm.ListBox1_AbilitaEventiListBox(True)
        'frm.visibleMy(True)
    End Sub


    Private Sub TextBox1_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Down Then
            'freccia giù - se listbox1 non è visibile allora la rendo visibile. 
            'Metto la condizione altrimenti ho altri effetti collaterali nel comportamento
            frm.ListBox1.Focus()
            'seleziono il primo elemento
            If (frm.ListBox1.Items.Count > 0) Then
                ' frm.ListBox1.SelectedIndex = 0
                If (Not frm.ListBox1.Visible) Then
                    frm.visibleMy(True)
                End If
            Else
                frm.visibleMy(False)
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            'tasto invio
            InsNuovoValore()
        ElseIf e.KeyCode = Keys.Escape Then
            frm.visibleMy(False)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CurrentString = TextBox1.Text.Trim
        If CurrentString <> "" Then
            fill(CurrentString)
            If (frm.ListBox1.Items.Count > 0) Then
                If Not frm.ListBox1.Visible Then
                    frm.visibleMy(True)
                End If
                frm.ListBox1.SetSelected(0, False)
            Else
                'azzero il flag voceSelezionata
                frm.bVoceSelezionata = False
                frm.visibleMy(False)
            End If
            'disattiva evento deactivate
            frm.EventoDeactivateAbilitato(False)
            TextBox1.Focus()
            frm.EventoDeactivateAbilitato(True)
            '==================
        Else
            frm.visibleMy(False)
        End If
    End Sub

    Public Sub TextBox1_AbilitazioneEventoTextChanged(ByVal attivato As Boolean)
        If (attivato) Then
            AddHandler TextBox1.TextChanged, AddressOf Me.TextBox1_TextChanged
        Else
            RemoveHandler TextBox1.TextChanged, AddressOf Me.TextBox1_TextChanged
        End If
    End Sub


    Public Function InsNuovoValore()
        Try
            If (TextBox1.Text.Trim.Length > 0 And Me.FindStringExact() < 0) Then
                log.xlogWriteEntry("Inserimento """ & Me.Text & """ nella tabella """ & DbAlegatoADataSet.luoghicontrollo.ToString & """", TraceEventType.Critical)
                'inserisce il valore in tabella e poi lo seleziona nella listbox1
                Me.ins(CurrentString.Trim)
                Me.fill(CurrentString.Trim)
                iSelectedID = frm.getSelectedID()
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
        Return frm.ListBox1.SelectedValue
    End Function

    Public Sub setSelectedID(ByVal i)
        Select Case tabella
            Case tabellaEnum.LuogoControllo
                'NON IMPLEMENTATO
            Case tabellaEnum.ModelliMezzo
                If (Me.ModelliMezzoTableAdapter.FillById(Me.DbAlegatoADataSet.modelliMezzo, i) >= 1) Then
                    'seleziono la prima voce del listbox. (il listbox è collegato al binding
                    frm.ListBox1.SelectedIndex = 0
                    Dim drv As DataRowView = frm.ListBox1.SelectedItem
                    'leggo il valore della voce selezionata
                    If (Not drv Is Nothing) Then
                        TextBox1.Text = drv.Item(frm.ListBox1.DisplayMember)
                        'la scrittura in textbox1 causa l'apparizione della listbox e della textbox2. Le nascondo
                        frm.visibleMy(False)
                    End If
                Else
                    Try

                    Catch
                        Dim e = New eccezione("Errore nella selezione del mezzo")
                    End Try
                End If
        End Select

    End Sub



    Public Function FindStringExact()
        Return frm.ListBox1.FindStringExact(CurrentString)
    End Function

    Public Function getSelectedText()
        Return TextBox1.Text.Trim
        'Return ListBox1.SelectedItem.Item(Me.ListBox1.DisplayMember)
    End Function

    'funzione usata quando viene inserito un nuovo valore nel DB
    Shadows Function Text()
        Return TextBox1.Text.Trim
    End Function



    Private Sub TextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        ' se il fuoco non è andato alla listbox1 allora la nasconde
        'se il fuoco non è andato alla listbox1 allora controllo se è stato selezionato un valore, altrimenti inseriso un nuovo valore
        If (Not frm.ListBox1.Focused) Then
            frm.visibleMy(False)
            If (Not frm.bVoceSelezionata) Then InsNuovoValore()

        End If

    End Sub

    Public Function getCount()
        Return frm.getCount
    End Function


    Public Sub MaxLength(ByVal i As Integer)
        TextBox1.MaxLength = i
    End Sub

    Private Sub UserControlComboBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        'nasconde il form con la listbox quando il usercontrol perde il focus
        frm.visibleMy(False)
    End Sub

    Dim loc As Point
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If (Me.PointToScreen(Me.Location) <> loc) Then
            loc = Me.PointToScreen(Me.Location)
            frm.visibleMy(False)
        End If
    End Sub

End Class



<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private Textbox1 As TextBox
    Private iCount, iSelectedID As Integer
    Public bVoceSelezionata As Boolean = False
    Dim log As New XOrseLog

    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbAlegatoADataSetBindingSource As System.Windows.Forms.BindingSource

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container

        Me.ListBox1 = New System.Windows.Forms.ListBox

        Me.DbAlegatoADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DbAlegatoADataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()


        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

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
        Me.ListBox1.Dock = DockStyle.Fill
        ' Me.ListBox1.Size = New System.Drawing.Size(20, 20)

        Me.Controls.Add(Me.ListBox1)

        'abilito l'evento
        '   ListBox1_AbilitaEventiListBox(True)

        Me.ResumeLayout()
        Me.PerformLayout()

        '
        'form tipo splashScreen
        '
        Me.TopMost = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmList"
        Me.ShowInTaskbar = False
        ' Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Dim UserContr As UserControlComboBox
    Public Sub New(ByRef userctrl As UserControlComboBox, ByRef tb As TextBox)
        UserContr = userctrl
        Textbox1 = tb
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    Public Sub ListBox1_AbilitaEventiListBox(ByVal attivato As Boolean)
        If (attivato) Then
            AddHandler ListBox1.SelectedValueChanged, AddressOf Me.ListBox1_SelectedValueChanged
        Else
            RemoveHandler ListBox1.SelectedValueChanged, AddressOf Me.ListBox1_SelectedValueChanged
        End If
    End Sub

    Public Sub setSelectedValue(ByRef binding As System.Windows.Forms.BindingSource, ByVal sCampo As String)
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", binding, sCampo, True))
    End Sub

    Public Sub setDisplayMember(ByVal sMember As String)
        Me.ListBox1.DisplayMember = sMember
    End Sub

    Public Sub setValueMember(ByVal sValueMember As String)
        ListBox1.ValueMember = sValueMember
    End Sub

    Private Sub ListBox1_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles ListBox1.PreviewKeyDown
        'carattere grigio
        ' TextBox1.ForeColor = Color.LightSlateGray
        If (Me.ListBox1.SelectedIndex = 0) Then
            If e.KeyCode = Keys.Up Then
                'freccia su se su primo elemento
                Textbox1.Focus()
                Me.visibleMy(False)
            End If
        End If
        If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Tab Then
            selezionevoce()
        End If
    End Sub

    Private Sub ListBox1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        selezionevoce()
    End Sub


    ' Private Sub BindingSource_ListChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles BindingSource.ListChanged
    '    iCount = Me.BindingSource.Count
    '    iCount = ListBox1.Items.Count
    '    If iCount <= 0 Then
    '        Me.visibleMy(False)
    '    Else
    '        Me.visibleMy(True)
    '    End If
    'End Sub

    Private Sub selezionevoce()
        'sospende evento textchanged

        UserContr.TextBox1_AbilitazioneEventoTextChanged(False)
        'invio per selezionare una voce
        Dim drv As DataRowView = ListBox1.SelectedItem
        If (Not drv Is Nothing) Then
            log.xlogWriteEntry("Voce selezionata:" & drv.Item(ListBox1.DisplayMember), TraceEventType.Critical)
            Textbox1.Text = drv.Item(ListBox1.DisplayMember)
            iSelectedID = ListBox1.SelectedValue
            'imposta il frag voece selezionata su true, viene disattivato al prossimo fill
            bVoceSelezionata = True
            'carattere NERO
            Textbox1.ForeColor = Color.Black

            'visto che in passato sono state inserite stringhe lunghe 150 caratteri, eseguo il trim
            Textbox1.Text = Textbox1.Text.Trim

            Textbox1.SelectionStart = 0
            Textbox1.SelectionLength = Textbox1.Text.Length
            Textbox1.Focus()
        End If

        'riprende evento textchanged
        UserContr.TextBox1_AbilitazioneEventoTextChanged(True)
    End Sub

    'evento attivato con addhandler
    Public Sub ListBox1_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        selezionevoce()
    End Sub

    Public Function getCount()
        Return iCount
    End Function

    Public Sub frmLocationUpdate()
        Dim iDistanza As Integer = 1
        Dim x As Integer = Textbox1.PointToScreen(Textbox1.Location).X
        Dim y As Integer = Textbox1.PointToScreen(Textbox1.Location).Y
        Me.Location = New System.Drawing.Point(x, y + Textbox1.Height + iDistanza)
        Me.Width = Textbox1.Width
    End Sub

    Public Sub visibleMy(ByVal stato As Boolean)
        Me.Visible = stato
        If (stato) Then
            frmLocationUpdate()
        End If
    End Sub

    Public Function getSelectedID() As Integer
        Return ListBox1.SelectedValue
    End Function

    Public Sub EventoDeactivateAbilitato(ByVal state As Boolean)
        If state Then
            AddHandler MyBase.Deactivate, AddressOf Me.frmList_Deactivate
        Else
            RemoveHandler MyBase.Deactivate, AddressOf Me.frmList_Deactivate
        End If

    End Sub

    Private Sub frmList_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        visibleMy(False)
    End Sub

End Class