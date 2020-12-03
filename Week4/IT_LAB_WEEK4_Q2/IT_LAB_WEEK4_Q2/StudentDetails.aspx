<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDetails.aspx.cs" Inherits="IT_LAB_WEEK4_Q2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nameTextBox" runat="server" style="margin-left: 35px"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Roll"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="rollTextbox" runat="server" style="margin-left: 46px"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Subjects"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="subjectsList" runat="server" Height="16px" Width="136px">
        </asp:DropDownList>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="submit_Click" Text="Submit" Width="103px" />
        </p>
    </form>
</body>
</html>
