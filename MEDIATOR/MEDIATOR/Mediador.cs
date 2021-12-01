using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIATOR
{
     class Mediador
    {
        public delegate void DEnvio(string emisor, string mensaje);
        DEnvio enviarMensaje;

        public void Suscribir(DEnvio metodo)
        {
            enviarMensaje += metodo;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("---Suscrito");
        }

        public void Enviar(string emisor, string mensaje)
        {
            if (mensaje.Contains("palabra antisonante"))
                mensaje = mensaje.Replace("palabra antisonante", "*******");

            enviarMensaje(emisor, mensaje);
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.WriteLine("--Mensaje enviado--");
        }

        public void Bloqueo(DEnvio metodo)
        {
            enviarMensaje -= metodo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--Bloqueo :v ---");
        }
    }
}
