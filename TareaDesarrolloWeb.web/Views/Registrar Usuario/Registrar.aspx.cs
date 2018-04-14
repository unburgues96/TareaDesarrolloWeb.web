using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TareaDesarrolloWeb.web.Views.Registrar
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
             ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('Bienvenido!', 'Completa los campos para registrarte!', 'info')</Script>");
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                String stMensaje = String.Empty;
                if (String.IsNullOrEmpty(txtNombre.Text)) stMensaje += "Ingrese el Nombre,";
                if (String.IsNullOrEmpty(txtLastName.Text)) stMensaje += " Ingrese el apellido,";
                if (String.IsNullOrEmpty(txtCorreo.Text)) stMensaje += " Ingrese Email,";
                if (String.IsNullOrEmpty(txtContraseña.Text)) stMensaje += " Ingrese La Contraseña,";
                if (!String.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                //Defino Objeto con prioridades
                Logica.Models.clsRegistrarUsuario obclsRegistarUsuario = new Logica.Models.clsRegistrarUsuario
                {
                    LgCedula = Convert.ToInt64(TxtCedula.Text),
                    StNombre = txtNombre.Text,
                    StApellido = txtLastName.Text,
                    StCorreo = txtCorreo.Text,
                    StTelefono = Txttelefono.Text,
                    StUserName = TxtNickName.Text,
                    StContraseña = txtContraseña.Text,
                    

                };
                //Instancio Controlador
                Controller.RegistroController obRegistroController = new Controller.RegistroController();
                if (string.IsNullOrEmpty(lblOpcion.Text)) lblOpcion.Text = "2";
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('Mensaje', '" + obRegistroController.setRegistrarUsuarioController(obclsRegistarUsuario,Convert.ToInt32(lblOpcion.Text)) + "!', 'success')</Script>");
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }
        }
    }
}