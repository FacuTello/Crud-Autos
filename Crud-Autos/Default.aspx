<%@ Page Title="" Language="C#" MasterPageFile="~/miMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Crud_Autos.Formulario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="./Content/Default.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Nuestros Modelos Disponibles</h1>
    <div class="row">
        <div class="col-8">
            <asp:GridView runat="server" ID="grillaAutos" CssClass="table table-striped" >   </asp:GridView>
        </div>
    </div>
    <a href="Formulario.aspx" class="btn btn-success">Agregar</a>
</asp:Content>
