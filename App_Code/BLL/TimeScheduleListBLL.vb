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

Public Class TimeScheduleListBLL

#Region "Private Members"
    Private _TimeSchedule As TimeScheduleBLL
    Private TimeScheduleDAL As New TimeScheduleDAL()
#End Region

#Region "Constructor"
    Public Sub New(ByVal TimeSchedule As TimeScheduleBLL)
        _TimeSchedule = TimeSchedule
    End Sub
#End Region

#Region "Public Properties"
    Public ReadOnly Property SID() As Integer
        Get
            Return _TimeSchedule.SID
        End Get
    End Property
    Public ReadOnly Property DID() As String
        Get
            Return _TimeSchedule.DID
        End Get
    End Property
    Public ReadOnly Property ChannelingDate() As String
        Get
            Return _TimeSchedule.ChannelingDate
        End Get
    End Property
    Public ReadOnly Property ChannelingTime() As String
        Get
            Return _TimeSchedule.ChannelingTime
        End Get
    End Property
    Public ReadOnly Property NoPatients() As String
        Get
            Return _TimeSchedule.NoPatients
        End Get
    End Property

#End Region

#Region "Methods"


#End Region

End Class
