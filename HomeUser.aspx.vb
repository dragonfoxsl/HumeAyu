
Partial Class HomeUser
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("UserType") <> "Patient" Then
            Response.Redirect("Home.aspx")
        End If
    End Sub

    Protected Sub ImgbtnVConf_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnVConf.Click
        Response.Redirect("~/Video.aspx")
    End Sub

    Protected Sub ImgbtnEdit_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnEdit.Click
        Response.Redirect("~/UserRegister.aspx?PID=" & Session("UID").ToString())
    End Sub

    Protected Sub ImgbtnVidConfSchedule_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnVidConfSchedule.Click
        Response.Redirect("~/VideoConfView.aspx")
    End Sub

    Protected Sub ImgbtnSchedule_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnSchedule.Click
        Response.Redirect("~/ViewSchedule.aspx")
    End Sub
End Class
