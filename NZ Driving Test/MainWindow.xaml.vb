Class MainWindow
    Dim UserName As String

    Private Sub btnStart_Click(sender As Object, e As RoutedEventArgs) Handles btnStart.Click
        Me.Hide()

        Dim TestScreen As New Test_Screen
        TestScreen.ShowDialog()

        txtName.Text = UserName

    End Sub


End Class
