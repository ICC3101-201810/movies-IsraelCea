using System;


namespace Movies
    
{
    [Serializable]
    public class Estudio
    {
        string nombre, direccion;
        DateTime fechaApertura;
        public Estudio(string nombre, string direccion, DateTime fechaApertura)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaApertura = fechaApertura;
        }
        public override string ToString()
        {
            return "Estudio: " + nombre + " ---Direccion;" + direccion;
        }
    }

}
