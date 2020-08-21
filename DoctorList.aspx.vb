Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class DoctorList
    Inherits System.Web.UI.Page
    Private DoctorObj As DoctorBLL()

    Protected Sub gdviewDoctors_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gdviewDoctors.PageIndexChanging
        gdviewDoctors.PageIndex = e.NewPageIndex
    End Sub

    Protected Sub gdviewDoctors_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gdviewDoctors.RowCommand
        If e.CommandName = "details" Then
            Response.Redirect("Doctors.aspx?DID=" & Integer.Parse(e.CommandArgument.ToString()))
        End If
    End Sub

    Protected Sub loadGrid()
        Dim DoctorArrayList As New ArrayList()
        For Each eBLL As DoctorBLL In New DoctorBLL().getAllDoctors()
            DoctorArrayList.Add(New DoctorListBLL(eBLL))
        Next
        gdviewDoctors.DataSource = DoctorArrayList
        gdviewDoctors.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.loadGrid()
    End Sub
End Class
