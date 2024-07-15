<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Generating Divs Using Drop Down.aspx.cs" Inherits="Events_Methods.Generating_Divs_Using_Drop_Down" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="txtInput" runat="server" OnTextChanged="txt-Input"></asp:TextBox>

        </div>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
