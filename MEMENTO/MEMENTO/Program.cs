using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MEMENTO 
{
    class Program
    {
        static void Main(string[] args)
        {
            Caretaker caretaker = new Caretaker();
            Horas c1 = new Horas();
            c1.asignarFecha(DateTime.Now);

            System.Threading.Thread.Sleep(5000);

            Horas c2 = new Horas();
            c2.asignarFecha(DateTime.Now);

            Memento m1 = c1.guardarFecha();
            caretaker.agregarMemento(m1);
            caretaker.agregarMemento(c2.guardarFecha());

            Memento memento1 = caretaker.dameMemento(0);
            Memento memento2 = caretaker.dameMemento(1);
            DateTime f1 = memento1.DameFecha();
            DateTime f2 = memento2.DameFecha();

            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());
            Console.ReadLine();

        }
    }
}