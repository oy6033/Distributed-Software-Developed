<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Top10contentWords.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong style="text-align: center">Top10ContentWords</strong><br />
            <br />
            <br />
            <br />
            <br />
            Input Url:
            <asp:TextBox ID="TextBox1" runat="server" Height="16px" OnTextChanged="TextBox1_TextChanged" Width="1379px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Try it" Width="131px" />
            <br />
            <br />
            <br />
            <br />
            Get Top 10 content words and show times:<br />
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="297px" OnTextChanged="TextBox2_TextChanged" TextMode="MultiLine" Width="1669px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

