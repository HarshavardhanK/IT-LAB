<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Actors.aspx.cs" Inherits="IT_LAB_WEEK_Q2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" Text="Choose the genre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="genreDDL" runat="server" Height="22px" Width="115px">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="choose_Genre" Text="Choose" Width="72px" />
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Choose the actor"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="actorLB" runat="server" Width="117px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="choose_Actor" Text="Choose" Width="79px" />
        </p>
        <p>
            <asp:Label ID="actorDetails" runat="server" Text="Actor details..."></asp:Label>
        </p>
        <div>
        </div>
    </form>
</body>
</html>
