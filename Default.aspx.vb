
Partial Class _Default
    Inherits System.Web.UI.Page
    Public Shared Sub Effect()

    End Sub

    Protected Sub ImgbtnEnter_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnEnter.Click
        Response.Redirect("Home.aspx")
    End Sub
End Class
