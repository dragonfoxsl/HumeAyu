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

Public Class TimeScheduleDAL
    Private dbUtils As New DatabaseUtils()

#Region "Constructor"

    Public Sub New()

    End Sub

#End Region

#Region "Methods"
    Public Shared Select_Date, DocID As String
    Public Shared Set_PayType As String

    Public Function listTimes() As Hashtable
        Dim sql As String = "SELECT SID,Time FROM Schedule WHERE Date ='" & Select_Date & "' AND DID = '" & DocID & "'"
        Dim TimeDataTable As DataTable = dbUtils.ExecuteQuery(sql)
        Dim TimeHashTable As New Hashtable(TimeDataTable.Rows.Count)
        For i As Integer = 0 To TimeDataTable.Rows.Count - 1
            TimeHashTable.Add(TimeDataTable.Rows(i)("SID"), TimeDataTable.Rows(i)("Time"))
        Next
        Return TimeHashTable
    End Function


    Public Function getTimeSchedule(ByVal SID As Integer) As DataRow
        Dim sql As String = "SELECT * FROM Schedule WHERE SID = " & SID
        Dim TimeScheduleDataTable As DataTable = dbUtils.ExecuteQuery(sql)
        If TimeScheduleDataTable.Rows.Count > 0 Then
            Return TimeScheduleDataTable.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function insertTimeSchedule(ByVal timeObj As TimeScheduleBLL) As Integer
        Dim strSql As String
        Try
            strSql = "INSERT INTO Schedule(DID, Date, Time, NoPatients) VALUES('" & timeObj.DID & "','" & timeObj.ChannelingDate & "','" & timeObj.ChannelingTime & "','" & timeObj.NoPatients & "')"
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Sub setPayType(ByVal strPay As String)
        Set_PayType = strPay
    End Sub

    Public Function insertBooking(ByVal timeObj As TimeScheduleBLL) As Integer
        Dim strSql As String
        Try
            strSql = "INSERT INTO Schedule(DID, Date, Time, NoPatients) VALUES('" & timeObj.DID & "','" & timeObj.ChannelingDate & "','" & timeObj.ChannelingTime & "','" & timeObj.NoPatients & "')"
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Sub setDate(ByVal strDate As String, ByVal DocIDV As String)
        Select_Date = strDate
        DocID = DocIDV
    End Sub

    Public Function getAllTimeSchedule() As TimeScheduleBLL()
        Dim sql As String = "SELECT * FROM Schedule ORDER BY SID ASC"
        Dim dt As DataTable = Me.dbUtils.ExecuteQuery(sql)
        Dim e As TimeScheduleBLL() = New TimeScheduleBLL(dt.Rows.Count - 1) {}
        For i As Integer = 0 To e.GetUpperBound(0)
            e(i) = New TimeScheduleBLL(dt.Rows(i))
        Next
        Return e
    End Function

    Public Function getAllTimeSchedule_Date() As TimeScheduleBLL()
        Dim sql As String = "SELECT * FROM Schedule WHERE Date = '" & Select_Date & "' AND DID = '" & DocID & "'"
        Dim dt As DataTable = Me.dbUtils.ExecuteQuery(sql)
        Dim e As TimeScheduleBLL() = New TimeScheduleBLL(dt.Rows.Count - 1) {}
        For i As Integer = 0 To e.GetUpperBound(0)
            e(i) = New TimeScheduleBLL(dt.Rows(i))
        Next
        Return e
    End Function

    Public Function RemoveSchedule(ByVal SID As Integer) As Boolean
        Dim strSql As String
        Try
            strSql = "DELETE FROM Schedule WHERE SID = " & SID & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function
#End Region
End Class
