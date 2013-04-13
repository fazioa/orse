Imports System.Deployment
Public Class FRicerca
    Dim feActions As New OrSe.ActionsLibrary
    Dim parametri As New parametriControllo_e_OS

    Private Sub InterventiDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles interventiDataGrid.CellClick
        Dim dgv As DataGridView = sender
        If e.ColumnIndex = dgv.Columns("cDettaglioInterventi").Index() Then
            'non passo il dataset fillato perchè nel datagrid uso una query e non la tabella di cui avrò bisogno nel form
            feActions.doApriDettaglioIntervento(interventiDataGrid, e, "iddgvInterventi", parametri)
        End If
    End Sub

    Private Sub InformazioniDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles InformazioniDataGrid.CellClick
        Dim dgv As DataGridView = sender
        If e.ColumnIndex = dgv.Columns("cDettaglioInformazioni").Index() Then
            'non passo il dataset fillato perchè nel datagrid uso una query e non la tabella di cui avrò bisogno nel form
            feActions.doApriDettaglioIntervento(InformazioniDataGrid, e, "iddgvInformazioni", parametri)
        End If
    End Sub

    Private Sub SoggettiDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles QAllegatoADataGridView.CellClick
        Dim dgv As DataGridView = sender
        Dim coord As System.Drawing.Point = dgv.CurrentCellAddress
        If coord.X = dgv.Columns("cDettaglio").Index() Then
            apriDettaglioSoggetto(dgv)
        End If
    End Sub
    Private Sub apriDettaglioSoggetto(ByRef dgv As DataGridView)
        Dim v As Integer = dgv.CurrentRow.Cells("cID").Value
        parametri.nomeLuogoControllo = dgv.CurrentRow.Cells("cLuogoControllo").Value
        parametri.dataoraControllo = dgv.CurrentRow.Cells("cOra").Value
        feActions.doApriDettaglioSoggetto(DbAlegatoADataSet, parametri, v)
    End Sub


    Private Sub FRicerca_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        tbCampoRicerca.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cerca()
    End Sub
    Private Sub cerca()
        Me.QAllegatoATableAdapter.FillByCampoRicerca(Me.DbAlegatoADataSet.QAllegatoA, tbCampoRicerca.Text.Trim)
        Me.QInterventiTableAdapter.FillByCampoRicerca(Me.DbAlegatoADataSet.QInterventi, tbCampoRicerca.Text.Trim)
        Me.QSopralluogoTableAdapter.FillByCampoRicerca(Me.DbAlegatoADataSet.QSopralluogo, tbCampoRicerca.Text.Trim)
        Me.RubricaTableAdapter.FillByCampoRicerca(DbAlegatoADataSet.rubrica, tbCampoRicerca.Text.Trim)
    End Sub


    Private Sub tbCampoRicerca_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles tbCampoRicerca.PreviewKeyDown
        If (e.KeyCode = 13) Then
            cerca()
        End If
    End Sub


    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        feActions.setStandardFormSize(Me)
        ' Add any initialization after the InitializeComponent() call.
        QInterventi_informazioniBindigSource.Filter = "iParagrafo=" & paragrafoOS.informazioni
        QInterventiBindingSource.Filter = "iParagrafo=" & paragrafoOS.interventi

    End Sub

    Private Sub SopralluogoDataGrid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SopralluogoDataGrid.CellClick
        Dim dgv As DataGridView = sender
        Dim coord As System.Drawing.Point = dgv.CurrentCellAddress
        If coord.X = dgv.Columns("cDettaglioSopralluogo").Index() Then
            feActions.doApriDettaglioSopralluogo(dgv.CurrentRow.Cells("sopralluogo_id").Value, dgv.CurrentRow.Cells("operatori").Value)
        End If
    End Sub

    Private Sub DataGridView3_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles rubricaDataGrid.CellClick
        Dim dgv As DataGridView = sender
        Dim coord As System.Drawing.Point = dgv.CurrentCellAddress
        If coord.X = dgv.Columns("cDettaglioRubrica").Index() Then
            feActions.doApriDettaglioRubrica(dgv.CurrentRow.Cells("idRub").Value)
        End If
    End Sub

   


    'Private Sub DataGrid_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles rubricaDataGrid.Paint, interventiDataGrid.Paint, QAllegatoADataGridView.Paint, InformazioniDataGrid.Paint, SopralluogoDataGrid.Paint
    '    Dim dgv As DataGridView = sender

    '    dgv.BorderStyle = BorderStyle.None
    '    dgv.ColumnHeadersHeight = 16
    '    Dim cellStyle As DataGridViewCellStyle = New DataGridViewCellStyle()
    '    cellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)

    '    dgv.ColumnHeadersDefaultCellStyle = cellStyle
    'End Sub
End Class