using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIATOR
{
    class ColegaA:IColega
   {
        private Mediador mediador;
        private string nombre;

        public ColegaA(string pNombre, Mediador pMediador)
        {
            nombre = pNombre;

            mediador = pMediador;

            mediador.Suscribir(Recibir);
        }
        public void Recibir(string emisor, string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Soy {0}, recibi de {1}: {2}", nombre, emisor, mensaje);
        }
        public void Enviar(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Soy {0}, envio:{1}", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }
    
    }
}
