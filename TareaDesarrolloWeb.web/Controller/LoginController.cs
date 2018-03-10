using System;

namespace TareaDesarrolloWeb.web.Controller
{
    public class LoginController
    {
        /// <summary>
        /// Validar Usuario
        /// </summary>
        /// <param name="obclsUsuarios">Objeto Usuario</param>
        /// <returns>Confirmacion</returns>
        public bool getValidarUsuarioController(Logica.Models.clsUsuarios obclsUsuarios) {
            try
            {
                Logica.BL.clsUsuarios obclsUsuario = new Logica.BL.clsUsuarios();
                return obclsUsuario.getValidarUsuario(obclsUsuarios);

            }catch(Exception ew)
            {
                throw ew;
            }
        }
    }
}