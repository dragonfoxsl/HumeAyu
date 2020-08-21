Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class TimeScheduleVideo
    Inherits System.Web.UI.Page
    Private objVTimeSchedule As New VideoBookingBLL()

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        txtTimeSchdule.Text = Calendar1.SelectedDate.ToShortDateString()
        objVTimeSchedule.setDate(txtTimeSchdule.Text, Session("UID").ToString())
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Validity") = "True" Then
            lblDID.Text = Session("UID")
        Else
            MsgBox("Invalid User Access..!", MsgBoxStyle.OkOnly, "System Message")
            If MsgBoxResult.Ok = MsgBoxResult.Ok Then
                Response.Redirect("~/Home.aspx")
            End If
        End If
    End Sub

    Protected Sub ImgbtnSchedule_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnSchedule.Click
        If txtTimeSchdule.Text = "" Then
            lblCheckDate.Text = "Select an Appropriate Date"
            lblCheckDate.ForeColor = System.Drawing.Color.Red
        Else
            If Session("Validity") = "True" And Session("UserType") = "Doctor" Then
                objVTimeSchedule.setDate(txtTimeSchdule.Text.ToString(), Session("UID").ToString())
                loadGridVTime()
            Else
                MsgBox("Invalid User Access..!", MsgBoxStyle.OkOnly, "System Message")
                If MsgBoxResult.Ok = MsgBoxResult.Ok Then
                    Response.Redirect("~/Home.aspx")
                End If
            End If
        End If
    End Sub

    Protected Sub loadGridVTime()
        Dim VScheduleArrayList As New ArrayList()
        For Each eBLL As VideoBookingBLL In New VideoBookingBLL().getAllVideoBooking()
            VScheduleArrayList.Add(New VideoBookingListBLL(eBLL))
        Next
        gvTimeScheduleVideo.DataSource = VScheduleArrayList
        gvTimeScheduleVideo.DataBind()
        If VScheduleArrayList.Count > 0 Then
            lblRequest.Visible = True
        End If
    End Sub

    Protected Sub gvTimeScheduleVideo_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvTimeScheduleVideo.PageIndexChanging
        gvTimeScheduleVideo.PageIndex = e.NewPageIndex
    End Sub

    Protected Sub gvTimeScheduleVideo_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvTimeScheduleVideo.RowCommand
        If e.CommandName = "schedule" Then
            Response.Redirect("PatientView.aspx?VBID=" & Integer.Parse(e.CommandArgument.ToString()) & "&Type=Check")
        End If
    End Sub
End Class
