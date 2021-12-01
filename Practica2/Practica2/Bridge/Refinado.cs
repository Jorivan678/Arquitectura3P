using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Bridge
{
    public class Refinado : Abstract
    {
        public override void Operador()
        {
            implementador.Operador();
        }
    }
}
