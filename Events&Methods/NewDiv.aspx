﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewDiv.aspx.cs" Inherits="Events_Methods.NewDiv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblDiv" runat="server"></asp:Label>
            <asp:TextBox ID="inputNumber" runat="server"></asp:TextBox>

        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
