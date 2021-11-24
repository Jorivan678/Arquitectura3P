using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Patrón_Façade
{
    public class Cliente
    {
        private string nombre;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return nombre; }
        }
    }
}
