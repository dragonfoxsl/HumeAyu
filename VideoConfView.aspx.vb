Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class VideoConfView
    Inherits System.Web.UI.Page
    Private objVBooking As New VideoBookingBLL()

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        txtVideoCDate.Text = Calendar1.SelectedDate.ToShortDateString()
        loadGrid()
    End Sub

    Private Sub loadGrid()
        objVBooking.setPID(txtVideoCDate.Text, Session("UID").ToString())
        Dim ScheduleArrayList As New ArrayList()
        For Each eBLL As VideoBookingBLL In New VideoBookingBLL().GetPatientSchedule()
            ScheduleArrayList.Add(New VideoBookingListBLL(eBLL))
        Next
        gdviewDoctor.DataSource = ScheduleArrayList
        gdviewDoctor.DataBind()
        If ScheduleArrayList.Count > 0 Then
            lblATime.Visible = True
        End If
    End Sub


    Protected Sub gdviewDoctor_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gdviewDoctor.PageIndexChanging
        gdviewDoctor.PageIndex = e.NewPageIndex
    End Sub

    Protected Sub gdviewDoctor_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gdviewDoctor.RowCommand
        If e.CommandName = "select" Then
            loadGrid()
        End If
    End Sub
End Class
