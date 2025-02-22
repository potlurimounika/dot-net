Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Text = "Button Demo"
        Me.BackColor = Color.LightGray
        Button1.Text = "Red"
        Button2.Text = "Green"
        Button3.Text = "Blue"
        Button4.Text = "Quit"
        Label1.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BackColor = Color.Red
        Label1.BackColor = Color.Red
        Label1.Text = "Red Selected"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BackColor = Color.Blue
        Label1.BackColor = Color.Blue
        Label1.Text = "Blue Selected"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.BackColor = Color.Green
        Label1.BackColor = Color.Green
        Label1.Text = "Green Selected"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
