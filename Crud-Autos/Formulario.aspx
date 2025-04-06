<%@ Page Title="" Language="C#" MasterPageFile="~/miMaster.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Crud_Autos.Formulario1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="./Content/Formulario.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center">
        <h1>Formulario</h1>
        <div class="row">
            <div class="col">
                <div class="mb-3">
                    <label for="txtId" class="form-label">Ingrese el ID</label>
                    <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <label for="txtModelo" class="form-label">Ingrese el Modelo</label>
                    <asp:TextBox runat="server" ID="txtModelo" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <label for="txtDescripcion" class="form-label">Ingrese la Descripcion</label>
                    <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine" />
                </div>
                <div class="mb-3">
                    <label for="ddlColores" class="form-label">Ingrese el color</label>
                    <asp:DropDownList runat="server" ID="ddlColores" CssClass="form-select"></asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="txtFecha" class="form-label">Ingrese la Fecha</label>
                    <asp:TextBox runat="server" ID="txtFecha" CssClass="form-control" TextMode="Date" />
                </div>
                <div>
                    <label for="rbImportado" class="form-label">¿Es usado?</label>
                </div>
                <div class="mb-3">
                    <asp:CheckBox runat="server" Text="Usado" CssClass="form-check-input" ID="cbUsado"></asp:CheckBox>
                </div>
                <div class="mb-3">
                    <label for="rbImportado" class="form-label">¿Es importado o nacional?</label>
                </div>
                <div class="mb-3">
                    <asp:RadioButton ID="rbImportado" CssClass="form-check-input" Text="Importado" Checked="true" GroupName="Importado" runat="server" />
                </div>
                <div class="mb-5">
                    <asp:RadioButton ID="rbNacional" CssClass="form-check-input" Text="Nacional" GroupName="Importado" runat="server" />
                </div>
                <div class="mb-3">
                    <asp:Button ID="btnAceptar" Text="Aceptar" OnClick="btnAceptar_Click" CssClass="btn btn-success" runat="server" />
                    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Text="Cancelar" />
                </div>
                
            </div>
        </div>
    </div>
</asp:Content>
