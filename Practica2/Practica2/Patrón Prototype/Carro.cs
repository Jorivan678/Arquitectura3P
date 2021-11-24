using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Prototype
{
    public abstract class Carro
    {
        public string Modelo { get; set; }
        public double Precio { get; set; }
        public static double SetPrecio()
        {
            double precio = 0;
            Random r = new Random();
            double p = r.Next(200000, 1000000);
            precio = p;
            return precio;
        }
        public abstract Carro Clone();
    }
}
