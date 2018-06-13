using System;


namespace Movies

{
    [Serializable]
    public class Actor : Persona
    {
        public Actor(string nombre, string apellido, DateTime fechaNac, string bibliografia)
           : base(nombre, apellido, fechaNac, bibliografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.bibliografia = bibliografia;
        }
    }

}