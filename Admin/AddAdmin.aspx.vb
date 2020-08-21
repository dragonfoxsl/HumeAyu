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

Partial Class Admin_AddAdmin
    Inherits System.Web.UI.Page
    Private objAdmin As New AdminBLL

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        objAdmin.AUNme = txtUN.Text
        objAdmin.APass = txtPASS.Text
        If objAdmin.AddAdmin() Then
            Me.Clear()
            loadGrid()
        Else
            lblMsg.Text = "Error occured. No action performed"
            lblMsg.ForeColor = System.Drawing.Color.Red
        End If
    End Sub

    Protected Sub BbtnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BbtnClear.Click
        Clear()
    End Sub

    Protected Sub loadGrid()
        Dim PlantArrayList As New ArrayList()
        For Each eBLL As AdminBLL In New AdminBLL().getAllAdmin()
            PlantArrayList.Add(New AdminListBLL(eBLL))
        Next
        gdviewMedicine.DataSource = PlantArrayList
        gdviewMedicine.DataBind()
    End Sub

    Protected Sub gdviewMedicine_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gdviewMedicine.PageIndexChanging
        gdviewMedicine.PageIndex = e.NewPageIndex
    End Sub

    Protected Sub gdviewMedicine_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gdviewMedicine.RowCommand
        Try
            If e.CommandName = "delete" Then
                objAdmin.RemoveAdmin(Integer.Parse(e.CommandArgument.ToString()))
                loadGrid()
            End If
        Catch ex As HttpUnhandledException
            loadGrid()
        End Try

    End Sub

    Private Sub Clear()
        Me.txtUN.Text = ""
        Me.txtPASS.Text = ""
        Me.txtUN.Focus()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadGrid()
    End Sub

    Protected Sub ImgbtnBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnBack.Click
        Response.Redirect("~/Admin/AdminMain.aspx")
    End Sub

    Protected Sub gdviewMedicine_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gdviewMedicine.RowDeleting
        loadGrid()
    End Sub
End Class
