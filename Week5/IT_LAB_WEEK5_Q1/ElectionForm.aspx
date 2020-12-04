<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ElectionForm.aspx.cs" Inherits="IT_LAB_WEEK5_Q1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 6px">
            <asp:Label ID="Label1" runat="server" Text="Choose a Candidate"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="candidateList" runat="server" Height="16px" Width="129px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="candidateValidator" runat="server" ControlToValidate="candidateList" ErrorMessage="Please choose a candidate"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Student Details"></asp:Label>
            <br />
            <br />
            <asp:RadioButtonList ID="houseList" runat="server">
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="houseList" ErrorMessage="Please select a house"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="classText" runat="server" Width="202px">Enter class</asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="classText" ErrorMessage="Please enter a class"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
            <asp:RangeValidator ID="classRangeValidator" runat="server" ControlToValidate="classText" ErrorMessage="Enter class from 6 to 9" MaximumValue="9" MinimumValue="6"></asp:RangeValidator>
            <br />
            <br />
            <asp:TextBox ID="emailText" runat="server" Width="205px">Enter Email</asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="emailText" ErrorMessage="Please enter an email ID"></asp:RequiredFieldValidator>
&nbsp;<br />
&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="emailRegExValidator" runat="server" ControlToValidate="emailText" ErrorMessage="Enter a valid email ID" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:TextBox ID="phoneText" runat="server" Width="206px">Enter Parent Phone Number</asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:CustomValidator ID="phoneCustomValidator" runat="server" ControlToValidate="phoneText" ErrorMessage="Enter a valid phone number" OnServerValidate="phone_Custom_Server_Validator"></asp:CustomValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" style="margin-left: 38px" Text="Submit" Width="121px" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </div>
    </form>
</body>
</html>
