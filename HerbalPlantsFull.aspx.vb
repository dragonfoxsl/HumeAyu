Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class HerbalPlantsFull
    Inherits System.Web.UI.Page
    Private PlantsObj As New PlantsBLL()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.loadData()
            If Request.QueryString("PLID") IsNot Nothing Then
                If (Request.QueryString("PLID").Length) <> 0 Then
                    Me.loadData(Integer.Parse(Request.QueryString("PLID")))
                End If
            End If
        End If
    End Sub

    Private Sub loadData()

    End Sub

    Private Sub loadData(ByVal PLID As Integer)
        PlantsObj.getPlants(PLID)
        lblPNme.Text = PlantsObj.PLNme.ToString()
        lblPlantNme.Text = PlantsObj.PLNme.ToString()
        lblBNme.Text = PlantsObj.PLBotnicalNme.ToString()
        txtDescrip.Text = PlantsObj.PLDescription.ToString()
        ImgPlant.ImageUrl = PlantsObj.PLImage.ToString()
    End Sub

End Class
