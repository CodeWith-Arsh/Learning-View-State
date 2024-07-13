<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButton.aspx.cs" Inherits="Events_Methods.RadioButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <fieldset style="width:300px">
                <legend>Gender</legend>
            <asp:RadioButton ID="MaleRadioButton" runat="server" Text="Male" OnCheckedChanged="MaleRadioButton_CheckedChanged" />
            <asp:RadioButton ID="FemaleRadioButton" runat="server" Text="Female" />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Other" OnCheckedChanged="RadioButton1_CheckedChanged" />

            </fieldset>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

        </div>
    
    </form>
</body>
</html>
