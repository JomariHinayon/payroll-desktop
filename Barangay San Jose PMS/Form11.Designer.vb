<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form11))
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Label7 = New Label()
        TextBox4 = New TextBox()
        Label8 = New Label()
        TextBox5 = New TextBox()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lucida Sans Unicode", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(23, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 28)
        Label1.TabIndex = 6
        Label1.Text = "Create Account"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Info
        Label3.Location = New Point(23, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(325, 23)
        Label3.TabIndex = 10
        Label3.Text = "Create an account for the new employee."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.Info
        Label2.Location = New Point(23, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(512, 23)
        Label2.TabIndex = 11
        Label2.Text = "This account will be used for their website and mobile application."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(3, 369)
        Label4.Name = "Label4"
        Label4.Size = New Size(175, 23)
        Label4.TabIndex = 12
        Label4.Text = "Employee ID No.:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(6, 420)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 23)
        Label5.TabIndex = 13
        Label5.Text = "Username:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(3, 515)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 23)
        Label6.TabIndex = 14
        Label6.Text = "Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(189, 370)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(309, 27)
        TextBox1.TabIndex = 16
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(189, 417)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(309, 27)
        TextBox2.TabIndex = 17
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(189, 512)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(311, 27)
        TextBox3.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Font = New Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(86, 607)
        Button1.Name = "Button1"
        Button1.Size = New Size(381, 42)
        Button1.TabIndex = 19
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(3, 555)
        Label7.Name = "Label7"
        Label7.Size = New Size(190, 23)
        Label7.TabIndex = 21
        Label7.Text = "Confirm Password:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(187, 556)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(311, 27)
        TextBox4.TabIndex = 22
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(5, 468)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 23)
        Label8.TabIndex = 23
        Label8.Text = "Phone No.:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(187, 465)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(311, 27)
        TextBox5.TabIndex = 24
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Elegant_Circle_Signature_Photography_Logo_20240611_173635_0000
        PictureBox1.Location = New Point(165, 137)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(209, 197)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(445, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(98, 34)
        Button2.TabIndex = 25
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form11
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(555, 671)
        Controls.Add(Button2)
        Controls.Add(TextBox5)
        Controls.Add(Label8)
        Controls.Add(TextBox4)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form11"
        Text = "Create Account"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
End Class
