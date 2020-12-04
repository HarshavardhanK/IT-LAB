<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="IT_LAB_MID_TERM.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            <asp:TextBox ID="valueTextbox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="checkButton" runat="server" OnClick="check_Click" Text="CHECK" />
        </p>
        <p>
            <asp:Label ID="detailsLabel" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:ListBox ID="numberListbox" runat="server" Width="142px"></asp:ListBox>
        </p>
        <div>
        </div>
    </form>
</body>
</html>
