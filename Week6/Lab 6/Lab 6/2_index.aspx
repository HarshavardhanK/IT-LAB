<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Lab8Q2.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Choose the Genre</td>
                    <td>
                        <asp:DropDownList ID="ddl_genre" runat="server" OnSelectedIndexChanged="ddl_genre_change">
                            <asp:ListItem Selected>
                                -------- Select --------
                            </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <div>
            <asp:ListBox runat="server" ID="list_actors" OnSelectedIndexChanged="list_actors_change"></asp:ListBox>
        </div>
        <div>
            <asp:Label ID="lbl" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
