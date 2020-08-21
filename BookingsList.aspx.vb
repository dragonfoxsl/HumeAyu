Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class BookingsList
    Inherits System.Web.UI.Page
    Private DoctorObj As DoctorBLL()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Validity") = "True" Then
            Me.loadGrid()
        Else
            lblMessage.Text = "You are un-authorized to use this function Please Login or Register to make a Booking..."
        End If
    End Sub

    Protected Sub gdviewDoctor_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gdviewDoctor.PageIndexChanging
        gdviewDoctor.PageIndex = e.NewPageIndex
    End Sub

    Protected Sub gdviewDoctor_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gdviewDoctor.RowCommand
        If e.CommandName = "select" Then
            Response.Redirect("Bookings.aspx?DID=" & Integer.Parse(e.CommandArgument.ToString()))
        ElseIf e.CommandName = "video" Then
            Response.Redirect("VideoBookings.aspx?DID=" & Integer.Parse(e.CommandArgument.ToString()))
        End If
    End Sub

    Protected Sub loadGrid()
        Dim DoctorArrayList As New ArrayList()
        For Each eBLL As DoctorBLL In New DoctorBLL().getAllDoctors()
            DoctorArrayList.Add(New DoctorListBLL(eBLL))
        Next
        gdviewDoctor.DataSource = DoctorArrayList
        gdviewDoctor.DataBind()
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        lblMessage.Text = ""
    End Sub
End Class
