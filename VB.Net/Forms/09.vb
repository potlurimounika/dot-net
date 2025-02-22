Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Red")
        ComboBox1.Items.Add("Blue")
        ComboBox1.Items.Add("Green")
        ComboBox1.Items.Add("yellow")
        ComboBox1.Items.Add("cyan")
        ComboBox1.Items.Add("Magenta")
        ComboBox1.Items.Add("crypton")
        ComboBox1.Text = "yellow"
        Label1.Text = " "
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label1.Text = "You selected:" & ComboBox1.Text
    End Sub
End Class
