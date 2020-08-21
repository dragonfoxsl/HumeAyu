Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class Bookings
    Inherits System.Web.UI.Page
    Private DoctorsObj As New DoctorBLL()
    Private objTimeSchedule As New TimeScheduleBLL()
    Private objBookings As New BookingBLL()

    Protected Sub ImgbtnSelect_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnSelect.Click
        If txtChanelDate.Text = "" Then
            lblMsgChcDate.Text = "Please Enter an Date"
        ElseIf dpdwnTime.Text = "" Then
            lblMsgChkTime.Text = "Please Select an available Time Period"
        ElseIf dpdwnPay.Text = "" Then
            lblMsgChkPay.Text = "Please Select an appropriate Payment Method"
        Else
            objTimeSchedule.set_PayType(dpdwnPay.SelectedValue)
            objBookings.DID = CInt(lblDID.Text)
            objBookings.PID = CInt(Session("UID").ToString())
            objBookings.BDate = txtChanelDate.Text()
            objBookings.Time = dpdwnTime.SelectedValue.ToString()
            objBookings.PayType = dpdwnPay.SelectedValue.ToString()
            objBookings.AddBooking()
            Response.Redirect("~/Payment.aspx?PType=" & Me.dpdwnPay.Text)
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Request.QueryString("DID") IsNot Nothing Then
                If (Request.QueryString("DID").Length) <> 0 Then
                    Me.loadData(Integer.Parse(Request.QueryString("DID")))
                    lblATime.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub loadData(ByVal DID As Integer)
        DoctorsObj.getDoctor(DID)
        lblDID.Text = DoctorsObj.DID.ToString()
        lblDNme.Text = DoctorsObj.DName.ToString()
    End Sub

    Private Sub loadGrid()
        objTimeSchedule.set_Date(txtChanelDate.Text, lblDID.Text.ToString())
        Dim ScheduleArrayList As New ArrayList()
        For Each eBLL As TimeScheduleBLL In New TimeScheduleBLL().getAllSchedule_Date()
            ScheduleArrayList.Add(New TimeScheduleListBLL(eBLL))
        Next
        gdviewATimes.DataSource = ScheduleArrayList
        gdviewATimes.DataBind()
        If ScheduleArrayList.Count > 0 Then
            lblATime.Visible = True
        End If
    End Sub

    Protected Sub calATime_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calATime.SelectionChanged
        ClearAll()
        txtChanelDate.Text = calATime.SelectedDate.ToShortDateString()
        objTimeSchedule.set_Date(txtChanelDate.Text, lblDID.Text.ToString())
        loadGrid()
        If gdviewATimes.PageCount = 0 Then
            lblError.Visible = True
            dpdwnTime.Enabled = False
            dpdwnPay.Enabled = False
            ImgbtnSelect.Enabled = False
        Else
            loadTimes()
        End If

    End Sub

    Private Sub loadTimes()
        objTimeSchedule.set_Date(txtChanelDate.Text, lblDID.Text.ToString())
        dpdwnTime.DataSource = objTimeSchedule.listTimes()
        dpdwnTime.DataValueField = "Value"
        dpdwnTime.DataBind()
    End Sub

    Private Sub ClearAll()
        txtChanelDate.Text = ""
        lblMsgChcDate.Text = ""
        lblMsgChkPay.Text = ""
        lblMsgChkTime.Text = ""
        lblError.Text = ""
    End Sub
End Class
