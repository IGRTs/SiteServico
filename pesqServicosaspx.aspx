<%@ Page Title="" Language="C#" MasterPageFile="~/modelo.master" AutoEventWireup="true" CodeFile="pesqServicosaspx.aspx.cs" Inherits="pesqServicosaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TextBoxNome" runat="server"></asp:TextBox>
    <asp:Button ID="ButtonPesquisar" runat="server" Text="Pesquisa" OnClick="ButtonPesquisar_Click" />
    <br /><hr /><br />
    <asp:DataGrid ID="DataGrid1" runat="server" AutoGenerateColumns="False" OnCancelCommand="DataGrid1_CancelCommand" OnDeleteCommand="DataGrid1_DeleteCommand" OnEditCommand="DataGrid1_EditCommand" OnUpdateCommand="DataGrid1_UpdateCommand">
        <AlternatingItemStyle BackColor="Silver" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
        <Columns>
            <asp:BoundColumn DataField="codigo" HeaderText="Código" ReadOnly="True"></asp:BoundColumn>
            <asp:BoundColumn DataField="nome" HeaderText="Serviço"></asp:BoundColumn>
            <asp:BoundColumn DataField="preco" HeaderText="Preço"></asp:BoundColumn>
            <asp:EditCommandColumn CancelText="Cancelar" EditText="Editar" UpdateText="Atualizar"></asp:EditCommandColumn>
            <asp:ButtonColumn CommandName="Delete" Text="Excluir"></asp:ButtonColumn>
        </Columns>
        <EditItemStyle BackColor="#99CCFF" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
        <HeaderStyle BackColor="#6699FF" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="White" />
    </asp:DataGrid>
</asp:Content>

