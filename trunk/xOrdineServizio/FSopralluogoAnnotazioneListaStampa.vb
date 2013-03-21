Imports System.Windows.Forms

Public Class FSopralluogoAnnotazioneListaStampa
    Dim log As New XOrseLog
    Dim feActions As New OrSe.ActionsLibrary
    Dim parametriOS As parametriControllo_e_OS

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Select Case TabControl1.SelectedIndex
            '"Sopralluogo"
            Case 0
                generaReportSopralluogo(parametriOS.nomeOperatore)
                '"Annotazione"
            Case 1
                generaReportAnnotazione()
        End Select


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Public Sub New(ByVal parametri As parametriControllo_e_OS)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        parametriOS = parametri
        Me.SopralluogoTableAdapter.FillByOS(Me.DbAlegatoADataSet.sopralluogo, parametri.idOS)

        Me.InterventiTableAdapter.FillByOS(Me.DbAlegatoADataSet.interventi, parametri.idOS, paragrafoOS.interventi)
    End Sub

    Private Sub SopralluogoAnnotazione_DataGridView_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles SopralluogoDataGridView.CellPainting, InterventiDataGridView.CellPainting
        feActions.genericoDataGridView_CellPainting(sender)
    End Sub

    Private Sub SopralluogoDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SopralluogoDataGridView.CellDoubleClick
        Try
            ' Dim dgv As DataGridView = sender
            ' Dim v As Integer = dgv.CurrentRow.Cells("idSopralluogo").Value
            generaReportSopralluogo(parametriOS.nomeOperatore)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AnnotazioneDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SopralluogoDataGridView.CellDoubleClick, InterventiDataGridView.CellDoubleClick
        Try
            'Dim dgv As DataGridView = sender
            'Dim v As Integer = dgv.CurrentRow.Cells("idIntervento").Value
            generaReportAnnotazione()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub generaReportSopralluogo(ByVal nomeOperatore As String)
        feActions.wordInizializzaEcompilaVerbaleSopralluogo(SopralluogoBindingSource, parametriOS.nomeOperatore)
    End Sub

    Private Sub generaReportAnnotazione()
        feActions.wordInizializzaEcompilaAnnotazionePG(InterventiBindingSource, parametriOS.nomeOperatore)
    End Sub


End Class
