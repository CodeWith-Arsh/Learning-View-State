﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Generate Divs.aspx.cs" Inherits="Events_Methods.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
            <asp:Button ID="btnCreateDivs" runat="server" Text="Create Divs" OnClick="btnCreateDivs_Click" />
            <br /><br />
            <asp:Label ID="lblOutput" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
