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

Partial Class DoctorReg
    Inherits System.Web.UI.Page
    Private objDoctor As New DoctorBLL()

    Protected Sub ImgbtnSubmit_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnSubmit.Click
        If FileUploadImageDoc.HasFile Then
            Dim strFilePath As String = "E:\Users\Bisina Keshara\Documents\Visual Studio 2010\WebSites\HumeAyu\DocImagesUpload\" & FileUploadImageDoc.FileName
            If File.Exists(strFilePath) Then
                lblMsg.Text = "Image File Already Exists in the Server, Please Upload another Image"
                lblMsg.ForeColor = System.Drawing.Color.Red
            Else
                Dim ImageString As String = "~/DocImagesUpload/" & FileUploadImageDoc.FileName
                Dim UNme, Pass, Email As String
                objDoctor.DName = txtNme.Text
                objDoctor.DAddress = txtAddress.Text
                objDoctor.DContact = txtCN.Text
                objDoctor.DEmail = txtEmail.Text
                objDoctor.DQualifications = txtQualifications.Text
                objDoctor.DExperience = txtExp.Text
                objDoctor.DSpecility = txtSpec.Text
                objDoctor.DUNme = txtUN.Text
                objDoctor.DPass = txtPW.Text
                objDoctor.DImage = ImageString
                UNme = txtUN.Text
                Pass = txtPW.Text
                FileUploadImageDoc.SaveAs("E:\Users\Bisina Keshara\Documents\Visual Studio 2010\WebSites\HumeAyu\DocImagesUpload\" & FileUploadImageDoc.FileName)
                Email = txtEmail.Text
                If objDoctor.AddDoctor() Then
                    Me.CLEARALL()
                    Response.Redirect("~/FinalReg.aspx?UN=" & UNme & "&PW=" & Pass & "&Email=" & Email)
                Else
                    lblMsg.Text = "Error occured. No action performed"
                    lblMsg.ForeColor = System.Drawing.Color.Red
                End If
            End If


        Else
            Dim UNme, Pass, Email As String
            objDoctor.DName = txtNme.Text
            objDoctor.DAddress = txtAddress.Text
            objDoctor.DContact = txtCN.Text
            objDoctor.DEmail = txtEmail.Text
            objDoctor.DQualifications = txtQualifications.Text
            objDoctor.DExperience = txtExp.Text
            objDoctor.DSpecility = txtSpec.Text
            objDoctor.DUNme = txtUN.Text
            objDoctor.DPass = txtPW.Text
            objDoctor.DImage = ""
            UNme = txtUN.Text
            Pass = txtPW.Text
            FileUploadImageDoc.SaveAs("E:\Users\Bisina Keshara\Documents\Visual Studio 2010\WebSites\HumeAyu\DocImagesUpload\" & FileUploadImageDoc.FileName)
            Email = txtEmail.Text
            If objDoctor.AddDoctor() Then
                Me.CLEARALL()
                Response.Redirect("~/FinalReg.aspx?UN=" & UNme & "&PW=" & Pass & "&Email" & Email)
            Else
                lblMsg.Text = "Error occured. No action performed"
                lblMsg.ForeColor = System.Drawing.Color.Red
            End If
        End If
    End Sub

    Protected Sub ImgbtnChg_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnChg.Click
        If FileUploadImageDoc.HasFile Then
            Dim strFilePath As String = "E:\Users\Bisina Keshara\Documents\Visual Studio 2010\WebSites\HumeAyu\DocImagesUpload" & FileUploadImageDoc.FileName
            If File.Exists(strFilePath) Then
                lblMsg.Text = "Image File Already Exists in the Server, Please Upload another Image"
                lblMsg.ForeColor = System.Drawing.Color.Red
            Else
                Dim ImageString As String = "~/DocImagesUpload/" & FileUploadImageDoc.FileName
                Dim UNme, Pass As String
                objDoctor.DID = Session("UID").ToString()
                objDoctor.DName = txtNme.Text
                objDoctor.DAddress = txtAddress.Text
                objDoctor.DContact = txtCN.Text
                objDoctor.DEmail = txtEmail.Text
                objDoctor.DQualifications = txtQualifications.Text
                objDoctor.DExperience = txtExp.Text
                objDoctor.DSpecility = txtSpec.Text
                objDoctor.DUNme = txtUN.Text
                objDoctor.DPass = txtPW.Text
                objDoctor.DImage = ImageString
                UNme = txtUN.Text
                Pass = txtPW.Text
                If objDoctor.saveDoctor() Then
                    Me.CLEARALL()
                    FileUploadImageDoc.SaveAs(strFilePath)
                    lblMsg.Text = "Changes Saved Successfully to the Database"
                    lblMsg.ForeColor = System.Drawing.Color.Green
                Else
                    lblMsg.Text = "Error occured. No action performed"
                    lblMsg.ForeColor = System.Drawing.Color.Red
                End If
            End If
        Else
            Dim UNme, Pass As String
            objDoctor.DName = txtNme.Text
            objDoctor.DAddress = txtAddress.Text
            objDoctor.DContact = txtCN.Text
            objDoctor.DEmail = txtEmail.Text
            objDoctor.DQualifications = txtQualifications.Text
            objDoctor.DExperience = txtExp.Text
            objDoctor.DSpecility = txtSpec.Text
            objDoctor.DUNme = txtUN.Text
            objDoctor.DPass = txtPW.Text
            objDoctor.DImage = ""
            UNme = txtUN.Text
            Pass = txtPW.Text
            If objDoctor.AddDoctor() Then
                Me.CLEARALL()
                lblMsg.Text = "Changes Saved Successfully to the Database"
                lblMsg.ForeColor = System.Drawing.Color.Green
            Else
                lblMsg.Text = "Error occured. No action performed"
                lblMsg.ForeColor = System.Drawing.Color.Red
            End If
        End If
    End Sub

    Protected Sub ImgbtnClr_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnClr.Click
        CLEARALL()
    End Sub

    Private Sub CLEARALL()
        txtNme.Text = ""
        txtAddress.Text = ""
        txtCN.Text = ""
        txtEmail.Text = ""
        txtQualifications.Text = ""
        txtExp.Text = ""
        txtSpec.Text = ""
        txtUN.Text = ""
        txtPW.Text = ""
        txtRPW.Text = ""
        txtNme.Focus()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Request.QueryString("DID") IsNot Nothing Then
                If (Request.QueryString("DID").Length) <> 0 Then
                    ImgbtnSubmit.Visible = False
                    ImgbtnChg.Visible = True
                    ImgTitleDReg.Visible = False
                    loadData(Integer.Parse(Request.QueryString("DID")))
                End If
            Else
                ImgbtnChg.Visible = False
                ImgbtnSubmit.Visible = True
            End If
        End If
    End Sub

    Private Sub loadData(ByVal DID As Integer)
        objDoctor.getDoctor(DID)
        lblUID.Text = objDoctor.DID.ToString()
        txtNme.Text = objDoctor.DName
        txtAddress.Text = objDoctor.DAddress
        txtCN.Text = objDoctor.DContact
        txtEmail.Text = objDoctor.DEmail
        txtQualifications.Text = objDoctor.DQualifications
        txtExp.Text = objDoctor.DExperience
        txtSpec.Text = objDoctor.DSpecility
        txtUN.Text = objDoctor.DUNme
        txtPW.Text = objDoctor.DPass
        txtRPW.Text = objDoctor.DPass
    End Sub

End Class
