<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppTemplate.Default" %>

<%@ Register Src="~/ListaMenu.ascx" TagPrefix="uc1" TagName="ListaMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <%
                var Op = "";
                if (Request.QueryString["Op"] != null)
                {
                    Op = Request.QueryString["Op"].ToString();
                }
            %>
            <%if (Op == "GetById")
                { %>
            <div class="col-md-4">
            </div>

            <div class="col-md-8">
                <label class="col-form-label">Ingrese el Id del chef a buscar </label>
                <asp:TextBox ID="TBIdCheff" runat="server" CssClass="form-control-sm"></asp:TextBox>
                <asp:Button ID="BtnConsultar" runat="server" Text="Consultar" CssClass="btn btn-primary mb-2" OnClick="BtnConsultar_Click" />
                <input id="BtnInicio" type="button" value="Volver al inicio" class="btn btn-primary mb-2" onclick="javascript:ReturnToHome();" />
            </div>
            <br />

            <%} %>

            <div class="col-md-4">
                <uc1:ListaMenu runat="server" id="ListaMenu" />
            </div>
            <div class="col-md-8">
                <asp:GridView ID="GridView1" runat="server" CssClass="table table-sm"></asp:GridView>

            </div>
        </div>
    </div>

</asp:Content>
