<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextToInt.aspx.cs" Inherits="Events_Methods.TextToInt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
            <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
