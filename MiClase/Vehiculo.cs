using System;
using System.Collections.Generic;
using System.Text;

namespace MiClase
{
    class Vehiculo
    {
        //propiedades
        public string marca;
        public string placa;
        public int modelo;
        //metodos
        public Vehiculo(string marca,string placa, int modelo)
        {
            this.marca = marca;
            this.placa = placa;
            this.modelo = modelo;
        }

    }
}
