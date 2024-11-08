<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form8))
        MenuStrip1 = New MenuStrip()
        DashboardToolStripMenuItem = New ToolStripMenuItem()
        EmployeeToolStripMenuItem = New ToolStripMenuItem()
        AttendanceToolStripMenuItem = New ToolStripMenuItem()
        PayrollToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        DataGridView1 = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        employee = New DataGridViewTextBoxColumn()
        attendanceDate = New DataGridViewTextBoxColumn()
        time_in = New DataGridViewTextBoxColumn()
        time_out = New DataGridViewTextBoxColumn()
        Button2 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.IndianRed
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DashboardToolStripMenuItem, EmployeeToolStripMenuItem, PayrollToolStripMenuItem, LogOutToolStripMenuItem, AttendanceToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(1075, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DashboardToolStripMenuItem
        ' 
        DashboardToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        DashboardToolStripMenuItem.Size = New Size(83, 20)
        DashboardToolStripMenuItem.Text = "Dashboard"
        ' 
        ' EmployeeToolStripMenuItem
        ' 
        EmployeeToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        EmployeeToolStripMenuItem.Size = New Size(75, 20)
        EmployeeToolStripMenuItem.Text = "Employee"
        ' 
        ' AttendanceToolStripMenuItem
        ' 
        AttendanceToolStripMenuItem.BackColor = Color.Firebrick
        AttendanceToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AttendanceToolStripMenuItem.ForeColor = SystemColors.ControlLight
        AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        AttendanceToolStripMenuItem.Size = New Size(84, 20)
        AttendanceToolStripMenuItem.Text = "Attendance"
        ' 
        ' PayrollToolStripMenuItem
        ' 
        PayrollToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        PayrollToolStripMenuItem.Size = New Size(57, 20)
        PayrollToolStripMenuItem.Text = "Payroll"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(63, 20)
        LogOutToolStripMenuItem.Text = "Log Out"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {id, employee, attendanceDate, time_in, time_out})
        DataGridView1.Location = New Point(25, 120)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1025, 317)
        DataGridView1.TabIndex = 5
        ' 
        ' id
        ' 
        id.HeaderText = "Employee Number"
        id.Name = "id"
        id.Width = 150
        ' 
        ' employee
        ' 
        employee.HeaderText = "Employee Name"
        employee.Name = "employee"
        employee.Width = 200
        ' 
        ' attendanceDate
        ' 
        attendanceDate.HeaderText = "Date"
        attendanceDate.Name = "attendanceDate"
        attendanceDate.Width = 200
        ' 
        ' time_in
        ' 
        time_in.HeaderText = "Time In"
        time_in.Name = "time_in"
        time_in.Width = 200
        ' 
        ' time_out
        ' 
        time_out.HeaderText = "Time Out"
        time_out.Name = "time_out"
        time_out.Width = 200
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.IndianRed
        Button2.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(963, 454)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 26)
        Button2.TabIndex = 6
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.IndianRed
        Button3.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(850, 454)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(87, 26)
        Button3.TabIndex = 7
        Button3.Text = "Refresh"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(767, 85)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(283, 23)
        TextBox1.TabIndex = 11
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(654, 85)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(108, 21)
        Button4.TabIndex = 12
        Button4.Text = "Search"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Lucida Sans Unicode", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(456, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 34)
        Label2.TabIndex = 13
        Label2.Text = "Attendance"
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
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(767, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 16)
        Label3.TabIndex = 15
        Label3.Text = "Baranagay Payroll Management System"
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1075, 490)
        Controls.Add(Label3)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(Button4)
        Controls.Add(TextBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Attendance Page"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents employee As DataGridViewTextBoxColumn
    Friend WithEvents attendanceDate As DataGridViewTextBoxColumn
    Friend WithEvents time_in As DataGridViewTextBoxColumn
    Friend WithEvents time_out As DataGridViewTextBoxColumn
End Class
