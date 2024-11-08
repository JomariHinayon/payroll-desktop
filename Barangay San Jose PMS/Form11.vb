Public Class Form11
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Successfully Saved!", vbOKOnly)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class