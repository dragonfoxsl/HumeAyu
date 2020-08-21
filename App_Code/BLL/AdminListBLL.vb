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

Public Class AdminListBLL

#Region "Private Members"
    Private _Admin As AdminBLL
    Private AdminDAL As New AdminDAL()
#End Region

#Region "Constructor"
    Public Sub New(ByVal Admin As AdminBLL)
        _Admin = Admin
    End Sub
#End Region

#Region "Public Properties"
    Public ReadOnly Property AID() As Integer
        Get
            Return _Admin.AID
        End Get
    End Property
    Public ReadOnly Property AUNme() As String
        Get
            Return _Admin.AUNme
        End Get
    End Property
    Public ReadOnly Property APass() As String
        Get
            Return _Admin.APass
        End Get
    End Property
    Public ReadOnly Property Message() As String
        Get
            Return _Admin.Message
        End Get
    End Property

#End Region

#Region "Methods"


#End Region
End Class
