<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginNet.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h2>Login</h2>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label runat="server">Nombre:</asp:Label>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label runat="server" type="passwd">Password:</asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <asp:button runat="server" OnClick="SignIn" Text="Aceptar" />
            </div>
        </div>
    </form>
     <asp:Label ID="ConfirmMessage" runat="server"></asp:Label>
</body>
</html>
