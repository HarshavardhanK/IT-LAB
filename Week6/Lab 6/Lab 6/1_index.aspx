<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Lab8Q1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .staffTD {
            padding: 2px 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td class="staffTD">
                        <span>Staff ID</span>
                    </td>
                    <td class="staffTD">
                        <asp:DropDownList runat="server" ID="ddl_staffID" OnSelectedIndexChanged="ddl_staffID_OnSelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem Selected>
                                -------- Select --------
                            </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <br />
        <div>
            <h3 style="text-align: center">Staff Details</h3>
            <asp:GridView ID="staffGrid" runat="server" AutoGenerateColumns="false" CellPadding="5" CellSpacing="5" BorderColor="Black" BorderWidth="2" AllowSorting="true">
                <Columns>
                    <asp:TemplateField HeaderText="Staff Name" HeaderStyle-BackColor="#339966" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White">
                        <ItemTemplate>
                            <%# Eval("FirstName") %> <%#Eval("LastName") %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="DNo" HeaderText="Department Number" HeaderStyle-BackColor="#339966" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White" />
                    <asp:BoundField DataField="Street" HeaderText="Street" HeaderStyle-BackColor="#339966" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White" />
                    <asp:BoundField DataField="City" HeaderText="City" HeaderStyle-BackColor="#339966" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White" />
                    <asp:BoundField DataField="State" HeaderText="State" HeaderStyle-BackColor="#339966" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White" />
                    <asp:BoundField DataField="ZipCode" HeaderText="Zip Code" HeaderStyle-BackColor="#339966" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White" />
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <br />
        <div>
            <asp:ListBox runat="server" ID="list_cities">
                <asp:ListItem>Udupi</asp:ListItem>
                <asp:ListItem>Manipal</asp:ListItem>
                <asp:ListItem>Mangalore</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:Button runat="server" ID="butn_Update" Text="Update" OnClick="btn_Update_OnClick"/>
        </div>
    </form>
</body>
</html>
