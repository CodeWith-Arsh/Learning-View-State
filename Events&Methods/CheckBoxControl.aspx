<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBoxControl.aspx.cs" Inherits="Events_Methods.CheckBoxControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <fieldset>
                <legend><b>Education</b> </legend>
                    <asp:CheckBox ID="GraduateCheckBox" Text="Graduate" runat="server" />
                    <asp:CheckBox ID="PostGraduateCheckBox" Text="PostGraduate" runat="server" />
                    <asp:CheckBox ID="PHDCheckbox" Text="PHD" runat="server" />

               </fieldset>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server">Click Here</asp:HyperLink>
        </p>
    </form>
</body>
</html>
