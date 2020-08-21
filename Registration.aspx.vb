
Partial Class Registration
    Inherits System.Web.UI.Page

    Protected Sub ImgbtnDoc_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnDoc.Click
        Response.Redirect("~/DoctorReg.aspx")
    End Sub

    Protected Sub ImgbtnPa_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnPa.Click
        Response.Redirect("~/UserRegister.aspx")
    End Sub
End Class
