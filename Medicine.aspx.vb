Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class Medicine
    Inherits System.Web.UI.Page
    Private PlantObj As New PlantsBLL()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.loadGrid()
    End Sub

    Protected Sub loadGrid()
        Dim PlantArrayList As New ArrayList()
        For Each eBLL As PlantsBLL In New PlantsBLL().getAllPlants()
            PlantArrayList.Add(New PlantsListBLL(eBLL))
        Next
        gdviewMedicine.DataSource = PlantArrayList
        gdviewMedicine.DataBind()
    End Sub

    Protected Sub gdviewMedicine_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gdviewMedicine.PageIndexChanging
        gdviewMedicine.PageIndex = e.NewPageIndex
    End Sub

    Protected Sub gdviewMedicine_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gdviewMedicine.RowCommand
        If e.CommandName = "details" Then
            Response.Redirect("~/HerbalPlantsFull.aspx?PLID=" & Integer.Parse(e.CommandArgument.ToString()))
        End If
    End Sub
End Class
