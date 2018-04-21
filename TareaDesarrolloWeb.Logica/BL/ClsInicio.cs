using System;
using System.Data;
using System.Data.SqlClient;

namespace TareaDesarrolloWeb.Logica.BL
{
    public class ClsInicio
    {
        SqlConnection _SqlConnection = null;//me permite establecer comunicacion con la base de datos
        SqlCommand _SqlCommand = null;//me permite ejecutar comandos SQL
        SqlDataAdapter _SqlDataAdapter = null;//me permite adaptar un conjunto de datos sql
        String stConexion = String.Empty;//Cadena de conexion
        SqlParameter _SqlParameter = null;


        public ClsInicio()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }

        public string setImagenPublicacion (Models.clsInicio obclsInicio)
        {
            try
            {
                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("sp_NuevaPublicacion", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@Imagen", obclsInicio.stImagen));
                _SqlCommand.Parameters.Add(new SqlParameter("@UserName", obclsInicio.stNombreUsuario));
                _SqlCommand.Parameters.Add(new SqlParameter("@Descripcion", obclsInicio.stDescripcion));

                _SqlParameter = new SqlParameter();

                _SqlParameter.ParameterName = "@cMensaje";
                _SqlParameter.Direction = ParameterDirection.Output;
                _SqlParameter.SqlDbType = SqlDbType.VarChar;
                _SqlParameter.Size = 50;

                _SqlCommand.Parameters.Add(_SqlParameter);

                _SqlCommand.ExecuteNonQuery();

                return _SqlParameter.Value.ToString();
            }
            catch (Exception ew)
            {
                throw ew;
            }
            finally { _SqlConnection.Close(); }
        }

    }
}
