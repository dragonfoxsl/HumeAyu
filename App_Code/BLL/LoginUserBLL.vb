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

Public Class LoginUserBLL
    Private LoginDAL As New LoginDAL()

#Region "constructors"
    Public Sub New()
        ' Default Constructor 
        Me.intPID = 0
    End Sub

    Public Sub New(ByVal LoginRow As DataRow)
        ' Constructor 
        Me.intPID = CInt(LoginRow("PID"))
        Me.strFNme = LoginRow("FNme").ToString()
        Me.strLNme = LoginRow("LNme").ToString()
        Me.strPUNme = LoginRow("UNme").ToString()
        Me.strPPass = LoginRow("Password").ToString()
    End Sub

#End Region

#Region "Private Variables"

    Private dbUtils As New DatabaseUtils()
    Private intPID As Integer
    Private strFNme As String = ""
    Private strLNme As String = ""
    Private strPUNme As String = ""
    Private strPPass As String = ""
    Private strMsg As String = vbNullString

#End Region

#Region "Properties"

    Public Property PID() As Integer
        Get
            Return intPID
        End Get
        Set(ByVal value As Integer)
            intPID = value
        End Set
    End Property
    Public Property PFNme() As String
        Get
            Return strFNme
        End Get
        Set(ByVal value As String)
            strFNme = value
        End Set
    End Property
    Public Property PLNme() As String
        Get
            Return strLNme
        End Get
        Set(ByVal value As String)
            strLNme = value
        End Set
    End Property
    Public Property PUNme() As String
        Get
            Return strPUNme
        End Get
        Set(ByVal value As String)
            strPUNme = value
        End Set
    End Property
    Public Property PPass() As String
        Get
            Return strPPass
        End Get
        Set(ByVal value As String)
            strPPass = value
        End Set
    End Property

    Public Property Message() As String
        Get
            Return strMsg
        End Get
        Set(ByVal value As String)
            strMsg = value
        End Set
    End Property

#End Region

#Region "Methods"

    Public Sub getPatient(ByVal UNme As String, ByVal Pass As String)
        Dim PatientDataRow As DataRow = Me.LoginDAL.getPatientLogin(UNme, Pass)
        If PatientDataRow Is Nothing Then
            strMsg = "Invalid Username or Password...!"
        Else
            Me.intPID = CInt(PatientDataRow("PID"))
            Me.strFNme = PatientDataRow("FNme").ToString()
            Me.strLNme = PatientDataRow("LNme").ToString()
            Me.strPUNme = PatientDataRow("UNme").ToString()
            Me.strPPass = PatientDataRow("Password").ToString()
        End If
    End Sub

#End Region
End Class
