<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="TareaDesarrolloWeb.web.Views.Perfil.Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
    <div class="mx-auto mt-5">

        <div class="form-group">
            <div class="form-row">
                <div class="col-md-4">
                    <h2><b>Mi Perfil</b></h2>
                </div>
                <div class="col-md-8">
                   <h2><b>Imagen</b></h2>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-4">
                    <asp:Label runat="server" ID="lblUserName" Text="Usuario"></asp:Label>
                    <asp:TextBox runat="server" ID="txtUserName" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                    <asp:Label runat="server" ID="lblNombre" Text="Nombre"></asp:Label>
                    <asp:TextBox runat="server" ID="txtNombre" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                    <asp:Label runat="server" ID="lblApellido" Text="Apellido"></asp:Label>
                    <asp:TextBox runat="server" ID="txtApellido" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                    <asp:Label runat="server" ID="lblCorreo" Text="Correo"></asp:Label>
                    <asp:TextBox runat="server" ID="txtCorreo" ReadOnly="true" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-8">
                    <asp:Image runat="server" Height="200px" Width="140px" ID="iCuenta" />
                    <br />
                    <asp:FileUpload runat="server" ID="ImgPerfil" CssClass="form-control-file" />
                     <asp:Button runat="server" ID="btnActualizar" Text="Actualizar Foto" CssClass="btn btn-primary" OnClick="btnActualizar_Click"></asp:Button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
