using System;

namespace TareaDesarrolloWeb.web.Controller
{
    public class ImagenPerfilController
    {
        public string setImagenPerfilController(Logica.Models.clsRegistrarUsuario obclsRegistrarUsuario)
        {
            try
            {
                Logica.BL.ClsRegistroUsuario obclsRegistroUsuario = new Logica.BL.ClsRegistroUsuario();
                return obclsRegistroUsuario.setImagenUsuario(obclsRegistrarUsuario);
            } catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}