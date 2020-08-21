Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class ViewTimeSchedule
    Inherits System.Web.UI.Page
    Private objTimeSchedule As New TimeScheduleBLL()

    Protected Sub loadGrid()
        Dim ScheduleArrayList As New ArrayList()
        For Each eBLL As TimeScheduleBLL In New TimeScheduleBLL().getAllSchedule_Date()
            ScheduleArrayList.Add(New TimeScheduleListBLL(eBLL))
        Next
        gvTimeSchedule.DataSource = ScheduleArrayList
        gvTimeSchedule.DataBind()
    End Sub

    Protected Sub calDate_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles calDate.SelectionChanged
        lblDelMsg.Text = ""
        lblDate.Text = calDate.SelectedDate.ToShortDateString()
        objTimeSchedule.set_Date(lblDate.Text, Session("UID").ToString())
        loadGrid()
    End Sub
    Protected Sub gvTimeSchedule_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvTimeSchedule.PageIndexChanging
        gvTimeSchedule.PageIndex = e.NewPageIndex
    End Sub

    Protected Sub gvTimeSchedule_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvTimeSchedule.RowCommand
        If e.CommandName = "delete" Then
            If objTimeSchedule.RemoveSchedule(Integer.Parse(e.CommandArgument.ToString())) Then
                lblDelMsg.Text = "Scheduled Date Deleted Successfully..!!"
                lblDelMsg.ForeColor = Drawing.Color.Red
                loadGrid()
            End If
        End If
    End Sub

    Protected Sub gvTimeSchedule_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gvTimeSchedule.RowDeleting
        lblDelMsg.Text = "Scheduled Date Deleted Successfully..!!"
        lblDelMsg.ForeColor = Drawing.Color.Red
        loadGrid()
    End Sub

    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Response.Redirect("~/TimeSchedule.aspx")
    End Sub
End Class
