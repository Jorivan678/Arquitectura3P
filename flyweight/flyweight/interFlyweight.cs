using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight
{
    interface interFlyweight
    {
        void ColocaNombre(string pNombre);
        void CalculaCosto();
        void Mostrar();
        string ObtenNombre(); 
    }
}
