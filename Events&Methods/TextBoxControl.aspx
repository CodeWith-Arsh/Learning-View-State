﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextBoxControl.aspx.cs" Inherits="Events_Methods.TextBoxControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="MultiLine"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
