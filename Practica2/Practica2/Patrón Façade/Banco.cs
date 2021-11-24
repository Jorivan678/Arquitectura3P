using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Façade
{
    public class Banco
    {
        public bool TieneSuficientesCreditos(Cliente c, int monto)
        {
            Console.WriteLine("Revisión de banco para " + c.Nombre);
            return true;
        }
    }
}
