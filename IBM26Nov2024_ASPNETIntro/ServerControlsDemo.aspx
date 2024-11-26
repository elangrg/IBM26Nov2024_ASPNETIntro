<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerControlsDemo.aspx.cs" Inherits="IBM26Nov2024_ASPNETIntro.ServerControlsDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        
            <asp:TextBox ID="txtWebCtrlTextbox" runat="server"></asp:TextBox>
            <input id="txtHtmlTextbox" type="text" runat="server" />


            <asp:DropDownList ID="DropDownListCity" runat="server" ViewStateMode="Disabled"></asp:DropDownList>


            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>




            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
