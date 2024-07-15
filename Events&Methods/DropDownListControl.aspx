<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownListControl.aspx.cs" Inherits="Events_Methods.DropDownListControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <%--<asp:ListItem Value="1">Name</asp:ListItem>
                <asp:ListItem Value="2">City</asp:ListItem>
                <asp:ListItem Value="3">Country</asp:ListItem>--%>
            </asp:DropDownList>
        </div>
        
        <asp:Button ID="Button1" runat="server" Text="Submit" />
        
    </form>
</body>
</html>
