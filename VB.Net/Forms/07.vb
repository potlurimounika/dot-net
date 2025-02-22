Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Text = "CREAM"
        CheckBox2.Text = "SUGAR"
        Button1.Text = "CHOICE"
        Label1.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (CheckBox1.Checked = True And CheckBox2.Checked = True) Then
            Label1.Text = "You selected coffee with cream & sugar"
        ElseIf (CheckBox1.Checked = True) Then
            Label1.Text = "You selected coffee with cream "
        ElseIf (CheckBox2.Checked = True) Then
            Label1.Text = "You selected coffee with sugar"
        End If
    End Sub
End Class
