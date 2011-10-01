Imports System.Windows.Forms

Public Class FElencosoggetti
    Dim bTutti As Boolean
    Dim feActions As OrSe.ActionsLibrary

    Private iResult As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
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
        iResult = QPersonaDataGridView.CurrentRow.Cells("ID").Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
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
End Class
