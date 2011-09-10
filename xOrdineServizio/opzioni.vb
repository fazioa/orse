Imports System.Windows.Forms

Public Class opzioni

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If (RadioButton_layoutRiepilogoInserimentiS.Checked) Then
            FPrima.TableLayoutPanelRiepilogoInserimenti.Visible = True
            FPrima.ButtonVedi.Visible = False
        Else
            FPrima.TableLayoutPanelRiepilogoInserimenti.Visible = False
            FPrima.ButtonVedi.Visible = True

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

        'Layout
        If (My.MySettings.Default.display_reportPrimaPagina = True) Then
            RadioButton_layoutRiepilogoInserimentiS.Checked = True
            RadioButton_layoutRiepilogoInserimentiN.Checked = False
        Else
            RadioButton_layoutRiepilogoInserimentiS.Checked = False
            RadioButton_layoutRiepilogoInserimentiN.Checked = True
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



    Private Sub RadioButton_layoutRiepilogoInserimentiN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton_layoutRiepilogoInserimentiN.CheckedChanged
        If (RadioButton_layoutRiepilogoInserimentiS.Checked) Then
            My.MySettings.Default.display_reportPrimaPagina = True
        Else
            My.MySettings.Default.display_reportPrimaPagina = False

        End If
    End Sub
End Class