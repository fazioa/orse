Imports System.IO
Imports System.Drawing.Imaging
Imports System.Text
Imports System.Net.Mime.MediaTypeNames.Image



Public Class userControlImmagini
    Public Property sFilePath As String
    Private _imageTmb As Image

    Sub New(_sFilePath As String, sCognomeNomeData As String, width As Integer)
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

        sFilePath = _sFilePath
        salvaFile(_sFilePath, sCognomeNomeData)
        PictureBox1.Image = _imageTmb

    End Sub



    Private Sub salvaFile(_sFilePath As String, _sCognomeNomeData As String)
        _sCognomeNomeData = _sCognomeNomeData.Replace(" ", "_")
        sFilePath = My.Settings.pathCartellaScrivibile & My.Settings.pathCartellaFotografie & "\" & _sCognomeNomeData & "\" & Path.GetFileName(_sFilePath)
        My.Computer.FileSystem.CopyFile(_sFilePath, sFilePath, True)

        Solo il path delle fotografie deve essere memorizzato
        Al momento del salvataggio il link deve essere memorizzato sul DB ed i file salvati

        Label cartella deve essere il numero IDPersona
        InitializeComponent file interni = timestamps + cognome + nome


    End Sub

    Private Sub clickFoto(sLink As String)
        Process.Start(sLink)
    End Sub

    Private Sub PictureBox1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDoubleClick
        clickFoto(sFilePath)
    End Sub
End Class
