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
        <asp:Button ID="btn1" runat="server" Text="INDIATIMES" OnClick="btn1_Click" />
    </form>

    <script runat="server">
        protected void btn1_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('welcome to INDIATIMES');", true);
        }
    </script>
</body>
</html>
