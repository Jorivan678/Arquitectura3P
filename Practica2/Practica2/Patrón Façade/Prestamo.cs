using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Façade
{
    public class Prestamo
    {
        public bool NoTieneBloqueoDePrestamos(Cliente c)
        {
            Console.WriteLine("Revisión de préstamos para " + c.Nombre);
            return true;
        }
    }
}
