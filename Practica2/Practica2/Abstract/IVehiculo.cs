using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    public interface IVehiculo
    {
        Vehículo Crea();

        IVehiculo SetModelo(string modelo);

        IVehiculo SetMarca(string marca);

        IVehiculo SetTipo(string tipo);
    }
}
