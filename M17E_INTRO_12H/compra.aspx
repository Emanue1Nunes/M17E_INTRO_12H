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
            <asp:TextBox ID="tb_nome" runat="server" required ="true" placeholder="Nome do Cliente" MaxLength="50"></asp:TextBox>
            <br />
            <!-- Data de Nascimento -->
            <asp:Label ID="lb_data_nascimento" runat="server" Text="Data de Nascimento:"></asp:Label>
            <asp:textbox ID="tb_data_nascimento" runat="server" type="date" required="true"></asp:textbox>
            <br />
            <!-- Email -->
            <asp:Label ID="lb_email" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="tb_email" runat="server" type="email" required="true" placeholder="Email do Cliente"></asp:TextBox>
            <br />
            <!-- Marca DropDownList -->
            <asp:Label id="lb_marca" runat="server" Text="Marca:"></asp:Label>
            <asp:DropDownList ID="dd_marca" runat="server" OnSelectedIndexChanged="dd_marca_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Text="Escolha uma Marca" Value="0"></asp:ListItem>
                <asp:ListItem Text="Asus" Value="1"></asp:ListItem>
                <asp:ListItem Text="HP" Value="2"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <!-- Modelo DropDownList -->
            <asp:Label id="lb_modelo" runat="server" Text="Modelo:"></asp:Label>
            <asp:DropDownList id="dd_modelo" runat="server"></asp:DropDownList>
            <br />
            <!-- Processador radio button -->
            <asp:Label id="lb_processador" runat="server" Text="Processador:"></asp:Label><br />
            <asp:RadioButton groupName="processador" ID="rb_intel" runat="server" Text="Intel" /><br />
            <asp:RadioButton groupName="processador" ID="rb_amd" runat="server" Text="AMD" /><br />
            <asp:RadioButton groupName="processador" ID="rb_outro" runat="server" Text="Outro" /><br />
            <br />
            <!-- Aceitar condições chk_bx -->
            <asp:CheckBox ID="cb_aceitar" runat="server" Text="Aceito as condições" />
            <br />
            <!-- Foto perfil -->
            <asp:Label ID="lb_foto_perfil" runat="server" Text="Foto de Perfil:"></asp:Label>
            <asp:FileUpload ID="fu_foto_perfil" runat="server" />
            <!-- Button Finalizar -->
            <br />
            <asp:Button ID="bt_comprar" runat="server" Text="Finalizar a Compra" OnClick="bt_comprar_Click" />
            <br />
            <asp:Label ID="lb_erro" runat="server" ForeColor="Red"></asp:Label>
            <% Response.Write(DateTime.Now); %>
        </div>
    </form>
</body>
</html>
