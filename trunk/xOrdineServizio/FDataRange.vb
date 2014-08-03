Imports System.Windows.Forms

Public Class FDataRange

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'imposto la data di ultima esportazione
        My.Settings.dataUltimaEsportazioneDati = DateTimePickerFine.Value

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim d As New dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter

        'imposto nel date di inizio e fine
        Dim obj As System.Nullable(Of Date) = d.ScalarQueryDataOraMinima()
        If obj.HasValue Then
            DateTimePickerInizio.Value = d.ScalarQueryDataOraMinima()
        Else
            DateTimePickerInizio.Value = Now
        End If

        obj = d.ScalarQueryDataOraMassima
        If obj.HasValue Then
            DateTimePickerFine.Value = d.ScalarQueryDataOraMassima
        Else
            DateTimePickerFine.Value = Now
        End If



    End Sub


    Public Function getStartDateResult()
        Dim d As Date = New Date(DateTimePickerInizio.Value.Year, DateTimePickerInizio.Value.Month, DateTimePickerInizio.Value.Day, 0, 0, 0)
        Return d

    End Function
    Public Function getEndDateResult()
        Dim d As Date = New Date(DateTimePickerFine.Value.Year, DateTimePickerFine.Value.Month, DateTimePickerFine.Value.Day, 23, 59, 59)
        Return d
    End Function


    Private Sub RadioButtonPrimaDataDisp_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Dim cb As RadioButton = sender
        If (cb.Checked) Then
            Dim d As New dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
            Dim obj As System.Nullable(Of Date) = d.ScalarQueryDataOraMinima()
            If obj.HasValue Then
                DateTimePickerInizio.Value() = obj
            End If
        End If
    End Sub

    Private Sub RadioButtonDataUltimaEsport_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Dim cb As RadioButton = sender
        If (cb.Checked) Then
            If (My.Settings.dataUltimaEsportazioneDati.ToString = "01/01/0001 00:00:00") Then
                'se la variabile (letta dal file delle impostazioni) è ancora vuota, allora vuol dire che deve essere impostata la prima data disponibile
                Dim d As New dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter
                DateTimePickerInizio.Value = d.ScalarQueryDataOraMinima()
            Else
                DateTimePickerInizio.Value = My.Settings.dataUltimaEsportazioneDati
            End If
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonUltimoMese.CheckedChanged
        Dim cb As RadioButton = sender
        If (cb.Checked) Then
            Dim a As Date
            a.Add(New TimeSpan(30, 0, 0, 0))
            Dim n As Date = Now()
            DateTimePickerInizio.Value = New Date(n.Year, n.Month, n.Day, 0, 0, 0) - New TimeSpan(30, 0, 0, 0)

        End If
    End Sub


End Class
