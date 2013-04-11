Public Class FContatti

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If (ActionsLibrary.ConnessioneInternet()) Then
            abilitaCampi(True)
        Else
            abilitaCampi(False)
        End If

    End Sub

    Sub abilitaCampi(bEnabled As Boolean)
        
        If (bEnabled) Then
            btnInvia.Text = "Invia"
            btnInvia.Enabled = True

        Else
            btnInvia.Text = "Invio possib.solo con conness.internet attiva"
            btnInvia.Enabled = False

        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Timer1.Start()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnInvia_Click(sender As System.Object, e As System.EventArgs) Handles btnInvia.Click
        Dim cats() As String = {"Messaggi Utenti"}
        Dim sTitoloConComando As String = My.Settings.comando & " " & My.Settings.comandoSecondaRiga & " - " & TextBoxNome.Text.Trim
        Dim result As Integer = ActionsLibrary.newBlogPostSend(sTitoloConComando, TextBoxMessaggio.Text.Trim, cats)
        If result > 0 Then
            MessageBox.Show("Inviato", "", MessageBoxButtons.OK, MessageBoxIcon.None)
            TextBoxNome.Text = ""
            TextBoxMessaggio.Text = ""
        End If
    End Sub
End Class