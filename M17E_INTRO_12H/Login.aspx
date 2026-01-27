<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="M17E_INTRO_12H.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login</h1>
Email: <asp:textbox ID="tb_email" runat="server" CssClass="texto_vermelho" type="email"></asp:textbox>
    <br />
Palavra-passe: <asp:textbox ID="tb_password" runat="server" type="passwprd"></asp:textbox>
    <br />
    <asp:Button ID="bt_login" runat="server" Text="Login" />
    <br />
    <asp:Label ID="lb_erro" runat="server" CssClass="texto_vermelho"></asp:Label>
</asp:Content>
