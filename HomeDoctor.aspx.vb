
Partial Class HomeDoctor
    Inherits System.Web.UI.Page


    Protected Sub ImgbtnVidCon_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnVidCon.Click
        Response.Redirect("~/Video.aspx")
    End Sub

    Protected Sub ImgbtnEditDoc_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnEditDoc.Click
        Response.Redirect("~/DoctorReg.aspx?DID=" & Session("UID").ToString())
    End Sub

    Protected Sub ImgbtnShedule_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnShedule.Click
        Response.Redirect("~/TimeSchedule.aspx")
    End Sub

    Protected Sub ImgbtnVidS_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnVidS.Click
        Response.Redirect("~/TimeScheduleVideo.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("UserType") <> "Doctor" Then
            Response.Redirect("~/Home.aspx")
        End If
    End Sub
End Class
