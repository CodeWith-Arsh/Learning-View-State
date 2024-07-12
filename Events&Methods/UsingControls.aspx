<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsingControls.aspx.cs" Inherits="Events_Methods.UsingControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblResult" runat="server" BorderStyle="Groove">Enter Number</asp:Label>
            <asp:TextBox ID="txtValue" runat="server" OnTextChanged="txtTest_TextChanged" ></asp:TextBox>
        </div>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnCode_Click" style="height: 29px" Text="Create Div from the above number" />
    
    </form>
</body>
</html>
