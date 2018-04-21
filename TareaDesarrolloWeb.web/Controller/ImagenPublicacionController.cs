using System;

namespace TareaDesarrolloWeb.web.Controller
{
    public class ImagenPublicacionController
    {
        public string setImagenPublicacionController(Logica.Models.clsInicio obclsInicio)
        {
            try
            {
                Logica.BL.ClsInicio obclsInicioPub = new Logica.BL.ClsInicio();
                return obclsInicioPub.setImagenPublicacion(obclsInicio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}