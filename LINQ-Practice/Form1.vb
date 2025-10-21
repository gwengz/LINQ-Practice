Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim numbers As List(Of Integer) = New List(Of Integer) From {1, 2, 3, 4, 5,
6}
        Dim evenNumbers = numbers.Where(Function(n) n Mod 2 = 0)
        For Each num In evenNumbers
            Console.WriteLine(num) ' Output: 2, 4, 6
        Next
    End Sub
End Class
