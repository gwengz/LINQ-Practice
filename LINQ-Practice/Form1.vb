Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim names As List(Of String) = New List(Of String) From {"Crystal", "Jamaica", "Carmelo", "Angelo", "Tin", "Jo"}

        Dim upperNames = names.Select(Function(n) n.ToLower())

        Dim outputMessage As String = ""

        For Each namee In upperNames
            outputMessage += namee & " "
        Next

        labelOutput.Text = outputMessage
    End Sub

End Class
