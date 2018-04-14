using System;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace TareaDesarrolloWeb.Logica.BL
{
    public class ClsGeneral
    {
        public void SendCorreo(Models.ClsCorreo obClsCorreo)
        {
            try
            {
                //Objeto del correo
                System.Net.Mail.MailMessage Correo = new MailMessage();

                Correo.From = new System.Net.Mail.MailAddress(obClsCorreo.stDesdeCorreo);
                Correo.To.Add(obClsCorreo.stParaCorreo);
                Correo.Subject = obClsCorreo.stAsunto;
                Correo.Body = obClsCorreo.stMensaje;

                if (obClsCorreo.inTipo == 0 ) Correo.IsBodyHtml = false;
                else if (obClsCorreo.inTipo == 1) Correo.IsBodyHtml = true;

                if (obClsCorreo.inPrioridad == 2) Correo.Priority = MailPriority.High;
                else if (obClsCorreo.inPrioridad == 1) Correo.Priority = MailPriority.Low;
                else if (obClsCorreo.inPrioridad == 0) Correo.Priority = MailPriority.Normal;

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(obClsCorreo.stMensaje, Encoding.UTF8,
                    MediaTypeNames.Text.Html);
                
                LinkedResource Img = new LinkedResource(obClsCorreo.stImagen,MediaTypeNames.Image.Jpeg);
                Img.ContentId = obClsCorreo.stIdImagen;
                htmlView.LinkedResources.Add(Img); 
                //Para agregar imagen de encabezado al correo
                

                //Cliente del servidor del correo
                SmtpClient smtp = new SmtpClient();
                smtp.Host = obClsCorreo.stServidor;

                if (obClsCorreo.blAutenticacion) smtp.Credentials = new System.Net.NetworkCredential(obClsCorreo.stUsuarioCorreo, obClsCorreo.stContraseñaCorreo);
                if (obClsCorreo.stPuerto.Length > 0) smtp.Port = Convert.ToInt32(obClsCorreo.stPuerto);

                smtp.EnableSsl = obClsCorreo.blConexionSegura;
                smtp.Send(Correo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
