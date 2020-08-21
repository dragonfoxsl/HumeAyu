Imports Microsoft.VisualBasic


Partial Class Admin_AdminMain
    Inherits System.Web.UI.Page

    Protected Sub ImgbtnVal_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnVal.Click
        Response.Redirect("~/Admin/AdminDoctor.aspx")
    End Sub

    Protected Sub ImgbtnPlants_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnPlants.Click
        Response.Redirect("~/Admin/AdminDB.aspx")
    End Sub

    Protected Sub ImgbtnPay_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnPay.Click
        Response.Redirect("~/Admin/AdminDBPayment.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Admin") <> "Admin" Then
            Response.Redirect("~/Admin/Default.aspx")
        End If
    End Sub

    Protected Sub ImgbtnAdd_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnAdd.Click
        Response.Redirect("~/Admin/AddAdmin.aspx")
    End Sub
End Class
