Public Class Form4

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim mes As String = Date.Now.Month.ToString()

        If Date.Now.Month.ToString() = 12 Or Date.Now.Month.ToString() = 1 Or Date.Now.Month.ToString() = 2 Then
            Me.BackgroundImage = My.Resources.inverno
        ElseIf Date.Now.Month.ToString() = 3 Or Date.Now.Month.ToString() = 4 Or Date.Now.Month.ToString() = 5 Then
            Me.BackgroundImage = My.Resources.primavera
        ElseIf Date.Now.Month.ToString() = 6 Or Date.Now.Month.ToString() = 7 Or Date.Now.Month.ToString() = 8 Then
            Me.BackgroundImage = My.Resources.verao
        ElseIf Date.Now.Month.ToString() = 9 Or Date.Now.Month.ToString() = 10 Or Date.Now.Month.ToString() = 11 Then
            Me.BackgroundImage = My.Resources.outono
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Create_Click(sender As System.Object, e As System.EventArgs) Handles Create.Click

        Dim FILE_NAME As String = "../Notes.txt" '"C:\Notes.txt"
        If System.IO.File.Exists(FILE_NAME) = False Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, False) 'pode-se colocar FILE_NAME,true) caso se queira que ao guardar, adicione essa informaçao ao txt e nao apagando o que anteriormente estava escrito'
            MessageBox.Show("File Created")
            objWriter.Close()

        Else

            MessageBox.Show("File Already Exists")

        End If
    End Sub

    Private Sub Save_Click(sender As System.Object, e As System.EventArgs) Handles Save.Click
        Dim FILE_NAME As String = "../Notes.txt" '"C:\Notes.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME) 'pode-se colocar FILE_NAME,true) caso se queira que ao guardar, adicione essa informaçao ao txt e nao apagando o que anteriormente estava escrito'

            objWriter.Write(TextBox1.Text)
            objWriter.Close()
            MessageBox.Show("Text written to file")

        Else

            MessageBox.Show("File Does Not Exist")

        End If
    End Sub

    Private Sub Load_Click(sender As System.Object, e As System.EventArgs) Handles See_Notes.Click
        Dim FILE_NAME As String = "../Notes.txt" '"C:\Notes.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            TextBox1.Text = objReader.ReadToEnd
            objReader.Close()

        Else

            MessageBox.Show("File Does Not Exist")

        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        Me.Hide()
        Form6.Show()

    End Sub
End Class