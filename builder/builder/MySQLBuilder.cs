using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class MySQLBuilder : ConexionBuilder
    {
        public MySQLBuilder()
        {
            conexion = new CadenaConexion();
        }
        public override void asignarServidor()
        {
            conexion.Servidor = "Servidor MySQL";
        }
        public override void asignarBasedatos()
        {
            conexion.NombreBaseDatos = "Nombre instgancia MySQL";
        }
        public override void asignarUsuario()
        {
            conexion.Usuario = "usuario MySQL";
        }
        public override void asignarPassword()
        {
            conexion.Password = "password usuario Mysql";
        }
    }
}
