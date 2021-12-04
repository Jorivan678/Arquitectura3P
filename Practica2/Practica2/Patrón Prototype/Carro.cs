using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Prototype
{
    public abstract class Carro
    {
        public string Modelo { get; set; }
        public int Precio { get; set; }
        public static int SetPrecio()
        {
            int precio = 0;
            Random r = new Random();
            int p = r.Next(200000, 1000000);
            precio = p;
            return precio;
        }
        public abstract Carro Clone();
    }
}
