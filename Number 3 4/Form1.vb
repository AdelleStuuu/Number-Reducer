Public Class Form1
    Private Sub Btnsubmit_click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intNumber As Integer = NumericUpDown1.Value
        Dim intNumberDisplay As Integer

        intNumberDisplay = intNumber

        While intNumber <> 1
            intNumber -= 1
        End While

        MsgBox(intNumberDisplay & " is reduced to " & intNumber)
    End Sub
End Class
