Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("UserType") = "Doctor" Then
            Response.Redirect("~/HomeDoctor.aspx")
        ElseIf Session("UserType") = "Patient" Then
            Response.Redirect("~/HomeUser.aspx")
        End If
    End Sub
End Class
