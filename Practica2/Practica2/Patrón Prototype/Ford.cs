using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Prototype
{
    public class Ford : Carro
    {
        public Ford(string m)
        {
            Modelo = m;
        }

        public override Carro Clone()
        {
            return (Ford)this.MemberwiseClone();
        }
    }
}
