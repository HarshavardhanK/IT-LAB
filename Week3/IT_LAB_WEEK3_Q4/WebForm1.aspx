<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Captcha.aspx.cs" Inherits="Captcha.Captcha" %> 

 

<!DOCTYPE html> 

 

<html xmlns="http://www.w3.org/1999/xhtml"> 

<head runat="server"> 

    <title></title> 

</head> 

<body> 

    <form id="form1" runat="server"> 

        <div> 

            <img runat="server" id="CaptchaImage" alt="Captcha Image" style="width:180px; height:30px" /> 

            <br /><br /> 

            <asp:Button runat="server" ID="Reload" Text="Reload this Captcha" /> 

            <br /> 

            <br /> 

            <asp:TextBox ID="CaptchaText" runat="server" /> 

            <asp:Button runat="server" ID="Submit" Text="Submit Captcha" OnClick="Check_Captcha" /> 

        </div> 

        <br /> 

        <asp:Label Text="Waiting for Verification..." runat="server" ID="VerifiedStatus" /> 

    </form> 

</body> 

</html> 