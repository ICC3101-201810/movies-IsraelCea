using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    [Serializable]
    public class PeliculaActor
    {
        Pelicula pelicula;
        Actor actor;
        public PeliculaActor(Pelicula pelicula, Actor actor)
        {
            this.pelicula = pelicula;
            this.actor = actor;
        }
        public Pelicula GetPelicula()
        {
            return pelicula;
        }
        public Actor GetActor()
        {
            return actor;
        }
    }
}
