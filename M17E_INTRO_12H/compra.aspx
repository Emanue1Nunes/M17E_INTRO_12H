<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="compra.aspx.cs" Inherits="M17E_INTRO_12H.compra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Comprar PC</h1>
            <!-- Nome -->
            <asp:Label ID="lb_nome" runat="server" Text="Nome:"></asp:Label>
            <input id="tx_nome" type="text" />
            <!-- Data de Nascimento -->
            <asp:Label ID="lb_data_nascimento" runat="server" Text="Data de Nascimento:"></asp:Label>
            <input id="tx_data_nascimento" type="text" />
            <!-- Email -->
            <asp:Label ID="lb_email" runat="server" Text="Email:"></asp:Label>
            <input id="tx_email" type="text" />
            <!-- Marca DropDownList -->
            <asp:Label ID="lb_marca" runat="server" Text="Marca:"></asp:Label>
            <!-- Modelo DropDownList -->
            <asp:Label ID="lb_modelo" runat="server" Text="Modelo:"></asp:Label>
            <!-- Processador radio button -->
            <asp:Label ID="lb_processador" runat="server" Text="Processador:"></asp:Label>
            <!-- Aceitar condições chk_bx -->
            <!-- Button Finalizar -->
        </div>
    </form>
</body>
</html>
