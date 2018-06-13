using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class ARGS: EventArgs
    {
        public Pelicula pelicula { get; set; };
            public Director director { get; set; };
            public Actor actor { get; set; };
            public  Productor productor { get; set; };
        public Estudio estudio { get; set; };
    }
}
