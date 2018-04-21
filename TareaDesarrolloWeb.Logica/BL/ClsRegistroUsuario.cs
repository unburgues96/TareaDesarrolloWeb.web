using System;
using System.Data;
using System.Data.SqlClient;

namespace TareaDesarrolloWeb.Logica.BL
{
    public class ClsRegistroUsuario
    {
        SqlConnection _SqlConnection = null;//me permite establecer comunicacion con la base de datos
        SqlCommand _SqlCommand = null;//me permite ejecutar comandos SQL
        SqlDataAdapter _SqlDataAdapter = null;//me permite adaptar un conjunto de datos sql
        SqlParameter _SqlParameter = null;

        public string setRegistroUsuario(Models.clsRegistrarUsuario obclsRegistroUsuarios, int inOpcion)
        {
            try
            { 
                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("sp_RegistrarNuevoUs", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@Nombre", obclsRegistroUsuarios.StNombre));
                _SqlCommand.Parameters.Add(new SqlParameter("@Apellido", obclsRegistroUsuarios.StApellido));
                _SqlCommand.Parameters.Add(new SqlParameter("@Correo", obclsRegistroUsuarios.StCorreo));
                _SqlCommand.Parameters.Add(new SqlParameter("@Telefono", obclsRegistroUsuarios.StTelefono));
                _SqlCommand.Parameters.Add(new SqlParameter("@UserName", obclsRegistroUsuarios.StUserName));
                _SqlCommand.Parameters.Add(new SqlParameter("@Contraseña", obclsRegistroUsuarios.StContraseña));
                _SqlCommand.Parameters.Add(new SqlParameter("@Cedula", obclsRegistroUsuarios.LgCedula));
                _SqlCommand.Parameters.Add(new SqlParameter("@CodPerfil",inOpcion));

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

        public string setImagenUsuario(Models.clsRegistrarUsuario obclsRegistroUsuarios)
        {
            try
            {
                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("sp_AgregarImagen", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@Imagen", obclsRegistroUsuarios.stImagen));
                _SqlCommand.Parameters.Add(new SqlParameter("@UserName", obclsRegistroUsuarios.StUserName));

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


        String stConexion = String.Empty;//Cadena de conexion

        public ClsRegistroUsuario()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }     
        }
    } 

