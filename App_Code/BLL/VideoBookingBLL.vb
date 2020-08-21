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

Public Class VideoBookingBLL
    Private VideoBokingsDAL As New VideoBookingDAL()

#Region "constructors"

    Public Sub New()
        ' Default Constructor 
        Me.intVBID = 0
    End Sub

    Public Sub New(ByVal VideoBookingRow As DataRow)
        ' Constructor 
        Me.intVBID = CInt(VideoBookingRow("VBID"))
        Me.intDID = CInt(VideoBookingRow("DID"))
        Me.intPID = CInt(VideoBookingRow("PID"))
        Me.strPDate = VideoBookingRow("PDate").ToString()
        Me.strPTime = VideoBookingRow("PTime").ToString()
        Me.strPayT = VideoBookingRow("PayT").ToString()
        Me.strConfirmed = VideoBookingRow("Confirmed").ToString()
        Me.strConfTime = VideoBookingRow("ConfTime").ToString()
        Me.strConfP = VideoBookingRow("ConfP").ToString()
    End Sub

#End Region

#Region "Private Variables"

    Private dbUtils As New DatabaseUtils()
    Private intVBID As Integer
    Private intDID As Integer
    Private intPID As Integer
    Private strPDate As String
    Private strPTime As String
    Private strPayT As String
    Private strConfirmed As String
    Private strConfTime As String
    Private strConfP As String

#End Region

#Region "Properties"

    Public Property VBID() As Integer
        Get
            Return intVBID
        End Get
        Set(ByVal value As Integer)
            intVBID = value
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
    Public Property PDate() As String
        Get
            Return strPDate
        End Get
        Set(ByVal value As String)
            strPDate = value
        End Set
    End Property
    Public Property PTime() As String
        Get
            Return strPTime
        End Get
        Set(ByVal value As String)
            strPTime = value
        End Set
    End Property
    Public Property PayT() As String
        Get
            Return strPayT
        End Get
        Set(ByVal value As String)
            strPayT = value
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
    Public Property ConfTime() As String
        Get
            Return strConfTime
        End Get
        Set(ByVal value As String)
            strConfTime = value
        End Set
    End Property
    Public Property ConfP() As String
        Get
            Return strConfP
        End Get
        Set(ByVal value As String)
            strConfP = value
        End Set
    End Property

#End Region

#Region "Methods"

    Public Function RemoveVideoBooking(ByVal VBID As Integer) As Boolean
        Return VideoBokingsDAL.RemoveVBooking(VBID)
    End Function
    Public Function AddVideoBooking() As Boolean
        Try
            VideoBokingsDAL.insertVBooking(Me)
            Return True
        Catch generatedExceptionName As Exception
            'throw e.Message; 
            Return False
        End Try
    End Function

    Public Function setDate(ByVal VDate As String, ByVal DID As String) As String
        Return VideoBokingsDAL.Variables(VDate, DID)
    End Function

    Public Function setPID(ByVal VDate As String, ByVal myPID As String) As String
        Return VideoBokingsDAL.SetDPID(VDate, myPID)
    End Function

    Public Function getAllVideoBooking() As VideoBookingBLL()
        Return Me.VideoBokingsDAL.getAllVBookingDate()
    End Function

    Public Sub getVideoBooking(ByVal DID As Integer, ByVal VDate As String)
        Dim VideoDataRow As DataRow = Me.VideoBokingsDAL.getVBooking(DID, VDate)
        Me.intVBID = CInt(VideoDataRow("VBID"))
        Me.intDID = CInt(VideoDataRow("DID"))
        Me.intPID = CInt(VideoDataRow("PID"))
        Me.strPDate = VideoDataRow("PDate").ToString()
        Me.strPTime = VideoDataRow("PTime").ToString()
        Me.strPayT = VideoDataRow("PayT").ToString()
        Me.strConfirmed = VideoDataRow("Confirmed").ToString()
        Me.strConfTime = VideoDataRow("ConfTime").ToString()
    End Sub

    Public Sub getVideoBookingView(ByVal VBID As String)
        Dim VideoDataRowView As DataRow = Me.VideoBokingsDAL.getVBookingView(VBID)
        Me.intPID = CInt(VideoDataRowView("PID"))
    End Sub

    Public Function UpdateConf() As Boolean
        Return VideoBokingsDAL.UpdateTime(Me)
    End Function

    Public Function UpdateConfCus() As Boolean
        Return VideoBokingsDAL.UpdatePatientConf(Me)
    End Function

    Public Function GetPatientSchedule() As VideoBookingBLL()
        Return Me.VideoBokingsDAL.getAllVBooking()
    End Function
#End Region



End Class
