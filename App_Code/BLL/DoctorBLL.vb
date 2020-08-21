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

Public Class DoctorBLL
    Private DoctorDAL As New DoctorDAL()

#Region "constructors"

    Public Sub New()
        ' Default Constructor 
        Me.intDID = 0
    End Sub

    Public Sub New(ByVal DoctorRow As DataRow)
        ' Constructor 
        Me.intDID = CInt(DoctorRow("DID"))
        Me.strDNme = DoctorRow("DNme").ToString()
        Me.strAddress = DoctorRow("Address").ToString()
        Me.strContactNo = DoctorRow("ContactNo").ToString()
        Me.strEmail = DoctorRow("Email").ToString()
        Me.strQuali = DoctorRow("Qualifications").ToString()
        Me.strExp = DoctorRow("Experience").ToString()
        Me.strSpec = DoctorRow("Speciality").ToString()
        Me.strUNme = DoctorRow("UNme").ToString()
        Me.strPass = DoctorRow("Pass").ToString()
        Me.strImg = DoctorRow("Img").ToString()
        Me.strVal = DoctorRow("Validity").ToString()
    End Sub

#End Region

#Region "Private Variables"

    Private dbUtils As New DatabaseUtils()
    Private intDID As Integer
    Private strDNme As String
    Private strAddress As String
    Private strContactNo As String
    Private strEmail As String
    Private strQuali As String
    Private strExp As String
    Private strSpec As String
    Private strUNme As String
    Private strPass As String
    Private strImg As String
    Private strVal As String

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
    Public Property DName() As String
        Get
            Return strDNme
        End Get
        Set(ByVal value As String)
            strDNme = value
        End Set
    End Property
    Public Property DAddress() As String
        Get
            Return strAddress
        End Get
        Set(ByVal value As String)
            strAddress = value
        End Set
    End Property
    Public Property DContact() As String
        Get
            Return strContactNo
        End Get
        Set(ByVal value As String)
            strContactNo = value
        End Set
    End Property
    Public Property DEmail() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property
    Public Property DQualifications() As String
        Get
            Return strQuali
        End Get
        Set(ByVal value As String)
            strQuali = value
        End Set
    End Property
    Public Property DExperience() As String
        Get
            Return strExp
        End Get
        Set(ByVal value As String)
            strExp = value
        End Set
    End Property
    Public Property DSpecility() As String
        Get
            Return strSpec
        End Get
        Set(ByVal value As String)
            strSpec = value
        End Set
    End Property
    Public Property DUNme() As String
        Get
            Return strUNme
        End Get
        Set(ByVal value As String)
            strUNme = value
        End Set
    End Property
    Public Property DPass() As String
        Get
            Return strPass
        End Get
        Set(ByVal value As String)
            strPass = value
        End Set
    End Property
    Public Property DImage() As String
        Get
            Return strImg
        End Get
        Set(ByVal value As String)
            strImg = value
        End Set
    End Property
    Public Property DValidity() As String
        Get
            Return strVal
        End Get
        Set(ByVal value As String)
            strVal = value
        End Set
    End Property
#End Region

#Region "Methods"

    Public Function RemoveDoctor(ByVal DID As Integer) As Boolean
        Return DoctorDAL.RemoveDoctor(DID)
    End Function
    Public Function AddDoctor() As Boolean
        Try
            DoctorDAL.insertDoctor(Me)
            Return True
        Catch generatedExceptionName As Exception
            'throw e.Message; 
            Return False
        End Try
    End Function

    Public Function getAllDoctors() As DoctorBLL()
        Return Me.DoctorDAL.getAllDoctor()
    End Function

    Public Sub getDoctor(ByVal DID As Integer)
        Dim DoctorDataRow As DataRow = Me.DoctorDAL.getDoctor(DID)
        Me.intDID = CInt(DoctorDataRow("DID"))
        Me.strDNme = DoctorDataRow("DNme").ToString()
        Me.strAddress = DoctorDataRow("Address").ToString()
        Me.strContactNo = DoctorDataRow("ContactNo").ToString()
        Me.strEmail = DoctorDataRow("Email").ToString()
        Me.strQuali = DoctorDataRow("Qualifications").ToString()
        Me.strExp = DoctorDataRow("Experience").ToString()
        Me.strSpec = DoctorDataRow("Speciality").ToString()
        Me.strUNme = DoctorDataRow("UNme").ToString()
        Me.strPass = DoctorDataRow("Pass").ToString()
        Me.strImg = DoctorDataRow("Img").ToString()
        Me.strVal = DoctorDataRow("Validity").ToString()
    End Sub

    Public Function saveDoctor() As Boolean
        Return DoctorDAL.saveDoctor(Me)
    End Function

    Public Function UpdateValidity() As Boolean
        Return DoctorDAL.UpdateValidity(Me)
    End Function

#End Region

End Class
