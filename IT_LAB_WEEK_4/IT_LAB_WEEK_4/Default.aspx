<%@ Page Language="C#" Inherits="IT_LAB_WEEK_4.Default" %>
<!DOCTYPE html>

<html>
    <head runat="server">
        <title> Currency Coverter</title>
    </head>
    
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:Label id="label" runat="server"/>
                    <asp:TextBox runat="server" id="inputCurrency"/>
                    <asp:Label id="fromLabel" runat="server"/>
                    <asp:DropDownList id="fromCurrencyDropDown" runat="server"/>
                        
                    <br/><br/>
                        <asp:Label runat="server" id="labelAns"/>
                        <br/><br/>
                        <asp:Button Text="Convert" OnClick="SubmitClickEvent" runat="server"/>
                        <br/>
                        <br/>
             </div>
             </form>
        </body>
    </html>
            
                        