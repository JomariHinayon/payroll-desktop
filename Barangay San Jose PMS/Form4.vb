
Imports MongoDB.Driver

Public Class Form4
    Private Function HashPassword(password As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(password)
    End Function
    Private Function SearchUser(username As String)

        Dim filter = Builders(Of Accounts).Filter.Eq(Of String)("Username", username)
        Dim userDoc = conn.OpenCollectionUsers.Find(filter).FirstOrDefault()

        If userDoc IsNot Nothing Then
            PopulateFields(userDoc)
            Return userDoc
        Else
            MessageBox.Show("User not found.")
            Return Nothing
        End If
    End Function

    Private Sub PopulateFields(userDoc As Accounts)
        textFirstname.Text = userDoc.FirstName
        textLastName.Text = userDoc.LastName
        textUsername.Text = userDoc.Username
        textEmployeeID.Text = userDoc.EmployeeIdNo
    End Sub

    Private Sub UpdatePassword(username As String, newPassword As String)
        Dim filter = Builders(Of Accounts).Filter.Eq(Of String)("Username", username)
        Dim update = Builders(Of Accounts).Update.Set(Of String)("Password", newPassword)

        conn.OpenCollectionUsers.UpdateOne(filter, update)
        MessageBox.Show("Password updated successfully.")
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrEmpty(textFirstname.Text) OrElse
           String.IsNullOrEmpty(textLastName.Text) OrElse
           String.IsNullOrEmpty(textEmployeeID.Text) OrElse
           String.IsNullOrEmpty(textUsername.Text) OrElse
           String.IsNullOrEmpty(textNewPassword.Text) OrElse
           String.IsNullOrEmpty(textConPass.Text) Then

            MessageBox.Show("Please fill in all fields.")
            Return False
        End If

        If textNewPassword.Text <> textConPass.Text Then
            MessageBox.Show("Passwords do not match.")
            Return False
        End If

        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ValidateInput() Then
            Return
        End If

        ' Hash the new password
        Dim hashedPassword As String = HashPassword(textNewPassword.Text)

        ' Find the user by username
        Dim filter = Builders(Of Accounts).Filter.Eq(Of String)("Username", textUsername.Text)
        Dim update = Builders(Of Accounts).Update.Set(Of String)("Password", hashedPassword)

        ' Update the password in MongoDB
        Try
            conn.OpenCollectionUsers.UpdateOne(filter, update)
            MessageBox.Show("Password updated successfully.")
            Form2.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the password: " & ex.Message)
        End Try
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If String.IsNullOrEmpty(textSearchUser.Text) Then
            MessageBox.Show("Please enter a username to search.")
            Return
        End If

        ' Call the SearchUser function to search for the user
        Dim userDoc = SearchUser(textSearchUser.Text)

        ' Check if the user was found (this is already handled in SearchUser)
        If userDoc IsNot Nothing Then
            PopulateFields(userDoc) ' This is redundant now since it's called in SearchUser
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class