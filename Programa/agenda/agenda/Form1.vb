Public Class Form1
    Public online As New User
    Dim users As New Dictionary(Of String, User)

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = Date.Now.Year
        Form2.Close()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
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
                    If Not users.ContainsKey(TextBox1.Text) Then
                        users.Add(TextBox1.Text, New User With {.nome = TextBox1.Text, .pass = TextBox2.Text})

                        Me.Hide()
                        Form3.Show()
                    Else
                        MessageBox.Show("Utilizador já registado, por favor faça o login.")
                    End If

                Else
                    MessageBox.Show("Erro: passes não coincídem.")
                End If
            End If
        Else ' Login
            If TextBox1.TextLength = 0 Or TextBox2.TextLength = 0 Then
                MessageBox.Show("Erro: preencha todos os campos.")
            Else
                If users.ContainsKey(TextBox1.Text) Then
                    If users(TextBox1.Text).pass = TextBox2.Text Then
                        online = users(TextBox1.Text)
                        Me.Hide()
                        Form3.Show()
                    End If

                Else
                    MessageBox.Show("Erro: utilizador não encontrado, por favor faça o registo.")
                End If
            End If
        End If
    End Sub
End Class
