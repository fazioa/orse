Imports System.Windows.Forms


Public Class FDownloadLink
    Dim sNuovaVersione, sVersioneInstallata


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub downloadLink_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sNomeApp As String = My.Application.Info.AssemblyName.ToString
        Label1.Text = "E' disponibile una nuova versione di " & sNomeApp & vbCrLf
        Label1.Text += "La nuova versione " & sNuovaVersione & " sostituirà la versione " & sVersioneInstallata & " attualmente installata"
        Label1.Text += vbCrLf & "Puoi scaricare la nuova versione dal seguente link diretto:"
        LinkLabelDonwload.Text = My.Settings.linkDownloadNuovaVersione

    End Sub

    Private Sub LinkLabelDonwload_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelDonwload.LinkClicked
        Try
            Process.Start(LinkLabelDonwload.Text)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub New(ByVal sA, ByVal sR)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        sNuovaVersione = sR
        sVersioneInstallata = sA
    End Sub

 
End Class
