SPLASH SCREEN:

Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Dim form1 As New Form1
        form1.Show()
        Me.Hide()
    End Sub
End Class


FORM 1:

Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "User Name"
        Label2.Text = "Password"
        Button1.Text = "Login"
        Button2.Text = "Exit"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MessageBox.Show("Login Successful")
            Me.Visible = True
            Form2.Show()
        ElseIf TextBox1.Text <> "admin" And TextBox2.Text = "admin" Then
            MessageBox.Show("Invalid User Name", "login failed")
            TextBox1.Clear()
            TextBox1.Focus()
        ElseIf TextBox1.Text = "admin" And TextBox2.Text <> "admin" Then
            MessageBox.Show("Invalid Password", "login failed")
            TextBox2.Clear()
            TextBox1.Focus()
        ElseIf TextBox1.Text <> "admin" And TextBox2.Text <> "admin" Then
            MessageBox.Show("Invalid Credentials", "login failed")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        End If
    End Sub
End Class


FORM 2:

Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Form2
    Dim connectionstring As String
    Dim cnn As SqlConnection
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.BackColor = Color.Coral
        Label1.Text = "Eno"
        Label2.Text = "Ename"
        Label3.Text = "ESalary"
        Label4.Text = "Egrade"
        Button1.Text = "Insert"
        Button2.Text = "Clear"
        Button3.Text = "Exit"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection
        con.ConnectionString = "Data Source=DESKTOP-JFKEMN0;Initial Catalog=demobase;Integrated Security=True"
        Dim cmd As New SqlCommand("insert into myemp VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record Inserted")
        con.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Focus()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Me.Visible = True
        Dim fm4 As New Form4
        fm4.Show()
    End Sub
End Class

FORM 3:

Imports System.Data.SqlClient
Public Class Form3

    Private scon As SqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim conString As String = "Data Source=DESKTOP-JFKEMN0;Initial Catalog=demobase;Integrated Security=True"
            scon = New SqlConnection(conString)
            scon.Open()

            Using cmd As New SqlCommand("select eno,ename,esal,egrade from myemp where eno = @teno", scon)
                cmd.Parameters.AddWithValue("@teno", SqlDbType.Int).Value = TextBox1.Text
                Dim dr As SqlDataReader = cmd.ExecuteReader()

                If dr.HasRows = False Then
                    Throw New Exception()
                End If

                If dr.Read() Then
                    TextBox2.Text = dr(1).ToString()
                    TextBox3.Text = dr(2).ToString()
                    TextBox4.Text = dr(3).ToString()
                End If

                dr.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("No Record", "Error")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox1.Focus()
        Finally
            If scon IsNot Nothing AndAlso scon.State = ConnectionState.Open Then
                scon.Close()
                scon.Dispose()
            End If
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.BackColor = Color.Coral
        Label1.Text = "Eno"
        Label2.Text = "Ename"
        Label3.Text = "Esalary"
        Label4.Text = "Egrade"
        Button1.Text = "show"
        Button2.Text = "exit"
        Me.CenterToScreen()
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

FORM 4:

Imports System.Data.SqlClient
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "enter eno"
        Button1.Text = "Delete"
        Button2.Text = "Exit"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim con As [String] = "Data Source=DESKTOP-JFKEMN0;Initial Catalog=demobase;Integrated Security=True"
            Dim scon As New SqlConnection(con)
            scon.Open()
            Dim cmd As New SqlCommand("delete from myemp where eno=@teno", scon)
            cmd.Parameters.Add("@teno", SqlDbType.Int).Value = TextBox1.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Deleted")
        Catch ex As Exception
            MessageBox.Show("No Record", "Error")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
