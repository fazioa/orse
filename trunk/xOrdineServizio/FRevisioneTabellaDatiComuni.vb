Public Class FRevisioneTabellaDatiComuni
    Dim feActions As New ActionsLibrary
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        feActions.setStandardFormSize(Me)
        feActions.datagridviewSetup(ComuneDataGridView)

        ComuneDataGridView.AllowUserToDeleteRows = False

        ComuneDataGridView.ReadOnly = False
        ComuneDataGridView.AllowUserToAddRows = True
        ComuneDataGridView.RowHeadersVisible = True
    End Sub

    Private Sub LuoghicontrolloBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ComuneBindingSource.EndEdit()
        Me.ComuneTableAdapter.Update(Me.DbAlegatoADataSet.comune)

    End Sub

    Private Sub FAggiuntaVoceTabellaDatiComuni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbAlegatoADataSet.comune' table. You can move, or remove it, as needed.
        Me.ComuneTableAdapter.Fill(Me.DbAlegatoADataSet.comune)
        updateDataGridView()

    End Sub

    Private Sub updateDataGridView()
        Me.ComuneTableAdapter.Fill(Me.DbAlegatoADataSet.comune)
    End Sub

    Private Sub ComuneDataGridView_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ComuneDataGridView.CellValueChanged
        Me.Validate()
        Me.ComuneBindingSource.EndEdit()
        Me.ComuneTableAdapter.Update(Me.DbAlegatoADataSet.comune)
        updateDataGridView()
    End Sub


End Class