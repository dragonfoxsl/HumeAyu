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


' General Database Connectivity and Database Functions

Namespace DAL
    Public Class DatabaseUtils
        Private DBConnectionStr As String

#Region "Constructor"

        Public Sub New()
            ' reads Connection string from .config file 
            Dim s As String = System.Configuration.ConfigurationSettings.AppSettings.[Get]("ConnectionString")
            If s Is Nothing Then
                Throw New NullReferenceException("ConnectionString settings not found in .config file.")
            End If

            'else 
            Me.DBConnectionStr = s
        End Sub

#End Region

#Region "Open/Close DB Connections"

        Private Function OpenConnection() As SqlConnection

            Dim cn As New SqlConnection(DBConnectionStr)
            cn.Open()

            Return cn
        End Function

        Private Sub CloseConnection(ByVal cn As SqlConnection)
            cn.Close()
            cn.Dispose()
        End Sub

        Public Function GetConnection() As SqlConnection
            Return Me.OpenConnection()
        End Function


#End Region

#Region "Execute General SQL statemenets"

        ' Execute SQL Command 
        Public Function ExecuteCommand(ByVal sCommand As String) As Boolean
            Dim cn As SqlConnection = Me.OpenConnection()
            Dim cmd As New SqlCommand(sCommand, cn)
            Dim ret As Integer = cmd.ExecuteNonQuery()
            cmd.Dispose()
            Me.CloseConnection(cn)

            Return (ret > 0)
        End Function


        'Execute Sql Query and return single value 
        Public Function ExecuteScalar(ByVal sQuery As String) As Object
            Dim cn As SqlConnection = Me.OpenConnection()
            Dim cmd As New SqlCommand(sQuery, cn)
            Dim o As Object = cmd.ExecuteScalar()
            cmd.Dispose()
            Me.CloseConnection(cn)

            If o = DBNull.Value.ToString() Then
                Return Nothing
            Else
                Return o
            End If
        End Function

        ' Execute Sql Query and return data table 
        Public Function ExecuteQuery(ByVal sQuery As String) As DataTable
            Dim cn As SqlConnection = Me.OpenConnection()
            Dim da As New SqlDataAdapter(sQuery, cn)
            Dim dt As New DataTable()
            da.Fill(dt)
            da.Dispose()
            Me.CloseConnection(cn)
            Return dt
        End Function

        ' Execute Sql Query and return data set 
        Public Function ExecuteQuery1(ByVal sQuery As String) As DataSet
            Dim cn As SqlConnection = Me.OpenConnection()
            Dim da As New SqlDataAdapter(sQuery, cn)
            Dim ds As New DataSet()
            da.Fill(ds)
            da.Dispose()
            Me.CloseConnection(cn)
            Return ds
        End Function



#End Region

#Region "Formatting for database field comparrisons when constructing SQL statements"

        ' returns a string enclosed in ' formatted correctly to be used in a SQL 
        ' eg: abc'def will return 'abc''def' 
        Public Function FormatStr(ByVal s As String) As String
            Return "'" & s.Replace("'", "''") & "'"
        End Function

        ' returns a date formatted correctly to be used in a SQL. 
        ' we convert the date to SQL date-format-type: 101 
        ' eg: Convert(datetime, '06/20/2003', 101) 
        Public Function FormatDate(ByVal d As DateTime) As String
            Return "Convert(datetime, '" & d.ToString("MM/dd/yyyy") & "', 101)"
        End Function

        ' returns a date-time formatted correctly to be used in a SQL 
        ' we convert the date to SQL date-format-type: 120 
        ' eg: Convert(datetime, '2003-06-20 14:15:16', 120) 
        Public Function FormatDateTime(ByVal d As DateTime) As String
            Return "Convert(datetime, '" & d.ToString("yyyy-MM-dd hh:mm:ss") & "', 120)"
        End Function

#End Region
    End Class
End Namespace
