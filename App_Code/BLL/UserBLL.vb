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

Public Class UserBLL
    Private UserDAL As New UserDAL()

#Region "constructors"
    Public Sub New()
        ' Default Constructor 
        Me.intPID = 0
    End Sub

    Public Sub New(ByVal PatientRow As DataRow)
        ' Constructor 
        Me.intPID = CInt(PatientRow("PID"))
        Me.strFNme = PatientRow("FNme").ToString()
        Me.strLNme = PatientRow("LNme").ToString()
        Me.strAddress = PatientRow("Address").ToString()
        Me.strEmail = PatientRow("Email").ToString()
        Me.strContactNo = PatientRow("ContactNo").ToString()
        Me.dtDOB = PatientRow("DOB").ToString()
        Me.dtDOJ = PatientRow("DOJ").ToString()
        Me.strUNme = PatientRow("UNme").ToString()
        Me.strPass = PatientRow("Password").ToString()
    End Sub
#End Region

#Region "Private Variables"

    Private dbUtils As New DatabaseUtils()
    Private intPID As Integer
    Private strFNme As String
    Private strLNme As String
    Private strAddress As String
    Private strEmail As String
    Private strContactNo As String
    Private dtDOB As String
    Private dtDOJ As String
    Private strUNme As String
    Private strPass As String

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
    Public Property PFirstName() As String
        Get
            Return strFNme
        End Get
        Set(ByVal value As String)
            strFNme = value
        End Set
    End Property
    Public Property PLastName() As String
        Get
            Return strLNme
        End Get
        Set(ByVal value As String)
            strLNme = value
        End Set
    End Property
    Public Property PAddress() As String
        Get
            Return strAddress
        End Get
        Set(ByVal value As String)
            strAddress = value
        End Set
    End Property
    Public Property PEmail() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property
    Public Property PContact() As String
        Get
            Return strContactNo
        End Get
        Set(ByVal value As String)
            strContactNo = value
        End Set
    End Property
    Public Property PDOB() As String
        Get
            Return dtDOB
        End Get
        Set(ByVal value As String)
            dtDOB = value
        End Set
    End Property
    Public Property PDOJ() As String
        Get
            Return dtDOJ
        End Get
        Set(ByVal value As String)
            dtDOJ = value
        End Set
    End Property
    Public Property PUNme() As String
        Get
            Return strUNme
        End Get
        Set(ByVal value As String)
            strUNme = value
        End Set
    End Property
    Public Property PPass() As String
        Get
            Return strPass
        End Get
        Set(ByVal value As String)
            strPass = value
        End Set
    End Property

#End Region

#Region "Methods"

    Public Function RemovePatient(ByVal PID As Integer) As Boolean
        Return UserDAL.RemovePatient(PID)
    End Function
    Public Function AddPatient() As Boolean
        Try
            UserDAL.insertPatient(Me)
            Return True
        Catch generatedExceptionName As Exception
            'throw e.Message; 
            Return False
        End Try
    End Function

    Public Function getAllPatients() As UserBLL()
        Return Me.UserDAL.getAllPatient()
    End Function
    Public Sub getPatient(ByVal PID As Integer)
        Dim PatientDataRow As DataRow = Me.UserDAL.getPatient(PID)
        Me.intPID = CInt(PatientDataRow("PID"))
        Me.strFNme = PatientDataRow("FNme").ToString()
        Me.strLNme = PatientDataRow("LNme").ToString()
        Me.strAddress = PatientDataRow("Address").ToString()
        Me.strEmail = PatientDataRow("Email").ToString()
        Me.strContactNo = PatientDataRow("ContactNo").ToString()
        Me.dtDOB = PatientDataRow("DOB").ToString()
        Me.dtDOJ = PatientDataRow("DOJ").ToString()
        Me.strUNme = PatientDataRow("UNme").ToString()
        Me.strPass = PatientDataRow("Password").ToString()
    End Sub
    Public Function savePatient() As Boolean
        Return UserDAL.savePatient(Me)
    End Function

#End Region
End Class
