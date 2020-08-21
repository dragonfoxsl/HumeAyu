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

Public Class DoctorListBLL

#Region "Private Members"
    Private _Doctor As DoctorBLL
    Private doctorDAL As New DoctorDAL()
#End Region

#Region "Constructor"
    Public Sub New(ByVal doctor As DoctorBLL)
        _Doctor = doctor
    End Sub
#End Region

#Region "Public Properties"
    Public ReadOnly Property DID() As Integer
        Get
            Return _Doctor.DID
        End Get
    End Property
    Public ReadOnly Property DName() As String
        Get
            Return _Doctor.DName
        End Get
    End Property
    Public ReadOnly Property DAddress() As String
        Get
            Return _Doctor.DAddress
        End Get
    End Property
    Public ReadOnly Property DContact() As String
        Get
            Return _Doctor.DContact
        End Get
    End Property
    Public ReadOnly Property DEmail() As String
        Get
            Return _Doctor.DEmail
        End Get
    End Property
    Public ReadOnly Property DQualifications() As String
        Get
            Return _Doctor.DQualifications
        End Get
    End Property
    Public ReadOnly Property DExperience() As String
        Get
            Return _Doctor.DExperience
        End Get
    End Property
    Public ReadOnly Property DSpecility() As String
        Get
            Return _Doctor.DSpecility
        End Get
    End Property
    Public ReadOnly Property DUNme() As String
        Get
            Return _Doctor.DUNme
        End Get
    End Property
    Public ReadOnly Property DPass() As String
        Get
            Return _Doctor.DPass
        End Get
    End Property
    Public ReadOnly Property DImage() As String
        Get
            Return _Doctor.DImage
        End Get
    End Property
    Public ReadOnly Property DValidity() As String
        Get
            Return _Doctor.DValidity
        End Get
    End Property
#End Region

#Region "Methods"


#End Region

End Class
