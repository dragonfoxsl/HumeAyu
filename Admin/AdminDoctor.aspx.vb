
Partial Class Admin_AdminDoctor
    Inherits System.Web.UI.Page
    Private objDoc As New DoctorBLL

    Protected Sub gdviewDoctor_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gdviewDoctor.PageIndexChanging
        gdviewDoctor.PageIndex = e.NewPageIndex
    End Sub


    Protected Sub gdviewDoctor_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gdviewDoctor.RowCommand
        If e.CommandName = "validate" Then
            objDoc.DID = Integer.Parse(e.CommandArgument)
            objDoc.DValidity = "Yes"
            If objDoc.UpdateValidity() Then
                loadGrid()
            End If
        ElseIf e.CommandName = "change" Then
            objDoc.DID = Integer.Parse(e.CommandArgument.ToString())
            objDoc.DValidity = "No"
            If objDoc.UpdateValidity() Then
                loadGrid()
            End If
        End If

    End Sub

    Protected Sub ImgbtnBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnBack.Click
        Response.Redirect("~/Admin/AdminMain.aspx")
    End Sub

    Protected Sub loadGrid()
        Dim DoctorArrayList As New ArrayList()
        For Each eBLL As DoctorBLL In New DoctorBLL().getAllDoctors()
            DoctorArrayList.Add(New DoctorListBLL(eBLL))
        Next
        gdviewDoctor.DataSource = DoctorArrayList
        gdviewDoctor.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadGrid()
    End Sub
End Class
