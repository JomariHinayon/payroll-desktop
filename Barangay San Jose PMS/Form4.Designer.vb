<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        Label1 = New Label()
        Label2 = New Label()
        textSearchUser = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        textFirstname = New TextBox()
        textLastName = New TextBox()
        textEmployeeID = New TextBox()
        textUsername = New TextBox()
        textNewPassword = New TextBox()
        textConPass = New TextBox()
        Button1 = New Button()
        Label9 = New Label()
        Button2 = New Button()
        SearchBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(10, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 19)
        Label1.TabIndex = 0
        Label1.Text = "Forgot Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(21, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 18)
        Label2.TabIndex = 1
        Label2.Text = "Search username:"
        ' 
        ' textSearchUser
        ' 
        textSearchUser.Location = New Point(184, 100)
        textSearchUser.Margin = New Padding(3, 2, 3, 2)
        textSearchUser.Name = "textSearchUser"
        textSearchUser.Size = New Size(125, 23)
        textSearchUser.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(24, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 18)
        Label3.TabIndex = 3
        Label3.Text = "First Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(24, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 18)
        Label4.TabIndex = 4
        Label4.Text = "Last Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(25, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 18)
        Label5.TabIndex = 5
        Label5.Text = "Employee ID No.:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(29, 244)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 18)
        Label6.TabIndex = 6
        Label6.Text = "Username:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(24, 278)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 18)
        Label7.TabIndex = 7
        Label7.Text = "New Password:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(25, 312)
        Label8.Name = "Label8"
        Label8.Size = New Size(147, 18)
        Label8.TabIndex = 8
        Label8.Text = "Confirm Password:"
        ' 
        ' textFirstname
        ' 
        textFirstname.Location = New Point(184, 144)
        textFirstname.Margin = New Padding(3, 2, 3, 2)
        textFirstname.Name = "textFirstname"
        textFirstname.Size = New Size(215, 23)
        textFirstname.TabIndex = 9
        ' 
        ' textLastName
        ' 
        textLastName.Location = New Point(184, 176)
        textLastName.Margin = New Padding(3, 2, 3, 2)
        textLastName.Name = "textLastName"
        textLastName.Size = New Size(215, 23)
        textLastName.TabIndex = 10
        ' 
        ' textEmployeeID
        ' 
        textEmployeeID.Location = New Point(184, 208)
        textEmployeeID.Margin = New Padding(3, 2, 3, 2)
        textEmployeeID.Name = "textEmployeeID"
        textEmployeeID.ReadOnly = True
        textEmployeeID.Size = New Size(215, 23)
        textEmployeeID.TabIndex = 11
        ' 
        ' textUsername
        ' 
        textUsername.Location = New Point(184, 241)
        textUsername.Margin = New Padding(3, 2, 3, 2)
        textUsername.Name = "textUsername"
        textUsername.Size = New Size(215, 23)
        textUsername.TabIndex = 12
        ' 
        ' textNewPassword
        ' 
        textNewPassword.Location = New Point(184, 274)
        textNewPassword.Margin = New Padding(3, 2, 3, 2)
        textNewPassword.Name = "textNewPassword"
        textNewPassword.Size = New Size(215, 23)
        textNewPassword.TabIndex = 13
        ' 
        ' textConPass
        ' 
        textConPass.Location = New Point(184, 311)
        textConPass.Margin = New Padding(3, 2, 3, 2)
        textConPass.Name = "textConPass"
        textConPass.Size = New Size(215, 23)
        textConPass.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Font = New Font("Lucida Console", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(228, 346)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 32)
        Button1.TabIndex = 15
        Button1.Text = "Update"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.WindowFrame
        Label9.Location = New Point(10, 46)
        Label9.Name = "Label9"
        Label9.Size = New Size(267, 17)
        Label9.TabIndex = 17
        Label9.Text = "Don't share your password to anyone."
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Lucida Console", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(346, 4)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 26)
        Button2.TabIndex = 16
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' SearchBtn
        ' 
        SearchBtn.BackColor = Color.IndianRed
        SearchBtn.Location = New Point(324, 99)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(75, 24)
        SearchBtn.TabIndex = 18
        SearchBtn.Text = "Search"
        SearchBtn.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(441, 448)
        Controls.Add(SearchBtn)
        Controls.Add(Label9)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(textConPass)
        Controls.Add(textNewPassword)
        Controls.Add(textUsername)
        Controls.Add(textEmployeeID)
        Controls.Add(textLastName)
        Controls.Add(textFirstname)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(textSearchUser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Forgot Password"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textSearchUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents textFirstname As TextBox
    Friend WithEvents textLastName As TextBox
    Friend WithEvents textEmployeeID As TextBox
    Friend WithEvents textUsername As TextBox
    Friend WithEvents textNewPassword As TextBox
    Friend WithEvents textConPass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents SearchBtn As Button
End Class
