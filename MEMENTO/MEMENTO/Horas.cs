using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMENTO
{
     class Horas
    {
        private DateTime fecha;

        public Memento guardarFecha()
        {
            return new Memento(this.fecha);
        }

        public void restaurarFecha(Memento memento)
        {
            this.fecha = memento.DameFecha();
        }

        public DateTime dameFecha()
        {
            return fecha;
        }

        public void asignarFecha(DateTime f)
        {
            this.fecha = f;
        }

    }
}
