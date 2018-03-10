<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recuperar Password.aspx.cs" Inherits="TareaDesarrolloWeb.web.Views.Recuperar_Password.Recuperar_Password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Speak and Sell - Recuperar contraseña</title>
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
            <div class="card-header">Recuperar Contraseña</div>
            <div class="card-body">
                <div class="text-center mt-4 mb-5">
                    <h4>Olvido su contraseña?</h4>
                    <p>Ingrese su Nombre de Usuario para recuperar o crear una contraseña nueva.</p>
                </div>
                <form id="Form1" runat="server">
                    <div class="form-group">
                        <asp:TextBox ID="txtIngresarEmail" runat="server" CssClass="form-control" placeholder="Ingresa tu nombre" />
                    </div>
                    <asp:Button ID="btnRecuperar" runat="server" CssClass="btn btn-primary btn-block" Text="Recuperar Contraseña" OnClick="btnRecuperar_Click"/>
                </form>
                <div class="text-center">
                    <a class="d-block small mt-3" href="../Registrar/Registrar.aspx">Crear Cuenta</a>
                    <a class="d-block small" href="../Login/Login.aspx">Ingresar</a>
                </div>
            </div>
        </div>
    </div>
    
</body>

</html>
