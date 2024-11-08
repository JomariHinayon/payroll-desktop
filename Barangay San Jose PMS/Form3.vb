Imports Amazon.Runtime
Imports MongoDB.Driver

Public Class Form3
    Private Function GetNextEmployeeId() As Integer
        ' Open the collection to store the counter
        Dim counterCollection = conn.OpenCollectionCounters()
        Dim filter = Builders(Of Counters).Filter.Eq(Function(x) x.CounterName, "EmployeeID")
        Dim update = Builders(Of Counters).Update.Inc(Function(x) x.CounterValue, 1)
        Dim options = New FindOneAndUpdateOptions(Of Counters) With {.IsUpsert = True, .ReturnDocument = ReturnDocument.After}

        ' Find the current EmployeeID and increment it
        Dim result = counterCollection.FindOneAndUpdate(filter, update, options)

        ' If no counter exists, set initial value to 100
        If result Is Nothing Then
            Dim newCounter = New Counters With {
                .CounterName = "EmployeeID",
                .CounterValue = 100
            }
            counterCollection.InsertOne(newCounter)
            Return newCounter.CounterValue
        End If

        Return result.CounterValue
    End Function

    Private Function HashPassword(password1 As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(password1)
    End Function

    Private Function VerifyPassword(inputPassword As String, storedHash As String) As Boolean
        Return BCrypt.Net.BCrypt.Verify(inputPassword, storedHash)
    End Function

    Private Function StoreUser(username As String, password As String, Firstname As String, LastName As String) As Integer
        Dim conStore = conn.OpenCollectionUsers()
        Dim hashedPassword = HashPassword(password)
        Dim EmployeeID = GetNextEmployeeId()
        Dim Accounts = New Accounts With {
            .EmployeeIdNo = EmployeeID,
            .FirstName = Firstname,
            .LastName = LastName,
            .Username = username,
            .Password = hashedPassword}
        conStore.InsertOne(Accounts)
        Return EmployeeID
    End Function

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not ValidateInput() Then
            MessageBox.Show("Please fill in all fields: Username, First Name, Last Name, and Password.")
            Return
        End If

        Dim password = textPassword.Text
        Dim confirmPassword = textConPass.Text

        ' Check if passwords match
        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        Try
            ' Store the user and get the generated EmployeeID
            Dim generatedEmployeeID As Integer = StoreUser(textUsername.Text, password, textFirstName.Text, textLastName.Text)

            ' Show success message along with the generated EmployeeID
            MessageBox.Show("User registered successfully. Your Employee ID is: " & generatedEmployeeID.ToString())

        Catch ex As Exception
            MessageBox.Show("An error occurred during registration: " & ex.Message)
        End Try

        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            textPassword.UseSystemPasswordChar = False
            textConPass.UseSystemPasswordChar = False
        Else
            textPassword.UseSystemPasswordChar = True
            textConPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrEmpty(textUsername.Text) OrElse
           String.IsNullOrEmpty(textFirstName.Text) OrElse
           String.IsNullOrEmpty(textLastName.Text) OrElse
           String.IsNullOrEmpty(textPassword.Text) OrElse
           String.IsNullOrEmpty(textConPass.Text) Then
            Return False
        End If

        Return True
    End Function
End Class
