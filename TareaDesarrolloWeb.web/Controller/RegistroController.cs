using System;

namespace TareaDesarrolloWeb.web.Controller
{
    public class RegistroController
    {
        /// <summary>
        /// Validar Usuario
        /// </summary>
        /// <param name="obclsUsuarios">Objeto Usuario</param>
        /// <returns>Confirmacion</returns>
        public String setRegistrarUsuarioController(Logica.Models.clsRegistrarUsuario obclsRegistroUsuarios, int inOpcion) {
            try
            {
                Logica.BL.ClsRegistroUsuario clsRegistroUsuario = new Logica.BL.ClsRegistroUsuario();
                return clsRegistroUsuario.setRegistroUsuario(obclsRegistroUsuarios, inOpcion);

            }catch(Exception ew)
            {
                throw ew;
            }
        }
    }
}