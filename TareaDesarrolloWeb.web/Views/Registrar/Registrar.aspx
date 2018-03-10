<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="TareaDesarrolloWeb.web.Views.Registrar.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Speak and Sell - Registro</title>
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
        <div class="card card-register mx-auto mt-5">
            <div class="card-header">Registrar Cuenta</div>
            <div class="card-body">
                <form id="Form1" runat="server">
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <asp:Label ID="lblInputName" runat="server" Text="Nombre"></asp:Label>
                                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Ingresar Nombre"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label ID="lblInputLastName" runat="server" Text="Apellido"></asp:Label>
                                <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" placeholder="Ingresar Apellido"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCedula" runat="server" Text="Cedula"></asp:Label>
                        <asp:TextBox ID="TxtCedula" runat="server" CssClass="form-control" placeholder="Ingresar Cedula"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCorreo" runat="server" Text="Correo"></asp:Label>
                        <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" placeholder="Ingresar Email"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblTelefono" runat="server" Text="Telefono"></asp:Label>
                        <asp:TextBox ID="Txttelefono" runat="server" CssClass="form-control" placeholder="Ingresar Telefono"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblNickName" runat="server" Text="Nombre de Usuario"></asp:Label>
                        <asp:TextBox ID="TxtNickName" runat="server" CssClass="form-control" placeholder="Ingresar Nombre de Usuario"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblContraseña" runat="server" Text="Contraseña"></asp:Label>
                        <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control" placeholder="Ingresar Contraseña" TextMode="Password"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary btn-block" Text="Registrar" OnClick="btnRegistrar_Click" />
                </form>
                <div class="text-center">
                    <a class="d-block small mt-3" href="../Login/Login.aspx">Iniciar Sesion</a>
                    <a class="d-block small" href="../Recuperar Password/Recuperar Password.aspx">¿Olvido su Contraseña?</a>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
