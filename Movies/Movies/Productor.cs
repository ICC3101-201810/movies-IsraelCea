using System;


namespace Movies

{
    [Serializable]
    public class Productor : Persona
    {
        public Productor(string nombre, string apellido, DateTime fechaNac, string bibliografia)
           : base(nombre, apellido, fechaNac, bibliografia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.bibliografia = bibliografia;
        }
    }
}