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

Public Class VideoBookingDAL
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

    Public Function getVBooking(ByVal DID As Integer, ByVal VDate As Integer) As DataRow
        Dim sql As String = "SELECT * FROM VideoBookings WHERE DID = " & DID & " AND PDate = '" & VDate & "'"
        Dim VBookingDataTable As DataTable = dbUtils.ExecuteQuery(sql)
        If VBookingDataTable.Rows.Count > 0 Then
            Return VBookingDataTable.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function insertVBooking(ByVal BookingObj As VideoBookingBLL) As Integer
        Dim strSql As String
        Try
            strSql = "INSERT INTO VideoBookings(DID, PID, PDate, PTime, PayT, Confirmed, ConfP) VALUES('" & BookingObj.DID & "','" & BookingObj.PID & "','" & BookingObj.PDate & "','" & BookingObj.PTime & "','" & BookingObj.PayT & "','No','No')"
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function getAllVBooking() As VideoBookingBLL()
        Dim sql As String = "SELECT * FROM VideoBookings ORDER BY VBID ASC"
        Dim dt As DataTable = Me.dbUtils.ExecuteQuery(sql)
        Dim e As VideoBookingBLL() = New VideoBookingBLL(dt.Rows.Count - 1) {}
        For i As Integer = 0 To e.GetUpperBound(0)
            e(i) = New VideoBookingBLL(dt.Rows(i))
        Next
        Return e
    End Function

    Public Function getAllVBookingDate() As VideoBookingBLL()
        Dim sql As String = "SELECT * FROM VideoBookings WHERE PDate = '" & SDate & "' AND DID = '" & DocID & "' ORDER BY VBID ASC"
        Dim dt As DataTable = Me.dbUtils.ExecuteQuery(sql)
        Dim e As VideoBookingBLL() = New VideoBookingBLL(dt.Rows.Count - 1) {}
        For i As Integer = 0 To e.GetUpperBound(0)
            e(i) = New VideoBookingBLL(dt.Rows(i))
        Next
        Return e
    End Function

    Public Function getAllVBookingPatient() As VideoBookingBLL()
        Dim sql As String = "SELECT * FROM VideoBookings WHERE PDate = '" & SDate & "' AND PID = '" & PID & "' ORDER BY VBID ASC"
        Dim dt As DataTable = Me.dbUtils.ExecuteQuery(sql)
        Dim e As VideoBookingBLL() = New VideoBookingBLL(dt.Rows.Count - 1) {}
        For i As Integer = 0 To e.GetUpperBound(0)
            e(i) = New VideoBookingBLL(dt.Rows(i))
        Next
        Return e
    End Function

    Public Function RemoveVBooking(ByVal SID As Integer) As Boolean
        Dim strSql As String
        Try
            strSql = "DELETE FROM VideoBookings WHERE VBID = " & SID & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function UpdateTime(ByVal VBookingObj As VideoBookingBLL) As Boolean
        Dim strSql As String
        Try
            strSql = "UPDATE VideoBookings SET Confirmed = '" & VBookingObj.Confirm & "', ConfTime = '" & VBookingObj.ConfTime & "' WHERE VBID =" & VBookingObj.VBID & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function UpdatePatientConf(ByVal VBookingObj As VideoBookingBLL) As Boolean
        Dim strSql As String
        Try
            strSql = "UPDATE VideoBookings SET ConfP = '" & VBookingObj.ConfP & "' WHERE VBID =" & VBookingObj.VBID & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Function getVBookingView(ByVal VBID As String) As DataRow
        Dim sql As String = "SELECT * FROM VideoBookings WHERE VBID = '" & VBID & "'"
        Dim VBookingDataTable As DataTable = dbUtils.ExecuteQuery(sql)
        If VBookingDataTable.Rows.Count > 0 Then
            Return VBookingDataTable.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Function getVBookingViewAll() As DataRow
        Dim sql As String = "SELECT * FROM VideoBookings"
        Dim VBookingDataTable As DataTable = dbUtils.ExecuteQuery(sql)
        If VBookingDataTable.Rows.Count > 0 Then
            Return VBookingDataTable.Rows(0)
        Else
            Return Nothing
        End If
    End Function
#End Region

End Class
