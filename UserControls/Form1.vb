Imports UserControls.CustomControls.RJControls

Public Class Form1

    Private Sub RjButton2_MouseHover(sender As Object, e As EventArgs) Handles RjButton2.MouseHover

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CreateButton()
        'CreateTextbox()
    End Sub

    Async Sub CreateButton()

        For i = 0 To 1000
            Dim btn As New RJButton With {.Text = "RJButton" & i}
            FlowLayoutPanel1.Controls.Add(btn)
            Await Task.Delay(100)
            'btn.Select()
            Label1.Text = i
        Next
    End Sub

    Async Sub CreateTextbox()
        For i = 0 To 100
            Dim tx As New RJTextBox With {.Text = "RJButton" & i}
            FlowLayoutPanel1.Controls.Add(tx)
            Await Task.Delay(100)
            'tx.Select()
            Label2.Text = i
        Next
    End Sub
End Class
