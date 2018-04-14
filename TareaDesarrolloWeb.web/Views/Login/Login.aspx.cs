using System;
using System.Web;
// gihih
namespace TareaDesarrolloWeb.web.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //!IsPostBack = Primera vez que carga pagina
            if (!IsPostBack)
            {
                if (Request.Cookies["CookieUsuario"] != null)
                {
                    txtUser.Text = Request.Cookies["CookieUsuario"].Value.ToString();
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
                        //Creo el objeto cookie
                        HttpCookie Cookie = new HttpCookie("CookieUsuario", txtUser.Text);
                        //Defino tiempo de vida
                        Cookie.Expires = DateTime.Now.AddDays(2);
                        //Agrego a la colecion de cookies
                        Response.Cookies.Add(Cookie);
                    }
                    else
                    {
                        HttpCookie Cookie = new HttpCookie("CookieUsuario", txtUser.Text);
                        //Cookie expira ayer (Fecha de hoy menos 1 dia)
                        Cookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(Cookie);
                    }
                    Session["SessionUser"] = txtUser.Text;
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