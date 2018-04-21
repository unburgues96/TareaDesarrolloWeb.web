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
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('Buen Trabajo!', 'Se realizo proceso con exito!', 'success')</Script>");
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
            }
            catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }
        }
    }
}