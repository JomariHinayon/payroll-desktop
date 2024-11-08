<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form9))
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Label7 = New Label()
        TextBox5 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        Label10 = New Label()
        TextBox8 = New TextBox()
        Label11 = New Label()
        TextBox9 = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        TextBox13 = New TextBox()
        TextBox14 = New TextBox()
        Label17 = New Label()
        Label18 = New Label()
        TextBox15 = New TextBox()
        TextBox16 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lucida Sans Unicode", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(33, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(271, 28)
        Label1.TabIndex = 5
        Label1.Text = "Update Employee List"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(936, 47)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(283, 27)
        TextBox1.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(728, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 22)
        Label2.TabIndex = 7
        Label2.Text = "Search an Employee"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 47)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(710, 536)
        DataGridView1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.WindowFrame
        Label3.Location = New Point(728, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(485, 21)
        Label3.TabIndex = 9
        Label3.Text = "Search the employee you want to update the information."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(728, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 21)
        Label4.TabIndex = 10
        Label4.Text = "Last Name:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(923, 116)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(296, 27)
        TextBox2.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(728, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 21)
        Label5.TabIndex = 12
        Label5.Text = "First Name:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(923, 149)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(296, 27)
        TextBox3.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(728, 188)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 21)
        Label6.TabIndex = 14
        Label6.Text = "Birthday:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(923, 182)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(296, 27)
        TextBox4.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(728, 221)
        Label7.Name = "Label7"
        Label7.Size = New Size(44, 21)
        Label7.TabIndex = 16
        Label7.Text = "Sex:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(923, 215)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(296, 27)
        TextBox5.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(728, 254)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 21)
        Label8.TabIndex = 18
        Label8.Text = "Status:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(728, 287)
        Label9.Name = "Label9"
        Label9.Size = New Size(82, 21)
        Label9.TabIndex = 19
        Label9.Text = "Address:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(923, 248)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(296, 27)
        TextBox6.TabIndex = 20
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(923, 281)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(296, 27)
        TextBox7.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = SystemColors.ActiveCaptionText
        Label10.Location = New Point(728, 320)
        Label10.Name = "Label10"
        Label10.Size = New Size(99, 21)
        Label10.TabIndex = 22
        Label10.Text = "Phone No.:"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(923, 314)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(296, 27)
        TextBox8.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = SystemColors.ActiveCaptionText
        Label11.Location = New Point(724, 353)
        Label11.Name = "Label11"
        Label11.Size = New Size(137, 21)
        Label11.TabIndex = 24
        Label11.Text = "Telephone No.:"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(923, 347)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(296, 27)
        TextBox9.TabIndex = 25
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.ForeColor = SystemColors.ActiveCaptionText
        Label12.Location = New Point(727, 386)
        Label12.Name = "Label12"
        Label12.Size = New Size(80, 21)
        Label12.TabIndex = 26
        Label12.Text = "Position:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.ForeColor = SystemColors.ActiveCaptionText
        Label13.Location = New Point(727, 419)
        Label13.Name = "Label13"
        Label13.Size = New Size(99, 21)
        Label13.TabIndex = 27
        Label13.Text = "Basic Rate:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.ForeColor = SystemColors.ActiveCaptionText
        Label14.Location = New Point(728, 452)
        Label14.Name = "Label14"
        Label14.Size = New Size(42, 21)
        Label14.TabIndex = 28
        Label14.Text = "SSS:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.ForeColor = SystemColors.ActiveCaptionText
        Label15.Location = New Point(727, 485)
        Label15.Name = "Label15"
        Label15.Size = New Size(77, 21)
        Label15.TabIndex = 29
        Label15.Text = "Time In:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Lucida Console", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.ForeColor = SystemColors.ActiveCaptionText
        Label16.Location = New Point(727, 522)
        Label16.Name = "Label16"
        Label16.Size = New Size(98, 17)
        Label16.TabIndex = 30
        Label16.Text = "Time Out:"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(923, 380)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(296, 27)
        TextBox10.TabIndex = 31
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(923, 413)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(296, 27)
        TextBox11.TabIndex = 32
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(923, 446)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(296, 27)
        TextBox12.TabIndex = 33
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(923, 479)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(296, 27)
        TextBox13.TabIndex = 34
        ' 
        ' TextBox14
        ' 
        TextBox14.Location = New Point(923, 512)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(296, 27)
        TextBox14.TabIndex = 35
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.ForeColor = SystemColors.ActiveCaptionText
        Label17.Location = New Point(727, 551)
        Label17.Name = "Label17"
        Label17.Size = New Size(68, 21)
        Label17.TabIndex = 36
        Label17.Text = "Profile:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.ForeColor = SystemColors.ActiveCaptionText
        Label18.Location = New Point(724, 584)
        Label18.Name = "Label18"
        Label18.Size = New Size(106, 21)
        Label18.TabIndex = 37
        Label18.Text = "Fingerprint:"
        ' 
        ' TextBox15
        ' 
        TextBox15.Location = New Point(923, 545)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(296, 27)
        TextBox15.TabIndex = 38
        ' 
        ' TextBox16
        ' 
        TextBox16.Location = New Point(923, 578)
        TextBox16.Name = "TextBox16"
        TextBox16.Size = New Size(296, 27)
        TextBox16.TabIndex = 39
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(1110, 648)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 36)
        Button1.TabIndex = 40
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.IndianRed
        Button2.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(996, 648)
        Button2.Name = "Button2"
        Button2.Size = New Size(93, 36)
        Button2.TabIndex = 41
        Button2.Text = "Refresh"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.IndianRed
        Button4.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(881, 648)
        Button4.Name = "Button4"
        Button4.Size = New Size(93, 36)
        Button4.TabIndex = 43
        Button4.Text = "Remove"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.IndianRed
        Button5.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(1225, 44)
        Button5.Name = "Button5"
        Button5.Size = New Size(93, 33)
        Button5.TabIndex = 44
        Button5.Text = "Search"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(1225, 648)
        Button3.Name = "Button3"
        Button3.Size = New Size(98, 36)
        Button3.TabIndex = 45
        Button3.Text = "Cancel"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(1330, 696)
        Controls.Add(Button3)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox16)
        Controls.Add(TextBox15)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(TextBox14)
        Controls.Add(TextBox13)
        Controls.Add(TextBox12)
        Controls.Add(TextBox11)
        Controls.Add(TextBox10)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(TextBox9)
        Controls.Add(Label11)
        Controls.Add(TextBox8)
        Controls.Add(Label10)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(TextBox5)
        Controls.Add(Label7)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form9"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Update Employee List"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
End Class
