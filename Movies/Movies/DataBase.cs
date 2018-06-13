using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Movies
{
    class DataBase
    {
        List<Pelicula> peliculas;
        List<Director> directores;
        List<Estudio> estudios;
        List<Persona> personas;
        List<PeliculaActor> actoresP;
        List<PeliculaProductor> productoresP;
        List<Actor> actores;
        List<Productor> productores;
        public List<Object> dataBase;
            

    public List<Pelicula> GetPeliculas()
    { return peliculas; }
        public List<Director> GetDirectores()
        { return directores; }
        public List<Estudio> GetEstudios()
        { return estudios; }
        public List<Persona> GetPersonas()
        { return personas; }
        public List<PeliculaActor> GetActoresP()
        { return actoresP; }
        public List<PeliculaProductor> GetProductoresP()
        { return productoresP; }
        public List<Actor> GetActores()
        { return actores; }
        public List<Productor> GetProductores()
        { return productores; }

    }
}
