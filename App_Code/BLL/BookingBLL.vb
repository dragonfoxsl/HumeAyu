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

Public Class BookingBLL

    Private BookingsDAL As New BookingDAL()

#Region "constructors"

    Public Sub New()
        ' Default Constructor 
        Me.intBIDT = 0
    End Sub

    Public Sub New(ByVal BookingRow As DataRow)
        ' Constructor 
        Me.intBIDT = CInt(BookingRow("BIDT"))
        Me.intDID = CInt(BookingRow("DID"))
        Me.intPID = CInt(BookingRow("PID"))
        Me.strDate = BookingRow("Date").ToString()
        Me.strTime = BookingRow("Time").ToString()
        Me.strPayType = BookingRow("PayType").ToString()
        Me.strConfirmed = BookingRow("ConfTime").ToString()

    End Sub

#End Region

#Region "Private Variables"

    Private dbUtils As New DatabaseUtils()
    Private intBIDT As Integer
    Private intDID As Integer
    Private intPID As Integer
    Private strDate As String
    Private strTime As String
    Private strPayType As String
    Private strConfirmed As String

#End Region

#Region "Properties"

    Public Property BIDT() As Integer
        Get
            Return intBIDT
        End Get
        Set(ByVal value As Integer)
            intBIDT = value
        End Set
    End Property
    Public Property DID() As Integer
        Get
            Return intDID
        End Get
        Set(ByVal value As Integer)
            intDID = value
        End Set
    End Property
    Public Property PID() As Integer
        Get
            Return intPID
        End Get
        Set(ByVal value As Integer)
            intPID = value
        End Set
    End Property
    Public Property BDate() As String
        Get
            Return strDate
        End Get
        Set(ByVal value As String)
            strDate = value
        End Set
    End Property
    Public Property Time() As String
        Get
            Return strTime
        End Get
        Set(ByVal value As String)
            strTime = value
        End Set
    End Property
    Public Property PayType() As String
        Get
            Return strPayType
        End Get
        Set(ByVal value As String)
            strPayType = value
        End Set
    End Property
    Public Property Confirm() As String
        Get
            Return strConfirmed
        End Get
        Set(ByVal value As String)
            strConfirmed = value
        End Set
    End Property

#End Region

#Region "Methods"

    Public Function RemoveBooking(ByVal BIDT As Integer) As Boolean
        Return BookingsDAL.RemoveBooking(BIDT)
    End Function
    Public Function AddBooking() As Boolean
        Try
            BookingsDAL.insertBooking(Me)
            Return True
        Catch generatedExceptionName As Exception
            'throw e.Message; 
            Return False
        End Try
    End Function

    Public Function setDate(ByVal VDate As String, ByVal DID As String) As String
        Return BookingsDAL.Variables(VDate, DID)
    End Function

    Public Function setPID(ByVal VDate As String, ByVal PID As String) As String
        Return BookingsDAL.SetDPID(VDate, PID)
    End Function

    Public Function getAllVideoBooking() As BookingBLL()
        Return Me.BookingsDAL.getAllBookingDate()
    End Function

    Public Function getAllVideoBookingAdmin() As BookingBLL()
        Return Me.BookingsDAL.getAllBooking()
    End Function

    Public Function getAllVideoBookingPatients() As BookingBLL()
        Return Me.BookingsDAL.getAllBookingPatients()
    End Function

    Public Sub getBooking(ByVal DID As Integer, ByVal VDate As String)
        Dim BookingDataRow As DataRow = Me.BookingsDAL.getBooking(DID, VDate)
        Me.intBIDT = CInt(BookingDataRow("BIDT"))
        Me.intDID = CInt(BookingDataRow("DID"))
        Me.intPID = CInt(BookingDataRow("PID"))
        Me.strDate = BookingDataRow("Date").ToString()
        Me.strTime = BookingDataRow("Time").ToString()
        Me.strPayType = BookingDataRow("PayType").ToString()
        Me.strConfirmed = BookingDataRow("ConfTime").ToString()
    End Sub

    Public Sub getBookingView(ByVal BIDT As String)
        Dim VideoDataRowView As DataRow = Me.BookingsDAL.getBookingView(BIDT)
        Me.intPID = CInt(VideoDataRowView("PID"))
    End Sub

    Public Function UpdateConf() As Boolean
        Return BookingsDAL.UpdateTime(Me)
    End Function
#End Region

End Class
