<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryAll.aspx.cs" Inherits="WebApplication1.TryAll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
            <br />
            <br />
            <br />
            <br />
            <span style="text-align: center"><strong>GetLonLat</strong></span><br />
            <br />
            Input ZipCode:
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Width="667px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Try it" Width="97px" style="height: 26px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            Lat: <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            Lon:
            <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
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
            <strong>Top10words<br />
            <br />
            </strong>Input Url:<asp:TextBox ID="TextBox9" runat="server" Width="1410px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Try it" Width="143px" />
            <br />
            <br />
            <br />
            Get Top 10 words and show times<br />
            <asp:TextBox ID="TextBox10" runat="server" Height="264px" TextMode="MultiLine" Width="1681px"></asp:TextBox>
            <br />
            <br />
            <br />
            <strong>WordFilter<br />
            <br />
            <br />
            </strong>Input string:
            <asp:TextBox ID="TextBox11" runat="server" Width="327px"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Try it" />
            <br />
            <br />
            <br />
            String<strong> </strong>After Stop Word Delete:<br />
            <br />
            <asp:TextBox ID="TextBox12" runat="server" Height="94px" TextMode="MultiLine" Width="1679px"></asp:TextBox>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
