Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub btnSelectFromDb_Click(sender As Object, e As EventArgs) Handles btnSelectFromDb.Click

        Form2.connection.Open()

        Dim tableName = InputBox("Enter the name of the table you want to query:")
        If tableName.Trim = "" Then
            MessageBox.Show("Please enter a valid table name.")
            Return
        End If

        Dim sql = "SELECT * FROM " & tableName
        Dim command As New SqlCommand(sql, Form2.connection)

        Try
            Dim reader = command.ExecuteReader
            Dim result As New Text.StringBuilder

            While reader.Read
                For i = 0 To reader.FieldCount - 1
                    result.Append(reader.GetName(i) & ": " & reader.GetValue(i).ToString)
                Next
                result.AppendLine()
            End While

            reader.Close()

            If result.Length = 0 Then
                MessageBox.Show("No records found in the table.")
            Else
                ShowResult(sql, Form2.connection)
            End If
        Catch ex As Exception
            MessageBox.Show("Error executing query: " & ex.Message)
        End Try

        Form2.connection.Close()
    End Sub

    Private Sub btnCustomSelectQuery_Click(sender As Object, e As EventArgs) Handles btnCustomSelectQuery.Click

        Form2.connection.Open()

        Dim sql As String = InputBox("Enter your query:")

        ' Check if the SQL string is empty
        If String.IsNullOrWhiteSpace(sql) Then
            MessageBox.Show("Please enter a valid query.")
            Return
        End If

        ' Convert the SQL string to uppercase and check if it starts with "SELECT"
        If Not sql.Trim().ToUpper().StartsWith("SELECT") Then
            MessageBox.Show("The query must start with 'SELECT'.")
            Return
        End If

        Dim command As New SqlCommand(sql, Form2.connection)

        Try
            Dim reader = command.ExecuteReader
            Dim result As New Text.StringBuilder

            While reader.Read
                For i = 0 To reader.FieldCount - 1
                    result.Append(reader.GetName(i) & ": " & reader.GetValue(i).ToString)
                Next
                result.AppendLine()
            End While

            reader.Close()

            If result.Length = 0 Then
                MessageBox.Show("No records found in the table.")
            Else
                ShowResult(sql, Form2.connection)
            End If
        Catch ex As Exception
            MessageBox.Show("Error executing query: " & ex.Message)
        End Try

        Form2.connection.Close()
    End Sub

    Private Sub btnUpdateQuery_Click(sender As Object, e As EventArgs) Handles btnUpdateQuery.Click

        Form2.connection.Open()
        'Dim userId As Integer = InputBox("Introduce your ID:")
        '' Check if the user has permission to execute the update query
        'If CheckPermission(userId) Then
        ' Prompt the user for the update query
        Dim sql = InputBox("Enter your UPDATE query:")

        ' Check if the SQL string is empty
        If String.IsNullOrWhiteSpace(sql) Then
            MessageBox.Show("Please enter a valid UPDATE query.")
            Return
        End If

        ' Convert the SQL string to uppercase and check if it starts with "UPDATE"
        If Not sql.Trim.ToUpper.StartsWith("UPDATE") Then
            MessageBox.Show("The query must start with 'UPDATE'.")
            Return
        End If

        Dim command As New SqlCommand(sql, Form2.connection)

        Try
            Dim rowsAffected = command.ExecuteNonQuery

            MessageBox.Show(rowsAffected & " rows updated successfully.")
        Catch ex As Exception
            MessageBox.Show("Error executing query: " & ex.Message)
        End Try
        'End If
        Form2.connection.Close()
    End Sub


    Private Sub btnClearTable_Click(sender As Object, e As EventArgs) Handles btnClearTable.Click

        queryScreen.DataSource = Nothing

    End Sub

    Private Sub btnAllowEdit_Click(sender As Object, e As EventArgs) Handles btnAllowEdit.Click

        If queryScreen.ReadOnly Then

            queryScreen.ReadOnly = False
            MessageBox.Show("The table is now editable.")

        Else

            queryScreen.ReadOnly = True
            MessageBox.Show("The table is now non-editable.")

        End If

    End Sub

    Private Sub btnDisconnectFromDB_Click(sender As Object, e As EventArgs) Handles btnDisconnectFromDB.Click
        Try
            Form2.connection.Close()
            MessageBox.Show("Disconnected from " & Database.databaseName)
        Catch ex As Exception
            MessageBox.Show("Error disconnecting from the database: " & ex.Message)

        End Try

        'If closeCheck() = True Then

        '    Application.Exit()

        'Else

        Me.Hide()
        Form2.Show()

        'End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblConnection.Text = "Connected to " & Database.databaseName
        'btnAllowEdit.Height = 60
        'btnAllowEdit.Width = 160
        'btnAllowEdit.Text = "Make Editable/Non Editable"
        'btnAllowEdit.Location = New Point(12, 210)






    End Sub

    'Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    Console.WriteLine("Form1_FormClosing called")
    '    If closeCheck() = True Then
    '        Application.Exit()
    '    Else
    '        e.Cancel = True
    '    End If
    'End Sub


    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.connection.Close()
        Application.Exit()
    End Sub

    Private Function ShowResult(command As String, connection As SqlConnection)
        Dim ds As New DataSet()
        Dim dataadapter As New SqlDataAdapter(command, connection)
        dataadapter.Fill(ds, "column_name")
        queryScreen.DataSource = ds
        queryScreen.DataMember = "column_name"
    End Function

    'Private Function CheckPermission(userId As Integer) As Boolean


    '    Dim sql = "SELECT UserAccessLevelId FROM Users WHERE UserAccessLevelId=" & userId
    '    Dim command As New SqlCommand(sql, Form2.connection)
    '    'Add parameter to the command to prevent SQL injection
    '    command.Parameters.AddWithValue("@UserId", userId)

    '    Dim reader As SqlDataReader = command.ExecuteReader()

    '    If reader.HasRows Then
    '        reader.Close() ' Close the DataReader before executing ExecuteScalar

    '        ' ExecuteScalar to get the userAccessLevelId
    '        Dim userAccessLevelId As Object = command.ExecuteScalar()

    '        If userAccessLevelId IsNot Nothing AndAlso userAccessLevelId = 2 Then
    '            Return True
    '        Else
    '            MessageBox.Show("You do not have permission to perform this action.")
    '            Return False
    '        End If
    '    Else
    '        MessageBox.Show("User not found.")
    '        Return False
    '    End If

    'End Function


End Class
