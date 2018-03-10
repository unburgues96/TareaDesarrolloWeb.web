using System;

using System.Configuration;

namespace TareaDesarrolloWeb.Logica.BL
{
    public class clsConexion
    {

        /// <summary>
        /// Obtiene Conexion  a base de datos
        /// </summary>
        /// <returns>Cadena de conexion</returns>
        public String getConexion()
        {
            return ConfigurationManager.ConnectionStrings["Cnx"].ToString();
        }
    }
}
