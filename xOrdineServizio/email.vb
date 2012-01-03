Public Class email
    Dim log As New XOrseLog
    Private result As Boolean = False
    Private nomeUtente As String = "xorsedebug"
    Private pwd As String = "xorsedebug00"

    Public Sub New()

    End Sub


    Public Function inviaEmail(ByVal screenshootPath As String, ByVal sBody As String) As Boolean
        'imposto l'smtp
        Dim x As New System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
        Try
            With x
                .EnableSsl = True
                .Credentials = New Net.NetworkCredential("xorsedebug@gmail.com", "xorsedebug00")
            End With

            'INVIO SEGNALAZIONE
            Dim emailmittente As String = "xorsedebug@gmail.com"
            Dim emaildestinatario As String = "xorsedebug@gmail.com"
            'IMPOSTAZIONE INDIRIZZI MITTENTE E DESTINATARIO
            Dim mittente As Net.Mail.MailAddress = New Net.Mail.MailAddress(emailmittente, "Orse " & My.Application.Info.Version.ToString)
            Dim destinatario As Net.Mail.MailAddress = New Net.Mail.MailAddress(emaildestinatario, "Orse")

            Dim m As New Net.Mail.MailMessage(mittente, destinatario)
            'IMPOSTO IL CORPO DELL'EMAIL
            m.Body = "Segnalazione eccezione non gestita" & vbCrLf & vbCrLf & sBody

            m.Subject = "Orse " & My.Application.Info.Version.ToString

            If Not screenshootPath = "" Then
                'INSERISCO GLI ALLEGATI
                m.Attachments.Add(New Net.Mail.Attachment(screenshootPath))
            End If
 
            x.Send(m)

        Catch ex As Exception
            MsgBox("Errore invio segnalazione. " & ex.Message, MsgBoxStyle.Exclamation, "Segnalazione errore")
        End Try

    End Function

End Class
