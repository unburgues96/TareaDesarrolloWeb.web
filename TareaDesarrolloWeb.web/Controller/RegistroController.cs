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
        public String setRegistrarUsuarioController(Logica.Models.clsRegistrarUsuario obclsRegistroUsuariosModels, int inOpcion) {
            try
            {
                Logica.BL.ClsRegistroUsuario obclsRegistroUsuario = new Logica.BL.ClsRegistroUsuario();
                return obclsRegistroUsuario.setRegistroUsuario(obclsRegistroUsuariosModels, inOpcion);

            }catch(Exception ew)
            {
                throw ew;
            }
        }
    }
}