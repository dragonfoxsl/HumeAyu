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

Public Class BookingDAL
    Private dbUtils As New DatabaseUtils()
    Public Shared SDate, DocID, PID As String

#Region "Constructor"

    Public Sub New()

    End Sub

#End Region

#Region "Methods"
    Public Function SetDPID(ByVal VDate As String, ByVal MyPID As String) As String
        SDate = VDate
        PID = MyPID
        Return 0
    End Function

    Public Function Variables(ByVal VDate As String, ByVal DID As String) As String
        SDate = VDate
        DocID = DID
        Return 0
    End Function

    Public Function getBooking(ByVal DID As Integer, ByVal VDate As Integer) As DataRow
        Dim sql As String = "SELECT * FROM TimeBookings WHERE DID = " & DID & " AND Date = '" & VDate & "'"
        Dim BookingDataTable As DataTable = dbUtils.ExecuteQuery(sql)
        If BookingDataTable.Rows.Count > 0 Then
            Return BookingDataTable.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function insertBooking(ByVal BookingObj As BookingBLL) As Integer
        Dim strSql As String
        Try
            strSql = "INSERT INTO TimeBookings(DID, PID, Date, Time, PayType, ConfTime) VALUES('" & BookingObj.DID & "','" & BookingObj.PID & "','" & BookingObj.BDate & "','" & BookingObj.Time & "','" & BookingObj.PayType & "','No')"
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function getAllBooking() As BookingBLL()
        Dim sql As String = "SELECT * FROM TimeBookings ORDER BY BIDT ASC"
        Dim dt As DataTable = Me.dbUtils.ExecuteQuery(sql)
        Dim e As BookingBLL() = New BookingBLL(dt.Rows.Count - 1) {}
        For i As Integer = 0 To e.GetUpperBound(0)
            e(i) = New BookingBLL(dt.Rows(i))
        Next
        Return e
    End Function

    Public Function getAllBookingDate() As BookingBLL()
        Dim sql As String = "SELECT * FROM TimeBookings WHERE Date = '" & SDate & "' AND DID = '" & DocID & "' ORDER BY BIDT ASC"
        Dim dt As DataTable = Me.dbUtils.ExecuteQuery(sql)
        Dim e As BookingBLL() = New BookingBLL(dt.Rows.Count - 1) {}
        For i As Integer = 0 To e.GetUpperBound(0)
            e(i) = New BookingBLL(dt.Rows(i))
        Next
        Return e
    End Function

    Public Function getAllBookingPatients() As BookingBLL()
        Dim sql As String = "SELECT * FROM TimeBookings WHERE Date = '" & SDate & "' AND PID = '" & PID & "' ORDER BY BIDT ASC"
        Dim dt As DataTable = Me.dbUtils.ExecuteQuery(sql)
        Dim e As BookingBLL() = New BookingBLL(dt.Rows.Count - 1) {}
        For i As Integer = 0 To e.GetUpperBound(0)
            e(i) = New BookingBLL(dt.Rows(i))
        Next
        Return e
    End Function

    Public Function RemoveBooking(ByVal SID As Integer) As Boolean
        Dim strSql As String
        Try
            strSql = "DELETE FROM TimeBookings WHERE BIDT = " & SID & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function UpdateTime(ByVal BookingObj As BookingBLL) As Boolean
        Dim strSql As String
        Try
            strSql = "UPDATE TimeBookings SET ConfTime = '" & BookingObj.Confirm & "' WHERE BIDT =" & BookingObj.BIDT & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Function getBookingView(ByVal BIDT As String) As DataRow
        Dim sql As String = "SELECT * FROM TimeBookings WHERE BIDT = '" & BIDT & "'"
        Dim BookingDataTable As DataTable = dbUtils.ExecuteQuery(sql)
        If BookingDataTable.Rows.Count > 0 Then
            Return BookingDataTable.Rows(0)
        Else
            Return Nothing
        End If
    End Function

#End Region


End Class
