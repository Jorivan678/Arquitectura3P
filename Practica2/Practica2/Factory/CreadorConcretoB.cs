using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Factory
{
    class CreadorConcretoB : Creador
    {
        public override Producto FactoryMethod()
        {
            return new ProductoConcretoB();
        }
    }
}
