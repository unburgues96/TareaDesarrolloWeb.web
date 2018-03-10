using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TareaDesarrolloWeb.web.Views.Recuperar_Password
{
    public partial class Recuperar_Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                String stMensaje = String.Empty;
                if (String.IsNullOrEmpty(txtIngresarEmail.Text)) stMensaje = "Ingrese el Email";
                if (!String.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje);
            }
            catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }
        }

        protected void btnRecuperar_Click1(object sender, EventArgs e)
        {

        }
    }
}