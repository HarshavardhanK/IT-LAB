<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="IT_LAB_WEEK4_Q1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="margin-left: 120px">
            &nbsp;</p>
        <p style="margin-left: 120px">
            <asp:TextBox ID="modelTextbox" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 120px">
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="carManufacturersList" runat="server">
            </asp:DropDownList>
        </p>
        <p style="margin-left: 120px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="submitButton" runat="server" OnClick="submit_Button_Click" Text="Submit" />
        </p>
    </form>
</body>
</html>
