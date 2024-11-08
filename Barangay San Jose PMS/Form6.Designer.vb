<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form6))
        Label1 = New Label()
        Button1 = New Button()
        MenuStrip1 = New MenuStrip()
        DashboardToolStripMenuItem = New ToolStripMenuItem()
        EmployeeToolStripMenuItem = New ToolStripMenuItem()
        AttendanceToolStripMenuItem = New ToolStripMenuItem()
        PayrollToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        employee_number = New DataGridViewTextBoxColumn()
        employee_name = New DataGridViewTextBoxColumn()
        hire_date = New DataGridViewTextBoxColumn()
        address = New DataGridViewTextBoxColumn()
        department = New DataGridViewTextBoxColumn()
        position = New DataGridViewTextBoxColumn()
        phone_number = New DataGridViewTextBoxColumn()
        salary = New DataGridViewTextBoxColumn()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(24, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 23)
        Label1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(24, 68)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(276, 31)
        Button1.TabIndex = 1
        Button1.Text = "Add new Employee +"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.IndianRed
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DashboardToolStripMenuItem, EmployeeToolStripMenuItem, AttendanceToolStripMenuItem, PayrollToolStripMenuItem, LogOutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(1070, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DashboardToolStripMenuItem
        ' 
        DashboardToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        DashboardToolStripMenuItem.Size = New Size(83, 20)
        DashboardToolStripMenuItem.Text = "Dashboard"
        ' 
        ' EmployeeToolStripMenuItem
        ' 
        EmployeeToolStripMenuItem.BackColor = Color.Firebrick
        EmployeeToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        EmployeeToolStripMenuItem.ForeColor = SystemColors.ButtonFace
        EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        EmployeeToolStripMenuItem.Size = New Size(75, 20)
        EmployeeToolStripMenuItem.Text = "Employee"
        ' 
        ' AttendanceToolStripMenuItem
        ' 
        AttendanceToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        AttendanceToolStripMenuItem.Size = New Size(84, 20)
        AttendanceToolStripMenuItem.Text = "Attendance"
        ' 
        ' PayrollToolStripMenuItem
        ' 
        PayrollToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        PayrollToolStripMenuItem.Size = New Size(57, 20)
        PayrollToolStripMenuItem.Text = "Payroll"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(63, 20)
        LogOutToolStripMenuItem.Text = "Log Out"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {employee_number, employee_name, hire_date, address, department, position, phone_number, salary})
        DataGridView1.Location = New Point(24, 106)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1025, 298)
        DataGridView1.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.BackColor = Color.IndianRed
        Button2.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(962, 417)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 26)
        Button2.TabIndex = 4
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button3.BackColor = Color.IndianRed
        Button3.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(853, 417)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(87, 26)
        Button3.TabIndex = 5
        Button3.Text = "Refresh"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(766, 76)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(283, 23)
        TextBox1.TabIndex = 6
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(653, 75)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(108, 21)
        Button4.TabIndex = 7
        Button4.Text = "Search"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Lucida Sans Unicode", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(445, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 34)
        Label2.TabIndex = 8
        Label2.Text = "Employees"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(766, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 16)
        Label3.TabIndex = 10
        Label3.Text = "Baranagay Payroll Management System"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.LOGO_removebg_preview
        PictureBox2.Location = New Point(1022, 23)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(48, 39)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' employee_number
        ' 
        employee_number.HeaderText = "Employee Number"
        employee_number.Name = "employee_number"
        ' 
        ' name
        ' 
        employee_name.HeaderText = "Name"
        employee_name.Name = "name"
        ' 
        ' hire_date
        ' 
        hire_date.HeaderText = "Hire Date"
        hire_date.Name = "hire_date"
        ' 
        ' address
        ' 
        address.HeaderText = "Address"
        address.Name = "address"
        ' 
        ' department
        ' 
        department.HeaderText = "Department"
        department.Name = "department"
        ' 
        ' position
        ' 
        position.HeaderText = "Position"
        position.Name = "position"
        ' 
        ' phone_number
        ' 
        phone_number.HeaderText = "Phone Number"
        phone_number.Name = "phone_number"
        ' 
        ' salary
        ' 
        salary.HeaderText = "Salary"
        salary.Name = "salary"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1070, 461)
        Controls.Add(Label3)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(Button4)
        Controls.Add(TextBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee List Page"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents employee_number As DataGridViewTextBoxColumn
    Friend WithEvents employee_name As DataGridViewTextBoxColumn
    Friend WithEvents hire_date As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents department As DataGridViewTextBoxColumn
    Friend WithEvents position As DataGridViewTextBoxColumn
    Friend WithEvents phone_number As DataGridViewTextBoxColumn
    Friend WithEvents salary As DataGridViewTextBoxColumn
End Class
