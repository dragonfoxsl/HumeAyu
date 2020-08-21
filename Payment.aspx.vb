Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class Payment
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Request.QueryString("PType") IsNot Nothing Then
                If (Request.QueryString("PType").Length) <> 0 Then
                    Me.SelectPayment(Request.QueryString("PType").ToString())
                End If
            End If
        End If
    End Sub

    Private Sub SelectPayment(ByVal Payment As String)
        If Payment = "Cash" Then
            PanelCash.Visible = True
            PanelCheaque.Visible = False
            PanelByPhone.Visible = False
            PanelCreditCard.Visible = False
        ElseIf Payment = "Cheaque" Then
            PanelCash.Visible = False
            PanelCheaque.Visible = True
            PanelByPhone.Visible = False
            PanelCreditCard.Visible = False
        ElseIf Payment = "By_Phone" Then
            PanelCash.Visible = False
            PanelCheaque.Visible = False
            PanelByPhone.Visible = True
            PanelCreditCard.Visible = False
        ElseIf Payment = "Credit_Card" Then
            PanelCash.Visible = False
            PanelCheaque.Visible = False
            PanelByPhone.Visible = False
            PanelCreditCard.Visible = True
        End If
    End Sub

    Protected Sub ImgbtnBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnBack.Click
        Response.Redirect("~/Home.aspx")
    End Sub
End Class
