Imports System.Windows.Forms

Public Class DEccezione
    Dim excp As Exception
    Dim feActions As New OrSe.ActionsLibrary
    'filePath memorizza il nome del file temporaneo (screenshot). Viene tentata la cancellazione periodicamente
    Dim sScreenshotPath As String = ""

    Private Sub Continue_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Continue_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Esci_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Esci_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal ex As Exception)
        excp = ex
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        TextBoxEccezioneMessage.Text = ex.Message
        TextBoxEccezioneStack.Text = ex.StackTrace
    End Sub

    Private Sub DEccezione_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Public Sub test(ByVal sTestoEccezione As String)
        'controllo che sia presente la rete
        Dim isAvailable As Boolean = My.Computer.Network.IsAvailable
        'esegue ScreenShot

        'costruisce testo email
        Dim sBody As String = "Message: " & vbCrLf & excp.Message & vbCrLf & " StackTrace: " & vbCrLf & excp.StackTrace
        Dim listaSegnalazioniEmail As New emailStore

        'inserisco i dati recuperati in una lista che viene serializzata, poi se la rete è disponibile allora tento l'invio

        'catturo lo screenshot solo se l'utente non nega il consenso
        Dim img As Image = Nothing
        If My.Settings.segnalazioneErroreConScreenshot Then
            img = getScreenshotImage()
        End If
        listaSegnalazioniEmail.push(sBody, img)


        'anche se l'invio non viene eseguito perchè manca la connessione, le segnalazioni verranno inviate periodicamente dalla pagina principale, attraverso il timer, solo se la connessione è disponibile
        If (ActionsLibrary.ConnessioneInternet) Then
            Dim imapMail As New email
            'estrae segnalazione dalla lista
            Dim obj As emailObj = listaSegnalazioniEmail.pop
            'invia email
            imapMail.inviaEmail(obj.screenShot, obj.testoEmail)
        End If
    End Sub

    'restituisce il path del file
    Private Function esegueScreenShot() As String
        Dim imgCodecs() As Imaging.ImageCodecInfo = Imaging.ImageCodecInfo.GetImageEncoders()
        Dim params As Imaging.EncoderParameters = New Imaging.EncoderParameters(1)
        Dim quality As Imaging.EncoderParameter = New Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 35)
        'Set quality to 50
        params.Param(0) = quality
        Try
            System.IO.Directory.CreateDirectory(My.Settings.pathCartellaScrivibile & My.Settings.sTempDirName) ' inserire \ nella sTempDirName
        Catch ex As Exception

        End Try

        Dim sFilePath As String = My.Settings.pathCartellaScrivibile & My.Settings.sTempDirName & "/screenshot.jpg"
        ScreenShot.Save(sFilePath, imgCodecs(1), params)
        Return sFilePath
    End Function



    Function getScreenshotImage() As Image
        SendKeys.SendWait("^{PRTSC}")
        Dim Obj As IDataObject = Clipboard.GetDataObject
        If (Obj.GetDataPresent(DataFormats.Bitmap)) Then
            Dim Img As Bitmap = New Bitmap(CType((Obj.GetData("System.Drawing.Bitmap")), Bitmap))
            Return Img
        End If
        Return Nothing
    End Function


    Public Shared Function ScreenShot() As Bitmap
        SendKeys.SendWait("^{PRTSC}")
        Dim Obj As IDataObject = Clipboard.GetDataObject
        If (Obj.GetDataPresent(DataFormats.Bitmap)) Then
            Dim Img As Bitmap = New Bitmap(CType((Obj.GetData("System.Drawing.Bitmap")), Bitmap))
            Return Img
        End If
        Return Nothing
    End Function


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        feActions.invioPeriodicoSegnalazioni()
    End Sub
End Class
