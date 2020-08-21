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

Public Class VideoBookingListBLL
#Region "Private Members"
    Private _VideoBooking As VideoBookingBLL
    Private VBookingDAL As New VideoBookingDAL()
#End Region

#Region "Constructor"
    Public Sub New(ByVal VBooking As VideoBookingBLL)
        _VideoBooking = VBooking
    End Sub
#End Region

#Region "Public Properties"
    Public ReadOnly Property VBID() As Integer
        Get
            Return _VideoBooking.VBID
        End Get
    End Property
    Public ReadOnly Property DID() As Integer
        Get
            Return _VideoBooking.DID
        End Get
    End Property
    Public ReadOnly Property PID() As Integer
        Get
            Return _VideoBooking.PID
        End Get
    End Property
    Public ReadOnly Property PDate() As String
        Get
            Return _VideoBooking.PDate
        End Get
    End Property
    Public ReadOnly Property PTime() As String
        Get
            Return _VideoBooking.PTime
        End Get
    End Property
    Public ReadOnly Property PayT() As String
        Get
            Return _VideoBooking.PayT
        End Get
    End Property
    Public ReadOnly Property Confirm() As String
        Get
            Return _VideoBooking.Confirm
        End Get
    End Property
    Public ReadOnly Property ConfTime() As String
        Get
            Return _VideoBooking.ConfTime
        End Get
    End Property
    Public ReadOnly Property ConfP() As String
        Get
            Return _VideoBooking.ConfP
        End Get
    End Property

#End Region

#Region "Methods"


#End Region
End Class
