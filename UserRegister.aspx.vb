Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class UserRegister
    Inherits System.Web.UI.Page
    Private objPatient As New UserBLL()

    Protected Sub ImgbtnCal_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnCal.Click
        If CalDOB.Visible = False Then
            CalDOB.Visible = True
        ElseIf CalDOB.Visible = True Then
            CalDOB.Visible = False
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtDOJ.Text = DateAndTime.Today
        If Not IsPostBack Then
            If Request.QueryString("PID") IsNot Nothing Then
                If (Request.QueryString("PID").Length) <> 0 Then
                    ImgbtnSubmit.Visible = False
                    lmgbtnChage.Visible = True
                    ImgbtnClr.Visible = True
                    loadData(Integer.Parse(Request.QueryString("PID")))
                End If
            Else
                ImgbtnSubmit.Visible = True
                ImgbtnClr.Visible = True
            End If
        End If
    End Sub

    Protected Sub CalDOB_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CalDOB.SelectionChanged
        Me.txtDOB.Text = CalDOB.SelectedDate
        CalDOB.Visible = False
    End Sub

    Private Sub ClearAll()
        Me.txtFNme.Text = ""
        Me.txtLNme.Text = ""
        Me.txtAddress.Text = ""
        Me.txtEmail.Text = ""
        Me.txtTP.Text = ""
        Me.txtDOB.Text = ""
        Me.txtDOJ.Text = ""
        Me.txtUN.Text = ""
        Me.txtPW.Text = ""
        Me.txtRPW.Text = ""
        Me.cbxTerms.Checked = False
        Me.CalDOB.Visible = False
        Me.txtDOJ.Text = DateAndTime.Today
        Me.txtFNme.Focus()
    End Sub

    Protected Sub ImgbtnClr_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnClr.Click
        ClearAll()
    End Sub

    Protected Sub ImgbtnSubmit_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnSubmit.Click
        If cbxTerms.Checked = True Then
            Dim UNme, Pass As String
            objPatient.PFirstName = txtFNme.Text
            objPatient.PLastName = txtLNme.Text
            objPatient.PAddress = txtAddress.Text
            objPatient.PEmail = txtEmail.Text
            objPatient.PContact = txtTP.Text
            objPatient.PDOB = txtDOB.Text
            objPatient.PDOJ = txtDOJ.Text
            objPatient.PUNme = txtUN.Text
            objPatient.PPass = txtPW.Text
            UNme = txtUN.Text
            Pass = txtPW.Text
            If objPatient.AddPatient() Then
                Me.ClearAll()
                Response.Redirect("~/FinalReg.aspx?UN=" & UNme & "&PW=" & Pass & "&Email=" & objPatient.PEmail.ToString())
            Else
                lblMsg.Text = "Error occured. No action performed"
                lblMsg.ForeColor = System.Drawing.Color.Red
                ClearAll()
            End If
        Else
            lblCheck.Text = "Please Accept the Terms and Conditions of HumeAyu.com"
        End If
    End Sub

    Protected Sub lmgbtnChage_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles lmgbtnChage.Click
        objPatient.PFirstName = txtFNme.Text
        objPatient.PLastName = txtLNme.Text
        objPatient.PAddress = txtAddress.Text
        objPatient.PEmail = txtEmail.Text
        objPatient.PContact = txtTP.Text
        objPatient.PDOB = txtDOB.Text
        objPatient.PDOJ = txtDOJ.Text
        objPatient.PUNme = txtUN.Text
        objPatient.PPass = txtPW.Text
        If objPatient.savePatient() Then
            Me.ClearAll()
            lblMsg.Text = "Changes Saved Successfully to the Database"
            lblMsg.ForeColor = System.Drawing.Color.Green
        Else
            lblMsg.Text = "Error occured. No action performed"
            lblMsg.ForeColor = System.Drawing.Color.Red
        End If
    End Sub

    Private Sub loadData(ByVal PID As Integer)
        objPatient.getPatient(PID)
        txtPID.Text = objPatient.PID.ToString()
        txtFNme.Text = objPatient.PFirstName
        txtLNme.Text = objPatient.PLastName
        txtAddress.Text = objPatient.PAddress
        txtEmail.Text = objPatient.PEmail
        txtTP.Text = objPatient.PContact
        txtDOB.Text = Convert.ToString(objPatient.PDOB)
        txtDOJ.Text = Convert.ToString(objPatient.PDOJ)
        txtUN.Text = objPatient.PUNme
        txtPW.Text = objPatient.PPass
        txtRPW.Visible = True
        cbxTerms.Visible = False
    End Sub

    Protected Sub cbxTerms_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTerms.CheckedChanged
        lblCheck.Text = ""
    End Sub
End Class
