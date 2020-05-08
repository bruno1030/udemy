<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AloMundo.aspx.cs" Inherits="ASPM1_AloMundo.AloMundo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="msgText" runat="server"></asp:TextBox>
        <asp:Button ID="btExecutar" runat="server" OnClick="btExecutar_Click" Text="Executar" />
        <p>
            <asp:Label ID="lMsg" runat="server" Text="Escreve o que deseja informar na caixa de text"></asp:Label>
        </p>
    </form>
</body>
</html>
