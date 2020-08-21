Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class ViewSchedule
    Inherits System.Web.UI.Page
    Private objBooking As New BookingBLL()

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        txtVideoCDate.Text = Calendar1.SelectedDate.ToShortDateString()
        loadGrid()
    End Sub
    Private Sub loadGrid()
        objBooking.setDate(txtVideoCDate.Text, "0")
        objBooking.setPID(txtVideoCDate.Text, Session("UID").ToString())
        Dim ScheduleArrayList As New ArrayList()
        For Each eBLL As BookingBLL In New BookingBLL().getAllVideoBookingPatients()
            ScheduleArrayList.Add(New BookingListBLL(eBLL))
        Next
        gdviewATimes.DataSource = ScheduleArrayList
        gdviewATimes.DataBind()
        If ScheduleArrayList.Count > 0 Then
            lblATime.Visible = True
        End If
    End Sub
End Class
