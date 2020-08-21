Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Net.Mail
Partial Class FinalReg
    Inherits System.Web.UI.Page
    Dim UNme, Pass, Email As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UNme = Request.QueryString("UN")
        Pass = Request.QueryString("PW")
        Email = Request.QueryString("Email")
        lblUN.Text = UNme.ToString()
        lblPW.Text = Pass.ToString()
        SendMessage(Email, UNme, Pass)
    End Sub

    Public Sub SendMessage(ByVal ToMail As String, ByVal UN As String, ByVal PW As String)
        Dim mail As New MailMessage()

        Dim SmtpServer As New SmtpClient()
        SmtpServer.Credentials = New Net.NetworkCredential("humeayu@gmail.com", "keshara5000")
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp.gmail.com"
        SmtpServer.EnableSsl = True

        mail = New MailMessage()
        Try
            mail.From = New MailAddress("humeayu@gmail.com", "HumeAyu", System.Text.Encoding.UTF8)

            mail.To.Add(ToMail)
            mail.Subject = "User Registration"
            mail.Body = "Your Account Has Been Successfully Created.. User Name : " + UN + " Password :" + PW
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            mail.ReplyTo = New MailAddress("humeayu@gmail.com")
            SmtpServer.Send(mail)
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly, "HumeAyu Administration")
        End Try
    End Sub
End Class
