<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form7))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtLastName = New TextBox()
        txtFirstName = New TextBox()
        Label5 = New Label()
        txtMiddleName = New TextBox()
        Label6 = New Label()
        txtAge = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        cbStatus = New ComboBox()
        Label10 = New Label()
        txtAddress = New TextBox()
        Label11 = New Label()
        txtPhoneNum = New TextBox()
        Label12 = New Label()
        txtTelNum = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        cbPosition = New ComboBox()
        Label15 = New Label()
        Label16 = New Label()
        Label19 = New Label()
        pbProfilePic = New PictureBox()
        Label20 = New Label()
        pbFingerprint = New PictureBox()
        BtnSave = New Button()
        Label21 = New Label()
        Label22 = New Label()
        txtEmployeeID = New TextBox()
        Button3 = New Button()
        Button1 = New Button()
        cbSex = New ComboBox()
        Button2 = New Button()
        btnCaptureFingerprint = New Button()
        Label7 = New Label()
        txtBirthday = New DateTimePicker()
        cbBasicRate = New TextBox()
        cbSSS = New TextBox()
        CType(pbProfilePic, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbFingerprint, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Unicode", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(33, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 23)
        Label1.TabIndex = 0
        Label1.Text = "Add new Employee"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(33, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 17)
        Label2.TabIndex = 1
        Label2.Text = "Last Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Info
        Label3.Location = New Point(33, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(227, 17)
        Label3.TabIndex = 2
        Label3.Text = "Employee personal information:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(348, 81)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 17)
        Label4.TabIndex = 3
        Label4.Text = "First Name:"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(120, 80)
        txtLastName.Margin = New Padding(3, 2, 3, 2)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(224, 23)
        txtLastName.TabIndex = 4
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(438, 81)
        txtFirstName.Margin = New Padding(3, 2, 3, 2)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(224, 23)
        txtFirstName.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(666, 84)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 17)
        Label5.TabIndex = 6
        Label5.Text = "Middle Name:"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(774, 81)
        txtMiddleName.Margin = New Padding(3, 2, 3, 2)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(224, 23)
        txtMiddleName.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(394, 164)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 17)
        Label6.TabIndex = 8
        Label6.Text = "Age:"
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(438, 164)
        txtAge.Margin = New Padding(3, 2, 3, 2)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(105, 23)
        txtAge.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(33, 206)
        Label8.Name = "Label8"
        Label8.Size = New Size(37, 17)
        Label8.TabIndex = 13
        Label8.Text = "Sex:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(33, 242)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 17)
        Label9.TabIndex = 16
        Label9.Text = "Status:"
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Single", "Married", "Widow"})
        cbStatus.Location = New Point(120, 242)
        cbStatus.Margin = New Padding(3, 2, 3, 2)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(224, 23)
        cbStatus.TabIndex = 17
        cbStatus.Text = "Single"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(33, 279)
        Label10.Name = "Label10"
        Label10.Size = New Size(68, 17)
        Label10.TabIndex = 18
        Label10.Text = "Address:"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(120, 279)
        txtAddress.Margin = New Padding(3, 2, 3, 2)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(541, 23)
        txtAddress.TabIndex = 19
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(36, 320)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 17)
        Label11.TabIndex = 20
        Label11.Text = "Phone Number:"
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Location = New Point(188, 320)
        txtPhoneNum.Margin = New Padding(3, 2, 3, 2)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(224, 23)
        txtPhoneNum.TabIndex = 21
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(438, 320)
        Label12.Name = "Label12"
        Label12.Size = New Size(96, 17)
        Label12.TabIndex = 22
        Label12.Text = "Tel. Number:"
        ' 
        ' txtTelNum
        ' 
        txtTelNum.Location = New Point(536, 317)
        txtTelNum.Margin = New Padding(3, 2, 3, 2)
        txtTelNum.Name = "txtTelNum"
        txtTelNum.Size = New Size(224, 23)
        txtTelNum.TabIndex = 23
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = SystemColors.Info
        Label13.Location = New Point(41, 353)
        Label13.Name = "Label13"
        Label13.Size = New Size(134, 19)
        Label13.TabIndex = 24
        Label13.Text = "Other Information:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(36, 392)
        Label14.Name = "Label14"
        Label14.Size = New Size(67, 17)
        Label14.TabIndex = 25
        Label14.Text = "Position:"
        ' 
        ' cbPosition
        ' 
        cbPosition.FormattingEnabled = True
        cbPosition.Items.AddRange(New Object() {"Sangguniang Barangay", "Punong Barangay", "Sangguniang Kabataan", "Barangay secretary", "Barangay treasurer"})
        cbPosition.Location = New Point(188, 388)
        cbPosition.Margin = New Padding(3, 2, 3, 2)
        cbPosition.Name = "cbPosition"
        cbPosition.Size = New Size(218, 23)
        cbPosition.TabIndex = 26
        cbPosition.Text = "IT"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(36, 479)
        Label15.Name = "Label15"
        Label15.Size = New Size(36, 17)
        Label15.TabIndex = 27
        Label15.Text = "SSS:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(33, 436)
        Label16.Name = "Label16"
        Label16.Size = New Size(80, 17)
        Label16.TabIndex = 28
        Label16.Text = "Basic Rate:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label19.Location = New Point(448, 422)
        Label19.Name = "Label19"
        Label19.Size = New Size(56, 17)
        Label19.TabIndex = 35
        Label19.Text = "Profile:"
        ' 
        ' pbProfilePic
        ' 
        pbProfilePic.Location = New Point(518, 422)
        pbProfilePic.Margin = New Padding(3, 2, 3, 2)
        pbProfilePic.Name = "pbProfilePic"
        pbProfilePic.Size = New Size(118, 110)
        pbProfilePic.SizeMode = PictureBoxSizeMode.StretchImage
        pbProfilePic.TabIndex = 36
        pbProfilePic.TabStop = False
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label20.Location = New Point(658, 422)
        Label20.Name = "Label20"
        Label20.Size = New Size(52, 17)
        Label20.TabIndex = 37
        Label20.Text = "Finger"
        ' 
        ' pbFingerprint
        ' 
        pbFingerprint.Location = New Point(718, 422)
        pbFingerprint.Margin = New Padding(3, 2, 3, 2)
        pbFingerprint.Name = "pbFingerprint"
        pbFingerprint.Size = New Size(118, 110)
        pbFingerprint.SizeMode = PictureBoxSizeMode.StretchImage
        pbFingerprint.TabIndex = 38
        pbFingerprint.TabStop = False
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.IndianRed
        BtnSave.Location = New Point(774, 536)
        BtnSave.Margin = New Padding(3, 2, 3, 2)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(101, 30)
        BtnSave.TabIndex = 39
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label21.Location = New Point(664, 439)
        Label21.Name = "Label21"
        Label21.Size = New Size(41, 19)
        Label21.TabIndex = 40
        Label21.Text = "print:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label22.Location = New Point(33, 124)
        Label22.Name = "Label22"
        Label22.Size = New Size(123, 17)
        Label22.TabIndex = 41
        Label22.Text = "Employee ID No.:"
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(188, 121)
        txtEmployeeID.Margin = New Padding(3, 2, 3, 2)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(224, 23)
        txtEmployeeID.TabIndex = 42
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.IndianRed
        Button3.Location = New Point(879, 536)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(176, 30)
        Button3.TabIndex = 43
        Button3.Text = "Create Account"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Lucida Console", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(964, 9)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 26)
        Button1.TabIndex = 45
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' cbSex
        ' 
        cbSex.FormattingEnabled = True
        cbSex.Items.AddRange(New Object() {"Male", "Female", "Other"})
        cbSex.Location = New Point(120, 205)
        cbSex.Margin = New Padding(3, 2, 3, 2)
        cbSex.Name = "cbSex"
        cbSex.Size = New Size(224, 23)
        cbSex.TabIndex = 46
        cbSex.Text = "Male"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(545, 536)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 48
        Button2.Text = "Upload"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnCaptureFingerprint
        ' 
        btnCaptureFingerprint.Location = New Point(745, 508)
        btnCaptureFingerprint.Name = "btnCaptureFingerprint"
        btnCaptureFingerprint.Size = New Size(75, 23)
        btnCaptureFingerprint.TabIndex = 49
        btnCaptureFingerprint.Text = "Capture"
        btnCaptureFingerprint.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(33, 164)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 17)
        Label7.TabIndex = 11
        Label7.Text = "Birthday:"
        ' 
        ' txtBirthday
        ' 
        txtBirthday.Location = New Point(120, 164)
        txtBirthday.Name = "txtBirthday"
        txtBirthday.Size = New Size(200, 23)
        txtBirthday.TabIndex = 50
        ' 
        ' cbBasicRate
        ' 
        cbBasicRate.Location = New Point(188, 430)
        cbBasicRate.Margin = New Padding(3, 2, 3, 2)
        cbBasicRate.Name = "cbBasicRate"
        cbBasicRate.Size = New Size(218, 23)
        cbBasicRate.TabIndex = 51
        cbBasicRate.Text = "20000"
        ' 
        ' cbSSS
        ' 
        cbSSS.Location = New Point(188, 479)
        cbSSS.Margin = New Padding(3, 2, 3, 2)
        cbSSS.Name = "cbSSS"
        cbSSS.Size = New Size(218, 23)
        cbSSS.TabIndex = 52
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(1060, 572)
        Controls.Add(cbSSS)
        Controls.Add(cbBasicRate)
        Controls.Add(txtBirthday)
        Controls.Add(btnCaptureFingerprint)
        Controls.Add(Button2)
        Controls.Add(cbSex)
        Controls.Add(Button1)
        Controls.Add(Button3)
        Controls.Add(txtEmployeeID)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(BtnSave)
        Controls.Add(pbFingerprint)
        Controls.Add(Label20)
        Controls.Add(pbProfilePic)
        Controls.Add(Label19)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(cbPosition)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(txtTelNum)
        Controls.Add(Label12)
        Controls.Add(txtPhoneNum)
        Controls.Add(Label11)
        Controls.Add(txtAddress)
        Controls.Add(Label10)
        Controls.Add(cbStatus)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtAge)
        Controls.Add(Label6)
        Controls.Add(txtMiddleName)
        Controls.Add(Label5)
        Controls.Add(txtFirstName)
        Controls.Add(txtLastName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add new Employee form"
        CType(pbProfilePic, ComponentModel.ISupportInitialize).EndInit()
        CType(pbFingerprint, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTelNum As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbPosition As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents pbProfilePic As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents pbFingerprint As PictureBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cbSex As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCaptureFingerprint As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBirthday As DateTimePicker
    Friend WithEvents cbBasicRate As TextBox
    Friend WithEvents cbSSS As TextBox
End Class
