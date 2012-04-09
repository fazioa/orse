Public Class email
    Dim log As New XOrseLog
    Private result As Boolean = False
    Private nomeUtente As String = "xorsedebug"
    Private pwd As String = "xorsedebug00"

    Public Sub New()

    End Sub


    Public Function inviaEmail(ByVal screenshootImage As Image, ByVal sBody As String) As Boolean
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

            If Not screenshootImage Is Nothing Then
                'INSERISCO GLI ALLEGATI - Salva su file l'immagine in memoria
                m.Attachments.Add(New Net.Mail.Attachment(ActionsLibrary.salvaImageToJPG(screenshootImage)))

            End If

            'INVIO
            'wire up the event for when the Async send is completed
            AddHandler x.SendCompleted, AddressOf SmtpClient_OnCompleted

            Dim userState As Object = m
            x.SendAsync(m, userState)
        Catch ex As Exception
            MsgBox("Errore invio segnalazione. " & ex.Message, MsgBoxStyle.Exclamation, "Segnalazione errore")
        End Try
    End Function
    Public Sub SmtpClient_OnCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        'Get the Original MailMessage object
        Dim mail As Net.Mail.MailMessage = CType(e.UserState, Net.Mail.MailMessage)

        'write out the subject
        Dim subject As String = mail.Subject

        If e.Cancelled Then
            Console.WriteLine("Send canceled for mail with subject [{0}].", subject)
        End If
        If Not (e.Error Is Nothing) Then
            Console.WriteLine("Error {1} occurred when sending mail [{0}] ", subject, e.Error.ToString())
        Else
            Console.WriteLine("Message [{0}] sent.", subject)
        End If
    End Sub 'SmtpClient_OnCompleted


   
End Class
