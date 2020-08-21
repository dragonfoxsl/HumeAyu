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

Public Class PlantsDAL
    Private dbUtils As New DatabaseUtils()

#Region "Constructor"

    Public Sub New()

    End Sub

#End Region

#Region "Methods"

    Public Function getPlant(ByVal PLID As Integer) As DataRow
        Dim sql As String = "SELECT * FROM Plant WHERE PLID = " & PLID
        Dim PlantDataTable As DataTable = dbUtils.ExecuteQuery(sql)
        If PlantDataTable.Rows.Count > 0 Then
            Return PlantDataTable.Rows(0)
        Else
            Return Nothing
        End If
    End Function
    Public Function insertPlant(ByVal plantObj As PlantsBLL) As Integer
        Dim strSql As String
        Try
            strSql = "INSERT INTO Plant(PLNme, BotnicalNme, Description, Image) VALUES('" & plantObj.PLNme & "','" & plantObj.PLBotnicalNme & "','" & plantObj.PLDescription & "','" & plantObj.PLImage & "')"
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function getAllPlant() As PlantsBLL()
        Dim sql As String = "SELECT * FROM Plant ORDER BY PLID ASC"
        Dim dt As DataTable = Me.dbUtils.ExecuteQuery(sql)
        Dim e As PlantsBLL() = New PlantsBLL(dt.Rows.Count - 1) {}
        For i As Integer = 0 To e.GetUpperBound(0)
            e(i) = New PlantsBLL(dt.Rows(i))
        Next
        Return e
    End Function

    Public Function savePlant(ByVal plantObj As PlantsBLL) As Boolean
        Dim strSql As String
        Try
            strSql = "UPDATE Plant SET PLNme = '" & plantObj.PLNme & "', BotnicalNme = '" & plantObj.PLBotnicalNme & "', Description = '" & plantObj.PLDescription & "', Image = '" & plantObj.PLImage & "'  WHERE PLID =" & plantObj.PLID & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function RemovePlant(ByVal PLID As Integer) As Boolean
        Dim strSql As String
        Try
            strSql = "DELETE FROM Plant WHERE PLID =" & PLID & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

#End Region
End Class
