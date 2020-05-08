<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfTabuada.aspx.cs" Inherits="waConhecendoOsComponentes.wfTabuada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Tabuada</h1>
            <asp:DropDownList ID="dlNumbers" runat="server"></asp:DropDownList>
            <asp:Button ID="btnExecutar" runat="server" OnClick="btnExecutar_Click" Text="Exibir a tabuada" />
        </div>
        <asp:ListBox ID="lbDados" runat="server" Height="171px"></asp:ListBox>
    </form>
</body>
</html>
