Imports System.Net.Http
Imports MongoDB.Driver
Imports Newtonsoft.Json

Public Class Form6

    Public Shared Token As String = "c36507696160d41d8e7a5a731ae6f21ad1107380" ' Replace this with the actual token after login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form7.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub AttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.Click

        Me.Hide()
        Dim form8 As New Form8()
        form8.WindowState = Me.WindowState ' Set Form8's WindowState to the current form's WindowState
        form8.Size = Me.Size ' Optional: Set the size if the state is Normal
        form8.Location = Me.Location ' Optional: Set the location if the state is Normal

        form8.Show()
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click

        Me.Hide()
        Dim form5 As New Form5()
        form5.WindowState = Me.WindowState ' Set Form5's WindowState to the current form's WindowState
        form5.Size = Me.Size ' Optional: Set the size if the state is Normal
        form5.Location = Me.Location ' Optional: Set the location if the state is Normal

        form5.Show()
    End Sub


    Private Sub PayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollToolStripMenuItem.Click

        Me.Hide()
        Dim form10 As New Form10()
        form10.WindowState = Me.WindowState ' Set Form10's WindowState to the current form's WindowState
        form10.Size = Me.Size ' Optional: Set the size if the state is Normal
        form10.Location = Me.Location ' Optional: Set the location if the state is Normal

        form10.Show()
    End Sub

    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Await PopulateDataGridView()
    End Sub

    Private Async Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Await PopulateDataGridView()
    End Sub

    Public Sub load_data()
        ' Connect to MongoDB
        Dim client = New MongoClient(conn.Server)
        Dim db = client.GetDatabase(conn.Db)
        Dim collectionEmployee = db.GetCollection(Of Employee)(conn.collectionEmployee)

        ' Retrieve all employees (no filtering criteria for now)
        Dim filter = Builders(Of Employee).Filter.Empty

        ' Optionally exclude ProfilePic from the data to avoid loading images in the grid
        Dim projection = Builders(Of Employee).Projection.Exclude("ProfilePic").Exclude("Fingerprint")

        ' Fetch the list of employees and project the fields (excluding ProfilePic)
        Dim listEmployee = collectionEmployee.Find(filter).Project(Of Employee)(projection).ToList()
        DataGridView1.DataSource = listEmployee
    End Sub

    Private Async Function PopulateDataGridView() As Task
        ' Create HttpClient to send request
        Using client As New HttpClient()
            ' Add the Authorization header with the token
            client.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Token", GlobalVariables.Token)

            Try
                ' Send GET request to the attendance endpoint
                Dim response = Await client.GetAsync("http://127.0.0.1:8000/api/employees/")

                ' Check response status
                If response.IsSuccessStatusCode Then
                    ' Read response content
                    Dim jsonResponse = Await response.Content.ReadAsStringAsync()

                    Dim employeeList As List(Of EmployeeRecord) = JsonConvert.DeserializeObject(Of List(Of EmployeeRecord))(jsonResponse)

                    ' Clear existing rows in DataGridView
                    DataGridView1.Rows.Clear()

                    For Each record In employeeList
                        DataGridView1.Rows.Add(record.IdNumber, record.FullName, record.HireDate, record.address, record.department.name, record.position.title, record.PhoneNumber, record.salary)
                    Next
                Else
                    MessageBox.Show("Failed to load data: " & response.ReasonPhrase)
                End If
            Catch ex As Exception
                ' Log the error to the console
                Debug.WriteLine("An error occurred while fetching data: " & ex.Message)
                ' Optionally show the error message
                MessageBox.Show("An error occurred while fetching data. Check console for details.")
            End Try
        End Using
    End Function

    ' Class representing an employee record
    Private Class EmployeeRecord
        Public Property id As Integer

        ' Directly map the id_number to the property name
        <JsonProperty("id_number")>
        Public Property IdNumber As String

        ' Map the gender
        Public Property gender As String

        ' Map the birth date
        <JsonProperty("birth_date")>
        Public Property BirthDate As String

        ' Map the hire date
        <JsonProperty("hire_date")>
        Public Property HireDate As String

        ' Map the address
        Public Property address As String

        ' Nested department object
        <JsonProperty("department")>
        Public Property department As DepartmentRecord

        ' Nested position object
        <JsonProperty("position")>
        Public Property position As PositionRecord

        ' Map phone numbers
        <JsonProperty("phone_number")>
        Public Property PhoneNumber As String

        <JsonProperty("tel_number")>
        Public Property TelNumber As String

        ' Map salary
        Public Property salary As Decimal

        ' Map active status
        <JsonProperty("is_active")>
        Public Property IsActive As Boolean

        ' Map full name
        <JsonProperty("full_name")>
        Public Property FullName As String
    End Class

    ' Class representing the department record
    Private Class DepartmentRecord
        Public Property name As String
    End Class

    ' Class representing the position record
    Private Class PositionRecord
        Public Property title As String
    End Class

End Class