Public Class Form2


    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim mes As String = Date.Now.Month.ToString()

            Select mes
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
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub OvalShape7_Click(sender As System.Object, e As System.EventArgs) Handles OvalShape7.Click
        Process.Start("https://www.google.com")
    End Sub

    Private Sub OvalShape1_Click(sender As System.Object, e As System.EventArgs) Handles OvalShape1.Click
        Process.Start("https://www.duolingo.com/")
    End Sub

    Private Sub OvalShape2_Click(sender As System.Object, e As System.EventArgs) Handles OvalShape2.Click
        Process.Start("https://en.oxforddictionaries.com/")
    End Sub

    Private Sub OvalShape3_Click(sender As System.Object, e As System.EventArgs) Handles OvalShape3.Click
        Process.Start("https://academicearth.org/")

    End Sub

    Private Sub OvalShape5_Click(sender As System.Object, e As System.EventArgs) Handles OvalShape5.Click
        Process.Start("https://www.khanacademy.org/")
    End Sub

    Private Sub OvalShape4_Click(sender As System.Object, e As System.EventArgs) Handles OvalShape4.Click
        Process.Start("https://collegeinfogeek.com/")
    End Sub

    Private Sub OvalShape8_Click(sender As System.Object, e As System.EventArgs) Handles OvalShape8.Click
        Process.Start("http://www.priberam.pt/")
    End Sub

    Private Sub OvalShape6_Click(sender As System.Object, e As System.EventArgs) Handles OvalShape6.Click
        Process.Start("https://www.explicamat.pt/")
    End Sub
End Class