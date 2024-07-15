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
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" OnClientClick="Are you sure " />
        </div>
        <p>
            <asp:LinkButton runat="server" OnClientClick="return Confirm('are you sure')">LinkButton</asp:LinkButton>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.google.com">Click Here</asp:HyperLink>
        </p>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="62px" ImageUrl="~/images/images (2).jpg" OnClick="ImageButton1_Click" OnClientClick="alert(&quot;Are you sure&quot;);" Width="129px" />
    </form>
</body>

</html>
