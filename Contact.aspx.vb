Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class Contact
    Inherits System.Web.UI.Page
    Private objContact As New ContactBLL()
    Private objContactMail As New ContactMail()

    Private Sub ClearAll()
        Me.txtCUser.Text = ""
        Me.txtCUEmail.Text = ""
        Me.txtComments.Text = ""
        Me.lblMsg.Text = ""
        Me.txtCUser.Focus()
    End Sub

    Protected Sub ImgbtnSend_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnSend.Click
        objContact.Name = txtCUser.Text
        objContact.Email = txtCUEmail.Text
        objContact.Comment = txtComments.Text
        If txtCUser.Text = "" Or txtCUEmail.Text = "" Or txtComments.Text = "" Then
            ClearAll()
            lblMsg.Text = "Please Fill all the fields"
            lblMsg.ForeColor = System.Drawing.Color.Red
        Else
            If objContact.Contact() Then
                objContactMail.SendMessage(txtCUser.Text, txtCUEmail.Text, txtComments.Text)
                Me.ClearAll()
                lblMsg.Text = "Thank You.. Your Comment has been sent.."
                lblMsg.ForeColor = System.Drawing.Color.DarkGreen
            Else
                ClearAll()
                lblMsg.Text = "Error occured. No action performed"
                lblMsg.ForeColor = System.Drawing.Color.Red
            End If
        End If
    End Sub

    Protected Sub ImgbtnClear_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnClear.Click
        ClearAll()
    End Sub
End Class
