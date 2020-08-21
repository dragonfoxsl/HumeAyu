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

Public Class UserDAL
    Private dbUtils As New DatabaseUtils()

#Region "Constructor"

    Public Sub New()

    End Sub

#End Region

#Region "Methods"

    Public Function getPatient(ByVal PID As Integer) As DataRow
        Dim sql As String = "SELECT * FROM Patient WHERE PID = " & PID
        Dim PatientDataTable As DataTable = dbUtils.ExecuteQuery(sql)
        If PatientDataTable.Rows.Count > 0 Then
            Return PatientDataTable.Rows(0)
        Else
            Return Nothing
        End If
    End Function
    Public Function insertPatient(ByVal userObj As UserBLL) As Integer
        Dim strSql As String
        Try
            strSql = "INSERT INTO Patient(FNme, LNme, Address, Email, ContactNo, DOB, DOJ, UNme, Password) VALUES('" & userObj.PFirstName & "','" & userObj.PLastName & "','" & userObj.PAddress & "','" & userObj.PEmail & "','" & userObj.PContact & "','" & userObj.PDOB & "','" & userObj.PDOJ & "','" & userObj.PUNme & "','" & userObj.PPass & "')"
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function getAllPatient() As UserBLL()
        Dim sql As String = "SELECT * FROM Patient ORDER BY PID ASC"
        Dim dt As DataTable = Me.dbUtils.ExecuteQuery(sql)
        Dim e As UserBLL() = New UserBLL(dt.Rows.Count - 1) {}
        For i As Integer = 0 To e.GetUpperBound(0)
            e(i) = New UserBLL(dt.Rows(i))
        Next
        Return e
    End Function

    Public Function savePatient(ByVal userObj As UserBLL) As Boolean
        Dim strSql As String
        Try
            strSql = "UPDATE Patient SET FNme = '" & userObj.PFirstName & "', LNme = '" & userObj.PLastName & "', Address = '" & userObj.PAddress & "', Email = '" & userObj.PEmail & "', ContactNo = " & userObj.PContact & "', DOB = '" & userObj.PDOB & "', DOJ = '" & userObj.PDOJ & "', UNme = '" & userObj.PUNme & "', Password = '" & userObj.PPass & "' WHERE PID =" & userObj.PID & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function RemovePatient(ByVal PID As Integer) As Boolean
        Dim strSql As String
        Try
            strSql = "DELETE FROM Patient WHERE PID =" & PID & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try

    End Function
#End Region
End Class
