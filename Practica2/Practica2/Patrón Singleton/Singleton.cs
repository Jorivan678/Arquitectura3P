using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Singleton
{
    public sealed class Singleton
    {
        Singleton() { }
        private static readonly object blocker = new object();

        private static Singleton instancia = null;

        public static Singleton Instancia
        {
            get
            {
                lock (blocker)
                    {
                        if (instancia == null)
                        {
                            instancia = new Singleton();
                        }
                        return instancia;
                    }
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("El código de la clase Singleton ha sido llamado");
        }
    }
}
