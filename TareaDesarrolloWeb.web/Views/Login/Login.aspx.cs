using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// gihih
namespace TareaDesarrolloWeb.web.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                String stMensaje = String.Empty;
                if (String.IsNullOrEmpty(txtUser.Text)) stMensaje += "Ingrese Email, ";
                if (String.IsNullOrEmpty(txtPassword.Text)) stMensaje += "Ingrese Contraseña, ";
                if (!String.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                //Defino Objeto con prioridades
                Logica.Models.clsUsuarios obclsUsuarios = new Logica.Models.clsUsuarios
                {
                    stLogin = txtUser.Text,
                    stPassword = txtPassword.Text

                };
                //Instancio Controlador
                Controller.LoginController obLogingController = new Controller.LoginController();
                bool blBandera = obLogingController.getValidarUsuarioController(obclsUsuarios);

                if (blBandera)
                    Response.Redirect("../Index/Index.aspx");//Redirecciono
                else
                    throw new Exception("Usuario o password incorrectos");

            }
            catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '"+ex.Message+"!', 'error')</Script>");
            }
        }
    }
}