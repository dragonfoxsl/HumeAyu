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

Public Class AdminBLL
    Private LoginDAL As New LoginDAL()
    Private AdminDAL As New AdminDAL()

#Region "constructors"
    Public Sub New()
        ' Default Constructor 
        Me.intAID = 0
    End Sub

    Public Sub New(ByVal LoginRow As DataRow)
        ' Constructor 
        Me.intAID = CInt(LoginRow("AID"))
        Me.strUNme = LoginRow("UNme").ToString()
        Me.strPass = LoginRow("Pass").ToString()
    End Sub

#End Region

#Region "Private Variables"

    Private dbUtils As New DatabaseUtils()
    Private intAID As Integer
    Private strUNme As String = ""
    Private strPass As String = ""
    Private strMsg As String = vbNullString

#End Region

#Region "Properties"

    Public Property AID() As Integer
        Get
            Return intAID
        End Get
        Set(ByVal value As Integer)
            intAID = value
        End Set
    End Property
    Public Property AUNme() As String
        Get
            Return strUNme
        End Get
        Set(ByVal value As String)
            strUNme = value
        End Set
    End Property
    Public Property APass() As String
        Get
            Return strPass
        End Get
        Set(ByVal value As String)
            strPass = value
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

    Public Sub getAdminLogin(ByVal UNme As String, ByVal Pass As String)
        Dim DoctorDataRow As DataRow = Me.LoginDAL.getAdminLogin(UNme, Pass)
        If DoctorDataRow Is Nothing Then
            strMsg = "Invalid Username or Password...!"
        Else
            Me.intAID = CInt(DoctorDataRow("AID"))
            Me.strUNme = DoctorDataRow("UNme").ToString()
            Me.strPass = DoctorDataRow("Pass").ToString()
        End If
    End Sub

    Public Function RemoveAdmin(ByVal AID As Integer) As Boolean
        Return AdminDAL.RemoveAdmin(AID)
    End Function
    Public Function AddAdmin() As Boolean
        Try
            AdminDAL.insertAdmin(Me)
            Return True
        Catch generatedExceptionName As Exception
            'throw e.Message; 
            Return False
        End Try
    End Function

    Public Function getAllAdmin() As AdminBLL()
        Return Me.AdminDAL.getAllAdmin()
    End Function
#End Region
End Class
