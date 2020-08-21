Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class PatientList
    Inherits System.Web.UI.Page
    Private objPatient As UserBLL()


    Protected Sub gdviewPatient_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gdviewPatient.PageIndexChanging
        gdviewPatient.PageIndex = e.NewPageIndex
    End Sub

    Protected Sub gdviewPatient_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gdviewPatient.RowCommand
        If e.CommandName = "details" Then
            Response.Redirect("~/PatientView.aspx?PID=" & Integer.Parse(e.CommandArgument.ToString()) & "&Type=View")
        End If
    End Sub

    Protected Sub loadGrid()
        Dim PatientArrayList As New ArrayList()
        For Each eBLL As UserBLL In New UserBLL().getAllPatients()
            PatientArrayList.Add(New UserListBLL(eBLL))
        Next
        gdviewPatient.DataSource = PatientArrayList
        gdviewPatient.DataBind()
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("UserType") = "Doctor" Then
            loadGrid()
        Else
            MsgBox("You Are Unauthorized to View this Page...", MsgBoxStyle.Exclamation, "HumeAyu Administration")
            Response.Redirect("~/Home.aspx")
        End If

    End Sub
End Class
