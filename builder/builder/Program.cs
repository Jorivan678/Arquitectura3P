using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var conexion = new Conexion();

            //crear Cadena de conexion a SQL SERVER
            conexion.nuevaConexion(new SqlServerBuilder());
            conexion.crearCadenaConexion();
            var conexionSQLServer = conexion.ConexionLista;

            //crear Cadena de conexion MySQL
            conexion.nuevaConexion(new MySQLBuilder());
            conexion.crearCadenaConexion();
            var conexionSQL = conexion.ConexionLista;

            //crear conexion ORACLE
            conexion.nuevaConexion(new OracleBuilder());
            conexion.crearCadenaConexion();
            var conexionOracle = conexion.ConexionLista;
        }
    }
}