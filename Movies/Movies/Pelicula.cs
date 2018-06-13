using System;



namespace Movies

{
    [Serializable]
    public class Pelicula

    {
        public string nombre;
        public Director director;
        public DateTime fechaEstreno;
        public string descripcion;
        public int presupuesto;
        public Estudio estudio;

        public Pelicula(string nombre, Director director, DateTime fechaEstreno, string descripcion, int presupuesto, Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fechaEstreno = fechaEstreno;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;

        }
        public Director GetDirecor()
        {
            return director;
        }
        public DateTime GetEstreno()
        {
            return fechaEstreno;

        }
        public override string ToString()
        {
            return "Pelicula: " + nombre + "---Director " + director.nombre;
        }
    }
}
