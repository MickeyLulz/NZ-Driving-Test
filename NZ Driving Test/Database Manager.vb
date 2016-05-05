Imports System.Data.SqlClient
Imports System.Data

Public Class Database_Manager
    Dim Sql As New SqlConnection("Data Source=shar;Initial Catalog=Mickey_2016;Integrated Security=True")
    Dim SqlStr As New SqlCommand
    Dim SqlReader As SqlDataReader
    Dim SqlStat As String

    Public Function QuestionDetails() As DataTable
        Dim dt As New DataTable

        Try
            SqlStr.Connection = Sql
            SqlStat = "Select * from NZDrivingTest"
            Using cmd = New SqlCommand(SqlStat, Sql)
                Sql.Open()
                SqlReader = cmd.ExecuteReader

                If SqlReader.HasRows Then
                    dt.Load(SqlReader)

                End If

                Sql.Close()

            End Using

        Catch ex As Exception
            Sql.Close()
            MsgBox("Error Occured: " & ex.Message)

        End Try

        Return dt

    End Function


End Class
