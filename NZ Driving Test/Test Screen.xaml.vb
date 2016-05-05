Public Class Test_Screen
    Dim objDM As New Database_Manager
    Dim QuestionNumber As Integer = 0
    Dim Questions = objDM.QuestionDetails()
    Dim Answer = Questions.Rows(QuestionNumber).Item(6)
    Dim Score As Integer = 0


    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Try
            tbQuestion.Text = Questions.Rows(QuestionNumber).Item(0)

            tbA.Text = Questions.Rows(QuestionNumber).Item(2)
            tbB.Text = Questions.Rows(QuestionNumber).Item(3)
            tbC.Text = Questions.Rows(QuestionNumber).Item(4)
            tbD.Text = Questions.Rows(QuestionNumber).Item(5)

            'image.Source = 

        Catch ex As Exception

        End Try


    End Sub


    Private Sub btnNext_Click(sender As Object, e As RoutedEventArgs) Handles btnNext.Click
        If QuestionNumber < 34 Then
            QuestionNumber += 1
            lblNum.Content += 1
        ElseIf QuestionNumber = 34 Then
            MsgBox(Score)
            If MsgBox("Get results?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                Dim ScoreScreen As New Score_Screen
                Me.Close()
                ScoreScreen.ShowDialog()
            End If

        End If



        Try
            tbQuestion.Text = Questions.Rows(QuestionNumber).Item(0)

            tbA.Text = Questions.Rows(QuestionNumber).Item(2)
            tbB.Text = Questions.Rows(QuestionNumber).Item(3)
            tbC.Text = Questions.Rows(QuestionNumber).Item(4)
            tbD.Text = Questions.Rows(QuestionNumber).Item(5)
        Catch ex As Exception

        End Try


    End Sub


    Private Sub btnPrev_Click(sender As Object, e As RoutedEventArgs) Handles btnPrev.Click
        If QuestionNumber > 0 Then
            QuestionNumber -= 1
            lblNum.Content -= 1
        Else
            MsgBox("No previous questions.")

        End If

        Try
            tbQuestion.Text = Questions.Rows(QuestionNumber).Item(0)

            tbA.Text = Questions.Rows(QuestionNumber).Item(2)
            tbB.Text = Questions.Rows(QuestionNumber).Item(3)
            tbC.Text = Questions.Rows(QuestionNumber).Item(4)
            tbD.Text = Questions.Rows(QuestionNumber).Item(5)
        Catch ex As Exception

        End Try


    End Sub


    Private Sub btnSkip_Click(sender As Object, e As RoutedEventArgs) Handles btnSkip.Click
        If QuestionNumber < 34 Then
            QuestionNumber += 1
            lblNum.Content += 1
        Else
            MsgBox("This is the last question.")

        End If

        Try
            tbQuestion.Text = Questions.Rows(QuestionNumber).Item(0)

            tbA.Text = Questions.Rows(QuestionNumber).Item(2)
            tbB.Text = Questions.Rows(QuestionNumber).Item(3)
            tbC.Text = Questions.Rows(QuestionNumber).Item(4)
            tbD.Text = Questions.Rows(QuestionNumber).Item(5)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnA_Click(sender As Object, e As RoutedEventArgs) Handles btnA.Click
        If Questions.Rows(QuestionNumber).Item(6) = "A" Then
            Score += 1

        End If

    End Sub

    Private Sub btnB_Click(sender As Object, e As RoutedEventArgs) Handles btnB.Click
        If Questions.Rows(QuestionNumber).Item(6) = "B" Then
            Score += 1

        End If

    End Sub

    Private Sub btnC_Click(sender As Object, e As RoutedEventArgs) Handles btnC.Click
        If Questions.Rows(QuestionNumber).Item(6) = "C" Then
            Score += 1

        End If

    End Sub

    Private Sub btnD_Click(sender As Object, e As RoutedEventArgs) Handles btnD.Click
        If Questions.Rows(QuestionNumber).Item(6) = "D" Then
            Score += 1

        End If

    End Sub


End Class
