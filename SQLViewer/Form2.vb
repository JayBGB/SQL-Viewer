Imports System.Data.SqlClient

Public Class Form2

    Public Shared connection As SqlConnection

    Private Sub btnConnectToDatabase_Click(sender As Object, e As EventArgs) Handles btnConnectToDatabase.Click
        ' Check if any of the text boxes are empty
        If String.IsNullOrEmpty(txtDatabaseServer.Text) OrElse
           String.IsNullOrEmpty(txtDatabaseName.Text) OrElse
           String.IsNullOrEmpty(txtDatabaseUsername.Text) OrElse
           String.IsNullOrEmpty(txtDatabasePassword.Text) Then
            MessageBox.Show("Please fill in all four fields before connecting to the database.")
            Return ' Exit the method without proceeding further
        End If

        Database.databaseServer = txtDatabaseServer.Text
        Database.databaseName = txtDatabaseName.Text
        Database.databaseUsername = txtDatabaseUsername.Text
        Database.databasePassword = txtDatabasePassword.Text

        ' Save the inputted information to application settings
        My.Settings.txtDatabaseServer = Database.databaseServer
        My.Settings.txtDatabaseName = Database.databaseName
        My.Settings.txtDatabaseUsername = Database.databaseUsername
        My.Settings.txtDatabasePassword = Database.databasePassword
        My.Settings.Save() ' Save the settings

        Dim connectionString As String = "Server=" & Database.databaseServer & ";Database=" & Database.databaseName & ";User Id=" & Database.databaseUsername & ";Password=" & Database.databasePassword & ";"
        connection = New SqlConnection(connectionString)

        Try
            connection.Open()
            MessageBox.Show("Connected to " & Database.databaseName)
        Catch ex As Exception
            MessageBox.Show("Error connecting to the database: " & ex.Message)
            Return ' Exit the method if connection fails
        End Try

        Me.Hide()
        Form1.Show()
        connection.Close()
    End Sub

    'Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    '    If closeCheck() = True Then

    '        Application.Exit()

    '    Else

    '        e.Cancel = True

    '    End If

    'End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Application.Exit()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the last inputted information from application settings and set them as the text of the corresponding text boxes
        txtDatabaseServer.Text = My.Settings.txtDatabaseServer
        txtDatabaseName.Text = My.Settings.txtDatabaseName
        txtDatabaseUsername.Text = My.Settings.txtDatabaseUsername
        txtDatabasePassword.Text = My.Settings.txtDatabasePassword
    End Sub
End Class
