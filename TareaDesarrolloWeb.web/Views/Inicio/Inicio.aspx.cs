using System;
using System.IO;

namespace TareaDesarrolloWeb.web.Views.Inicio
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPublicar_Click(object sender, EventArgs e)
        {
            try
            {
                string stUsuariosesion = Session["SessionUser"].ToString();
                Controller.ImagenPublicacionController obimagenPublicacionController = new Controller.ImagenPublicacionController();

                if (imgPublicacion.HasFile)
                {
                    if (!Path.GetExtension(imgPublicacion.FileName).Equals((".jpg")))
                    {
                        throw new Exception("Solo se admiten formatos .JPG");
                    }

                    string stRuta = Server.MapPath(@"~\tmp\") + imgPublicacion.FileName; //Ruta temporal
                    imgPublicacion.PostedFile.SaveAs(stRuta); //Guardar archivo en el proyecto  
                    string stRutaFinal = Server.MapPath(@"~\Images Publicacion\") + stUsuariosesion + Path.GetExtension(imgPublicacion.FileName); //Ruta de destino

                    if (File.Exists(stRutaFinal))
                    {
                        File.SetAttributes(stRutaFinal, FileAttributes.Normal);
                        File.Delete(stRutaFinal);
                    }

                    File.Copy(stRuta, stRutaFinal);
                    File.SetAttributes(stRuta, FileAttributes.Normal);
                    File.Delete(stRuta);
                    Logica.Models.clsInicio obclsInicio = new Logica.Models.clsInicio
                    {
                        stImagen = stRutaFinal,
                        stDescripcion = txtPublicacion.Text,
                        stNombreUsuario = stUsuariosesion
                    };

                    iPublicacion.ImageUrl = "~/Images Publicacion/" + stUsuariosesion + ".jpg";
                    lblNombreUssPublicacion.Text = stUsuariosesion;
                    lblDescripcionArticulo.Text = txtPublicacion.Text;

                    ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('Mensaje!', '" + obimagenPublicacionController.setImagenPublicacionController(obclsInicio) + "!', 'success')</Script>");

                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }
        }
    }
}