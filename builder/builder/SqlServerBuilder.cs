using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class SqlServerBuilder : ConexionBuilder
    {
        public SqlServerBuilder()
        {
            conexion = new CadenaConexion();
        }
        public override void asignarServidor()
        {
            conexion.Servidor = "Servidor SQLSERVER";
        }
        public override void asignarBasedatos()
        {
            conexion.NombreBaseDatos = "Nombre instgancia SQLSERVER";
        }
        public override void asignarUsuario()
        {
            conexion.Usuario = "usuario SQLSERVER";
        }
        public override void asignarPassword()
        {
            conexion.Password = "password usuario SQLSERVER";
        }
    }
}
