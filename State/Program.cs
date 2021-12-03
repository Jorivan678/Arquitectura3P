using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Caldera miCaldera = new Caldera();

            string opcion;
            do
            {
                Console.WriteLine("1- Cortar fuego, 2- Pobner combustioblke, 3-Forzar fuego, 4- Salir");
                opcion = Console.ReadLine();

                miCaldera.Trabajar();

                if (opcion == "1")
                    miCaldera.CortarFuego();
                if (opcion == "2")
                    miCaldera.PonerCombustible();
                if (opcion == "3")
                    miCaldera.ForzarFuego();

                Console.WriteLine(miCaldera);
            } while (opcion != "4");
        }
    }
}
