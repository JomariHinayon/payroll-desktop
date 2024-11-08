Imports System.Drawing.Imaging
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text

Public Class Form7
    Private fingerprintHandler As New FingerprintHandler()

    Public Sub New()
        ' Initialize components and event handlers
        InitializeComponent()
        AddHandler fingerprintHandler.FingerprintCaptured, AddressOf OnFingerprintCaptured
        AddHandler fingerprintHandler.FingerprintReaderStatus, AddressOf OnFingerprintReaderStatus
    End Sub

    ' Event handler for the Capture Fingerprint button
    Private Sub BtnCaptureFingerprint_Click(sender As Object, e As EventArgs) Handles btnCaptureFingerprint.Click
        fingerprintHandler.StartCapture() ' Start the fingerprint capture process
    End Sub

    Private Sub OnFingerprintCaptured(ByVal fingerprintImage As Bitmap, ByVal templateBytes As Byte())
        ' Check if the fingerprint image is not null
        If fingerprintImage IsNot Nothing Then
            pbFingerprint.Image = fingerprintImage ' Set the captured fingerprint image to the PictureBox
            Me.FingerprintTemplateBytes = templateBytes ' Store the template bytes for later use
            MessageBox.Show("Fingerprint captured successfully and displayed.") ' Debug message
        Else
            MessageBox.Show("Captured fingerprint image is null.") ' Debug message
        End If

        fingerprintHandler.StopCapture() ' Stop capturing after a fingerprint is captured
    End Sub

    Private Sub OnFingerprintReaderStatus(ByVal message As String)
        MessageBox.Show(message)
    End Sub

    Private Function ConvertBitmapToByteArray(bitmap As Bitmap) As Byte()
        Using ms As New MemoryStream()
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp) ' Save as BMP
            Return ms.ToArray()
        End Using
    End Function

    ' Stores the employee data in MongoDB

    ' Helper function to convert an Image to a byte array
    Private Function ConvertImageToByteArray(image As Image) As Byte()
        Using ms As New IO.MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        End Using
    End Function
    Public Sub StoreUserWithFingerprint()
        Try
            ' Set up HttpClient
            Dim client As New HttpClient()

            client.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Token", GlobalVariables.Token)

            ' API URL for the custom create_with_user endpoint
            Dim apiUrl As String = "http://127.0.0.1:8000/api/employees/create_with_user/"

            ' Prepare user details
            Dim userData As New JObject From {
            {"username", txtFirstName.Text}, ' Assuming Employee ID as the username
            {"password", "your_secure_password_here"}, ' Replace with actual password logic
            {"first_name", txtFirstName.Text},
            {"last_name", txtLastName.Text},
            {"email", txtFirstName.Text + "@gmail.com"}
        }

            ' Prepare employee data including user details
            Dim genderCode As String = If(cbSex.Text = "Male", "M", "F")
            Dim jsonData As New JObject From {
            {"user", userData}, ' Embed user data here
            {"id_number", txtEmployeeID.Text},
            {"gender", genderCode}, ' Assuming cbSex.Text is "Male" or "Female"
            {"birth_date", txtBirthday.Value.ToString("yyyy-MM-dd")},
            {"hire_date", DateTime.Now.ToString("yyyy-MM-dd")},
            {"address", txtAddress.Text},
            {"phone_number", txtPhoneNum.Text},
            {"tel_number", txtTelNum.Text},
            {"salary", cbBasicRate.Text},
            {"is_active", True},
            {"sss_number", cbSSS.Text},
            {"position", New JObject From {{"title", cbPosition.Text}}},
            {"department", New JObject From {{"name", "IT"}}}
        }

            Console.WriteLine("JSON data to submit:")
            Console.WriteLine(jsonData.ToString())

            ' Prepare multipart form data content
            Using formContent As New MultipartFormDataContent()
                ' Add JSON data as a string content (without 'json_data' wrapping)
                Dim jsonContent As New StringContent(jsonData.ToString(), Encoding.UTF8, "application/json")
                formContent.Add(jsonContent, "json_data")

                ' Add profile image as a file
                If pbProfilePic.Image IsNot Nothing Then
                    Dim profilePicBytes = ConvertImageToByteArray(pbProfilePic.Image)
                    Dim profilePicContent As New ByteArrayContent(profilePicBytes)
                    profilePicContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg")
                    formContent.Add(profilePicContent, "profile_image", "profile_image.jpg")
                End If

                ' Add fingerprint if available
                If Me.FingerprintTemplateBytes IsNot Nothing Then
                    Dim fingerprintContent As New ByteArrayContent(Me.FingerprintTemplateBytes)
                    fingerprintContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/octet-stream")
                    formContent.Add(fingerprintContent, "fingerprint_file", "fingerprint_file.dat")
                End If

                ' Send POST request to API
                Dim response As HttpResponseMessage = client.PostAsync(apiUrl, formContent).Result
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("User data with fingerprint successfully saved to API!")
                Else
                    MessageBox.Show($"Error: {response.StatusCode} - {response.Content.ReadAsStringAsync().Result}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error sending data to API: " & ex.Message)
        End Try
    End Sub



    ' Validates that all required fields are filled
    Private Function ValidateInputs() As Boolean
        If String.IsNullOrEmpty(txtLastName.Text) OrElse
           String.IsNullOrEmpty(txtFirstName.Text) OrElse
           String.IsNullOrEmpty(txtMiddleName.Text) OrElse
           String.IsNullOrEmpty(txtEmployeeID.Text) OrElse
           String.IsNullOrEmpty(txtBirthday.Text) OrElse
           String.IsNullOrEmpty(txtAge.Text) OrElse
           String.IsNullOrEmpty(cbSex.Text) OrElse
           String.IsNullOrEmpty(cbStatus.Text) OrElse
           String.IsNullOrEmpty(txtAddress.Text) OrElse
           String.IsNullOrEmpty(txtPhoneNum.Text) OrElse
           String.IsNullOrEmpty(txtTelNum.Text) OrElse
           String.IsNullOrEmpty(cbPosition.Text) OrElse
           String.IsNullOrEmpty(cbBasicRate.Text) OrElse
           String.IsNullOrEmpty(cbSSS.Text) OrElse
           pbProfilePic.Image Is Nothing Then
            Return False
        End If
        ' pbFingerprint.Image Is Nothing Then
        ' Return False
        Return True
    End Function

    ' Saves the data when the Save button is clicked
    Public Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ValidateInputs() Then
            Try
                StoreUserWithFingerprint() ' Store user data along with fingerprint
                clearform() ' Clear the form after saving
                Form6.load_data()
            Catch ex As Exception
                MessageBox.Show("Error while saving: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please fill in all the required fields.")
        End If
    End Sub

    Private Sub clearform()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtEmployeeID.Clear()
        txtAge.Clear()
        txtAddress.Clear()
        txtPhoneNum.Clear()
        txtTelNum.Clear()

        ' Reset comboboxes
        cbSex.SelectedIndex = -1
        cbStatus.SelectedIndex = -1
        cbPosition.SelectedIndex = -1
        cbBasicRate.Clear()
        cbSSS.Clear()
    End Sub

    ' Opens a file dialog to select and load an image for the profile picture
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                pbProfilePic.Image = Image.FromFile(openFileDialog.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message)
        End Try
    End Sub

    ' Field to store fingerprint template bytes for later use
    Private FingerprintTemplateBytes As Byte()

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

End Class
