Imports System.Windows.Forms

Public Class FModificaDatiOS

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'inserimento nuova voce. se non già presente
        Dim feActions = New OrSe.ActionsLibrary()
        feActions.doComboInsNuovoValore(OperatoriComboBox, OperatoreTableAdapter, DbAlegatoADataSet.operatore)

        'Aggiornamento timestamp uso della voce operatore
        Dim dr As DataRowView = OperatoreBindingSource.Current
        Dim d As String
        Try
            d = dr.Item("dataoraultimouso")
        Catch ex As Exception
            d = ""
        End Try

        'Aggiornamento timestamp uso della voce operatore
        OperatoreTableAdapter.Update(dr.Item("operatori"), ActionsLibrary.getTimeStamp, dr.Item("id"), dr.Item("operatori"), d)
        Dim drOS As DataRowView = OrdineServizioBindingSource.Current

        drOS.Item("idOperatori") = dr.Item("id")

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
