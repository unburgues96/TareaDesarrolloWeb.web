using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;
// gihih
namespace TareaDesarrolloWeb.web.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        if (!IsPostBack)
            {
                if (Request.Cookies["Usuario"] != null) {
                    txtUser.Text = Request.Cookies["Usuario"].Value.ToString();
                }
            }
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
                    StLogin = txtUser.Text,
                    StPassword = txtPassword.Text

                };
                //Instancio Controlador
                Controller.LoginController obLogingController = new Controller.LoginController();
                bool blBandera = obLogingController.getValidarUsuarioController(obclsUsuarios);

                if (blBandera)
                {
                    if (chkRecordar.Checked)
                    {
                        HttpCookie CookieUsuario = new HttpCookie("Usuario", txtUser.Text);
                        CookieUsuario.Expires = DateTime.Now.AddDays(2);
                        Response.Cookies.Add(CookieUsuario);
                    }
                    else
                    {
                        HttpCookie CookieUsuario = new HttpCookie("Usuario", txtUser.Text);
                        CookieUsuario.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(CookieUsuario);
                    }

                    ViewState["viewLogin"] = txtUser.Text;
                    ViewState["viewPassword"] = txtPassword.Text;

                    Response.Redirect("../Index/Index.aspx");//Redirecciono
                }
                else
                    throw new Exception("Usuario o password incorrectos");

            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }
        }
    }
}