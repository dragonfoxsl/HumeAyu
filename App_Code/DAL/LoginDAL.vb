Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Data.SqlClient
Imports System.Collections
Imports DAL

Public Class LoginDAL
    Private dbUtils As New DatabaseUtils()

#Region "Constructor"

    Public Sub New()

    End Sub

#End Region

#Region "Methods"

    Public Function getDoctorLogin(ByVal MUNme As String, ByVal MPass As String) As DataRow
        Dim sql As String = "SELECT [DID],[DNme],[UNme],[Pass] FROM Doctor WHERE UNme = '" & MUNme & "' AND Pass = '" & MPass & "' AND Validity = 'Yes'"
        Dim DoctorDataTable As DataTable = dbUtils.ExecuteQuery(sql)
        If DoctorDataTable.Rows.Count > 0 Then
            Return DoctorDataTable.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function getPatientLogin(ByVal MUNme As String, ByVal MPass As String) As DataRow
        Dim sql As String = "SELECT [PID],[FNme],[LNme],[UNme],[Password] FROM Patient WHERE UNme = '" & MUNme & "' AND Password = '" & MPass & "'"
        Dim DoctorDataTable As DataTable = dbUtils.ExecuteQuery(sql)
        If DoctorDataTable.Rows.Count > 0 Then
            Return DoctorDataTable.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function getAdminLogin(ByVal MUNme As String, ByVal MPass As String) As DataRow
        Dim sql As String = "SELECT [AID],[UNme],[Pass] FROM AdminLog WHERE UNme = '" & MUNme & "' AND Pass = '" & MPass & "'"
        Dim DoctorDataTable As DataTable = dbUtils.ExecuteQuery(sql)
        If DoctorDataTable.Rows.Count > 0 Then
            Return DoctorDataTable.Rows(0)
        Else
            Return Nothing
        End If
    End Function


#End Region

End Class
