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

Public Class UserListBLL

#Region "Private Members"
    Private _Patient As UserBLL
    Private patientDAL As New UserDAL()
#End Region

#Region "Constructor"
    Public Sub New(ByVal patient As UserBLL)
        _Patient = patient
    End Sub
#End Region

#Region "Public Properties"
    Public ReadOnly Property PID() As Integer
        Get
            Return _Patient.PID
        End Get
    End Property
    Public ReadOnly Property PFirstName() As String
        Get
            Return _Patient.PFirstName
        End Get
    End Property
    Public ReadOnly Property PLastName() As String
        Get
            Return _Patient.PLastName
        End Get
    End Property
    Public ReadOnly Property PAddress() As String
        Get
            Return _Patient.PAddress
        End Get
    End Property
    Public ReadOnly Property PEmail() As String
        Get
            Return _Patient.PEmail
        End Get
    End Property
    Public ReadOnly Property PContact() As String
        Get
            Return _Patient.PContact
        End Get
    End Property
    Public ReadOnly Property PDOB() As String
        Get
            Return _Patient.PDOB
        End Get
    End Property
    Public ReadOnly Property PDOJ() As String
        Get
            Return _Patient.PDOJ
        End Get
    End Property
    Public ReadOnly Property PUNme() As String
        Get
            Return _Patient.PUNme
        End Get
    End Property
    Public ReadOnly Property PPass() As String
        Get
            Return _Patient.PPass
        End Get
    End Property
#End Region

#Region "Methods"


#End Region

End Class
