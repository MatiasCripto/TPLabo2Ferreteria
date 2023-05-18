namespace Logica.Usuarios
{
    public abstract class Persona
    {
        private int _id;
        static int nexId = 1;
        private string _nombre;
        private string _usuario;
        private string _contrasenia;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; }
        public string Usuario { get => _usuario; }
        public string Contrasenia { get => _contrasenia; }
        public static int NexId { get => ++nexId; set => nexId = value; }

        protected Persona(int id, string nombre, string usuario, string contrasenia)
        {
            this._id = id;
            this._nombre = nombre;
            this._usuario = usuario;
            this._contrasenia = contrasenia;
        } 
        protected Persona(string nombre, string usuario, string contrasenia)
        {
            
            this._nombre = nombre;
            this._usuario = usuario;
            this._contrasenia = contrasenia;
        }
        public bool ComprobarUsuario(string usuario, string contrasenia)
        {
            return (this._usuario == usuario && this._contrasenia == contrasenia);
        }
    }
}