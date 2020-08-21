Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class VideoBookings
    Inherits System.Web.UI.Page
    Private DoctorsObj As New DoctorBLL()
    Private objVBooking As New VideoBookingBLL()

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        txtVideoCDate.Text = Calendar1.SelectedDate.ToShortDateString()
    End Sub

    Protected Sub ImgbtnSelect_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnSelect.Click
        objVBooking.DID = CInt(lblDID.Text)
        objVBooking.PID = Session("UID").ToString()
        objVBooking.PDate = txtVideoCDate.Text
        objVBooking.PTime = dpdwnTime.SelectedValue.ToString()
        objVBooking.PayT = dpdwnPay.SelectedValue.ToString()
        objVBooking.AddVideoBooking()
        Response.Redirect("~/Payment.aspx?PType=" & Me.dpdwnPay.Text)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Request.QueryString("DID") IsNot Nothing Then
                If (Request.QueryString("DID").Length) <> 0 Then
                    Me.loadData(Integer.Parse(Request.QueryString("DID")))
                End If
            End If
        End If
    End Sub

    Private Sub loadData(ByVal DID As Integer)
        DoctorsObj.getDoctor(DID)
        lblDID.Text = DoctorsObj.DID.ToString()
        lblDNme.Text = DoctorsObj.DName.ToString()
    End Sub
End Class
