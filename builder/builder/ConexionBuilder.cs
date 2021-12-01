using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public abstract class ConexionBuilder
    {
        protected CadenaConexion conexion;
        public CadenaConexion dameCadenaConexion() { return conexion; }
        public virtual void asignarServidor()
        { }
        public virtual void asignarBasedatos() 
        { }
        public virtual void asignarUsuario()
        { }
        public virtual void asignarPassword()
        { }
    }
}
