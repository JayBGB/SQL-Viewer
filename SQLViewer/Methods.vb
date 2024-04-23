Module Methods

    Public Function closeCheck() As Boolean

        ' Display a message box with a Yes and No button
        Dim result As DialogResult = MessageBox.Show("Do you want to close the app?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the result of the user's selection
        If result = DialogResult.Yes Then

            Return True
        Else

            Return False

        End If

    End Function

End Module
