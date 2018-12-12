<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountWords.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <strong>CountWords<br />
            <br />
            <br />
            </strong>Input Url<strong>:
&nbsp;<asp:TextBox ID="TextBox8" runat="server" OnTextChanged="TextBox8_TextChanged" Width="669px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; </strong>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Try it" Width="140px" />
            <br />
            <br />
            English Words in URL: <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
            </p>
        <div>
        </div>
    </form>
</body>
</html>
