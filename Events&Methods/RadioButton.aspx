﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButton.aspx.cs" Inherits="Events_Methods.RadioButton" %>

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
            <asp:RadioButton ID="MaleRadioButton" runat="server" Text="Male" OnCheckedChanged="MaleRadioButton_CheckedChanged" GroupName="GenderGroup" />
            <asp:RadioButton ID="FemaleRadioButton" runat="server" Text="Female" GroupName="GenderGroup" />
            <asp:RadioButton ID="UnknownRadioButton" runat="server" Text="Unknown" OnCheckedChanged="Unknown_CheckedChanged" GroupName="GenderGroup" />

            </fieldset>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" EnableViewState="true" />

        </div>
    
    </form>
</body>
</html>
