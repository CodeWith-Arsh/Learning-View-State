<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Generate Divs Dynamically</title>
    <style>
        .generated-div {
            border: 1px solid black;
            padding: 5px;
            margin: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblEnterNumber" runat="server" Text="Enter a number: "></asp:Label>
            <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
            <asp:Button ID="btnGenerate" runat="server" Text="Generate Divs" OnClick="btnGenerate_Click" />
            <br /><br />
            <asp:Label ID="lblDivs" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
