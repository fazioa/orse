Imports System.IO
Public Class userControlImmagini
    Public Property sFilePath As String
    Private _imageTmb As Image


    Sub New(_sFilePath As String, width As Integer, bCopiaFile As Boolean)
        'bCopiaFile As Boolean
        'true -->  copia il file nella cartella temporanea delle foto 
        'false --> carica l'immagine in memoria senza salvarla nella cartella temporanea delle foto 

        InitializeComponent()
        Dim image As Image = Bitmap.FromFile(_sFilePath)
        Dim widthImage As Integer = image.Width()
        Dim heightImage As Integer = image.Height()


        Dim ratio As Single = 0

        ratio = CSng(widthImage) / CSng(heightImage)
        widthImage = width
        heightImage = Convert.ToInt32(Math.Round(CSng(widthImage) / ratio))


        _imageTmb = image.GetThumbnailImage(widthImage, heightImage, Nothing, IntPtr.Zero)
        Me.Height = heightImage
        Me.Width = widthImage


        If bCopiaFile Then
            sFilePath = _sFilePath
            salvaFile(_sFilePath)
        End If


        PictureBox1.Image = _imageTmb

    End Sub



    Private Sub salvaFile(_sFilePath As String)
        sFilePath = My.Settings.pathCartellaScrivibile & My.Settings.pathTempFotografie & "\" & Path.GetFileName(_sFilePath)
        My.Computer.FileSystem.CopyFile(_sFilePath, sFilePath, True)

        '  Solo il path delle fotografie deve essere memorizzato
        '   Al momento del salvataggio il link deve essere memorizzato sul DB ed i file salvati

        '        Label cartella deve essere il numero IDPersona
        '   InitializeComponent File interni = timestamps + cognome + nome


    End Sub

    Private Sub clickFoto(sLink As String)
        Process.Start(sLink)
    End Sub

    Private Sub PictureBox1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDoubleClick
        clickFoto(sFilePath)
    End Sub
End Class
