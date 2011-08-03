Public Class FProgressionBar

    Private Sub FProgressionBar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Step = 1
    End Sub

    Public Sub PerformStep()
        ProgressBar1.PerformStep()
    End Sub

    Public Sub Maximum(ByVal v As Integer)
        ProgressBar1.Maximum = v
    End Sub

    Public Sub Minimum(ByVal v As Integer)
        ProgressBar1.Minimum = v
    End Sub
End Class