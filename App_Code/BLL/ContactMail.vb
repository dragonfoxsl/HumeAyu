Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Net.Mail

Public Class ContactMail

    Public Sub SendMessage(ByVal User As String, ByVal SenderMail As String, ByVal Comments As String)
        Dim Message As New MailMessage

        Dim StmpClient As New SmtpClient
        StmpClient.Credentials = New System.Net.NetworkCredential("humeayu@gmail.com", "keshara5000")
        StmpClient.Port = 587
        StmpClient.Host = "stmp.gmail.com"
        StmpClient.EnableSsl = True

        Try
            Message.From = New MailAddress("humeayu@gmail.com", "HumeAyu", System.Text.Encoding.UTF8)
            Message.To.Add(SenderMail.ToString())
            Message.Subject = "Thank You"
            Message.Body = "Thank You for Your Valuble Comments"

            Message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            Message.ReplyTo = New MailAddress("humeayu@gmail.com")
            StmpClient.Send(Message)
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly, "HumeAyu Administration")
        End Try
    End Sub

End Class
