using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    public class Avión : IVehiculo
    {
        Vehículo vehículo;

        public Avión()
        {
            vehículo = new Vehículo();
        }

        public Vehículo Crea()
        {
            return vehículo;
        }

        public IVehiculo SetMarca(string marca)
        {
            vehículo.Marca = marca;
            return this;
        }

        public IVehiculo SetModelo(string modelo)
        {
            vehículo.Modelo = modelo;
            return this;
        }

        public IVehiculo SetTipo(string tipo)
        {
            vehículo.Tipo = "Avión";
            return this;
        }
    }
}
