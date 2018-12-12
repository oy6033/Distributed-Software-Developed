<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            XML Verification<br />
            <br />
            <br />
            URL (Try: <a href="http://webstrar36.fulton.asu.edu/page10/Hotels.xml">http://webstrar36.fulton.asu.edu/page10/Hotels.xml</a>)<br />
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="550px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Try it" />
            <br />
            <br />
            Result:<br />
            <asp:TextBox ID="TextBox2" runat="server" Height="77px" OnTextChanged="TextBox2_TextChanged" TextMode="MultiLine" Width="239px"></asp:TextBox>
            <br />
            <br />
            <br />
            XPathSearch<br />
            <br />
            URL (Try: <a href="http://webstrar36.fulton.asu.edu/page10/Hotels.xml">http://webstrar36.fulton.asu.edu/page10/Hotels.xml</a>)<br />
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Width="551px"></asp:TextBox>
            <br />
            <br />
            Path: (Try: Name&nbsp;&nbsp; or&nbsp;&nbsp; Contact/Phone)<br />
            <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged" Width="550px"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Try it" />
            <br />
            <br />
            Result:<br />
            <asp:TextBox ID="TextBox5" runat="server" Height="123px" OnTextChanged="TextBox5_TextChanged" TextMode="MultiLine" Width="258px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
