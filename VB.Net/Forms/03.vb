Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.BackColor = Color.Aqua
        Me.Text = "Demo App"
        Label1.Text = "Hello World"
        Label1.BackColor = Color.Yellow
        Label1.ForeColor = Color.Red
        Label1.Font = New Font("Arial", 20, FontStyle.Bold)
        Label2.Text = "Nipuna"
    End Sub
End Class
