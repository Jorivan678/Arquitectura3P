using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMENTO
{
     class Memento
    {
        private DateTime fecha;
        public Memento(DateTime tiempo)
        {
            this.fecha = tiempo;
        }
        public DateTime DameFecha()
        {
            return this.fecha;
        }
    }
}
