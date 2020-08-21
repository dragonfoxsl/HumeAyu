Partial Class MasterPage
    Inherits System.Web.UI.MasterPage
    Private objDocUser As New DoctorBLL()
    Private ImgUrl As String
    Protected Sub ImgbtnReg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnReg.Click
        Response.Redirect("Registration.aspx")
    End Sub

    Protected Sub ImgbtnLogin_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnLogin.Click
        Response.Redirect("Login.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Validity") = "True" Then
            Me.ImgbtnReg.Visible = False
            Me.ImgbtnLogin.Visible = False
            Me.ImgbtnLogout.Visible = True
            Me.lblWelcome.Text = "Welcome " + Session("User").ToString() + " !"
            If Session("UserType") = "Doctor" Then
                objDocUser.getDoctor(Session("UID").ToString())
                ImgUrl = objDocUser.DImage.ToString()
                Me.ImgDocReg.ImageUrl = ImgUrl
                Me.ImgDocReg.Visible = True
            End If
        Else
            Me.ImgbtnReg.Visible = True
            Me.ImgbtnLogin.Visible = True
            Me.ImgbtnLogout.Visible = False
            Me.ImgDocReg.Visible = False
        End If
    End Sub

    Protected Sub ImgbtnLogout_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnLogout.Click
        Session.RemoveAll()
        Response.Redirect("~/Home.aspx")
    End Sub
End Class

