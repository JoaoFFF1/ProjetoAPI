Public Class Form1

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub TextBox1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Clear()

    End Sub

    Private Sub TextBox2_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseClick
        TextBox2.Clear()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class
