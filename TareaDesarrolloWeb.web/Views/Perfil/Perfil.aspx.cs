using System;
using System.Data;

namespace TareaDesarrolloWeb.web.Views.Perfil
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionUser"] == null)
            {
                Response.Redirect("../../Views/Login/Login.aspx");
            }

            string stUsuariosesion = Session["SessionUser"].ToString();
            if (!IsPostBack)
            {
                try
                {
                    Controller.PerfilController obperfilController = new Controller.PerfilController();
                    DataSet dsConsulta = obperfilController.getConsultarPerfilController(stUsuariosesion);
                    txtUserName.Text = stUsuariosesion;
                    if (dsConsulta.Tables[0].Rows.Count > 0)
                    {
                        txtNombre.Text = Convert.ToString(dsConsulta.Tables[0].Rows[0][1]);
                        txtApellido.Text = Convert.ToString(dsConsulta.Tables[0].Rows[0][2]);
                        txtCorreo.Text = Convert.ToString(dsConsulta.Tables[0].Rows[0][3]);

                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
                }



            }
        }
    }
}