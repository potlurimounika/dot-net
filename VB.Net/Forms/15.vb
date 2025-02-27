Public Class Form1
    Public Property ToolStripStatusStrip1 As Object
    Public Property ToolStripStatusLabel1 As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusStrip1.Text = " "
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.BackColor = Color.Red
        ToolStripStatusLabel1.Text = "Red"
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.BackColor = Color.Blue
        ToolStripStatusLabel1.Text = "Blue"
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.BackColor = Color.Green
        ToolStripStatusLabel1.Text = "Green"
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub
End Class
