using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
     class CFlyweightFactory
    {
        private List<interFlyweight> flyweights = new List<interFlyweight>();
        private int conteo = 0;

        public int Conteo { get => conteo; set => conteo = value; }

        public int Adiciona(string pNombre)
        {
            //verificar si ya existe
            bool existe = false;
            foreach(interFlyweight f in flyweights)
            {
                if (f.ObtenNombre() == pNombre)
                    existe = true;
            }
            if (existe)
            {
                Console.WriteLine("El objeto ya existe");
                return -1;
            }
            else
            {
                CReceta miReceta = new CReceta();
                miReceta.ColocaNombre(pNombre);
                flyweights.Add(miReceta);
                conteo = flyweights.Count;
                return conteo - 1;
            }
        }
        public interFlyweight this[int index]
        {
            get { return flyweights[index]; }
        }
    }
}
