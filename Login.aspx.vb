Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Class Login
    Inherits System.Web.UI.Page
    Private LoginUserObj As New LoginUserBLL()
    Private LoginDoctorObj As New LoginDoctorBLL()

    Protected Sub ImgbtnClear_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnClear.Click
        ClearLogin()
    End Sub

    Private Sub ClearLogin()
        txtUN.Text = ""
        txtPW.Text = ""
        dpDwnType.SelectedIndex = 0
        txtUN.Focus()
    End Sub

    Protected Sub ImgbtnLogin_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnLogin.Click
        Dim UNme As String = Me.txtUN.Text
        Dim Pass As String = Me.txtPW.Text
        Dim UID, Name As String
        Try
            If dpDwnType.SelectedValue = "Doctor" Then
                LoginDoctorObj.getDoctorLogin(UNme, Pass)
                If LoginDoctorObj.Message Is Nothing Then
                    UID = LoginDoctorObj.DID.ToString()
                    Name = LoginDoctorObj.DNme
                    UNme = LoginDoctorObj.DUNme
                    Pass = LoginDoctorObj.DPass
                    If UID = 0 Then
                        lblMsg.Text = LoginDoctorObj.Message
                        lblMsg.ForeColor = System.Drawing.Color.Red
                        ClearLogin()
                    End If
                    Session("Validity") = "True"
                    Session("UserType") = "Doctor"
                    Session("User") = Name
                    Session("UID") = UID.ToString()
                    Response.Redirect("~/Home.aspx")
                Else
                    ClearLogin()
                    lblMsg.Text = "Invalid Data, Please Re-enter the Details"
                    lblMsg.ForeColor = Drawing.Color.Red
                End If

            ElseIf dpDwnType.SelectedValue = "Patient" Then
                LoginUserObj.getPatient(UNme, Pass)
                If LoginUserObj.Message Is Nothing Then
                    UID = LoginUserObj.PID.ToString()
                    Name = LoginUserObj.PFNme + " " + LoginUserObj.PLNme
                    UNme = LoginUserObj.PUNme
                    Pass = LoginUserObj.PPass
                    If UID = 0 Then
                        lblMsg.Text = LoginUserObj.Message
                        lblMsg.ForeColor = System.Drawing.Color.Red
                        ClearLogin()
                    End If
                    Session("Validity") = "True"
                    Session("UserType") = "Patient"
                    Session("User") = Name
                    Session("UID") = UID.ToString()
                    Response.Redirect("~/Home.aspx")
                Else
                    ClearLogin()
                    lblMsg.Text = "Invalid Data, Please Re-enter the Details"
                    lblMsg.ForeColor = Drawing.Color.Red
                End If
            End If
            'End If
        Catch ex As Exception
            txtUN.Text = ""
            lblMsg.Text = "Error Occured Invalid Data, Please Re-enter the Details"
            lblMsg.ForeColor = Drawing.Color.Red
        End Try
        
    End Sub
End Class
