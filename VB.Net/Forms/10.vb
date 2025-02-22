Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Pen")
        ListBox1.Items.Add("Pencil")
        ListBox1.Items.Add("Eraser")
        ListBox1.Items.Add("Ruler")
        ListBox1.Items.Add("Book")
        Label1.Text = " "
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Label1.Text = ListBox1.SelectedItem
    End Sub
End Class
