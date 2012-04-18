Public Class FRevisioneTabelleDati
    Dim feActions As New ActionsLibrary
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        feActions.setStandardFormSize(Me)
        feActions.datagridviewSetup(LuoghicontrolloDataGridView)
        feActions.datagridviewSetup(ModelliMezzoDataGridView)
    End Sub

    Private Sub LuoghicontrolloBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LuoghicontrolloBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LuoghicontrolloBindingSource.EndEdit()
        Me.LuoghicontrolloTableAdapter.Update(Me.DbAlegatoADataSet.luoghicontrollo)

    End Sub

    Private Sub FRevisioneTabelleDati_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updateDataGridView()

    End Sub

    Private Sub updateDataGridView()
        Me.ModelliMezzoTableAdapter.Fill(Me.DbAlegatoADataSet.modelliMezzo)
        Me.LuoghicontrolloTableAdapter.Fill(Me.DbAlegatoADataSet.luoghicontrollo)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'query per cancellare voci non utilizzate


        'aggiorna vista
        updateDataGridView()
    End Sub
End Class