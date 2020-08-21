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

Public Class AdminDAL
    Private dbUtils As New DatabaseUtils()

#Region "Constructor"

    Public Sub New()

    End Sub

#End Region

#Region "Methods"

    Public Function insertAdmin(ByVal AdminObj As AdminBLL) As Integer
        Dim strSql As String
        Try
            strSql = "INSERT INTO AdminLog(UNme, Pass) VALUES('" & AdminObj.AUNme & "','" & AdminObj.APass & "')"
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function RemoveAdmin(ByVal AID As Integer) As Boolean
        Dim strSql As String
        Try
            strSql = "DELETE FROM AdminLog WHERE AID = " & AID & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function getAllAdmin() As AdminBLL()
        Dim sql As String = "SELECT * FROM AdminLog ORDER BY AID ASC"
        Dim dt As DataTable = Me.dbUtils.ExecuteQuery(sql)
        Dim e As AdminBLL() = New AdminBLL(dt.Rows.Count - 1) {}
        For i As Integer = 0 To e.GetUpperBound(0)
            e(i) = New AdminBLL(dt.Rows(i))
        Next
        Return e
    End Function

#End Region

End Class
