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

Public Class TimeScheduleBLL
    Private TSchedule As New TimeScheduleDAL()

#Region "constructors"
    Public Sub New()
        ' Default Constructor 
        Me.intCID = 0
    End Sub

    Public Sub New(ByVal PatientRow As DataRow)
        ' Constructor 
        Me.intCID = CInt(PatientRow("SID"))
        Me.intDID = CInt(PatientRow("DID"))
        Me.strCDate = PatientRow("Date").ToString()
        Me.strCTime = PatientRow("Time").ToString()
        Me.strNoPatient = PatientRow("NoPatients").ToString()
    End Sub
#End Region

#Region "Private Variables"

    Private dbUtils As New DatabaseUtils()
    Private intCID As Integer
    Private intDID As Integer
    Private strCDate As String
    Private strCTime As String
    Private strNoPatient As String

#End Region

#Region "Properties"

    Public Property SID() As Integer
        Get
            Return intCID
        End Get
        Set(ByVal value As Integer)
            intCID = value
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
    Public Property ChannelingDate() As String
        Get
            Return strCDate
        End Get
        Set(ByVal value As String)
            strCDate = value
        End Set
    End Property
    Public Property ChannelingTime() As String
        Get
            Return strCTime
        End Get
        Set(ByVal value As String)
            strCTime = value
        End Set
    End Property
    Public Property NoPatients() As String
        Get
            Return strNoPatient
        End Get
        Set(ByVal value As String)
            strNoPatient = value
        End Set
    End Property


#End Region

#Region "Methods"

    Public Function listTimes() As Hashtable
        Return TSchedule.listTimes()
    End Function

    Public Function RemoveSchedule(ByVal SID As Integer) As Boolean
        Return TSchedule.RemoveSchedule(SID)
    End Function
    Public Function AddSchedule() As Boolean
        Try
            TSchedule.insertTimeSchedule(Me)
            Return True
        Catch generatedExceptionName As Exception
            'throw e.Message; 
            Return False
        End Try
    End Function

    Public Sub set_PayType(ByVal strPay As String)
        TSchedule.setPayType(strPay)
    End Sub

    Public Function AddBooking() As Boolean
        Try
            TSchedule.insertBooking(Me)
            Return True
        Catch generatedExceptionName As Exception
            'throw e.Message; 
            Return False
        End Try
    End Function

    Public Function getAllSchedule() As TimeScheduleBLL()
        Return Me.TSchedule.getAllTimeSchedule()
    End Function


    Public Sub set_Date(ByVal strDate As String, ByVal DID As String)
        TSchedule.setDate(strDate, DID)
    End Sub

    Public Function getAllSchedule_Date() As TimeScheduleBLL()
        Return Me.TSchedule.getAllTimeSchedule_Date()
    End Function

    Public Sub getSchedule(ByVal SID As Integer)
        Dim ScheduleDataRow As DataRow = Me.TSchedule.getTimeSchedule(SID)
        Me.intCID = CInt(ScheduleDataRow("SID"))
        Me.intDID = ScheduleDataRow("DID").ToString()
        Me.strCDate = ScheduleDataRow("Date").ToString()
        Me.strCTime = ScheduleDataRow("Time").ToString()
        Me.strNoPatient = ScheduleDataRow("NoPatients").ToString()

    End Sub
    'Public Function savePatient() As Boolean
    '    Return UserDAL.savePatient(Me)
    'End Function

#End Region
End Class
