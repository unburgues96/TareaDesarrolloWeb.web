namespace TareaDesarrolloWeb.Logica.Models
{
    public class ClsCorreo
    {
        public string stServidor { get; set; }
        public string stUsuarioCorreo { get; set; }
        public string stContraseñaCorreo { get; set; }
        public bool blConexionSegura { get; set; }
        public bool blAutenticacion { get; set; }
        public string stDesdeCorreo { get; set; }
        public string stParaCorreo { get; set; }
        public string stAsunto { get; set; }
        public string stMensaje { get; set; }
        public int inTipo { get; set; }
        public int inPrioridad { get; set; }
        public string stPuerto { get; set; }
        public string stImagen { get; set; }
        public string stIdImagen { get; set; }
    }
}
