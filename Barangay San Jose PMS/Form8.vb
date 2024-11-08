Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form8
    ' Assuming you have a global variable to store the token
    Public Shared Token As String = "c36507696160d41d8e7a5a731ae6f21ad1107380" ' Replace this with the actual token after login

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        Me.Hide()
        Form6.WindowState = Me.WindowState
        Form6.Size = Me.Size
        Form6.Location = Me.Location
        Form6.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollToolStripMenuItem.Click
        Me.Hide()
        Form10.WindowState = Me.WindowState
        Form10.Size = Me.Size
        Form10.Location = Me.Location
        Form10.Show()
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Me.Hide()
        Dim form5 As New Form5()
        form5.WindowState = Me.WindowState
        form5.Size = Me.Size
        form5.Location = Me.Location
        form5.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Handle cell click event if needed
    End Sub

    Private Async Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the DataGridView when the form loads
        Await PopulateDataGridView()
    End Sub

    Private Async Function PopulateDataGridView() As Task
        ' Create HttpClient to send request
        Using client As New HttpClient()
            ' Add the Authorization header with the token
            client.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Token", GlobalVariables.Token)

            Try
                ' Send GET request to the attendance endpoint
                Dim response = Await client.GetAsync("http://127.0.0.1:8000/api/attendance/")

                ' Check response status
                If response.IsSuccessStatusCode Then
                    ' Read response content
                    Dim jsonResponse = Await response.Content.ReadAsStringAsync()

                    ' Deserialize JSON to a list of attendance records
                    Dim attendanceList As List(Of AttendanceRecord) = JsonConvert.DeserializeObject(Of List(Of AttendanceRecord))(jsonResponse)

                    ' Clear existing rows in DataGridView
                    DataGridView1.Rows.Clear()

                    ' Populate DataGridView with attendance records
                    For Each record In attendanceList
                        DataGridView1.Rows.Add(record.StaffEmployee.id_number, record.StaffEmployee.full_name, record.attendanceDate, record.time_in, record.time_out, record.is_present)
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


    ' Define classes to represent the attendance record and employee
    Private Class AttendanceRecord
        Public Property id As Integer
        <JsonProperty("employee")>
        Public Property StaffEmployee As StaffMember
        <JsonProperty("date")>
        Public Property attendanceDate As String
        Public Property time_in As String
        Public Property time_out As String
        Public Property is_present As Boolean
        Public Property fingerprint_data As String
    End Class

    Private Class StaffMember
        Public Property id As Integer
        Public Property id_number As String
        Public Property full_name As String ' Ensure this property exists
    End Class

    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Await PopulateDataGridView()
    End Sub
End Class
