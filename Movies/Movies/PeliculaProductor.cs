using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies 
{
    [Serializable]
    class PeliculaProductor
    {
        Pelicula pelicula;
        Productor productor;
        public PeliculaProductor(Pelicula pelicula, Productor productor)
        {
            this.pelicula = pelicula;
            this.productor = productor;
        }
    }
}
