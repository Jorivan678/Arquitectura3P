using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
     class EstadoCalentando: IEstado
    {
        Caldera miCaldera;

        public EstadoCalentando(Caldera pCaldera)
        {
            miCaldera = pCaldera;
        }

        public void Trabajar()
        {
            if(miCaldera.Combustible>0)
            {
                Console.WriteLine("Estamos calentado el agua jajaj");
                miCaldera.Combustible -= 3;
                miCaldera.Temperatura += 10;
            }
            //Verificar si hubo cambio de estado
            if (miCaldera.Temperatura > 100)
                miCaldera.ColocarEstado(miCaldera.Alarma);
            else if (miCaldera.Temperatura > 80)
                miCaldera.ColocarEstado(miCaldera.Espera);
            if (miCaldera.Combustible <= 0)
                miCaldera.ColocarEstado(miCaldera.Espera);
        }
        public void CortarFuego()
        {
            Console.WriteLine("Cortamos Fuego");
            miCaldera.ColocarEstado(miCaldera.Espera);
        }

        public void PonerCombustible()
        {
            Console.WriteLine("No echar combustible cuando este prendida");
        }

        public void ForzarFuego()
        {
            Console.WriteLine("El fuego ya se prendio");
        }

        public override string ToString()
        {
            return string.Format("Calentando-> temp {0} comb {1}", miCaldera.Temperatura, miCaldera.Combustible);

        }
    }
}
