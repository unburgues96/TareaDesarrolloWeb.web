using System.Data;
using System;

namespace TareaDesarrolloWeb.web.Controller
{
    public class RecuperarContraseñaController
    {
        public DataSet getConsultaContraseñaController(Logica.Models.clsUsuarios obclsUsuarios)
        {
            try
            {
                Logica.BL.ClsRecuperarContraseña obclsRecuperarContraseña = new Logica.BL.ClsRecuperarContraseña();
                return obclsRecuperarContraseña.getConsultarContraseña(obclsUsuarios);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SendCorreoController(Logica.Models.ClsCorreo obclsCorreo)
        {
            try
            {
                Logica.BL.ClsGeneral obclsGeneral = new Logica.BL.ClsGeneral();
                obclsGeneral.SendCorreo(obclsCorreo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}