using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Adapter
{
    public class Destino
    {
        public virtual void Request()
        {
            Console.WriteLine("Solicitud de destino llamada() ");
        }
    }
}
