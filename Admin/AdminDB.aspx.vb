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

Partial Class Admin_AdminDB
    Inherits System.Web.UI.Page
    Private objPlant As New PlantsBLL

    Protected Sub ImgbtnBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnBack.Click
        Response.Redirect("~/Admin/AdminMain.aspx")
    End Sub

    Protected Sub gdviewMedicine_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gdviewMedicine.PageIndexChanging
        gdviewMedicine.PageIndex = e.NewPageIndex
    End Sub

    Protected Sub gdviewMedicine_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gdviewMedicine.RowCommand
        Try
            If e.CommandName = "delete" Then
                objPlant.RemovePlant(Integer.Parse(e.CommandArgument.ToString()))
                loadGrid()
            End If
        Catch ex As Exception
            loadGrid()
        End Try
        Response.Redirect("~/Admin/AdminDB.aspx")
    End Sub

    Protected Sub loadGrid()
        Dim PlantArrayList As New ArrayList()
        For Each eBLL As PlantsBLL In New PlantsBLL().getAllPlants()
            PlantArrayList.Add(New PlantsListBLL(eBLL))
        Next
        gdviewMedicine.DataSource = PlantArrayList
        gdviewMedicine.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadGrid()
    End Sub

    Private Sub Clear()
        txtPNme.Text = ""
        txtBNme.Text = ""
        txtDes.Text = ""
        txtPNme.Focus()
    End Sub

    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If FileUploadImage.HasFile Then
            Dim strFilePath As String = "E:\Users\Bisina Keshara\Documents\Visual Studio 2010\WebSites\HumeAyu\Images\Plants\" & FileUploadImage.FileName
            If File.Exists(strFilePath) Then
                lblMsg.Text = "Image File Already Exists in the Server, Please Upload another Image"
                lblMsg.ForeColor = System.Drawing.Color.Red
            Else
                Dim ImageString As String = "~/Images/Plants/" & FileUploadImage.FileName
                objPlant.PLNme = txtPNme.Text
                objPlant.PLBotnicalNme = txtBNme.Text
                objPlant.PLDescription = txtDes.Text
                objPlant.PLImage = ImageString.ToString()
                FileUploadImage.SaveAs("E:\Users\Bisina Keshara\Documents\Visual Studio 2010\WebSites\HumeAyu\Images\Plants\" & FileUploadImage.FileName)
                If objPlant.AddPlant() Then
                    Me.Clear()
                    loadGrid()
                Else
                    lblMsg.Text = "Error occured. No action performed"
                    lblMsg.ForeColor = System.Drawing.Color.Red
                End If
            End If
        End If
        

    End Sub

    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clear()
    End Sub
End Class
