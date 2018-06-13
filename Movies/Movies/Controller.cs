using System;
using System.Collections.Generic;

namespace Movies
{
    class Controller
    {
        Form1 buscador;
        DataBase dataBase = new DataBase();
        Form1 searcher;
        public Controller()
        {
            searcher.OnSearch += Searcher_OnSearch;

        }

        public void Searcher_OnSearch(object sender, ARGS e)
        {
            e.texto = searcher.GetTexto();
            if(e.texto.Length>=3)
            {

            }




        }

        //Metodo que compara strings, t1 es el string que se extrae del buscador
        public bool Comparar(string t1, string t2)
        {
            int l1 = t1.Length;
            int l2 = t2.Length;
            bool parecido = false;
            int comparer;
            if (l1 == l2)
            {
                comparer = String.Compare(t1, t2);
                if (comparer==1){ parecido=true; }
                else { parecido = false; }
            }
            else if(l1>l2)
            { parecido=false; }

            else if(l2>l1)
            {
                int dif = l2-l1;
                int i = dif;
                int ii = 0;
                int counter = Convert.ToInt32(dif);
                List<int> coincidencias=new List<int>();
                while (i>=0)
                {
                    comparer = String.Compare(t1,0, t2,ii,l1);
                    coincidencias.Add(comparer);
                    foreach( int c in coincidencias)
                    {
                        if (c == 0)//si alguna de las comparaciones retorna 0, es porque nuestro string t1 se parece o se encuentra dentro del string t2
                        {
                            parecido =true;
                            break;
                        }
                        else { parecido = false; }
                       
                    }
                    if(i==0)
                    { break; }

                }
            }
            return parecido;

        }
        public void CargarDB(DataBase dataBase)
        {
            foreach(Pelicula p in dataBase.GetPeliculas())
            {
                dataBase.dataBase.Add(p);
            }
            foreach (Director d in dataBase.GetDirectores())
            {
                dataBase.dataBase.Add(d);
            }
            foreach (Actor a in dataBase.GetActores())
            {
                dataBase.dataBase.Add(a);
            }
            foreach (Productor prod in dataBase.GetProductores())
            {
                dataBase.dataBase.Add(prod);
            }
            foreach(Estudio est in dataBase.GetEstudios())
            { dataBase.dataBase.Add(est); }

        }

    }
}
