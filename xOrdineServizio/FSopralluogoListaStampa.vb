Imports System.Windows.Forms

Public Class FSopralluogoListaStampa
    Dim log As New XOrseLog
    Dim feActions As New OrSe.ActionsLibrary
    Dim parametriOS As parametriControllo_e_OS

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        generaReport(parametriOS.nomeOperatore)
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
    End Sub

    Private Sub SopralluogoDataGridView_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles SopralluogoDataGridView.CellPainting
        feActions.genericoDataGridView_CellPainting(sender)
    End Sub

    Private Sub SopralluogoDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SopralluogoDataGridView.CellDoubleClick
        Dim dgv As DataGridView = sender
        Dim v As Integer = dgv.CurrentRow.Cells("idSopralluogo").Value
        generaReport(parametriOS.nomeOperatore)

    End Sub

    Private Sub generaReport(ByVal nomeOperatore As String)
        feActions.wordInizializzaEcompilaVerbaleSopralluogo(SopralluogoBindingSource, parametriOS.nomeOperatore)
    End Sub
End Class
