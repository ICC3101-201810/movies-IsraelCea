using System;



namespace Movies

{
    [Serializable]
    public class Pelicula

    {
        string nombre;
        Director director;
        DateTime fechaEstreno;
        string descripcion;
        int presupuesto;
        Estudio estudio;

        public Pelicula(string nombre, Director director, DateTime fechaEstreno, string descripcion, int presupuesto, Estudio estudio)
        {
            this.nombre = nombre;
            this.director = director;
            this.fechaEstreno = fechaEstreno;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;

        }
    }
}
