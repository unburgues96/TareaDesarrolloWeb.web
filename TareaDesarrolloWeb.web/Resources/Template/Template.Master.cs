using System;

namespace TareaDesarrolloWeb.web.Resources.Template
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["SessionUser"] == null)
                {
                    Response.Redirect("../../Views/Login/Login.aspx");
                }
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.RemoveAll(); //Elimina todas las variables de session
            Response.Redirect("../../Views/Login/Login.aspx");
        }

        protected void btnVerPerfi_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Views/Perfil/Perfil.aspx");
        }

        protected void btnVerInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Views/Inicio/Inicio.aspx");
        }

        protected void btnChat_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../Views/Chat/Chat.aspx");
        }
    }
}