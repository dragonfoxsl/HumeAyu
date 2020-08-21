Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class Video
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Validity") <> "True" Then
            MsgBox("You are Unauthorized to view this page, Please making a Conferance Request!", MsgBoxStyle.Information, "HumeAyu Administration")
            Response.Redirect("~/Home.aspx")
        End If
    End Sub
End Class
