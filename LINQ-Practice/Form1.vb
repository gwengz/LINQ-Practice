Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim numbers As List(Of Integer) = New List(Of Integer) From {1, 2, 3, 4, 5, 6}

        Dim evenNumbers = numbers.Where(Function(n) n Mod 2 = 0)

        Dim outputMessage As String = ""

        For Each num In evenNumbers
            outputMessage += num & " "
        Next

        labelOutput.Text = outputMessage
    End Sub
End Class
