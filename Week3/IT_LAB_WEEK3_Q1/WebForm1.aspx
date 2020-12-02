<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="IT_LAB_WEEK3_Q1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 672px">
            <asp:TextBox ID="messageTextBox" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 148px; margin-top: 46px" Width="152px">Type message</asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Choose font"></asp:Label>
            <asp:DropDownList ID="fontDropDown" runat="server" Height="50px" style="margin-left: 58px; margin-top: 31px" Width="203px">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Choose size"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="fontSizeDropDown" runat="server" Height="24px" style="margin-left: 0px" Width="203px">
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Choose color"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="colorDropDown" runat="server" Height="24px" Width="212px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="bgColor" runat="server" Text="Choose background"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="backgroundColor" runat="server" Height="16px" Width="200px">
            </asp:DropDownList>
            <br />
            <br />
&nbsp;<asp:Label ID="Label5" runat="server" Text="Upload image"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="imageLocal" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="generateButton" runat="server" OnClick="generate" Text="Generate" />
        </div>
        <asp:Panel ID="magazine" runat="server" style="position: absolute; margin-left: 598px; top: 32px; left: -86px; width: 554px; height: 405px;">
            <asp:Label ID="titleLabel" runat="server" Text="Label"></asp:Label>
            <asp:Image ID="coverImage" runat="server" Height="200px" style="margin-left: 149px; margin-top: 119px" Width="250px" />
        </asp:Panel>
    </form>
</body>
</html>
