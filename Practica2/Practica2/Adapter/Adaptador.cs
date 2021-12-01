using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Adapter
{
    public class Adaptador : Destino
    {
        private Adaptado adap = new Adaptado();

        public override void Request()
        {
            adap.SpecificRequest();
        }
    }
}
