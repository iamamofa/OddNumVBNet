Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        For a = 0 To 100
            If a Mod 2 <> 0 Then
                ListBox1.Items.Add(a)
            End If
        Next
    End Sub
End Class
