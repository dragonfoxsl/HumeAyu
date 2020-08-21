Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class Doctors
    Inherits System.Web.UI.Page
    Private DoctorsObj As New DoctorBLL()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.loadData()
            If Request.QueryString("DID") IsNot Nothing Then
                If (Request.QueryString("DID").Length) <> 0 Then
                    Me.loadData(Integer.Parse(Request.QueryString("DID")))
                End If
            End If
        End If
    End Sub

    Private Sub loadData()
        Me.ImgbtnVideo.Visible = False
        Me.ImgbtnChannel.Visible = False
    End Sub

    Private Sub loadData(ByVal DID As Integer)
        DoctorsObj.getDoctor(DID)
        lblDID.Text = DoctorsObj.DID.ToString()
        ImgDocImage.ImageUrl = DoctorsObj.DImage.ToString()
        txtDocNme.Text = DoctorsObj.DName.ToString()
        txtQuali.Text = DoctorsObj.DQualifications.ToString()
        txtDocExp.Text = DoctorsObj.DExperience.ToString()
        txtDocSpe.Text = DoctorsObj.DSpecility.ToString()
        txtDocEmail.Text = DoctorsObj.DEmail.ToString()
        txtDocAdd.Text = DoctorsObj.DAddress.ToString()
        txtContactNo.Text = DoctorsObj.DContact.ToString()
    End Sub

    Protected Sub ImgbtnBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnBack.Click
        Response.Redirect("~/DoctorList.aspx")
    End Sub

End Class
