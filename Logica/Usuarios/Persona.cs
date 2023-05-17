namespace Logica.Usuarios
{
    public abstract class Persona
    {
        private int _id;
        private string _nombre;
        private string _usuario;
        private string _contrasenia;

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