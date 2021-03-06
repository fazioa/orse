Imports System.Windows.Forms

Public Class FElencosoggetti
    Dim bTutti As Boolean
    Dim feActions As New OrSe.ActionsLibrary

    Private iResult As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FElencosoggetti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'porto il fuoco direttamente sul text box cognome
        tbCognome.Focus()
    End Sub

    Private Sub tbCognome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCognome.TextChanged
        Aggiorna()
    End Sub

    Private Sub Aggiorna()
        If (bTutti) Then
            QPersonaTableAdapter.FillByDati(DbAlegatoADataSet.QPersona, tbCognome.Text, tbNome.Text)
        Else
            QPersonaTableAdapter.FillByDatiPIO(DbAlegatoADataSet.QPersona, tbCognome.Text, tbNome.Text)
        End If
    End Sub


    Private Sub tbNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNome.TextChanged
        Aggiorna()
    End Sub

    Private Sub rTutti_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rTutti.CheckedChanged
        bTutti = True
        Me.QPersonaTableAdapter.FillByDati(Me.DbAlegatoADataSet.QPersona, "", "")
    End Sub

    Private Sub rIO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rIO.CheckedChanged
        bTutti = False
        Me.QPersonaTableAdapter.FillByDatiPIO(Me.DbAlegatoADataSet.QPersona, "", "")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            iResult = QPersonaDataGridView.CurrentRow.Cells("ID").Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End Try

    End Sub
    'metodo che restituisce il risultato della maschera
    Public Function getResult()
        getResult = iResult
    End Function

    Private Sub bntAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        feActions.setStandardFormSize(Me)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub QPersonaDataGridView_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles QPersonaDataGridView.CellPainting
        Dim dgv As DataGridView = sender
        datagridviewSetup(dgv)
        Dim stile As DataGridViewCellStyle = New DataGridViewCellStyle()
        stile.BackColor() = Color.Lavender
        dgv.AlternatingRowsDefaultCellStyle() = stile
    End Sub

    Private Sub datagridviewSetup(ByVal sender As System.Object)
        Dim dgv As DataGridView = sender
        dgv.MultiSelect = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.ColumnHeadersVisible = True
        dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        'dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        dgv.RowHeadersVisible = False
        dgv.AllowUserToResizeColumns = True
        dgv.AllowUserToResizeRows = True
        dgv.AllowUserToAddRows = False
        dgv.ReadOnly = True
        '----------------
        dgv.BackgroundColor = Color.Silver
        dgv.BorderStyle = BorderStyle.FixedSingle
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgv.GridColor = Color.WhiteSmoke
        dgv.DefaultCellStyle.BackColor = Color.FloralWhite
    End Sub

End Class
