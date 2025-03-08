<%@ Page Language="C#" %>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>WebApplication1</title>
</head>
<body>
   <form name="fm1" runat="server">
       <asp:Label ID="lb1" runat="server" Text="Age" ></asp:Label>
         <asp:TextBox ID="tbx1" runat="server" placeholder="enter your age" ></asp:TextBox>
       <asp:RangeValidator ID="rv1" runat="server" ControlToValidate="tbx1" Type="Integer" MinimumValue="18" MaximumValue="23" ErrorMessage="Age Must Be Between 18 To 23" ></asp:RangeValidator>
   </form>
</body>
</html>
