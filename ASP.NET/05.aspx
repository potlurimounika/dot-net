<%@ Page Language="C#" %>
<!DOCTYPE html>
<script runat="server">
    double p, t, r, si, ci;
    protected void btn1_Click(object sender, EventArgs e)
    {
        p = Convert.ToDouble(tbx1.Text);
        t = Convert.ToDouble(tbx2.Text);
        r = Convert.ToDouble(tbx3.Text);
        si = p * t * r / 100;
        lb5.InnerText = Convert.ToString(si);
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        p = Convert.ToDouble(tbx1.Text);
        t = Convert.ToDouble(tbx2.Text);
        r = Convert.ToDouble(tbx3.Text);
        ci = p * (Math.Pow(1 + r / 100, t));
        lb5.InnerText = Convert.ToString(ci);
    }

    protected void btn3_Click(object sender, EventArgs e)
    {
        tbx1.Text = " ";
        tbx2.Text = " ";
        tbx3.Text = " ";
    }
</script>


<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>WebApplication1</title>
</head>
<body>
    <form name="fm1" runat="server">
        <asp:label ID="lb1" runat="server" Text="principal"></asp:label>
        <asp:TextBox ID="tbx1" runat="server" placeholder="Enter principal"></asp:TextBox><br /></br>

        <asp:Label ID="lb2" runat="server" Text="time"></asp:Label>
        <asp:TextBox ID="tbx2" runat="server" placeholder="Enter time"></asp:TextBox><br /></br>

        <asp:Label ID="lb3" runat="server" Text="rate of intrest"></asp:Label>
        <asp:TextBox ID="tbx3" runat="server" placeholder="Enter rate of intrest"></asp:TextBox><br /></br>

        <asp:Label ID="lb4" Text="Intrest payable" runat="server" /></asp:label>
        <aspllabel id="lb5" runat="server" text=" "/></asp:label><br /></br>

        <asp:Button ID="btn1" runat="server" Text="simple" OnClick="btn1_Click"/></asp:Button>
        <asp:Button ID="btn2" runat="server" Text="compound" OnClick="btn2_Click" /></asp:Button>
        <asp:Button ID="btn3" runat="server" Text="clear" OnClick="btn3_Click" /></asp:Button>
    </form>
</body>
</html>
