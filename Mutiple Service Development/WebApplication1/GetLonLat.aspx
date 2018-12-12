<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetLonLat.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <span style="text-align: center"><strong>GetLonLat</strong></span><br />
            <br />
            Input ZipCode:
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Width="667px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Try it" Width="97px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            Lat: <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            Lon:
            <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
            </p>
        <div>
        </div>
    </form>
</body>
</html>
