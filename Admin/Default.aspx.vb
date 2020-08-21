Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class Admin_Default
    Inherits System.Web.UI.Page
    Private LoginAdminObj As New AdminBLL()

    Protected Sub ImgbtnLogin_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnLogin.Click
        Dim UNme As String = Me.txtUN.Text
        Dim Pass As String = Me.txtPW.Text
        LoginAdminObj.getAdminLogin(UNme, Pass)
        If LoginAdminObj.Message Is Nothing Then
            Session("Admin") = "Admin"
            Response.Redirect("~/Admin/AdminMain.aspx")
        Else
            ClearLogin()
            lblMsg.Text = "Invalid Data, Please Re-enter the Details"
            lblMsg.ForeColor = Drawing.Color.Red
        End If
    End Sub

    Protected Sub ImgbtnClear_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnClear.Click
        ClearLogin()
    End Sub

    Private Sub ClearLogin()
        txtUN.Text = ""
        txtPW.Text = ""
        txtUN.Focus()
    End Sub
End Class
