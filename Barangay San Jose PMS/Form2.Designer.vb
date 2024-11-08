<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        PasswordText = New MaskedTextBox()
        IdNumText = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        CheckBox1 = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PasswordText
        ' 
        PasswordText.Location = New Point(129, 253)
        PasswordText.Margin = New Padding(3, 2, 3, 2)
        PasswordText.Name = "PasswordText"
        PasswordText.Size = New Size(190, 23)
        PasswordText.TabIndex = 11
        PasswordText.UseSystemPasswordChar = True
        ' 
        ' IdNumText
        ' 
        IdNumText.Location = New Point(129, 219)
        IdNumText.Margin = New Padding(3, 2, 3, 2)
        IdNumText.Name = "IdNumText"
        IdNumText.Size = New Size(189, 23)
        IdNumText.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(26, 219)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(26, 255)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 20)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Elegant_Circle_Signature_Photography_Logo_20240611_173635_0000
        PictureBox1.Location = New Point(98, 40)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 122)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.Location = New Point(189, 294)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(118, 20)
        LinkLabel1.TabIndex = 5
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Password"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Font = New Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(72, 334)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(214, 30)
        Button1.TabIndex = 6
        Button1.Text = "Create New Account"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.IndianRed
        Button2.Font = New Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(72, 376)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(214, 30)
        Button2.TabIndex = 7
        Button2.Text = "Log In"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(136, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 23)
        Label3.TabIndex = 8
        Label3.Text = "Admin"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(61, 296)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 12
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(354, 451)
        Controls.Add(CheckBox1)
        Controls.Add(PasswordText)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(LinkLabel1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(IdNumText)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LogInForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IdNumText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordText As MaskedTextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
