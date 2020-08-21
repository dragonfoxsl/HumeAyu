Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.IO

Partial Class Admin_AdminDBPayment
    Inherits System.Web.UI.Page
    Private objBooking As New BookingBLL
    Private objVBooking As New VideoBookingBLL

    Protected Sub ImgbtnBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnBack.Click
        Response.Redirect("~/Admin/AdminMain.aspx")
    End Sub

    Protected Sub gdviewTime_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gdviewTime.PageIndexChanging
        gdviewTime.PageIndex = e.NewPageIndex
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadGrid()
        loadGridView()
    End Sub

    Protected Sub gdviewTime_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gdviewTime.RowCommand
        If e.CommandName = "select" Then
            objBooking.BIDT = Integer.Parse(e.CommandArgument.ToString())
            objBooking.Confirm = "Yes"
            objBooking.UpdateConf()
            loadGrid()
        ElseIf e.CommandName = "select2" Then
            objVBooking.VBID = Integer.Parse(e.CommandArgument.ToString())
            objVBooking.ConfP = "Yes"
            objVBooking.UpdateConfCus()
            loadGridView()
        End If
    End Sub

    Protected Sub loadGrid()
        Dim PlantArrayList As New ArrayList()
        For Each eBLL As BookingBLL In New BookingBLL().getAllVideoBookingAdmin()
            PlantArrayList.Add(New BookingListBLL(eBLL))
        Next
        gdviewTime.DataSource = PlantArrayList
        gdviewTime.DataBind()
    End Sub

    Private Sub loadGridView()
        Dim ScheduleArrayList As New ArrayList()
        For Each eBLL As VideoBookingBLL In New VideoBookingBLL().GetPatientSchedule()
            ScheduleArrayList.Add(New VideoBookingListBLL(eBLL))
        Next
        gdviewTime0.DataSource = ScheduleArrayList
        gdviewTime0.DataBind()
    End Sub
End Class
