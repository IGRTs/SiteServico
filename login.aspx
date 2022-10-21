<%@ Page Title="" Language="C#" MasterPageFile="~/modelo.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>

        <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
        <asp:TextBox ID="TextBoxLogin" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
        <asp:TextBox ID="TextBoxSenha" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonEnviar" runat="server" onclick="ButtonEnviar_Click" 
            Text="Enviar" />
        <br />
        <asp:Label ID="LabelResposta" runat="server" Text="" ForeColor="Red"></asp:Label>    
    </div>
</asp:Content>


