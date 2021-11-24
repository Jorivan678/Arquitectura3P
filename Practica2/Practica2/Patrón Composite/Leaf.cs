using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Composite
{
    public class Leaf : Component
    {
        // Constructor
        public Leaf(string name)
            : base(name)
        {
        }
        public override void Add(Component c)
        {
            Console.WriteLine("No se puede agregar a una hoja");
        }
        public override void Remove(Component c)
        {
            Console.WriteLine("No se puede remover de una hoja");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
