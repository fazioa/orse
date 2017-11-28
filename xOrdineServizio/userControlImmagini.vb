Imports System.IO
Imports System.Drawing.Imaging
Imports System.Text
Imports System.Net.Mime.MediaTypeNames.Image



Public Class userControlImmagini
    Public Property sFilePath As String
    Private _imageTmb As Image

    Sub New(image As Image, _sFilePath As String, sCognomeNomeData As String, width As Integer)
        InitializeComponent()
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

    INSERIRE CANCELLAZIONE FOTO E MEMORIZZAZIONE SU DATABASE

    Private Sub salvaFile(_sFilePath As String, _sCognomeNomeData As String)
        _sCognomeNomeData = _sCognomeNomeData.Replace(" ", "_")
        My.Computer.FileSystem.CopyFile(_sFilePath, My.Settings.pathCartellaScrivibile & My.Settings.pathCartellaFotografie & "\" & _sCognomeNomeData & "\" & Path.GetFileName(_sFilePath))
        sFilePath = _sFilePath
    End Sub

    Private Sub clickFoto(sLink As String)
        Process.Start(sLink)
    End Sub

    Private Sub PictureBox1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDoubleClick
        clickFoto(sFilePath)
    End Sub
End Class
