Imports System.Windows.Forms

Public Class DEccezione
    Dim excp As Exception
    Dim feActions As New OrSe.ActionsLibrary
    'filePath memorizza il nome del file temporaneo (screenshot). Viene tentata la cancellazione periodicamente
    Dim sScreenshotPath As String = ""

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
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
        If (isAvailable) Then

            Dim smtpMail As New email
            'esegue ScreenShot ed invia email

            Try
                sScreenshotPath = esegueScreenShot()
            Catch ex As Exception

            End Try
            Dim sBody As String = "Message: " & vbCrLf & excp.Message & vbCrLf & " StackTrace: " & vbCrLf & excp.StackTrace
            smtpMail.inviaEmail(sScreenshotPath, sBody)
            'dopo l'invio dell'email ebailita il pulsante di chiusura della finestra

            Cancel_Button.Enabled = True
            'la cancellazione del file viene tentata in modo asincrono, con evento sul timer
            ' feActions.cancellaFile(sScreenshotPath)

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
            System.IO.Directory.CreateDirectory(My.Settings.sTempPath)
        Catch ex As Exception

        End Try

        Dim sFilePath As String = My.Settings.sTempPath & "/screenshot.jpg"
        ScreenShot.Save(sFilePath, imgCodecs(1), params)
        Return sFilePath
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

End Class
