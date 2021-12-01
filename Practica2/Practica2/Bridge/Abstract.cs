using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Bridge
{
    public class Abstract
    {
        protected Implementador implementador;

        public Implementador Implementador
        {
            set { implementador = value; }
        }

        public virtual void Operador()
        {
            implementador.Operador();
        }
    }
}
