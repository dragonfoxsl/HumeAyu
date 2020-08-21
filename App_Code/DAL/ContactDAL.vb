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
Imports System.Collections
Imports DAL

Public Class ContactDAL
    Private dbUtils As New DatabaseUtils()

#Region "Constructor"

    Public Sub New()

    End Sub

#End Region

#Region "Methods"

    Public Function AddComment(ByVal ContObj As ContactBLL) As Integer
        Dim strSql As String
        Try
            strSql = "INSERT INTO Contact(CNme,CEmail,Comment) VALUES('" & ContObj.Name & "','" & ContObj.Email & "','" & ContObj.Comment & "')"
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

#End Region
End Class
