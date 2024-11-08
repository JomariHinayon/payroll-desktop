Imports System.Net.Http
Imports Newtonsoft.Json
Public Class Form10

    Private Sub LogOutToolStripMuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub AttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.Click

        Me.Hide()
        Form8.WindowState = Me.WindowState ' Set Form8's WindowState to the current form's WindowState
        Form8.Size = Me.Size ' Optional: Set the size if the state is Normal
        Form8.Location = Me.Location ' Optional: Set the location if the state is Normal

        Form8.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click

        Me.Hide()
        Form6.WindowState = Me.WindowState ' Set Form6's WindowState to the current form's WindowState
        Form6.Size = Me.Size ' Optional: Set the size if the state is Normal
        Form6.Location = Me.Location ' Optional: Set the location if the state is Normal

        Form6.Show()
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click

        Me.Hide()
        Dim form5 As New Form5()
        form5.WindowState = Me.WindowState ' Set Form5's WindowState to the current form's WindowState
        form5.Size = Me.Size ' Optional: Set the size if the state is Normal
        form5.Location = Me.Location ' Optional: Set the location if the state is Normal

        form5.Show()
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulatePayrollDataGridView()
    End Sub


    Private Async Function PopulatePayrollDataGridView() As Task
        ' Create HttpClient to send request
        Using client As New HttpClient()
            ' Add the Authorization header with the token
            client.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Token", GlobalVariables.Token)

            Try
                ' Send GET request to the payroll endpoint
                Dim response = Await client.GetAsync("http://127.0.0.1:8000/api/payroll/")

                ' Check response status
                If response.IsSuccessStatusCode Then
                    ' Read response content
                    Dim jsonResponse = Await response.Content.ReadAsStringAsync()

                    ' Deserialize JSON to a list of payroll records
                    Dim payrollList As List(Of PayrollRecord) = JsonConvert.DeserializeObject(Of List(Of PayrollRecord))(jsonResponse)

                    ' Clear existing rows in DataGridView
                    DataGridView1.Rows.Clear()

                    ' Populate DataGridView with payroll records
                    For Each record In payrollList
                        ' Use values from the payroll record to populate DataGridView
                        DataGridView1.Rows.Add(record.Employee.full_name, record.start_date, record.end_date,
                                           record.deductions, record.allowances, record.bonuses, record.net_salary)
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

    ' Define classes to represent the payroll record and employee
    Private Class PayrollRecord
        Public Property id As Integer
        <JsonProperty("employee")>
        Public Property Employee As Employee
        Public Property start_date As String
        Public Property end_date As String
        Public Property deductions As Decimal
        Public Property allowances As Decimal
        Public Property bonuses As Decimal
        <JsonProperty("net_salary")>
        Public Property net_salary As Decimal
    End Class

    Private Class Employee
        Public Property id As Integer
        Public Property full_name As String ' Full name of the employee
    End Class


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PopulatePayrollDataGridView()
    End Sub
End Class