<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateCheff.aspx.cs" Inherits="WebAppTemplate.UpdateCheff" %>

<%@ Register Src="~/ListaMenu.ascx" TagPrefix="uc1" TagName="ListaMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
            </div>

            <div class="col-md-8">
                <label class="col-form-label">Ingrese el Id del chef a modificar </label>
                <asp:TextBox ID="TBIdCheff" runat="server" CssClass="form-control-sm"></asp:TextBox>
                <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" CssClass="btn btn-primary mb-2" OnClick="BtnConsultar_Click" />
                <input id="BtnInicio" type="button" value="Volver al inicio" class="btn btn-primary mb-2" onclick="javascript:ReturnToHome();" />
            </div>

            <% %>
            <div class="col-md-4">
                <uc1:ListaMenu runat="server" id="ListaMenu" />
            </div>
            <div class="col-md-8 form-group mb-2">

                <label class="col-sm-2 col-form-label">Id</label>
                <asp:TextBox ID="TBId" runat="server" CssClass="form-control-sm"></asp:TextBox>
                <br />

                <label class="col-sm-2 col-form-label">Nombre</label>
                <asp:TextBox ID="TBNombre" runat="server" CssClass="form-control-sm"></asp:TextBox>
                <br />

                <label class="col-sm-2 col-form-label">Apellido</label>
                <asp:TextBox ID="TBApellido" runat="server" CssClass="form-control-sm"></asp:TextBox>
                <br />

                <label class="col-sm-2 col-form-label">Telefono</label>
                <asp:TextBox ID="TBTelefono" runat="server" CssClass="form-control-sm"></asp:TextBox>
                <br />

                <label class="col-sm-2 col-form-label">Especialidad</label>
                <asp:TextBox ID="TBEspecialidad" runat="server" CssClass="form-control-sm"></asp:TextBox>
                <br />

                <br />

                <asp:Button ID="BtnGuardar" runat="server" Text="Confirmar" CssClass="btn btn-primary mb-2" OnClick="BtnGuardar_Click" />

                <br />
                <br />

                <asp:Label ID="LblError" runat="server" Text="" Visible="false" CssClass="alert alert-danger"></asp:Label>

            </div>
        </div>
    </div>
</asp:Content>
