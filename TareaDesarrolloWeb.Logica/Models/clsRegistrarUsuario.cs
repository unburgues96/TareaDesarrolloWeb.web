    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDesarrolloWeb.Logica.Models
{
    public class clsRegistrarUsuario
    {
        public string StNombre { get; set; }
        public string StApellido { get; set; }
        public string StCorreo { get; set; }
        public string StTelefono { get; set; }
        public string StUserName { get; set; }
        public string StContraseña { get; set; }
        public long LgCedula { get; set; }
        public int InCodigoPerfil { get; set; }
    }
}
