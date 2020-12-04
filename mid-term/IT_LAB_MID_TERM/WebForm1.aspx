<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="IT_LAB_MID_TERM.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="nameTextbox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="regLabel" runat="server" Text="RegNo:"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="regTextbox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Option:"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="oddEvenDropDown" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="next_Click" Text="NEXT" />
        </div>
    </form>
</body>
</html>
