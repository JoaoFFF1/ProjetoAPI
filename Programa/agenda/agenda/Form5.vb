
Public Class Form5

    'Dim controlos() = {RichTextBox2, RichTextBox1, Label7,
    '                    RichTextBox3, RichTextBox4, Label8,
    '                    RichTextBox5, RichTextBox11, Label9,
    '                    RichTextBox16, RichTextBox20, Label10,
    '                    RichTextBox35, RichTextBox36, Label13,
    '                    RichTextBox29, RichTextBox34, Label12,
    '                    RichTextBox22, RichTextBox24, Label11,
    '                    RichTextBox37, RichTextBox38, Label14,
    '                    RichTextBox32, RichTextBox33, Label22,
    '                    RichTextBox30, RichTextBox31, Label21,
    '                    RichTextBox27, RichTextBox28, Label20,
    '                    RichTextBox19, RichTextBox26, Label19,
    '                    RichTextBox17, RichTextBox18, Label18,
    '                    RichTextBox14, RichTextBox15, Label17,
    '                    RichTextBox10, RichTextBox13, Label16,
    '                    RichTextBox8, RichTextBox9, Label15,
    '                    RichTextBox55, RichTextBox56, Label30,
    '                    RichTextBox53, RichTextBox54, Label29,
    '                    RichTextBox51, RichTextBox52, Label28,
    '                    RichTextBox49, RichTextBox50, Label27,
    '                    RichTextBox47, RichTextBox48, Label26,
    '                    RichTextBox45, RichTextBox46, Label25,
    '                    RichTextBox41, RichTextBox44, Label24,
    '                    RichTextBox39, RichTextBox40, Label23,
    '                    Label38, Label37, Label36, Label35, Label34, Label33, Label32, Label31}

    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        '80
        RichTextBox2.Text = Form1.online.notas(0)
        RichTextBox1.Text = Form1.online.notas(1)
        Label7.Text = Form1.online.notas(2)
        RichTextBox3.Text = Form1.online.notas(3)
        RichTextBox4.Text = Form1.online.notas(4)
        Label8.Text = Form1.online.notas(5)
        RichTextBox5.Text = Form1.online.notas(6)
        RichTextBox11.Text = Form1.online.notas(7)
        Label9.Text = Form1.online.notas(8)
        RichTextBox16.Text = Form1.online.notas(9)
        RichTextBox20.Text = Form1.online.notas(10)
        Label10.Text = Form1.online.notas(11)
        RichTextBox35.Text = Form1.online.notas(12)
        RichTextBox36.Text = Form1.online.notas(13)
        Label13.Text = Form1.online.notas(14)
        RichTextBox29.Text = Form1.online.notas(15)
        RichTextBox34.Text = Form1.online.notas(16)
        Label12.Text = Form1.online.notas(17)
        RichTextBox22.Text = Form1.online.notas(18)
        RichTextBox24.Text = Form1.online.notas(19)
        Label11.Text = Form1.online.notas(20)
        RichTextBox37.Text = Form1.online.notas(21)
        RichTextBox38.Text = Form1.online.notas(22)
        Label14.Text = Form1.online.notas(23)
        RichTextBox32.Text = Form1.online.notas(24)
        RichTextBox33.Text = Form1.online.notas(25)
        Label22.Text = Form1.online.notas(26)
        RichTextBox30.Text = Form1.online.notas(27)
        RichTextBox31.Text = Form1.online.notas(28)
        Label21.Text = Form1.online.notas(29)
        RichTextBox27.Text = Form1.online.notas(30)
        RichTextBox28.Text = Form1.online.notas(31)
        Label20.Text = Form1.online.notas(32)
        RichTextBox19.Text = Form1.online.notas(33)
        RichTextBox26.Text = Form1.online.notas(34)
        Label19.Text = Form1.online.notas(35)
        RichTextBox17.Text = Form1.online.notas(36)
        RichTextBox18.Text = Form1.online.notas(37)
        Label18.Text = Form1.online.notas(38)
        RichTextBox14.Text = Form1.online.notas(39)
        RichTextBox15.Text = Form1.online.notas(40)
        Label17.Text = Form1.online.notas(41)
        RichTextBox10.Text = Form1.online.notas(42)
        RichTextBox13.Text = Form1.online.notas(43)
        Label16.Text = Form1.online.notas(44)
        RichTextBox8.Text = Form1.online.notas(45)
        RichTextBox9.Text = Form1.online.notas(46)
        Label15.Text = Form1.online.notas(47)
        RichTextBox55.Text = Form1.online.notas(48)
        RichTextBox56.Text = Form1.online.notas(49)
        Label30.Text = Form1.online.notas(50)
        RichTextBox53.Text = Form1.online.notas(51)
        RichTextBox54.Text = Form1.online.notas(52)
        Label29.Text = Form1.online.notas(53)
        RichTextBox51.Text = Form1.online.notas(54)
        RichTextBox52.Text = Form1.online.notas(55)
        Label28.Text = Form1.online.notas(56)
        RichTextBox49.Text = Form1.online.notas(57)
        RichTextBox50.Text = Form1.online.notas(58)
        Label27.Text = Form1.online.notas(59)
        RichTextBox47.Text = Form1.online.notas(60)
        RichTextBox48.Text = Form1.online.notas(61)
        Label26.Text = Form1.online.notas(62)
        RichTextBox45.Text = Form1.online.notas(63)
        RichTextBox46.Text = Form1.online.notas(64)
        Label25.Text = Form1.online.notas(65)
        RichTextBox41.Text = Form1.online.notas(66)
        RichTextBox44.Text = Form1.online.notas(67)
        Label24.Text = Form1.online.notas(68)
        RichTextBox39.Text = Form1.online.notas(69)
        RichTextBox40.Text = Form1.online.notas(70)
        Label23.Text = Form1.online.notas(71)
        Label38.Text = Form1.online.notas(72)
        Label37.Text = Form1.online.notas(73)
        Label36.Text = Form1.online.notas(74)
        Label35.Text = Form1.online.notas(75)
        Label34.Text = Form1.online.notas(76)
        Label33.Text = Form1.online.notas(77)
        Label32.Text = Form1.online.notas(78)
        Label31.Text = Form1.online.notas(79)
        '"""""""""""""""""""""""""""""""""""""""""""
        RichTextBox6.Text = Form1.online.notas(80)
        RichTextBox12.Text = Form1.online.notas(81)
        RichTextBox7.Text = Form1.online.notas(82)
        RichTextBox25.Text = Form1.online.notas(83)
        RichTextBox23.Text = Form1.online.notas(84)
        RichTextBox21.Text = Form1.online.notas(85)
        RichTextBox43.Text = Form1.online.notas(86)
        RichTextBox42.Text = Form1.online.notas(87)

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        'Public notas() = {"", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "", "", "Media", "Media", "Media", "Media", "Media", "Media", "Media", "Media", "Media", "", "", "", "", "", "", "", ""}
        Form1.online.notas = {RichTextBox2.Text, RichTextBox1.Text, Label7.Text,
                              RichTextBox3.Text, RichTextBox4.Text, Label8.Text,
                              RichTextBox5.Text, RichTextBox11.Text, Label9.Text,
                              RichTextBox16.Text, RichTextBox20.Text, Label10.Text,
                              RichTextBox35.Text, RichTextBox36.Text, Label13.Text,
                              RichTextBox29.Text, RichTextBox34.Text, Label12.Text,
                              RichTextBox22.Text, RichTextBox24.Text, Label11.Text,
                              RichTextBox37.Text, RichTextBox38.Text, Label14.Text,
                              RichTextBox32.Text, RichTextBox33.Text, Label22.Text,
                              RichTextBox30.Text, RichTextBox31.Text, Label21.Text,
                              RichTextBox27.Text, RichTextBox28.Text, Label20.Text,
                              RichTextBox19.Text, RichTextBox26.Text, Label19.Text,
                              RichTextBox17.Text, RichTextBox18.Text, Label18.Text,
                              RichTextBox14.Text, RichTextBox15.Text, Label17.Text,
                              RichTextBox10.Text, RichTextBox13.Text, Label16.Text,
                              RichTextBox8.Text, RichTextBox9.Text, Label15.Text,
                              RichTextBox55.Text, RichTextBox56.Text, Label30.Text,
                              RichTextBox53.Text, RichTextBox54.Text, Label29.Text,
                              RichTextBox51.Text, RichTextBox52.Text, Label28.Text,
                              RichTextBox49.Text, RichTextBox50.Text, Label27.Text,
                              RichTextBox47.Text, RichTextBox48.Text, Label26.Text,
                              RichTextBox45.Text, RichTextBox46.Text, Label25.Text,
                              RichTextBox41.Text, RichTextBox44.Text, Label24.Text,
                              RichTextBox39.Text, RichTextBox40.Text, Label23.Text,
                              Label38.Text, Label37.Text, Label36.Text, Label35.Text, Label34.Text, Label33.Text, Label32.Text, Label31.Text,
                              RichTextBox6.Text, RichTextBox12.Text, RichTextBox7.Text, RichTextBox25.Text, RichTextBox23.Text, RichTextBox21.Text, RichTextBox43.Text, RichTextBox42.Text}
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click
            Try
                Dim n1 As Double = RichTextBox1.Text.Trim
                Dim n2 As Double = RichTextBox2.Text.Trim
            Label7.Text = (n1 + n2) / 2
            Catch ex As Exception
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
            End Try
    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click
        Dim average As Double
        If IsNumeric(RichTextBox3.Text) And IsNumeric(RichTextBox4.Text) Then
            'faz tudo
            Dim n3 As Double = RichTextBox3.Text.Trim
            Dim n4 As Double = RichTextBox4.Text.Trim
            average = (n3 + n4) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label8.Text = average 'Print(averege)
    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click
        Dim average As Double
        If IsNumeric(RichTextBox5.Text) And IsNumeric(RichTextBox11.Text) Then
            'faz tudo
            Dim n5 As Double = RichTextBox5.Text.Trim
            Dim n11 As Double = RichTextBox11.Text.Trim
            average = (n5 + n11) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label9.Text = average 'Print(averege)
    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click
        Dim average As Double
        If IsNumeric(RichTextBox16.Text) And IsNumeric(RichTextBox20.Text) Then
            'faz tudo
            Dim n16 As Double = RichTextBox16.Text.Trim
            Dim n20 As Double = RichTextBox20.Text.Trim
            average = (n16 + n20) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label10.Text = average 'Print(averege)
    End Sub

    Private Sub Label13_Click(sender As System.Object, e As System.EventArgs) Handles Label13.Click
        Dim average As Double
        If IsNumeric(RichTextBox35.Text) And IsNumeric(RichTextBox36.Text) Then
            'faz tudo
            Dim n35 As Double = RichTextBox1.Text.Trim
            Dim n36 As Double = RichTextBox2.Text.Trim
            average = (n35 + n36) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label13.Text = average 'Print(averege)
    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click
        Dim average As Double
        If IsNumeric(RichTextBox3.Text) And IsNumeric(RichTextBox4.Text) Then
            'faz tudo
            Dim n29 As Double = RichTextBox29.Text.Trim
            Dim n34 As Double = RichTextBox34.Text.Trim
            average = (n29 + n34) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label12.Text = average 'Print(averege)
    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click
        Dim average As Double
        If IsNumeric(RichTextBox22.Text) And IsNumeric(RichTextBox24.Text) Then
            'faz tudo
            Dim n22 As Double = RichTextBox22.Text.Trim
            Dim n24 As Double = RichTextBox24.Text.Trim
            average = (n22 + n24) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label11.Text = average 'Print(averege)
    End Sub

    Private Sub Label14_Click(sender As System.Object, e As System.EventArgs) Handles Label14.Click
        Dim average As Double
        If IsNumeric(RichTextBox37.Text) And IsNumeric(RichTextBox38.Text) Then
            'faz tudo
            Dim n37 As Double = RichTextBox37.Text.Trim
            Dim n38 As Double = RichTextBox38.Text.Trim
            average = (n37 + n38) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label14.Text = average 'Print(averege)
    End Sub

    Private Sub Label22_Click(sender As System.Object, e As System.EventArgs) Handles Label22.Click
        Dim average As Double
        If IsNumeric(RichTextBox32.Text) And IsNumeric(RichTextBox33.Text) Then
            'faz tudo
            Dim n32 As Double = RichTextBox32.Text.Trim
            Dim n33 As Double = RichTextBox33.Text.Trim
            average = (n32 + n33) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label22.Text = average 'Print(averege)
    End Sub

    Private Sub Label21_Click(sender As System.Object, e As System.EventArgs) Handles Label21.Click
        Dim average As Double
        If IsNumeric(RichTextBox30.Text) And IsNumeric(RichTextBox31.Text) Then
            'faz tudo
            Dim n30 As Double = RichTextBox30.Text.Trim
            Dim n31 As Double = RichTextBox31.Text.Trim
            average = (n30 + n31) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label21.Text = average 'Print(averege)
    End Sub

    Private Sub Label20_Click(sender As System.Object, e As System.EventArgs) Handles Label20.Click
        Dim average As Double
        If IsNumeric(RichTextBox27.Text) And IsNumeric(RichTextBox28.Text) Then
            'faz tudo
            Dim n27 As Double = RichTextBox27.Text.Trim
            Dim n28 As Double = RichTextBox28.Text.Trim
            average = (n27 + n28) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label20.Text = average 'Print(averege)
    End Sub

    Private Sub Label19_Click(sender As System.Object, e As System.EventArgs) Handles Label19.Click
        Dim average As Double
        If IsNumeric(RichTextBox19.Text) And IsNumeric(RichTextBox26.Text) Then
            'faz tudo
            Dim n19 As Double = RichTextBox19.Text.Trim
            Dim n26 As Double = RichTextBox26.Text.Trim
            average = (n19 + n26) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label19.Text = average 'Print(averege)
    End Sub

    Private Sub Label18_Click(sender As System.Object, e As System.EventArgs) Handles Label18.Click
        Dim average As Double
        If IsNumeric(RichTextBox17.Text) And IsNumeric(RichTextBox18.Text) Then
            'faz tudo
            Dim n17 As Double = RichTextBox17.Text.Trim
            Dim n18 As Double = RichTextBox18.Text.Trim
            average = (n17 + n18) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label18.Text = average 'Print(averege)
    End Sub

    Private Sub Label17_Click(sender As System.Object, e As System.EventArgs) Handles Label17.Click
        Dim average As Double
        If IsNumeric(RichTextBox14.Text) And IsNumeric(RichTextBox15.Text) Then
            'faz tudo
            Dim n14 As Double = RichTextBox15.Text.Trim
            Dim n15 As Double = RichTextBox15.Text.Trim
            average = (n14 + n15) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label17.Text = average 'Print(averege)
    End Sub

    Private Sub Label16_Click(sender As System.Object, e As System.EventArgs) Handles Label16.Click
        Dim average As Double
        If IsNumeric(RichTextBox10.Text) And IsNumeric(RichTextBox13.Text) Then
            'faz tudo
            Dim n10 As Double = RichTextBox10.Text.Trim
            Dim n13 As Double = RichTextBox13.Text.Trim
            average = (n10 + n13) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label16.Text = average 'Print(averege)
    End Sub

    Private Sub Label15_Click(sender As System.Object, e As System.EventArgs) Handles Label15.Click
        Dim average As Double
        If IsNumeric(RichTextBox8.Text) And IsNumeric(RichTextBox9.Text) Then
            'faz tudo
            Dim n8 As Double = RichTextBox8.Text.Trim
            Dim n9 As Double = RichTextBox9.Text.Trim
            average = (n8 + n9) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label15.Text = average 'Print(averege)
    End Sub

    Private Sub Label30_Click(sender As System.Object, e As System.EventArgs) Handles Label30.Click
        Dim average As Double
        If IsNumeric(RichTextBox55.Text) And IsNumeric(RichTextBox56.Text) Then
            'faz tudo
            Dim n55 As Double = RichTextBox55.Text.Trim
            Dim n56 As Double = RichTextBox56.Text.Trim
            average = (n55 + n56) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label30.Text = average 'Print(averege)
    End Sub

    Private Sub Label29_Click(sender As System.Object, e As System.EventArgs) Handles Label29.Click
        Dim average As Double
        If IsNumeric(RichTextBox53.Text) And IsNumeric(RichTextBox54.Text) Then
            'faz tudo
            Dim n53 As Double = RichTextBox53.Text.Trim
            Dim n54 As Double = RichTextBox54.Text.Trim
            average = (n53 + n54) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label29.Text = average 'Print(averege)
    End Sub

    Private Sub Label28_Click(sender As System.Object, e As System.EventArgs) Handles Label28.Click
        Dim average As Double
        If IsNumeric(RichTextBox51.Text) And IsNumeric(RichTextBox52.Text) Then
            'faz tudo
            Dim n51 As Double = RichTextBox51.Text.Trim
            Dim n52 As Double = RichTextBox52.Text.Trim
            average = (n51 + n52) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label28.Text = average 'Print(averege)
    End Sub

    Private Sub Label27_Click(sender As System.Object, e As System.EventArgs) Handles Label27.Click
        Dim average As Double
        If IsNumeric(RichTextBox49.Text) And IsNumeric(RichTextBox50.Text) Then
            'faz tudo
            Dim n49 As Double = RichTextBox49.Text.Trim
            Dim n50 As Double = RichTextBox50.Text.Trim
            average = (n49 + n50) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label27.Text = average 'Print(averege)
    End Sub

    Private Sub Label26_Click(sender As System.Object, e As System.EventArgs) Handles Label26.Click
        Dim average As Double
        If IsNumeric(RichTextBox47.Text) And IsNumeric(RichTextBox48.Text) Then
            'faz tudo
            Dim n47 As Double = RichTextBox47.Text.Trim
            Dim n48 As Double = RichTextBox48.Text.Trim
            average = (n47 + n48) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label26.Text = average 'Print(averege)
    End Sub

    Private Sub Label25_Click(sender As System.Object, e As System.EventArgs) Handles Label25.Click
        Dim average As Double
        If IsNumeric(RichTextBox45.Text) And IsNumeric(RichTextBox46.Text) Then
            'faz tudo
            Dim n45 As Double = RichTextBox45.Text.Trim
            Dim n46 As Double = RichTextBox46.Text.Trim
            average = (n45 + n46) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label25.Text = average 'Print(averege)
    End Sub

    Private Sub Label24_Click(sender As System.Object, e As System.EventArgs) Handles Label24.Click
        Dim average As Double
        If IsNumeric(RichTextBox41.Text) And IsNumeric(RichTextBox44.Text) Then
            'faz tudo
            Dim n41 As Double = RichTextBox41.Text.Trim
            Dim n44 As Double = RichTextBox44.Text.Trim
            average = (n41 + n44) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label24.Text = average 'Print(averege)
    End Sub

    Private Sub Label23_Click(sender As System.Object, e As System.EventArgs) Handles Label23.Click
        Dim average As Double
        If IsNumeric(RichTextBox39.Text) And IsNumeric(RichTextBox40.Text) Then
            'faz tudo
            Dim n39 As Double = RichTextBox39.Text.Trim
            Dim n40 As Double = RichTextBox40.Text.Trim
            average = (n39 + n40) / 2
        Else
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End If
        Label23.Text = average 'Print(averege)
    End Sub
    '================================================================
    '================================================================
    Private Sub Label37_Click(sender As System.Object, e As System.EventArgs) Handles Label37.Click
        '37 8 21 29
        Try
            Dim n1 As Double = Label8.Text
            Dim n22 As Double = Label21.Text
            Dim n30 As Double = Label29.Text
            Dim media As Integer = (n1 + n22 + n30) / 3

            Label37.Text = media
        Catch ex As Exception
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End Try
    End Sub

    Private Sub Label36_Click(sender As System.Object, e As System.EventArgs) Handles Label36.Click
        '36 9 20 28
        Try
            Dim n1 As Double = Label9.Text
            Dim n22 As Double = Label20.Text
            Dim n30 As Double = Label28.Text
            Dim media As Integer = (n1 + n22 + n30) / 3

            Label36.Text = media
        Catch ex As Exception
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End Try
    End Sub

    Private Sub Label35_Click(sender As System.Object, e As System.EventArgs) Handles Label35.Click
        '35 10 19 27
        Try
            Dim n1 As Double = Label10.Text
            Dim n22 As Double = Label19.Text
            Dim n30 As Double = Label27.Text
            Dim media As Integer = (n1 + n22 + n30) / 3

            Label35.Text = media
        Catch ex As Exception
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End Try
    End Sub

    Private Sub Label34_Click(sender As System.Object, e As System.EventArgs) Handles Label34.Click
        '34 13 18 26
        Try
            Dim n1 As Double = Label13.Text
            Dim n22 As Double = Label18.Text
            Dim n30 As Double = Label26.Text
            Dim media As Integer = (n1 + n22 + n30) / 3

            Label34.Text = media
        Catch ex As Exception
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End Try
    End Sub

    Private Sub Label33_Click(sender As System.Object, e As System.EventArgs) Handles Label33.Click
        '33 12 17 25
        Try
            Dim n1 As Double = Label12.Text
            Dim n22 As Double = Label17.Text
            Dim n30 As Double = Label25.Text
            Dim media As Integer = (n1 + n22 + n30) / 3

            Label33.Text = media
        Catch ex As Exception
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End Try
    End Sub

    Private Sub Label32_Click(sender As System.Object, e As System.EventArgs) Handles Label32.Click
        '32 11 16 24
        Try
            Dim n1 As Double = Label11.Text
            Dim n22 As Double = Label16.Text
            Dim n30 As Double = Label24.Text
            Dim media As Integer = (n1 + n22 + n30) / 3

            Label32.Text = media
        Catch ex As Exception
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End Try
    End Sub

    Private Sub Label31_Click(sender As System.Object, e As System.EventArgs) Handles Label31.Click
        '31 14 15 23
        Try
            Dim n1 As Double = Label14.Text
            Dim n22 As Double = Label15.Text
            Dim n30 As Double = Label23.Text
            Dim media As Integer = (n1 + n22 + n30) / 3

            Label31.Text = media
        Catch ex As Exception
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End Try
    End Sub

    Private Sub Label39_Click(sender As System.Object, e As System.EventArgs) Handles Label39.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Label38_Click(sender As System.Object, e As System.EventArgs) Handles Label38.Click
        Try
            Dim n1 As Double = Label7.Text
            Dim n22 As Double = Label22.Text
            Dim n30 As Double = Label30.Text
            Dim media As Integer = (n1 + n22 + n30) / 3

            Label38.Text = media
        Catch ex As Exception
            MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
        End Try

    End Sub

    Private Sub RichTextBox2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox2.KeyDown
        Select Case e.KeyCode
            'Case Keys.Up
            '    RichTextBox1.Focus()
            Case Keys.Down
                RichTextBox3.Focus()
            Case Keys.Right
                RichTextBox1.Focus()
                'Case Keys.Left
                '    RichTextBox1.Focus()
        End Select

    End Sub
End Class
' ^(); \/(); <(); >()
