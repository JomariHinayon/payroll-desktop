Public Class Form5

    Private Sub AttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem.Click

        Me.Hide()
        Dim form8 As New Form8()
        form8.WindowState = Me.WindowState ' Set Form8's WindowState to the current form's WindowState
        form8.Size = Me.Size ' Optional: Set the size if the state is Normal
        form8.Location = Me.Location ' Optional: Set the location if the state is Normal

        form8.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem1.Click

        Me.Hide()
        Dim form6 As New Form6()
        form6.WindowState = Me.WindowState ' Set Form6's WindowState to the current form's WindowState
        form6.Size = Me.Size ' Optional: Set the size if the state is Normal
        form6.Location = Me.Location ' Optional: Set the location if the state is Normal

        form6.Show()
    End Sub

    Private Sub AddNewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem1.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollToolStripMenuItem.Click
        Me.Hide()
        Dim form10 As New Form10()
        form10.WindowState = Me.WindowState ' Set Form10's WindowState to the current form's WindowState
        form10.Size = Me.Size ' Optional: Set the size if the state is Normal
        form10.Location = Me.Location ' Optional: Set the location if the state is Normal

        form10.Show()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class