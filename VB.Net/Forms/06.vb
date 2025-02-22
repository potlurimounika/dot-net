Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Label1.Text = "Length"
        Label2.Text = "Breadth"
        Label3.Text = " "
        Button1.Text = "Calculate"
        Button2.Text = "Quit"
    End Sub
    Dim l, b, a As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        l = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        a = l * b
        Label3.Text = Convert.ToString(a)
    End Sub
End Class
