<%@ Page Title="" Language="C#" MasterPageFile="~/modelo.master" AutoEventWireup="true" CodeFile="novoServico.aspx.cs" Inherits="novoServico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="LabelMensagem" runat="server" Text=""></asp:Label>
    <br />
    <asp:label runat="server" text="Serviço"></asp:label>
    <asp:textbox runat="server" ID="TextBoxNome"></asp:textbox>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Preço"></asp:Label>
    <asp:TextBox ID="TextBoxPreco" runat="server"></asp:TextBox>
    <br />
    <asp:button runat="server" text="Cadastrar" ID="btnCadastrar" OnClick="btnCadastrar_Click" />

</asp:Content>

