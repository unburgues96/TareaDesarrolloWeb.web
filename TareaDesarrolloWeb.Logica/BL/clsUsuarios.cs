using System;
using System.Data;
using System.Data.SqlClient;

namespace TareaDesarrolloWeb.Logica.BL
{
    public class clsUsuarios
    {
        SqlConnection _SqlConnection = null;//me permite establecer comunicacion con la base de datos
        SqlCommand _SqlCommand = null;//me permite ejecutar comandos SQL
        SqlDataAdapter _SqlDataAdapter = null;//me permite adaptar un conjunto de datos sql
        String stConexion = String.Empty;//Cadena de conexion

        public clsUsuarios()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }
        /// <summary>
        /// Validar Usuarios
        /// </summary>
        /// <param name="obclsUsuarios">Objeto Usuario</param>
        /// <returns>Confirmacion</returns>

        public bool getValidarUsuario(Models.clsUsuarios obclsUsuarios)
        {
            try
            {
                DataSet dsConsulta = new DataSet();
                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("sp_IniciodeSesion", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@UserName", obclsUsuarios.StLogin));
                _SqlCommand.Parameters.Add(new SqlParameter("@PassWord", obclsUsuarios.StPassword));
                _SqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                if (dsConsulta.Tables[0].Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ew)
            {
                throw ew;
            }
            finally { _SqlConnection.Close(); }
        }
    }
}

