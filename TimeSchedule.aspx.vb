Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Xml

Partial Class TimeSchedule
    Inherits System.Web.UI.Page
    Private objTimeSchedule As New TimeScheduleBLL()

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        lblMsg.Text = ""
        txtTimeSchdule.Text = Calendar1.SelectedDate.ToShortDateString()
        objTimeSchedule.set_Date(txtTimeSchdule.Text, lblDID.Text)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Validity") = "True" Then
            lblDID.Text = Session("UID")
        Else
            MsgBox("Invalid User Access..!", MsgBoxStyle.OkOnly, "System Message")
            If MsgBoxResult.Ok = MsgBoxResult.Ok Then
                Response.Redirect("~/Home.aspx")
            End If
        End If

    End Sub

    Protected Sub ImgbtnSchedule_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnSchedule.Click
        If txtTimeSchdule.Text = "" Then
            lblCheckDate.Text = "Select an Appropriate Date"
            lblCheckDate.ForeColor = System.Drawing.Color.Red
        Else
            If txtNoPat.Text = "" Then
                lblCheckPatient.Text = "Please Enter a Valid No of Patients"
                lblCheckPatient.ForeColor = System.Drawing.Color.Red
            Else
                If Session("Validity") = "True" Then
                    objTimeSchedule.DID = Convert.ToInt32(lblDID.Text)
                    objTimeSchedule.ChannelingDate = txtTimeSchdule.Text
                    objTimeSchedule.ChannelingTime = dpdwnTime.SelectedItem.Value
                    objTimeSchedule.NoPatients = txtNoPat.Text
                    If objTimeSchedule.AddSchedule() Then
                        CLEAR()
                        lblMsg.Text = "Channeling Times Scheduled Successfully..!!"
                        lblMsg.ForeColor = System.Drawing.Color.Green
                    Else
                        lblMsg.Text = "Error occured. No action performed"
                        lblMsg.ForeColor = System.Drawing.Color.Red
                    End If
                Else
                    MsgBox("Invalid User Access..!", MsgBoxStyle.OkOnly, "System Message")
                    If MsgBoxResult.Ok = MsgBoxResult.Ok Then
                        Response.Redirect("~/Home.aspx")
                    End If
                End If
            End If
        End If
    End Sub

    Protected Sub ImgbtnClear_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgbtnClear.Click
        CLEAR()
    End Sub

    Private Sub CLEAR()
        Me.lblCheckDate.Text = ""
        Me.lblMsg.Text = ""
        Me.txtTimeSchdule.Text = ""
        Me.txtNoPat.Text = ""
        Me.dpdwnTime.SelectedIndex = 0
        Me.txtTimeSchdule.Focus()
    End Sub

End Class
