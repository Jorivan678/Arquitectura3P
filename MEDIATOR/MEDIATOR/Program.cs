using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediador miMediador = new Mediador();

            ColegaA luis = new ColegaA("Luis", miMediador);
            ColegaA Sofia = new ColegaA("Sofia", miMediador);

            ColegaB Ramon = new ColegaB("Ramon", miMediador);

            luis.Enviar("Saludos a todos");
            Sofia.Enviar("¿que hacen?");
            Ramon.Enviar("Haciendo las tareas de arquitectura");
            Console.WriteLine();

            Console.WriteLine("****Verificamos censura **");
            Sofia.Enviar("las palabras antisonantes no van");
            Console.WriteLine();

            miMediador.Bloqueo(Sofia.Recibir);
            luis.Enviar("Vean las noticias");
            Console.WriteLine();

            miMediador.Suscribir(Sofia.Recibir);
            Ramon.Enviar("odio mi vida");
            Console.WriteLine();

        }
    }
}
