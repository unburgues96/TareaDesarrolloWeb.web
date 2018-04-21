﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TareaDesarrolloWeb.web.Views.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Speak and Sell - Iniciar Sesion</title>
    <!-- Bootstrap core CSS-->
    <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom fonts for this template-->
    <link href="../../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <!-- Custom styles for this template-->
    <link href="../../css/sb-admin.css" rel="stylesheet" />
    <!-- Bootstrap core JavaScript-->
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>

    <link href="../../css/sweetalert.css" rel="stylesheet" />
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
</head>
<body class="bg-dark">
    <div class="container">
        <div class="card card-login mx-auto mt-5">
            <div class="card-header">Iniciar Sesion</div>
            <div class="card-body">
                <form id="Form1" runat="server">
                    <div class="form-group">
                        <asp:Label ID="lblUser" runat="server" Text="Usuario"></asp:Label>
                        <asp:TextBox ID="txtUser" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ErrorMessage="Campo Requerido" ForeColor="Red" ControlToValidate="txtUser" ValidationGroup="Validar_Sesion"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblPassword" runat="server" Text="Contraseña"></asp:Label>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Campo Requerido" ForeColor="Red" ControlToValidate="txtPassword" ValidationGroup="Validar_Sesion"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <div class="form-check">
                            <label class="form-check-label" />
                            <asp:CheckBox ID="chkRecordar" runat="server" Text="Recordar Usuario" />
                        </div>
                    </div>
                    <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary btn-block" Text="Aceptar" ValidationGroup="Validar_Sesion" OnClick="btnAceptar_Click" />
                </form>
                <div class="text-center">
                    <a class="d-block small mt-3" href="../Registrar Usuario/Registrar.aspx">Registrar Cuenta</a>
                    <a class="d-block small" href="../Recuperar Password/Recuperar Password.aspx">Olvido su contraseña?</a>
                </div>
            </div>
        </div>
    </div>

</body>

</html>
