<%@ Page Language="C#" %>
<!DOCTYPE html>
<script runat="server">
    int a, b, c;
    protected void btn1_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(tbx1.Text);
        b = Convert.ToInt32(tbx2.Text);
        c = a + b;
        tbx3.Text = Convert.ToString(c);
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(tbx1.Text);
        b = Convert.ToInt32(tbx2.Text);
        c = a - b;
        tbx3.Text = Convert.ToString(c);
    }

    protected void btn3_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(tbx1.Text);
        b = Convert.ToInt32(tbx2.Text);
        c = a * b;
        tbx3.Text = Convert.ToString(c);
    }

    protected void btn4_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(tbx1.Text);
        b = Convert.ToInt32(tbx2.Text);
        c = a / b;
        tbx3.Text = Convert.ToString(c);
    }

    protected void btn5_Click(object sender, EventArgs e)
    {
         a = Convert.ToInt32(tbx1.Text);
 b = Convert.ToInt32(tbx2.Text);
 c = a % b;
 tbx3.Text = Convert.ToString(c);
    }
</script>

<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>WebApplication1</title>
        <style>
    body {
        background-color:#flflfl;
    }
</style>
</head>
<body>
    <form name="fm1" runat="server">
        <asp:label ID="lb1" runat="server" Text="A"></asp:label>
        <asp:TextBox ID="tbx1" runat="server"></asp:TextBox>

       <asp:label ID="lb2" runat="server" Text="B"></asp:label>
       <asp:TextBox ID="tbx2" runat="server"></asp:TextBox>

        <asp:label ID="lb3" runat="server" Text="C" placeholder="result"></asp:label>
        <asp:TextBox ID="tbx3" runat="server" enabled="false"></asp:TextBox></asp:TextBox><br /></br>

        <asp:Button ID="btn1" runat="server" Text="+" OnClick="btn1_Click" />
        <asp:Button ID="btn2" runat="server" Text="-" OnClick="btn2_Click" />
        <asp:Button ID="btn3" runat="server" Text="*" OnClick="btn3_Click" />
        <asp:Button ID="btn4" runat="server" Text="/" OnClick="btn4_Click" />
        <asp:Button ID="btn5" runat="server" Text="%" OnClick="btn5_Click" />
    </form>
</body>
</html>
