Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "Red"
        Label1.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BackColor = Color.Red
        Label1.BackColor = Color.Red
        Label1.Text = "Red Selected"
        MessageBox.Show("Red selected", "Red")
    End Sub
End Class
