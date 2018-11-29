
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
            If n1 < 0 Or n2 < 0 Then
                MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
            Else
                Label7.Text = (n1 + n2) / 2
            End If
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
            If n3 < 0 Or n4 < 0 Then
                MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
            Else
                average = (n3 + n4) / 2
            End If
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
            If n5 < 0 Or n11 < 0 Then
                MessageBox.Show("deu erro volta a trás e para de gozar com o nosso trabalho")
            Else
                average = (n5 + n11) / 2
            End If
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
            Case Keys.Left
                RichTextBox6.Focus()
        End Select

    End Sub

    Private Sub RichTextBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyDown
        Select Case e.KeyCode
            'Case Keys.Up
            '    RichTextBox1.Focus()
            Case Keys.Down
                RichTextBox4.Focus()
            Case Keys.Right
                RichTextBox32.Focus()
            Case Keys.Left
                RichTextBox2.Focus()
        End Select
    End Sub

    Private Sub RichTextBox6_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox6.KeyDown
        Select Case e.KeyCode
            'Case Keys.Up
            '    RichTextBox1.Focus()
            Case Keys.Down
                RichTextBox12.Focus()
            Case Keys.Right
                RichTextBox2.Focus()
                'Case Keys.Left
                '    RichTextBox1.Focus()
        End Select
    End Sub

    Private Sub RichTextBox32_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox32.KeyDown
        Select Case e.KeyCode
            'Case Keys.Up
            '    RichTextBox1.Focus()
            Case Keys.Down
                RichTextBox30.Focus()
            Case Keys.Right
                RichTextBox33.Focus()
            Case Keys.Left
                RichTextBox1.Focus()
        End Select
    End Sub

    Private Sub RichTextBox33_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox33.KeyDown
        Select Case e.KeyCode
            'Case Keys.Up
            '    RichTextBox1.Focus()
            Case Keys.Down
                RichTextBox31.Focus()
            Case Keys.Right
                RichTextBox55.Focus()
            Case Keys.Left
                RichTextBox32.Focus()
        End Select
    End Sub

    Private Sub RichTextBox55_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox55.KeyDown
        Select Case e.KeyCode
            'Case Keys.Up
            '    RichTextBox1.Focus()
            Case Keys.Down
                RichTextBox53.Focus()
            Case Keys.Right
                RichTextBox56.Focus()
            Case Keys.Left
                RichTextBox33.Focus()
        End Select
    End Sub

    Private Sub RichTextBox56_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox56.KeyDown
        Select Case e.KeyCode
            'Case Keys.Up
            '    RichTextBox1.Focus()
            Case Keys.Down
                RichTextBox54.Focus()
                'Case Keys.Right
                '   RichTextBox1.Focus()
            Case Keys.Left
                RichTextBox55.Focus()
        End Select
    End Sub

    Private Sub RichTextBox12_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox12.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox6.Focus()
            Case Keys.Down
                RichTextBox7.Focus()
            Case Keys.Right
                RichTextBox3.Focus()
                'Case Keys.Left
                '    RichTextBox1.Focus()
        End Select
    End Sub

    Private Sub RichTextBox3_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox3.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox2.Focus()
            Case Keys.Down
                RichTextBox5.Focus()
            Case Keys.Right
                RichTextBox4.Focus()
            Case Keys.Left
                RichTextBox12.Focus()
        End Select
    End Sub

    Private Sub RichTextBox4_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox4.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox1.Focus()
            Case Keys.Down
                RichTextBox11.Focus()
            Case Keys.Right
                RichTextBox30.Focus()
            Case Keys.Left
                RichTextBox3.Focus()
        End Select
    End Sub

    Private Sub RichTextBox30_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox30.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox32.Focus()
            Case Keys.Down
                RichTextBox27.Focus()
            Case Keys.Right
                RichTextBox31.Focus()
            Case Keys.Left
                RichTextBox4.Focus()
        End Select
    End Sub

    Private Sub RichTextBox31_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox33.Focus()
            Case Keys.Down
                RichTextBox28.Focus()
            Case Keys.Right
                RichTextBox53.Focus()
            Case Keys.Left
                RichTextBox30.Focus()
        End Select
    End Sub

    Private Sub RichTextBox53_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox53.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox55.Focus()
            Case Keys.Down
                RichTextBox51.Focus()
            Case Keys.Right
                RichTextBox54.Focus()
            Case Keys.Left
                RichTextBox31.Focus()
        End Select
    End Sub

    Private Sub RichTextBox54_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox54.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox56.Focus()
            Case Keys.Down
                RichTextBox52.Focus()
                'Case Keys.Right
                'RichTextBox1.Focus()
            Case Keys.Left
                RichTextBox53.Focus()
        End Select
    End Sub

    Private Sub RichTextBox7_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox7.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox12.Focus()
            Case Keys.Down
                RichTextBox25.Focus()
            Case Keys.Right
                RichTextBox5.Focus()
                'Case Keys.Left
                '    RichTextBox1.Focus()
        End Select
    End Sub

    Private Sub RichTextBox5_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox5.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox3.Focus()
            Case Keys.Down
                RichTextBox16.Focus()
            Case Keys.Right
                RichTextBox11.Focus()
            Case Keys.Left
                RichTextBox7.Focus()
        End Select
    End Sub

    Private Sub RichTextBox11_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox11.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox4.Focus()
            Case Keys.Down
                RichTextBox20.Focus()
            Case Keys.Right
                RichTextBox27.Focus()
            Case Keys.Left
                RichTextBox5.Focus()
        End Select
    End Sub

    Private Sub RichTextBox27_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox27.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox30.Focus()
            Case Keys.Down
                RichTextBox19.Focus()
            Case Keys.Right
                RichTextBox28.Focus()
            Case Keys.Left
                RichTextBox11.Focus()
        End Select
    End Sub

    Private Sub RichTextBox28_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox28.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox31.Focus()
            Case Keys.Down
                RichTextBox26.Focus()
            Case Keys.Right
                RichTextBox51.Focus()
            Case Keys.Left
                RichTextBox27.Focus()
        End Select
    End Sub

    Private Sub RichTextBox51_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox51.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox53.Focus()
            Case Keys.Down
                RichTextBox49.Focus()
            Case Keys.Right
                RichTextBox52.Focus()
            Case Keys.Left
                RichTextBox28.Focus()
        End Select
    End Sub

    Private Sub RichTextBox52_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox52.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox54.Focus()
            Case Keys.Down
                RichTextBox50.Focus()
                'Case Keys.Right
                'RichTextBox1.Focus()
            Case Keys.Left
                RichTextBox51.Focus()
        End Select
    End Sub

    Private Sub RichTextBox25_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox25.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox7.Focus()
            Case Keys.Down
                RichTextBox23.Focus()
            Case Keys.Right
                RichTextBox16.Focus()
                'Case Keys.Left
                '    RichTextBox1.Focus()
        End Select
    End Sub

    Private Sub RichTextBox16_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox16.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox5.Focus()
            Case Keys.Down
                RichTextBox35.Focus()
            Case Keys.Right
                RichTextBox20.Focus()
            Case Keys.Left
                RichTextBox25.Focus()
        End Select
    End Sub

    Private Sub RichTextBox20_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox20.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox11.Focus()
            Case Keys.Down
                RichTextBox36.Focus()
            Case Keys.Right
                RichTextBox19.Focus()
            Case Keys.Left
                RichTextBox16.Focus()
        End Select
    End Sub

    Private Sub RichTextBox19_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox19.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox27.Focus()
            Case Keys.Down
                RichTextBox17.Focus()
            Case Keys.Right
                RichTextBox26.Focus()
            Case Keys.Left
                RichTextBox20.Focus()
        End Select
    End Sub

    Private Sub RichTextBox26_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox26.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox28.Focus()
            Case Keys.Down
                RichTextBox18.Focus()
            Case Keys.Right
                RichTextBox49.Focus()
            Case Keys.Left
                RichTextBox19.Focus()
        End Select
    End Sub

    Private Sub RichTextBox49_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox49.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox51.Focus()
            Case Keys.Down
                RichTextBox47.Focus()
            Case Keys.Right
                RichTextBox50.Focus()
            Case Keys.Left
                RichTextBox26.Focus()
        End Select
    End Sub

    Private Sub RichTextBox50_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox50.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox52.Focus()
            Case Keys.Down
                RichTextBox48.Focus()
                'Case Keys.Right
                'RichTextBox49.Focus()
            Case Keys.Left
                RichTextBox49.Focus()
        End Select
    End Sub

    Private Sub RichTextBox23_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox23.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox25.Focus()
            Case Keys.Down
                RichTextBox21.Focus()
            Case Keys.Right
                RichTextBox35.Focus()
                'Case Keys.Left
                '    RichTextBox1.Focus()
        End Select
    End Sub



    Private Sub RichTextBox35_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox35.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox16.Focus()
            Case Keys.Down
                RichTextBox29.Focus()
            Case Keys.Right
                RichTextBox36.Focus()
            Case Keys.Left
                RichTextBox23.Focus()
        End Select
    End Sub

    Private Sub RichTextBox34_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox34.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox36.Focus()
            Case Keys.Down
                RichTextBox24.Focus()
            Case Keys.Right
                RichTextBox14.Focus()
            Case Keys.Left
                RichTextBox29.Focus()
        End Select
    End Sub

    Private Sub RichTextBox36_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox36.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox20.Focus()
            Case Keys.Down
                RichTextBox34.Focus()
            Case Keys.Right
                RichTextBox17.Focus()
            Case Keys.Left
                RichTextBox35.Focus()
        End Select
    End Sub

    Private Sub RichTextBox17_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox17.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox19.Focus()
            Case Keys.Down
                RichTextBox14.Focus()
            Case Keys.Right
                RichTextBox18.Focus()
            Case Keys.Left
                RichTextBox36.Focus()
        End Select
    End Sub

    Private Sub RichTextBox18_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox18.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox26.Focus()
            Case Keys.Down
                RichTextBox15.Focus()
            Case Keys.Right
                RichTextBox47.Focus()
            Case Keys.Left
                RichTextBox17.Focus()
        End Select
    End Sub


    Private Sub RichTextBox47_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox47.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox49.Focus()
            Case Keys.Down
                RichTextBox45.Focus()
            Case Keys.Right
                RichTextBox48.Focus()
            Case Keys.Left
                RichTextBox18.Focus()
        End Select
    End Sub


    Private Sub RichTextBox48_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox48.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox50.Focus()
            Case Keys.Down
                RichTextBox46.Focus()
                'Case Keys.Right
                'RichTextBox18.Focus()
            Case Keys.Left
                RichTextBox47.Focus()
        End Select
    End Sub

    Private Sub RichTextBox21_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox21.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox23.Focus()
            Case Keys.Down
                RichTextBox43.Focus()
            Case Keys.Right
                RichTextBox29.Focus()
                'Case Keys.Left
                'RichTextBox36.Focus()
        End Select
    End Sub

    Private Sub RichTextBox29_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox29.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox35.Focus()
            Case Keys.Down
                RichTextBox22.Focus()
            Case Keys.Right
                RichTextBox34.Focus()
            Case Keys.Left
                RichTextBox21.Focus()
        End Select
    End Sub

    Private Sub RichTextBox14_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox14.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox17.Focus()
            Case Keys.Down
                RichTextBox10.Focus()
            Case Keys.Right
                RichTextBox15.Focus()
            Case Keys.Left
                RichTextBox34.Focus()
        End Select
    End Sub

    Private Sub RichTextBox15_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox15.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox18.Focus()
            Case Keys.Down
                RichTextBox13.Focus()
            Case Keys.Right
                RichTextBox45.Focus()
            Case Keys.Left
                RichTextBox14.Focus()
        End Select
    End Sub

    Private Sub RichTextBox45_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox45.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox47.Focus()
            Case Keys.Down
                RichTextBox41.Focus()
            Case Keys.Right
                RichTextBox46.Focus()
            Case Keys.Left
                RichTextBox15.Focus()
        End Select
    End Sub

    Private Sub RichTextBox46_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox46.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox48.Focus()
            Case Keys.Down
                RichTextBox44.Focus()
                'Case Keys.Right
                'RichTextBox18.Focus()
            Case Keys.Left
                RichTextBox45.Focus()
        End Select
    End Sub

    Private Sub RichTextBox43_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox43.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox21.Focus()
            Case Keys.Down
                RichTextBox42.Focus()
            Case Keys.Right
                RichTextBox22.Focus()
                'Case Keys.Left
                'RichTextBox36.Focus()
        End Select
    End Sub

    Private Sub RichTextBox22_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox22.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox29.Focus()
            Case Keys.Down
                RichTextBox37.Focus()
            Case Keys.Right
                RichTextBox24.Focus()
            Case Keys.Left
                RichTextBox43.Focus()
        End Select
    End Sub


    Private Sub RichTextBox24_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox24.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox34.Focus()
            Case Keys.Down
                RichTextBox38.Focus()
            Case Keys.Right
                RichTextBox10.Focus()
            Case Keys.Left
                RichTextBox22.Focus()
        End Select
    End Sub

    Private Sub RichTextBox10_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox10.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox14.Focus()
            Case Keys.Down
                RichTextBox8.Focus()
            Case Keys.Right
                RichTextBox13.Focus()
            Case Keys.Left
                RichTextBox24.Focus()
        End Select
    End Sub

    Private Sub RichTextBox13_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox13.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox15.Focus()
            Case Keys.Down
                RichTextBox9.Focus()
            Case Keys.Right
                RichTextBox41.Focus()
            Case Keys.Left
                RichTextBox10.Focus()
        End Select
    End Sub

    Private Sub RichTextBox41_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox41.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox45.Focus()
            Case Keys.Down
                RichTextBox39.Focus()
            Case Keys.Right
                RichTextBox44.Focus()
            Case Keys.Left
                RichTextBox13.Focus()
        End Select
    End Sub

    Private Sub RichTextBox44_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox44.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox46.Focus()
            Case Keys.Down
                RichTextBox40.Focus()
                'Case Keys.Right
                'RichTextBox18.Focus()
            Case Keys.Left
                RichTextBox41.Focus()
        End Select
    End Sub

    Private Sub RichTextBox42_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox42.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox43.Focus()
                'Case Keys.Down
                'RichTextBox14.Focus()
            Case Keys.Right
                RichTextBox37.Focus()
                'Case Keys.Left
                'RichTextBox36.Focus()
        End Select
    End Sub

    Private Sub RichTextBox37_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox37.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox22.Focus()
                'Case Keys.Down
                'RichTextBox14.Focus()
            Case Keys.Right
                RichTextBox38.Focus()
            Case Keys.Left
                RichTextBox42.Focus()
        End Select
    End Sub

    Private Sub RichTextBox38_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox38.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox24.Focus()
                'Case Keys.Down
                'RichTextBox12.Focus()
            Case Keys.Right
                RichTextBox8.Focus()
            Case Keys.Left
                RichTextBox37.Focus()
        End Select
    End Sub

    Private Sub RichTextBox8_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox8.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox10.Focus()
                'Case Keys.Down
                'RichTextBox14.Focus()
            Case Keys.Right
                RichTextBox9.Focus()
            Case Keys.Left
                RichTextBox38.Focus()
        End Select
    End Sub

    Private Sub RichTextBox9_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox9.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox13.Focus()
            Case Keys.Right
                RichTextBox39.Focus()
            Case Keys.Left
                RichTextBox8.Focus()
        End Select
    End Sub

    Private Sub RichTextBox39_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox39.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox41.Focus()
                'Case Keys.Down
                'RichTextBox14.Focus()
            Case Keys.Right
                RichTextBox40.Focus()
            Case Keys.Left
                RichTextBox9.Focus()
        End Select
    End Sub

    Private Sub RichTextBox40_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox40.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox44.Focus()
                'Case Keys.Down
                'RichTextBox14.Focus()
                'Case Keys.Right
                'RichTextBox18.Focus()
            Case Keys.Left
                RichTextBox39.Focus()
        End Select
    End Sub

    Private Sub RichTextBox31_KeyDown_1(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox31.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                RichTextBox33.Focus()
            Case Keys.Down
                RichTextBox28.Focus()
            Case Keys.Right
                RichTextBox53.Focus()
            Case Keys.Left
                RichTextBox30.Focus()
        End Select
    End Sub

    Private Sub RichTextBox6_Leave(sender As System.Object, e As System.EventArgs) Handles RichTextBox6.Leave
        If RichTextBox6.TextLength < 0 Or (RichTextBox6.Text = RichTextBox12.Text And RichTextBox12.TextLength > 0) Or (RichTextBox6.Text = RichTextBox7.Text And RichTextBox7.TextLength > 0) Or (RichTextBox6.Text = RichTextBox25.Text And RichTextBox25.TextLength > 0) Or (RichTextBox6.Text = RichTextBox23.Text And RichTextBox23.TextLength > 0) Or (RichTextBox6.Text = RichTextBox21.Text And RichTextBox21.TextLength > 0) Or (RichTextBox6.Text = RichTextBox43.Text And RichTextBox43.TextLength > 0) Or (RichTextBox6.Text = RichTextBox42.Text And RichTextBox42.TextLength > 0) Then
            MessageBox.Show("Duas disciplinas iguais? A sério?")
            RichTextBox6.Clear()
        End If
    End Sub

    Private Sub RichTextBox12_Leave(sender As System.Object, e As System.EventArgs) Handles RichTextBox12.Leave
        If RichTextBox12.TextLength < 0 Or (RichTextBox12.Text = RichTextBox6.Text And RichTextBox12.TextLength > 0) Or (RichTextBox12.Text = RichTextBox7.Text And RichTextBox7.TextLength > 0) Or (RichTextBox12.Text = RichTextBox25.Text And RichTextBox25.TextLength > 0) Or (RichTextBox12.Text = RichTextBox23.Text And RichTextBox23.TextLength > 0) Or (RichTextBox12.Text = RichTextBox21.Text And RichTextBox21.TextLength > 0) Or (RichTextBox12.Text = RichTextBox43.Text And RichTextBox43.TextLength > 0) Or (RichTextBox12.Text = RichTextBox42.Text And RichTextBox42.TextLength > 0) Then
            MessageBox.Show("Duas disciplinas iguais? A sério?")
            RichTextBox12.Clear()
        End If
    End Sub

    Private Sub RichTextBox7_Leave(sender As System.Object, e As System.EventArgs) Handles RichTextBox7.Leave
        If RichTextBox7.TextLength < 0 Or (RichTextBox7.Text = RichTextBox6.Text And RichTextBox12.TextLength > 0) Or (RichTextBox7.Text = RichTextBox7.Text And RichTextBox7.TextLength > 0) Or (RichTextBox7.Text = RichTextBox25.Text And RichTextBox25.TextLength > 0) Or (RichTextBox7.Text = RichTextBox23.Text And RichTextBox23.TextLength > 0) Or (RichTextBox7.Text = RichTextBox21.Text And RichTextBox21.TextLength > 0) Or (RichTextBox7.Text = RichTextBox43.Text And RichTextBox43.TextLength > 0) Or (RichTextBox7.Text = RichTextBox42.Text And RichTextBox42.TextLength > 0) Then
            MessageBox.Show("Duas disciplinas iguais? A sério?")
            RichTextBox7.Clear()
        End If
    End Sub

    Private Sub RichTextBox25_Leave(sender As System.Object, e As System.EventArgs) Handles RichTextBox25.Leave
        If RichTextBox25.TextLength < 0 Or (RichTextBox25.Text = RichTextBox6.Text And RichTextBox12.TextLength > 0) Or (RichTextBox25.Text = RichTextBox7.Text And RichTextBox7.TextLength > 0) Or (RichTextBox25.Text = RichTextBox25.Text And RichTextBox25.TextLength > 0) Or (RichTextBox25.Text = RichTextBox23.Text And RichTextBox23.TextLength > 0) Or (RichTextBox25.Text = RichTextBox21.Text And RichTextBox21.TextLength > 0) Or (RichTextBox25.Text = RichTextBox43.Text And RichTextBox43.TextLength > 0) Or (RichTextBox25.Text = RichTextBox42.Text And RichTextBox42.TextLength > 0) Then
            MessageBox.Show("Duas disciplinas iguais? A sério?")
            RichTextBox25.Clear()
        End If
    End Sub

    Private Sub RichTextBox23_Leave(sender As System.Object, e As System.EventArgs) Handles RichTextBox23.Leave
        If RichTextBox23.TextLength < 0 Or (RichTextBox23.Text = RichTextBox6.Text And RichTextBox12.TextLength > 0) Or (RichTextBox23.Text = RichTextBox7.Text And RichTextBox7.TextLength > 0) Or (RichTextBox23.Text = RichTextBox25.Text And RichTextBox25.TextLength > 0) Or (RichTextBox23.Text = RichTextBox23.Text And RichTextBox23.TextLength > 0) Or (RichTextBox23.Text = RichTextBox21.Text And RichTextBox21.TextLength > 0) Or (RichTextBox23.Text = RichTextBox43.Text And RichTextBox43.TextLength > 0) Or (RichTextBox23.Text = RichTextBox42.Text And RichTextBox42.TextLength > 0) Then
            MessageBox.Show("Duas disciplinas iguais? A sério?")
            RichTextBox23.Clear()
        End If
    End Sub

    Private Sub RichTextBox21_Leave(sender As System.Object, e As System.EventArgs) Handles RichTextBox21.Leave
        If RichTextBox21.TextLength < 0 Or (RichTextBox21.Text = RichTextBox6.Text And RichTextBox12.TextLength > 0) Or (RichTextBox21.Text = RichTextBox7.Text And RichTextBox7.TextLength > 0) Or (RichTextBox21.Text = RichTextBox25.Text And RichTextBox25.TextLength > 0) Or (RichTextBox21.Text = RichTextBox23.Text And RichTextBox23.TextLength > 0) Or (RichTextBox21.Text = RichTextBox21.Text And RichTextBox21.TextLength > 0) Or (RichTextBox21.Text = RichTextBox43.Text And RichTextBox43.TextLength > 0) Or (RichTextBox21.Text = RichTextBox42.Text And RichTextBox42.TextLength > 0) Then
            MessageBox.Show("Duas disciplinas iguais? A sério?")
            RichTextBox21.Clear()
        End If
    End Sub

    Private Sub RichTextBox43_Leave(sender As System.Object, e As System.EventArgs) Handles RichTextBox43.Leave
        If RichTextBox43.TextLength < 0 Or (RichTextBox43.Text = RichTextBox6.Text And RichTextBox12.TextLength > 0) Or (RichTextBox43.Text = RichTextBox7.Text And RichTextBox7.TextLength > 0) Or (RichTextBox43.Text = RichTextBox25.Text And RichTextBox25.TextLength > 0) Or (RichTextBox43.Text = RichTextBox23.Text And RichTextBox23.TextLength > 0) Or (RichTextBox43.Text = RichTextBox21.Text And RichTextBox21.TextLength > 0) Or (RichTextBox43.Text = RichTextBox43.Text And RichTextBox43.TextLength > 0) Or (RichTextBox43.Text = RichTextBox42.Text And RichTextBox42.TextLength > 0) Then
            MessageBox.Show("Duas disciplinas iguais? A sério?")
            RichTextBox43.Clear()
        End If
    End Sub

    Private Sub RichTextBox42_Leave(sender As System.Object, e As System.EventArgs) Handles RichTextBox42.Leave
        If RichTextBox42.TextLength < 0 Or (RichTextBox42.Text = RichTextBox6.Text And RichTextBox12.TextLength > 0) Or (RichTextBox42.Text = RichTextBox7.Text And RichTextBox7.TextLength > 0) Or (RichTextBox42.Text = RichTextBox25.Text And RichTextBox25.TextLength > 0) Or (RichTextBox42.Text = RichTextBox23.Text And RichTextBox23.TextLength > 0) Or (RichTextBox42.Text = RichTextBox21.Text And RichTextBox21.TextLength > 0) Or (RichTextBox42.Text = RichTextBox43.Text And RichTextBox43.TextLength > 0) Or (RichTextBox42.Text = RichTextBox42.Text And RichTextBox42.TextLength > 0) Then
            MessageBox.Show("Duas disciplinas iguais? A sério?")
            RichTextBox42.Clear()
        End If
    End Sub
End Class
' ^(); \/(); <(); >()
