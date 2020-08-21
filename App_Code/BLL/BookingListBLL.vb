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

Public Class BookingListBLL

#Region "Private Members"
    Private _Booking As BookingBLL
    Private BookingDAL As New BookingDAL()
#End Region

#Region "Constructor"
    Public Sub New(ByVal Booking As BookingBLL)
        _Booking = Booking
    End Sub
#End Region

#Region "Public Properties"
    Public ReadOnly Property BIDT() As Integer
        Get
            Return _Booking.BIDT
        End Get
    End Property
    Public ReadOnly Property DID() As Integer
        Get
            Return _Booking.DID
        End Get
    End Property
    Public ReadOnly Property PID() As Integer
        Get
            Return _Booking.PID
        End Get
    End Property
    Public ReadOnly Property BDate() As String
        Get
            Return _Booking.BDate
        End Get
    End Property
    Public ReadOnly Property Time() As String
        Get
            Return _Booking.Time
        End Get
    End Property
    Public ReadOnly Property PayType() As String
        Get
            Return _Booking.PayType
        End Get
    End Property
    Public ReadOnly Property Confirm() As String
        Get
            Return _Booking.Confirm
        End Get
    End Property

#End Region

#Region "Methods"


#End Region

End Class
