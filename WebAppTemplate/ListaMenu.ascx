<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListaMenu.ascx.cs" Inherits="WebAppTemplate.ListaMenu" %>
<h6>Explorar Metodos del CRUD</h6>
<asp:BulletedList ID="BulletedList1" runat="server" DisplayMode="HyperLink">
    <asp:ListItem Text="Consultar chef por Id" Value="Default.aspx?Op=GetById"></asp:ListItem>
    <asp:ListItem Text="Ingresar un nuevo chef" Value="NewCheff.aspx"></asp:ListItem>
    <asp:ListItem Text="Modificar un chef por Id" Value="UpdateCheff.aspx"></asp:ListItem>
    <asp:ListItem Text="Eliminar un chef por Id" Value="DeleteCheff.aspx"></asp:ListItem>
</asp:BulletedList>