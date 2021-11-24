using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Façade
{
    public class Credito
    {
        public bool TieneBuenCredito(Cliente c)
        {
            Console.WriteLine("Revisión de crédito para " + c.Nombre);
            return true;
        }
    }
}
