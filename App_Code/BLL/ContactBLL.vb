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

Public Class ContactBLL
    Private ContactDAL As New ContactDAL()

#Region "constructors"
    Public Sub New()
        ' Default Constructor 
        Me.intCID = 0
    End Sub

    Public Sub New(ByVal BookRow As DataRow)
        ' Constructor 
        Me.intCID = CInt(BookRow("BID"))
        Me.strUser = BookRow("Title").ToString()
        Me.strEmail = BookRow("Author").ToString()
        Me.strComment = BookRow("ISBN").ToString()
    End Sub
#End Region

#Region "Private Variables"

    Private dbUtils As New DatabaseUtils()
    Private intCID As Integer
    Private strUser As String
    Private strEmail As String
    Private strComment As String

#End Region

#Region "Properties"

    Public Property CID() As Integer
        Get
            Return intCID
        End Get
        Set(ByVal value As Integer)
            intCID = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return strUser
        End Get
        Set(ByVal value As String)
            strUser = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property

    Public Property Comment() As String
        Get
            Return strComment
        End Get
        Set(ByVal value As String)
            strComment = value
        End Set
    End Property


#End Region

#Region "Methods"

    Public Function Contact() As Boolean
        Try
            ContactDAL.AddComment(Me)
            Return True
        Catch generatedExceptionName As Exception
            'throw e.Message; 
            Return False
        End Try
    End Function

#End Region
End Class
