using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{ 
    public class CadenaConexion
    {
        public string Servidor { get; set; }
        public string NombreBaseDatos { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }

        public CadenaConexion()
        {

        }
        public CadenaConexion(string servidor, string baseDatos, string usuario, string pass) : this()
        {
           Servidor = servidor;
            NombreBaseDatos = baseDatos;
            Usuario = usuario;
            Password = pass;
        }
    }
}
