using System;

namespace MiClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo miVehiculo= new Vehiculo("Kia","KIC45",2016);
            //miVehiculo.marca = "Toyota";
            Console.WriteLine("Marca del vehiculo : " + miVehiculo.marca);
            Console.WriteLine("Placa : "+miVehiculo.placa);
            Console.WriteLine("Modelo : "+miVehiculo.modelo);
        }
    }
}
