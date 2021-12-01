using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public class Conexion
    {
        private ConexionBuilder conexionBuilder;
        public void nuevaConexion(ConexionBuilder conBuilder)
        {
            conexionBuilder = conBuilder;
        }
        public void crearCadenaConexion()
        {
            conexionBuilder.asignarServidor();
            conexionBuilder.asignarBasedatos();
            conexionBuilder.asignarPassword();
            conexionBuilder.asignarUsuario();
        }
        public CadenaConexion ConexionLista
        {
            get { return conexionBuilder.dameCadenaConexion();}
        }
    }
}
