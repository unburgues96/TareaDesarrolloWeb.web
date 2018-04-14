using System;
using System.Data;

namespace TareaDesarrolloWeb.web.Controller
{
    public class PerfilController
    {
        public DataSet getConsultarPerfilController(string stNombre)
        {
            try
            {
                Logica.BL.ClsPerfil obClsPerfil = new Logica.BL.ClsPerfil();
                return obClsPerfil.getConsultarPerfil(stNombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}