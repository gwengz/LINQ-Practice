Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim names As List(Of String) = New List(Of String) From {"Crystal", "Jamaica",
                                                         "Carmelo", "Angelo", "Tin", "Jo"}

        Dim lessThanFive = names.Where(Function(n) n.Length <= 5)

        Dim outputMessage As String = ""

        For Each namee In lessThanFive
            outputMessage += namee & " "
        Next

        labelOutput.Text = outputMessage
    End Sub

End Class
