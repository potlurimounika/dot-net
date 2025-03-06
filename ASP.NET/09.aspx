<%@ Page Language="C#" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>WebApplication1</title>
</head>
<body>
   <form name="fm1" runat="server"></form>
    <asp:Table GridLines="Both" runat="server">
        <asp:TableRow>
            <asp:tablecell>Eno</asp:tablecell>
            <asp:tablecell>Ename</asp:tablecell>
            <asp:tablecell>Esal</asp:tablecell>
            <asp:tablecell>Egrade</asp:tablecell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:tablecell>121</asp:tablecell>
            <asp:tablecell>raj</asp:tablecell>
            <asp:tablecell>6543</asp:tablecell>
            <asp:tablecell>A</asp:tablecell>
        </asp:TableRow>
                <asp:TableRow>
                     <asp:tablecell>153</asp:tablecell>
                     <asp:tablecell>sri</asp:tablecell>
                     <asp:tablecell>22345</asp:tablecell>
                     <asp:tablecell>A</asp:tablecell>
                </asp:TableRow>
    </asp:Table>
    </form>
</body>
</html>
