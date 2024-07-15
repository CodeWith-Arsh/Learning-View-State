<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDown.aspx.cs" Inherits="Events_Methods.DropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem Value="2">Female</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
