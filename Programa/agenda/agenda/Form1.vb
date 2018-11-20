Public Class Form1

    Dim nusers As Byte = 0
    Dim users(10) As String
    Dim passes(10) As String

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox3.Visible = False Then
            TextBox3.Visible = True
            Label5.Visible = True
            Button2.Text = "Registo"
        Else
            TextBox3.Visible = False
            Label5.Visible = False
            Button2.Text = "Login"
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If Button2.Text = "Registo" Then
            If TextBox1.TextLength = 0 Or TextBox2.TextLength = 0 Or TextBox3.TextLength = 0 Then
                MessageBox.Show("Erro: preencha todos os campos.")
            Else
                If TextBox2.Text = TextBox3.Text Then
                    users(nusers) = TextBox1.Text
                    passes(nusers) = TextBox2.Text

                    nusers = nusers + 1

                    Me.Hide()
                    Form3.Show()
                Else
                    MessageBox.Show("Erro: passes não coincídem.")
                End If
            End If
        Else

        End If

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label2.Text = Date.Now.Year
    End Sub
End Class
'my.computer.filesystem 
'   writtealltext(dir, ficheiro, boool)
'
'