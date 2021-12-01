using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Bridge
{
    public class Concret_B : Implementador
    {
        public override void Operador()
        {
            Console.WriteLine("Operacion Concret_B");
        }
    }
}
