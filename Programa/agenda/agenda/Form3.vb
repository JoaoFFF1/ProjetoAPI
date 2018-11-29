Public Class Form3

    Public frases(11) As String
    Dim t As Double


    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            RichTextBox1.Text = Form1.online.diarios(DateTimePicker1.Value.ToShortDateString).todo
            RichTextBox2.Text = Form1.online.diarios(DateTimePicker1.Value.ToShortDateString).todo2
        Catch ex As Exception
            RichTextBox1.Text = ""
            RichTextBox2.Text = ""
        End Try

        frases(0) = "Knownledge is power, but enthusiasm pulls the switch."
        frases(1) = "Be yourself because an original is worth more than a copy."
        frases(2) = "Every sixty seconds you spend upset is a minute of happiness you'll never get back."
        frases(2) = "Change your thoughts and you'll change the world."
        frases(3) = "Strength grows in the moments you think you can't go on but you keep going anyway."
        frases(4) = "Talk doesn't help someone out of poverty. That takes doing."
        frases(5) = "Do something today that your future self will thank you for."
        frases(6) = "Sarcasm isn't an attitude, it's an art."
        frases(7) = "If you talk about it, it´s a dream, if you envision it, it's possible, but if you schedule it, it's real."
        frases(8) = "You have to believe."
        frases(9) = "The tragedy in life doesn't lie in not reaching your goal. The tragedy lies in having no goal to reach."
        frases(10) = "Success is not final, failure is not fatal: it is the courage to continue that counts."
        frases(11) = "The world is yours."

        Dim n As Byte
        Randomize()
        n = Int(Rnd() * 12 + 1)
        If n = 1 Then
            Label1.Text = frases(0)
        ElseIf n = 2 Then
            Label1.Text = frases(1)
        ElseIf n = 3 Then
            Label1.Text = frases(2)
        ElseIf n = 4 Then
            Label1.Text = frases(3)
        ElseIf n = 5 Then
            Label1.Text = frases(4)
        ElseIf n = 6 Then
            Label1.Text = frases(5)
        ElseIf n = 7 Then
            Label1.Text = frases(6)
        ElseIf n = 8 Then
            Label1.Text = frases(7)
        ElseIf n = 9 Then
            Label1.Text = frases(8)
        ElseIf n = 10 Then
            Label1.Text = frases(9)
        ElseIf n = 11 Then
            Label1.Text = frases(10)
        Else : Label1.Text = frases(11)


        End If

        If Date.Now.Month = 12 Or Date.Now.Month = 1 Or Date.Now.Month = 2 Then
            Me.BackgroundImage = My.Resources.inverno
        ElseIf Date.Now.Month = 3 Or Date.Now.Month = 4 Or Date.Now.Month = 5 Then
            Me.BackgroundImage = My.Resources.primavera
        ElseIf Date.Now.Month = 6 Or Date.Now.Month = 7 Or Date.Now.Month = 8 Then
            Me.BackgroundImage = My.Resources.verao
        ElseIf Date.Now.Month = 9 Or Date.Now.Month = 10 Or Date.Now.Month = 11 Then
            Me.BackgroundImage = My.Resources.outono
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub Label2_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseClick
        Label2.Location = New Point(0, 150)
        Label2.BringToFront()
        PictureBox1.Location = New Point(10, 167)
        PictureBox1.BringToFront()
        PictureBox3.Location = New Point(10, 226)
        PictureBox3.BringToFront()
        PictureBox4.Location = New Point(10, 309)
        PictureBox4.BringToFront()
        PictureBox5.Location = New Point(10, 359)
        PictureBox5.BringToFront()

    End Sub

    Private Sub Label2_MouseDoubleClick_1(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseDoubleClick
        Label2.Location = New Point(-36, 150)
        Label2.BringToFront()
        PictureBox1.Location = New Point(-37, 167)
        PictureBox1.BringToFront()
        PictureBox3.Location = New Point(-37, 226)
        PictureBox3.BringToFront()
        PictureBox4.Location = New Point(-37, 309)
        PictureBox4.BringToFront()
        PictureBox5.Location = New Point(-37, 359)
        PictureBox5.BringToFront()
    End Sub

    Private Sub PictureBox3_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseClick
        Form4.Show()
    End Sub

    Private Sub PictureBox4_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseClick
        Form5.Show()
    End Sub

    Private Sub PictureBox6_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseClick

        My.Computer.Audio.Stop()
        PictureBox6.Hide()
        PictureBox7.Show()
    End Sub

    Private Sub PictureBox7_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox7.MouseClick
        PictureBox6.BringToFront()
        My.Computer.Audio.Play("..\..\Resources\Four Seasons Vivaldi.wav")
        PictureBox7.Hide()
        PictureBox6.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        Try
            RichTextBox1.Text = Form1.online.diarios(DateTimePicker1.Value.ToShortDateString).todo
            RichTextBox2.Text = Form1.online.diarios(DateTimePicker1.Value.ToShortDateString).todo2
        Catch ex As Exception
            RichTextBox1.Text = ""
            RichTextBox2.Text = ""
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Form1.online.diarios.Add(DateTimePicker1.Value.ToShortDateString, New Diario With {.data = DateTimePicker1.Value.ToShortDateString(), .todo = RichTextBox1.Text, .todo2 = RichTextBox2.Text})
        Catch ex As Exception
            Form1.online.diarios.Remove(DateTimePicker1.Value.ToShortDateString)
            Form1.online.diarios.Add(DateTimePicker1.Value.ToShortDateString, New Diario With {.data = DateTimePicker1.Value.ToShortDateString(), .todo = RichTextBox1.Text, .todo2 = RichTextBox2.Text})
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        Me.Close()
        Form2.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form1.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Form2.Show()
    End Sub
End Class