using System;
using System.Configuration;
using System.Data;

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
                if (String.IsNullOrEmpty(txtIngresarUsuario.Text)) stMensaje = "Ingrese el nombre de usuario";
                if (!String.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje);

                Controller.RecuperarContraseñaController obRecuperarContraseñaController = new Controller.RecuperarContraseñaController();
                Logica.Models.clsUsuarios obclsUsuarios = new Logica.Models.clsUsuarios
                {
                    StLogin = txtIngresarUsuario.Text
                };

                DataSet dsConsulta = obRecuperarContraseñaController.getConsultaContraseñaController(obclsUsuarios);
                if (dsConsulta.Tables[0].Rows.Count > 0)
                {
                    
                    string stCorreo = dsConsulta.Tables[0].Rows[0][1].ToString();
                    string stContraseñaRec = dsConsulta.Tables[0].Rows[0][0].ToString();
                    string[] stNombreUss = stCorreo.Split('@');
                    
                    string stMensajeCorreo = "<!DOCTYPE htmll>";
                    stMensajeCorreo += "<html lang='es'›";
                    stMensajeCorreo += "<head>";
                    stMensajeCorreo += "<meta charset='utf - 8'>";
                    stMensajeCorreo += "<title> Recuperacion de correo </title >";
                    stMensajeCorreo += "</head>";
                    stMensajeCorreo += "<body style='background - color: black '>";
                    stMensajeCorreo += "<table style='max - width: 600px; padding: l0px; margin: 0 auto; border - collapse: collapse; '>";
                    stMensajeCorreo += "<tr>";
                    stMensajeCorreo += "<td style='padding:0'>";
                    stMensajeCorreo += "<img style='padding: 0; display: block' src='cid:Fondo' width='100 %' height='10 % '>";
                    stMensajeCorreo += "</td>";
                    stMensajeCorreo += "</tr>";
                    stMensajeCorreo += "<tr>";
                    stMensajeCorreo += "<td style='background - color: #ecf0f1'›";
                    stMensajeCorreo += "<div style='color: #34495e; margin: 4% 10% 2%; text-align: justify;font-family: sans-serif'>";
                    stMensajeCorreo += "<h2 style='color: #e67e22; margin: 0 0 7px'>Hola " + stNombreUss[0] + "</h2>";
                    stMensajeCorreo += "<p style='margin: 2px; font - size: 15pxo'>";
                    stMensajeCorreo += "Hemos recibido una solicitud para recuperar la contraseña de su cuenta asociada con";
                    stMensajeCorreo += " esta dirección de correo electrónico. Si no ha realizado esta solicitud, puede ignorar este";
                    stMensajeCorreo += "correo electrónico y le garantizamos que su cuenta es completamente segura.";
                    stMensajeCorreo += "<br/> ";
                    stMensajeCorreo += "<bri> Su contraseña es: " + stContraseñaRec;
                    stMensajeCorreo += "</p>";
                    stMensajeCorreo += "<p style='color: #b3b3b3; font-size: 12px; text-align: center;margin: 30px 0 0'>Copyright © Speak and Sell 2018</p> </div>";
                    stMensajeCorreo += "</td>";
                    stMensajeCorreo += "</tr>";
                    stMensajeCorreo += "</table>";
                    stMensajeCorreo += "</body>";
                    stMensajeCorreo += "</html>";

                    Logica.Models.ClsCorreo obClsCorreo = new Logica.Models.ClsCorreo
                    {
                        stServidor = ConfigurationManager.AppSettings["stServidor"].ToString(),
                        stUsuarioCorreo = ConfigurationManager.AppSettings["stUsuario"].ToString(),
                        stContraseñaCorreo = ConfigurationManager.AppSettings["stContraseña"].ToString(),
                        stPuerto = ConfigurationManager.AppSettings["stPuerto"].ToString(),
                        blAutenticacion = true,
                        blConexionSegura = true,
                        inPrioridad = 0, //Defino prioridad (2 Alta,1 Media,0 Baja)
                        inTipo = 1, //html
                        stAsunto = "Recuperar Contraseña",
                        stDesdeCorreo = ConfigurationManager.AppSettings["stUsuario"].ToString(),
                        stParaCorreo = stCorreo,
                        stImagen = Server.MapPath("~") + @"\Resources\Images\Fondo.jpeg",
                        stIdImagen = "Fondo",
                        stMensaje = stMensajeCorreo
                    };

                    obRecuperarContraseñaController.SendCorreoController(obClsCorreo);
                    ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('BIEN!', 'Tu contraseña se ha enviado a tu correo!', 'info')</Script>");

                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', 'No se encontro un usuario correspondiente al nombre ingresado', 'info')</Script>");

                    throw new Exception("No se encontro un usuario correspondiente al nombre ingresado");

                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }
        }

    }
}