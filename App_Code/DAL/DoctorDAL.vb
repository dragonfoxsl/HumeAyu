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
Imports System.Data.SqlClient
Imports System.Collections
Imports DAL

Public Class DoctorDAL
    Private dbUtils As New DatabaseUtils()

#Region "Constructor"

    Public Sub New()

    End Sub

#End Region

#Region "Methods"

    Public Function getDoctor(ByVal DID As Integer) As DataRow
        Dim sql As String = "SELECT * FROM Doctor WHERE DID = " & DID
        Dim DoctorDataTable As DataTable = dbUtils.ExecuteQuery(sql)
        If DoctorDataTable.Rows.Count > 0 Then
            Return DoctorDataTable.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function insertDoctor(ByVal userObj As DoctorBLL) As Integer
        Dim strSql As String
        Try
            strSql = "INSERT INTO Doctor(DNme, Address, ContactNo, Email, Qualifications, Experience, Speciality, UNme, Pass, Img, Validity) VALUES('" & userObj.DName & "','" & userObj.DAddress & "','" & userObj.DContact & "','" & userObj.DEmail & "','" & userObj.DQualifications & "','" & userObj.DExperience & "','" & userObj.DSpecility & "','" & userObj.DUNme & "','" & userObj.DPass & "','" & userObj.DImage & "','No')"
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function getAllDoctor() As DoctorBLL()
        Dim sql As String = "SELECT * FROM Doctor ORDER BY DID ASC"
        Dim dt As DataTable = Me.dbUtils.ExecuteQuery(sql)
        Dim e As DoctorBLL() = New DoctorBLL(dt.Rows.Count - 1) {}
        For i As Integer = 0 To e.GetUpperBound(0)
            e(i) = New DoctorBLL(dt.Rows(i))
        Next
        Return e
    End Function

    Public Function saveDoctor(ByVal userObj As DoctorBLL) As Boolean
        Dim strSql As String
        Try
            strSql = "UPDATE Doctor SET DNme = '" & userObj.DName & "', Address = '" & userObj.DAddress & "', ContactNo = '" & userObj.DContact & "', Email = '" & userObj.DEmail & "', Qualifications = '" & userObj.DQualifications & "', Experience = '" & userObj.DExperience & "', Speciality  = '" & userObj.DSpecility & "', UNme = '" & userObj.DUNme & "', Pass = '" & userObj.DPass & "', Img = '" & userObj.DImage & "' WHERE DID =" & userObj.DID & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function UpdateValidity(ByVal userObj As DoctorBLL) As Boolean
        Dim strSql As String
        Try
            strSql = "UPDATE Doctor SET Validity = '" & userObj.DValidity & "' WHERE DID =" & userObj.DID & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try
    End Function

    Public Function RemoveDoctor(ByVal DID As Integer) As Boolean
        Dim strSql As String
        Try
            strSql = "DELETE FROM Doctor WHERE DID =" & DID & ""
            Return dbUtils.ExecuteCommand(strSql)
        Catch generatedExceptionName As Exception
            Throw
        End Try

    End Function

    Public Function getAllDoctorRep() As DataTable
        Dim sql As String = "SELECT * FROM Doctor ORDER BY DID ASC"
        Dim dt As DataTable = Me.dbUtils.ExecuteQuery(sql)
        Return dt
    End Function
#End Region
End Class
