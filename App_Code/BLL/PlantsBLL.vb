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

Public Class PlantsBLL
    Private PlantDAL As New PlantsDAL()

#Region "constructors"
    Public Sub New()
        ' Default Constructor 
        Me.intPLID = 0
    End Sub

    Public Sub New(ByVal PlantRow As DataRow)
        ' Constructor 
        Me.intPLID = CInt(PlantRow("PLID"))
        Me.strPNme = PlantRow("PLNme").ToString()
        Me.strBotnicalNme = PlantRow("BotnicalNme").ToString()
        Me.strDes = PlantRow("Description").ToString()
        Me.strImage = PlantRow("Image").ToString()
    End Sub
#End Region

#Region "Private Variables"

    Private dbUtils As New DatabaseUtils()
    Private intPLID As Integer
    Private strPNme As String
    Private strBotnicalNme As String
    Private strDes As String
    Private strImage As String

#End Region

#Region "Properties"

    Public Property PLID() As Integer
        Get
            Return intPLID
        End Get
        Set(ByVal value As Integer)
            intPLID = value
        End Set
    End Property
    Public Property PLNme() As String
        Get
            Return strPNme
        End Get
        Set(ByVal value As String)
            strPNme = value
        End Set
    End Property
    Public Property PLBotnicalNme() As String
        Get
            Return strBotnicalNme
        End Get
        Set(ByVal value As String)
            strBotnicalNme = value
        End Set
    End Property
    Public Property PLDescription() As String
        Get
            Return strDes
        End Get
        Set(ByVal value As String)
            strDes = value
        End Set
    End Property
    Public Property PLImage() As String
        Get
            Return strImage
        End Get
        Set(ByVal value As String)
            strImage = value
        End Set
    End Property


#End Region

#Region "Methods"

    Public Function RemovePlant(ByVal PLID As Integer) As Boolean
        Return PlantDAL.RemovePlant(PLID)
    End Function
    Public Function AddPlant() As Boolean
        Try
            PlantDAL.insertPlant(Me)
            Return True
        Catch generatedExceptionName As Exception
            'throw e.Message; 
            Return False
        End Try
    End Function

    Public Function getAllPlants() As PlantsBLL()
        Return Me.PlantDAL.getAllPlant()
    End Function
    Public Sub getPlants(ByVal PLID As Integer)
        Dim PlantDataRow As DataRow = Me.PlantDAL.getPlant(PLID)
        Me.intPLID = CInt(PlantDataRow("PLID"))
        Me.strPNme = PlantDataRow("PLNme").ToString()
        Me.strBotnicalNme = PlantDataRow("BotnicalNme").ToString()
        Me.strDes = PlantDataRow("Description").ToString()
        Me.strImage = PlantDataRow("Image").ToString()
    End Sub
    Public Function savePlant() As Boolean
        Return PlantDAL.savePlant(Me)
    End Function

#End Region

End Class
