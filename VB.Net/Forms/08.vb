Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Text = "cash"
        RadioButton2.Text = "credit card"
        RadioButton3.Text = "debit card"
        Label1.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked) Then
            Label1.Text = "You have selected cash"
        End If
        If (RadioButton2.Checked) Then
            Label1.Text = "You have selected credit card"
        End If
        If (RadioButton3.Checked) Then
            Label1.Text = "You have selected debit card"
        End If
    End Sub
End Class
