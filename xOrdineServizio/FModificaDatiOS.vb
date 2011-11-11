Imports System.Windows.Forms

Public Class FModificaDatiOS

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.Validate()
        Me.OrdineServizioBindingSource.EndEdit()
        Me.OrdineServizioTableAdapter.Update(Me.DbAlegatoADataSet.ordineServizio)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub New(ByVal idOS As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.OperatoreTableAdapter.Fill(Me.DbAlegatoADataSet.operatore)

        Me.OrdineServizioTableAdapter.FillByID(Me.DbAlegatoADataSet.ordineServizio, idOS)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
