using System;


namespace Movies
{
    [Serializable]
    public class Persona
    {
        public string nombre, apellido, bibliografia;
        public DateTime fechaNac;

        public Persona(string nombre, string apellido, DateTime fechaNac, string bibliografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.bibliografia = bibliografia;
        }


    }
}
