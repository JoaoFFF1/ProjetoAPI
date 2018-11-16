Public Class Form3

    Dim listaDiarios As List(Of Diario)

    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        'Lê a data selecionada no calendário
        'Se a data tiver dados associados
        'Então define o texto da RichTextBox1 como o texto associado à data 
        'Se não cria um novo diário com a data igual à data selecionada
        'Tá confuso, eu sei, então lê https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.monthcalendar?view=netframework-4.7.2

        'Dim data1 As Date = MonthCalendar1.SelectDate
    End Sub

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

    Sub sla()
       
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
End Class