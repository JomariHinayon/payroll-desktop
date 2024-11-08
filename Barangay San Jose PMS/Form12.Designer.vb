<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form12))
        MenuStrip1 = New MenuStrip()
        EmployeeToolStripMenuItem = New ToolStripMenuItem()
        EmployeeToolStripMenuItem1 = New ToolStripMenuItem()
        AttendanceToolStripMenuItem = New ToolStripMenuItem()
        PayrollToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.IndianRed
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {EmployeeToolStripMenuItem, EmployeeToolStripMenuItem1, AttendanceToolStripMenuItem, PayrollToolStripMenuItem, LogOutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(1091, 24)
        MenuStrip1.TabIndex = 5
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' EmployeeToolStripMenuItem
        ' 
        EmployeeToolStripMenuItem.BackColor = Color.IndianRed
        EmployeeToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        EmployeeToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText
        EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        EmployeeToolStripMenuItem.Size = New Size(83, 20)
        EmployeeToolStripMenuItem.Text = "Dashboard"
        ' 
        ' EmployeeToolStripMenuItem1
        ' 
        EmployeeToolStripMenuItem1.BackColor = Color.IndianRed
        EmployeeToolStripMenuItem1.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        EmployeeToolStripMenuItem1.Name = "EmployeeToolStripMenuItem1"
        EmployeeToolStripMenuItem1.Size = New Size(75, 20)
        EmployeeToolStripMenuItem1.Text = "Employee"
        ' 
        ' AttendanceToolStripMenuItem
        ' 
        AttendanceToolStripMenuItem.BackColor = Color.IndianRed
        AttendanceToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        AttendanceToolStripMenuItem.Size = New Size(84, 20)
        AttendanceToolStripMenuItem.Text = "Attendance"
        ' 
        ' PayrollToolStripMenuItem
        ' 
        PayrollToolStripMenuItem.BackColor = Color.Firebrick
        PayrollToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PayrollToolStripMenuItem.ForeColor = SystemColors.Info
        PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        PayrollToolStripMenuItem.Size = New Size(57, 20)
        PayrollToolStripMenuItem.Text = "Payroll"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.BackColor = Color.IndianRed
        LogOutToolStripMenuItem.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(63, 20)
        LogOutToolStripMenuItem.Text = "Log Out"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(779, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(231, 16)
        Label2.TabIndex = 10
        Label2.Text = "Baranagay Payroll Management System"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.LOGO_removebg_preview
        PictureBox2.Location = New Point(1040, 21)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(48, 39)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' Form12
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1091, 491)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form12"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payslip"
        TransparencyKey = Color.Transparent
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
