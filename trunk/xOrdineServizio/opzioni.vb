Imports System.Windows.Forms

Public Class opzioni

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'salvataggio automatico
        If (CheckBoxSalvataggioAutomatico.Checked = False) Then
            My.Settings.intervalloSalvataggioAutomatico = -1
        Else
            My.Settings.intervalloSalvataggioAutomatico = tbIntervalloSalvataggioAutomatico.Text
        End If


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        'ripristino i valori, scartando le modifiche 
        My.Settings.GruppoFirmaRiga1 = gruppoFirmaRiga1_tmp
        My.Settings.GruppoFirmaRiga2 = gruppoFirmaRiga2_tmp
        My.Settings.GruppoFirmaInterinaleRiga1 = gruppoFirmaRigaInterinale1_tmp
        My.Settings.GruppoFirmaInterinaleRiga2 = gruppoFirmaRigaInterinale2_tmp
        My.MySettings.Default.ComandanteTitolare = comandanteTitolare_tmp
        Me.Close()
    End Sub
    Dim gruppoFirmaRiga1_tmp, gruppoFirmaRiga2_tmp, gruppoFirmaRigaInterinale2_tmp, gruppoFirmaRigaInterinale1_tmp, comandanteTitolare_tmp As String

    Private Sub opzioni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gruppoFirmaRiga1_tmp = My.Settings.GruppoFirmaRiga1
        gruppoFirmaRiga2_tmp = My.Settings.GruppoFirmaRiga2
        gruppoFirmaRigaInterinale1_tmp = My.Settings.GruppoFirmaInterinaleRiga1
        gruppoFirmaRigaInterinale2_tmp = My.Settings.GruppoFirmaInterinaleRiga2
        comandanteTitolare_tmp = My.MySettings.Default.ComandanteTitolare


        'Comandante titolare selezionato di default
        If (My.MySettings.Default.ComandanteTitolare = True) Then
            RadioButtonTitolare.Checked = True
            RadioButtonInterinale.Checked = False
        Else
            RadioButtonTitolare.Checked = False
            RadioButtonInterinale.Checked = True
        End If

        'salvataggio automatico
        If Integer.Parse(My.Settings.intervalloSalvataggioAutomatico) <= 0 Then
            tbIntervalloSalvataggioAutomatico.Enabled = False
        End If
        ' tbIntervalloSalvataggioAutomatico.Text = My.Settings.intervalloSalvataggioAutomatico

        'finestro a tutto schermo
        If (My.Settings.maximizeForm) Then
            CheckBoxMaximized.Enabled = True
        Else
            CheckBoxMaximized.Enabled = False
        End If

    End Sub

    Private Sub RadioButtonTitolare_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonTitolare.CheckedChanged
        If (RadioButtonTitolare.Checked) Then
            RadioButtonInterinale.Checked = False
            My.MySettings.Default.ComandanteTitolare = True
        End If
    End Sub

    Private Sub RadioButtonInterinale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonInterinale.CheckedChanged
        If (RadioButtonInterinale.Checked) Then
            RadioButtonTitolare.Checked = False
            My.MySettings.Default.ComandanteTitolare = False
        End If
    End Sub



    Private Sub CheckBoxSalvataggioAutomatico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxSalvataggioAutomatico.CheckedChanged
        Dim cb As CheckBox = sender
        If cb.Checked Then
            tbIntervalloSalvataggioAutomatico.Enabled = True
            'se nel file delle impostazioni c'è un valore errato allora pongo il valore a zero
            If (Integer.Parse(My.Settings.intervalloSalvataggioAutomatico) <= 0) Then
                My.Settings.intervalloSalvataggioAutomatico = 0
            End If
            tbIntervalloSalvataggioAutomatico.Text = My.Settings.intervalloSalvataggioAutomatico
        Else
            tbIntervalloSalvataggioAutomatico.Enabled = False
        End If
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
