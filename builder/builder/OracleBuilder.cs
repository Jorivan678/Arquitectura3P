using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class OracleBuilder : ConexionBuilder
    {
        public OracleBuilder()
        {
            conexion = new CadenaConexion();
        }
        public override void asignarServidor()
        {
            conexion.Servidor = "Servidor Oracle";
        }
        public override void asignarBasedatos()
        {
            conexion.NombreBaseDatos = "Nombre instgancia Oracle";
        }
        public override void asignarUsuario()
        {
            conexion.Usuario = "usuario Oracle";
        }
        public override void asignarPassword()
        {
            conexion.Password = "password usuario Oracle";
        }
    }
}
