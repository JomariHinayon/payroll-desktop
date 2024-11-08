<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        textFirstName = New TextBox()
        textLastName = New TextBox()
        Label4 = New Label()
        textEmployeeId = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        textUsername = New TextBox()
        textPassword = New TextBox()
        textConPass = New TextBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Label8 = New Label()
        Label9 = New Label()
        Button2 = New Button()
        CheckBox1 = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(10, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 20)
        Label1.TabIndex = 0
        Label1.Text = "Create a New Account"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(10, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 18)
        Label2.TabIndex = 1
        Label2.Text = "First Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(10, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 18)
        Label3.TabIndex = 2
        Label3.Text = "Last Name:"
        ' 
        ' textFirstName
        ' 
        textFirstName.Location = New Point(192, 142)
        textFirstName.Margin = New Padding(3, 2, 3, 2)
        textFirstName.Name = "textFirstName"
        textFirstName.Size = New Size(182, 23)
        textFirstName.TabIndex = 3
        ' 
        ' textLastName
        ' 
        textLastName.Location = New Point(192, 178)
        textLastName.Margin = New Padding(3, 2, 3, 2)
        textLastName.Name = "textLastName"
        textLastName.Size = New Size(182, 23)
        textLastName.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(10, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 18)
        Label4.TabIndex = 5
        Label4.Text = "Employee ID No.:"
        ' 
        ' textEmployeeId
        ' 
        textEmployeeId.Location = New Point(192, 214)
        textEmployeeId.Margin = New Padding(3, 2, 3, 2)
        textEmployeeId.Name = "textEmployeeId"
        textEmployeeId.ReadOnly = True
        textEmployeeId.Size = New Size(182, 23)
        textEmployeeId.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(10, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 18)
        Label5.TabIndex = 7
        Label5.Text = "Username:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(10, 290)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 18)
        Label6.TabIndex = 8
        Label6.Text = "Password:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(10, 326)
        Label7.Name = "Label7"
        Label7.Size = New Size(147, 18)
        Label7.TabIndex = 9
        Label7.Text = "Confirm Password:"
        ' 
        ' textUsername
        ' 
        textUsername.Location = New Point(192, 250)
        textUsername.Margin = New Padding(3, 2, 3, 2)
        textUsername.Name = "textUsername"
        textUsername.Size = New Size(182, 23)
        textUsername.TabIndex = 10
        ' 
        ' textPassword
        ' 
        textPassword.Location = New Point(192, 286)
        textPassword.Margin = New Padding(3, 2, 3, 2)
        textPassword.Name = "textPassword"
        textPassword.Size = New Size(182, 23)
        textPassword.TabIndex = 11
        textPassword.UseSystemPasswordChar = True
        ' 
        ' textConPass
        ' 
        textConPass.Location = New Point(192, 322)
        textConPass.Margin = New Padding(3, 2, 3, 2)
        textConPass.Name = "textConPass"
        textConPass.Size = New Size(182, 23)
        textConPass.TabIndex = 12
        textConPass.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(208, 362)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 29)
        Button1.TabIndex = 13
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(216, 69)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(142, 68)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.Info
        Label8.Location = New Point(10, 42)
        Label8.Name = "Label8"
        Label8.Size = New Size(246, 17)
        Label8.TabIndex = 17
        Label8.Text = "Create a new account as an admin."
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.WindowFrame
        Label9.Location = New Point(41, 422)
        Label9.Name = "Label9"
        Label9.Size = New Size(378, 17)
        Label9.TabIndex = 18
        Label9.Text = "Don't share your account information to other people."
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(376, 9)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 26)
        Button2.TabIndex = 19
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(28, 362)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 20
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(472, 444)
        Controls.Add(CheckBox1)
        Controls.Add(Button2)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(textConPass)
        Controls.Add(textPassword)
        Controls.Add(textUsername)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(textEmployeeId)
        Controls.Add(Label4)
        Controls.Add(textLastName)
        Controls.Add(textFirstName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Create New Account"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textFirstName As TextBox
    Friend WithEvents textLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents textEmployeeId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents textUsername As TextBox
    Friend WithEvents textPassword As TextBox
    Friend WithEvents textConPass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
