Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Text
Imports System.Text.StringBuilder

Partial Class PatientView
    Inherits System.Web.UI.Page
    Private PatientObj As New UserBLL()
    Private VBookingObj As New VideoBookingBLL()
    Dim VideoBookingRecordID As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Request.QueryString("Type") IsNot Nothing Then
                If (Request.QueryString("Type")) = "Check" Then
                    VideoBookingRecordID = Request.QueryString("VBID").ToString()
                    VBookingObj.getVideoBookingView(Request.QueryString("VBID"))
                    Dim VPID As Integer = CInt(VBookingObj.PID)
                    Me.loadData(VPID)
                    Me.lblUpdate.Visible = True
                    Me.lblConfirm.Visible = True
                    Me.lblTime.Visible = True
                    Me.txtTime.Visible = True
                    Me.chbConfirm.Visible = True
                    Me.dpdwnTime.Visible = True
                    Me.ImgbtnSubmit.Visible = True
                ElseIf (Request.QueryString("Type")) = "View" Then
                    Me.loadData(Integer.Parse(Request.QueryString("PID")))
                    Me.ImgbtnBack.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub loadData(ByVal PID As Integer)
        PatientObj.getPatient(PID)
        txtPID.Text = PatientObj.PID.ToString()
        txtFNme.Text = PatientObj.PFirstName.ToString()
        txtLNme.Text = PatientObj.PLastName.ToString()
        txtAddress.Text = PatientObj.PAddress.ToString()
        txtEmail.Text = PatientObj.PEmail.ToString()
        txtTP.Text = PatientObj.PContact.ToString()
        txtDOB.Text = PatientObj.PDOB.ToString()
        txtDOJ.Text = PatientObj.PDOJ.ToString()
    End Sub


    Protected Sub ImgbtnSubmit_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnSubmit.Click
        Dim NewMail As New StringBuilder
        NewMail.Append("mailto:" + txtEmail.Text.ToString())
        NewMail.Append("&subject=HumeAyu Video Conferencing  Service")
        NewMail.Append("&body=Video Conferencing is Assigned to the Following Time : " + txtTime.Text.ToString())
        System.Diagnostics.Process.Start(NewMail.ToString())
        Dim Conf As String
        If chbConfirm.Checked = True Then
            Conf = "Yes"
            VBookingObj.VBID = Request.QueryString("VBID").ToString()
            VBookingObj.ConfTime = txtTime.Text + " " + dpdwnTime.SelectedValue.ToString()
            VBookingObj.Confirm = Conf.ToString()
            VBookingObj.UpdateConf()
        Else
            chbConfirm.Text = "Please Confirm the Time"
            chbConfirm.ForeColor = Drawing.Color.Red
        End If
        Response.Redirect("~/TimeScheduleVideo.aspx")
    End Sub

    Protected Sub ImgbtnBack_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnBack.Click
        Response.Redirect("PatientList.aspx")
    End Sub
End Class
