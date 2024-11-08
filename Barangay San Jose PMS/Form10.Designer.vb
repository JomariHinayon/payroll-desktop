<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form10))
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Button3 = New Button()
        MenuStrip1 = New MenuStrip()
        DashboardToolStripMenuItem = New ToolStripMenuItem()
        EmployeeToolStripMenuItem = New ToolStripMenuItem()
        AttendanceToolStripMenuItem = New ToolStripMenuItem()
        PayrollToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        employee_fulname = New DataGridViewTextBoxColumn()
        date_start = New DataGridViewTextBoxColumn()
        date_end = New DataGridViewTextBoxColumn()
        deductions = New DataGridViewTextBoxColumn()
        allowances = New DataGridViewTextBoxColumn()
        bonuses = New DataGridViewTextBoxColumn()
        net_salary = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {employee_fulname, date_start, date_end, deductions, allowances, bonuses, net_salary})
        DataGridView1.Location = New Point(25, 131)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1025, 337)
        DataGridView1.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.IndianRed
        Button2.Location = New Point(963, 472)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 26)
        Button2.TabIndex = 7
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.IndianRed
        Button3.Location = New Point(856, 472)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(87, 26)
        Button3.TabIndex = 8
        Button3.Text = "Refresh"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.IndianRed
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DashboardToolStripMenuItem, EmployeeToolStripMenuItem, AttendanceToolStripMenuItem, PayrollToolStripMenuItem, LogOutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(1075, 24)
        MenuStrip1.TabIndex = 9
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
        EmployeeToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        PayrollToolStripMenuItem.BackColor = Color.Firebrick
        PayrollToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        PayrollToolStripMenuItem.ForeColor = SystemColors.ButtonFace
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(767, 94)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(283, 23)
        TextBox1.TabIndex = 10
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(654, 93)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(108, 21)
        Button4.TabIndex = 11
        Button4.Text = "Search"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Lucida Sans Unicode", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(499, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 34)
        Label2.TabIndex = 14
        Label2.Text = "Payroll"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(767, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 16)
        Label3.TabIndex = 16
        Label3.Text = "Baranagay Payroll Management System"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lucida Sans Unicode", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(410, 253)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 16)
        Label1.TabIndex = 17
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.LOGO_removebg_preview
        PictureBox2.Location = New Point(1027, 23)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(48, 39)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' employee_fulname
        ' 
        employee_fulname.HeaderText = "employee"
        employee_fulname.Name = "employee_fulname"
        ' 
        ' date_start
        ' 
        date_start.HeaderText = "Date Start"
        date_start.Name = "date_start"
        ' 
        ' date_end
        ' 
        date_end.HeaderText = "Date End"
        date_end.Name = "date_end"
        ' 
        ' deductions
        ' 
        deductions.HeaderText = "Deductions"
        deductions.Name = "deductions"
        ' 
        ' allowances
        ' 
        allowances.HeaderText = "Allowances"
        allowances.Name = "allowances"
        ' 
        ' bonuses
        ' 
        bonuses.HeaderText = "Bonuses"
        bonuses.Name = "bonuses"
        ' 
        ' net_salary
        ' 
        net_salary.HeaderText = "Net Salary"
        net_salary.Name = "net_salary"
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1075, 520)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button4)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form10"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payroll Page"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents employee_fulname As DataGridViewTextBoxColumn
    Friend WithEvents date_start As DataGridViewTextBoxColumn
    Friend WithEvents date_end As DataGridViewTextBoxColumn
    Friend WithEvents deductions As DataGridViewTextBoxColumn
    Friend WithEvents allowances As DataGridViewTextBoxColumn
    Friend WithEvents bonuses As DataGridViewTextBoxColumn
    Friend WithEvents net_salary As DataGridViewTextBoxColumn
End Class
