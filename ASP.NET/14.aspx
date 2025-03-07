<%@ Page Language="C#" %>
<!DOCTYPE html>
<script runat="server">

    protected void btn1_click(object sender, EventArgs e)
    {
        if(rb1.Checked==true)
        {
            lb1.Text = "CASH Mode Selected";
        }
        else if(rb2.Checked==true)
{
    lb1.Text = "CHEQUE Mode Selected";
}
                else if(rb3.Checked==true)
{
    lb1.Text = "DD Mode Selected";
}
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
       <asp:RadioButton ID="rb1" runat="server" text="CASH" GroupName="fees"></asp:RadioButton>
       <asp:RadioButton ID="rb2" runat="server" text="CHEQUE" GroupName="fees"></asp:RadioButton>
       <asp:RadioButton ID="rb3" runat="server" text="DD" GroupName="fees"></asp:RadioButton><br /></br>
                   <asp:Button ID="btn1" runat="server" text="Payment" onClick="btn1_click" /><br /></br>
                     <asp:Label ID="lb1" text=" " runat="server"></asp:Label>
   </form>
</body>
</html>
