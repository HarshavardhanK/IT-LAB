<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="IT_LAB_WEEK4_Q2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="detailsLabel" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Label ID="counterLabel" runat="server" Text="Label"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="counter_Click" Text="Counter" />
        </p>
    </form>
</body>
</html>
