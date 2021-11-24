using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Façade
{
    public class Hipoteca
    {
        Banco banco = new Banco();
        Prestamo prestamo = new Prestamo();
        Credito credito = new Credito();

        public bool EsElegible(Cliente c, int monto)
        {
            Console.WriteLine("{0} aplica para {1:C} de préstamo\n", c.Nombre, monto);

            bool elegible = true;

            //Revisa la solvencia del solicitante

            if(!banco.TieneSuficientesCreditos(c, monto))
            {
                elegible = false;
            }
            else if (!prestamo.NoTieneBloqueoDePrestamos(c))
            {
                elegible = false;
            }
            else if (!credito.TieneBuenCredito(c))
            {
                elegible = false;
            }

            return elegible;
        }
    }
}
