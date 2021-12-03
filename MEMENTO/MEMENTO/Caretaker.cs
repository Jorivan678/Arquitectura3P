using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMENTO
{
     class Caretaker
    {
        private ArrayList fechas = new ArrayList();

        public void agregarMemento(Memento m) { fechas.Add(m); }
        public Memento dameMemento(int index) { return((Memento)fechas[index]); }
    }
}
