Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MongoDB.Driver
Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text
Imports System.Net.Http.Json
Imports Newtonsoft.Json.Linq

Public Class Form2
    Private Function VerifyPassword(inputPassword As String, storedHash As String) As Boolean
        Return BCrypt.Net.BCrypt.Verify(inputPassword, storedHash)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form4.Show()
        Me.Hide()
    End Sub


    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username = IdNumText.Text
        Dim password = PasswordText.Text

        ' Create the request body
        Dim requestBody = New With {
        Key .username = username,
        Key .password = password
    }

        Dim json = JsonConvert.SerializeObject(requestBody)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        ' Create HttpClient to send request
        Using client As New HttpClient()
            Try
                Dim response = Await client.PostAsync("http://127.0.0.1:8000/api/admin/login/", content)

                If response.IsSuccessStatusCode Then
                    Dim responseData = Await response.Content.ReadAsStringAsync()

                    ' Parse the JSON response to get the token
                    Dim responseObject As JObject = JsonConvert.DeserializeObject(Of JObject)(responseData)
                    GlobalVariables.Token = responseObject("token").ToString() ' Store the token globally

                    MessageBox.Show("Login successful!")
                    Form5.Show()
                    Me.Close()
                    Form1.Hide()
                Else
                    MessageBox.Show("Invalid username or password.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred during login: " & ex.Message)
            End Try
        End Using
    End Sub




    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PasswordText.UseSystemPasswordChar = False
        Else
            PasswordText.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class