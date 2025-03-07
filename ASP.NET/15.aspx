<%@ Page Language="C#" %>
<!DOCTYPE html>
<script runat="server">
    protected void d1_SelectedIndexChanged(object sender, EventArgs e)
    {
        lb1.Text = d1.SelectedItem.Text;
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
       <asp:DropdownList ID="d1" runat="server" OnSelectedIndexChange="d1_SelectedIndex changed" AutoPostBack="true" OnSelectedIndexChanged="d1_SelectedIndexChanged">
       <asp:ListItem>PEN</asp:ListItem>
       <asp:ListItem>BOOK</asp:ListItem>
       <asp:ListItem>PENCIL</asp:ListItem>
           </asp:DropdownList>
                     <asp:Label ID="lb1" text=" " runat="server"></asp:Label>
   </form>
</body>
</html>
