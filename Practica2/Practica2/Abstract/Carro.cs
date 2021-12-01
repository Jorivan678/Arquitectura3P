using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    public class Carro : IVehiculo
    {
        Vehículo vehículo;

        public Carro()
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
            vehículo.Tipo = "Carro";
            return this;
        }
    }
}
