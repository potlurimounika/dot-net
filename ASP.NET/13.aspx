<%@ Page Language="C#" %>
<!DOCTYPE html>
<script runat="server">

    protected void btn1_click(object sender, EventArgs e)
    {
                 if(C1.Checked==true && C2.Checked==true && C3.Checked==true)
                    {
                        lb1.Text = "All Courses Selected";
                     }
                 else if(C1.Checked==true && C2.Checked==true)
                    {
                         lb1.Text = "DCA & PGDCA Selected";
                    }
                 else if(C2.Checked==true && C3.Checked==true)
                    {
                        lb1.Text = "PGDCA & DoTNET Selected";
                    }
                 else if(C3.Checked==true && C1.Checked==true)
                    {
                        lb1.Text = "DoTNET & PGDCA Selected";
                    }
                 else if(C1.Checked==true)
                     {
                        lb1.Text = "DCA Selected";
                     }
                 else if(C2.Checked==true)
                     {
                        lb1.Text = "PGDCA Selected";
                     }
                 else if(C3.Checked==true)
                    {
                        lb1.Text = "DOTNET Selected";
                    }
                 else if(C1.Checked==false && C2.Checked==false && C3.Checked==false)
                    {
                        lb1.Text = "select any one option";
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
       <asp:CheckBox ID="C1" runat="server" text="DCA"></asp:CheckBox>
           <asp:CheckBox ID="C2" runat="server" text="PGDCA"></asp:CheckBox>
               <asp:CheckBox ID="C3" runat="server" text="DOTNET"></asp:CheckBox><br /></br>
                   <asp:Button ID="btn1" runat="server" text="COURSE" onClick="btn1_click" /><br /></br>
                     <asp:Label ID="lb1" text=" " runat="server"></asp:Label>
   </form>
</body>
</html>
