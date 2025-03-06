<%@ Page Language="C#" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>WebApplication1</title>
</head>
<body>
   <form name="fm1" runat="server">
        <asp:BulletedList ID="bl1" runat="server" BulletStyle="Circle">
            <asp:ListItem>Pen</asp:ListItem>
            <asp:ListItem>Book</asp:ListItem>
            <asp:ListItem>Pencil</asp:ListItem>
            <asp:ListItem>Erase</asp:ListItem>
        </asp:BulletedList>
   </form>
</body>
</html>
