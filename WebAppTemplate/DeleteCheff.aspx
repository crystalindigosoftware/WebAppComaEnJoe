<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DeleteCheff.aspx.cs" Inherits="WebAppTemplate.DeleteCheff" %>

<%@ Register Src="~/ListaMenu.ascx" TagPrefix="uc1" TagName="ListaMenu" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <uc1:ListaMenu runat="server" id="ListaMenu" />
            </div>

            <div class="col-md-8">
                <label class="col-form-label">Ingrese el Id del chef a eliminar </label>
                <asp:TextBox ID="TBIdCheff" runat="server" CssClass="form-control-sm"></asp:TextBox>
                <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-primary mb-2" OnClick="BtnEliminar_Click" />
                <input id="BtnInicio" type="button" value="Volver al inicio" class="btn btn-primary mb-2" onclick="javascript:ReturnToHome();" />

                <br />
                <br />

                <asp:Label ID="LblError" runat="server" Text="" Visible="false" CssClass="alert alert-danger"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
