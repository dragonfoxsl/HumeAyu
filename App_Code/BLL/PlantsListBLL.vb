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

Public Class PlantsListBLL

#Region "Private Members"
    Private _Plant As PlantsBLL
    Private plantDAL As New PlantsDAL()
#End Region

#Region "Constructor"
    Public Sub New(ByVal plant As PlantsBLL)
        _Plant = plant
    End Sub
#End Region

#Region "Public Properties"

    Public ReadOnly Property PLID() As Integer
        Get
            Return _Plant.PLID
        End Get
    End Property
    Public ReadOnly Property PLNme() As String
        Get
            Return _Plant.PLNme
        End Get
    End Property
    Public ReadOnly Property PLBotnicalNme() As String
        Get
            Return _Plant.PLBotnicalNme
        End Get
    End Property
    Public ReadOnly Property PLDescription() As String
        Get
            Return _Plant.PLDescription
        End Get
    End Property
    Public ReadOnly Property PLImage() As String
        Get
            Return _Plant.PLImage
        End Get
    End Property
#End Region

#Region "Methods"


#End Region

End Class
