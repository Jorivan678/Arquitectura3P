using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Prototype
{
    public class BMW : Carro
    {
        public BMW(string m)
        {
            Modelo = m;
        }

        public override Carro Clone()
        {
            return (BMW)this.MemberwiseClone();
        }
    }
}
