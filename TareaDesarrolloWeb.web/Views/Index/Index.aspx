<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TareaDesarrolloWeb.web.Views.Index.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
    <div class="container">
        <div class="card mx-auto mt-5">
            <div class="card-header">
                Bienvenido
            </div>
            <div class="card-body">
                <asp:Image runat="server" Height="70px" Width="70px" ID="imgCuenta" />
            </div>
        </div>
    </div>
</asp:Content>
