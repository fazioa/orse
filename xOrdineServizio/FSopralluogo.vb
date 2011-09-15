Public Class FSopralluogo
    Dim log As New XOrseLog

    Private Sub btnSalvaChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvaChiudi.Click
        Dim drv As DataRowView = SopralluogoBindingSource.Current()

        If (RadioButtonTipoFurtoAbitazione.Checked) Then
            drv.Item("tipoReato") = "Furto in abitazione"
        Else
            drv.Item("tipoReato") = TextBoxTipoAltro.Text
        End If


        drv.Item("oraRedazione") = DateTimePicker1.Value
        drv.Item("oraRichiesta") = DateTimePicker2.Value
        Me.Validate()
        Me.SopralluogoBindingSource.EndEdit()
        Me.SopralluogoTableAdapter.Update(Me.DbAlegatoADataSet.sopralluogo)
        Me.Close()
    End Sub

   

    Private Sub FSopralluogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbAlegatoADataSet.sopralluogo' table. You can move, or remove it, as needed.
        If (idSopralluogo >= 0) Then
            log.xlogWriteEntry("Apertura form sopralluogo per modifica", TraceEventType.Information)
            Me.SopralluogoTableAdapter.FillById(Me.DbAlegatoADataSet.sopralluogo, idSopralluogo)
        End If

    End Sub

    Private idSopralluogo As Integer = -1

    Public Sub New(ByVal idOS As Integer, ByVal idS As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'inizializzo datetimepicker, perchè altrimenti danno DBNull


        'se l'id è maggiore di zero allora sto modificando, altrimenti inserisco un nuovo elemento
        If (idS >= 0) Then
            idSopralluogo = idS
        Else
            Me.SopralluogoBindingSource.AddNew()
            log.xlogWriteEntry("Apertura form sopralluogo - nuovo sopralluogo", TraceEventType.Information)
            Dim drv As DataRowView = SopralluogoBindingSource.Current()
            drv.Item("idOS") = idOS
        End If

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    
End Class