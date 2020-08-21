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

Public Class LoginDoctorBLL
    Private LoginDAL As New LoginDAL()

#Region "constructors"
    Public Sub New()
        ' Default Constructor 
        Me.intDID = 0
    End Sub

    Public Sub New(ByVal LoginRow As DataRow)
        ' Constructor 
        Me.intDID = CInt(LoginRow("DID"))
        Me.strDNme = LoginRow("DNme").ToString()
        Me.strDUNme = LoginRow("UNme").ToString()
        Me.strDPass = LoginRow("Pass").ToString()
    End Sub

#End Region

#Region "Private Variables"

    Private dbUtils As New DatabaseUtils()
    Private intDID As Integer
    Private strDNme As String = ""
    Private strDUNme As String = ""
    Private strDPass As String = ""
    Private strMsg As String = vbNullString

#End Region

#Region "Properties"

    Public Property DID() As Integer
        Get
            Return intDID
        End Get
        Set(ByVal value As Integer)
            intDID = value
        End Set
    End Property
    Public Property DNme() As String
        Get
            Return strDNme
        End Get
        Set(ByVal value As String)
            strDNme = value
        End Set
    End Property
    Public Property DUNme() As String
        Get
            Return strDUNme
        End Get
        Set(ByVal value As String)
            strDUNme = value
        End Set
    End Property
    Public Property DPass() As String
        Get
            Return strDPass
        End Get
        Set(ByVal value As String)
            strDPass = value
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

    Public Sub getDoctorLogin(ByVal UNme As String, ByVal Pass As String)
        Dim DoctorDataRow As DataRow = Me.LoginDAL.getDoctorLogin(UNme, Pass)
        If DoctorDataRow Is Nothing Then
            strMsg = "Invalid Username or Password...!"
        Else
            Me.intDID = CInt(DoctorDataRow("DID"))
            Me.strDNme = DoctorDataRow("DNme").ToString()
            Me.strDUNme = DoctorDataRow("UNme").ToString()
            Me.strDPass = DoctorDataRow("Pass").ToString()
        End If
    End Sub

#End Region
End Class
