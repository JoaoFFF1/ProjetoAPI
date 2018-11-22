Public Class Form3

    Dim dados As Integer = 0
    Dim dataAnt As Date = Date.Now()
    Dim datas(365) As Date
    Dim notas(365) As String
    Dim notas2(365) As String

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

            Dim mes As String = Date.Now.Month.ToString()

            Select Case mes
            Case 12 Or 1 Or 2
                Me.BackgroundImage = My.Resources.inverno
            Case 3 Or 4 Or 5
                Me.BackgroundImage = My.Resources.primavera
            Case 6 Or 7 Or 8
                Me.BackgroundImage = My.Resources.verao
            Case 9 Or 10 Or 11
                Me.BackgroundImage = My.Resources.outono

        End Select

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RichTextBox1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseClick
        RichTextBox1.Clear()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form4.Show()
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

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

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

    Private Sub RichTextBox2_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox2.MouseClick
        RichTextBox2.Clear()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        'Dim a As Date = DateTimePicker1.Value

        'data muda
        'mostra nas textboxes os dados do dia

        'Tentar passar isto a botão, salva os dados carregando num botão que salva a data 
        'e ao mudar de data ele muda de texto

        '======================================
        'Dim dados As Integer = 0
        'Dim datas(365) As Date
        'Dim notas(365) As String
        'Dim notas2(365) As String

        RichTextBox3.AppendText("<=====================>" & vbNewLine & "Evento detetado, DateTimePicker1.Value: " & DateTimePicker1.Value & "///dataAnt: " & dataAnt)

        If Not (RichTextBox1.TextLength = 0 And RichTextBox2.TextLength = 0) Then

            datas(dados) = dataAnt
            notas(dados) = RichTextBox1.Text
            notas2(dados) = RichTextBox2.Text

            RichTextBox3.AppendText("///index: " & dados & vbNewLine & " ///data adicionada: " & datas(dados) & " ///nota1 adicionada: " & notas(dados) & vbNewLine & " ///nota2 adicionada: " & notas2(dados))
        End If

            RichTextBox1.Clear()
            RichTextBox2.Clear()

        RichTextBox3.AppendText("///Caixas limpas")

        Try
            RichTextBox1.Text = notas(Array.IndexOf(datas, DateTimePicker1.Value))
            RichTextBox2.Text = notas2(Array.IndexOf(datas, DateTimePicker1.Value))
        Catch ex As IndexOutOfRangeException
            RichTextBox3.AppendText("///Exceção detetada")
            RichTextBox1.Text = ""
            RichTextBox2.Text = ""
        End Try

        RichTextBox3.AppendText("///Texto definido" & vbNewLine & "<=====================>")

            dataAnt = DateTimePicker1.Value
    End Sub
End Class