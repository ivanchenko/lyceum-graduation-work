Public Class TestsFrm
    Dim randomNumbersQuestion(11) As Integer
    Dim randomNumbersAnswers(3) As Integer
    Dim nbrQuestion As Integer
    Dim studentAnswers(11) As String
    Dim mark As Integer
    Sub generateRandomNumbers()
        Dim rnd As Integer
        Dim r As New Random
        Dim swap As Integer

        For i = 0 To 11
            randomNumbersQuestion(i) = i + 1
        Next

        For i = 0 To 11
            rnd = r.Next(1, 50)
            swap = randomNumbersQuestion((i + rnd) Mod 11)
            randomNumbersQuestion((i + rnd) Mod 11) = randomNumbersQuestion(i)
            randomNumbersQuestion(i) = swap
        Next

        For i = 0 To 3
            randomNumbersAnswers(i) = i + 1
        Next

        For i = 0 To 3
            rnd = r.Next(1, 50)
            swap = randomNumbersAnswers((i + rnd) Mod 3)
            randomNumbersAnswers((i + rnd) Mod 3) = randomNumbersAnswers(i)
            randomNumbersAnswers(i) = swap
        Next

    End Sub

    Sub showQuestion()
        RichTextBox1.LoadFile(Application.StartupPath & "\Test\" & randomNumbersQuestion(nbrQuestion) & ".rtf")
        FileOpen(1, Application.StartupPath & "\Test\" & randomNumbersQuestion(nbrQuestion) & ".txt", OpenMode.Input)

        Dim s(3) As String

        For i = 0 To 3
            s(i) = LineInput(1)
        Next

        FileClose()
        RadioButton1.Text = s(randomNumbersAnswers(0) - 1)
        RadioButton2.Text = s(randomNumbersAnswers(1) - 1)
        RadioButton3.Text = s(randomNumbersAnswers(2) - 1)
        RadioButton4.Text = s(randomNumbersAnswers(3) - 1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        writeAnswer()

        nbrQuestion -= 1
        showQuestion()

        Label1.Text = "Питання " & nbrQuestion + 1 & "/12"" "

        If nbrQuestion = 0 Then
            Button1.Enabled = False
        ElseIf nbrQuestion <> 11 Then
            Button2.Enabled = True
        Else
            Button1.Enabled = True
        End If
    
        checkedAnswer()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        writeAnswer()

        nbrQuestion += 1
        showQuestion()

        Label1.Text = "Питання " & nbrQuestion + 1 & "/12"" "

        If nbrQuestion = 11 Then
            Button2.Enabled = False
        ElseIf nbrQuestion <> 0 Then
            Button1.Enabled = True
        Else
            Button2.Enabled = True
        End If

        checkedAnswer()
    End Sub

    Sub checkedAnswer()
        If studentAnswers(randomNumbersQuestion(nbrQuestion) - 1) = "" Then
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
        Else
            If studentAnswers(randomNumbersQuestion(nbrQuestion) - 1) = RadioButton1.Text Then
                RadioButton1.Checked = True
            ElseIf studentAnswers(randomNumbersQuestion(nbrQuestion) - 1) = RadioButton2.Text Then
                RadioButton2.Checked = True
            ElseIf studentAnswers(randomNumbersQuestion(nbrQuestion) - 1) = RadioButton3.Text Then
                RadioButton3.Checked = True
            ElseIf studentAnswers(randomNumbersQuestion(nbrQuestion) - 1) = RadioButton4.Text Then
                RadioButton4.Checked = True
            End If
        End If

    End Sub

    Sub writeAnswer()
        If RadioButton1.Checked = True Then
            studentAnswers(randomNumbersQuestion(nbrQuestion) - 1) = RadioButton1.Text
        End If
        If RadioButton2.Checked = True Then
            studentAnswers(randomNumbersQuestion(nbrQuestion) - 1) = RadioButton2.Text
        End If
        If RadioButton3.Checked = True Then
            studentAnswers(randomNumbersQuestion(nbrQuestion) - 1) = RadioButton3.Text
        End If
        If RadioButton4.Checked = True Then
            studentAnswers(randomNumbersQuestion(nbrQuestion) - 1) = RadioButton4.Text
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        writeAnswer()
        Dim answer(11) As String
        answer(0) = "...вектор магнітної індукції"
        answer(1) = "20 А"
        answer(2) = "Магнітною проникністю середовища"
        answer(3) = "…замкнуті"
        answer(4) = "…електричний заряд, що рухається"
        answer(5) = "…тесла"
        answer(6) = "Феромагнетики"
        answer(7) = "провідники відштовхуються"
        answer(8) = "збільшується в 9 разів"
        answer(9) = "0,004 Тл"
        answer(10) = "90"
        answer(11) = "0,1 Тл"


        For i = 0 To 11
            If studentAnswers(i) = answer(i) Then
                mark = mark + 1
            End If
        Next
        FileClose()

        MsgBox("Ваша оцінка: " & mark, , "")
        Button6.PerformClick()

    End Sub

    Private Sub TestsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateRandomNumbers()
        nbrQuestion = 0
        showQuestion()
        mark = 0
        Me.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath & "\Images\BackGround.jpg")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MenuFrm.Show()
        Me.Close()
        If MenuFrm.window <> MenuFrm.WindowState Then
            MenuFrm.Button4.PerformClick()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.Exit()
    End Sub
End Class