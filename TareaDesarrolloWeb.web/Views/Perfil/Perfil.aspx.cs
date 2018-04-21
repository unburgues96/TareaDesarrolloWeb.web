using System;
using System.Data;
using System.IO;

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
            iCuenta.ImageUrl = "~/Images Perfil/" + stUsuariosesion + ".jpg";

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

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string stUsuariosesion = Session["SessionUser"].ToString();
                Controller.ImagenPerfilController obimagenPerfilController = new Controller.ImagenPerfilController();

                if (ImgPerfil.HasFile)
                {
                    if (!Path.GetExtension(ImgPerfil.FileName).Equals((".jpg")))
                    {
                        throw new Exception("Solo se admiten formatos .JPG");
                    }

                    string stRuta = Server.MapPath(@"~\tmp\") + ImgPerfil.FileName; //Ruta temporal
                    ImgPerfil.PostedFile.SaveAs(stRuta); //Guardar archivo en el proyecto  
                    string stRutaFinal = Server.MapPath(@"~\Images Perfil\") + stUsuariosesion + Path.GetExtension(ImgPerfil.FileName); //Ruta de destino

                    if (File.Exists(stRutaFinal))
                    {
                        File.SetAttributes(stRutaFinal, FileAttributes.Normal);
                        File.Delete(stRutaFinal);
                    }

                    File.Copy(stRuta, stRutaFinal);
                    File.SetAttributes(stRuta, FileAttributes.Normal);
                    File.Delete(stRuta);

                    Logica.Models.clsRegistrarUsuario obclsRegistrarUsuario = new Logica.Models.clsRegistrarUsuario
                    {
                        StUserName = stUsuariosesion,
                        stImagen = stRutaFinal
                    };
                    iCuenta.ImageUrl = "~/Images Publicacion/" + stUsuariosesion + ".jpg";

                    ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('Mensaje!', '" + obimagenPerfilController.setImagenPerfilController(obclsRegistrarUsuario) + "!', 'success')</Script>");
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }
        }
    }
}