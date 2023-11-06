<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculadora_default.aspx.cs" Inherits="Calculadora.calculadora_default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 622px;
        }
    </style>
</head>

<form id="form1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style1" Height="579px" Width="634px">
        <asp:TextBox ID="TDisplay" runat="server" Height="90px" Width="613px"></asp:TextBox>
        <br />
        <asp:Button ID="RAIZ" runat="server" Height="80px" OnClick="RAIZ_Click" Text="²√x" Width="121px" />
        <asp:Button ID="clear" runat="server" Height="80px" OnClick="clear_Click" Text="C" Width="121px" />
        <asp:Button ID="delete" runat="server" Height="80px" OnClick="delete_Click" Text="Del" Width="121px" />
        <asp:Button ID="nsigno" runat="server" Height="80px" OnClick="nsigno_Click" Text="n!" Width="121px" />
        <asp:Button ID="division" runat="server" Height="80px" OnClick="division_Click" Text="/" Width="121px" />
        <br />
        <asp:Button ID="xelevado" runat="server" Height="80px" OnClick="xelevado_Click" Text="x^y" Width="121px" />
        <asp:Button ID="siete" runat="server" Height="80px" OnClick="siete_Click" Text="7" Width="121px" />
        <asp:Button ID="ocho" runat="server" Height="80px" OnClick="ocho_Click" Text="8" Width="121px" />
        <asp:Button ID="nueve" runat="server" Height="80px" OnClick="nueve_Click" Text="9" Width="121px" />
        <asp:Button ID="multiplicacion" runat="server" Height="80px" OnClick="multiplicacion_Click" Text="*" Width="121px" />
        <br />
        <asp:Button ID="pordiez" runat="server" Height="80px" OnClick="pordiez_Click" Text="10ˣ" Width="121px" />
        <asp:Button ID="cuatro" runat="server" Height="80px" OnClick="cuatro_Click" Text="4" Width="121px" />
        <asp:Button ID="cinco" runat="server" Height="80px" OnClick="cinco_Click" Text="5" Width="121px" />
        <asp:Button ID="seis" runat="server" Height="80px" OnClick="seis_Click" Text="6" Width="121px" />
        <asp:Button ID="resta" runat="server" Height="80px" OnClick="resta_Click" Text="-" Width="121px" />
        <br />
        <asp:Button ID="long" runat="server" Height="80px" OnClick="long_Click" Text="long" Width="121px" />
        <asp:Button ID="uno" runat="server" Height="80px" OnClick="uno_Click" Text="1" Width="121px" />
        <asp:Button ID="dos" runat="server" Height="80px" OnClick="dos_Click" Text="2" Width="121px" />
        <asp:Button ID="tres" runat="server" Height="80px" OnClick="tres_Click" Text="3" Width="121px" />
        <asp:Button ID="mas" runat="server" Height="80px" OnClick="mas_Click" Text="+" Width="121px" />
        <br />
        <asp:Button ID="xdos" runat="server" Height="80px" OnClick="xdos_Click" Text="x²" Width="121px" />
        <asp:Button ID="masmenos" runat="server" Height="80px" OnClick="masmenos_Click" Text="+/-" Width="121px" />
        <asp:Button ID="cero" runat="server" Height="80px" OnClick="cero_Click" Text="0" Width="121px" />
        <asp:Button ID="coma" runat="server" Height="80px" OnClick="coma_Click" Text="," Width="121px" />
        <asp:Button ID="igual" runat="server" Height="80px" OnClick="igual_Click" Text="=" Width="121px" />
    </asp:Panel>
</form>

</html>