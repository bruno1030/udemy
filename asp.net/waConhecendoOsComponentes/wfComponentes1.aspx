<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfComponentes1.aspx.cs" Inherits="waConhecendoOsComponentes.wfComponentes1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Conhecendo os componentes - parte 1</title>
    <style type="text/css">
        .auto-style1 {
            width: 293px;
        }
        .auto-style2 {
            width: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Site</td>
                    <td>Endereco</td>
                    <td class="auto-style2">Opcoes</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtSite" runat="server" Width="300px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEndereco" runat="server" Width="300px"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnInserir" runat="server" Text="Inserir Site" OnClick="btnInserir_Click" />
                        <asp:Button ID="btnSelecionar" runat="server" OnClick="btnSelecionar_Click" Text="Selecionar" Width="80px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:DropDownList ID="dlSite" runat="server" Width="300px">
                            <asp:ListItem>editoraBruno</asp:ListItem>
                            <asp:ListItem>globo esporte</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:ListBox ID="lbEndereco" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                            <asp:ListItem>http://www.uol.com.br</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
